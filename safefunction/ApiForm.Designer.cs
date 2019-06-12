namespace safefunction
{
    partial class ApiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiForm));
            this.apiTokenTextBox = new System.Windows.Forms.TextBox();
            this.apiGoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apiTokenTextBox
            // 
            this.apiTokenTextBox.Location = new System.Drawing.Point(12, 38);
            this.apiTokenTextBox.Name = "apiTokenTextBox";
            this.apiTokenTextBox.Size = new System.Drawing.Size(370, 22);
            this.apiTokenTextBox.TabIndex = 0;
            // 
            // apiGoButton
            // 
            this.apiGoButton.Location = new System.Drawing.Point(265, 66);
            this.apiGoButton.Name = "apiGoButton";
            this.apiGoButton.Size = new System.Drawing.Size(117, 54);
            this.apiGoButton.TabIndex = 1;
            this.apiGoButton.Text = "Controleren";
            this.apiGoButton.UseVisualStyleBackColor = true;
            this.apiGoButton.Click += new System.EventHandler(this.apiGoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vul uw api sleutel (opnieuw) in.";
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiGoButton);
            this.Controls.Add(this.apiTokenTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApiForm";
            this.Text = "ApiForm";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiTokenTextBox;
        private System.Windows.Forms.Button apiGoButton;
        private System.Windows.Forms.Label label1;
    }
}