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
    public partial class InputLessonForm : Form
    {
        public Lesson lesson = null;
        public InputLessonForm(Lesson lesson = null)
        {
            InitializeComponent();
            if (lesson != null)
            {
                tbName.Text = lesson.Name;
                tbTeacher.Text = lesson.Teacher;
                tbDay.Text = lesson.StrDay;
                tbPair.Text = lesson.Pair.ToString();
                tbRoom.Text = lesson.Room.ToString();
            }
        }

        public void EditOrFind()
        {
            btAction.Text = "Изменить";
            this.ShowDialog();
        }
        private void BtAction_Click(object sender, EventArgs e)
        {
            int pair = 0;
            int room = 0;
            if (Int32.TryParse(tbPair.Text, out pair) && pair > 0 && pair < 10 &&
                Int32.TryParse(tbRoom.Text, out room) && room > 0)
            {
                lesson = new Lesson(tbName.Text, tbTeacher.Text, Lesson.StringToDay(tbDay.Text), pair, room);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные. Повторите ввод.","Ошибка");
            }
        }
    }
}
