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

using System.Collections.Generic;

namespace AlastairLundy.Extensions.System.ArrayExtensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ArrayDeDuplicator
    {
        
        public static T[] RemoveDuplicates<T>(this T[] array)
        {
            Dictionary<T, long> items = new Dictionary<T, long>();

            foreach (T item in array)
            {
                if (items.ContainsKey(item))
                {
                    items[item] += 1;
                }
                else
                {
                    items.Add(item, 1);
                }
            }

            T[] newArray = new T[items.Keys.Count];
            
            for(int index = 0; index < items.Count; index++)
            {
                newArray[index] = ;
            }
        }

        /// <summary>
        /// Remove duplicate objects within an array.
        /// </summary>
        /// <param name="arrayWithDuplicates"></param>
        /// <param name="destinationArray"></param>
        /// <typeparam name="T"></typeparam>
        public static void RemoveDuplicates<T>(T[] arrayWithDuplicates, out T[] destinationArray)
        {
            destinationArray = arrayWithDuplicates.RemoveDuplicates();
        }
    }
}