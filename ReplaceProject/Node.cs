using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceProject
{
    [Serializable]
    public class Node
    {
        /// <summary>
        /// 父文件的物理路径（完整路径）
        /// </summary>
        string parentPath;
        /// <summary>
        /// 当前文件夹的名字
        /// </summary>
        string name;
        int depth;

        public string ParentPath
        {
            get { return parentPath; }
            set { parentPath = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        public class NodeByDepth:IComparer<Node>
        {
            #region IComparer<Node> Members

            public int Compare(Node x, Node y)
            {
                return x.Depth.CompareTo(y.Depth);
            }

            #endregion
        
        }

        public class NodeByDepthDesc : IComparer<Node>
        {
            #region IComparer<Node> Members

            public int Compare(Node x, Node y)
            {
                return y.Depth.CompareTo(x.Depth);
            }

            #endregion

        }

 
    }
}
