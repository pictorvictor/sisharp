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

        public FrmCredite(List<Credit> listaCredite)
        {
            InitializeComponent();
            creditBindingSource.DataSource = new Credit();
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
                    meniu.AduCreditu(credit);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creditBindingSource.DataSource = new Credit();
        }
    }
}
