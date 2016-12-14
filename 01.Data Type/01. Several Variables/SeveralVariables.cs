/* Декларирайте няколко променливи, като изберете за всяка една най- подходящия от типовете sbyte, byte, short, ushort, int, uint, long и ulong, за да им присвоите следните стойности: 52130, -115, 4825932, 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990; 123456789123456789.*/

using System;

class SeveralVariables
{
    static void Main()
    {
        sbyte sbyteOne = (-115);
        sbyte sbyteTwo = (-44);
        sbyte sbyteThree = 97;
        sbyte sbyteFour = 112;
        
        byte byteOne = 224;

        short shortOne = (-10000);
        short shortTwo = 1990;
        short shortThree = 20000;
        
        ushort ushortOne = 52130;
       
        int intOne= (-1000000);
        int intTwo= 4825932;
        int intThree= 970700000;
          
        long longOne= 123456789123456789;
       
        Console.WriteLine("type \"sbyte\" are: {0},{1},{2},{3}", sbyteOne, sbyteTwo, sbyteThree, sbyteFour);
        Console.WriteLine("type \"byte\" is: {0}", byteOne);
        Console.WriteLine("type \"short\" are: {0},{1},{2} ", shortOne, shortTwo, shortThree);
        Console.WriteLine("type \"ishort\" is: {0}", ushortOne);
        Console.WriteLine("type \"int\" are: {0},{1},{2}", intOne, intTwo, intThree);
        Console.WriteLine("type \"long\" is: {0}", longOne);
    }
}

