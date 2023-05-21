namespace SeniorProject_CSC490_
{
    partial class SaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.FileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBoredTitle = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveQuitButton = new System.Windows.Forms.Button();
            this.ErrorFieldSave = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(155, 88);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(294, 22);
            this.FileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name:";
            // 
            // SaveBoredTitle
            // 
            this.SaveBoredTitle.AutoSize = true;
            this.SaveBoredTitle.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBoredTitle.Location = new System.Drawing.Point(205, 33);
            this.SaveBoredTitle.Name = "SaveBoredTitle";
            this.SaveBoredTitle.Size = new System.Drawing.Size(171, 36);
            this.SaveBoredTitle.TabIndex = 4;
            this.SaveBoredTitle.Text = "Save Append";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Menu;
            this.SaveButton.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(219, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 36);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveQuitButton
            // 
            this.SaveQuitButton.BackColor = System.Drawing.SystemColors.Menu;
            this.SaveQuitButton.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuitButton.ForeColor = System.Drawing.Color.Red;
            this.SaveQuitButton.Location = new System.Drawing.Point(301, 140);
            this.SaveQuitButton.Name = "SaveQuitButton";
            this.SaveQuitButton.Size = new System.Drawing.Size(75, 36);
            this.SaveQuitButton.TabIndex = 6;
            this.SaveQuitButton.Text = "Cancel";
            this.SaveQuitButton.UseVisualStyleBackColor = false;
            this.SaveQuitButton.Click += new System.EventHandler(this.SaveQuitButton_Click);
            // 
            // ErrorFieldSave
            // 
            this.ErrorFieldSave.Font = new System.Drawing.Font("Franklin Gothic Book", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorFieldSave.Location = new System.Drawing.Point(155, 215);
            this.ErrorFieldSave.Name = "ErrorFieldSave";
            this.ErrorFieldSave.ReadOnly = true;
            this.ErrorFieldSave.Size = new System.Drawing.Size(294, 22);
            this.ErrorFieldSave.TabIndex = 7;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 312);
            this.Controls.Add(this.ErrorFieldSave);
            this.Controls.Add(this.SaveQuitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveBoredTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boredom App Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SaveBoredTitle;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveQuitButton;
        private System.Windows.Forms.TextBox ErrorFieldSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}