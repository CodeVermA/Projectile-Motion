using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_CreateQuestions : Form
    {
        private int txtbxShown = 0;
        private Question question = new Question();
        private TextBox[] questionsTextBoxes = new TextBox[5];
        private TextBox[] marksTextBoxes = new TextBox[5];
        private Label[] labels = new Label[5];
        List<int> introductionsIDs = new List<int>();

        public fm_CreateQuestions()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_CreateQuestions_Resize);
        }

        public static void Create()
        {
            fm_CreateQuestions fm_CreateQuestions = new fm_CreateQuestions();
            fm_CreateQuestions.Show();
        }//createa new copy of this form

        private void fm_CreateQuestions_Resize(object sender, EventArgs e)
        {
            setupUI();
        }

        private void srlbar_Parts_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_PartsNum.Text = srlbar_Parts.Value.ToString();

            if(!(txtbxShown == Convert.ToInt32(lbl_PartsNum.Text)))
            {
                hide_show_QuestionsUI(false, true);
                hide_show_QuestionsUI(true, false);
                txtbxShown = Convert.ToInt32(lbl_PartsNum.Text);
            }
            
        }

        private void hide_show_QuestionsUI(bool show, bool hide)
        {
            if (show)
            {
                //show textboxes according to user
                for (int x = 0; x < srlbar_Parts.Value; x++)
                {
                    questionsTextBoxes[x].Show();
                    marksTextBoxes[x].Show();
                    labels[x].Show();
                }
            }
            else if (hide)
            {
                //hide all the text boxes except first
                for (int x = 1; x < questionsTextBoxes.Length; x++)
                {
                    questionsTextBoxes[x].Hide();
                    marksTextBoxes[x].Hide();
                    labels[x].Hide();
                }
            }
        } 
        private void addTextBoxesToArray()
        {
            questionsTextBoxes[0] = txtbx_question1;
            questionsTextBoxes[1] = txtbx_question2;
            questionsTextBoxes[2] = txtbx_question3;
            questionsTextBoxes[3] = txtbx_question4;
            questionsTextBoxes[4] = txtbx_question5;


            marksTextBoxes[0] = txtbx_marks1;
            marksTextBoxes[1] = txtbx_marks2;
            marksTextBoxes[2] = txtbx_marks3;
            marksTextBoxes[3] = txtbx_marks4;
            marksTextBoxes[4] = txtbx_marks5;


            labels[0] = lbl_question1;
            labels[1] = lbl_question2;
            labels[2] = lbl_question3;
            labels[3] = lbl_question4;
            labels[4] = lbl_question5;

        }// add question and marks textboxes  and labelsto array 

        private void setupUI()
        {
            dataGrid_MyQuestions.Location = new Point(cmbox_FileTypes.Location.X + cmbox_FileTypes.Width + 10, 5);
            dataGrid_MyQuestions.Height = this.Height - 80;
        }// sets the location of datagridview

        private void fm_CreateQuestions_Load(object sender, EventArgs e)
        {
            dataGrid_MyQuestions.Size = new Size(dataGrid_MyQuestions.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 20, this.Height - 60);
            addTextBoxesToArray();
            hide_show_QuestionsUI(false, true);
            loadQuestions();
        }

        private void loadQuestions()
        {
            int prevoiusIntroID = 0 ;
            int asci = Convert.ToInt32('a');
            DataGridViewRow dataRow = (DataGridViewRow)dataGrid_MyQuestions.Rows[0].Clone();//create a copy of datagridview's fisrt row

            foreach (DataRow row in question.Load(Global.User.ID).Rows)// for combining questions with introduction because one intro can have more than one questions
            {
                if (prevoiusIntroID == Convert.ToInt32(row["IntroductionID"]))
                {
                    dataRow.Cells[1].Value += $"{Convert.ToChar(asci)}> {FormatText(row["Question"].ToString())} \n";
                    dataRow.Cells[2].Value += $"({row["Marks"].ToString()})\n";
                    asci++;
                }
                else
                {
                    dataGrid_MyQuestions.Rows.Add(dataRow);
                    dataRow = (DataGridViewRow)dataGrid_MyQuestions.Rows[0].Clone();
                    asci = Convert.ToInt32('a');

                    dataRow.Cells[0].Value = FormatText(row["Introduction"].ToString());
                    prevoiusIntroID = Convert.ToInt32(row["IntroductionID"]);
                    introductionsIDs.Add((int)row["IntroductionID"]);

                    dataRow.Cells[1].Value += $"{Convert.ToChar(asci)}> {FormatText(row["Question"].ToString())} \n";
                    dataRow.Cells[2].Value += $"({row["Marks"].ToString()})\n";

                    asci++;
                }
            }
            dataGrid_MyQuestions.Rows.Add(dataRow);// adding the last row because the loop above won't add the last row
            if (dataGrid_MyQuestions.Rows.Count > 1 && dataGrid_MyQuestions.Rows[0].Cells[1].Value == null)// deleting the first row as its always going to be empty
            {
                dataGrid_MyQuestions.Rows[0].Visible = false;
            }

        }

        private bool areAllFeildsCorrect()
        {
            bool correct = true;
            int i;
            for (int x = 0; x < questionsTextBoxes.Length; x++)
            { 
                if ((questionsTextBoxes[x].Visible && questionsTextBoxes[x].Text.Trim() == "") ||
                    (marksTextBoxes[x].Visible && !int.TryParse(marksTextBoxes[x].Text.Trim(), out i)))
                {
                    correct = false;
                }
            }

            return correct;
        }// checking if all feilds are filled corectly

        private string FormatText(string text)
        {
            string newText = "";
            int charWritten = 0;

            for(int x = 0; x < text.Length; x++)
            {
                if(charWritten > 100)
                {
                    newText += $"{text[x]}\n";
                    charWritten = 0;
                }
                else
                {
                    newText += text[x];
                    charWritten++;
                }
            }

            return newText;
        }// max lenght of datagridview coloums are 100 so this if for dividing text in 100 chars

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (areAllFeildsCorrect())
            {
                string intro = txtbx_Intro.Text.Trim();
                string[] questions = new string[srlbar_Parts.Value];
                int[] marks = new int[srlbar_Parts.Value];

                //saving question and marks in array
                for (int x = 0; x < srlbar_Parts.Value; x++)
                {
                    questions[x] = questionsTextBoxes[x].Text.Trim();
                    marks[x] = Convert.ToInt32(marksTextBoxes[x].Text.Trim());
                }
                question.Save(intro, questions, marks);
                emptyDataGridView();
                loadQuestions();
            }
            else
            {
                MessageBox.Show("DATA IS NOT FILLED CORRECTLY");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            fm_menu.Create();
            this.Close();
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            if(cmbox_FileTypes.SelectedItem == null || cmbox_FileTypes.SelectedItem.ToString() == "None"  || dataGrid_MyQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Some Feilds are not selected");
            }
            else
            {
                exportQuestions();
            }
        }

        private void exportQuestions()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string path = "";//to store where file is going to save

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog.ShowDialog();//opening the file explorer
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath + @"\";// getting th eselected path
            }

            if (cmbox_FileTypes.SelectedIndex == 1)
            {
                path += addFileName(".txt",path);
                question.Export(path, dataGrid_MyQuestions.SelectedRows);
            }
            else if(cmbox_FileTypes.SelectedIndex == 2)
            {
                path += addFileName(".doc", path);
                question.Export(path, dataGrid_MyQuestions.SelectedRows);
            }
            else if (cmbox_FileTypes.SelectedIndex == 3)
            {
                path += addFileName(".rtf", path);
                question.Export(path, dataGrid_MyQuestions.SelectedRows);
            }
        }  

        private string addFileName(string filetype, string path)
        {
            string filename = $"MyQuestions{filetype}";

            int x = 0;
            bool fileFound = true;

            while (fileFound)
            {
                fileFound = File.Exists(path + filename);//for checking if file with default name exists 
                if (fileFound)
                {
                    filename = $"MyQuestions{x}{filetype}";
                    x++;
                }
            }

            return filename;
        }

        private void txtbx_Intro_TextChanged(object sender, EventArgs e)
        {
            int charNum = txtbx_Intro.Text.Length;
            lbl_CharLimit.Text = $"Char Left: {txtbx_Intro.MaxLength - charNum}/{txtbx_Intro.MaxLength}";
        }// showing how many character left

        private void emptyDataGridView()
        {
            introductionsIDs.Clear();// clearing introductionIDs
            dataGrid_MyQuestions.Rows.Clear();// clearing all rows in datagridview
        }

        private void bt_DeleteQues_Click(object sender, EventArgs e)
        {
            if(dataGrid_MyQuestions.SelectedRows.Count != 0)
            {
                foreach(DataGridViewRow row in dataGrid_MyQuestions.SelectedRows)
                {
                    if(!(row.Index -1 > introductionsIDs.Count - 1))
                    {
                        question.Delete(introductionsIDs[row.Index - 1]);// geting the id of that question
                    }
                }
                emptyDataGridView();
                loadQuestions();
            }

        }
    }
}
