namespace Usuarios_planta.Capa_presentacion
{
    partial class horarios
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
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.lbfinal = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.lbinicial = new System.Windows.Forms.Label();
            this.Btn_busqueda = new System.Windows.Forms.PictureBox();
            this.dgv_informes = new System.Windows.Forms.DataGridView();
            this.BtnDescargar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Usuarios_planta.Properties.Resources.índice1;
            this.pictureBox8.Location = new System.Drawing.Point(12, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(120, 77);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(157)))));
            this.label3.Location = new System.Drawing.Point(360, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Control Horarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpfinal
            // 
            this.dtpfinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpfinal.CustomFormat = "dd/MM/yyyy";
            this.dtpfinal.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfinal.Location = new System.Drawing.Point(12, 202);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(111, 25);
            this.dtpfinal.TabIndex = 91;
            // 
            // lbfinal
            // 
            this.lbfinal.AutoSize = true;
            this.lbfinal.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfinal.Location = new System.Drawing.Point(9, 180);
            this.lbfinal.Name = "lbfinal";
            this.lbfinal.Size = new System.Drawing.Size(82, 17);
            this.lbfinal.TabIndex = 90;
            this.lbfinal.Text = "Fecha Final";
            // 
            // dtpinicio
            // 
            this.dtpinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpinicio.CustomFormat = "dd/MM/yyyy";
            this.dtpinicio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpinicio.Location = new System.Drawing.Point(12, 143);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(111, 25);
            this.dtpinicio.TabIndex = 89;
            // 
            // lbinicial
            // 
            this.lbinicial.AutoSize = true;
            this.lbinicial.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinicial.Location = new System.Drawing.Point(9, 121);
            this.lbinicial.Name = "lbinicial";
            this.lbinicial.Size = new System.Drawing.Size(90, 17);
            this.lbinicial.TabIndex = 88;
            this.lbinicial.Text = "Fecha Inicial";
            // 
            // Btn_busqueda
            // 
            this.Btn_busqueda.BackColor = System.Drawing.Color.White;
            this.Btn_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_busqueda.Image = global::Usuarios_planta.Properties.Resources.buscar;
            this.Btn_busqueda.Location = new System.Drawing.Point(141, 171);
            this.Btn_busqueda.Name = "Btn_busqueda";
            this.Btn_busqueda.Size = new System.Drawing.Size(24, 26);
            this.Btn_busqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Btn_busqueda.TabIndex = 87;
            this.Btn_busqueda.TabStop = false;
            this.Btn_busqueda.Click += new System.EventHandler(this.Btn_busqueda_Click);
            // 
            // dgv_informes
            // 
            this.dgv_informes.AllowUserToAddRows = false;
            this.dgv_informes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_informes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_informes.Location = new System.Drawing.Point(187, 121);
            this.dgv_informes.Name = "dgv_informes";
            this.dgv_informes.Size = new System.Drawing.Size(528, 305);
            this.dgv_informes.TabIndex = 92;
            // 
            // BtnDescargar
            // 
            this.BtnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.BtnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDescargar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDescargar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescargar.ForeColor = System.Drawing.Color.White;
            this.BtnDescargar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDescargar.IconColor = System.Drawing.Color.Black;
            this.BtnDescargar.IconSize = 16;
            this.BtnDescargar.Location = new System.Drawing.Point(635, 432);
            this.BtnDescargar.Name = "BtnDescargar";
            this.BtnDescargar.Rotation = 0D;
            this.BtnDescargar.Size = new System.Drawing.Size(80, 30);
            this.BtnDescargar.TabIndex = 93;
            this.BtnDescargar.Text = "Descargar";
            this.BtnDescargar.UseVisualStyleBackColor = false;
            this.BtnDescargar.Click += new System.EventHandler(this.BtnDescargar_Click);
            // 
            // horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(745, 480);
            this.Controls.Add(this.BtnDescargar);
            this.Controls.Add(this.dgv_informes);
            this.Controls.Add(this.dtpfinal);
            this.Controls.Add(this.lbfinal);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.lbinicial);
            this.Controls.Add(this.Btn_busqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "horarios";
            this.Text = "horarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.Label lbfinal;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label lbinicial;
        private System.Windows.Forms.PictureBox Btn_busqueda;
        private System.Windows.Forms.DataGridView dgv_informes;
        private FontAwesome.Sharp.IconButton BtnDescargar;
    }
}