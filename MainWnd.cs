using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace kurs
{

    public partial class MainWnd : Form
    {
        public MainWnd()
        {
            InitializeComponent();
            UpdateCount();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            
            var dlg = new OpenFileDialog();
            dlg.Title = "Добавить файлы...";
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.Filter = "Медиа-файлы (*.avi;*.mp4;*.jpg)|*.avi;*.mp4;*.jpg;*.txt|Все файлы (*.*)|*.*";
            dlg.RestoreDirectory = true;
            dlg.Multiselect = true;
            if( dlg.ShowDialog() == DialogResult.OK )
            {
                bool ThereWereErrors = false;
                foreach(string filename in dlg.FileNames)
                {
                    if(!lstFiles.AddFile(filename))
                    {
                        ThereWereErrors = true;
                    }
                }
                if(ThereWereErrors)
                {
                    MessageBox.Show(this, 
                                "Некоторые файлы не были добавлены.\n"+
                                "Проверьте формат имен.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
                UpdateCount();
            }
        }


        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile mf = (MediaFile)lstFiles.SelectedItem;
            if (mf != null)
            {
                tbFullName.Text = mf.FullName;
                tbDate.Text = mf.Date.ToShortDateString();
                tbTime.Text = mf.Date.ToShortTimeString();
                tbDesc.Text = mf.Desc;
                tbLabel.Text = mf.Label;
                tbIndex.Text = mf.Index.ToString();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            lstFiles.CheckAll();
            UpdateCount();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstFiles.RemoveChecked();
            UpdateCount();
        }

        private void MainWnd_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string file in files)
                {
                    lstFiles.AddFile(file);
                }
            }
        }

        private void MainWnd_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string file in files)
                {
                    if (!(new MediaFile(file)).ValidName) return;
                }
                e.Effect = DragDropEffects.Copy;
            }
        }


        private void lstVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbActionType.Items.Clear();

            RenameVarData d = lstVars.GetCurrentData();

            foreach(RenameVarData.Act act in d.Actions)
            {
                cmbActionType.Items.Add(act.Name);
            }
            cmbActionType.SelectedIndex = d.ActionIndex;
            tbActionValue.Text = d.ActionString;
            tbActionValue.Enabled = d.NeedActionString;
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenameVarData d = lstVars.GetCurrentData();
            if(d != null)
            {
                d.ActionIndex = cmbActionType.SelectedIndex;
                tbActionValue.Enabled = d.NeedActionString;
                lstVars.UpdateData(); // update checked states
            }            
        }

        private void tbActionValue_TextChanged(object sender, EventArgs e)
        {
            lstVars.GetCurrentData().ActionString = tbActionValue.Text;
        }

        private void btnDoRename_Click(object sender, EventArgs e)
        {
            if(lstFiles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали файлы", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            LogForm log = new LogForm();
            bool WereErrors = false;
            foreach(MediaFile x in lstFiles.CheckedItems)
            {
                lstVars.Process(x, log, ref WereErrors);
            }
            lstFiles.DoUpdate();
            if(WereErrors)
            {
                MessageBox.Show("При переименовании возникли конфликты, и/или ошибки.\n" +
                                "Подробности смотрите в логе", "Результат операции", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            log.ShowDialog();
            log.Dispose();
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstFiles.UnCheckAll();
            UpdateCount();
        }

        private void UpdateCount(int add = 0)
        {
            lblFileCount.Text = (lstFiles.CheckedItems.Count + add).ToString();
        }

        private void lstFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            UpdateCount(e.NewValue == CheckState.Checked ? 1 : -1);
        }


    }
}
