using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicdesenvol
{
    public partial class FrmUsabilidade : Form
    {
        public FrmUsabilidade()
        {
            InitializeComponent();
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_ab2460_Usabilidade_DataSet.HTML_CSS_USABILIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.hTML_CSS_USABILIDADETableAdapter.Fill(this.db_ab2460_Usabilidade_DataSet.HTML_CSS_USABILIDADE);

            try
            {
                // TODO: esta linha de código carrega dados na tabela 'db_ab2460_cadastrodbDataSet.Padrao'. Você pode movê-la ou removê-la conforme necessário.
                //this.PadraoTableAdapter.Fill(this.db_ab2460_cadastrodbDataSet.Padrao);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            }

            

        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Versão: " + guna2DataGridView1.CurrentRow.Cells[0].Value.ToString() + "\n" +
            //                "Data: " + guna2DataGridView1.CurrentRow.Cells[1].Value.ToString() + "\n" +
            //                "Descrição: " + guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());           
            
            //txtID.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void guna2DataGridView1_Click_1(object sender, EventArgs e)
        {
            //txtID.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtData.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtHora.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();


            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.hTMLCSSUSABILIDADEBindingSource.EndEdit();
                this.hTML_CSS_USABILIDADETableAdapter.Update(this.db_ab2460_Usabilidade_DataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            this.Close();        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPadrao_Shown(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void salvarToolStripButton_Click_1(object sender, EventArgs e)
        {
            DateTime DataAtual = DateTime.Now;
            string DataFormat = DataAtual.ToString("dd/MM/yyyy");
            string HoraFormat = DataAtual.ToString("HH:mm:ss");
            txtData.Text = DataFormat;
            txtHora.Text = HoraFormat;

            try
            {
                this.Validate();
                this.hTMLCSSUSABILIDADEBindingSource.EndEdit();
                this.hTML_CSS_USABILIDADETableAdapter.Update(this.db_ab2460_Usabilidade_DataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            this.Close();
        }

        private void guna2DataGridView1_Click_2(object sender, EventArgs e)
        {
            txtUsabilidade_Objetivo.Focus();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {

            var intContador = 0;
            ////declarando a variavel do tipo StreamWriter para
            //abrir ou criar um arquivo para escrita
            StreamWriter x;

            ////Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\Windows\\Temp\\impUsabilidade.txt";

            //utilizando o metodo para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoNome);

            //escrevendo o HEADER
            x.WriteLine("ID;Data;Hora;Usabilidade / Objetivo");

            //aqui, exemplo de escrever no arquivo texto
            //como se fossemos criar um recibo de pagamento

            DataTableReader dtr = this.db_ab2460_Usabilidade_DataSet.CreateDataReader();
            while (dtr.Read())
            {

                x.WriteLine(dtr["ID"].ToString() + ";" +
                            dtr["Data"].ToString() + ";" +
                            dtr["Hora"].ToString() + ";" +
                            dtr["USABILIDADE_OBJETIV0"].ToString()
                            );
                intContador++;



            }


            //fechando o arquivo texto com o método .Close()
            x.Close();
            InfoApp.LinhasImp = intContador + 1;
            FrmUsabilidadeImp UsabilidadeImp = new FrmUsabilidadeImp();
            UsabilidadeImp.ShowDialog(); ;

        }
    }
}
