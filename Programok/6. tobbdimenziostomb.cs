using System;

public class Program{
    public static void Main(){
        //több dimenziós tömb deklarálása
        int[,] tmb1 = new int[10,5];

        //több dimenziós tömb feltöltése, kiiratása
        for(int i=0;i<10;i++){
            for(int j=0;j<5;j++){
                tmb1[i,j] = (i+1)*(j+1);
                Console.Write(tmb1[i,j] + " ");
            }
            Console.WriteLine();
        }
        
        //több dimenziós tömb foreach-el
        Console.WriteLine();
        int[][] tmb3 = new int[2][] { new int[3] {1, 2, 3}, new int[3] {4, 5, 6} };
        foreach (int[] t in tmb3) {
            foreach (int i in t) {
                Console.Write(i);
            }
        }

        //nem kell, hogy ugyan akkorák legyenek 
        Console.WriteLine();
        int[][] tmb2 = new int[2][] { new int[5] {1, 2, 3, 4, 5}, new int[3] {6, 7, 8} };
        foreach (int[] t in tmb2) {
            foreach (int i in t) {
                Console.Write(i);
            }
        }
    }
}