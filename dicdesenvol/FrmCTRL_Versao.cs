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
    public partial class FrmCTRL_Versao : Form
    {
        public FrmCTRL_Versao()
        {
            InitializeComponent();
        }

        private void FrmCTRL_Versao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_ab2460_cadastrodbDataSet.CTRL_VERSAO'. Você pode movê-la ou removê-la conforme necessário.
            this.cTRL_VERSAOTableAdapter.Fill(this.db_ab2460_cadastrodbDataSet.CTRL_VERSAO);
            
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
            this.Validate();
            this.cTRLVERSAOBindingSource.EndEdit();
            this.cTRL_VERSAOTableAdapter.Update(this.db_ab2460_cadastrodbDataSet);
            
            FrmPrincipal frm = new FrmPrincipal();
            frm.AtualizaVersao();
            frm.Refresh();

            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
