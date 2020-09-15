using System;

namespace CS
{

    class Array
    {
    private const int V1 = 5;
    private const int V = V1;

    void Learn1DArrays()
        {
        int[] ages = new int[V1];
        ages[0] = 18;
        ages[1] = 28;
        ages[2] = 8;

        int[] ages2 = {2, 25, 55};

        int[] ages3 = new int[3] {34, 67, 101};
        }

    void LearnMDArrays()
    {
        int[,] mulTable = new int[2,2];
        mulTable[0,0] = 2;

        int[,,] mulTable2 = new int[2,2,2];
        mulTable2[0,0,0] = 2;

        byte[,] numbers =  {{1,3},{2,2}};
    }

    void LearnJaggedArrays()
    {
        int [][] jaggTable = new int [3][];
        jaggTable[0] = new int [V1];
    }
}
}
