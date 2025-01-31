﻿/*
        MIT License
       
       Copyright (c) 2020-2025 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

using System.Diagnostics;

namespace AlastairLundy.Extensions.System.Processes
{
    public static class IsProcessRunningExtensions
    {
        /// <summary>
        /// Check to see if a specified process is running or not.
        /// </summary>
        /// <param name="process">The process object.</param>
        /// <param name="processName">The name of the process to be checked.</param>
        /// <returns>true if the specified process is running; returns false otherwise.</returns>
        public static bool IsProcessRunning(this Process process, string processName)
        {
            foreach (Process proc in Process.GetProcesses())
            {
                string procName =  proc.ProcessName.Replace("System.Diagnostics.Process (", string.Empty);
                processName = processName.Replace(")", string.Empty);

                if (processName.Contains(processName))
                {
                    processName = processName.Replace(".exe", string.Empty);
                }
                
                if (procName.ToLower().Equals(processName.ToLower()) ||
                    procName.ToLower().Contains(processName.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}