namespace capaPresentacion
{
    partial class Pantalla1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registro = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxCarrera = new System.Windows.Forms.ComboBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1422, 397);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(281, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(864, 608);
            this.label2.TabIndex = 1;
            // 
            // btn_registro
            // 
            this.btn_registro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_registro.BackColor = System.Drawing.Color.Navy;
            this.btn_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registro.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_registro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registro.Location = new System.Drawing.Point(279, 342);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(434, 55);
            this.btn_registro.TabIndex = 2;
            this.btn_registro.Text = "Registrate y Participa";
            this.btn_registro.UseVisualStyleBackColor = false;
            // 
            // textMatricula
            // 
            this.textMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMatricula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMatricula.Location = new System.Drawing.Point(345, 540);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(552, 41);
            this.textMatricula.TabIndex = 3;
            this.textMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMatricula_KeyPress);
            // 
            // text_nom
            // 
            this.text_nom.AutoSize = true;
            this.text_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_nom.Location = new System.Drawing.Point(345, 496);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(103, 28);
            this.text_nom.TabIndex = 4;
            this.text_nom.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(345, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre completo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombre.Location = new System.Drawing.Point(345, 640);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(552, 41);
            this.textNombre.TabIndex = 5;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(345, 699);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrera";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIniciar.Location = new System.Drawing.Point(349, 860);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(175, 47);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Registrarme";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(281, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(864, 59);
            this.label5.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.Location = new System.Drawing.Point(540, 860);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(175, 47);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar Inputs";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(713, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 55);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Image = global::capaPresentacion.Properties.Resources.image_8;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 107);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Image = global::capaPresentacion.Properties.Resources.AppArte__1_;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(366, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(535, 287);
            this.label7.TabIndex = 14;
            // 
            // cBoxCarrera
            // 
            this.cBoxCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxCarrera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxCarrera.FormattingEnabled = true;
            this.cBoxCarrera.Items.AddRange(new object[] {
            "DESARROLLO DE SOFTWARE",
            "ANALÍTICA Y CIENCIA DE LOS DATOS",
            "SEGURIDAD INFORMÁTICA",
            "MULTIMEDIA",
            "DISEÑO INDUSTRIAL",
            "SONIDO",
            "MECATRÓNICA",
            "INTELIGENCIA ARTIFICIAL",
            "SIMULACIONES INTERACTIVAS Y VIDEOJUEGOS",
            "TELECOMUNICACIONES",
            "INFORMÁTICA FORENSE",
            "ENERGÍAS RENOVABLES",
            "REDES DE INFORMACIÓN",
            "MANUFACTURA AUTOMATIZADA",
            "MANUFACTURA DE DISPOSITIVOS MÉDICOS",
            "OTRA"});
            this.cBoxCarrera.Location = new System.Drawing.Point(346, 740);
            this.cBoxCarrera.Name = "cBoxCarrera";
            this.cBoxCarrera.Size = new System.Drawing.Size(551, 36);
            this.cBoxCarrera.TabIndex = 15;
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_admin.Location = new System.Drawing.Point(1048, 66);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(204, 45);
            this.btn_admin.TabIndex = 18;
            this.btn_admin.Text = "Administradores";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.cBoxCarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 1024);
            this.Name = "Pantalla1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - Aprende a Programar Practicando - ITLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_registro;
        private TextBox textMatricula;
        private Label text_nom;
        private Label label3;
        private TextBox textNombre;
        private Label label4;
        private Button btnIniciar;
        private Label label5;
        private Button btnLimpiar;
        private Button button1;
        private Label label6;
        private Label label7;
        private ComboBox cBoxCarrera;
        private Button btn_admin;
    }
}