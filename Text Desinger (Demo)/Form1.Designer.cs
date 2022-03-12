
namespace Text_Desinger__Demo_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Label();
            this.TextFiles = new System.Windows.Forms.TabControl();
            this.NewFile = new System.Windows.Forms.Button();
            this.CloseFile = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 57);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Youtube";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(400, 20);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(363, 20);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(31, 23);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(12, 289);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(104, 23);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(122, 289);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(104, 23);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text Designer (Demo)";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(232, 289);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(104, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(342, 260);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(104, 23);
            this.Paste.TabIndex = 5;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(342, 289);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(104, 23);
            this.Copy.TabIndex = 6;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Star
            // 
            this.Star.AutoSize = true;
            this.Star.BackColor = System.Drawing.Color.Transparent;
            this.Star.Location = new System.Drawing.Point(12, 72);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(0, 13);
            this.Star.TabIndex = 7;
            this.Star.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextFiles
            // 
            this.TextFiles.Location = new System.Drawing.Point(12, 75);
            this.TextFiles.Name = "TextFiles";
            this.TextFiles.SelectedIndex = 0;
            this.TextFiles.Size = new System.Drawing.Size(434, 179);
            this.TextFiles.TabIndex = 8;
            this.TextFiles.SelectedIndexChanged += new System.EventHandler(this.TextFiles_TabIndexChanged);
            this.TextFiles.TabIndexChanged += new System.EventHandler(this.TextFiles_TabIndexChanged);
            // 
            // NewFile
            // 
            this.NewFile.Location = new System.Drawing.Point(12, 260);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(104, 23);
            this.NewFile.TabIndex = 9;
            this.NewFile.Text = "New File";
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // CloseFile
            // 
            this.CloseFile.Location = new System.Drawing.Point(122, 260);
            this.CloseFile.Name = "CloseFile";
            this.CloseFile.Size = new System.Drawing.Size(104, 23);
            this.CloseFile.TabIndex = 10;
            this.CloseFile.Text = "Close File";
            this.CloseFile.UseVisualStyleBackColor = true;
            this.CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(232, 260);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(104, 23);
            this.Undo.TabIndex = 11;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.CloseFile);
            this.Controls.Add(this.NewFile);
            this.Controls.Add(this.TextFiles);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label Star;
        private System.Windows.Forms.TabControl TextFiles;
        private System.Windows.Forms.Button NewFile;
        private System.Windows.Forms.Button CloseFile;
        private System.Windows.Forms.Button Undo;
    }
}

