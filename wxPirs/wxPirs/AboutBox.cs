﻿// Type: wxPirs.AboutBox
// Assembly: wxPirs, Version=1.1.0.42, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\jamesc\Downloads\wxPirs-1.1\wxPirs.exe

using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace wxPirs
{
    internal class AboutBox : Form
    {
        private IContainer components;
        private TableLayoutPanel tableLayoutPanel;
        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button okButton;

        public string AssemblyTitle
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (customAttributes.Length > 0)
                {
                    AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
                    if (assemblyTitleAttribute.Title != "")
                        return assemblyTitleAttribute.Title;
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return ((object)Assembly.GetExecutingAssembly().GetName().Version).ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (customAttributes.Length == 0)
                    return "";
                else
                    return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (customAttributes.Length == 0)
                    return "";
                else
                    return ((AssemblyProductAttribute)customAttributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (customAttributes.Length == 0)
                    return "";
                else
                    return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (customAttributes.Length == 0)
                    return "";
                else
                    return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
            }
        }

        public AboutBox()
        {
            this.InitializeComponent();
            this.Text = string.Format("About {0}", (object)this.AssemblyTitle);
            this.labelProductName.Text = this.AssemblyProduct;
            this.labelVersion.Text = string.Format("Version {0}", (object)this.AssemblyVersion);
            this.labelCopyright.Text = this.AssemblyCopyright;
            this.labelCompanyName.Text = this.AssemblyCompany;
            this.textBoxDescription.Text = this.AssemblyDescription;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox));
            this.tableLayoutPanel = new TableLayoutPanel();
            this.logoPictureBox = new PictureBox();
            this.labelProductName = new Label();
            this.labelVersion = new Label();
            this.labelCopyright = new Label();
            this.labelCompanyName = new Label();
            this.textBoxDescription = new TextBox();
            this.okButton = new Button();
            this.tableLayoutPanel.SuspendLayout();
            //this.logoPictureBox.BeginInit();
            this.SuspendLayout();
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200f));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel.Controls.Add((Control)this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add((Control)this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add((Control)this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add((Control)this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add((Control)this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add((Control)this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add((Control)this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.Location = new Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tableLayoutPanel.Size = new Size(487, 265);
            this.tableLayoutPanel.TabIndex = 0;
            this.logoPictureBox.BackColor = SystemColors.Control;
            this.logoPictureBox.BorderStyle = BorderStyle.Fixed3D;
            this.logoPictureBox.Dock = DockStyle.Fill;
            //this.logoPictureBox.Image = (Image)componentResourceManager.GetObject("logoPictureBox.Image");
            this.logoPictureBox.Location = new Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan((Control)this.logoPictureBox, 6);
            this.logoPictureBox.Size = new Size(194, 259);
            this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.labelProductName.Dock = DockStyle.Fill;
            this.labelProductName.Location = new Point(206, 0);
            this.labelProductName.Margin = new Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new Size(278, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            this.labelVersion.Dock = DockStyle.Fill;
            this.labelVersion.Location = new Point(206, 26);
            this.labelVersion.Margin = new Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new Size(278, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            this.labelCopyright.Dock = DockStyle.Fill;
            this.labelCopyright.Location = new Point(206, 52);
            this.labelCopyright.Margin = new Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new Size(278, 17);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            this.labelCompanyName.Dock = DockStyle.Fill;
            this.labelCompanyName.Location = new Point(206, 78);
            this.labelCompanyName.Margin = new Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(278, 17);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            this.textBoxDescription.Dock = DockStyle.Fill;
            this.textBoxDescription.Location = new Point(206, 107);
            this.textBoxDescription.Margin = new Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = ScrollBars.Both;
            this.textBoxDescription.Size = new Size(278, 126);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.okButton.DialogResult = DialogResult.Cancel;
            this.okButton.Location = new Point(409, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.AcceptButton = (IButtonControl)this.okButton;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(505, 283);
            this.Controls.Add((Control)this.tableLayoutPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            //this.logoPictureBox.EndInit();
            this.ResumeLayout(false);
        }
    }
}
