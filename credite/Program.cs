using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace credite
{

    internal class Program
    {
        public static string ConnectionString { get; private set; }
        [STAThread]
        static void Main(string[] args)
        {
            ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=hostname)(PORT=port))(CONNECT_DATA=(SERVICE_NAME=service_name)));User Id=user_id;Password=pass;";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMeniu());
        }
    }
}
