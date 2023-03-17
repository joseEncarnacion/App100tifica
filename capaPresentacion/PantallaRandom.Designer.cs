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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_basico = new System.Windows.Forms.Button();
            this.btn_intermedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // PantallaRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_intermedio);
            this.Controls.Add(this.btn_basico);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaRandom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_basico;
        private Button btn_intermedio;
        private Label label1;
        private Label label2;
    }
}