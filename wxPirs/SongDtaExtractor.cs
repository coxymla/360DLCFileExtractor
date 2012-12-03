using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace wxPirs
{
  public partial class MainForm
  {
      public void ProcessFiles(string filename, string outputDir)
      {
          //this.textBoxLog.Clear();
          //this.folderBrowserDialog.SelectedPath = this.wr.extractFolderName(this.openFileDialog.FileName);
          if (this.br != null)
              this.br.Close();
          if (this.fs != null)
              this.fs.Dispose();
          //this.treeView.BeginUpdate();
          //this.treeView.Nodes.Clear();
          //this.treeView.EndUpdate();
          //this.listView.BeginUpdate();
          //this.listView.Items.Clear();
          //this.listView.EndUpdate();
          try
          {
              this.fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
              this.br = new BinaryReader((Stream)this.fs);
              //this.getDescription();
              this.br.BaseStream.Seek(0L, SeekOrigin.Begin);
              int num1 = this.wr.readInt32(this.br);
              if (num1 != MainForm.MAGIC_PIRS && num1 != MainForm.MAGIC_LIVE && num1 != MainForm.MAGIC_CON_)
              {
                  Console.WriteLine("Not a PIRS/LIVE file!\r\n");
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
                  else if (num2 == (int)ushort.MaxValue)
                  {
                      this.pirs_offset = MainForm.PIRS_TYPE1;
                      this.pirs_start = MainForm.PIRS_BASE + this.pirs_offset;
                  }
                  else
                  {
                      this.pirs_offset = MainForm.PIRS_TYPE2;
                      this.pirs_start = MainForm.PIRS_BASE + this.pirs_offset;
                  }

                  GetSongDta(outputDir);
              }
          }
          catch (Exception ex)
          {
              Console.WriteLine(ex);
          }
      }

      public void GetSongDta(string path)
      {
          int num1 = 0;
          while (true)
          {
              this.br.BaseStream.Seek(this.pirs_start + (long)(num1 * 64), SeekOrigin.Begin);
              MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
              MainForm.PirsEntry entry = this.getEntry();
              if (entry.Filename == "songs.dta")
              {
                  var filename = Path.Combine(path, Guid.NewGuid().ToString());
                  extractFile(entry.Cluster, entry.Size, filename);
                  return;
              }

              if ((entry.Filename.Trim() == ""))
              {
                  break;
              }

              ++num1;
          }

          int num2 = 0;
          while (true)
          {
              this.br.BaseStream.Seek(this.pirs_start + (long) (num2*64), SeekOrigin.Begin);
              MainForm.PirsEntry pirsEntry = new MainForm.PirsEntry();
              pirsEntry = this.getEntry();
              if (pirsEntry.Filename == "songs.dta")
              {
                  var filename = Path.Combine(path, Guid.NewGuid().ToString());
                  extractFile(pirsEntry.Cluster, pirsEntry.Size, filename);
                  return;
              }

              if ((pirsEntry.Filename.Trim() == ""))
              {
                  break;
              }

              ++num2;
          }
      }
  }
}
