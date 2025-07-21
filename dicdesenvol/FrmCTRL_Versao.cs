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
    }
}
