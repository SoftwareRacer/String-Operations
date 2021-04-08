
namespace Übung_20
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLength = new System.Windows.Forms.Button();
            this.cmdChar = new System.Windows.Forms.Button();
            this.cmdTrim = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.cmdSplit = new System.Windows.Forms.Button();
            this.cmdSearchOne = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.cmdSearchAll = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.lblPositionInsert = new System.Windows.Forms.Label();
            this.lblTextInsert = new System.Windows.Forms.Label();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.numInsertPosition = new System.Windows.Forms.NumericUpDown();
            this.numRemoveFrom = new System.Windows.Forms.NumericUpDown();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblRemovePosition = new System.Windows.Forms.Label();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.numRemoveChars = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.numSubstringPosition = new System.Windows.Forms.NumericUpDown();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblWith = new System.Windows.Forms.Label();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.textBoxWith = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubstringPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLength
            // 
            this.cmdLength.Location = new System.Drawing.Point(426, 10);
            this.cmdLength.Name = "cmdLength";
            this.cmdLength.Size = new System.Drawing.Size(75, 23);
            this.cmdLength.TabIndex = 0;
            this.cmdLength.Text = "Länge";
            this.cmdLength.UseVisualStyleBackColor = true;
            this.cmdLength.Click += new System.EventHandler(this.cmdLength_Click);
            // 
            // cmdChar
            // 
            this.cmdChar.Location = new System.Drawing.Point(426, 39);
            this.cmdChar.Name = "cmdChar";
            this.cmdChar.Size = new System.Drawing.Size(75, 23);
            this.cmdChar.TabIndex = 1;
            this.cmdChar.Text = "Zeichen";
            this.cmdChar.UseVisualStyleBackColor = true;
            this.cmdChar.Click += new System.EventHandler(this.cmdChar_Click);
            // 
            // cmdTrim
            // 
            this.cmdTrim.Location = new System.Drawing.Point(426, 68);
            this.cmdTrim.Name = "cmdTrim";
            this.cmdTrim.Size = new System.Drawing.Size(75, 23);
            this.cmdTrim.TabIndex = 2;
            this.cmdTrim.Text = "Trimmen";
            this.cmdTrim.UseVisualStyleBackColor = true;
            this.cmdTrim.Click += new System.EventHandler(this.cmdTrim_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 22);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(52, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Eingabe: ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Ausgabe: ";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(357, 20);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // cmdSplit
            // 
            this.cmdSplit.Location = new System.Drawing.Point(426, 97);
            this.cmdSplit.Name = "cmdSplit";
            this.cmdSplit.Size = new System.Drawing.Size(75, 23);
            this.cmdSplit.TabIndex = 6;
            this.cmdSplit.Text = "Split";
            this.cmdSplit.UseVisualStyleBackColor = true;
            this.cmdSplit.Click += new System.EventHandler(this.cmdSplit_Click);
            // 
            // cmdSearchOne
            // 
            this.cmdSearchOne.Location = new System.Drawing.Point(426, 158);
            this.cmdSearchOne.Name = "cmdSearchOne";
            this.cmdSearchOne.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchOne.TabIndex = 7;
            this.cmdSearchOne.Text = "Suche eins";
            this.cmdSearchOne.UseVisualStyleBackColor = true;
            this.cmdSearchOne.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(351, 135);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Suche: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(401, 132);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 9;
            // 
            // cmdSearchAll
            // 
            this.cmdSearchAll.Location = new System.Drawing.Point(426, 187);
            this.cmdSearchAll.Name = "cmdSearchAll";
            this.cmdSearchAll.Size = new System.Drawing.Size(75, 23);
            this.cmdSearchAll.TabIndex = 10;
            this.cmdSearchAll.Text = "Suche alle";
            this.cmdSearchAll.UseVisualStyleBackColor = true;
            this.cmdSearchAll.Click += new System.EventHandler(this.cmdSearchAll_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(166, 295);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(75, 23);
            this.cmdInsert.TabIndex = 11;
            this.cmdInsert.Text = "Einfügen";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // lblPositionInsert
            // 
            this.lblPositionInsert.AutoSize = true;
            this.lblPositionInsert.Location = new System.Drawing.Point(138, 256);
            this.lblPositionInsert.Name = "lblPositionInsert";
            this.lblPositionInsert.Size = new System.Drawing.Size(64, 13);
            this.lblPositionInsert.TabIndex = 12;
            this.lblPositionInsert.Text = "bei Position:";
            // 
            // lblTextInsert
            // 
            this.lblTextInsert.AutoSize = true;
            this.lblTextInsert.Location = new System.Drawing.Point(138, 215);
            this.lblTextInsert.Name = "lblTextInsert";
            this.lblTextInsert.Size = new System.Drawing.Size(51, 13);
            this.lblTextInsert.TabIndex = 13;
            this.lblTextInsert.Text = "Füge ein:";
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(141, 231);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsert.TabIndex = 14;
            // 
            // numInsertPosition
            // 
            this.numInsertPosition.Location = new System.Drawing.Point(141, 272);
            this.numInsertPosition.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numInsertPosition.Name = "numInsertPosition";
            this.numInsertPosition.Size = new System.Drawing.Size(100, 20);
            this.numInsertPosition.TabIndex = 15;
            this.numInsertPosition.ValueChanged += new System.EventHandler(this.numInsertPosition_ValueChanged);
            // 
            // numRemoveFrom
            // 
            this.numRemoveFrom.Location = new System.Drawing.Point(19, 272);
            this.numRemoveFrom.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numRemoveFrom.Name = "numRemoveFrom";
            this.numRemoveFrom.Size = new System.Drawing.Size(100, 20);
            this.numRemoveFrom.TabIndex = 20;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(16, 215);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(45, 13);
            this.lblRemove.TabIndex = 18;
            this.lblRemove.Text = "Lösche:";
            // 
            // lblRemovePosition
            // 
            this.lblRemovePosition.AutoSize = true;
            this.lblRemovePosition.Location = new System.Drawing.Point(16, 256);
            this.lblRemovePosition.Name = "lblRemovePosition";
            this.lblRemovePosition.Size = new System.Drawing.Size(62, 13);
            this.lblRemovePosition.TabIndex = 17;
            this.lblRemovePosition.Text = "ab Position:";
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(44, 295);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdRemove.TabIndex = 16;
            this.cmdRemove.Text = "Löschen";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // numRemoveChars
            // 
            this.numRemoveChars.Location = new System.Drawing.Point(19, 231);
            this.numRemoveChars.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numRemoveChars.Name = "numRemoveChars";
            this.numRemoveChars.Size = new System.Drawing.Size(100, 20);
            this.numRemoveChars.TabIndex = 21;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(265, 272);
            this.numLength.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(100, 20);
            this.numLength.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Teilstring ab Position:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(262, 256);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 23;
            this.lblLength.Text = "Länge:";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(290, 295);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 22;
            this.cmdShow.Text = "Anzeigen";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // numSubstringPosition
            // 
            this.numSubstringPosition.Location = new System.Drawing.Point(265, 233);
            this.numSubstringPosition.Name = "numSubstringPosition";
            this.numSubstringPosition.Size = new System.Drawing.Size(100, 20);
            this.numSubstringPosition.TabIndex = 27;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(386, 231);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(100, 20);
            this.textBoxReplace.TabIndex = 31;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(383, 215);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(45, 13);
            this.lblReplace.TabIndex = 30;
            this.lblReplace.Text = "Ersetze:";
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Location = new System.Drawing.Point(383, 256);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(37, 13);
            this.lblWith.TabIndex = 29;
            this.lblWith.Text = "durch:";
            // 
            // cmdReplace
            // 
            this.cmdReplace.Location = new System.Drawing.Point(411, 295);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(75, 23);
            this.cmdReplace.TabIndex = 28;
            this.cmdReplace.Text = "Ersetzen";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // textBoxWith
            // 
            this.textBoxWith.Location = new System.Drawing.Point(386, 272);
            this.textBoxWith.Name = "textBoxWith";
            this.textBoxWith.Size = new System.Drawing.Size(100, 20);
            this.textBoxWith.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 330);
            this.Controls.Add(this.textBoxWith);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblWith);
            this.Controls.Add(this.cmdReplace);
            this.Controls.Add(this.numSubstringPosition);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.numRemoveChars);
            this.Controls.Add(this.numRemoveFrom);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblRemovePosition);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.numInsertPosition);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.lblTextInsert);
            this.Controls.Add(this.lblPositionInsert);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdSearchAll);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmdSearchOne);
            this.Controls.Add(this.cmdSplit);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.cmdTrim);
            this.Controls.Add(this.cmdChar);
            this.Controls.Add(this.cmdLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInsertPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubstringPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLength;
        private System.Windows.Forms.Button cmdChar;
        private System.Windows.Forms.Button cmdTrim;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button cmdSplit;
        private System.Windows.Forms.Button cmdSearchOne;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button cmdSearchAll;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Label lblPositionInsert;
        private System.Windows.Forms.Label lblTextInsert;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.NumericUpDown numInsertPosition;
        private System.Windows.Forms.NumericUpDown numRemoveFrom;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblRemovePosition;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.NumericUpDown numRemoveChars;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.NumericUpDown numSubstringPosition;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.Button cmdReplace;
        private System.Windows.Forms.TextBox textBoxWith;
    }
}

