﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Explorer_Tree_MVVM.FileExplorer.Model
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
