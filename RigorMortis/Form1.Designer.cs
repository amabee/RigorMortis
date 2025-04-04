namespace RigorMortis
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
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commandTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandTextBox.Location = new System.Drawing.Point(0, 538);
            this.commandTextBox.Multiline = true;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(784, 23);
            this.commandTextBox.TabIndex = 0;
            // 
            // commandBox
            // 
            this.commandBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.commandBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandBox.ForeColor = System.Drawing.Color.Green;
            this.commandBox.Location = new System.Drawing.Point(0, 0);
            this.commandBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.commandBox.Name = "commandBox";
            this.commandBox.ReadOnly = true;
            this.commandBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.commandBox.Size = new System.Drawing.Size(784, 538);
            this.commandBox.TabIndex = 1;
            this.commandBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.commandTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rigor Mortis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.RichTextBox commandBox;
    }
}

