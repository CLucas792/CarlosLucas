namespace CarlosLucas
{
    partial class CarlosLucas_Ejercicio1_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.IntereseslistBox = new System.Windows.Forms.ListBox();
            this.Cant200radioButton = new System.Windows.Forms.RadioButton();
            this.Cant150radioButton = new System.Windows.Forms.RadioButton();
            this.Cant250radioButton = new System.Windows.Forms.RadioButton();
            this.FechaDepositodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE INTERESES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad depositada (en miles de LPS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de deposito";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(85, 129);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(428, 35);
            this.Calcularbutton.TabIndex = 3;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // IntereseslistBox
            // 
            this.IntereseslistBox.FormattingEnabled = true;
            this.IntereseslistBox.ItemHeight = 20;
            this.IntereseslistBox.Location = new System.Drawing.Point(85, 189);
            this.IntereseslistBox.Name = "IntereseslistBox";
            this.IntereseslistBox.Size = new System.Drawing.Size(425, 264);
            this.IntereseslistBox.TabIndex = 4;
            // 
            // Cant200radioButton
            // 
            this.Cant200radioButton.AutoSize = true;
            this.Cant200radioButton.Checked = true;
            this.Cant200radioButton.Enabled = false;
            this.Cant200radioButton.Location = new System.Drawing.Point(410, 54);
            this.Cant200radioButton.Name = "Cant200radioButton";
            this.Cant200radioButton.Size = new System.Drawing.Size(54, 24);
            this.Cant200radioButton.TabIndex = 5;
            this.Cant200radioButton.TabStop = true;
            this.Cant200radioButton.Text = "200";
            this.Cant200radioButton.UseVisualStyleBackColor = true;
            // 
            // Cant150radioButton
            // 
            this.Cant150radioButton.AutoSize = true;
            this.Cant150radioButton.Enabled = false;
            this.Cant150radioButton.Location = new System.Drawing.Point(321, 54);
            this.Cant150radioButton.Name = "Cant150radioButton";
            this.Cant150radioButton.Size = new System.Drawing.Size(54, 24);
            this.Cant150radioButton.TabIndex = 6;
            this.Cant150radioButton.Text = "150";
            this.Cant150radioButton.UseVisualStyleBackColor = true;
            // 
            // Cant250radioButton
            // 
            this.Cant250radioButton.AutoSize = true;
            this.Cant250radioButton.Enabled = false;
            this.Cant250radioButton.Location = new System.Drawing.Point(503, 54);
            this.Cant250radioButton.Name = "Cant250radioButton";
            this.Cant250radioButton.Size = new System.Drawing.Size(54, 24);
            this.Cant250radioButton.TabIndex = 7;
            this.Cant250radioButton.Text = "250";
            this.Cant250radioButton.UseVisualStyleBackColor = true;
            // 
            // FechaDepositodateTimePicker
            // 
            this.FechaDepositodateTimePicker.Enabled = false;
            this.FechaDepositodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDepositodateTimePicker.Location = new System.Drawing.Point(193, 87);
            this.FechaDepositodateTimePicker.Name = "FechaDepositodateTimePicker";
            this.FechaDepositodateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FechaDepositodateTimePicker.TabIndex = 8;
            this.FechaDepositodateTimePicker.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // CarlosLucas_Ejercicio1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 474);
            this.Controls.Add(this.FechaDepositodateTimePicker);
            this.Controls.Add(this.Cant250radioButton);
            this.Controls.Add(this.Cant150radioButton);
            this.Controls.Add(this.Cant200radioButton);
            this.Controls.Add(this.IntereseslistBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarlosLucas_Ejercicio1_Form";
            this.Text = "CarlosLucas_Ejercicio1_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ListBox IntereseslistBox;
        private System.Windows.Forms.RadioButton Cant200radioButton;
        private System.Windows.Forms.RadioButton Cant150radioButton;
        private System.Windows.Forms.RadioButton Cant250radioButton;
        private System.Windows.Forms.DateTimePicker FechaDepositodateTimePicker;
    }
}