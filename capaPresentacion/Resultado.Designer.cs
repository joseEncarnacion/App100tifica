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
            this.btn_resultIrInicio = new System.Windows.Forms.Button();
            this.text_CountDown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 313);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = global::capaPresentacion.Properties.Resources.AppArte__1_;
            this.label1.Location = new System.Drawing.Point(343, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 173);
            this.label1.TabIndex = 0;
            // 
            // btn_resultIrInicio
            // 
            this.btn_resultIrInicio.BackColor = System.Drawing.Color.Gold;
            this.btn_resultIrInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_resultIrInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_resultIrInicio.Location = new System.Drawing.Point(517, 671);
            this.btn_resultIrInicio.Name = "btn_resultIrInicio";
            this.btn_resultIrInicio.Size = new System.Drawing.Size(347, 47);
            this.btn_resultIrInicio.TabIndex = 3;
            this.btn_resultIrInicio.Text = "Ir al inicio";
            this.btn_resultIrInicio.UseVisualStyleBackColor = false;
            this.btn_resultIrInicio.Click += new System.EventHandler(this.btn_resultIrInicio_Click);
            // 
            // text_CountDown
            // 
            this.text_CountDown.AutoSize = true;
            this.text_CountDown.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_CountDown.ForeColor = System.Drawing.Color.White;
            this.text_CountDown.Location = new System.Drawing.Point(541, 479);
            this.text_CountDown.Name = "text_CountDown";
            this.text_CountDown.Size = new System.Drawing.Size(310, 54);
            this.text_CountDown.TabIndex = 4;
            this.text_CountDown.Text = "Enhorabuena!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(495, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estaremos validando tus resultados";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Image = global::capaPresentacion.Properties.Resources.image_8;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 107);
            this.label6.TabIndex = 14;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_CountDown);
            this.Controls.Add(this.btn_resultIrInicio);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_resultIrInicio;
        private Label text_CountDown;
        private Label label3;
        private Label label1;
        private Label label6;
    }
}