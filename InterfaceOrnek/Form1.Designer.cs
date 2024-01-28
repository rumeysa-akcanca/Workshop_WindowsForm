namespace InterfaceOrnek
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
            this.btnGaranti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGaranti
            // 
            this.btnGaranti.Location = new System.Drawing.Point(100, 84);
            this.btnGaranti.Name = "btnGaranti";
            this.btnGaranti.Size = new System.Drawing.Size(107, 54);
            this.btnGaranti.TabIndex = 0;
            this.btnGaranti.Text = "Garanti";
            this.btnGaranti.UseVisualStyleBackColor = true;
            this.btnGaranti.Click += new System.EventHandler(this.btnGaranti_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ziraat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGaranti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGaranti;
        private Button button2;
    }
}