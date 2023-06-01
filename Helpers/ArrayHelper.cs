using System;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public static class ArrayHelper
    {
        public static void AddElementToArray(ref Sweet[] array, Sweet newElement)
        {
            if (newElement == null)
            {
                return;
            }

            var currentSize = (array == null) ? 0 : array.Length;
            var temp = new Sweet[currentSize + 1];
            for (var i = 0; i < currentSize; i++)
            {
                temp[i] = array[i];
            }

            temp[currentSize] = newElement;
            array = temp;
        }

        public static void AddElementToArray(ref Present[] array, Present newElement)
        {
            if (newElement == null)
            {
                return;
            }

            var currentSize = (array == null) ? 0 : array.Length;
            var temp = new Present[currentSize + 1];
            for (var i = 0; i < currentSize; i++)
            {
                temp[i] = array[i];
            }

            temp[currentSize] = newElement;
            array = temp;
        }

        public static void SortSweetByName(Sweet[] array)
        {
            Array.Sort(array, new SweetComparer());
        }

        public static void SortChocolateByType(Sweet[] array)
        {
            Array.Sort(array, new ChocolateComparer());
        }
    }
}
