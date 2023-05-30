using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace credite
{
    public partial class FrmMeniu : Form
    {
        List<Credit> listaCredite = new List<Credit>();
        List<Client> listaClienti = new List<Client>();
        public FrmMeniu()
        {
            InitializeComponent();
            //deserializeaza();
            citesteDinDb(listaCredite, listaClienti);
            
            clientBindingSource.DataSource = new Client();
            
            foreach (Credit credit in listaCredite)
                cbCred.Items.Add(credit);

            foreach (Client c in listaClienti)
                lista.Text += c + "\n";

            TrackBar trackBar = new TrackBar();
            trackBar.Minimum = 8; // Dimensiunea minimă a fontului
            trackBar.Maximum = 24; // Dimensiunea maximă a fontului
            trackBar.Value = 12; // Dimensiunea inițială a fontului
            trackBar.TickStyle = TickStyle.BottomRight; // Stilul marcărilor pentru control (opțional)
            trackBar.TickFrequency = 2; // Frecvența la care sunt afișate marcările (opțional)
            trackBar.ValueChanged += TrackBar_ValueChanged; // Evenimentul declanșat atunci când valoarea controlului se schimbă
            trackBar.Size = new Size(lista.Width, 50);
            trackBar.Location = new Point(lista.Left, lista.Top - trackBar.Height - 10);

            Controls.Add(trackBar);

            
        }

        public void AduCreditu(Credit credit)
        {
            cbCred.Items.Add(credit);
            listaCredite.Add(credit);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmCredite frm = new FrmCredite())
            {
                frm.ShowDialog(this);
            }
        }

        private void btAdaugaClient_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            Client client = clientBindingSource.Current as Client;
            client.credit = (Credit)cbCred.SelectedItem;
            if (client != null)
            {
                ValidationContext context = new ValidationContext(client, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(client, context, errors, true))
                {
                    lista.BackColor = Color.Red;
                    lista.Text = "";
                    foreach (ValidationResult result in errors)
                    {
                        lista.Text += result.ErrorMessage + "\n";
                    }
                }
                else
                {
                    listaClienti.Add(client);
                    lista.Text = "";
                    lista.BackColor = SystemColors.Control;

                    salveazaClientu(client);

                    foreach (Client c in listaClienti)
                        lista.Text += c + "\n";
                    cbCred.Text = "";
                    tbCnp.Clear();
                    tbEmail.Clear();
                    tbNume.Clear();
                    tbPrenume.Clear();

                    clientBindingSource.DataSource = new Client();
                }
            }
        }

        private void salveazaInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(lista.Text);
                sw.Close();
            }
        }

        private void restaurareDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                lista.Text = sr.ReadToEnd();
                sr.Close();
            }
            cbCred.Text = "";
            tbCnp.Clear();
            tbEmail.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
        }
        private void deserializeaza()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsCredite = new FileStream("fisierCredite.dat", FileMode.Open,
                FileAccess.Read);
            FileStream fsClienti = new FileStream("fisierClienti.dat", FileMode.Open,
                FileAccess.Read);
            listaCredite = (List<Credit>)bf.Deserialize(fsCredite);
            listaClienti = (List<Client>)bf.Deserialize(fsClienti);

            fsCredite.Close();
            fsClienti.Close();
        }

        public void serializeaza()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsCredite = new FileStream("fisierCredite.dat", FileMode.Create,
                FileAccess.Write);
            FileStream fsClienti = new FileStream("fisierClienti.dat", FileMode.Create,
                FileAccess.Write);
            bf.Serialize(fsCredite, listaCredite);
            bf.Serialize(fsClienti, listaClienti);
            fsCredite.Close();
            fsClienti.Close();
        }

        private void FrmMeniu_FormClosing(object sender, FormClosingEventArgs e)
        {
            serializeaza();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "";
            foreach (Client c in listaClienti)
                text += c + "\n";
            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;
            PointF location = new PointF(100, 100);
            e.Graphics.DrawString(text, font, brush, location);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            int selectedValue = trackBar.Value;

            lista.Font = new Font(lista.Font.FontFamily, selectedValue);
        }

        public void salveazaClientu(Client client)
        {
            using (OracleConnection connection = new OracleConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO CLIENT_C (clientId, cnp, nume, prenume, email, creditId) " +
                               "VALUES (client_sequence.nextval, :cnp, :nume, :prenume, :email, :creditId)";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":cnp", OracleDbType.Varchar2).Value = client.cnp;
                    command.Parameters.Add(":nume", OracleDbType.Varchar2).Value = client.nume;
                    command.Parameters.Add(":prenume", OracleDbType.Varchar2).Value = client.prenume;
                    command.Parameters.Add(":email", OracleDbType.Varchar2).Value = client.email;
                    command.Parameters.Add(":creditId", OracleDbType.Int32).Value = client.credit.creditId;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void citesteDinDb(List<Credit> listaCredite, List<Client> listaClienti)
        {
            using (OracleConnection connection = new OracleConnection(Program.ConnectionString))
            {
                connection.Open();

                // Citire credite
                string creditQuery = "SELECT creditId, rataDobanda, durata, valoare FROM CREDIT_C";
                using (OracleCommand creditCommand = new OracleCommand(creditQuery, connection))
                {
                    using (OracleDataReader creditReader = creditCommand.ExecuteReader())
                    {
                        while (creditReader.Read())
                        {
                            Credit credit = new Credit();
                            credit.creditId = creditReader.GetInt32(0);
                            credit.rataDobanda = creditReader.GetInt32(1);
                            credit.durata = creditReader.GetInt32(2);
                            credit.valoare = creditReader.GetInt32(3);

                            listaCredite.Add(credit);
                        }
                    }
                }

                // Citire clienți
                string clientQuery = "SELECT cnp, nume, prenume, email, creditId FROM CLIENT_C";
                using (OracleCommand clientCommand = new OracleCommand(clientQuery, connection))
                {
                    using (OracleDataReader clientReader = clientCommand.ExecuteReader())
                    {
                        while (clientReader.Read())
                        {
                            Client client = new Client();
                            client.cnp = clientReader.GetString(0);
                            client.nume = clientReader.GetString(1);
                            client.prenume = clientReader.GetString(2);
                            client.email = clientReader.GetString(3);
                            client.credit = listaCredite.FirstOrDefault(credit => credit.creditId == clientReader.GetInt32(4));

                            listaClienti.Add(client);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
