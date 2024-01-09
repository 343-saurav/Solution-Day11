using System;



class Class1
{
    static void Average(int[] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);

    }
    static void MatrixSum(int[,] matrixsum)
    {
        int sum = 0;

        Console.WriteLine("Enter elements of the matrix:");
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                matrixsum[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += matrixsum[i, j];
            }
        }

        // printing the result
        Console.WriteLine("\nSum of the matrix: {0}", sum);
    }
    static void MaximumNum(int[] arr)
    {
        int max1 = 0;
        for(int i=0;i<arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < arr.Length; i++)

        {
            if (arr[i] > max1)
            {
                max1 = arr[i];
            }
        }
        Console.WriteLine(max1);
    }
    static void MatrixSumColumn(int[,] matrixColumn)
    {
        int[] sum= new int[3];
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                matrixColumn[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                sum[j] += matrixColumn[i,j];

                }
            }
            for( int i = 0;i < 3; ++i)

            Console.WriteLine(sum[i]);
        }


    static void MatrixSumRow(int[,] matrixRow)
    {
        int[] sum = new int[3];
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                matrixRow[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                sum[i] += matrixRow[i, j];

            }
        }
        for (int i = 0; i < 3; ++i)

            Console.WriteLine(sum[i]);
    }

    static void Main (string[] args)
            {
        //int[] myNum = [10, 20, 30, 40, 60];
        //Average(myNum);
        //int[,] matrix = new int[3, 3];
        //MatrixSum(matrix);
        //int[] array = new int[5];
        //MaximumNum(array);
        //int[,] matrixColumn = new int[3, 3];
        //        MatrixSumColumn(matrixColumn);
        int[,] matrixRow = new int[3, 3];
        MatrixSumRow(matrixRow);
    }
        }