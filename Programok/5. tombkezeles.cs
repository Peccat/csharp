/*
    tömb, for és foreach van benne
    A tömbök 0tól indexelődnek, nem 1től. Így a legelső elemet a tömb 0. elemével fogjuk elérni. A legutolsó elemet is így egyel kisebb
    számmal fogjuk elérni.

    Feltöltése történhet kézzel, vagy ciklusokkal automatán is, attól függ milyen értékeket és hogyan akarunk tárolni benne
    A tömböket 3 féle képpen tudjuk létre hozni, attól függ, hogy kapjuk meg majd az elemszámot.
    Érettségin a tömb maximum elemszámát szokták megadni, így akár azt is megadhatjuk méretnek.

    A kiolvasása a tömböknek ugyan úgy több féle képpen történhet meg. használhatunk for ciklust vagy foreach ciklust.


    lista is?

*/

using System;

namespace tombkezeles{
    class Program{
        public static void Main(){
            //tömb létrehozása ha tudjuk hány eleme lesz;
            int[] tmb1 = new int[10];
            
            //tömb létrehozása változóval
            const int tmb2_elemszam = 10;
            int[] tmb2 = new int[tmb2_elemszam];

            //tömb létrehozása elemekkel
            int[] tmb3 = {1,2,5,6,8,9};

            //tömb feltöltése
            for(int i = 0;i<tmb1.Length;i++){
                tmb1[i] = (i + 1) * 5;
                tmb2[i] = (i + 1) * 8;
            }

            //tömb elemeinek kiolvasása for ciklussal
            Console.WriteLine("Tmb1:");
            for(int i = 0; i < tmb1.Length ; i++){
                if(i > 0){Console.Write(", ");} // nem feltétlen kell ez, szóközökkel is el lehet választani a számokat
                Console.Write(tmb1[i]);
            }

            Console.WriteLine("\nTmb2:");
            for(int i = 0; i < tmb2_elemszam ; i++){
                if(i > 0){Console.Write(", ");} // nem feltétlen kell ez, szóközökkel is el lehet választani a számokat
                Console.Write(tmb2[i]);
            }

            //tömb kiolvasása foreach ciklussal
            Console.WriteLine("\nTmb3:");
            foreach(int elemek in tmb3){
                Console.Write(elemek +" ");
            }
        }
    }
}