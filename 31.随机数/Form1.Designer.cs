namespace _31.随机数
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
            this.LabNumber = new System.Windows.Forms.Label();
            this.TxtBoxNumber = new System.Windows.Forms.TextBox();
            this.BtnNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabNumber
            // 
            this.LabNumber.AutoSize = true;
            this.LabNumber.Location = new System.Drawing.Point(12, 46);
            this.LabNumber.Name = "LabNumber";
            this.LabNumber.Size = new System.Drawing.Size(69, 20);
            this.LabNumber.TabIndex = 0;
            this.LabNumber.Text = "随机数：";
            // 
            // TxtBoxNumber
            // 
            this.TxtBoxNumber.Location = new System.Drawing.Point(99, 46);
            this.TxtBoxNumber.Name = "TxtBoxNumber";
            this.TxtBoxNumber.Size = new System.Drawing.Size(125, 27);
            this.TxtBoxNumber.TabIndex = 1;
            // 
            // BtnNumber
            // 
            this.BtnNumber.Location = new System.Drawing.Point(247, 46);
            this.BtnNumber.Name = "BtnNumber";
            this.BtnNumber.Size = new System.Drawing.Size(94, 29);
            this.BtnNumber.TabIndex = 2;
            this.BtnNumber.Text = "生成随即数";
            this.BtnNumber.UseVisualStyleBackColor = true;
            this.BtnNumber.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 113);
            this.Controls.Add(this.BtnNumber);
            this.Controls.Add(this.TxtBoxNumber);
            this.Controls.Add(this.LabNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabNumber;
        private TextBox TxtBoxNumber;
        private Button BtnNumber;
    }
}