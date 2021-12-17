using System;

namespace ciklusok
{
    class Program{
        public static void Main(){
            //do while
            //hátul tesztelő ciklus, egyszer mindenképp lefut
            int i = 1;
            Console.WriteLine(i);
            do{
                i++;
                Console.WriteLine(i);
            }while(i!=6); 
            //}while(i == 0); //hiába teljesül a feltétel elsőre, egyszer lefut            
            Console.WriteLine(i);

            //ellenőrzött bekérés
		    string bekert = "";
		    int i = 0;

		    Console.WriteLine("Ird be, hogy \"alma\":");
		    do{
			    if(i>0){
				    Console.WriteLine("Próbáld újra!");
			    }
			    bekert = Console.ReadLine();
			    i++;
			    Console.WriteLine("hossza: " + bekert.Length);
		    }while(bekert != "alma" );
		    //}while(!bekert.Equals("alma"));
		    Console.WriteLine("A szo: " + bekert);

            //while
            //Elöl tesztelő ciklus, nem biztos, hogy lefut
            int j=1;
            Console.WriteLine("j:" + j);
            while(j<5){
            //while(j==0){ //Teljesül a feltétel, így egyzser sem fut le
                j++;
                Console.WriteLine(j);
            }
            Console.WriteLine(j);
            
            //for
            for(int k = 0; k < 10; k++){
                Console.WriteLine("k:" + k );
            }

            for(int l = 10; l != 0; l--){
                Console.WriteLine("l:" + l );
            }
            
            //for ciklusok egyben
            for (i = 0, j=10; i < j; i++, j--)
            {
                Console.WriteLine("i: " + i + "\tj: " + j);
            }

            for(i = 1 ; i < 5 ; i ++){
                for(j = 1; j < 5; j++){
                    Console.Write(i*j + " ");
                }
                Console.WriteLine();
            }

            //foreach
            char[] myArray = {'H','e','l','l','o'};
 
            for(i = 0; i < myArray.Length; i++)//Sima for ciklussal
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();

            foreach(char ch in myArray)//ugyan az foreach-el
            {
                Console.WriteLine(ch);
            }
            

        }
    }
}