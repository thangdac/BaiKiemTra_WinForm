namespace BaiKiemTra_WinForm
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
            this.btnBangcap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBangcap
            // 
            this.btnBangcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangcap.Location = new System.Drawing.Point(391, 12);
            this.btnBangcap.Name = "btnBangcap";
            this.btnBangcap.Size = new System.Drawing.Size(157, 169);
            this.btnBangcap.TabIndex = 0;
            this.btnBangcap.Text = "Bằng Cấp";
            this.btnBangcap.UseVisualStyleBackColor = true;
            this.btnBangcap.Click += new System.EventHandler(this.btnBangcap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.btnBangcap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBangcap;
    }
}

