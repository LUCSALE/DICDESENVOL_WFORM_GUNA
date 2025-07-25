using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicdesenvol
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_ab2460_USUARIOS_dbDataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOSTableAdapter.Fill(this.db_ab2460_USUARIOS_dbDataSet.USUARIOS);
            // TODO: esta linha de código carrega dados na tabela 'db_ab2460_Padrao_DataSet.HTML_CSS_Padrao'. Você pode movê-la ou removê-la conforme necessário.
            //this.hTML_CSS_PadraoTableAdapter.Fill(this.db_ab2460_Padrao_DataSet.HTML_CSS_Padrao);

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
                //this.Validate();
                //this.cTRLVERSAOBindingSource.EndEdit();
                //this.PadraoTableAdapter.Update(this.db_ab2460_cadastrodbDataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
                
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
    }
}
