using MySQLNotes.Model;
using MySQLNotes.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLNotes.Views
{
    public class TreeViewNotebooksViews:ITreeViewNotebooksView
    {
        private const string DUMMY = "_dummy_";
        private readonly TreeView control;
        TreeNode root;
        public TreeViewNotebooksViews(TreeView control)
        {
            this.control = control;
            root = control.Nodes.Add("Notebooks");
            root.Nodes.Add(DUMMY);
            root.ImageIndex = 0;
            this.control.BeforeExpand += (s, e) =>
            {
                if (e.Node.Nodes.Count==1 && e.Node.Nodes[0].Text == DUMMY)
                {
                    e.Node.Nodes[0].Remove();
                    var children = this?. OnExpand(e.Node.Tag as NotebookNodeModel);
                }
            };
        }

        public event ExpandDelegate OnExpand;
    }
}
