namespace AutoUpdateTest
{
    partial class Main_Window
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
            this.label_MainTitle = new System.Windows.Forms.Label();
            this.button_CheckUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MainTitle
            // 
            this.label_MainTitle.AutoSize = true;
            this.label_MainTitle.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MainTitle.Location = new System.Drawing.Point(92, 46);
            this.label_MainTitle.Name = "label_MainTitle";
            this.label_MainTitle.Size = new System.Drawing.Size(290, 36);
            this.label_MainTitle.TabIndex = 0;
            this.label_MainTitle.Text = "当前版本为:Unknown";
            // 
            // button_CheckUpdate
            // 
            this.button_CheckUpdate.Location = new System.Drawing.Point(178, 163);
            this.button_CheckUpdate.Name = "button_CheckUpdate";
            this.button_CheckUpdate.Size = new System.Drawing.Size(130, 31);
            this.button_CheckUpdate.TabIndex = 2;
            this.button_CheckUpdate.Text = "检查更新";
            this.button_CheckUpdate.UseVisualStyleBackColor = true;
            this.button_CheckUpdate.Click += new System.EventHandler(this.button_CheckUpdate_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 206);
            this.Controls.Add(this.button_CheckUpdate);
            this.Controls.Add(this.label_MainTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 245);
            this.MinimumSize = new System.Drawing.Size(505, 245);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MainTitle;
        private System.Windows.Forms.Button button_CheckUpdate;
    }
}