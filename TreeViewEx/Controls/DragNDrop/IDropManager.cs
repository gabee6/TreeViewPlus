﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Windows.Controls.DragNDrop
{
    public interface IDropManager
    {
        void DragOver(IDropInfo dropInfo);
        void Drop(IDropInfo dropInfo);
    }
}
