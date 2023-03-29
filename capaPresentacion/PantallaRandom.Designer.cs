namespace capaPresentacion
{
    partial class PantallaRandom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_basico = new System.Windows.Forms.Button();
            this.btn_intermedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado1 = new System.Windows.Forms.Panel();
            this.text_segundo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_PedirTiempo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_minuto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProblema = new System.Windows.Forms.Panel();
            this.textProblema = new System.Windows.Forms.Label();
            this.timerCountD = new System.Windows.Forms.Timer(this.components);
            this.Resultado1.SuspendLayout();
            this.panelProblema.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 53);
            this.panel1.TabIndex = 0;
            // 
            // btn_basico
            // 
            this.btn_basico.Image = global::capaPresentacion.Properties.Resources.btnBasico;
            this.btn_basico.Location = new System.Drawing.Point(401, 547);
            this.btn_basico.Name = "btn_basico";
            this.btn_basico.Size = new System.Drawing.Size(294, 250);
            this.btn_basico.TabIndex = 1;
            this.btn_basico.UseVisualStyleBackColor = true;
            this.btn_basico.Click += new System.EventHandler(this.btn_basico_Click);
            // 
            // btn_intermedio
            // 
            this.btn_intermedio.Image = global::capaPresentacion.Properties.Resources.btnIntermedio;
            this.btn_intermedio.Location = new System.Drawing.Point(751, 547);
            this.btn_intermedio.Name = "btn_intermedio";
            this.btn_intermedio.Size = new System.Drawing.Size(294, 250);
            this.btn_intermedio.TabIndex = 2;
            this.btn_intermedio.UseVisualStyleBackColor = true;
            this.btn_intermedio.Click += new System.EventHandler(this.btn_intermedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(553, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elegir el nivel de dificultad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(633, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hola! Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultado1
            // 
            this.Resultado1.Controls.Add(this.text_segundo);
            this.Resultado1.Controls.Add(this.label5);
            this.Resultado1.Controls.Add(this.btn_PedirTiempo);
            this.Resultado1.Controls.Add(this.button1);
            this.Resultado1.Controls.Add(this.text_minuto);
            this.Resultado1.Controls.Add(this.label3);
            this.Resultado1.Controls.Add(this.panelProblema);
            this.Resultado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resultado1.Location = new System.Drawing.Point(0, 53);
            this.Resultado1.Name = "Resultado1";
            this.Resultado1.Size = new System.Drawing.Size(1422, 924);
            this.Resultado1.TabIndex = 5;
            this.Resultado1.Visible = false;
            // 
            // text_segundo
            // 
            this.text_segundo.AutoSize = true;
            this.text_segundo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_segundo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_segundo.Location = new System.Drawing.Point(720, 613);
            this.text_segundo.Name = "text_segundo";
            this.text_segundo.Size = new System.Drawing.Size(40, 46);
            this.text_segundo.TabIndex = 7;
            this.text_segundo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(428, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiempo Restante:";
            // 
            // btn_PedirTiempo
            // 
            this.btn_PedirTiempo.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_PedirTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PedirTiempo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PedirTiempo.Location = new System.Drawing.Point(762, 750);
            this.btn_PedirTiempo.Name = "btn_PedirTiempo";
            this.btn_PedirTiempo.Size = new System.Drawing.Size(222, 52);
            this.btn_PedirTiempo.TabIndex = 4;
            this.btn_PedirTiempo.Text = "Perdir prorroga";
            this.btn_PedirTiempo.UseVisualStyleBackColor = false;
            this.btn_PedirTiempo.Click += new System.EventHandler(this.btn_PedirTiempo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(428, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terminar reto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_minuto
            // 
            this.text_minuto.AutoSize = true;
            this.text_minuto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_minuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_minuto.Location = new System.Drawing.Point(656, 613);
            this.text_minuto.Name = "text_minuto";
            this.text_minuto.Size = new System.Drawing.Size(40, 46);
            this.text_minuto.TabIndex = 5;
            this.text_minuto.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(664, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hola!";
            // 
            // panelProblema
            // 
            this.panelProblema.BackColor = System.Drawing.Color.AliceBlue;
            this.panelProblema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProblema.Controls.Add(this.textProblema);
            this.panelProblema.Location = new System.Drawing.Point(278, 194);
            this.panelProblema.Name = "panelProblema";
            this.panelProblema.Size = new System.Drawing.Size(865, 352);
            this.panelProblema.TabIndex = 0;
            this.panelProblema.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProblema_Paint);
            // 
            // textProblema
            // 
            this.textProblema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textProblema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textProblema.Location = new System.Drawing.Point(21, 15);
            this.textProblema.Name = "textProblema";
            this.textProblema.Size = new System.Drawing.Size(819, 320);
            this.textProblema.TabIndex = 5;
            this.textProblema.Text = ".";
            this.textProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountD
            // 
            this.timerCountD.Interval = 1000;
            this.timerCountD.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PantallaRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.Resultado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_intermedio);
            this.Controls.Add(this.btn_basico);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resultado1.ResumeLayout(false);
            this.Resultado1.PerformLayout();
            this.panelProblema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_basico;
        private Button btn_intermedio;
        private Label label1;
        private Label label2;
        private Panel Resultado1;
        private Button btn_PedirTiempo;
        private Button button1;
        private Label text_minuto;
        private Label label3;
        private Panel panelProblema;
        private Label textProblema;
        private Label label5;
        private System.Windows.Forms.Timer timerCountD;
        private Label text_segundo;
    }
}