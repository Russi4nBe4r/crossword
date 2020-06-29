using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crosswords;

namespace Cross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelector = new OpenFileDialog();
            fileSelector.Filter = "All Files (*.txt)|*.txt";
            fileSelector.FilterIndex = 1;

            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                wordsFileBox.Text = fileSelector.FileName;
            }
        }

        private void wordsFileBtn_Click(object sender, EventArgs e)
        {
            List<Word> words = new List<Word>();

            using (StreamReader reader = new StreamReader(wordsFileBox.Text))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine();
                    words.Add(new Word(word));
                }
            }

            CrosswordGenerator generator = new CrosswordGenerator(words);
            generator.Generate();

            int sizeN = generator.blocks.GetLength(0) - 1;
            int sizeM = generator.blocks.GetLength(1) - 1;

            crosswordGridView.Columns.Clear();
            crosswordGridView.Rows.Clear();

            crosswordGridView.BackgroundColor = Color.Black;
            crosswordGridView.DefaultCellStyle.BackColor = Color.Black;

            for (int i = 0; i < sizeN; i++)
                crosswordGridView.Columns.Add("Column", "Column");

            for (int i = 0; i < sizeM; i++)
                crosswordGridView.Rows.Add();

            foreach (DataGridViewColumn c in crosswordGridView.Columns)
                c.Width = 50;

            //set width of row
            foreach (DataGridViewRow r in crosswordGridView.Rows)
                r.Height = 50;

            //set width of column
            foreach (DataGridViewColumn c in crosswordGridView.Columns)
                c.Width = crosswordGridView.Width / crosswordGridView.Columns.Count;

            //set width of row
            foreach (DataGridViewRow r in crosswordGridView.Rows)
                r.Height = crosswordGridView.Height / crosswordGridView.Rows.Count;

            //make all cells read only 
            for (int row = 0; row < crosswordGridView.Rows.Count; row++)
            {
                for (int col = 0; col < crosswordGridView.Columns.Count; col++)
                    crosswordGridView[col, row].ReadOnly = true;
            }

            for (int i = 0; i < sizeN; i++)
            {
                for (int j = 0; j < sizeM; j++)
                {
                    if (generator.blocks[i, j] != null)
                    {
                        crosswordGridView[i, j].Value = generator.blocks[i, j].letter.Character;
                        crosswordGridView[i, j].Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
