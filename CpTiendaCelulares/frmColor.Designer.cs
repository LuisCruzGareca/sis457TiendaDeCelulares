namespace CpTiendaCelulares
{
    partial class frmColor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet2 = new CpTiendaCelulares.LabTiendaCelularesDataSet2();
            this.coloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet1 = new CpTiendaCelulares.LabTiendaCelularesDataSet1();
            this.coloresTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet1TableAdapters.coloresTableAdapter();
            this.labTiendaCelularesDataSet4 = new CpTiendaCelulares.LabTiendaCelularesDataSet4();
            this.labTiendaCelularesDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet2TableAdapters.categoriasTableAdapter();
            this.labTiendaCelularesDataSet3 = new CpTiendaCelulares.LabTiendaCelularesDataSet3();
            this.coloresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coloresTableAdapter1 = new CpTiendaCelulares.LabTiendaCelularesDataSet3TableAdapters.coloresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coloresBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.labTiendaCelularesDataSet2;
            // 
            // labTiendaCelularesDataSet2
            // 
            this.labTiendaCelularesDataSet2.DataSetName = "LabTiendaCelularesDataSet2";
            this.labTiendaCelularesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloresBindingSource
            // 
            this.coloresBindingSource.DataMember = "colores";
            this.coloresBindingSource.DataSource = this.labTiendaCelularesDataSet1;
            // 
            // labTiendaCelularesDataSet1
            // 
            this.labTiendaCelularesDataSet1.DataSetName = "LabTiendaCelularesDataSet1";
            this.labTiendaCelularesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloresTableAdapter
            // 
            this.coloresTableAdapter.ClearBeforeFill = true;
            // 
            // labTiendaCelularesDataSet4
            // 
            this.labTiendaCelularesDataSet4.DataSetName = "LabTiendaCelularesDataSet4";
            this.labTiendaCelularesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTiendaCelularesDataSet4BindingSource
            // 
            this.labTiendaCelularesDataSet4BindingSource.DataSource = this.labTiendaCelularesDataSet4;
            this.labTiendaCelularesDataSet4BindingSource.Position = 0;
            // 
            // labTiendaCelularesDataSet2BindingSource
            // 
            this.labTiendaCelularesDataSet2BindingSource.DataSource = this.labTiendaCelularesDataSet2;
            this.labTiendaCelularesDataSet2BindingSource.Position = 0;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // labTiendaCelularesDataSet3
            // 
            this.labTiendaCelularesDataSet3.DataSetName = "LabTiendaCelularesDataSet3";
            this.labTiendaCelularesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloresBindingSource1
            // 
            this.coloresBindingSource1.DataMember = "colores";
            this.coloresBindingSource1.DataSource = this.labTiendaCelularesDataSet3;
            // 
            // coloresTableAdapter1
            // 
            this.coloresTableAdapter1.ClearBeforeFill = true;
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(844, 198);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.Load += new System.EventHandler(this.frmColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private LabTiendaCelularesDataSet1 labTiendaCelularesDataSet1;
        private System.Windows.Forms.BindingSource coloresBindingSource;
        private LabTiendaCelularesDataSet1TableAdapters.coloresTableAdapter coloresTableAdapter;
        private System.Windows.Forms.BindingSource labTiendaCelularesDataSet2BindingSource;
        private LabTiendaCelularesDataSet2 labTiendaCelularesDataSet2;
        private LabTiendaCelularesDataSet4 labTiendaCelularesDataSet4;
        private System.Windows.Forms.BindingSource labTiendaCelularesDataSet4BindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private LabTiendaCelularesDataSet2TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private LabTiendaCelularesDataSet3 labTiendaCelularesDataSet3;
        private System.Windows.Forms.BindingSource coloresBindingSource1;
        private LabTiendaCelularesDataSet3TableAdapters.coloresTableAdapter coloresTableAdapter1;
    }
}