using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using InstagramBot.Business_Logic_Layer;

namespace InstagramBot
{
    public partial class InstagramBOT : Form
    {
        public InstagramBOT()
        {
            InitializeComponent();
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Selecione o Arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            DataSet ds = new DataSet();

            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"+
                      "Data Source='" + filePath +
                      "';Extended Properties=\"Excel 12.0;HDR=YES;\"");

            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Planilha1$]", conexao);


            da.Fill(ds);

            if (!string.IsNullOrEmpty(tbLink.Text) || string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbSenha.Text))
            {
                var bot = new BOT();

                if (Convert.ToBoolean(rb1.Checked.ToString()) != false)
                {
                    bot.Instagram(tbLink.Text, tbLogin.Text, tbSenha.Text, Convert.ToInt32(Enum.QtdPessoas.QtdPessoa.UmaPessoa),ds);
                }
                else if (Convert.ToBoolean(rb2.Checked.ToString()) != false)
                {
                    bot.Instagram(tbLink.Text, tbLogin.Text, tbSenha.Text, Convert.ToInt32(Enum.QtdPessoas.QtdPessoa.DuasPessoas),ds);
                }
                else
                {
                    bot.Instagram(tbLink.Text, tbLogin.Text, tbSenha.Text, Convert.ToInt32(Enum.QtdPessoas.QtdPessoa.TresPessoas),ds);
                }
            }
            else
            {
                MessageBox.Show("Digite os campos Link do sorteio, Login, Senha");
            }
        }
    }
}
