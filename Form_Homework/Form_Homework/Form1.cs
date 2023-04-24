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

        public static Form1 sform1;
        private void buttonHello_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;//設置Form1是父窗體
            FormHello formHello = new FormHello();
            formHello.MdiParent = this;//設置窗體的父子關係
            formHello.Parent = splitContainer2.Panel2;//子窗體的容器是父窗體的panel2
            formHello.TopLevel = false;//必須關閉,否則衝突
            this.splitContainer2.Panel2.Controls.Add(formHello);//將formHello添加到penel中
            formHello.Show();
            formHello.BringToFront();
        }

        private void buttonLoan_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormLoan formLoan = new FormLoan();
            formLoan.MdiParent = this;
            formLoan.Parent = splitContainer2.Panel2;
            formLoan.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formLoan);
            formLoan.Show();
            formLoan.BringToFront();

        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormPos formPos = new FormPos();
            formPos.MdiParent = this;
            formPos.Parent = splitContainer2.Panel2;
            formPos.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formPos);
            formPos.Show();
            formPos.BringToFront();
        }

        private void buttonStudentStructForm_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormStudent_Struct formStudent_Struct = new FormStudent_Struct();
            formStudent_Struct.MdiParent = this;
            formStudent_Struct.Parent = splitContainer2.Panel2;
            formStudent_Struct.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formStudent_Struct);
            formStudent_Struct.Show();
            formStudent_Struct.BringToFront();
        }

        private void buttonStudentGrade_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormStudentGrade formStudentGrade = new FormStudentGrade();
            formStudentGrade.MdiParent = this;
            formStudentGrade.Parent = splitContainer2.Panel2;
            formStudentGrade.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formStudentGrade);
            formStudentGrade.Show();
            formStudentGrade.BringToFront();
        }

        private void buttonStudentGradeList_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormStudentGradeList formStudentGradeList = new FormStudentGradeList();
            formStudentGradeList.MdiParent = this;
            formStudentGradeList.Parent = splitContainer2.Panel2;
            formStudentGradeList.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formStudentGradeList);
            formStudentGradeList.Show();
            formStudentGradeList.BringToFront();
        }

        private void buttonMethod_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormMethod formMethod = new FormMethod();
            formMethod.MdiParent = this;
            formMethod.Parent = splitContainer2.Panel2;
            formMethod.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formMethod);
            formMethod.Show();
            formMethod.BringToFront();
        }

        private void buttonMyClac_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormMyClac formMyclac = new FormMyClac();
            formMyclac.MdiParent = this;
            formMyclac.Parent = splitContainer2.Panel2;
            formMyclac.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formMyclac);
            formMyclac.Show();
            formMyclac.BringToFront();
        }

        private void buttonForDoWhile_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormForDoWhile formForDowhile = new FormForDoWhile();
            formForDowhile.MdiParent = this;
            formForDowhile.Parent = splitContainer2.Panel2;
            formForDowhile.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formForDowhile);
            formForDowhile.Show();
            formForDowhile.BringToFront();
        }

        private void buttonScreenSaver_Click(object sender, EventArgs e)
        {
            FormScreenSaver formScreenSaver = new FormScreenSaver();
            formScreenSaver.Show();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormDraw formDraw = new FormDraw();
            formDraw.MdiParent = this;
            formDraw.Parent = splitContainer2.Panel2;
            formDraw.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formDraw);
            formDraw.Show();
            formDraw.BringToFront();
        }

        private void buttonNotePad_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormNotepad formNotepad = new FormNotepad();
            formNotepad.MdiParent = this;
            formNotepad.Parent = splitContainer2.Panel2;
            formNotepad.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formNotepad);
            formNotepad.Show();
            formNotepad.BringToFront();
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormAlarm formalarm = new FormAlarm();
            formalarm.MdiParent = this;
            formalarm.Parent = splitContainer2.Panel2;
            formalarm.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formalarm);
            formalarm.Show();
            formalarm.BringToFront();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormGuess formguess = new FormGuess();
            formguess.MdiParent = this;
            formguess.Parent = splitContainer2.Panel2;
            formguess.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formguess);
            formguess.Show();
            formguess.BringToFront();
        }

        private void buttonXOGame_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormXOGame formxogame = new FormXOGame();
            formxogame.MdiParent = this;
            formxogame.Parent = splitContainer2.Panel2;
            formxogame.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formxogame);
            formxogame.Show();
            formxogame.BringToFront();
        }

        private void buttonPictureViewer_Click(object sender, EventArgs e)
        {
            sform1 = this;
            this.IsMdiContainer = true;
            FormPictureViewer formPictureViewer = new FormPictureViewer();
            formPictureViewer.MdiParent = this;
            formPictureViewer.Parent = splitContainer2.Panel2;
            formPictureViewer.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(formPictureViewer);
            formPictureViewer.Show();
            formPictureViewer.BringToFront();
        }
    }
}
