using System;

class BinarySearch
{
    static int IndexOf(int[] sortedArr, int element)
    {
        Array.Sort(sortedArr);
        int devidedBy = 2;
        int howMuchToAdd = 1;
        int timesSubtracted = 1;

        int i = (sortedArr.Length/devidedBy);

        while(i != sortedArr.Length)
        {
            if(sortedArr[i] == element) {
                return i;
            }
            else if(sortedArr[i] < element) {
                howMuchToAdd = (sortedArr.Length/devidedBy) - devidedBy * timesSubtracted;
                i = (sortedArr.Length/devidedBy) + howMuchToAdd;
                timesSubtracted++;
                continue;
            }
            else {
                i--;
                continue;
            }
        }

        return -1;
    }
}