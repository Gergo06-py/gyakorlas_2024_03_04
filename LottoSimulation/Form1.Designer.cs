namespace LottoSimulation
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
            sorsolasButton = new Button();
            closeButton = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(695, 426);
            panel.TabIndex = 0;
            // 
            // sorsolasButton
            // 
            sorsolasButton.Location = new Point(713, 12);
            sorsolasButton.Name = "sorsolasButton";
            sorsolasButton.Size = new Size(75, 23);
            sorsolasButton.TabIndex = 1;
            sorsolasButton.Text = "Sorsolás";
            sorsolasButton.UseVisualStyleBackColor = true;
            sorsolasButton.Click += sorsolasButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(713, 415);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Bezár";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label.AutoSize = true;
            label.Location = new Point(713, 38);
            label.Name = "label1";
            label.Size = new Size(12, 15);
            label.TabIndex = 3;
            label.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(closeButton);
            Controls.Add(sorsolasButton);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button sorsolasButton;
        private Button closeButton;
        private Label label;
    }
}
