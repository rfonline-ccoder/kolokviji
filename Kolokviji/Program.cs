namespace Kolokviji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KOLOKVIJ 1

            //int starost; // int ker imam stevilko
            //double povprecje; // double ker imam decimalno stevilko
            //char ocena; // char ker imam en znak
            //string ime;  // string ker imam besedilo

            //Console.WriteLine("Vnesi svoje ime:");
            //ime = Console.ReadLine(); //dajmo prebrat vnos kot besedilo

            //Console.WriteLine("Vnesi svojo starost:");
            //starost = Convert.ToInt32(Console.ReadLine());  //dajmo prebrat vnos kot stevilo

            //Console.WriteLine("Vnesi svoje povprecje:");
            //povprecje = Convert.ToDouble(Console.ReadLine()); //dajmo prebrat vnos kot decimalno stevilo

            //Console.WriteLine("Vnesi svojo oceno (A, B, C, D, F):");
            //ocena = Convert.ToChar(Console.ReadLine()); //dajmo prebrat vnos kot en znak

            //Console.WriteLine("\nTvoji podatki so:");
            //Console.WriteLine("Ime: " + ime);
            //Console.WriteLine("Starost: " + starost);
            //Console.WriteLine("Povprecje: " + povprecje);
            //Console.WriteLine("Ocena: " + ocena);






            //KOLOKVIJ 2
            //bool jeStudent = true; //lahko tudi false

            //string status = jeStudent ? "Ste student." : "Niste student."; // tudi lahko dam jeStudent.ToString(); da pokaze true ali false, 
            //Console.WriteLine("Kot string - " + status); // pokazemo kot string kaj smo dali v status
            //Console.WriteLine("Kot boolean - " + jeStudent); //pokazemo kot boolean vrednost a je student ali ne, ampak zdaj imamo vedno true ali false(odvisno kaj damo v jeStudent), tudi lahko damo ReadLine da vpisemo sami vrednost

            //string opis = jeStudent ? "Ste vpisani v visokošolski program." : "Niste vpisani v visokošolski program."; // najbolj da dam text namest samo true ali false da bi bilo kej boljse
            //Console.WriteLine(opis); //pokazemo opis


            //KOLOKVIJ 3

            //Console.WriteLine("Vnesi stevilo svojih tock (0-100): ");

            //string vnos = Console.ReadLine();
            //int tocke = int.Parse(vnos); //parse za stevilke katere smo dali v readline

            //int ocena = 0; //zacnemo od 0

            //if (tocke >= 90 && tocke <= 100) // ce imas vec kot 90 in manj kot 100 dobis oceno 10, pol ne bom napisal za vsak line ker ista logika, ampak druge stevilke
            //{
            //    ocena = 10;
            //}
            //else if (tocke >= 80 && tocke < 90)
            //{
            //    ocena = 9;
            //}
            //else if (tocke >= 70 && tocke < 80)
            //{
            //    ocena = 8;
            //}
            //else if (tocke >= 60 && tocke < 70)
            //{
            //    ocena = 7;
            //}
            //else if (tocke >= 50 && tocke < 60)
            //{
            //    ocena = 6;
            //}
            //else if (tocke >= 0 && tocke < 50)
            //{
            //    ocena = 5;
            //}
            //else
            //{
            //    Console.WriteLine("Neveljaven vnos. Vnesite stevilo med 0 in 100."); //ce vneses stevilo manjse od 0 ali vecje od 100
            //    return; //izhod iz programa
            //}
            //Console.WriteLine("Vasa ocena je: " + ocena);
            //switch (ocena) // switch case za ocene da pokaze komentar glede na oceno
            //{
            //    case 5:
            //        Console.WriteLine("Ocena 5: Slabo, probaj boljse");
            //        break;
            //    case 6:
            //        Console.WriteLine("Ocena 6: Dost za enkrat");
            //        break;
            //    case 7:
            //        Console.WriteLine("Ocena 7: Vredu");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ocena 8: Zelo dobro");
            //        break;
            //    case 9:
            //        Console.WriteLine("Ocena 9: Super");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ocena 10: MAGIC");
            //        break;
            //}

            //if (tocke < 0 || tocke > 100)
            //{
            //    Console.WriteLine("Neveljaven vnos. Vnesite stevilo med 0 in 100."); //se enkrat za neveljaven vnos(ampak program je dela vredu, 2 krat gleda na stevilo)
            //}
            //else
            //{
            //    Console.WriteLine("Student je dobil " + ocena + " pri " + tocke + "tockah"); //pokaze oceno in tocke + komentar
            //}


            //KOLOKVIJ 4


            //Console.WriteLine("===REGISTRACIJA KOLOKVIJ 3. SKUPINA BY STEPAN MALCHENKOV===");

            //Console.Write("Vnesi svoj uporabnisko ime: ");
            //string uporabniskoIme = Console.ReadLine(); //preberemo uporabnisko ime 

            //Console.Write("Vnesi svoje geslo: ");
            //string geslo = Console.ReadLine(); //preberemo geslo

            //Console.Write("Potrdi svoje geslo: ");
            //string potrdiGeslo = Console.ReadLine(); //preberemo potrjeno geslo

            //Console.Write("Registracija uspesna \n");

            //Console.WriteLine("Prijava na sistem kolokvij 3. skupina by stepan malchenkov"); //prijava with username and password

            //Console.Write("Vnesi svoje uporabnisko ime: ");
            //string vnesenoUporabniskoIme = Console.ReadLine(); //preberemo vneseno uporabnisko ime

            //Console.Write("Vnesi svoje geslo: ");
            //string vnesenoGeslo = Console.ReadLine(); //preberemo vneseno geslo

            //if (vnesenoUporabniskoIme == uporabniskoIme && vnesenoGeslo == geslo) //preverimo ce so pravilni podatki
            //{
            //    Console.WriteLine("Prijava uspesna! Dobrodosli, " + uporabniskoIme); //ce so pravilni podatki, prijava uspesna
            //}
            //else
            //{
            //    Console.WriteLine("Napacno uporabnisko ime ali geslo. Probaj se enkrat."); //ce so podatki napacni takrat gremo na registracijo
            //}


            //KOLOKVIJ 5
            //Console.WriteLine("Vnesi ime frienda: ");
            //string friendName = Console.ReadLine(); //preberemo ime frienda

            //if (friendName.Length < 6) // pogledamo dolzino imena
            //{
            //    Console.WriteLine("Ime frienda: " + friendName); // ce je ime manj kot 6 crk - pisemo ime v konzolo
            //}
            //else
            //{
            //     Console.WriteLine("Bomo naredili ponovno program da lahko spemlja vec crk!!!"); // ce je ime vec kot 6 crk
            //}
        }
    }
}
