using System;
using System.Windows.Forms;

namespace kurs
{
    class RenameVarListBox : CheckedListBox
    {
        public RenameVarListBox() : base()
        {
            DisplayMember = "Name";
            data = new RenameVarData[RenameVar.All.Length];
            for(int i = 0; i < RenameVar.All.Length; i++)
            {
                Items.Add(RenameVar.All[i]);
                data[i] = new RenameVarData(RenameVar.All[i]);
            }
            ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(ItemCheckEvent);
            CheckAllowFlag = false;
        }

        private void ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (!CheckAllowFlag)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        public RenameVarData GetCurrentData()
        {
            return SelectedIndex >= 0 ? data[SelectedIndex] : null;   
        }

        public void UpdateData()
        {
            CheckAllowFlag = true;
            for(int i = 0; i < data.Length; i++)
            {
                SetItemChecked(i, !data[i].IsNoAction);
            }
            CheckAllowFlag = false;
        }

        public void Process(MediaFile mf, LogForm log, ref bool WereErrors)
        {
            for (int i = 0; i < data.Length; i++)
            {
                ((RenameVar)Items[i]).Process(mf, data[i]);
            }
            mf.DoRename(log, ref WereErrors);
        }


        private RenameVarData[] data;
        private bool CheckAllowFlag;
    }
}
