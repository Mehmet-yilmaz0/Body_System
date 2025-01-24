namespace Body_System
{
    partial class FormBodySystem
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
            ProcessAddButton = new Button();
            TimeIncrease = new Button();
            ProcessNumberTextbox = new TextBox();
            NumberLabel = new Label();
            ProcessSizeLabel = new Label();
            ProcessSizeTextbox = new TextBox();
            ProcessTimeLabel = new Label();
            ProcessTimeTextbox = new TextBox();
            SuspendLayout();
            // 
            // ProcessAddButton
            // 
            ProcessAddButton.Location = new Point(74, 353);
            ProcessAddButton.Name = "ProcessAddButton";
            ProcessAddButton.Size = new Size(87, 23);
            ProcessAddButton.TabIndex = 0;
            ProcessAddButton.Text = "Process Add";
            ProcessAddButton.UseVisualStyleBackColor = true;
            ProcessAddButton.Click += button1_Click;
            // 
            // TimeIncrease
            // 
            TimeIncrease.Location = new Point(613, 353);
            TimeIncrease.Name = "TimeIncrease";
            TimeIncrease.Size = new Size(94, 23);
            TimeIncrease.TabIndex = 2;
            TimeIncrease.Text = "Tıme Increase";
            TimeIncrease.UseVisualStyleBackColor = true;
            TimeIncrease.Click += TimeIncrease_Click;
            // 
            // ProcessNumberTextbox
            // 
            ProcessNumberTextbox.Location = new Point(74, 240);
            ProcessNumberTextbox.Name = "ProcessNumberTextbox";
            ProcessNumberTextbox.Size = new Size(100, 23);
            ProcessNumberTextbox.TabIndex = 3;
            ProcessNumberTextbox.TextChanged += textBox1_TextChanged;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(74, 222);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(51, 15);
            NumberLabel.TabIndex = 4;
            NumberLabel.Text = "Number";
            // 
            // ProcessSizeLabel
            // 
            ProcessSizeLabel.AutoSize = true;
            ProcessSizeLabel.Location = new Point(74, 266);
            ProcessSizeLabel.Name = "ProcessSizeLabel";
            ProcessSizeLabel.Size = new Size(27, 15);
            ProcessSizeLabel.TabIndex = 5;
            ProcessSizeLabel.Text = "Size";
            ProcessSizeLabel.Click += label1_Click;
            // 
            // ProcessSizeTextbox
            // 
            ProcessSizeTextbox.Location = new Point(74, 284);
            ProcessSizeTextbox.Name = "ProcessSizeTextbox";
            ProcessSizeTextbox.Size = new Size(100, 23);
            ProcessSizeTextbox.TabIndex = 6;
            // 
            // ProcessTimeLabel
            // 
            ProcessTimeLabel.AutoSize = true;
            ProcessTimeLabel.Location = new Point(74, 310);
            ProcessTimeLabel.Name = "ProcessTimeLabel";
            ProcessTimeLabel.Size = new Size(33, 15);
            ProcessTimeLabel.TabIndex = 7;
            ProcessTimeLabel.Text = "Time";
            // 
            // ProcessTimeTextbox
            // 
            ProcessTimeTextbox.Location = new Point(74, 328);
            ProcessTimeTextbox.Name = "ProcessTimeTextbox";
            ProcessTimeTextbox.Size = new Size(100, 23);
            ProcessTimeTextbox.TabIndex = 8;
            // 
            // FormBodySystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProcessTimeTextbox);
            Controls.Add(ProcessTimeLabel);
            Controls.Add(ProcessSizeTextbox);
            Controls.Add(ProcessSizeLabel);
            Controls.Add(NumberLabel);
            Controls.Add(ProcessNumberTextbox);
            Controls.Add(TimeIncrease);
            Controls.Add(ProcessAddButton);
            Name = "FormBodySystem";
            Text = "Body System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProcessAddButton;
        private Button TimeIncrease;
        private TextBox ProcessNumberTextbox;
        private Label NumberLabel;
        private Label ProcessSizeLabel;
        private TextBox ProcessSizeTextbox;
        private Label ProcessTimeLabel;
        private TextBox ProcessTimeTextbox;
    }
}