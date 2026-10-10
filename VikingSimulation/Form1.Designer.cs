namespace VikingSimulation
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
            panel = new Panel();
            btnClose = new Button();
            btnSorsol = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(38, 52);
            panel.Name = "panel";
            panel.Size = new Size(599, 406);
            panel.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(708, 126);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "Bezár";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSorsol
            // 
            btnSorsol.Location = new Point(708, 52);
            btnSorsol.Name = "btnSorsol";
            btnSorsol.Size = new Size(131, 40);
            btnSorsol.TabIndex = 1;
            btnSorsol.Text = "Sorsol";
            btnSorsol.UseVisualStyleBackColor = true;
            btnSorsol.Click += btnSorsol_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(708, 208);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(68, 30);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 521);
            Controls.Add(lblInfo);
            Controls.Add(btnSorsol);
            Controls.Add(btnClose);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button btnClose;
        private Button btnSorsol;
        private Label lblInfo;
    }
}
