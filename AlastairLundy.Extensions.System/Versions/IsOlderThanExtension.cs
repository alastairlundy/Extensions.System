﻿/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
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

using System;

namespace AlastairLundy.Extensions.System
{
    public static class IsOlderThanExtension
    {
        /// <summary>
        /// Returns whether a specified Version is older than the current Version object.
        /// </summary>
        /// <param name="version">The current version object.</param>
        /// <param name="versionToBeCompared">The version to be compared.</param>
        /// <returns>true if the specified compared version is older than the current version, and returns false otherwise.</returns>
        public static bool IsOlderThan(this Version version, Version versionToBeCompared)
        {
            if (version.Major < versionToBeCompared.Major)
            {
                if (version.Minor < versionToBeCompared.Minor)
                {
                    if (version.Build < versionToBeCompared.Build)
                    {
                        if (version.Revision < versionToBeCompared.Revision)
                        {
                            return true;
                        }

                        return false;
                    }

                    return false;
                }
                else
                {
                    if (version.Build < versionToBeCompared.Build)
                    {
                        return true;
                    }
                    else
                    {
                        if (version.Revision < versionToBeCompared.Revision)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (version.Minor < versionToBeCompared.Minor)
                {
                    return true;
                }
                else
                {
                    if (version.Build < versionToBeCompared.Build)
                    {
                        return true;
                    }
                    else
                    {
                        if (version.Revision < versionToBeCompared.Revision)
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
        }
    }
}