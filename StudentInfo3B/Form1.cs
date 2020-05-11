using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo3B
{
    public partial class Form1 : Form
    {
        private School school = null;
        private StudentInfoModelContainer dbContext;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisableEventHandlers()
        {
            //this.departmentsDropDownList.SelectedValueChanged -= this.departmentsDropDownList_SelectedValueChanged;
            //this.termsDropDownList.SelectedValueChanged -= this.termsDropDownList_SelectedValueChanged;
            //this.coursesDropDownList.SelectedValueChanged -= this.coursesDropDownList_SelectedValueChanged;
            //this.sectionsDropDownList.SelectedValueChanged -= this.sectionsDropDownList_SelectedValueChanged;
            //this.enrollmentsListBox.SelectedValueChanged -= this.enrollmentsListBox_SelectedValueChanged;
            //this.assignmentsListBox.SelectedValueChanged -= this.assignmentsListBox_SelectedValueChanged;
        }

        private void EnableEventHandlers()
        {
            //this.departmentsDropDownList.SelectedValueChanged += new System.EventHandler(this.departmentsDropDownList_SelectedValueChanged);
            //this.termsDropDownList.SelectedValueChanged += new System.EventHandler(this.termsDropDownList_SelectedValueChanged);
            //this.coursesDropDownList.SelectedValueChanged += new System.EventHandler(this.coursesDropDownList_SelectedValueChanged);
            //this.sectionsDropDownList.SelectedValueChanged += new System.EventHandler(this.sectionsDropDownList_SelectedValueChanged);
            //this.enrollmentsListBox.SelectedValueChanged += new System.EventHandler(this.enrollmentsListBox_SelectedValueChanged);
            //this.assignmentsListBox.SelectedValueChanged += new System.EventHandler(this.assignmentsListBox_SelectedValueChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new StudentInfoModelContainer();
            //this.school = this.dbContext.Schools.First();

            //this.school.Departments = this.dbContext.Departments.ToList();
            //this.departmentsDropDownList.DisplayMember = "DeptName";
            //this.departmentsDropDownList.DataSource = this.school.Departments;
            //Department comc = this.school.FindDepartment("COMC");
            //this.departmentsDropDownList.SelectedItem = comc;

            //comc.Courses = this.dbContext.Courses.Where(c =>
            //    c.Department.Id == comc.Id).ToList();
            //this.coursesDropDownList.DisplayMember = "CourseTitle";
            //this.coursesDropDownList.DataSource = comc.Courses;
            //Course comc2750 = comc.FindCourse("2750");
            //this.coursesDropDownList.SelectedItem = comc2750;
        }

        //private void departmentsDropDownList_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.assignmentsListBox.DataSource = null;
        //    this.enrollmentsListBox.DataSource = null;
        //    this.sectionsDropDownList.DataSource = null;
        //    this.coursesDropDownList.DataSource = null;
        //    Department selectedDept = 
        //    selectedDept.Courses = 
        //    this.coursesDropDownList.DisplayMember = "CourseTitle";
        //    this.coursesDropDownList.DataSource = selectedDept.Courses;
        //}

        //private void coursesDropDownList_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.assignmentsListBox.DataSource = null;
        //    this.enrollmentsListBox.DataSource = null;
        //    this.sectionsDropDownList.DataSource = null;
        //    Course selectedCourse = 
        //    Term selectedTerm = 
        //    if (selectedCourse != null && selectedTerm != null)
        //    {
        //        selectedCourse.Sections = 
        //
        //        this.sectionsDropDownList.DisplayMember = "Id";
        //        this.sectionsDropDownList.DataSource = selectedCourse.Sections;
        //    }
        //}

        //private void termsDropDownList_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.assignmentsListBox.DataSource = null;
        //    this.enrollmentsListBox.DataSource = null;
        //    this.sectionsDropDownList.DataSource = null;
        //    Course selectedCourse = 
        //    Term selectedTerm = 
        //    if (selectedCourse != null && selectedTerm != null)
        //    {
        //        selectedCourse.Sections = 
        //
        //
        //        this.sectionsDropDownList.DisplayMember = "Id";
        //        this.sectionsDropDownList.DataSource = selectedCourse.Sections;
        //    }
        //}

        //private void sectionsDropDownList_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.enrollmentsListBox.DataSource = null;
        //    this.assignmentsListBox.DataSource = null;
        //    Section selectedSection = 
        //    if (selectedSection != null)
        //    {
        //        selectedSection.Enrollments =
        //            
        //        selectedSection.Assignments = 
        //
        //        enrollmentsListBox.DisplayMember = "DisplayString";
        //        this.enrollmentsListBox.DataSource = selectedSection.Enrollments;
        //        assignmentsListBox.DisplayMember = "DisplayString";
        //        this.assignmentsListBox.DataSource = selectedSection.Assignments;
        //    }
        //}

        //private void enrollmentsListBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.pointsTextBox.Text = "";
        //    this.dateTextBox.Text = "";
        //    Enrollment selectedEnrollment = 
        //    Assignment selectedAssignment = 
        //    if (selectedEnrollment != null && selectedAssignment != null)
        //    {
        //        AssignmentGrade grade = 
        //
        //        if (grade != null)
        //        {
        //            this.pointsTextBox.Text = grade.Points.ToString();
        //            this.dateTextBox.Text = grade.DateCompleted.ToShortDateString();
        //        }
        //    }
        //}

        //private void assignmentsListBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.pointsTextBox.Text = "";
        //    this.dateTextBox.Text = "";
        //    Enrollment selectedEnrollment = 
        //    Assignment selectedAssignment = 
        //    if (selectedEnrollment != null && selectedAssignment != null)
        //    {
        //        AssignmentGrade grade = 
        //
        //        if (grade != null)
        //        {
        //            this.pointsTextBox.Text = grade.Points.ToString();
        //            this.dateTextBox.Text = grade.DateCompleted.ToShortDateString();
        //        }
        //    }
        //}

        //private void saveGradeButton_Click(object sender, EventArgs e)
        //{
        //    Enrollment selectedEnrollment = 
        //    Assignment selectedAssignment = 
        //    if (selectedEnrollment != null && selectedAssignment != null)
        //    {
        //        AssignmentGrade grade = selectedEnrollment.FindAssignmentGrade(selectedAssignment.Assign);
        //        if (grade == null)
        //        {
        //            short points = 0;
        //            Int16.TryParse(this.pointsTextBox.Text, out points);
        //            grade = new AssignmentGrade(points, DateTime.Now,
        //                selectedEnrollment, selectedAssignment);
        //        }
        //        else
        //        {
        //            short points = 0;
        //            Int16.TryParse(this.pointsTextBox.Text, out points);
        //            grade.Points = points;
        //            grade.DateCompleted = DateTime.Now;
        //        }
        //        this.dbContext.SaveChanges();
        //    }
        //}
    }
}
