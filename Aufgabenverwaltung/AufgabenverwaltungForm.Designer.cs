
namespace Aufgabenverwaltung
{
    partial class aufgabenverwaltungForm
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
            this.aufgabenListBox = new System.Windows.Forms.ListBox();
            this.aufgabeHinzufuegenButton = new System.Windows.Forms.Button();
            this.aufgabeEntfernenButton = new System.Windows.Forms.Button();
            this.aufgabeAendernButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aufgabenListBox
            // 
            this.aufgabenListBox.FormattingEnabled = true;
            this.aufgabenListBox.ItemHeight = 21;
            this.aufgabenListBox.Location = new System.Drawing.Point(12, 12);
            this.aufgabenListBox.Name = "aufgabenListBox";
            this.aufgabenListBox.Size = new System.Drawing.Size(528, 235);
            this.aufgabenListBox.TabIndex = 0;
            // 
            // aufgabeHinzufuegenButton
            // 
            this.aufgabeHinzufuegenButton.Location = new System.Drawing.Point(191, 253);
            this.aufgabeHinzufuegenButton.Name = "aufgabeHinzufuegenButton";
            this.aufgabeHinzufuegenButton.Size = new System.Drawing.Size(163, 36);
            this.aufgabeHinzufuegenButton.TabIndex = 1;
            this.aufgabeHinzufuegenButton.Text = "Aufgabe hinzufügen";
            this.aufgabeHinzufuegenButton.UseVisualStyleBackColor = true;
            this.aufgabeHinzufuegenButton.Click += new System.EventHandler(this.aufgabeHinzufuegenButton_Click);
            // 
            // aufgabeEntfernenButton
            // 
            this.aufgabeEntfernenButton.Location = new System.Drawing.Point(371, 253);
            this.aufgabeEntfernenButton.Name = "aufgabeEntfernenButton";
            this.aufgabeEntfernenButton.Size = new System.Drawing.Size(163, 36);
            this.aufgabeEntfernenButton.TabIndex = 2;
            this.aufgabeEntfernenButton.Text = "Aufgabe entfernen";
            this.aufgabeEntfernenButton.UseVisualStyleBackColor = true;
            this.aufgabeEntfernenButton.Click += new System.EventHandler(this.aufgabeEntfernenButton_Click);
            // 
            // aufgabeAendernButton
            // 
            this.aufgabeAendernButton.Location = new System.Drawing.Point(12, 253);
            this.aufgabeAendernButton.Name = "aufgabeAendernButton";
            this.aufgabeAendernButton.Size = new System.Drawing.Size(163, 36);
            this.aufgabeAendernButton.TabIndex = 3;
            this.aufgabeAendernButton.Text = "Aufgabe ändern";
            this.aufgabeAendernButton.UseVisualStyleBackColor = true;
            this.aufgabeAendernButton.Click += new System.EventHandler(this.aufgabeAendernButton_Click);
            // 
            // aufgabenverwaltungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.aufgabeAendernButton);
            this.Controls.Add(this.aufgabeEntfernenButton);
            this.Controls.Add(this.aufgabeHinzufuegenButton);
            this.Controls.Add(this.aufgabenListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "aufgabenverwaltungForm";
            this.Text = "Aufgabenverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox aufgabenListBox;
        private System.Windows.Forms.Button aufgabeHinzufuegenButton;
        private System.Windows.Forms.Button aufgabeEntfernenButton;
        private System.Windows.Forms.Button aufgabeAendernButton;
    }
}

