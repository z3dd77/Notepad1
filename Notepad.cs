using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad1
{
    public partial class Notepad : Form
    {
        // Create a DataTable to store notes and declare a flag for editing.
        DataTable notes = new DataTable();
        bool editing = false;
        string notesDirectory = "C:\\NotepadFiles"; // Specify the directory to store notes.

        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            // Define columns for the DataTable to store note titles and content.
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            // Create the directory for notes if it doesn't exist.
            if (!Directory.Exists(notesDirectory))
            {
                Directory.CreateDirectory(notesDirectory);
            }

            // Retrieve and load notes from text files in the directory.
            string[] noteFiles = Directory.GetFiles(notesDirectory, "*.txt");

            foreach (string noteFile in noteFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(noteFile);
                string noteContent = File.ReadAllText(noteFile);
                notes.Rows.Add(fileName, noteContent);
            }

            // Bind the DataTable to the DataGridView for displaying notes.
            prevNotes.DataSource = notes;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the title of the selected note and construct the file path.
                string title = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
                string fileName = Path.Combine(notesDirectory, title + ".txt");

                // Delete the corresponding text file.
                File.Delete(fileName);

                notes.Rows.RemoveAt(prevNotes.CurrentCell.RowIndex); // Remove the row from the DataTable.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note: " + ex.Message);
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Get the selected note's title and file path.
            titleBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
            string title = titleBox.Text;
            string fileName = Path.Combine(notesDirectory, title + ".txt");

            if (File.Exists(fileName))
            {
                // Load the content from the corresponding text file.
                noteBox.Text = File.ReadAllText(fileName);
                editing = true;
            }
            else
            {
                noteBox.Text = "File not found.";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(noteBox.Text))
            {
                // Check if both title and note are filled in.
                MessageBox.Show("Both title and note must be filled in.");
                return;
            }

            if (editing)
            {
                // If editing an existing note, update the file and DataTable.
                string oldTitle = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
                string fileName = Path.Combine(notesDirectory, oldTitle + ".txt");
                File.WriteAllText(fileName, noteBox.Text);

                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                // If saving a new note, create a new file and add to the DataTable.
                string fileName = Path.Combine(notesDirectory, titleBox.Text + ".txt");
                File.WriteAllText(fileName, noteBox.Text);

                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }

            // Clear input fields and reset the editing flag.
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // Clear input fields and reset the editing flag for creating a new note.
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double-clicking a note in the DataGridView loads it for editing.
            titleBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
            noteBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"].ToString();
            editing = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input fields and reset the editing flag.
            titleBox.Clear();
            noteBox.Clear();
            editing = false;
        }
    }
}