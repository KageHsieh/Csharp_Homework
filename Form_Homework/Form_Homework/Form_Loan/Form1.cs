using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonHello_Click(object sender, EventArgs e)
        {
            FormHello formHello = new FormHello();
            formHello.Show();
        }

        private void buttonLoan_Click(object sender, EventArgs e)
        {
            FormLoan formLoan = new FormLoan();
            formLoan.Show();
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            FormPos formPos = new FormPos();
            formPos.Show();
        }

        private void buttonStudentStructForm_Click(object sender, EventArgs e)
        {
            FormStudent_Struct formPos = new FormStudent_Struct();
            formPos.Show();
        }

        private void buttonStudentGrade_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudentGradeList_Click(object sender, EventArgs e)
        {

        }

        private void buttonMethod_Click(object sender, EventArgs e)
        {

        }

        private void buttonMyClac_Click(object sender, EventArgs e)
        {
            FormMyClac formMyclac = new FormMyClac();
            formMyclac.Show();
        }

        private void buttonForDoWhile_Click(object sender, EventArgs e)
        {
            FormForDoWhile formForDowhile = new FormForDoWhile();
            formForDowhile.Show();
        }

        private void buttonScreenSaver_Click(object sender, EventArgs e)
        {
            FormScreenSaver formScreenSaver = new FormScreenSaver();
            formScreenSaver.Show();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            FormDraw formDraw = new FormDraw();
            formDraw.Show();
        }

        private void buttonNotePad_Click(object sender, EventArgs e)
        {
            FormNotepad formNotepad = new FormNotepad();
            formNotepad.Show();
        }
    }
}
