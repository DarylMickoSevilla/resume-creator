namespace Resume_Creator
{
    partial class ResumeCreator
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
            this.OpenFilebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenFilebtn
            // 
            this.OpenFilebtn.Location = new System.Drawing.Point(53, 315);
            this.OpenFilebtn.Name = "OpenFilebtn";
            this.OpenFilebtn.Size = new System.Drawing.Size(101, 23);
            this.OpenFilebtn.TabIndex = 0;
            this.OpenFilebtn.Text = "Open JSON File";
            this.OpenFilebtn.UseVisualStyleBackColor = true;
            this.OpenFilebtn.Click += new System.EventHandler(this.OpenFilebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(525, 315);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 1;
            this.Savebtn.Text = "Save PDF";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(43, 23);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(571, 264);
            this.InfoBox.TabIndex = 2;
            this.InfoBox.Text = "";
            // 
            // ResumeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.OpenFilebtn);
            this.Name = "ResumeCreator";
            this.Text = "Resume Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenFilebtn;
        private Button Savebtn;
        private RichTextBox InfoBox;
    }
}