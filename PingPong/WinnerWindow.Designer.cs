namespace PingPong
{
    partial class winnerWindow
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
            this.winnerLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerLabel.Location = new System.Drawing.Point(90, 42);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(112, 34);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "You won!";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel
            // 
            this.exitLabel.Location = new System.Drawing.Point(90, 134);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(112, 34);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Exit";
            this.exitLabel.UseVisualStyleBackColor = true;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // winnerWindow
            // 
            this.AcceptButton = this.exitLabel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 223);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.winnerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "winnerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winnerWindow_FormClosing);
            this.Load += new System.EventHandler(this.winnerWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label winnerLabel;
        private Button exitLabel;
    }
}