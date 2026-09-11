using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Utilities
{
    public static class AppLogger
    {
        public static event Action<string>? LogAdded;

        public static void Log(string message)
        {
            LogAdded?.Invoke($"{DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}
