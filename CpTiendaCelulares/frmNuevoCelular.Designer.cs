namespace CpTiendaCelulares
{
    partial class frmNuevoCelular
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.coloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet1 = new CpTiendaCelulares.LabTiendaCelularesDataSet1();
            this.coloresTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet1TableAdapters.coloresTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet2 = new CpTiendaCelulares.LabTiendaCelularesDataSet2();
            this.categoriasTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet2TableAdapters.categoriasTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorColores = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategorias = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txMarca
            // 
            this.txMarca.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarca.Location = new System.Drawing.Point(96, 129);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(378, 20);
            this.txMarca.TabIndex = 16;
            // 
            // txDescripcion
            // 
            this.txDescripcion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescripcion.Location = new System.Drawing.Point(96, 41);
            this.txDescripcion.Multiline = true;
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(378, 70);
            this.txDescripcion.TabIndex = 15;
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(96, 15);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(378, 20);
            this.txNombre.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Modelo";
            // 
            // txModelo
            // 
            this.txModelo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txModelo.Location = new System.Drawing.Point(96, 157);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(378, 20);
            this.txModelo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Precio";
            // 
            // txPrecio
            // 
            this.txPrecio.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecio.Location = new System.Drawing.Point(96, 190);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(378, 20);
            this.txPrecio.TabIndex = 24;
            // 
            // cmbColores
            // 
            this.cmbColores.DataSource = this.coloresBindingSource;
            this.cmbColores.DisplayMember = "nombre";
            this.cmbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColores.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(96, 228);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(378, 21);
            this.cmbColores.TabIndex = 26;
            this.cmbColores.ValueMember = "id";
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(11, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Colores";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DataSource = this.categoriasBindingSource;
            this.cmbCategorias.DisplayMember = "nombre";
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(96, 267);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(378, 21);
            this.cmbCategorias.TabIndex = 28;
            this.cmbCategorias.ValueMember = "id";
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(11, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Categorias";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(370, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 47);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorMarca
            // 
            this.errorMarca.ContainerControl = this;
            // 
            // errorModelo
            // 
            this.errorModelo.ContainerControl = this;
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // errorColores
            // 
            this.errorColores.ContainerControl = this;
            // 
            // errorCategorias
            // 
            this.errorCategorias.ContainerControl = this;
            // 
            // frmNuevoCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(496, 405);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txMarca);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.txNombre);
            this.Name = "frmNuevoCelular";
            this.Text = "frmNuevoCelular";
            this.Load += new System.EventHandler(this.frmNuevoCelular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.ComboBox cmbColores;
        private LabTiendaCelularesDataSet1 labTiendaCelularesDataSet1;
        private System.Windows.Forms.BindingSource coloresBindingSource;
        private LabTiendaCelularesDataSet1TableAdapters.coloresTableAdapter coloresTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private LabTiendaCelularesDataSet2 labTiendaCelularesDataSet2;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private LabTiendaCelularesDataSet2TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorMarca;
        private System.Windows.Forms.ErrorProvider errorModelo;
        private System.Windows.Forms.ErrorProvider errorPrecio;
        private System.Windows.Forms.ErrorProvider errorColores;
        private System.Windows.Forms.ErrorProvider errorCategorias;
    }
}