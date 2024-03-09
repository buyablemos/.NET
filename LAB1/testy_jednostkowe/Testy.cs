using Konsolowa;
using Newtonsoft.Json.Bson;
namespace testy_jednostkowe
{
    [TestClass]
    public class Testy
    {
        [TestMethod]
        public void czy_zwrocono_jeden_gdy_spelnia_ograniczenia()
        {
            Problem plecak = new Problem(5, 1);
            Result wynik=plecak.Solve(10,true);
            Assert.IsTrue(wynik.Dodane.Count > 0, "Co najmniej jeden element powinien siê zmieœciæ w plecaku o pojemnoœci 10, gdy maksymalna mo¿liwa waga to 10");
        }
        [TestMethod]
        public void czy_zwrocono_puste_gdy_nie_spelnia_ograniczenia()
        {
            Problem plecak = new Problem(5, 1);
            List<Item> tmp = new List<Item> { new Item(5, 2, 0), new Item(5, 5, 1), new Item(8, 12, 2), new Item(7, 7, 3), new Item(6, 9, 4) };
            plecak.Items=tmp;
            Result wynik = plecak.Solve(4,true);
            Assert.IsTrue(wynik.Dodane.Count == 0, "¯aden element nie powinien byæ dodany do plecaka, gdy ograniczenie pojemnoœci to 4, a wszystkie maja wage >= 5");
        }


        [TestMethod]
        public void czy_kolejnosc_przedmiotow_wplywa_na_wynik()
        {
            List<Item> pierwsze = new List<Item> { new Item(1, 2, 0), new Item(2, 3, 0), new Item(4, 5, 0), new Item(6, 7, 0), new Item(8, 9, 0) };
            List<Item> drugie = new List<Item> { new Item(4, 5, 0), new Item(2, 3, 0), new Item(1, 2, 0), new Item(8, 9, 0) , new Item(6, 7, 0) };
            Problem problem1=new Problem(5,1);
            Problem problem2 = new Problem(5, 1);
            problem1.Items=pierwsze;
            problem2.Items=drugie;

            Result wynik1 = problem1.Solve(10, true);
            Result wynik2 = problem2.Solve(10, true);

            Assert.IsTrue((wynik1.Dodane.SequenceEqual(wynik2.Dodane)) && wynik1.Sum_value ==
               wynik2.Sum_value && wynik1.Sum_weight == wynik2.Sum_weight,
               "Kolejnosc przedmiotow przed sortowaniem nie powinna miec wplywu na wynik");


        }

        [TestMethod]
        public void czy_sortowanie_wplywa_na_wynik()
        {
            Problem plecak = new Problem(100, 1);

            Result wynik1 = plecak.Solve(100, true);
            Result wynik2 = plecak.Solve(100, false);

            Assert.IsTrue((!wynik1.Dodane.SequenceEqual(wynik2.Dodane))&&wynik1.Sum_value!=
               wynik2.Sum_value,
               "Sortowanie powinno mieæ wp³yw na rozwi¹zanie, a napewno dla duzej pojemnosci i duzej liczby przedmiotow");

        }
        [TestMethod]
        public void test_konkretnej_instancji()
        {
           // List<Item> tmp = new List<Item> { new Item(3, 6, 0), new Item(8, 3, 1), new Item(7, 10, 2), new Item(10, 7, 3), new Item(9, 9, 4) }; //tak wyglada z seedem 15
            Problem problem1 = new Problem(5, 15);
            Result wynik=problem1.Solve(10,true);

            int expexeted_sum_value = 16;
            int expexeted_sum_weight = 10;
            int expexeted_index1 = 0;
            int expexeted_index2 = 2;


            Assert.IsTrue(expexeted_sum_value == wynik.Sum_value, "Prawidlowa sekwencja powinna wygladac inaczej");
            Assert.IsTrue(expexeted_sum_weight == wynik.Sum_weight, "Prawidlowa sekwencja powinna wygladac inaczej");
            Assert.IsTrue(expexeted_index1 == wynik.Dodane[0].Iterator && expexeted_index2 == wynik.Dodane[1].Iterator
                || expexeted_index1 == wynik.Dodane[1].Iterator && expexeted_index2 == wynik.Dodane[0].Iterator
                , "Prawidlowa sekwencja powinna wygladac inaczej");


        }

        [TestMethod]
        public void czy_algorytm_dziala_dla_duzej_pojemnosci_plecaka()
        {
            Problem plecak = new Problem(100, 1);
            Result wynik = plecak.Solve(10000, true);
            Assert.IsTrue(wynik.Dodane.Count > 0, "Co najmniej jeden element powinien siê znaleŸæ");
        }
        [TestMethod]
        public void czy_algorytm_dziala_dla_duzej_liczby_przedmiotow()
        {
            
            Problem plecak = new Problem(10000, 1);
            Result wynik = plecak.Solve(10, true);
            Assert.IsTrue(wynik.Dodane.Count > 0, "Co najmniej jeden element powinien siê znaleŸæ");
        }
        [TestMethod]
        public void czy_algorytm_dziala_poprawnie_dla_ujemnej_pojemnosci_plecaka()
        {
            Problem plecak = new Problem(5, 1);
            Result wynik = plecak.Solve(-10, true); 
                                                    
            Assert.AreEqual(0, wynik.Dodane.Count, "Ujemna pojemnoœæ plecaka powinna daæ pusty wynik");
        }
        [TestMethod]
        public void czy_algorytm_dziala_poprawnie_dla_pustej_listy_przedmiotow_i_pojemnosci_zero()
        {
            Problem plecak = new Problem(0, 1);
            Result wynik = plecak.Solve(0, true); 
                                                  
            Assert.AreEqual(0, wynik.Dodane.Count, "Pusta lista przedmiotów i pojemnoœæ plecaka równa zero powinny daæ pusty wynik");
        }
        [TestMethod]
        public void czy_sortowanie_dziala()
        {
            // List<Item> tmp = new List<Item> { new Item(3, 6, 0), new Item(8, 3, 1), new Item(7, 10, 2), new Item(10, 7, 3), new Item(9, 9, 4) }; //tak wyglada z seedem 15
            List<Item> tmp = new List<Item> { new Item(3, 6, 0), new Item(7, 10, 2), new Item(9, 9, 4) ,new Item(10, 7, 3), new Item(8, 3, 1) };
            List<Item> tmp2 = new List<Item> { new Item(3, 6, 0), new Item(8, 3, 1), new Item(7, 10, 2), new Item(10, 7, 3), new Item(9, 9, 4) };
            Problem plecak = new Problem(5, 15);
            Result wynik = plecak.Solve(40, true); // wszystkie sie zmieszcza
            Result wynik2 = plecak.Solve(40, false);
            Assert.IsTrue(wynik2.Dodane.SequenceEqual(tmp2), "Bez sortowania sekwencja powinna wygladaæ inaczej");
            Assert.IsTrue(wynik.Dodane.SequenceEqual(tmp), "Obie listy powinny wygl¹daæ identycznie po sortowaniu wygenerowanej");
           
        }




    }
}