
namespace Aufgabenverwaltung
{
    partial class AufgabenEditorForm
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
            this.aufgabeErstellenButton = new System.Windows.Forms.Button();
            this.aufgabeBezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.aufgabeAbgabedatumTextBox = new System.Windows.Forms.TextBox();
            this.aufgabeMitarbeiterTextBox = new System.Windows.Forms.TextBox();
            this.aufgabeErledigungsgradTextBox = new System.Windows.Forms.TextBox();
            this.aufgabeBezeichnungLabel = new System.Windows.Forms.Label();
            this.aufgabeAbgabedatumLabel = new System.Windows.Forms.Label();
            this.aufgabeMitarbeiterLabel = new System.Windows.Forms.Label();
            this.aufgabeErledigungsgradLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aufgabeErstellenButton
            // 
            this.aufgabeErstellenButton.Location = new System.Drawing.Point(61, 138);
            this.aufgabeErstellenButton.Name = "aufgabeErstellenButton";
            this.aufgabeErstellenButton.Size = new System.Drawing.Size(181, 39);
            this.aufgabeErstellenButton.TabIndex = 0;
            this.aufgabeErstellenButton.Tag = "bool ";
            this.aufgabeErstellenButton.Text = "Aufgabe erstellen";
            this.aufgabeErstellenButton.UseVisualStyleBackColor = true;
            this.aufgabeErstellenButton.Click += new System.EventHandler(this.aufgabeErstellenButton_Click);
            // 
            // aufgabeBezeichnungTextBox
            // 
            this.aufgabeBezeichnungTextBox.Location = new System.Drawing.Point(122, 12);
            this.aufgabeBezeichnungTextBox.Name = "aufgabeBezeichnungTextBox";
            this.aufgabeBezeichnungTextBox.Size = new System.Drawing.Size(159, 23);
            this.aufgabeBezeichnungTextBox.TabIndex = 1;
            // 
            // aufgabeAbgabedatumTextBox
            // 
            this.aufgabeAbgabedatumTextBox.Location = new System.Drawing.Point(122, 41);
            this.aufgabeAbgabedatumTextBox.Name = "aufgabeAbgabedatumTextBox";
            this.aufgabeAbgabedatumTextBox.Size = new System.Drawing.Size(159, 23);
            this.aufgabeAbgabedatumTextBox.TabIndex = 2;
            // 
            // aufgabeMitarbeiterTextBox
            // 
            this.aufgabeMitarbeiterTextBox.Location = new System.Drawing.Point(122, 70);
            this.aufgabeMitarbeiterTextBox.Name = "aufgabeMitarbeiterTextBox";
            this.aufgabeMitarbeiterTextBox.Size = new System.Drawing.Size(159, 23);
            this.aufgabeMitarbeiterTextBox.TabIndex = 3;
            // 
            // aufgabeErledigungsgradTextBox
            // 
            this.aufgabeErledigungsgradTextBox.Location = new System.Drawing.Point(122, 99);
            this.aufgabeErledigungsgradTextBox.Name = "aufgabeErledigungsgradTextBox";
            this.aufgabeErledigungsgradTextBox.Size = new System.Drawing.Size(159, 23);
            this.aufgabeErledigungsgradTextBox.TabIndex = 4;
            // 
            // aufgabeBezeichnungLabel
            // 
            this.aufgabeBezeichnungLabel.AutoSize = true;
            this.aufgabeBezeichnungLabel.Location = new System.Drawing.Point(35, 15);
            this.aufgabeBezeichnungLabel.Name = "aufgabeBezeichnungLabel";
            this.aufgabeBezeichnungLabel.Size = new System.Drawing.Size(81, 15);
            this.aufgabeBezeichnungLabel.TabIndex = 5;
            this.aufgabeBezeichnungLabel.Text = "Bezeichnung: ";
            // 
            // aufgabeAbgabedatumLabel
            // 
            this.aufgabeAbgabedatumLabel.AutoSize = true;
            this.aufgabeAbgabedatumLabel.Location = new System.Drawing.Point(27, 45);
            this.aufgabeAbgabedatumLabel.Name = "aufgabeAbgabedatumLabel";
            this.aufgabeAbgabedatumLabel.Size = new System.Drawing.Size(89, 15);
            this.aufgabeAbgabedatumLabel.TabIndex = 6;
            this.aufgabeAbgabedatumLabel.Text = "Abgabedatum: ";
            // 
            // aufgabeMitarbeiterLabel
            // 
            this.aufgabeMitarbeiterLabel.AutoSize = true;
            this.aufgabeMitarbeiterLabel.Location = new System.Drawing.Point(45, 74);
            this.aufgabeMitarbeiterLabel.Name = "aufgabeMitarbeiterLabel";
            this.aufgabeMitarbeiterLabel.Size = new System.Drawing.Size(71, 15);
            this.aufgabeMitarbeiterLabel.TabIndex = 7;
            this.aufgabeMitarbeiterLabel.Text = "Mitarbeiter: ";
            // 
            // aufgabeErledigungsgradLabel
            // 
            this.aufgabeErledigungsgradLabel.AutoSize = true;
            this.aufgabeErledigungsgradLabel.Location = new System.Drawing.Point(17, 103);
            this.aufgabeErledigungsgradLabel.Name = "aufgabeErledigungsgradLabel";
            this.aufgabeErledigungsgradLabel.Size = new System.Drawing.Size(99, 15);
            this.aufgabeErledigungsgradLabel.TabIndex = 8;
            this.aufgabeErledigungsgradLabel.Text = "Erledigungsgrad: ";
            // 
            // AufgabenEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 213);
            this.Controls.Add(this.aufgabeErledigungsgradLabel);
            this.Controls.Add(this.aufgabeMitarbeiterLabel);
            this.Controls.Add(this.aufgabeAbgabedatumLabel);
            this.Controls.Add(this.aufgabeBezeichnungLabel);
            this.Controls.Add(this.aufgabeErledigungsgradTextBox);
            this.Controls.Add(this.aufgabeMitarbeiterTextBox);
            this.Controls.Add(this.aufgabeAbgabedatumTextBox);
            this.Controls.Add(this.aufgabeBezeichnungTextBox);
            this.Controls.Add(this.aufgabeErstellenButton);
            this.Name = "AufgabenEditorForm";
            this.Text = "Aufgaben Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aufgabeErstellenButton;
        private System.Windows.Forms.TextBox aufgabeBezeichnungTextBox;
        private System.Windows.Forms.TextBox aufgabeAbgabedatumTextBox;
        private System.Windows.Forms.TextBox aufgabeMitarbeiterTextBox;
        private System.Windows.Forms.TextBox aufgabeErledigungsgradTextBox;
        private System.Windows.Forms.Label aufgabeBezeichnungLabel;
        private System.Windows.Forms.Label aufgabeAbgabedatumLabel;
        private System.Windows.Forms.Label aufgabeMitarbeiterLabel;
        private System.Windows.Forms.Label aufgabeErledigungsgradLabel;
    }
}