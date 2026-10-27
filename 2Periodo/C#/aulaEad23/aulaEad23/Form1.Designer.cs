namespace aulaEad23
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            txtObs = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(320, 29);
            label1.Name = "label1";
            label1.Size = new Size(230, 49);
            label1.TabIndex = 0;
            label1.Text = "Sistema IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(255, 138);
            label2.Name = "label2";
            label2.Size = new Size(73, 27);
            label2.TabIndex = 1;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(255, 188);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.Window;
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(334, 136);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(216, 29);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.Window;
            txtAltura.Font = new Font("Segoe UI", 12F);
            txtAltura.Location = new Point(334, 189);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(216, 29);
            txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkViolet;
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(353, 247);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(255, 299);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(128, 27);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // txtObs
            // 
            txtObs.BackColor = SystemColors.Window;
            txtObs.Font = new Font("Segoe UI", 15F);
            txtObs.Location = new Point(255, 350);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(382, 74);
            txtObs.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 660);
            Controls.Add(txtObs);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtObs;
    }
}
