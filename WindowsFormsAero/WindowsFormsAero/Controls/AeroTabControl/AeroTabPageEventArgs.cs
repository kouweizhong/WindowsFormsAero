﻿using System;

namespace WindowsFormsAero
{
    [Serializable]
    public class AeroTabPageEventArgs : EventArgs
    {
        private readonly AeroTabPage _page;

        public AeroTabPageEventArgs(AeroTabPage page)
        {
            _page = page;
        }

        public AeroTabPage Page
        {
            get { return _page; }
        }
    }
}
