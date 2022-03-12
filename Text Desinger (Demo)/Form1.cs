using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Desinger__Demo_
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        String alterText = "";
        String neuerText = "";
        int nächsteZahl = 0;
        RichTextBox aktuelleTextBox = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NewFile_Click(NewFile, EventArgs.Empty);
            TextFiles_TabIndexChanged(TextFiles, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (alterText != neuerText)
            {
                var antwort = MessageBox.Show("Möchtest Du den Text vorher speichern?", "Beenden?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (antwort == DialogResult.Yes)
                {
                    this.SaveFile_Click(this.SaveFile, EventArgs.Empty);

                    Application.Exit();
                } else if (antwort == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (antwort == DialogResult.Cancel)
                {
                    return;
                }
            } else
            {
                Application.Exit();
            }   
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/");
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                aktuelleTextBox.Text = File.ReadAllText(openFileDialog1.FileName);

                alterText = aktuelleTextBox.Text;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(aktuelleTextBox.Text);

                    alterText = aktuelleTextBox.Text;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Paste();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show("Are you sure to clear?", "Clear text", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                aktuelleTextBox.Clear();
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Text = Clipboard.GetText();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(aktuelleTextBox.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            neuerText = aktuelleTextBox.Text;

            if (alterText != neuerText)
            {
                Star.Text = "*";
            } else
            {
                Star.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            nächsteZahl = nächsteZahl + 1;

            var neueSeite = new TabPage();
            neueSeite.Text = "File " + nächsteZahl;

            var neueTextBox = new RichTextBox();
            neueTextBox.Dock = DockStyle.Fill;
            neueSeite.Controls.Add(neueTextBox);

            this.TextFiles.TabPages.Add(neueSeite);

            TextFiles.SelectedTab = neueSeite;
        }

        private void TextFiles_TabIndexChanged(object sender, EventArgs e)
        {
            var aktuelleTabSeite = TextFiles.SelectedTab;
            if (aktuelleTabSeite != null)
            {
                aktuelleTextBox = aktuelleTabSeite.Controls[0] as RichTextBox;
            }
            else
            {
                aktuelleTextBox = null;
            }
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            TextFiles.Controls.Remove(TextFiles.SelectedTab);
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Undo();
        }
    }
}
