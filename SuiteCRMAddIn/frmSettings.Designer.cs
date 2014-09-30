﻿/**
 * Outlook integration for SuiteCRM.
 * @package Outlook integration for SuiteCRM
 * @copyright SalesAgility Ltd http://www.salesagility.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with this program; if not, see http://www.gnu.org/licenses
 * or write to the Free Software Foundation,Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA 02110-1301  USA
 *
 * @author SalesAgility <info@salesagility.com>
 */
namespace SuiteCRMAddIn
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutoSync = new System.Windows.Forms.TextBox();
            this.tsResults = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAutoArchive = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowConfirmationMessageArchive = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSyncMaxRecords = new System.Windows.Forms.TextBox();
            this.cbShowCustomModules = new System.Windows.Forms.CheckBox();
            this.checkBoxShowRightClick = new System.Windows.Forms.CheckBox();
            this.checkBoxAutomaticSearch = new System.Windows.Forms.CheckBox();
            this.cbEmailAttachments = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbLDAPAuthentication = new System.Windows.Forms.GroupBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.txtLDAPAuthenticationKey = new System.Windows.Forms.TextBox();
            this.chkEnableLDAPAuthentication = new System.Windows.Forms.CheckBox();
            this.gbFirstTime = new System.Windows.Forms.GroupBox();
            this.dtpAutoArchiveFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbLDAPAuthentication.SuspendLayout();
            this.gbFirstTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtAutoSync);
            this.tabPage3.Controls.Add(this.tsResults);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.chkAutoArchive);
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(360, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Auto Archive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Exclude emails From/To the following emails ";
            // 
            // txtAutoSync
            // 
            this.txtAutoSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSync.Location = new System.Drawing.Point(18, 248);
            this.txtAutoSync.Multiline = true;
            this.txtAutoSync.Name = "txtAutoSync";
            this.txtAutoSync.Size = new System.Drawing.Size(311, 44);
            this.txtAutoSync.TabIndex = 13;
            // 
            // tsResults
            // 
            this.tsResults.AccessibleName = "";
            this.tsResults.CheckBoxes = true;
            this.tsResults.Location = new System.Drawing.Point(18, 64);
            this.tsResults.Name = "tsResults";
            this.tsResults.Size = new System.Drawing.Size(311, 148);
            this.tsResults.TabIndex = 12;
            this.tsResults.Tag = "tree_search_results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Automatically Archive the following folders only";
            // 
            // chkAutoArchive
            // 
            this.chkAutoArchive.AutoSize = true;
            this.chkAutoArchive.Location = new System.Drawing.Point(15, 20);
            this.chkAutoArchive.Name = "chkAutoArchive";
            this.chkAutoArchive.Size = new System.Drawing.Size(276, 17);
            this.chkAutoArchive.TabIndex = 9;
            this.chkAutoArchive.Text = "Automatically Archive all Inbound and Outbount mails";
            this.chkAutoArchive.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShowConfirmationMessageArchive);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.checkBoxShowRightClick);
            this.groupBox2.Controls.Add(this.checkBoxAutomaticSearch);
            this.groupBox2.Controls.Add(this.cbEmailAttachments);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 282);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chkShowConfirmationMessageArchive
            // 
            this.chkShowConfirmationMessageArchive.AutoSize = true;
            this.chkShowConfirmationMessageArchive.Checked = true;
            this.chkShowConfirmationMessageArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowConfirmationMessageArchive.Location = new System.Drawing.Point(26, 159);
            this.chkShowConfirmationMessageArchive.Name = "chkShowConfirmationMessageArchive";
            this.chkShowConfirmationMessageArchive.Size = new System.Drawing.Size(267, 17);
            this.chkShowConfirmationMessageArchive.TabIndex = 11;
            this.chkShowConfirmationMessageArchive.Text = "Show confirmation message on Successful Archive";
            this.chkShowConfirmationMessageArchive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSyncMaxRecords);
            this.groupBox3.Controls.Add(this.cbShowCustomModules);
            this.groupBox3.Location = new System.Drawing.Point(18, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(258, 43);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(57, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum number of search results per modules:";
            // 
            // txtSyncMaxRecords
            // 
            this.txtSyncMaxRecords.Location = new System.Drawing.Point(258, 18);
            this.txtSyncMaxRecords.Name = "txtSyncMaxRecords";
            this.txtSyncMaxRecords.Size = new System.Drawing.Size(57, 20);
            this.txtSyncMaxRecords.TabIndex = 4;
            // 
            // cbShowCustomModules
            // 
            this.cbShowCustomModules.AutoSize = true;
            this.cbShowCustomModules.Location = new System.Drawing.Point(8, 47);
            this.cbShowCustomModules.Name = "cbShowCustomModules";
            this.cbShowCustomModules.Size = new System.Drawing.Size(140, 17);
            this.cbShowCustomModules.TabIndex = 2;
            this.cbShowCustomModules.Text = "Include custom modules";
            this.cbShowCustomModules.UseVisualStyleBackColor = true;
            this.cbShowCustomModules.Click += new System.EventHandler(this.cbShowCustomModules_Click);
            // 
            // checkBoxShowRightClick
            // 
            this.checkBoxShowRightClick.AutoSize = true;
            this.checkBoxShowRightClick.Location = new System.Drawing.Point(21, 217);
            this.checkBoxShowRightClick.Name = "checkBoxShowRightClick";
            this.checkBoxShowRightClick.Size = new System.Drawing.Size(239, 17);
            this.checkBoxShowRightClick.TabIndex = 9;
            this.checkBoxShowRightClick.Text = "Show SugarCRM records in right click menus";
            this.checkBoxShowRightClick.UseVisualStyleBackColor = true;
            this.checkBoxShowRightClick.Visible = false;
            // 
            // checkBoxAutomaticSearch
            // 
            this.checkBoxAutomaticSearch.AutoSize = true;
            this.checkBoxAutomaticSearch.Location = new System.Drawing.Point(21, 253);
            this.checkBoxAutomaticSearch.Name = "checkBoxAutomaticSearch";
            this.checkBoxAutomaticSearch.Size = new System.Drawing.Size(299, 17);
            this.checkBoxAutomaticSearch.TabIndex = 1;
            this.checkBoxAutomaticSearch.Text = "Automatically Search when the Archive window is opened";
            this.checkBoxAutomaticSearch.UseVisualStyleBackColor = true;
            this.checkBoxAutomaticSearch.Visible = false;
            // 
            // cbEmailAttachments
            // 
            this.cbEmailAttachments.AutoSize = true;
            this.cbEmailAttachments.Location = new System.Drawing.Point(26, 30);
            this.cbEmailAttachments.Name = "cbEmailAttachments";
            this.cbEmailAttachments.Size = new System.Drawing.Size(145, 17);
            this.cbEmailAttachments.TabIndex = 0;
            this.cbEmailAttachments.Text = "Archive attachments also";
            this.cbEmailAttachments.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbLDAPAuthentication);
            this.tabPage1.Controls.Add(this.gbFirstTime);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(360, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Credentials";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbLDAPAuthentication
            // 
            this.gbLDAPAuthentication.Controls.Add(this.labelKey);
            this.gbLDAPAuthentication.Controls.Add(this.txtLDAPAuthenticationKey);
            this.gbLDAPAuthentication.Controls.Add(this.chkEnableLDAPAuthentication);
            this.gbLDAPAuthentication.Location = new System.Drawing.Point(7, 150);
            this.gbLDAPAuthentication.Name = "gbLDAPAuthentication";
            this.gbLDAPAuthentication.Size = new System.Drawing.Size(352, 69);
            this.gbLDAPAuthentication.TabIndex = 3;
            this.gbLDAPAuthentication.TabStop = false;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(6, 43);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(25, 13);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key";
            // 
            // txtLDAPAuthenticationKey
            // 
            this.txtLDAPAuthenticationKey.Location = new System.Drawing.Point(64, 40);
            this.txtLDAPAuthenticationKey.Name = "txtLDAPAuthenticationKey";
            this.txtLDAPAuthenticationKey.Size = new System.Drawing.Size(207, 20);
            this.txtLDAPAuthenticationKey.TabIndex = 1;
            // 
            // chkEnableLDAPAuthentication
            // 
            this.chkEnableLDAPAuthentication.AutoSize = true;
            this.chkEnableLDAPAuthentication.Location = new System.Drawing.Point(9, 16);
            this.chkEnableLDAPAuthentication.Name = "chkEnableLDAPAuthentication";
            this.chkEnableLDAPAuthentication.Size = new System.Drawing.Size(161, 17);
            this.chkEnableLDAPAuthentication.TabIndex = 0;
            this.chkEnableLDAPAuthentication.Text = "Enable LDAP Authentication";
            this.chkEnableLDAPAuthentication.UseVisualStyleBackColor = true;
            this.chkEnableLDAPAuthentication.CheckedChanged += new System.EventHandler(this.chkEnableLDAPAuthentication_CheckedChanged);
            // 
            // gbFirstTime
            // 
            this.gbFirstTime.Controls.Add(this.dtpAutoArchiveFrom);
            this.gbFirstTime.Controls.Add(this.label8);
            this.gbFirstTime.Location = new System.Drawing.Point(6, 225);
            this.gbFirstTime.Name = "gbFirstTime";
            this.gbFirstTime.Size = new System.Drawing.Size(353, 59);
            this.gbFirstTime.TabIndex = 2;
            this.gbFirstTime.TabStop = false;
            this.gbFirstTime.Text = "First Time Parameters";
            // 
            // dtpAutoArchiveFrom
            // 
            this.dtpAutoArchiveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAutoArchiveFrom.Location = new System.Drawing.Point(147, 21);
            this.dtpAutoArchiveFrom.Name = "dtpAutoArchiveFrom";
            this.dtpAutoArchiveFrom.Size = new System.Drawing.Size(94, 20);
            this.dtpAutoArchiveFrom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Automatically Archive from";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnTestLogin
            // 
            this.btnTestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestLogin.Location = new System.Drawing.Point(290, 103);
            this.btnTestLogin.Name = "btnTestLogin";
            this.btnTestLogin.Size = new System.Drawing.Size(42, 23);
            this.btnTestLogin.TabIndex = 7;
            this.btnTestLogin.Text = "&Test";
            this.btnTestLogin.UseVisualStyleBackColor = true;
            this.btnTestLogin.Click += new System.EventHandler(this.btnTestLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ex : http://www.testcrm/suitecrm/";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(65, 16);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(207, 20);
            this.txtURL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 382);
            this.tabControl1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(306, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(225, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(393, 419);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 458);
            this.Name = "frmSettings";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gbLDAPAuthentication.ResumeLayout(false);
            this.gbLDAPAuthentication.PerformLayout();
            this.gbFirstTime.ResumeLayout(false);
            this.gbFirstTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutoSync;
        private System.Windows.Forms.TreeView tsResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAutoArchive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxShowRightClick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSyncMaxRecords;
        private System.Windows.Forms.CheckBox cbShowCustomModules;
        private System.Windows.Forms.CheckBox checkBoxAutomaticSearch;
        private System.Windows.Forms.CheckBox cbEmailAttachments;
        private System.Windows.Forms.GroupBox gbFirstTime;
        private System.Windows.Forms.DateTimePicker dtpAutoArchiveFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbLDAPAuthentication;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox txtLDAPAuthenticationKey;
        private System.Windows.Forms.CheckBox chkEnableLDAPAuthentication;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkShowConfirmationMessageArchive;

    }
}