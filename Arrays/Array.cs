using System;

namespace Arrays
{
    public class Array
    {
      
        private int[] Numbers;
        private int count;
        public Array(int length)
        {          
            Numbers = new int[length];
        }

        public void Insert(int item)
        {           
            if(count == Numbers.Length)
            {
                int[] temp = new int[count * 2];
                for(int i=0; i< Numbers.Length; i++)                
                    temp[i] = Numbers[i];
                
                Numbers = temp;
            }
            Numbers[count++] = item;       
          
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count)
                throw new ArgumentException();

            for (int i = index; i < count; i++)
                Numbers[i] = Numbers[index + 1];

            count--;

        }

        public int IndexOf(int item)
        {
            // 0(n)
            int index = -1;
            for(int i=0; i<count; i++)
            {
                if (Numbers[i] == item)
                    index = i;
            }
            return index;
        }

        public int Max()
        {
            // 0(n)
            int max = 0;
            for(int i=0; i<count; i++)
            {
                if (Numbers[i] > max)
                    max = Numbers[i];
            }
            return max;
        }

        public void Intersect(int[] arr)
        {
            // 0 (n * n) or 0 (n^2)
            int[] arrCommon = new int[arr.Length + count];
            int arrCount = 0;

            for(int i=0; i<count; i++)
            {
                for(int j=0; j<arr.Length; j++)
                {
                    if(Numbers[i] == arr[j])
                    {
                        arrCommon[arrCount] = Numbers[i];
                        arrCount++;
                    }
                }
            }
            if(arrCount > 0)
            {
                for(int i=0; i<arrCount; i++)
                {
                    Console.WriteLine($"Common items are {arrCommon[i]}");
                }
            }            
        }

        public void Reverse()
        {
            int[] reversed = new int[count];
            int reverseCount = 0;
            for(int i=count-1; i>=0; i--)            
                reversed[reverseCount++] = Numbers[i];
            Numbers = reversed;
        }

        public void InsertAt(int item, int index)
        {
            var newArray = new int[count + 1];
            int newArrCount = 0;

            if (index < 0 || index > count)
                throw new ArgumentException();

            for(int i=0;i<count; i++)
            {
                if (newArrCount == index)
                {
                    newArray[newArrCount] = item;
                    newArrCount++;                   
                    i--;
                }
                else
                {
                    newArray[newArrCount] = Numbers[i];
                    newArrCount++;
                }
            }
            Numbers = newArray;
            count = newArrCount;
        }

        public void Print()
        {
            for (int i=0; i<count; i++)
            {
                System.Console.WriteLine(Numbers[i]);
            }
        }

    }
}
