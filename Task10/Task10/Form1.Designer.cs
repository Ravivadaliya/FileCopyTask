namespace Task10
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
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceSelect = new System.Windows.Forms.Button();
            this.DestinationSelect = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.Sourcelabel = new System.Windows.Forms.Label();
            this.Destinationlabel = new System.Windows.Forms.Label();
            this.TransferPercentage = new System.Windows.Forms.Label();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(25, 41);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(399, 22);
            this.SourceTextBox.TabIndex = 0;
            // 
            // SourceSelect
            // 
            this.SourceSelect.Location = new System.Drawing.Point(430, 40);
            this.SourceSelect.Name = "SourceSelect";
            this.SourceSelect.Size = new System.Drawing.Size(75, 23);
            this.SourceSelect.TabIndex = 2;
            this.SourceSelect.Text = "..........";
            this.SourceSelect.UseVisualStyleBackColor = true;
            this.SourceSelect.Click += new System.EventHandler(this.SourceSelect_Click);
            // 
            // DestinationSelect
            // 
            this.DestinationSelect.Location = new System.Drawing.Point(1183, 40);
            this.DestinationSelect.Name = "DestinationSelect";
            this.DestinationSelect.Size = new System.Drawing.Size(75, 23);
            this.DestinationSelect.TabIndex = 3;
            this.DestinationSelect.Text = "..........";
            this.DestinationSelect.UseVisualStyleBackColor = true;
            this.DestinationSelect.Click += new System.EventHandler(this.DestinationSelect_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(325, 275);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(662, 63);
            this.progressBar.TabIndex = 4;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(430, 159);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(132, 50);
            this.Startbutton.TabIndex = 5;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(755, 159);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(130, 50);
            this.Stopbutton.TabIndex = 6;
            this.Stopbutton.Text = "Pause";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(774, 40);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(403, 22);
            this.DestinationTextBox.TabIndex = 7;
            // 
            // Sourcelabel
            // 
            this.Sourcelabel.AutoSize = true;
            this.Sourcelabel.Location = new System.Drawing.Point(179, 9);
            this.Sourcelabel.Name = "Sourcelabel";
            this.Sourcelabel.Size = new System.Drawing.Size(50, 16);
            this.Sourcelabel.TabIndex = 8;
            this.Sourcelabel.Text = "Source";
            // 
            // Destinationlabel
            // 
            this.Destinationlabel.AutoSize = true;
            this.Destinationlabel.Location = new System.Drawing.Point(960, 9);
            this.Destinationlabel.Name = "Destinationlabel";
            this.Destinationlabel.Size = new System.Drawing.Size(74, 16);
            this.Destinationlabel.TabIndex = 9;
            this.Destinationlabel.Text = "Destination";
            // 
            // TransferPercentage
            // 
            this.TransferPercentage.AutoSize = true;
            this.TransferPercentage.Location = new System.Drawing.Point(934, 236);
            this.TransferPercentage.Name = "TransferPercentage";
            this.TransferPercentage.Size = new System.Drawing.Size(0, 16);
            this.TransferPercentage.TabIndex = 10;
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(599, 159);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(121, 50);
            this.ResumeButton.TabIndex = 11;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 518);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.TransferPercentage);
            this.Controls.Add(this.Destinationlabel);
            this.Controls.Add(this.Sourcelabel);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.DestinationSelect);
            this.Controls.Add(this.SourceSelect);
            this.Controls.Add(this.SourceTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Button SourceSelect;
        private System.Windows.Forms.Button DestinationSelect;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label Sourcelabel;
        private System.Windows.Forms.Label Destinationlabel;
        private System.Windows.Forms.Label TransferPercentage;
        private System.Windows.Forms.Button ResumeButton;
    }
}

