namespace CarlosLucas
{
    partial class CarlosLucas_Ejercicio3_Form
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
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.NumeracionlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(46, 27);
            this.Mostrarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(304, 35);
            this.Mostrarbutton.TabIndex = 0;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // NumeracionlistBox
            // 
            this.NumeracionlistBox.FormattingEnabled = true;
            this.NumeracionlistBox.ItemHeight = 20;
            this.NumeracionlistBox.Location = new System.Drawing.Point(34, 76);
            this.NumeracionlistBox.Name = "NumeracionlistBox";
            this.NumeracionlistBox.Size = new System.Drawing.Size(316, 404);
            this.NumeracionlistBox.TabIndex = 1;
            // 
            // CarlosLucas_Ejercicio3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 506);
            this.Controls.Add(this.NumeracionlistBox);
            this.Controls.Add(this.Mostrarbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarlosLucas_Ejercicio3_Form";
            this.Text = "CarlosLucas_Ejercicio3_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.ListBox NumeracionlistBox;
    }
}