using sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arm_Paint
{
    public partial class Form1 : Form
    {
        int pontos = 0;

        public Form1()
        {
            InitializeComponent();
            comando.Connection = con;
            labelPONTOS.Text = Convert.ToString(pontos);

        }

        SqlConnection con = new SqlConnection(("Data Source=.\\SQLEXPRESS;Initial Catalog=sistema_arm_paint;Integrated Security=True"));
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        bool iniciar = false;
        bool desafio = false;


        //botões de desafios
        #region
        private void button21_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar

            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 1;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {   
            
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 2;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 3;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 4;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 5;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button25.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 6;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button30.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 7;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button29.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 8;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button28.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 9;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button27.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 10;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button26.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 11;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button40.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 12;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button39.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 13;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button38.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 14;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button37.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 15;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button36.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 16;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button35.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 17;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button34.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 18;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button33.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 19;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button32.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 20;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button31.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 21;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button60.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 22;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button59.Enabled = false;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 23;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button58.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 24;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button57.Enabled = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 25;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button56.Enabled = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 26;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button55.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 27;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button54.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 28;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button53.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 29;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button52.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 30;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button51.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 31;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button50.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 32;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button49.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 33;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button48.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 34;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button47.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 35;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button46.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 36;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button45.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 37;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button44.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 38;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button43.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 39;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button42.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //iniciar
            iniciar = true;
            timer1.Enabled = true;
            now = DateTime.Now.AddMinutes(0.6);
            label2.Text = "Atenção, o professor está desenhando...";
            //iniciar
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 40;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button41.Enabled = false;
        }
        //Botões invisíveis
        private void button80_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 41;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button80.Enabled = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 42;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button79.Enabled = false;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 43;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button78.Enabled = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 44;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button77.Enabled = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 45;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button76.Enabled = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 46;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button75.Enabled = false;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 47;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button74.Enabled = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 48;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button73.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 49;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button72.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 50;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button71.Enabled = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 51;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button70.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 52;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button69.Enabled = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 53;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button68.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 54;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button67.Enabled = false;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 55;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button66.Enabled = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 56;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button65.Enabled = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 57;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button64.Enabled = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 58;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button63.Enabled = false;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 59;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button62.Enabled = false;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            desafio = true;
            con.Open();
            comando.CommandText = "SELECT * FROM tb_palavras where sequencia = 60;";

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        button1.Text = dr[1].ToString();
                        button2.Text = dr[2].ToString();
                        button3.Text = dr[3].ToString();
                        button4.Text = dr[4].ToString();
                        button5.Text = dr[5].ToString();
                        button6.Text = dr[6].ToString();
                        button7.Text = dr[7].ToString();
                        button8.Text = dr[8].ToString();
                        button9.Text = dr[9].ToString();
                        button10.Text = dr[10].ToString();
                        button11.Text = dr[11].ToString();
                        button12.Text = dr[12].ToString();
                        button13.Text = dr[13].ToString();
                        button14.Text = dr[14].ToString();
                        button15.Text = dr[15].ToString();
                        button16.Text = dr[16].ToString();
                        button17.Text = dr[17].ToString();
                        button18.Text = dr[18].ToString();
                        button19.Text = dr[19].ToString();
                        button20.Text = dr[20].ToString();
                        labelRESPOSTA.Text = dr[41].ToString();
                        labelsequencia.Text = dr[42].ToString();
                    }

                }
            }
            con.Close();
            button61.Enabled = false;
        }
        #endregion

        //botoes de seleção e tradução
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button1.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

                con.Open();
                comando.CommandText = "SELECT traducao1 FROM tb_palavras WHERE sequencia = " + sequencia;

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        {
                            textBoxTRADUCAO.Text = dr[0].ToString();
                        }

                    }
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button2.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {
                con.Open();
                comando.CommandText = "SELECT traducao2 FROM tb_palavras WHERE sequencia = " + sequencia;

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        {
                            textBoxTRADUCAO.Text = dr[0].ToString();
                        }

                    }
                }
                con.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button3.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

                con.Open();
                comando.CommandText = "SELECT traducao3 FROM tb_palavras WHERE sequencia = " + sequencia;

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        {
                            textBoxTRADUCAO.Text = dr[0].ToString();
                        }

                    }
                }
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button4.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }else{
                
            con.Open();
            comando.CommandText = "SELECT traducao4 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button5.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }else
            {

            con.Open();
            comando.CommandText = "SELECT traducao5 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button6.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao6 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button7.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao7 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button8.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao8 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button9.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao9 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button10.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao10 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button11.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao11 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button12.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao12 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button13.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao13 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button14.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao14 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button15.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao15 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button16.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao16 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button17.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao17 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button18.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao18 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button19.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao19 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int sequencia;
            sequencia = Convert.ToInt32(labelsequencia.Text);
            labelselecionado.Text = button20.Text;

            if (iniciar == false)
            {
                MessageBox.Show("Você só pode ver a tradução após iniciar!");
            }
            else
            {

            con.Open();
            comando.CommandText = "SELECT traducao20 FROM tb_palavras WHERE sequencia = " + sequencia;

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    {
                        textBoxTRADUCAO.Text = dr[0].ToString();
                    }

                }
            }
            con.Close();
            }

        }

        #endregion

        DateTime now;
        TimeSpan diff;
        //iniciar
        private void button81_Click(object sender, EventArgs e)
        {
            if (desafio == false)
            {
                MessageBox.Show("Clique em um desafio primeiro!");
            }
            else
            {

            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            diff = DateTime.Now.Subtract(now);

            string horas = diff.Hours.ToString().Substring(1);
            string minutes = diff.Minutes.ToString().Substring(1);
            string seconds = diff.Seconds.ToString().Substring(1);

            this.labelTIME.Text = String.Format("{0:D2}{1:D2}{2:D2}", horas, minutes, seconds);

            if (labelTIME.Text == "5")
            {
                labelTIME.ForeColor = Color.Red;
            }
            if (labelTIME.Text == "4")
            {
                labelTIME.ForeColor = Color.Red;
            }
            if (labelTIME.Text == "3")
            {
                labelTIME.ForeColor = Color.Red;
            }
            if (labelTIME.Text == "2")
            {
                labelTIME.ForeColor = Color.Red;
            }
            if (labelTIME.Text == "1")
            {
                labelTIME.ForeColor = Color.Red;
            }

            bool tempo = false;

            if (labelTIME.Text == "")
            {
                timer1.Stop();
                tempo = true;
                iniciar = false;
                desafio = false;
            }
            if (tempo == true)
            {
                labelTIME.Text = "00";
                tempo = false;
                button1.Text = "Aguarde...";
                button2.Text = "Aguarde...";
                button3.Text = "Aguarde...";
                button4.Text = "Aguarde...";
                button5.Text = "Aguarde...";
                button6.Text = "Aguarde...";
                button7.Text = "Aguarde...";
                button8.Text = "Aguarde...";
                button9.Text = "Aguarde...";
                button10.Text = "Aguarde...";
                button11.Text = "Aguarde...";
                button12.Text = "Aguarde...";
                button13.Text = "Aguarde...";
                button14.Text = "Aguarde...";
                button15.Text = "Aguarde...";
                button16.Text = "Aguarde...";
                button17.Text = "Aguarde...";
                button18.Text = "Aguarde...";
                button19.Text = "Aguarde...";
                button20.Text = "Aguarde...";
                labelPONTOS.Text = Convert.ToString(pontos);
                MessageBox.Show("Tempo esgotado! A resposta era " + labelRESPOSTA.Text);
                labelsequencia.Text = "";
                labelRESPOSTA.Text = "";
                labelselecionado.Text = "";
                textBoxTRADUCAO.Text = "";
                desafio = false;
                label2.Text = "...";
                

            }

        }

        private void button82_Click(object sender, EventArgs e)
        {
            string respostaPALAVRA;
            string respostaEscolhida;
            respostaPALAVRA = labelRESPOSTA.Text;
            respostaEscolhida = labelselecionado.Text;

            if (respostaPALAVRA == respostaEscolhida)
            {
                int pontosStop = Convert.ToInt32(labelTIME.Text);
                pontos = pontos + pontosStop;
                timer1.Stop();
                labelTIME.Text = "00";
                iniciar = false;
                button1.Text = "Aguarde...";
                button2.Text = "Aguarde...";
                button3.Text = "Aguarde...";
                button4.Text = "Aguarde...";
                button5.Text = "Aguarde...";
                button6.Text = "Aguarde...";
                button7.Text = "Aguarde...";
                button8.Text = "Aguarde...";
                button9.Text = "Aguarde...";
                button10.Text = "Aguarde...";
                button11.Text = "Aguarde...";
                button12.Text = "Aguarde...";
                button13.Text = "Aguarde...";
                button14.Text = "Aguarde...";
                button15.Text = "Aguarde...";
                button16.Text = "Aguarde...";
                button17.Text = "Aguarde...";
                button18.Text = "Aguarde...";
                button19.Text = "Aguarde...";
                button20.Text = "Aguarde...";
                labelsequencia.Text = "";
                labelRESPOSTA.Text = "";
                labelselecionado.Text = "";
                textBoxTRADUCAO.Text = "";
                desafio = false;
                label2.Text = label2.Text = "";
                labelPONTOS.Text = Convert.ToString(pontos);
                MessageBox.Show("Parabéns! Você acertou!");
            }
            else
            {
                timer1.Stop();
                labelTIME.Text = "00";
                iniciar = false;
                button1.Text = "Aguarde...";
                button2.Text = "Aguarde...";
                button3.Text = "Aguarde...";
                button4.Text = "Aguarde...";
                button5.Text = "Aguarde...";
                button6.Text = "Aguarde...";
                button7.Text = "Aguarde...";
                button8.Text = "Aguarde...";
                button9.Text = "Aguarde...";
                button10.Text = "Aguarde...";
                button11.Text = "Aguarde...";
                button12.Text = "Aguarde...";
                button13.Text = "Aguarde...";
                button14.Text = "Aguarde...";
                button15.Text = "Aguarde...";
                button16.Text = "Aguarde...";
                button17.Text = "Aguarde...";
                button18.Text = "Aguarde...";
                button19.Text = "Aguarde...";
                button20.Text = "Aguarde...";
                labelPONTOS.Text = Convert.ToString(pontos);
                MessageBox.Show("Você errou! A resposta era " + labelRESPOSTA.Text);
                labelsequencia.Text = "";
                labelRESPOSTA.Text = "";
                labelselecionado.Text = "";
                textBoxTRADUCAO.Text = "";
                desafio = false;
                label2.Text = "...";

            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            string nome;
            int pontuacao;

            nome = textBox1.Text;
            pontuacao = pontos;

            con.Open();
            comando.CommandText = "INSERT INTO tb_pontos (nome,pontos) VALUES ('"+nome+"',"+pontuacao+");";
            MessageBox.Show("Seus dados foram inseridos!");

            dr = comando.ExecuteReader();

            con.Close();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            frm_resultados frm = new frm_resultados();
            frm.Show();
        }
    }
}
