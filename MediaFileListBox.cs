using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace kurs
{
    class MediaFileListBox : CheckedListBox
    {
        public MediaFileListBox() : base()
        {
            DisplayMember = "Name";
        }

        public void DoUpdate()
        {
            Invalidate();
        }

        private bool IsAlreadyInList(string filename)
        {
            foreach (MediaFile x in this.Items)
            {
                if (x.FullName == filename) return true;
            }
            return false;
        }

        public bool AddFile(string filename)
        {
            if (IsAlreadyInList(filename))
            {
                return true;
            }

            MediaFile mf = new MediaFile(filename);
            if (!mf.ValidName)
            {
                return false;
            }
            int idx = Items.Add(mf);
            SetItemChecked(idx, true);
            return true;
        }

        public void RemoveAll()
        {
            Items.Clear();
        }

        public void RemoveChecked()
        {
            CheckedItems.Cast<object>().ToList().ForEach(x => Items.Remove(x));
        }

        public void CheckAll()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                SetItemChecked(i, true);
            }
        }
        public void UnCheckAll()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                SetItemChecked(i, false);
            }
        }
    }
}
