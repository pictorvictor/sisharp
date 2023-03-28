using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace credite
{
    public partial class FrmMeniu : Form
    {
        List<Credit> listaCredite = new List<Credit>();
        List<Client> listaClienti = new List<Client>();
        public FrmMeniu()
        {
            InitializeComponent();
            clientBindingSource.DataSource = new Client();
        }

        public void AduCreditu(Credit credit)
        {
            int index = listaCredite.Count;
            cbCred.Items.Insert(index, credit);
            listaCredite.Add(credit);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmCredite frm = new FrmCredite(listaCredite))
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

        private void deserializeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsCredite = new FileStream("fisierCredite.dat", FileMode.Open,
                FileAccess.Read);
            FileStream fsClienti = new FileStream("fisierClienti.dat", FileMode.Open,
                FileAccess.Read);
            listaCredite = (List<Credit>)bf.Deserialize(fsCredite);
            listaClienti = (List<Client>)bf.Deserialize(fsClienti);
            lista.Text = "";
            lista.BackColor = SystemColors.Control;
            foreach (Client c in listaClienti)
                lista.Text += c + "\n";

            cbCred.Text = "";
            tbCnp.Clear();
            tbEmail.Clear();
            tbNume.Clear();
            tbPrenume.Clear();

            fsCredite.Close();
            fsClienti.Close();
        }

        private void serializeazaToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
