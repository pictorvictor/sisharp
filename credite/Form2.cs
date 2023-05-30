using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credite
{
    public partial class FrmCredite : Form
    {
        Credit creditForm;
        private PictureBox chartPictureBox;
        public FrmCredite()
        {
            InitializeComponent();
            creditBindingSource.DataSource = new Credit();


            // Initializează și configurează PictureBox-ul pentru afișarea graficului
            chartPictureBox = new PictureBox();
            chartPictureBox.Size = new Size(400, 300);
            chartPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; // Adaugă ancorarea în colțul din dreapta jos
            chartPictureBox.Location = new Point(this.ClientSize.Width - chartPictureBox.Width - 20, this.ClientSize.Height - chartPictureBox.Height - 20); // Plasează PictureBox-ul în colțul dorit
            chartPictureBox.Paint += ChartPictureBox_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creditBindingSource.EndEdit();
            Credit credit = creditBindingSource.Current as Credit;
            if (credit != null)
            {
                ValidationContext context = new ValidationContext(credit, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(credit, context, errors, true))
                {
                    lblAfisare.BackColor = Color.Red;
                    lblAfisare.Text = "";
                    foreach (ValidationResult result in errors)
                    {
                        //MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblAfisare.Text += result.ErrorMessage + "\n";
                    }
                }
                else
                {
                    lblAfisare.Text = "";
                    lblAfisare.BackColor = Color.Lime;
                    FrmMeniu meniu = (FrmMeniu)this.Owner;

                    credit.creditId = salveazaCreditu(credit);

                    meniu.AduCreditu(credit);
                    Controls.Remove(chartPictureBox);
                    creditForm = credit;
                    creditBindingSource.DataSource = new Credit();
                    
                    Controls.Add(chartPictureBox);
                }
            }
        }

        private void ChartPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int durata = creditForm.durata;
            int dobanda = creditForm.rataDobanda;
            int valoare = creditForm.valoare;

            int durataRelativa = (int)Math.Ceiling((decimal)durata / 30 * 100);
            int dobandaRelativa = (int)Math.Ceiling((decimal)dobanda / 25 * 100);
            int valoareRelativa = (int)Math.Ceiling((decimal)valoare / 100000 * 100);

            int[] data = { durataRelativa, dobandaRelativa, valoareRelativa  }; // relative la valorile maxime pe care le pot lua
            int maxValue = data.Max();
  
            string[] labels = { "durata", "dobanda", "valoare" };

            int chartWidth = chartPictureBox.Width - 40;
            int chartHeight = chartPictureBox.Height - 40;
            int barWidth = chartWidth / data.Length;
            int scaleFactor = chartHeight / maxValue;

            for (int i = 0; i < data.Length; i++)
            {
                int barHeight = data[i] * scaleFactor;
                int x = 20 + i * barWidth;
                int y = chartPictureBox.Height - barHeight - 20;
                g.FillRectangle(Brushes.Blue, x, y, barWidth, barHeight);
                g.DrawString(labels[i], Font, Brushes.Black, x, chartPictureBox.Height - 20);
            }
        }

        private int salveazaCreditu(Credit credit)
        {
            int generatedCreditId = 0;

            using (OracleConnection connection = new OracleConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO CREDIT_C (creditId, rataDobanda, durata, valoare) " +
                               "VALUES (credit_sequence.nextval, :rataDobanda, :durata, :valoare) " +
                               "RETURNING creditId INTO :generatedCreditId";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":rataDobanda", OracleDbType.Int32).Value = credit.rataDobanda;
                    command.Parameters.Add(":durata", OracleDbType.Int32).Value = credit.durata;
                    command.Parameters.Add(":valoare", OracleDbType.Int32).Value = credit.valoare;

                    OracleParameter generatedCreditIdParameter = new OracleParameter(":generatedCreditId", OracleDbType.Int32);
                    generatedCreditIdParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(generatedCreditIdParameter);

                    command.ExecuteNonQuery();

                    generatedCreditId = generatedCreditIdParameter.Value is OracleDecimal oracleDecimal ? oracleDecimal.ToInt32(): 0;

                }

                connection.Close();
            }

            return generatedCreditId;
        }

    }
}
