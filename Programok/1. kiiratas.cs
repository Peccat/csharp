/*
	Short keys:
	alt + le/fel nyíl			sorok mozgatása
	alt + shift + le/fel nyíl	sorok duplikálása
	ctrl + f5					run
	alt + f5					debug
	f7							Check syntax
	crtl + c					másol
	ctrl + v					beilleszt
	ctrl + z					visszavon
	ctrl + y					visszavonja a visszavonást
	ctrl + s					ment

	C#: Modern, fejlett, magas szintű progrmozási nyelv egy csomó előre megírt függvénnyel. Microsoft fejlesztette (van hozzá 
		dokumentáció, referenciák a neten) a .NET keretrendszerrel Egyszerű szintaktika, Objektum Orientált, alapja a C++ és a 
		java, szóval ha az megy, akkor ez sem lesz nehéz és fordítva is igaz. Erősen tipusos, dinamikus és statikus elemei is vannak.   

	Visual Studio Code egy egyszerű fejlesztő környezet, alapból kb egy szövegszerkesztőhöz lehet hasonlítani, és kell nekünk majd a
		GitLab letöltése, hogy a githubbal össze lehessen kötni. Kell egy kiegészítő, hogy C# kódot tudjunk írni benne és futtatni 
		(CS-Script). Így már többet tud, mint egy szövegszerkesztő
		Van egy csomó kiegészítő hozzá, így lehet a kódot is színesebbé tenni pl.: "Prettier - Code formatter"

	Visual Studio 2022 rövid ismertetése(komplexebb, kiegészítőket lehet letölteni, intelligensebb, nuget peckage-ek, 
		Asztali alkalmazást is lehet benne csinálni, webes alkalmazás írására is alkalmas, mindegy melyiket használjuk,
		mert most nem kell nekünk olyan, amit a code nem tud)

	Run in terminal kell majd nekünk, ha bekérünk adatokat, de ha csak kiírunk, akkor a sima ctrl+f5 elég egyenlőre
	bal oldalt a fileok
	Github ismertetése, fiók készítése , hogyan csatolom hozzá a projektemet?
	Repository clonozása a VS Code-ba
	Utána a változások feltöltése
	ugyan abba a main merge-be, másik merge készítése
	Az órai anyagokat hol találják majd meg (Légyszi csinálj egy github fiókot, és oda minden óra végén tedd fel, hogy meddig jutottatok)
*/
using System;

class Program{
    public static void Main(){
        Console.Write("Hello Word!");                               //Simán egymás mellé tudsz kiírni 
        Console.WriteLine("Ez a legjobb nap, hogy elkezdd tanulni a C#-ot.");

        Console.WriteLine("\nA kiirast " + "igy is " + "ossze tudod fuzni.");
        //\n sortörés; \t tabulátor

        Console.WriteLine("Ez egy");                                
        Console.WriteLine("tobb soros kiiras");                     //WriteLine egy sortöréssel ér fel a sor végén		
		
		Console.WriteLine("Uss le egy gombot es a program futasa leall.");

		/*
         Ez egy több soros komment
         Nagyon hasznos ha például egy kódrészt egy ideig
         nem szeretnénk futtatni, de később még szükségünk lehet rá.
         Így nem veszik el de nem is fut le.
		 
		 Vagy ha a késöbbiekben többen akartok dolgozni egy
		 projecten és így röviden el tudjátok magyarázni, hogy mit csinál
		 vagy milyen adatokat ad át, mit vár stb..
        */

		Console.ReadKey(true); //ha terminálablakban futtatjuk, akkor megvárja, amíg leütünk egy gombot és csak utána zárja be magát
    }
}