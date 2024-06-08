namespace CpTiendaCelulares
{
    partial class frmMenu
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.venta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem3,
            this.iconMenuItem6,
            this.iconMenuItem5,
            this.iconMenuItem4});
            this.menu.Location = new System.Drawing.Point(0, 67);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 73);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem8});
            this.iconMenuItem1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem1.Text = "Usuario";
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem8.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Size = new System.Drawing.Size(162, 22);
            this.iconMenuItem8.Text = "frmPrincipal";
            this.iconMenuItem8.Click += new System.EventHandler(this.iconMenuItem8_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem2.Text = "Compras";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.MobilePhone;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem3.Text = "Celulares";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.AutoSize = false;
            this.iconMenuItem6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.ColonSign;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.IconSize = 50;
            this.iconMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem6.Text = "Colores";
            this.iconMenuItem6.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.AutoSize = false;
            this.iconMenuItem4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 50;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem4.Text = "ayuda";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(800, 67);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip3";
            // 
            // venta
            // 
            this.venta.AutoSize = true;
            this.venta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.venta.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.venta.Location = new System.Drawing.Point(12, 19);
            this.venta.Name = "venta";
            this.venta.Size = new System.Drawing.Size(247, 24);
            this.venta.TabIndex = 3;
            this.venta.Text = "Venta De Celulares";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 310);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 310;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(800, 310);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.AutoSize = false;
            this.iconMenuItem5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 50;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(135, 69);
            this.iconMenuItem5.Text = "Categoria";
            this.iconMenuItem5.Click += new System.EventHandler(this.iconMenuItem5_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.venta);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Name = "frmMenu";
            this.Text = "frmcolores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label venta;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
    }
}