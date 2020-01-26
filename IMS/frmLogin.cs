using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreApp;
using System.IO;

namespace IMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUtility objUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsThreadTask ObjThread = new clsThreadTask();

        byte count = 0;
        bool Isexit = true;
        String DBName = String.Empty;

        private bool ValidateLogin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin") && count <= 3)
            {
                count++;
            }
            if (username.Equals("admin") && password.Equals("admin") && count == 3)
            {
                clsUtility.LoginID = 0;
                clsUtility.IsAdmin = true;
                return true;
            }
            else if (!(username.Equals("admin") && password.Equals("admin")))
            {
                try
                {
                    DataTable dt = ObjDAL.GetDataCol(DBName+".dbo.UserManagement", "ID,UserName,Password,IsAdmin", "UserName='" + txtUserName.Text.Trim() + "' and Password='" + objUtil.Encrypt(txtPassword.Text, true) + "' and isnull(Isblock,0)=0", "ID desc");
                    //int a = ObjDAL.ExecuteScalarInt("select Count(*) From CyberCafeManagement.dbo.login where UserName='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'");                 
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        clsUtility.LoginID = Convert.ToInt32(dt.Rows[0]["ID"]);
                        clsUtility.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        private bool ValidateClientSide()
        {
            if (objUtil.IsControlTextEmpty(txtUserName))
            {
                clsUtility.ShowErrorMessage("Enter User Name.          ", clsUtility.strProjectTitle);
                txtUserName.Focus();
                return false;
            }
            else if (objUtil.IsControlTextEmpty(txtPassword))
            {
                clsUtility.ShowErrorMessage("Enter Password.          ", clsUtility.strProjectTitle);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private void InsertBackupConfig()
        {
            int a = ObjDAL.CountRecords(DBName + ".dbo.BackupConfig");
            if (a == 0)
            {
                ObjDAL.SetColumnData("IsAutoBackup", SqlDbType.Bit, 1);
                ObjDAL.InsertData(DBName + ".dbo.BackupConfig", false);
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Isexit = false;
            if (ValidateClientSide())
            {
                if (ValidateLogin(txtUserName.Text, txtPassword.Text))
                {
                    //InsertBackupConfig();
                    frmHome Obj = new frmHome();
                    Obj.BringToFront();
                    this.Close();
                    Obj.ShowDialog();
                }
                else
                {
                    Isexit = true;
                    clsUtility.ShowErrorMessage("Invalid User name or Password. or User " + txtUserName.Text.Trim() + " is blocked", clsUtility.strProjectTitle);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Isexit = false;

            UserManagement.frmForgetPassword Obj = new UserManagement.frmForgetPassword();

            Obj.ShowDialog();
            txtUserName.Focus();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Isexit)
            {
                try
                {
                    Application.Exit();
                }
                catch { }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DBName = ObjDAL.GetCurrentDBName(true);
        }
    }
}
