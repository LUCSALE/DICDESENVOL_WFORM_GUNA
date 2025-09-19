namespace dicdesenvol
{
    partial class FrmCTRL_Versao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCTRL_Versao));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sISTEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTRLVERSAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTRL_VERSAO_cadastrodbDataSet = new dicdesenvol.CTRL_VERSAO_cadastrodbDataSet();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlDados = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSistema = new MetroFramework.Controls.MetroTextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtVersao = new MetroFramework.Controls.MetroTextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.txtHora = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cTRL_VERSAOTableAdapter = new dicdesenvol.CTRL_VERSAO_cadastrodbDataSetTableAdapters.CTRL_VERSAOTableAdapter();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.pnlHeader.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTRLVERSAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTRL_VERSAO_cadastrodbDataSet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(717, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(199, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 57);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "CTRL_Versão";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pnlGrid.Controls.Add(this.guna2DataGridView1);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrid.Location = new System.Drawing.Point(0, 61);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(717, 119);
            this.pnlGrid.TabIndex = 1;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.hORADataGridViewTextBoxColumn,
            this.sISTEMADataGridViewTextBoxColumn,
            this.vERSAODataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.cTRLVERSAOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(717, 119);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click_3);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 126.9036F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.dATADataGridViewTextBoxColumn.HeaderText = "DATA";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORADataGridViewTextBoxColumn
            // 
            this.hORADataGridViewTextBoxColumn.DataPropertyName = "HORA";
            this.hORADataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.hORADataGridViewTextBoxColumn.HeaderText = "HORA";
            this.hORADataGridViewTextBoxColumn.Name = "hORADataGridViewTextBoxColumn";
            this.hORADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sISTEMADataGridViewTextBoxColumn
            // 
            this.sISTEMADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sISTEMADataGridViewTextBoxColumn.DataPropertyName = "SISTEMA";
            this.sISTEMADataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.sISTEMADataGridViewTextBoxColumn.HeaderText = "SISTEMA";
            this.sISTEMADataGridViewTextBoxColumn.Name = "sISTEMADataGridViewTextBoxColumn";
            this.sISTEMADataGridViewTextBoxColumn.ReadOnly = true;
            this.sISTEMADataGridViewTextBoxColumn.Width = 250;
            // 
            // vERSAODataGridViewTextBoxColumn
            // 
            this.vERSAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vERSAODataGridViewTextBoxColumn.DataPropertyName = "VERSAO";
            this.vERSAODataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.vERSAODataGridViewTextBoxColumn.HeaderText = "VERSAO";
            this.vERSAODataGridViewTextBoxColumn.Name = "vERSAODataGridViewTextBoxColumn";
            this.vERSAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTRLVERSAOBindingSource
            // 
            this.cTRLVERSAOBindingSource.DataMember = "CTRL_VERSAO";
            this.cTRLVERSAOBindingSource.DataSource = this.cTRL_VERSAO_cadastrodbDataSet;
            // 
            // cTRL_VERSAO_cadastrodbDataSet
            // 
            this.cTRL_VERSAO_cadastrodbDataSet.DataSetName = "CTRL_VERSAO_cadastrodbDataSet";
            this.cTRL_VERSAO_cadastrodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.bindingNavigator1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 441);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(717, 30);
            this.pnlFooter.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.cTRLVERSAOBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 1);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(717, 29);
            this.bindingNavigator1.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click_1);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.imprimirToolStripButton.Text = "&Imprimir";
            this.imprimirToolStripButton.Click += new System.EventHandler(this.imprimirToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::dicdesenvol.Properties.Resources._4213475_arrow_back_left_return_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.ToolTipText = "Voltar ...";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // pnlDados
            // 
            this.pnlDados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pnlDados.BorderThickness = 4;
            this.pnlDados.Controls.Add(this.pdfViewer1);
            this.pnlDados.Controls.Add(this.txtSistema);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel3);
            this.pnlDados.Controls.Add(this.txtVersao);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel2);
            this.pnlDados.Controls.Add(this.txtData);
            this.pnlDados.Controls.Add(this.txtHora);
            this.pnlDados.Controls.Add(this.txtID);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel6);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel5);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel4);
            this.pnlDados.Controls.Add(this.guna2HtmlLabel1);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 180);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(717, 261);
            this.pnlDados.TabIndex = 2;
            // 
            // txtSistema
            // 
            // 
            // 
            // 
            this.txtSistema.CustomButton.Image = null;
            this.txtSistema.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtSistema.CustomButton.Name = "";
            this.txtSistema.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSistema.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSistema.CustomButton.TabIndex = 1;
            this.txtSistema.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSistema.CustomButton.UseSelectable = true;
            this.txtSistema.CustomButton.Visible = false;
            this.txtSistema.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTRLVERSAOBindingSource, "SISTEMA", true));
            this.txtSistema.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSistema.Lines = new string[0];
            this.txtSistema.Location = new System.Drawing.Point(12, 173);
            this.txtSistema.MaxLength = 32767;
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.PasswordChar = '\0';
            this.txtSistema.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSistema.SelectedText = "";
            this.txtSistema.SelectionLength = 0;
            this.txtSistema.SelectionStart = 0;
            this.txtSistema.ShortcutsEnabled = true;
            this.txtSistema.Size = new System.Drawing.Size(318, 23);
            this.txtSistema.TabIndex = 12;
            this.txtSistema.UseSelectable = true;
            this.txtSistema.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSistema.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 155);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Sistema";
            // 
            // txtVersao
            // 
            // 
            // 
            // 
            this.txtVersao.CustomButton.Image = null;
            this.txtVersao.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.txtVersao.CustomButton.Name = "";
            this.txtVersao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVersao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVersao.CustomButton.TabIndex = 1;
            this.txtVersao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVersao.CustomButton.UseSelectable = true;
            this.txtVersao.CustomButton.Visible = false;
            this.txtVersao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTRLVERSAOBindingSource, "VERSAO", true));
            this.txtVersao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtVersao.Lines = new string[0];
            this.txtVersao.Location = new System.Drawing.Point(12, 220);
            this.txtVersao.MaxLength = 32767;
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.PasswordChar = '\0';
            this.txtVersao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVersao.SelectedText = "";
            this.txtVersao.SelectionLength = 0;
            this.txtVersao.SelectionStart = 0;
            this.txtVersao.ShortcutsEnabled = true;
            this.txtVersao.Size = new System.Drawing.Size(67, 23);
            this.txtVersao.TabIndex = 14;
            this.txtVersao.UseSelectable = true;
            this.txtVersao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVersao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 202);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Versão";
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTRLVERSAOBindingSource, "DATA", true));
            this.txtData.Enabled = false;
            this.txtData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtData.Lines = new string[0];
            this.txtData.Location = new System.Drawing.Point(12, 78);
            this.txtData.MaxLength = 32767;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(67, 23);
            this.txtData.TabIndex = 4;
            this.txtData.TabStop = false;
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHora
            // 
            // 
            // 
            // 
            this.txtHora.CustomButton.Image = null;
            this.txtHora.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.txtHora.CustomButton.Name = "";
            this.txtHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHora.CustomButton.TabIndex = 1;
            this.txtHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHora.CustomButton.UseSelectable = true;
            this.txtHora.CustomButton.Visible = false;
            this.txtHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTRLVERSAOBindingSource, "HORA", true));
            this.txtHora.Enabled = false;
            this.txtHora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtHora.Lines = new string[0];
            this.txtHora.Location = new System.Drawing.Point(12, 126);
            this.txtHora.MaxLength = 32767;
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHora.SelectedText = "";
            this.txtHora.SelectionLength = 0;
            this.txtHora.SelectionStart = 0;
            this.txtHora.ShortcutsEnabled = true;
            this.txtHora.Size = new System.Drawing.Size(54, 23);
            this.txtHora.TabIndex = 6;
            this.txtHora.TabStop = false;
            this.txtHora.UseSelectable = true;
            this.txtHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(8, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTRLVERSAOBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(12, 27);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(30, 23);
            this.txtID.TabIndex = 2;
            this.txtID.TabStop = false;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 109);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(30, 15);
            this.guna2HtmlLabel6.TabIndex = 5;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Hora";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 60);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(30, 15);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Data";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 10);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(16, 15);
            this.guna2HtmlLabel4.TabIndex = 1;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "ID";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(18, 18);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "ID";
            // 
            // cTRL_VERSAOTableAdapter
            // 
            this.cTRL_VERSAOTableAdapter.ClearBeforeFill = true;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(122, 14);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(554, 110);
            this.pdfViewer1.TabIndex = 15;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // FrmCTRL_Versao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(717, 471);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCTRL_Versao";
            this.Text = "FrmPadrao";
            this.Load += new System.EventHandler(this.FrmPadrao_Load);
            this.Shown += new System.EventHandler(this.FrmPadrao_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTRLVERSAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTRL_VERSAO_cadastrodbDataSet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlDados;
        private MetroFramework.Controls.MetroTextBox txtData;
        private MetroFramework.Controls.MetroTextBox txtHora;
        private MetroFramework.Controls.MetroTextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private MetroFramework.Controls.MetroTextBox txtSistema;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private MetroFramework.Controls.MetroTextBox txtVersao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private CTRL_VERSAO_cadastrodbDataSet cTRL_VERSAO_cadastrodbDataSet;
        private System.Windows.Forms.BindingSource cTRLVERSAOBindingSource;
        private CTRL_VERSAO_cadastrodbDataSetTableAdapters.CTRL_VERSAOTableAdapter cTRL_VERSAOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sISTEMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
    }
}