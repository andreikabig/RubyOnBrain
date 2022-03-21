using RubyOnBrain.Data;
using RubyOnBrain.Domain;

namespace RubyOnBrain.TestUI
{
    public partial class Form1 : Form
    {
        //private static DataContext db = new DataContext();
        public Form1()
        {
            InitializeComponent();
           // db.Database.EnsureCreated();
            Refresh();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            ProgLang? plang;
            

            string courseName = tbCourseNameAdd.Text;
            

            if (rbPython.Checked)
            {
                //plang = db.ProgLangs.FirstOrDefault(c => c.Name == rbPython.Text);
            }
            else if (rbCsharp.Checked)
            {
                //plang = db.ProgLangs.FirstOrDefault(c => c.Name == rbCsharp.Text);
            }
            else
            {
                MessageBox.Show("Язык программирования не выбран!");
                return;
            }

            //if (plang != null && !String.IsNullOrEmpty(courseName))
            //{
            //    db.Courses.Add(new Course { Name = courseName, ProgLang = plang });
            //    db.SaveChanges();
            //    MessageBox.Show("Курс успешно добавлен!");
            //    Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("Неправильные данные.");
            //}

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillCourses(CheckedListBox checkbox)
        {
            checkbox.Items.Clear();
            //var coursesNames = db.Courses.Select(x => x.Name);

            //foreach (var course in coursesNames)
            //    checkbox.Items.Add(course);
        }

        private void FillCourses(ListBox listbox)
        {
            listbox.Items.Clear();
            //var coursesNames = db.Courses.Select(x => x.Name);

            //foreach (var course in coursesNames)
            //    listbox.Items.Add(course);
        }

        private void FillTopics()
        {
            checkTopicForAdd.Items.Clear();

            string? _checked = checkCourseForAdd.SelectedItem.ToString();
            //var course = db.Courses.FirstOrDefault(x => x.Name == _checked);
            //if (_checked != null && course != null)
            //{
            //    //foreach (var topic in db.Topics.Where(x => x.CourseId == course.Id).Select(x => x.Name))
            //    {
            //        checkTopicForAdd.Items.Add(topic);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Что-то пошло не так!");
            //}
        }

        private new void Refresh()
        {
            FillCourses(checkCourse);
            FillCourses(checkCourseForAdd);
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            string topicName = tbTopicName.Text;
            var checkedItems = checkCourse.CheckedItems;

            string? courseName;
            switch (checkedItems.Count)
            {
                case 0:
                    MessageBox.Show("Курс не был выбран!");
                    return;
                case 1:
                    courseName = checkedItems[0].ToString();
                    break;
                default:
                    MessageBox.Show("Выберите один курс!");
                    return;
            }

            //var findedCourse = db.Courses.FirstOrDefault(x => x.Name == courseName);

            //if (!String.IsNullOrEmpty(topicName) && findedCourse != null)
            //{
            //    //db.Topics.Add(new Topic { Name = topicName, Course = findedCourse });
            //    //db.SaveChanges();
            //    MessageBox.Show("Топик успешно добавлен!");
            //}
            //else
            //{
            //    MessageBox.Show("Введите название раздела!");
            //}
        }

        private void checkCourseForAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTopics();
        }

        private void btnAddEntrie_Click(object sender, EventArgs e)
        {
            string topicName = checkTopicForAdd.Text;
            string text = rtbEntry.Text;
            string title = tbEntryTitle.Text;
            string entryTypeName;

            if (rbCode.Checked)
            {
                entryTypeName = rbCode.Text;
            }
            else if (rbText.Checked)
            {
                entryTypeName = rbText.Text;
            }
            else
            {
                MessageBox.Show("Выберите тип содержания!");
                return;
            }

            //var topic = db.Topics.FirstOrDefault(x => x.Name == topicName);
            //var entryType = db.EntryTypes.FirstOrDefault(x => x.Name == entryTypeName);
            //if (topic != null && entryType != null && !String.IsNullOrEmpty(text) && !String.IsNullOrEmpty(title))
            //{
            //    db.Entries.Add(new Entry {Topic = topic, ImgName = "", Text = text, Title = title, EntryType = entryType, VideoName = ""});
            //    db.SaveChanges();
            //    MessageBox.Show("Абзац успешно добавлен!");
            //    rtbEntry.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка заполнения формы!");
            //}
        }
    }
}