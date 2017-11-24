using System;
using System.Windows.Forms;

namespace Labsheet10
{
    public partial class MainForm : Form
    {
        const int MAX_PERSON = 3;

        const string TEXT_CURRENTCY = "Baht";
        const string TEXT_FORMAT_CURRENT_PERSON = "Pocket : {0} : {1}";
        const string TEXT_FORMAT_CURRENT_MONEY = "Money : {0} " + TEXT_CURRENTCY;


        Person[] arryPerson;
        int currentIndex;


        public MainForm()
        {
            InitializeComponent();
            _Initialize();
            _BindEvent();
        }

        void _Initialize()
        {
            currentIndex = 0;
            arryPerson = new Person[MAX_PERSON] {
                new Person("T.Keng", 54000),
                new Person("T.Kong", 35000),
                new Person("T.Montri", 64000)
            };
        }

        void _BindEvent()
        {
            this.Load += _UpdateUI;
            btnNext.Click += _UpdateUI;
            btnPrevious.Click += _UpdateUI;
            btnRestore.Click += _UpdateUI;
            btnRemove.Click += _UpdateUI;
        }

        void _UpdateUI(object sender, EventArgs e)
        {
            lblCurrentPerson.Text = String.Format(
                TEXT_FORMAT_CURRENT_PERSON,
                currentIndex + 1,
                arryPerson[currentIndex].Info.Name
            );

            lblCurrentMoney.Text = String.Format(
                TEXT_FORMAT_CURRENT_MONEY,
                arryPerson[currentIndex].Money.Current
            );

            btnNext.Enabled = (currentIndex + 1) < MAX_PERSON;
            btnPrevious.Enabled = (currentIndex - 1) >= 0;
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            _NextInfo();
        }

        void btnPrevious_Click(object sender, EventArgs e)
        {
            _PreviousInfo();
        }

        void _NextInfo()
        {
            var temp = (currentIndex + 1);
            currentIndex = (temp < MAX_PERSON) ? temp : (MAX_PERSON - 1);
        }

        void _PreviousInfo()
        {
            var temp = (currentIndex - 1);
            currentIndex = (temp < 0) ? 0 : temp;
        }

        void btnRestore_Click(object sender, EventArgs e)
        {
            arryPerson[currentIndex].Money.Restore(10);
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            arryPerson[currentIndex].Money.Remove(10);
        }
    }
}
