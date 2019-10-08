using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MainForm : Form
    {
        // Класс для работы с файлами
        FileManager fm = null;
        FileType fileType;
        
        public MainForm()
        {
            InitializeComponent();
            dgv.TopLeftHeaderCell.Value = "№";
            fm = new FileManager(dgv, "");
            fm.SetRowCheck(Lesson.CheckRow);
            fm.SetRowToObject(Lesson.RowToLesson);
            fm.SetObjectToRow(Lesson.LessonToRow);
        }
        // Обновление индексов
        public void RefreshIndex()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            InputLessonForm inForm = new InputLessonForm();
            if (inForm.ShowDialog() == DialogResult.OK)
            {
                dgv.Rows.Add(Lesson.LessonToRow(inForm.lesson, dgv));
            }
            inForm.Dispose();
        }
        private void ChangeRow(DataGridViewRow row)
        {
            InputLessonForm inForm = new InputLessonForm(Lesson.RowToLesson(row));
            inForm.EditOrFind();
            if (inForm.DialogResult == DialogResult.OK)
            {
                int index = row.Index;
                dgv.Rows.RemoveAt(index);
                dgv.Rows.Insert(index, Lesson.LessonToRow(inForm.lesson, dgv));
                RefreshIndex();
            }
            inForm.Dispose();
        }
        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeRow(dgv.SelectedRows[0]);
        }
        private void BtFind_Click(object sender, EventArgs e)
        {
            InputForm inForm = new InputForm("Введите сорт:");
            int index = -1;
            if (inForm.ShowDialog() == DialogResult.OK && inForm.inText != "")
            {
                try
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value.ToString().ToLower() == inForm.inText.ToLower())
                        {
                            index = row.Index;
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Такого сорта нет", "Ошибка");
                }
            }
            inForm.Dispose();
            if (index != -1)
            {
                ChangeRow(dgv.Rows[index]);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row);
                }
                RefreshIndex();
            }
        }

        private void BtTask_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm("Введите день недели");
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                enumDay day = Lesson.StringToDay(inputForm.inText);
                if (day == enumDay.Null)
                {
                    MessageBox.Show("Вы ввели некорректный день", "Ошибка");
                    return;
                }
                List<DataGridViewRow> rowList = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Lesson.StringToDay(row.Cells[2].Value.ToString()) != day)
                    {
                        rowList.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rowList)
                {
                    dgv.Rows.Remove(row);
                }
                dgv.Sort(dgv.Columns[3], ListSortDirection.Ascending);
            }
        }

        private void MenuOpenText_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(openFileDialog.FileName);
                fm.Load(FileType.Text);
                fileType = FileType.Text;
            }
        }

        private void MenuSaveAsText_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(saveFileDialog.FileName);
                fm.Save(FileType.Text);
                fileType = FileType.Text;
            }
        }

        private void MenuSaveAsBinary_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(saveFileDialog.FileName);
                fm.Save(FileType.Binary);
                fileType = FileType.Binary;
            }
        }

        private void MenuOpenBinary_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(openFileDialog.FileName);
                fm.Load(FileType.Binary);
                fileType = FileType.Binary;
            }
        }

        private void MenuOpenXml_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(openFileDialog.FileName);
                fm.Load(FileType.XML);
                fileType = FileType.XML;
            }
        }

        private void MenuSaveAsXml_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.SetFilepath(saveFileDialog.FileName);
                fm.Save(FileType.XML);
                fileType = FileType.XML;
            }
        }

        private void Dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void Dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            fm.Save(fileType);
        }
    }
}
