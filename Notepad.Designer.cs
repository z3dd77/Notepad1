namespace Notepad1
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prevNotes = new DataGridView();
            readButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            newButton = new Button();
            label3 = new Label();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)prevNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.BackColor = SystemColors.ControlDarkDark;
            titleBox.ForeColor = SystemColors.Info;
            titleBox.Location = new Point(413, 41);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(375, 23);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.BackColor = SystemColors.ControlDarkDark;
            noteBox.ForeColor = SystemColors.Info;
            noteBox.Location = new Point(413, 92);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(375, 346);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(413, 7);
            label1.Name = "label1";
            label1.Size = new Size(375, 31);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(413, 67);
            label2.Name = "label2";
            label2.Size = new Size(375, 26);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // prevNotes
            // 
            prevNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prevNotes.BackgroundColor = SystemColors.ControlDarkDark;
            prevNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prevNotes.GridColor = SystemColors.ControlDarkDark;
            prevNotes.Location = new Point(12, 41);
            prevNotes.Name = "prevNotes";
            prevNotes.RowTemplate.Height = 25;
            prevNotes.Size = new Size(387, 368);
            prevNotes.TabIndex = 4;
            prevNotes.CellDoubleClick += prevNotes_CellDoubleClick;
            // 
            // readButton
            // 
            readButton.BackColor = Color.Gold;
            readButton.Location = new Point(12, 415);
            readButton.Name = "readButton";
            readButton.Size = new Size(73, 23);
            readButton.TabIndex = 5;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = false;
            readButton.Click += readButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Gold;
            deleteButton.Location = new Point(91, 415);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(73, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Gold;
            saveButton.Location = new Point(170, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(73, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = Color.Cyan;
            newButton.Location = new Point(249, 415);
            newButton.Name = "newButton";
            newButton.Size = new Size(73, 23);
            newButton.TabIndex = 8;
            newButton.Text = "New Note";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(375, 31);
            label3.TabIndex = 9;
            label3.Text = "Your Notes!";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Location = new Point(328, 415);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(73, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(label3);
            Controls.Add(newButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(readButton);
            Controls.Add(prevNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Notepad";
            Text = "Notepad by Zee";
            Load += Notepad_Load;
            ((System.ComponentModel.ISupportInitialize)prevNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView prevNotes;
        private Button readButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newButton;
        private Label label3;
        private Button clearButton;
    }
}