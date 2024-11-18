namespace MyThreads
{
    partial class FrmTrackThread
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
            labelThreadStarts = new Label();
            buttonRun = new Button();
            SuspendLayout();
            // 
            // labelThreadStarts
            // 
            labelThreadStarts.AutoSize = true;
            labelThreadStarts.Font = new Font("Segoe UI", 19F);
            labelThreadStarts.Location = new Point(209, 120);
            labelThreadStarts.Name = "labelThreadStarts";
            labelThreadStarts.Size = new Size(365, 68);
            labelThreadStarts.TabIndex = 0;
            labelThreadStarts.Text = "-Thread Starts-";
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(277, 265);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(233, 57);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRun);
            Controls.Add(labelThreadStarts);
            Name = "FrmTrackThread";
            Text = "frmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelThreadStarts;
        private Button buttonRun;
    }
}
