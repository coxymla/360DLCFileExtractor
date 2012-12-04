// Type: wxPirs.MainForm
// Assembly: wxPirs, Version=1.1.0.42, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\jamesc\Downloads\wxPirs-1.1\wxPirs.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using wxPirs.Properties;
using WxTools;

namespace wxPirs
{
  public partial class MainForm : Form
  {
    private IContainer components;
    private MenuStrip menuStrip;
    private StatusStrip statusStrip;
    private ToolStripContainer toolStripContainer1;
    private SplitContainer splitContainerH;
    private SplitContainer splitContainerV;
    private TreeView treeView;
    private ListView listView;
    private ColumnHeader columnHeaderName;
    private TextBox textBoxLog;
    private ImageList imageListTreeView;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStrip fileToolStrip;
    private ToolStripButton openFileToolStripButton;
    private OpenFileDialog openFileDialog;
    private ColumnHeader columnHeaderSize;
    private ColumnHeader columnHeaderDateModified;
    private ImageList imageList;
    private ColumnHeader columnHeaderCluster;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem extractFileToolStripMenuItem;
    private ContextMenuStrip contextMenuStripMulti;
    private ToolStripMenuItem extractFilesToolStripMenuItem;
    private SaveFileDialog saveFileDialog;
    private ColumnHeader columnHeaderStatus;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem aboutPirsToolStripMenuItem;
    private ToolStripStatusLabel toolStripStatusLabelVersion;
    private ToolStripMenuItem openFileToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripStatusLabel toolStripStatusLabelSeparator;
    private ToolStripStatusLabel toolStripStatusLabelGael360;
    private FolderBrowserDialog folderBrowserDialog;
    private ContextMenuStrip contextMenuStripFolder;
    private ToolStripMenuItem extractFolderToolStripMenuItem;
    private ToolStripButton extractAllToolStripButton;
    private ToolStripMenuItem extractAllToolStripMenuItem;
    public static int MAGIC_PIRS;
    public static int MAGIC_LIVE;
    public static int MAGIC_CON_;
    public static long PIRS_TYPE1;
    public static long PIRS_TYPE2;
    public static long PIRS_BASE;
    private string[] args;
    private WxReader wr;
    private FileStream fs;
    private BinaryReader br;
    private long pirs_offset;
    private long pirs_start;

    static MainForm()
    {
      MainForm.MAGIC_PIRS = 1346982483;
      MainForm.MAGIC_LIVE = 1279874629;
      MainForm.MAGIC_CON_ = 1129270816;
      MainForm.PIRS_TYPE1 = 4096L;
      MainForm.PIRS_TYPE2 = 8192L;
      MainForm.PIRS_BASE = 45056L;
    }

