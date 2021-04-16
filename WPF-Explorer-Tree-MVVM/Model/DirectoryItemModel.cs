using WPF_Explorer_Tree_MVVM.FileExplorer;

namespace WPF_Explorer_Tree_MVVM.Model
{
    public class DirectoryItemModel
    {
        public DirectoryItemType Type { get; set; }

        public string FullPath { get; set; }

        public string Name
        {
            get
            {
                return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath);
            }
        }
    }
}
