using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace ScorpControlTwo
{
    public partial class Form1 : Form
    {

        private SoundPlayer _soundPlayer;
        private int i = 0;
        public string motoristaAux = "--";


        public Form1()
        {
            InitializeComponent();

            //lbl_desenvolvedor.Text = "Denvolvido pela TI Fruteb S/A";

            RetornaDados();
            AlimentaGrid();
            timer1.Enabled = true;
            LblHoraChamada.Text = "Chamado em: " + DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            _soundPlayer = new SoundPlayer("audio//alarme.wav");

            i++;
            LblNomeMotorista.ForeColor = LblNomeMotorista.ForeColor == Color.Red ? Color.White : Color.Red;
            LblHoraAtual.Text = "Dias Dávila - " + DateTime.Now.ToString();

            if (i > 5)
            {
                _soundPlayer.Stop();
            }
            else
            {
                if (LblNomeMotorista.Text != "--")
                {
                   //_soundPlayer.Play();
                }
                else
                {
                    _soundPlayer.Stop();
                }
            }

            if (i == 15)
            {
                RetornaDados();
                AlimentaGrid();
                i = 0;
            }
        }

        public void RetornaDados()
        {
            LblNomeMotorista.Text = motoristaAux;

            bool result = false;
            string StringDeConexao = @"data source=192.168.1.17\BANCOSERIGY; User Id=sa; Password=serigy@2020;  Initial Catalog=FrutebDesk";

            //string StringDeConexao = @"data source=den1.mssql8.gear.host; User Id=mastersolution; Password=Qi262t?g7AG_;  Initial Catalog=mastersolution";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                try
                {
                    SqlCommand cmd = new SqlCommand("select nome_motorista, placa, data_entrada, data_chamado, informacao_chamado from atendimento where chamado = '1';", cn);

                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;

                    DataTable dt = new DataTable();
                    dt.Load(dados);

                    DataRow[] oDataRow = dt.Select();
                    foreach (DataRow dr in oDataRow)
                    {
                        motoristaAux = dr[0].ToString();
                        LblNomeMotorista.Text = motoristaAux;
                        LblPlaca.Text = "Placa:     " + dr[1].ToString();
                        LblDataEntrada.Text = "Entrada: " + dr[2].ToString();
                        LblHoraChamada.Text = "Hora Chamada: " + dr[3].ToString();
                        LblDirigirFat.Text = dr[4].ToString();
                    }

                    cn.Close();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void RetornaUltimosChamados()
        {
            int i = 0;           
            bool result = false;
            string StringDeConexao = @"data source=192.168.1.17\BANCOSERIGY; User Id=sa; Password=serigy@2020;  Initial Catalog=FrutebDesk";


            //string StringDeConexao = @"data source=den1.mssql8.gear.host; User Id=mastersolution; Password=Qi262t?g7AG_;  Initial Catalog=mastersolution";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                try
                {
                    // SqlCommand cmd = new SqlCommand("select nome_motorista, placa, data_chamado from atendimento where chamado = '0';", cn);
                    SqlCommand cmd = new SqlCommand("select top 5 nome_motorista, placa, data_chamado, informacao_chamado from atendimento order by data_chamado desc ;", cn);

                    /*SELECT top 15 * FROM tabela ORDER By id DESC*/

                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;

                    DataTable dt = new DataTable();
                    dt.Load(dados);

                    DataRow[] oDataRow = dt.Select();
                    foreach (DataRow dr in oDataRow)
                    {
                        i++;

                        if (i == 1)
                        {
                            LblNome5.Text = dr[0].ToString();
                            LblPlaca5.Text = dr[1].ToString();
                            LblHora5.Text = dr[2].ToString();
                        }
                        else if (i == 2)
                        {
                            LblNome4.Text = dr[0].ToString();
                            LblPlaca4.Text = dr[1].ToString();
                            LblHora4.Text = dr[2].ToString();
                        }
                        else if (i == 3)
                        {
                            LblNome3.Text = dr[0].ToString();
                            LblPlaca3.Text = dr[1].ToString();
                            LblHora3.Text = dr[2].ToString();
                        }
                        else if (i == 4)
                        {
                            LblNome2.Text = dr[0].ToString();
                            LblPlaca2.Text = dr[1].ToString();
                            LblHora2.Text = dr[2].ToString();
                        }
                        else if (i == 5)
                        {
                            LblNome1.Text = dr[0].ToString();
                            LblPlaca1.Text = dr[1].ToString();
                            LblHora1.Text = dr[2].ToString();
                        }

                        


                        /*  for (int i = 0; i < 6; i++)
                          {
                              LblNome5.Text = dr[0].ToString();
                              LblPlaca5.Text = dr[1].ToString();
                              LblHora5.Text = dr[2].ToString();
                          }*/

                        /* motoristaAux = dr[0].ToString();
                         LblNomeMotorista.Text = motoristaAux;
                         LblPlaca.Text = "Placa:     " + dr[1].ToString();
                         LblDataEntrada.Text = "Entrada: " + dr[2].ToString();
                         LblHoraChamada.Text = "Hora Chamada: " + dr[3].ToString();*/

                    }

                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {

                    cn.Close();
                }
            }
        }

        public void AlimentaGrid()
        {
            string connString = @"data source=192.168.1.17\BANCOSERIGY; User Id=sa; Password=serigy@2020;  Initial Catalog=FrutebDesk";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select TOP 10 nome_motorista as MOTORISTA, placa AS PLACA, data_chamado AS HORA_CHAMADA, informacao_chamado as LOCAL from atendimento WHERE data_chamado <> '' order by data_chamado desc", con);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            GridChamados.DataSource = dt;
            //GridChamados.DataBindings;
            con.Close();
        }       
    }
}