    public MainForm(string[] args)
    {
      this.wr = new WxReader();
      this.args = args;
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.menuStrip = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.openFileToolStripMenuItem = new ToolStripMenuItem();
      this.extractAllToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.aboutPirsToolStripMenuItem = new ToolStripMenuItem();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabelVersion = new ToolStripStatusLabel();
      this.toolStripStatusLabelSeparator = new ToolStripStatusLabel();
      this.toolStripStatusLabelGael360 = new ToolStripStatusLabel();
      this.toolStripContainer1 = new ToolStripContainer();
      this.splitContainerH = new SplitContainer();
      this.splitContainerV = new SplitContainer();
      this.treeView = new TreeView();
      this.imageListTreeView = new ImageList(this.components);
      this.listView = new ListView();
      this.columnHeaderName = new ColumnHeader();
      this.columnHeaderSize = new ColumnHeader();
      this.columnHeaderCluster = new ColumnHeader();
      this.columnHeaderDateModified = new ColumnHeader();
      this.columnHeaderStatus = new ColumnHeader();
      this.imageList = new ImageList(this.components);
      this.textBoxLog = new TextBox();
      this.fileToolStrip = new ToolStrip();
      this.openFileToolStripButton = new ToolStripButton();
      this.extractAllToolStripButton = new ToolStripButton();
      this.contextMenuStripFolder = new ContextMenuStrip(this.components);
      this.extractFolderToolStripMenuItem = new ToolStripMenuItem();
      this.openFileDialog = new OpenFileDialog();
      this.contextMenuStrip = new ContextMenuStrip(this.components);
      this.extractFileToolStripMenuItem = new ToolStripMenuItem();
      this.contextMenuStripMulti = new ContextMenuStrip(this.components);
      this.extractFilesToolStripMenuItem = new ToolStripMenuItem();
      this.saveFileDialog = new SaveFileDialog();
      this.folderBrowserDialog = new FolderBrowserDialog();
      this.menuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.splitContainerH.Panel1.SuspendLayout();
      this.splitContainerH.Panel2.SuspendLayout();
      this.splitContainerH.SuspendLayout();
      this.splitContainerV.Panel1.SuspendLayout();
      this.splitContainerV.Panel2.SuspendLayout();
      this.splitContainerV.SuspendLayout();
      this.fileToolStrip.SuspendLayout();
      this.contextMenuStripFolder.SuspendLayout();
      this.contextMenuStrip.SuspendLayout();
      this.contextMenuStripMulti.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem1
      });
      this.menuStrip.Location = new Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new Size(729, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.openFileToolStripMenuItem,
        (ToolStripItem) this.extractAllToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(35, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.openFileToolStripMenuItem.Image = (Image) Resources.openHS;
      this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
      this.openFileToolStripMenuItem.Size = new Size(134, 22);
      this.openFileToolStripMenuItem.Text = "Open...";
      // ISSUE: method pointer
        this.openFileToolStripMenuItem.Click += openFile;
      this.extractAllToolStripMenuItem.Image = (Image) Resources.SaveAllHS;
      this.extractAllToolStripMenuItem.Name = "extractAllToolStripMenuItem";
      this.extractAllToolStripMenuItem.Size = new Size(134, 22);
      this.extractAllToolStripMenuItem.Text = "Extract all...";
      // ISSUE: method pointer
        this.extractAllToolStripMenuItem.Click += extractAll;
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(131, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(134, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // ISSUE: method pointer
        this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
      this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.aboutPirsToolStripMenuItem
      });
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(24, 20);
      this.toolStripMenuItem1.Text = "?";
      this.aboutPirsToolStripMenuItem.Name = "aboutPirsToolStripMenuItem";
      this.aboutPirsToolStripMenuItem.Size = new Size(123, 22);
      this.aboutPirsToolStripMenuItem.Text = "About Pirs";
      // ISSUE: method pointer
        this.aboutPirsToolStripMenuItem.Click += aboutPirsToolStripMenuItem_Click;
      this.statusStrip.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.toolStripStatusLabelVersion,
        (ToolStripItem) this.toolStripStatusLabelSeparator,
        (ToolStripItem) this.toolStripStatusLabelGael360
      });
      this.statusStrip.Location = new Point(0, 373);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(729, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip1";
      this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
      this.toolStripStatusLabelVersion.Size = new Size(664, 17);
      this.toolStripStatusLabelVersion.Spring = true;
      this.toolStripStatusLabelVersion.Text = "wxPirs";
      this.toolStripStatusLabelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.toolStripStatusLabelSeparator.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.toolStripStatusLabelSeparator.BorderStyle = Border3DStyle.Sunken;
      this.toolStripStatusLabelSeparator.Name = "toolStripStatusLabelSeparator";
      this.toolStripStatusLabelSeparator.Size = new Size(4, 17);
      this.toolStripStatusLabelGael360.Name = "toolStripStatusLabelGael360";
      this.toolStripStatusLabelGael360.Size = new Size(46, 17);
      this.toolStripStatusLabelGael360.Text = "Gael360";
      this.toolStripContainer1.ContentPanel.Controls.Add((Control) this.splitContainerH);
      this.toolStripContainer1.ContentPanel.Size = new Size(729, 324);
      this.toolStripContainer1.Dock = DockStyle.Fill;
      this.toolStripContainer1.Location = new Point(0, 24);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new Size(729, 349);
      this.toolStripContainer1.TabIndex = 2;
      this.toolStripContainer1.Text = "toolStripContainer1";
      this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control) this.fileToolStrip);
      this.splitContainerH.Dock = DockStyle.Fill;
      this.splitContainerH.FixedPanel = FixedPanel.Panel2;
      this.splitContainerH.Location = new Point(0, 0);
      this.splitContainerH.Name = "splitContainerH";
      this.splitContainerH.Orientation = Orientation.Horizontal;
      this.splitContainerH.Panel1.Controls.Add((Control) this.splitContainerV);
      this.splitContainerH.Panel2.Controls.Add((Control) this.textBoxLog);
      this.splitContainerH.Size = new Size(729, 324);
      this.splitContainerH.SplitterDistance = 243;
      this.splitContainerH.TabIndex = 0;
      this.splitContainerV.Dock = DockStyle.Fill;
      this.splitContainerV.FixedPanel = FixedPanel.Panel1;
      this.splitContainerV.Location = new Point(0, 0);
      this.splitContainerV.Name = "splitContainerV";
      this.splitContainerV.Panel1.Controls.Add((Control) this.treeView);
      this.splitContainerV.Panel2.Controls.Add((Control) this.listView);
      this.splitContainerV.Size = new Size(729, 243);
      this.splitContainerV.SplitterDistance = 180;
      this.splitContainerV.TabIndex = 0;
      this.treeView.Dock = DockStyle.Fill;
      this.treeView.ImageIndex = 1;
      this.treeView.ImageList = this.imageListTreeView;
      this.treeView.Location = new Point(0, 0);
      this.treeView.Name = "treeView";
      this.treeView.SelectedImageIndex = 2;
      this.treeView.ShowRootLines = false;
      this.treeView.Size = new Size(180, 243);
      this.treeView.TabIndex = 0;
      // ISSUE: method pointer
        this.treeView.AfterSelect += treeView_AfterSelect;
      // ISSUE: method pointer
        this.treeView.NodeMouseClick += treeView_NodeMouseClick;
      //this.imageListTreeView.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageListTreeView.ImageStream");
      this.imageListTreeView.TransparentColor = Color.Fuchsia;
      //this.imageListTreeView.Images.SetKeyName(0, "Control_FolderBrowserDialog.bmp");
      //this.imageListTreeView.Images.SetKeyName(1, "VSFolder_closed.bmp");
      //this.imageListTreeView.Images.SetKeyName(2, "VSFolder_open.bmp");
      this.listView.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeaderName,
        this.columnHeaderSize,
        this.columnHeaderCluster,
        this.columnHeaderDateModified,
        this.columnHeaderStatus
      });
      this.listView.Dock = DockStyle.Fill;
      this.listView.FullRowSelect = true;
      this.listView.Location = new Point(0, 0);
      this.listView.Name = "listView";
      this.listView.ShowItemToolTips = true;
      this.listView.Size = new Size(545, 243);
      this.listView.SmallImageList = this.imageList;
      this.listView.TabIndex = 0;
      this.listView.UseCompatibleStateImageBehavior = false;
      this.listView.View = View.Details;
      // ISSUE: method pointer
        this.listView.MouseClick += listView_MouseClick;
      this.columnHeaderName.Text = "Name";
      this.columnHeaderName.Width = 200;
      this.columnHeaderSize.Text = "Size";
      this.columnHeaderSize.TextAlign = HorizontalAlignment.Right;
      this.columnHeaderCluster.Text = "Cluster";
      this.columnHeaderCluster.TextAlign = HorizontalAlignment.Right;
      this.columnHeaderDateModified.Text = "Date modified";
      this.columnHeaderDateModified.Width = 120;
      this.columnHeaderStatus.Text = "Status";
      this.columnHeaderStatus.Width = 80;
      //this.imageList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList.ImageStream");
      this.imageList.TransparentColor = Color.Fuchsia;
      //this.imageList.Images.SetKeyName(0, "VSFolder_closed.bmp");
      //this.imageList.Images.SetKeyName(1, "DocumentHS.png");
      this.textBoxLog.Dock = DockStyle.Fill;
      this.textBoxLog.Location = new Point(0, 0);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ScrollBars = ScrollBars.Both;
      this.textBoxLog.Size = new Size(729, 77);
      this.textBoxLog.TabIndex = 0;
      this.fileToolStrip.Dock = DockStyle.None;
      this.fileToolStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.openFileToolStripButton,
        (ToolStripItem) this.extractAllToolStripButton
      });
      this.fileToolStrip.Location = new Point(3, 0);
      this.fileToolStrip.Name = "fileToolStrip";
      this.fileToolStrip.Size = new Size(58, 25);
      this.fileToolStrip.TabIndex = 0;
      this.fileToolStrip.Text = "File";
      this.openFileToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.openFileToolStripButton.Image = (Image) Resources.openHS;
      this.openFileToolStripButton.ImageTransparentColor = Color.Magenta;
      this.openFileToolStripButton.Name = "openFileToolStripButton";
      this.openFileToolStripButton.Size = new Size(23, 22);
      this.openFileToolStripButton.Text = "Open file";
      // ISSUE: method pointer
        this.openFileToolStripButton.Click += openFile;
      this.extractAllToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.extractAllToolStripButton.Image = (Image) Resources.SaveAllHS;
      this.extractAllToolStripButton.ImageTransparentColor = Color.Magenta;
      this.extractAllToolStripButton.Name = "extractAllToolStripButton";
      this.extractAllToolStripButton.Size = new Size(23, 22);
      this.extractAllToolStripButton.Text = "Extract all";
      // ISSUE: method pointer
        this.extractAllToolStripButton.Click += extractAll;
      this.contextMenuStripFolder.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.extractFolderToolStripMenuItem
      });
      this.contextMenuStripFolder.Name = "contextMenuStripFolder";
      this.contextMenuStripFolder.Size = new Size(141, 26);
      this.extractFolderToolStripMenuItem.Name = "extractFolderToolStripMenuItem";
      this.extractFolderToolStripMenuItem.Size = new Size(140, 22);
      this.extractFolderToolStripMenuItem.Text = "Extract folder";
      // ISSUE: method pointer
        this.extractFolderToolStripMenuItem.Click += extractFolder;
      this.openFileDialog.Filter = "All files (*.*)|*.*";
      this.contextMenuStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.extractFileToolStripMenuItem
      });
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.Size = new Size((int) sbyte.MaxValue, 26);
      this.extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
      this.extractFileToolStripMenuItem.Size = new Size(126, 22);
      this.extractFileToolStripMenuItem.Text = "Extract file";
      // ISSUE: method pointer
        this.extractFileToolStripMenuItem.Click += extractFileToolStripMenuItem_Click;
      this.contextMenuStripMulti.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.extractFilesToolStripMenuItem
      });
      this.contextMenuStripMulti.Name = "contextMenuStripMulti";
      this.contextMenuStripMulti.Size = new Size(132, 26);
      this.extractFilesToolStripMenuItem.Name = "extractFilesToolStripMenuItem";
      this.extractFilesToolStripMenuItem.Size = new Size(131, 22);
      this.extractFilesToolStripMenuItem.Text = "Extract files";
      // ISSUE: method pointer
        this.extractFilesToolStripMenuItem.Click += extractFilesToolStripMenuItem_Click;
      this.saveFileDialog.Filter = "All files (*.*)|*.*";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(729, 395);
      this.Controls.Add((Control) this.toolStripContainer1);
      this.Controls.Add((Control) this.statusStrip);
      this.Controls.Add((Control) this.menuStrip);
      //this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.Text = "wxPirs";
      // ISSUE: method pointer
        this.FormClosing += MainForm_FormClosing;
      // ISSUE: method pointer
        this.Load += MainForm_Load;
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.splitContainerH.Panel1.ResumeLayout(false);
      this.splitContainerH.Panel2.ResumeLayout(false);
      this.splitContainerH.Panel2.PerformLayout();
      this.splitContainerH.ResumeLayout(false);
      this.splitContainerV.Panel1.ResumeLayout(false);
      this.splitContainerV.Panel2.ResumeLayout(false);
      this.splitContainerV.ResumeLayout(false);
      this.fileToolStrip.ResumeLayout(false);
      this.fileToolStrip.PerformLayout();
      this.contextMenuStripFolder.ResumeLayout(false);
      this.contextMenuStrip.ResumeLayout(false);
      this.contextMenuStripMulti.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void log(string message)
    {
      this.textBoxLog.AppendText(message);
    }

    private void openFile(object sender, EventArgs e)
    {
      if (this.openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.openFile(this.openFileDialog.FileName);
    }

    private void openFile(string filename)
    {
      this.textBoxLog.Clear();
      this.folderBrowserDialog.SelectedPath = this.wr.extractFolderName(this.openFileDialog.FileName);
      if (this.br != null)
        this.br.Close();
      if (this.fs != null)
        this.fs.Dispose();
      this.treeView.BeginUpdate();
      this.treeView.Nodes.Clear();
      this.treeView.EndUpdate();
      this.listView.BeginUpdate();
      this.listView.Items.Clear();
      this.listView.EndUpdate();
      try
      {
        this.fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
        this.br = new BinaryReader((Stream) this.fs);
        this.getDescription();
        this.br.BaseStream.Seek(0L, SeekOrigin.Begin);
        int num1 = this.wr.readInt32(this.br);
        if (num1 != MainForm.MAGIC_PIRS && num1 != MainForm.MAGIC_LIVE && num1 != MainForm.MAGIC_CON_)
        {
          this.log("Not a PIRS/LIVE file!\r\n");
          this.br.Close();
          this.fs.Close();
        }
        else
        {
          this.br.BaseStream.Seek(49200L, SeekOrigin.Begin);
          int num2 = this.wr.readInt32(this.br);
          if (num1 == MainForm.MAGIC_CON_)
          {
            this.pirs_offset = MainForm.PIRS_TYPE2;
            this.pirs_start = 49152L;
          }
          else if (num2 == (int) ushort.MaxValue)
          {
            this.pirs_offset = MainForm.PIRS_TYPE1;
            this.pirs_start = MainForm.PIRS_BASE + this.pirs_offset;
          }
          else
          {
            this.pirs_offset = MainForm.PIRS_TYPE2;
            this.pirs_start = MainForm.PIRS_BASE + this.pirs_offset;
          }

            //GetSongDta();
          this.parse(filename);
        }
      }
      catch (IOException ex)
      {
        this.log(string.Format("{0}\r\n", (object) ex.Message));
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Exit();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Exit();
    }

    private void Exit()
    {
      base.Dispose();
    }

    private MainForm.PirsEntry getEntry()
    {
      MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
      pirsEntry.Filename = this.wr.readString(this.br, 38U);
      if (pirsEntry.Filename.Trim() == "")
        return pirsEntry;
      pirsEntry.Unknow = this.wr.readInt32(this.br);
      pirsEntry.BlockLen = this.wr.readInt32(this.br);
      pirsEntry.Cluster = this.br.ReadInt32() >> 8;
      pirsEntry.Parent = this.wr.readUInt16(this.br);
      pirsEntry.Size = this.wr.readInt32(this.br);
      pirsEntry.DateTime1 = this.dosDateTime(this.wr.readInt32(this.br));
      pirsEntry.DateTime2 = this.dosDateTime(this.wr.readInt32(this.br));
      return pirsEntry;
    }

    private DateTime dosDateTime(int datetime)
    {
        return DateTime.Now;
        //return this.dosDateTime((short)(datetime >> 16), (short)(datetime - (datetime >> 16 << 16)));
    }

    private DateTime dosDateTime(short date, short time)
    {
        return DateTime.Now;
      //  if ((int)date == 0 && (int)time == 0)
      //  return DateTime.Now;
      //else
      //    //return new DateTime((((int)date & 65024) >> 9) + 1980, ((int)date & 480) >> 5, (int)(date & 31) + 1, ((int)time & 63488) >> 11, ((int)time & 2016) >> 5, ((int)time & 31) * 2); 
      //return new DateTime((((int)date & 65024) >> 9) + 1980, ((int)date & 480) >> 5, 1, 11,11,11);
    }

    private void getFiles(TreeNode tn)
    {
      int num1 = 0;
      while (true)
      {
        this.br.BaseStream.Seek(this.pirs_start + (long) (num1 * 64), SeekOrigin.Begin);
        MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
        MainForm.PirsEntry entry = this.getEntry();
        if (!(entry.Filename.Trim() == ""))
        {
          if (entry.Cluster == 0 && entry.Size == 0 && (int) entry.Parent == (int) Convert.ToUInt16(tn.Tag))
          {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = entry.Filename;
            listViewItem.SubItems.Add(entry.Size.ToString());
            listViewItem.SubItems.Add(entry.Cluster.ToString());
            listViewItem.SubItems.Add(entry.DateTime1.ToString());
            listViewItem.SubItems.Add("");
            listViewItem.ImageIndex = 0;
            listViewItem.Tag = (object) num1;
            this.listView.Items.Add(listViewItem);
          }
          ++num1;
        }
        else
          break;
      }
      int num2 = 0;
      while (true)
      {
        this.br.BaseStream.Seek(this.pirs_start + (long) (num2 * 64), SeekOrigin.Begin);
        MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
        pirsEntry = this.getEntry();
        if (!(pirsEntry.Filename.Trim() == ""))
        {
          if (pirsEntry.Cluster != 0 && (int) pirsEntry.Parent == (int) Convert.ToUInt16(tn.Tag))
          {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = pirsEntry.Filename;
            listViewItem.SubItems.Add(pirsEntry.Size.ToString());
            listViewItem.SubItems.Add(pirsEntry.Cluster.ToString());
            listViewItem.SubItems.Add(pirsEntry.DateTime1.ToString());
            listViewItem.SubItems.Add("");
            listViewItem.ImageIndex = 1;
            listViewItem.ToolTipText = string.Format("Offset : 0x{0:X8}", (object) this.getOffset((long) pirsEntry.Cluster));
            this.listView.Items.Add(listViewItem);
          }
          ++num2;
        }
        else
          break;
      }
    }

    private void getDirectories(TreeNode tn)
    {
      int num = 0;
      while (true)
      {
        this.br.BaseStream.Seek(this.pirs_start + (long) (num * 64), SeekOrigin.Begin);
        MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
        MainForm.PirsEntry entry = this.getEntry();
        if (!(entry.Filename.Trim() == ""))
        {
          if (entry.Size == 0 && entry.Cluster == 0 && (int) entry.Parent == (int) Convert.ToUInt16(tn.Tag))
          {
            TreeNode treeNode = new TreeNode(entry.Filename);
            treeNode.Tag = (object) num;
            treeNode.ToolTipText = string.Format("0x{0:X4}", treeNode.Tag);
            tn.Nodes.Add(treeNode);
            this.getDirectories(treeNode);
          }
          ++num;
        }
        else
          break;
      }
    }

    private void parse(string filename)
    {
      this.treeView.BeginUpdate();
      this.treeView.Nodes.Clear();
      this.listView.BeginUpdate();
      this.listView.Items.Clear();
      TreeNode treeNode = new TreeNode(this.wr.extractFileName(filename), 0, 0);
      treeNode.Tag = (object) ushort.MaxValue;
      treeNode.ToolTipText = string.Format("0x{0:X4}", treeNode.Tag);
      this.treeView.Nodes.Add(treeNode);
      this.getDirectories(treeNode);
      this.getFiles(treeNode);
      treeNode.Expand();
      this.listView.EndUpdate();
      this.treeView.EndUpdate();
    }

    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.listView.BeginUpdate();
      this.listView.Items.Clear();
      this.getFiles(e.Node);
      this.listView.EndUpdate();
    }

    private long getOffset(long cluster)
    {
      long num1 = this.pirs_start + cluster * 4096L;
      long num2 = cluster / 170L;
      long num3 = num2 / 170L;
      if (num2 > 0L)
        num1 += (num2 + 1L) * this.pirs_offset;
      if (num3 > 0L)
        num1 += (num3 + 1L) * this.pirs_offset;
      return num1;
    }

    private void extractFile(ListViewItem listViewItem, string filename)
    {
      try
      {
        if (!Directory.Exists(this.wr.extractFolderName(filename)))
          Directory.CreateDirectory(this.wr.extractFolderName(filename));
      }
      catch (IOException ex)
      {
      }
      FileStream fileStream;
      BinaryWriter binaryWriter;
      try
      {
        fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
        binaryWriter = new BinaryWriter((Stream) fileStream);
      }
      catch (IOException ex)
      {
        this.log(string.Format("Error : {0}\r\n", (object) ex));
        return;
      }
      long cluster1 = Convert.ToInt64(listViewItem.SubItems[this.columnHeaderCluster.Index].Text);
      this.getOffset(cluster1);
      long num1 = Convert.ToInt64(listViewItem.SubItems[this.columnHeaderSize.Index].Text);
      long num2 = num1 >> 12;
      long num3 = num1 - (num2 << 12);
      for (long cluster2 = cluster1; cluster2 < cluster1 + num2; ++cluster2)
      {
        this.br.BaseStream.Seek(this.getOffset(cluster2), SeekOrigin.Begin);
        binaryWriter.Write(this.br.ReadBytes(4096));
        //string str = string.Format("{0}%", (object) (100L * (cluster2 - cluster1) / num2));
        //if (str != listViewItem.SubItems[this.columnHeaderStatus.Index].Text)
        //{
        //  listViewItem.SubItems[this.columnHeaderStatus.Index].Text = str;
        //  Application.DoEvents();
        //}
      }
      this.br.BaseStream.Seek(this.getOffset(cluster1 + num2), SeekOrigin.Begin);
      binaryWriter.Write(this.br.ReadBytes((int) num3));
      listViewItem.SubItems[this.columnHeaderStatus.Index].Text = "Done";
      Application.DoEvents();
      binaryWriter.Close();
      fileStream.Dispose();
    }

    private void extractFile(long cluster, long size, string filename)
    {
      try
      {
        if (!Directory.Exists(this.wr.extractFolderName(filename)))
          Directory.CreateDirectory(this.wr.extractFolderName(filename));
      }
      catch (IOException ex)
      {
      }
      FileStream fileStream;
      BinaryWriter binaryWriter;
      try
      {
        fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
        binaryWriter = new BinaryWriter((Stream) fileStream);
      }
      catch (IOException ex)
      {
        this.log(string.Format("Error : {0}\r\n", (object) ex));
        return;
      }
      long num1 = size >> 12;
      long num2 = size - (num1 << 12);
      for (long cluster1 = cluster; cluster1 < cluster + num1; ++cluster1)
      {
        this.br.BaseStream.Seek(this.getOffset(cluster1), SeekOrigin.Begin);
        binaryWriter.Write(this.br.ReadBytes(4096));
        Application.DoEvents();
      }
      this.br.BaseStream.Seek(this.getOffset(cluster + num1), SeekOrigin.Begin);
      binaryWriter.Write(this.br.ReadBytes((int) num2));
      Application.DoEvents();
      binaryWriter.Close();
      fileStream.Dispose();
    }

    private void extractFolder(ListViewItem listViewItem, string pathname)
    {
      listViewItem.SubItems[this.columnHeaderStatus.Index].Text = "Working...";
      Application.DoEvents();
      this.extractFolder(Convert.ToUInt16(listViewItem.Tag), listViewItem.Text, pathname);
      listViewItem.SubItems[this.columnHeaderStatus.Index].Text = "Done";
      Application.DoEvents();
    }

    private void extractFolder(ushort tag, string foldername, string pathname)
    {
      ushort tag1 = (ushort) 0;
      while (true)
      {
        this.br.BaseStream.Seek(MainForm.PIRS_BASE + this.pirs_offset + (long) ((int) tag1 * 64), SeekOrigin.Begin);
        MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
        pirsEntry = this.getEntry();
        if (!(pirsEntry.Filename.Trim() == ""))
        {
          if (pirsEntry.Cluster == 0 && pirsEntry.Size == 0 && (int) pirsEntry.Parent == (int) tag)
            this.extractFolder(tag1, pirsEntry.Filename, pathname + "\\" + foldername);
          else if (pirsEntry.Cluster != 0 && (int) pirsEntry.Parent == (int) tag)
            this.extractFile((long) pirsEntry.Cluster, (long) pirsEntry.Size, pathname + "\\" + foldername + "\\" + pirsEntry.Filename);
          ++tag1;
        }
        else
          break;
      }
    }

    private void listView_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right && this.listView.SelectedItems.Count == 1)
      {
        if (this.isFolder(this.listView.SelectedItems[0]))
          this.contextMenuStripMulti.Show((Control) this.listView, e.X, e.Y);
        else
          this.contextMenuStrip.Show((Control) this.listView, e.X, e.Y);
      }
      else
      {
        if (e.Button != MouseButtons.Right || this.listView.SelectedItems.Count <= 1)
          return;
        this.contextMenuStripMulti.Show((Control) this.listView, e.X, e.Y);
      }
    }

    private bool isFolder(ListViewItem listViewItem)
    {
      return listViewItem.ImageIndex == 0;
    }

    private void extractFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      for (int index = 0; index < this.listView.SelectedItems.Count; ++index)
      {
        if (this.isFolder(this.listView.SelectedItems[index]))
        {
          this.log(string.Format("Extract folder {0}\r\n", (object) this.listView.SelectedItems[index].Text));
          this.extractFolder(this.listView.SelectedItems[index], this.folderBrowserDialog.SelectedPath);
        }
        else
          this.extractFile(this.listView.SelectedItems[index], this.folderBrowserDialog.SelectedPath + "\\" + this.listView.SelectedItems[index].Text);
      }
    }

    private void extractFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.saveFileDialog.FileName = this.listView.SelectedItems[0].Text;
      if (this.saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.extractFile(this.listView.SelectedItems[0], this.saveFileDialog.FileName);
    }

    private void aboutPirsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox aboutBox = new AboutBox();
      int num = (int) aboutBox.ShowDialog();
      aboutBox.Dispose();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.toolStripStatusLabelVersion.Text = Application.ProductName + " - " + ((object) Assembly.GetExecutingAssembly().GetName().Version).ToString();
      if (this.args.Length <= 0)
        return;
      this.openFileDialog.FileName = this.args[0];
      this.openFile(this.args[0]);
    }

    private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      this.treeView.SelectedNode = e.Node;
      this.contextMenuStripFolder.Show((Control) this.treeView, e.X, e.Y);
    }

    private void extractFolder(object sender, EventArgs e)
    {
      if (this.treeView.SelectedNode == null || this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      for (int index = 0; index < this.listView.Items.Count; ++index)
      {
        if (this.isFolder(this.listView.Items[index]))
          this.extractFolder(this.listView.Items[index], this.folderBrowserDialog.SelectedPath);
        else
          this.extractFile(this.listView.Items[index], this.folderBrowserDialog.SelectedPath + "\\" + this.listView.Items[index].Text);
        Application.DoEvents();
      }
    }

    private void extractAll(object sender, EventArgs e)
    {
      this.treeView.SelectedNode = this.treeView.Nodes[0];
      this.extractFolder(sender, e);
    }

    private long getCultureOffset()
    {
      return !(Application.CurrentCulture.TwoLetterISOLanguageName.ToLower() == "de") ? (!(Application.CurrentCulture.TwoLetterISOLanguageName.ToLower() == "fr") ? (!(Application.CurrentCulture.TwoLetterISOLanguageName.ToLower() == "es") ? (!(Application.CurrentCulture.TwoLetterISOLanguageName.ToLower() == "it") ? 0L : 1280L) : 1024L) : 768L) : 512L;
    }

    private void getDescription()
    {
      long cultureOffset = this.getCultureOffset();
      this.br.BaseStream.Seek(1040L + cultureOffset, SeekOrigin.Begin);
      byte[] numArray1 = new byte[256];
      this.log("Title : " + this.wr.unicodeToStr(this.br.ReadBytes(256), 2) + "\r\n");
      this.br.BaseStream.Seek(3344L + cultureOffset, SeekOrigin.Begin);
      byte[] numArray2 = new byte[256];
      this.log("Description : " + this.wr.unicodeToStr(this.br.ReadBytes(256), 2) + "\r\n");
      this.br.BaseStream.Seek(5648L, SeekOrigin.Begin);
      byte[] numArray3 = new byte[256];
      this.log("Publisher : " + this.wr.unicodeToStr(this.br.ReadBytes(256), 2) + "\r\n");
    }

    public struct PirsEntry
    {
      public string Filename;
      public int Unknow;
      public int BlockLen;
      public int Cluster;
      public ushort Parent;
      public int Size;
      public DateTime DateTime1;
      public DateTime DateTime2;
    }
  }
}
