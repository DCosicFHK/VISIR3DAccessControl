using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AccessControl_VISIR
{
    public partial class Main : Form
    {
        string sqlConParam;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sqlConParam = "server=localhost;database=visir_3d;uid=root;pwd=VISIR3D;";
            txtSqlConParameter.Text = sqlConParam;
        }

        private MySqlConnection GetCheckSQLCon(string conParam, bool supressMsg = false)
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(conParam);
            try
            {
                cnn.Open();
                if (!supressMsg)
                {
                    txtSqlResponse.AppendText(Environment.NewLine + "Connection successfull");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                if (!supressMsg)
                {
                    txtSqlResponse.AppendText(Environment.NewLine + "Connection not successfull" + Environment.NewLine + ex.Message);
                }
            }

            return cnn;
        }


        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            GetCheckSQLCon(txtSqlConParameter.Text);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtpValid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);
            List<string> existingAccessCodes = new List<string>();

            using (sqlCon)
            {
                using (MySqlCommand cmd = new MySqlCommand("Select Distinct AccessCode From user", sqlCon))
                {
                    sqlCon.Open();
                    using (MySqlDataReader objReader = cmd.ExecuteReader())
                    {
                        if (objReader.HasRows)
                        {
                            while (objReader.Read())
                            {
                                string value = objReader.GetString(0);
                                existingAccessCodes.Add(value);
                            }
                        }
                    }
                    sqlCon.Close();
                }
            }

            string newAccessCode = GetRandomNumber();

            while (existingAccessCodes.Contains(newAccessCode))
            {
                newAccessCode = GetRandomNumber();
            }

            txtAccessCode.Text = newAccessCode.ToString();
            dtpValid.Value = DateTime.Now.AddMonths(4);
        }

        private string GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1000000).ToString("D6");

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);

            if (ValidateUserAddFields())
            {

                try
                {
                    using (sqlCon)
                    {
                        using (MySqlCommand cmd =
                            new MySqlCommand("Insert into user(FirstName,LastName,FacultyID,Email,AccessCode, ValidUntil) " +
                            "values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtFacultyID.Text + "', '" + txtEmail.Text + "', '" + txtAccessCode.Text + "', '" + dtpValid.Value.Date.ToString("dd.MM.yyyy") + "')", sqlCon))
                        {
                            sqlCon.Open();
                            using (MySqlDataReader objReader = cmd.ExecuteReader())
                            {
                            }
                            sqlCon.Close();
                        }
                    }
                    MessageBox.Show("User Saved to Database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error trying to save User" + Environment.NewLine + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all Fields");
            }

        }

        private bool ValidateUserAddFields()
        {
            bool IsValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtFacultyID.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtAccessCode.Text))
            {
                IsValid = false;
            }

            return IsValid;
        }

        private bool ValidateUserEditFields()
        {
            bool IsValid = true;

            if (string.IsNullOrEmpty(txtFirstNameEdit.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtLastNameEdit.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtFacultyIDEdit.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtEmailEdit.Text))
            {
                IsValid = false;
            }
            else if (string.IsNullOrEmpty(txtAccessCodeEdit.Text))
            {
                IsValid = false;
            }

            return IsValid;
        }

        private void ClearInputFieldsUser()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFacultyID.Clear();
            txtEmail.Clear();
            txtAccessCode.Clear();
            dtpValid.Value = DateTime.Now;
        }

        private void ClearEditFieldsUser()
        {
            txtFirstNameEdit.Clear();
            txtLastNameEdit.Clear();
            txtFacultyIDEdit.Clear();
            txtEmailEdit.Clear();
            txtAccessCodeEdit.Clear();
            dtpValidEdit.Value = DateTime.Now;
            txtID.Clear();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearInputFieldsUser();
        }

        private BindingSource getDataGridView()
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);
            DataSet dataset = new DataSet();
            BindingSource bs = new BindingSource();

            datagrid.AutoGenerateColumns = true;
            using (sqlCon)
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * From user", sqlCon))
                {
                    sqlCon.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataset);
                        datagrid.DataSource = dataset;
                        bs.DataSource = dataset.Tables[0];
                    }
                    sqlCon.Close();
                }
            }
            return bs;
        }


        private void btnRefreshGrid_Click_1(object sender, EventArgs e)
        {
            datagrid.DataSource = getDataGridView();
        }

        private void datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0 && datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                datagrid.CurrentRow.Selected = true;
                txtID.Text = datagrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtFirstNameEdit.Text = datagrid.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastNameEdit.Text = datagrid.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtFacultyIDEdit.Text = datagrid.Rows[e.RowIndex].Cells["FacultyID"].Value.ToString();
                txtEmailEdit.Text = datagrid.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtAccessCodeEdit.Text = datagrid.Rows[e.RowIndex].Cells["AccessCode"].Value.ToString();
                dtpValidEdit.Value = DateTime.Parse(datagrid.Rows[e.RowIndex].Cells["ValidUntil"].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);

            if (ValidateUserEditFields())
            {
                try
                {
                    using (sqlCon)
                    {
                        using (MySqlCommand cmd =
                            new MySqlCommand("UPDATE user set FirstName = '" + txtFirstNameEdit.Text + "', LastName = '"
                            + txtLastNameEdit.Text + "', FacultyID = '" + txtFacultyIDEdit.Text + "', Email= '" + txtEmailEdit.Text + "', AccessCode = '" + txtAccessCodeEdit.Text + "', ValidUntil= '" +
                            dtpValidEdit.Value.Date.ToString("dd.MM.yyyy") + "' where ID = '" + txtID.Text + "';", sqlCon))
                        {
                            sqlCon.Open();
                            using (MySqlDataReader objReader = cmd.ExecuteReader())
                            {
                            }
                            sqlCon.Close();
                        }
                    }
                    MessageBox.Show("User Updated to Database");
                    datagrid.DataSource = getDataGridView();
                    ClearEditFieldsUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error trying to update User" + Environment.NewLine + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all Fields");
            }
        }

        private void btnUpdateAccessCode_Click(object sender, EventArgs e)
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);
            List<string> existingAccessCodes = new List<string>();

            using (sqlCon)
            {
                using (MySqlCommand cmd = new MySqlCommand("Select Distinct AccessCode From user", sqlCon))
                {
                    sqlCon.Open();
                    using (MySqlDataReader objReader = cmd.ExecuteReader())
                    {
                        if (objReader.HasRows)
                        {
                            while (objReader.Read())
                            {
                                string value = objReader.GetString(0);
                                existingAccessCodes.Add(value);
                            }
                        }
                    }
                    sqlCon.Close();
                }
            }

            string newAccessCode = GetRandomNumber();

            while (existingAccessCodes.Contains(newAccessCode))
            {
                newAccessCode = GetRandomNumber();
            }

            txtAccessCodeEdit.Text = newAccessCode.ToString();
            dtpValidEdit.Value = DateTime.Now.AddMonths(4);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sqlCon = GetCheckSQLCon(txtSqlConParameter.Text, true);           
                try
                {
                    using (sqlCon)
                    {
                        using (MySqlCommand cmd =
                            new MySqlCommand("Delete from User where ID ='" +txtID.Text+ "';" , sqlCon))
                        {
                            sqlCon.Open();
                            using (MySqlDataReader objReader = cmd.ExecuteReader())
                            {
                            }
                            sqlCon.Close();
                        }
                    }
                    MessageBox.Show("User deleted from Database");
                    datagrid.DataSource = getDataGridView();
                ClearEditFieldsUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error trying to update User" + Environment.NewLine + ex.Message);
                }            
        }
    }
}
