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

namespace schoolmenagment.View
{
    public partial class Roomform : Form
    {
        private Roomcontroller controller = new Roomcontroller();
        private int selectedRoomId = -1;
        public Roomform()
        {
            InitializeComponent();
            if (finder.usertype != "Admin")
            {
                btnadd.Visible = false;
                btndelete.Visible = false;
                btnedit.Visible = false;

                lblroom.Visible = false;
                lblroomtype.Visible = false;

                txtroomname.Visible = false;
                txtroomtype.Visible = false;

            }
            LoadRooms();
        }
        private void LoadRooms()
        {
            dgvroom.DataSource = controller.GetAllRooms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvroom.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                txtroomname.Text = row.Cells["RoomName"].Value.ToString();
                txtroomtype.Text = row.Cells["RoomType"].Value.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Room room = new Room
            {
                Roomname = txtroomname.Text,
                Roomtype = txtroomtype.Text
            };

            controller.AddRoom(room);
            MessageBox.Show("Room added successfully!");
            ClearForm();
            LoadRooms();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            Room room = new Room
            {
                Roomid = selectedRoomId,
                Roomname = txtroomname.Text,
                Roomtype = txtroomtype.Text
            };

            controller.UpdateRoom(room);
            MessageBox.Show("Room updated successfully!");
            ClearForm();
            LoadRooms();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            controller.DeleteRoom(selectedRoomId);
            MessageBox.Show("Room deleted successfully!");
            ClearForm();
            LoadRooms();
        }
        private void ClearForm()
        {
            txtroomname.Clear();
            txtroomtype.Clear();
            selectedRoomId = -1;
        }
    }
}
