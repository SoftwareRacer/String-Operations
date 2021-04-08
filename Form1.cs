using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Übung_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLength_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Länge: " + textBox.Text.Length;
        }

        private void cmdChar_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Zeichen:";

            for(int i = 0; i < textBox.TextLength; i++)
            {
                lblOutput.Text += "\n" + i + ": " + textBox.Text[i];
            }
        }

        private void cmdTrim_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Getrimmt: |" + textBox.Text.Trim(' ', '_', '*', '-') + "|";
        }

        private void cmdSplit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Worte: ";
            String[] words = textBox.Text.Split(';');

            for(int i = 0; i < words.Length; i++)
            {
                lblOutput.Text += "\nWort " + i + ": " + words[i];
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (textBox.Text.IndexOf(textBoxSearch.Text) != -1)
            {
                lblOutput.Text = "Suchtext bei Zeichen: " + textBox.Text.IndexOf(textBoxSearch.Text);
            }
            else
            {
                lblOutput.Text = "Suchtext nicht vorhanden.";
            }
        }

        private void cmdSearchAll_Click(object sender, EventArgs e)
        {
            int index = 0, count = 0, start = 0;
            lblOutput.Text = "Suchtext bei Zeichen: ";
            do
            {
                index = textBox.Text.IndexOf(textBoxSearch.Text, start) + 1;
                lblOutput.Text += "\n" + index;
                count++;

                if (index < textBox.TextLength)
                {
                    start = index + 1;
                }
                else
                {
                    break;
                }
            }
            while (index != -1);

            lblOutput.Text += "\nAnzahl: " + count;
        }

        private void numInsertPosition_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            lblOutput.Text = textBox.Text.Insert((int)numInsertPosition.Value, textBoxInsert.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
            {
                numInsertPosition.Maximum = textBox.TextLength - 1;
                numRemoveChars.Maximum = textBox.TextLength - 1;
                numLength.Maximum = textBox.TextLength - 1;
                numRemoveFrom.Maximum = textBox.TextLength - 1;
                numSubstringPosition.Maximum = textBox.TextLength - 1;
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            lblOutput.Text = textBox.Text.Remove((int)numRemoveFrom.Value, (int)numRemoveChars.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            lblOutput.Text = textBox.Text.Substring((int)numSubstringPosition.Value, (int)numLength.Value);
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            lblOutput.Text = textBox.Text.Replace(textBoxReplace.Text, textBoxWith.Text);
        }
    }
}
