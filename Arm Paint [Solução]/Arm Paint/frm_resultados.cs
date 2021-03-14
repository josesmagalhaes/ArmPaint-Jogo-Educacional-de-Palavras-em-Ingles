using sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arm_Paint
{
    public partial class frm_resultados : Form
    {
        SqlConnection con = new SqlConnection(("Data Source=.\\SQLEXPRESS;Initial Catalog=sistema_arm_paint;Integrated Security=True"));
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_resultados()
        {
            InitializeComponent();
            comando.Connection = con;
            this.tbpontosBindingSource.DataSource = DataContextFactory.DataContext.tb_pontos;
        }



        private void frm_resultados_Load(object sender, EventArgs e)
        {


        }
    }
    
}
