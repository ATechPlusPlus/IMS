using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreApp;

namespace IMS
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        bool IsLogOut = false;
        String DBName = String.Empty;
        public int Login_ID_History = 0;

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
    
        static UserManagement.frmUserManagement ObjUserManag = new UserManagement.frmUserManagement();
        
        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjUserManag.IsHandleCreated)
            {
                ObjUserManag = null;
                ObjUserManag = new UserManagement.frmUserManagement();
                ObjUserManag.LoginStatus(clsUtility.LoginID, clsUtility.IsAdmin);
                ObjUserManag.Show();
                ObjUserManag.BringToFront();
            }
            ObjUserManag.LoginStatus(clsUtility.LoginID, clsUtility.IsAdmin);
            ObjUserManag.Show();
            ObjUserManag.BringToFront();
        }

        private void otherArtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_backupRestore.cs.frmDatabaseMaintenance Obj = new DB_backupRestore.cs.frmDatabaseMaintenance();
            Obj.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                DBName = ObjDAL.GetCurrentDBName(true);
                if (clsUtility.LoginID > 0)
                {

                    object ob = ObjDAL.ExecuteScalar("Select UserName from " + DBName + ".[dbo].[UserManagement] where ID=" + clsUtility.LoginID);
                    lblLoginName.Text = "Login By : " + ob.ToString();
                }
                else
                {
                    lblLoginName.Text = "Login By : Test Admin";
                }
                lblVersion.Text = "Version : " + Application.ProductVersion;
            }
            catch { }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogOut)
            {
                bool b = clsUtility.ShowQuestionMessage("Are you sure, you want to Exit?", clsUtility.strProjectTitle);
                if (b)
                {
                    ObjDAL.UpdateColumnData("LogOutTime", SqlDbType.DateTime, DateTime.Now);
                    ObjDAL.UpdateData(DBName + ".dbo.Login_History", "Login_ID_History = " + Login_ID_History);
                    IsLogOut = true;
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clsUtility.ShowQuestionMessage("Are you sure to Logout?", clsUtility.strProjectTitle))
            {
                ObjDAL.UpdateColumnData("LogOutTime", SqlDbType.DateTime, DateTime.Now);
                ObjDAL.UpdateData(DBName + ".dbo.Login_History", "Login_ID_History = " + Login_ID_History);
                frmLogin Obj = new frmLogin();
                Obj.BringToFront();
                Obj.Show();
                IsLogOut = true;
                this.Close();
            }
        }
    }
}
