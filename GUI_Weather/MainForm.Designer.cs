namespace GUI_Weather
{
    partial class MainForm
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
            this.btnFetchWeather = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFetchWeather
            // 
            this.btnFetchWeather.Location = new System.Drawing.Point(73, 161);
            this.btnFetchWeather.Name = "btnFetchWeather";
            this.btnFetchWeather.Size = new System.Drawing.Size(148, 57);
            this.btnFetchWeather.TabIndex = 0;
            this.btnFetchWeather.Text = "Check API";
            this.btnFetchWeather.UseVisualStyleBackColor = true;
            this.btnFetchWeather.Click += new System.EventHandler(this.btnFetchWeather_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Control;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLog.Location = new System.Drawing.Point(464, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(336, 477);
            this.txtLog.TabIndex = 1;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(70, 38);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(88, 16);
            this.lblApiKey.TabIndex = 3;
            this.lblApiKey.Text = "Enter API Key";
            this.lblApiKey.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(73, 75);
            this.txtApiKey.Multiline = true;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(296, 49);
            this.txtApiKey.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnFetchWeather);
            this.Name = "MainForm";
            this.Text = "Weather App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetchWeather;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.TextBox txtApiKey;
    }
}

