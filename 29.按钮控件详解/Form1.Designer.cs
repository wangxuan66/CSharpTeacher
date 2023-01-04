namespace _29.按钮控件详解
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
            this.BtnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSayHi
            // 
            this.BtnSayHi.Location = new System.Drawing.Point(512, 210);
            this.BtnSayHi.Name = "BtnSayHi";
            this.BtnSayHi.Size = new System.Drawing.Size(94, 29);
            this.BtnSayHi.TabIndex = 0;
            this.BtnSayHi.Text = "打招呼";
            this.BtnSayHi.UseVisualStyleBackColor = true;
            this.BtnSayHi.Click += new System.EventHandler(this.BtnSayHi_Click);
            this.BtnSayHi.MouseEnter += new System.EventHandler(this.BtnSayHi_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSayHi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSayHi;
    }
}