namespace Usuarios_planta.Formularios
{
    partial class Informes
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
            this.cmbactividad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnguardar = new FontAwesome.Sharp.IconButton();
            this.Txtidentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtobservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEtapa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblfecha_actual = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbactividad
            // 
            this.cmbactividad.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.cmbactividad.FormattingEnabled = true;
            this.cmbactividad.Items.AddRange(new object[] {
            "Entrada",
            "Salida - Break",
            "Entrada - Break",
            "Salida - Almuerzo",
            "Entrada - Almuerzo",
            "Salida"});
            this.cmbactividad.Location = new System.Drawing.Point(197, 242);
            this.cmbactividad.Name = "cmbactividad";
            this.cmbactividad.Size = new System.Drawing.Size(259, 28);
            this.cmbactividad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(84, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad:";
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnguardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btnguardar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnguardar.ForeColor = System.Drawing.Color.White;
            this.Btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btnguardar.IconColor = System.Drawing.Color.Black;
            this.Btnguardar.IconSize = 16;
            this.Btnguardar.Location = new System.Drawing.Point(283, 346);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Rotation = 0D;
            this.Btnguardar.Size = new System.Drawing.Size(80, 30);
            this.Btnguardar.TabIndex = 4;
            this.Btnguardar.Text = "Registrar";
            this.Btnguardar.UseVisualStyleBackColor = false;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Txtidentificacion
            // 
            this.Txtidentificacion.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidentificacion.Location = new System.Drawing.Point(197, 123);
            this.Txtidentificacion.Multiline = true;
            this.Txtidentificacion.Name = "Txtidentificacion";
            this.Txtidentificacion.Size = new System.Drawing.Size(259, 27);
            this.Txtidentificacion.TabIndex = 1;
            this.Txtidentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtidentificacion.Validated += new System.EventHandler(this.Txtidentificacion_Validated);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.TxtNombre.Location = new System.Drawing.Point(197, 161);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(259, 27);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(84, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(84, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // Txtobservaciones
            // 
            this.Txtobservaciones.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.Txtobservaciones.Location = new System.Drawing.Point(197, 283);
            this.Txtobservaciones.Multiline = true;
            this.Txtobservaciones.Name = "Txtobservaciones";
            this.Txtobservaciones.Size = new System.Drawing.Size(259, 46);
            this.Txtobservaciones.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(84, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observaciones";
            // 
            // TxtEtapa
            // 
            this.TxtEtapa.Enabled = false;
            this.TxtEtapa.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.TxtEtapa.Location = new System.Drawing.Point(197, 202);
            this.TxtEtapa.Multiline = true;
            this.TxtEtapa.Name = "TxtEtapa";
            this.TxtEtapa.Size = new System.Drawing.Size(259, 27);
            this.TxtEtapa.TabIndex = 11;
            this.TxtEtapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(84, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 18);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            this.pictureBox2.Location = new System.Drawing.Point(293, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 18);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(33)))));
            this.pictureBox3.Location = new System.Drawing.Point(519, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 18);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(145, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(332, 24);
            this.label33.TabIndex = 210;
            this.label33.Text = "FORMULARIO INGRESO - SALIDA";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Usuarios_planta.Properties.Resources.descarga;
            this.pictureBox4.Location = new System.Drawing.Point(539, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 211;
            this.pictureBox4.TabStop = false;
            // 
            // lblfecha_actual
            // 
            this.lblfecha_actual.AutoSize = true;
            this.lblfecha_actual.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha_actual.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_actual.Location = new System.Drawing.Point(358, 89);
            this.lblfecha_actual.Name = "lblfecha_actual";
            this.lblfecha_actual.Size = new System.Drawing.Size(0, 20);
            this.lblfecha_actual.TabIndex = 212;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(456, 89);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 20);
            this.lblHora.TabIndex = 213;
            this.lblHora.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(661, 410);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblfecha_actual);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtEtapa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtobservaciones);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Txtidentificacion);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.cmbactividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbactividad;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btnguardar;
        private System.Windows.Forms.TextBox Txtidentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtobservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEtapa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblfecha_actual;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}