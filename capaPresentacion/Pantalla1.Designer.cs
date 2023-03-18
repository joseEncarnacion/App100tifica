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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla1));
            label1 = new Label();
            label2 = new Label();
            btn_registro = new Button();
            textMatricula = new TextBox();
            text_nom = new Label();
            label3 = new Label();
            textNombre = new TextBox();
            label4 = new Label();
            btnIniciar = new Button();
            label5 = new Label();
            btnLimpiar = new Button();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            cBoxCarrera = new ComboBox();
            label8 = new Label();
            textpassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1422, 397);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.MidnightBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(281, 342);
            label2.Name = "label2";
            label2.Size = new Size(868, 608);
            label2.TabIndex = 1;
            // 
            // btn_registro
            // 
            btn_registro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_registro.BackColor = Color.Navy;
            btn_registro.Cursor = Cursors.Hand;
            btn_registro.FlatAppearance.BorderColor = Color.DarkBlue;
            btn_registro.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_registro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registro.ForeColor = SystemColors.ButtonHighlight;
            btn_registro.Location = new Point(281, 342);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(434, 59);
            btn_registro.TabIndex = 2;
            btn_registro.Text = "Registrate y Participa";
            btn_registro.UseVisualStyleBackColor = false;
            // 
            // textMatricula
            // 
            textMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textMatricula.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textMatricula.Location = new Point(345, 504);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(556, 41);
            textMatricula.TabIndex = 3;
            textMatricula.TextChanged += textMatricula_TextChanged;
            // 
            // text_nom
            // 
            text_nom.AutoSize = true;
            text_nom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_nom.ForeColor = SystemColors.ButtonHighlight;
            text_nom.Location = new Point(345, 460);
            text_nom.Name = "text_nom";
            text_nom.Size = new Size(103, 28);
            text_nom.TabIndex = 4;
            text_nom.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(345, 560);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 6;
            label3.Text = "Nombre completo";
            label3.Click += label3_Click;
            // 
            // textNombre
            // 
            textNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.Location = new Point(345, 604);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(556, 41);
            textNombre.TabIndex = 5;
            textNombre.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(345, 663);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 8;
            label4.Text = "Carrera";
            label4.Click += label4_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ControlDarkDark;
            btnIniciar.Location = new Point(349, 860);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(175, 47);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Registrarme";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.MidnightBlue;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(281, 342);
            label5.Name = "label5";
            label5.Size = new Size(868, 59);
            label5.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ControlDarkDark;
            btnLimpiar.Location = new Point(540, 860);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 47);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Inputs";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Navy;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(715, 342);
            button1.Name = "button1";
            button1.Size = new Size(434, 59);
            button1.TabIndex = 12;
            button1.Text = "Inicio Seccion";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.White;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(1197, 22);
            label6.Name = "label6";
            label6.Size = new Size(213, 111);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(211, 72);
            label7.Name = "label7";
            label7.Size = new Size(552, 279);
            label7.TabIndex = 14;
            // 
            // cBoxCarrera
            // 
            cBoxCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cBoxCarrera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCarrera.FormattingEnabled = true;
            cBoxCarrera.Items.AddRange(new object[] { "Software", "Multimedia", "Mecatronica", "Redes", "VideoJuegos", "Seguridad", "Diseño Grafico" });
            cBoxCarrera.Location = new Point(346, 704);
            cBoxCarrera.Name = "cBoxCarrera";
            cBoxCarrera.Size = new Size(555, 36);
            cBoxCarrera.TabIndex = 15;
            cBoxCarrera.SelectedIndexChanged += cBoxCarrera_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(345, 753);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 17;
            label8.Text = "Password";
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textpassword.Location = new Point(345, 797);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(556, 34);
            textpassword.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Pantalla1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1422, 977);
            Controls.Add(label8);
            Controls.Add(textpassword);
            Controls.Add(cBoxCarrera);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(btnLimpiar);
            Controls.Add(btn_registro);
            Controls.Add(label5);
            Controls.Add(btnIniciar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textNombre);
            Controls.Add(text_nom);
            Controls.Add(textMatricula);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            MaximumSize = new Size(1440, 1024);
            MinimizeBox = false;
            MinimumSize = new Size(1440, 1018);
            Name = "Pantalla1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App - Aprende a Programar Practicando - ITLA";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label8;
        private TextBox textpassword;
        private ErrorProvider errorProvider1;
    }
}