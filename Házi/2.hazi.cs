using System;

class Program{
    public static void Main(){
        /*
            A feladatokhoz, ha kell hozhatsz létre segéd változókat.
            Válaszokat szöveges formában írasd ki a console-ra és elé a feladatot, hogy mi volt a feladat.
            Szorgalmi feladatban lehet olyan, amit még nem vettünk, így az egy kis keresgéléssel járhat!
            Jó gyakorlást!

            1. feladat: Add össze a számokat.
            2. feladat: Ha az ACE oldalak 3szöget adnak ki, akkor mekkora a háromszög kerülete?   
            3. feladat: Ha a BCD oldalak egy háromszög oldalai, akkor mekkora a magassága?
            4. feladat: ABCD négyzög hosszabb átlójának mérete.
            5. feladat: 

            -----------------Szorgalmi----------------------
            1. feladat: (D/(A+B))*C-E képlet megoldása
            2. feladat: Másodfokú egyenlet megoldóképletét csináld meg és számolja ki a program.
            ------------------------------------------------ 
        */

        int A=2,B=3,C=5,D=7,E=9;

        Console.WriteLine("1. feladat: Add össze a számokat.");
        Console.WriteLine(A+B+C+D+E);
        Console.WriteLine("2. feladat: Ha az ACE oldalak 3szöget adnak ki, akkor mekkora a háromszög kerülete?");
        Console.WriteLine(A+C+E);
        Console.WriteLine("3. feladat: Ha a BCD oldalak egy háromszög oldalai, akkor mekkora a magassága?");
        Console.WriteLine();
        Console.WriteLine("4. feladat: ABCD négyzög hosszabb átlójának mérete.");
        Console.WriteLine();
        Console.WriteLine("5. feladat: ");
        Console.WriteLine();
        Console.WriteLine("-----------------Szorgalmi----------------------");
        Console.WriteLine("1. feladat: (D/(A+B))*C-E képlet megoldása");
        Console.WriteLine((D/(A+B))*C-E);
        Console.WriteLine("2. feladat: Másodfokú egyenlet megoldóképletét csináld meg és számolja ki a program.");
        Console.WriteLine("X1:" +( (B*B)+Math.Sqrt(4*A*C)/(2*A) )+ "\tX2:" + ( (B*B)-Math.Sqrt(4*A*C)/(2*A) ) );
        Console.WriteLine("------------------------------------------------");


    }
}