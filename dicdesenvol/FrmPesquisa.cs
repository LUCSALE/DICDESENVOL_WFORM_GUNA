using Guna.UI2.WinForms;
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
    public partial class FrmPesquisa : Form
    {
        public FrmPesquisa()
        {
            InitializeComponent();
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN'. Você pode movê-la ou removê-la conforme necessário.
            this.hTML_CSS_RADZENTableAdapter.Fill(this.db_HTML_CSS_RADZEN_DataSet.HTML_CSS_RADZEN);
            
            //try
            //{
            //    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_cadastrodbDataSet.Padrao'. Você pode movê-la ou removê-la conforme necessário.
            //    //this.PadraoTableAdapter.Fill(this.db_ab2460_cadastrodbDataSet.Padrao);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Consultar tabela: Padrao - " + ex.Message);
            //}



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

            //try
            //{
            //    this.Validate();
            //    this.hTMLCSSUSABILIDADEBindingSource.EndEdit();
            //    this.hTML_CSS_USABILIDADETableAdapter.Update(this.db_ab2460_Usabilidade_DataSet);
            //    MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Salvar: " + ex.Message);
            //}
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
            //try
            //{
            //    this.Validate();
            //    this.hTMLCSSUSABILIDADEBindingSource.EndEdit();
            //    this.hTML_CSS_USABILIDADETableAdapter.Update(this.db_ab2460_Usabilidade_DataSet);
            //    MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Salvar: " + ex.Message);
            //}
            //this.Close();
        }

        private void guna2DataGridView1_Click_2(object sender, EventArgs e)
        {
            //txtUsabilidade_Objetivo.Focus();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            //txtUsabilidade_Objetivo.Focus();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hTML_CSS_RADZENBindingSource.EndEdit();
                this.hTML_CSS_RADZENTableAdapter.Update(this.db_HTML_CSS_RADZEN_DataSet);
                            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                // Exibir a imagem
                // 
                if (File.Exists(InfoApp.dirfoto + metroGrid1.CurrentRow.Cells[10].Value))
                {
                    System.Diagnostics.Process.Start(InfoApp.dirfoto + metroGrid1.CurrentRow.Cells[10].Value);
                }

            }

            if (e.ColumnIndex == 1)
            {

                // Editar o registro   
                MessageBox.Show("Você clicou na Coluna: 1 - Edição !!!");
            }

            if (e.ColumnIndex == 11)
            {

                // Excluir o registro   
                MessageBox.Show("Você clicou na Coluna: 11 - Exclusão !!!");
            }

        }

    }
}
