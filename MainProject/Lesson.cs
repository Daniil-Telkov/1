using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    [Serializable]
    public enum enumDay { Sunday, Monday, Thuesday, Wednesday, Thursday, Friday, Saturday, Null = -1}
    [Serializable]
    public class Lesson
    {
        private string name;
        private string teacher;
        private enumDay day;
        private int pair;
        private int room;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        public string Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                if (value != "")
                {
                    teacher = value;
                }
            }
        }
        public enumDay Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public string StrDay
        {
            get
            {
                return DayToString(day);
            }
            set
            {
                if (StringToDay(value) != enumDay.Null)
                {
                    day = StringToDay(value);
                }
            }
        }
        public int Pair
        {
            get
            {
                return pair;
            }
            set
            {
                if (value > 0 && value < 10)
                {
                    pair = value;
                }
            }
        }
        public int Room
        {
            get
            {
                return room;
            }
            set
            {
                if (value > 0)
                {
                    room = value;
                }
            }
        }
        public Lesson()
        {
            name = "Name";
            teacher = "Teacher";
            day = enumDay.Null;
            pair = 1;
            room = 1;
        }
        public Lesson(string name, string teacher, enumDay day, int pair, int room)
        {
            this.name = name;
            this.teacher = teacher;
            this.day = day;
            this.pair = pair;
            this.room = room;
        }
        public static enumDay StringToDay(string day)
        {
            day = day.Trim();
            if (day.ToLower() == "понедельник")
            {
                return enumDay.Monday;
            }
            if (day.ToLower() == "вторник")
            {
                return enumDay.Thuesday;
            }
            if (day.ToLower() == "среда")
            {
                return enumDay.Wednesday;
            }
            if (day.ToLower() == "четверг")
            {
                return enumDay.Thursday;
            }
            if (day.ToLower() == "пятница")
            {
                return enumDay.Friday;
            }
            if (day.ToLower() == "суббота")
            {
                return enumDay.Saturday;
            }
            if (day.ToLower() == "воскресенье")
            {
                return enumDay.Sunday;
            }
            return enumDay.Null;
        }
        public static string DayToString(enumDay day)
        {
            if (day == enumDay.Monday)
            {
                return "Понедельник";
            }
            if (day == enumDay.Thuesday)
            {
                return "Вторник";
            }
            if (day == enumDay.Wednesday)
            {
                return "Среда";
            }
            if (day == enumDay.Thursday)
            {
                return "Четверг";
            }
            if (day == enumDay.Friday)
            {
                return "Пятница";
            }
            if (day == enumDay.Saturday)
            {
                return "Суббота";
            }
            if (day == enumDay.Sunday)
            {
                return "Воскресенье";
            }
            return "Неизвестно";
        }

        // Проверка строки на правильность
        public static bool CheckRow(DataGridViewRow row)
        {
            if (row.Cells[0].Value.ToString() == "" || row.Cells[1].Value.ToString() == "")
            {
                return false;
            }
            if (Lesson.StringToDay(row.Cells[2].Value.ToString()) == enumDay.Null)
            {
                row.Cells[2].Value = "Неизвестно";
            }
            int pair;
            if (!(Int32.TryParse(row.Cells[3].Value.ToString(), out pair) && pair > 0 && pair < 10))
            {
                return false;
            }
            int room;
            if (!(Int32.TryParse(row.Cells[4].Value.ToString(), out room) && room > 0))
            {
                return false;
            }
            return true;
        }

        // Перевод из строки в экзмепляр Coffee
        public static Lesson RowToLesson(DataGridViewRow row)
        {
            string name = row.Cells[0].Value.ToString();
            string teacher = row.Cells[1].Value.ToString();
            enumDay day = Lesson.StringToDay(row.Cells[2].Value.ToString());
            int pair = Int32.Parse(row.Cells[3].Value.ToString());
            int room = Int32.Parse(row.Cells[4].Value.ToString());
            return new Lesson(name, teacher, day, pair, room);
        }
        // Перевод из Coffee в строку
        public static DataGridViewRow LessonToRow(object obj, DataGridView dgv)
        {
            Lesson lesson = (Lesson)obj;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv);
            row.HeaderCell.Value = (dgv.RowCount + 1).ToString();
            row.Cells[0].Value = lesson.name;
            row.Cells[1].Value = lesson.teacher;
            row.Cells[2].Value = lesson.StrDay;
            row.Cells[3].Value = lesson.pair.ToString();
            row.Cells[4].Value = lesson.room.ToString();
            return row;
        }
    }
}
