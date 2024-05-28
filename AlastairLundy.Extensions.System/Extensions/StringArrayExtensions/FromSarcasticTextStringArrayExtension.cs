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
using System.Text;

using AlastairLundy.Extensions.System.StringExtensions;

namespace AlastairLundy.Extensions.System.StringArrayExtensions
{
    public static class FromSarcasticTextStringArrayExtension
    {
        /// <summary>
        /// Takes a string array of words and converts it to a string of text converted from sArCaSm tExT to regular text.
        /// </summary>
        /// <param name="words">The words to be converted to Regular Text.</param>
        /// <returns>a string of text converted from sArCaSm tExT to regular text.</returns>
        [Obsolete]
        public static string FromSarcasmTextToRegularText(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(words[0].CapitalizeFirstLetter());
            
            for(int index = 1; index < words.Length; index++)
            {
                stringBuilder.Append(words[index]);
            }

            return stringBuilder.ToString();
        }
    }
}