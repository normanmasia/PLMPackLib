//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLMPackLib.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TreeNode
    {
        public TreeNode()
        {
            this.TreeNode1 = new HashSet<TreeNode>();
            this.TreeNodeDocuments = new HashSet<TreeNodeDocument>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentNodeID { get; set; }
        public int ThumbnailID { get; set; }
    
        public virtual Thumbnail Thumbnail { get; set; }
        public virtual ICollection<TreeNode> TreeNode1 { get; set; }
        public virtual TreeNode TreeNode2 { get; set; }
        public virtual ICollection<TreeNodeDocument> TreeNodeDocuments { get; set; }
    }
}
