using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pic2Pdf
{
    public static class Utils
    {
        #region ListViewItem
        public static void MoveUp(this ListViewItem item)
        {
            var idx = item.Index;
            if (idx == 0)
                return;

            var lv = item.ListView;

            item.Remove();

            lv.Items.Insert(idx - 1, item);
        }

        public static void SelectAll(this ListView lv)
        {
            foreach (ListViewItem item in lv.Items)
                item.Selected = true;
        }

        public static void DeleteSelected(this ListView lv)
        {
            lv.BeginUpdate();

            while (lv.SelectedItems.Count > 0)
                lv.Items.Remove(lv.SelectedItems[0]);

            lv.EndUpdate();
        }

        public static void MoveDown(this ListViewItem item)
        {
            var idx = item.Index;
            var lv = item.ListView;
            if (idx == lv.Items.Count - 1)
                return;

            item.Remove();

            lv.Items.Insert(idx + 1, item);
        }
        #endregion
    }
}
