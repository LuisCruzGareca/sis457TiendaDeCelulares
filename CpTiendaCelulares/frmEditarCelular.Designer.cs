namespace CpTiendaCelulares
{
    partial class frmEditarCelular
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet4 = new CpTiendaCelulares.LabTiendaCelularesDataSet4();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.coloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet3 = new CpTiendaCelulares.LabTiendaCelularesDataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.labTiendaCelularesDataSet1 = new CpTiendaCelulares.LabTiendaCelularesDataSet1();
            this.labTiendaCelularesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTiendaCelularesDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coloresTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet3TableAdapters.coloresTableAdapter();
            this.categoriasTableAdapter = new CpTiendaCelulares.LabTiendaCelularesDataSet4TableAdapters.categoriasTableAdapter();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(380, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 47);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Categorias";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DataSource = this.categoriasBindingSource;
            this.cmbCategorias.DisplayMember = "nombre";
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(106, 265);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(378, 21);
            this.cmbCategorias.TabIndex = 43;
            this.cmbCategorias.ValueMember = "id";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.labTiendaCelularesDataSet4;
            // 
            // labTiendaCelularesDataSet4
            // 
            this.labTiendaCelularesDataSet4.DataSetName = "LabTiendaCelularesDataSet4";
            this.labTiendaCelularesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Colores";
            // 
            // cmbColores
            // 
            this.cmbColores.DataSource = this.coloresBindingSource;
            this.cmbColores.DisplayMember = "nombre";
            this.cmbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColores.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(106, 226);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(378, 21);
            this.cmbColores.TabIndex = 41;
            this.cmbColores.ValueMember = "id";
            // 
            // coloresBindingSource
            // 
            this.coloresBindingSource.DataMember = "colores";
            this.coloresBindingSource.DataSource = this.labTiendaCelularesDataSet3;
            // 
            // labTiendaCelularesDataSet3
            // 
            this.labTiendaCelularesDataSet3.DataSetName = "LabTiendaCelularesDataSet3";
            this.labTiendaCelularesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Precio";
            // 
            // txPrecio
            // 
            this.txPrecio.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecio.Location = new System.Drawing.Point(106, 188);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(378, 20);
            this.txPrecio.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(7, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Modelo";
            // 
            // txModelo
            // 
            this.txModelo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txModelo.Location = new System.Drawing.Point(106, 159);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(378, 20);
            this.txModelo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // txMarca
            // 
            this.txMarca.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarca.Location = new System.Drawing.Point(106, 127);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(378, 20);
            this.txMarca.TabIndex = 33;
            // 
            // txDescripcion
            // 
            this.txDescripcion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescripcion.Location = new System.Drawing.Point(106, 40);
            this.txDescripcion.Multiline = true;
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(378, 70);
            this.txDescripcion.TabIndex = 32;
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(106, 12);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(378, 20);
            this.txNombre.TabIndex = 31;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // labTiendaCelularesDataSet1
            // 
            this.labTiendaCelularesDataSet1.DataSetName = "LabTiendaCelularesDataSet1";
            this.labTiendaCelularesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTiendaCelularesDataSet1BindingSource
            // 
            this.labTiendaCelularesDataSet1BindingSource.DataSource = this.labTiendaCelularesDataSet1;
            this.labTiendaCelularesDataSet1BindingSource.Position = 0;
            // 
            // labTiendaCelularesDataSet1BindingSource1
            // 
            this.labTiendaCelularesDataSet1BindingSource1.DataSource = this.labTiendaCelularesDataSet1;
            this.labTiendaCelularesDataSet1BindingSource1.Position = 0;
            // 
            // coloresTableAdapter
            // 
            this.coloresTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
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
            // frmEditarCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(508, 405);
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
            this.Name = "frmEditarCelular";
            this.Text = "frmEditarCelular";
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTiendaCelularesDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.BindingSource labTiendaCelularesDataSet1BindingSource1;
        private LabTiendaCelularesDataSet1 labTiendaCelularesDataSet1;
        private System.Windows.Forms.BindingSource labTiendaCelularesDataSet1BindingSource;
        private LabTiendaCelularesDataSet3 labTiendaCelularesDataSet3;
        private System.Windows.Forms.BindingSource coloresBindingSource;
        private LabTiendaCelularesDataSet3TableAdapters.coloresTableAdapter coloresTableAdapter;
        private LabTiendaCelularesDataSet4 labTiendaCelularesDataSet4;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private LabTiendaCelularesDataSet4TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorMarca;
        private System.Windows.Forms.ErrorProvider errorModelo;
        private System.Windows.Forms.ErrorProvider errorPrecio;
    }
}