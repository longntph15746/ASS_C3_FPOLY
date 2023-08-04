using ASS_NAM_FPOLY.BUS;
using ASS_NAM_FPOLY.DTO;
using ASS_NAM_FPOLY.frmQLĐSV;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_NAM_FPOLY.frmQLSV
{

    public partial class Frm_QLSV : Form
    {
        public List<STUDENTS> lstSt = new List<STUDENTS>();
        private Image loadedImage;
        private string imagePath;   
        public Frm_QLSV()
        {
            InitializeComponent();
        }

        private void Frm_QLSV_Load(object sender, EventArgs e)
        {
            try
            {
                IServices services = new Services();

                List<STUDENTS> allStudents = services.GetAllSTUDENTS();
                dtg_QLSV.DataSource = allStudents;
                MeShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MeShow()
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_QLĐSV frmQLĐSV = new Frm_QLĐSV();
                frmQLĐSV.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateStudent()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999); 
            string studentID = "PH" + randomNumber.ToString();
            return studentID;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENTS st = new STUDENTS();

                st.MASV = txtStudentCode.Text;
                st.Hoten = txtStudentName.Text;
                st.Email = txtEmail.Text;
                st.Sdt = txtPhoneNumber.Text;
                st.Gioitinh = rdbMale.Checked ? "Nam" : "Nữ";
                st.Diachi = txtAdress.Text;
                st.Hinh = imagePath;
                lstSt.Add(st);
                dtg_QLSV.DataSource = null;
                dtg_QLSV.DataSource = lstSt;
                dtg_QLSV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã có l: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ptbImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imagePath = openFileDialog.FileName;
                        ptbImages.Image = Image.FromFile(imagePath);
                        ptbImages.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string studentCodeToDelete = txtStudentCode.Text; 

                var studentToDelete = lstSt.FirstOrDefault(st => st.MASV == studentCodeToDelete);
                if (studentToDelete != null)
                {
                    lstSt.Remove(studentToDelete);
                    dtg_QLSV.DataSource = null;
                    dtg_QLSV.DataSource = lstSt;

                    dtg_QLSV.Refresh();

                    MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dtg_QLSV.SelectedCells[0].RowIndex;

                if (selectedIndex >= 0 && selectedIndex < dtg_QLSV.Rows.Count)
                {
                    
                    DataGridViewRow selectedRow = dtg_QLSV.Rows[selectedIndex];
                    string studentCodeToUpdate = selectedRow.Cells["MASV"].Value.ToString(); 
                    string studentName = selectedRow.Cells["Hoten"].Value.ToString();
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    string sdt = selectedRow.Cells["Sdt"].Value.ToString();


                    var studentToUpdate = lstSt.FirstOrDefault(st => st.MASV == studentCodeToUpdate);
                    if (studentToUpdate != null)
                    {
                        studentToUpdate.Hoten = studentName;
                        studentToUpdate.Email = email;

                        dtg_QLSV.DataSource = null; 
                        dtg_QLSV.DataSource = lstSt;
                        dtg_QLSV.Refresh();

                        MessageBox.Show("Thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtg_QLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtg_QLSV.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtg_QLSV.Rows[e.RowIndex];
                    string studentCode = selectedRow.Cells["MASV"].Value.ToString(); 
                    string studentName = selectedRow.Cells["Hoten"].Value.ToString(); 
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    string hinh = selectedRow.Cells["Hinh"].Value.ToString();

                    txtStudentCode.Text = studentCode;
                    txtStudentName.Text = studentName;
                    txtEmail.Text = email;
                    ptbImages.ImageLocation = hinh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

                
        }
    }
}
