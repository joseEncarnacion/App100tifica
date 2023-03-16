namespace capaPresentacion
{
    partial class Resultado
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnSolicitarTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(287, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 292);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(676, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hola!";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnTerminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTerminar.Location = new System.Drawing.Point(410, 826);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(285, 47);
            this.btnTerminar.TabIndex = 2;
            this.btnTerminar.Text = "Terminar Intento";
            this.btnTerminar.UseVisualStyleBackColor = false;
            // 
            // btnSolicitarTiempo
            // 
            this.btnSolicitarTiempo.BackColor = System.Drawing.Color.Gold;
            this.btnSolicitarTiempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitarTiempo.Location = new System.Drawing.Point(735, 826);
            this.btnSolicitarTiempo.Name = "btnSolicitarTiempo";
            this.btnSolicitarTiempo.Size = new System.Drawing.Size(302, 47);
            this.btnSolicitarTiempo.TabIndex = 3;
            this.btnSolicitarTiempo.Text = "Solicitar Mas Tiempo";
            this.btnSolicitarTiempo.UseVisualStyleBackColor = false;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.btnSolicitarTiempo);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnTerminar;
        private Button btnSolicitarTiempo;
    }
}