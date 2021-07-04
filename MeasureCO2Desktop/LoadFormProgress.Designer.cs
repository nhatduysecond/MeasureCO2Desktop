
namespace MeasureCO2Desktop
{
    partial class LoadFormProgress
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
            this.barLoad = new System.Windows.Forms.ProgressBar();
            this.labelLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barLoad
            // 
            this.barLoad.Location = new System.Drawing.Point(12, 80);
            this.barLoad.Name = "barLoad";
            this.barLoad.Size = new System.Drawing.Size(510, 30);
            this.barLoad.TabIndex = 0;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(9, 64);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(59, 13);
            this.labelLoad.TabIndex = 1;
            this.labelLoad.Text = "Đang tải....";
            // 
            // LoadFormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 181);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.barLoad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadFormProgress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đang tải...";
            this.Load += new System.EventHandler(this.LoadFormProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barLoad;
        private System.Windows.Forms.Label labelLoad;
    }
}