using schoolmenagment.controller;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace schoolmenagment.View
{
    public partial class Timetableform : Form
    {
        private Timtablecontroller timtablecontroller = new Timtablecontroller();
        private int selectedTimetableId = -1;
        public Timetableform()
        {
            InitializeComponent();
        }

        private void Timetableform_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadRooms();
            if (finder.usertype != "Admin")
            {
                btnadd.Visible = false;
                btndelete.Visible = false;
                btnedit.Visible = false;

                lblcourse.Visible = false;
                lblroom.Visible = false;
                lbltimeslot.Visible = false;

                txttimeslot.Visible = false;
                cmbcourse.Visible = false;
                cmbroom.Visible = false;
                

            }
            LoadTimetables();
        }
        private void LoadCourses()
        {
            var courses = Coursecontroller.GetAll();
            cmbcourse.DataSource = courses;
            cmbcourse.DisplayMember = "CourseName";
            cmbcourse.ValueMember = "CourseId";
        }
        private void LoadRooms()
        {
            var rooms = new Roomcontroller().GetAllRooms();
            cmbroom.DataSource = rooms;
            cmbroom.DisplayMember = "RoomName";
            cmbroom.ValueMember = "RoomID";
        }
        private void LoadTimetables()
        {
            dgvtimetable.DataSource = null;
            dgvtimetable.DataSource = Timtablecontroller.GetAllTimetables();
        }
        private void ClearForm()
        {
            txttimeslot.Text = "";
            cmbcourse.SelectedIndex = -1;
            cmbroom.SelectedIndex = -1;
            selectedTimetableId = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var timetable = new Timtable
            {
                Timeslot = txttimeslot.Text,
                CourseId = Convert.ToInt32(cmbcourse.SelectedValue),
                Roomid = Convert.ToInt32(cmbroom.SelectedValue)
            };

            Timtablecontroller.AddTimetable(timetable);
            LoadTimetables();
            ClearForm();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId != -1)
            {
                var timetable = new Timtable
                {
                    TimtableId = selectedTimetableId,
                    Timeslot = txttimeslot.Text,
                    CourseId = Convert.ToInt32(cmbcourse.SelectedValue),
                    Roomid = Convert.ToInt32(cmbroom.SelectedValue)
                };

                Timtablecontroller.UpdateTimetable(timetable);
                LoadTimetables();
                ClearForm();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId != -1)
            {
                Timtablecontroller.DeleteTimetable(selectedTimetableId);
                LoadTimetables();
                ClearForm();
            }
        }

        private void dgvtimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvtimetable.Rows[e.RowIndex];
                selectedTimetableId = Convert.ToInt32(row.Cells["TimetableId"].Value);
                txttimeslot.Text = row.Cells["TimeSlot"].Value.ToString();
                cmbcourse.SelectedValue = Convert.ToInt32(row.Cells["CourseId"].Value);
                cmbroom.SelectedValue = Convert.ToInt32(row.Cells["RoomId"].Value);
            }
        }
    }

}
