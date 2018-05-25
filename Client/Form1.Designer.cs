namespace Client
{
    partial class Form1
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
            this.txtBoxS1 = new System.Windows.Forms.TextBox();
            this.txtBoxS2 = new System.Windows.Forms.TextBox();
            this.txtBoxSonuc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxS1
            // 
            this.txtBoxS1.Location = new System.Drawing.Point(39, 34);
            this.txtBoxS1.Name = "txtBoxS1";
            this.txtBoxS1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxS1.TabIndex = 0;
            // 
            // txtBoxS2
            // 
            this.txtBoxS2.Location = new System.Drawing.Point(165, 34);
            this.txtBoxS2.Name = "txtBoxS2";
            this.txtBoxS2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxS2.TabIndex = 1;
            // 
            // txtBoxSonuc
            // 
            this.txtBoxSonuc.Location = new System.Drawing.Point(405, 37);
            this.txtBoxSonuc.Name = "txtBoxSonuc";
            this.txtBoxSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSonuc.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(291, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxSonuc);
            this.Controls.Add(this.txtBoxS2);
            this.Controls.Add(this.txtBoxS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxS1;
        private System.Windows.Forms.TextBox txtBoxS2;
        private System.Windows.Forms.TextBox txtBoxSonuc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

