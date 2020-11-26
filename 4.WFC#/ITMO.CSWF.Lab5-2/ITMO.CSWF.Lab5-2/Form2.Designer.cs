namespace ITMO.CSWF.Lab5_2
{
    partial class Form2
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
            this.OpenForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenForm1
            // 
            this.OpenForm1.Location = new System.Drawing.Point(447, 110);
            this.OpenForm1.Name = "OpenForm1";
            this.OpenForm1.Size = new System.Drawing.Size(242, 191);
            this.OpenForm1.TabIndex = 0;
            this.OpenForm1.Text = "OpenForm1";
            this.OpenForm1.UseVisualStyleBackColor = true;
            this.OpenForm1.Click += new System.EventHandler(this.OpenForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.OpenForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenForm1;
    }
}