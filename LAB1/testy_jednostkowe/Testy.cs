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
            Assert.IsTrue(wynik.getdodane().Count > 0, "Co najmniej jeden element powinien siê zmieœciæ w plecaku o pojemnoœci 10, gdy maksymalna mo¿liwa waga to 10");
        }
        [TestMethod]
        public void czy_zwrocono_puste_gdy_nie_spelnia_ograniczenia()
        {
            Problem plecak = new Problem(5, 1);
            Result wynik = plecak.Solve(0,true);
            Assert.IsTrue(wynik.getdodane().Count == 0, "¯aden element nie powinien byæ dodany do plecaka, gdy ograniczenie pojemnoœci to 0");
        }


        [TestMethod]
        public void czy_kolejnosc_przedmiotow_wplywa_na_wynik()
        {
            List<Item> pierwsze = new List<Item> { new Item(1, 2, 0), new Item(2, 3, 0), new Item(4, 5, 0), new Item(6, 7, 0), new Item(8, 9, 0) };
            List<Item> drugie = new List<Item> { new Item(4, 5, 0), new Item(2, 3, 0), new Item(1, 2, 0), new Item(8, 9, 0) , new Item(6, 7, 0) };
            Problem problem1=new Problem(5,1);
            Problem problem2 = new Problem(5, 1);
            problem1.setitems(pierwsze);
            problem2.setitems(drugie);

            Result wynik1 = problem1.Solve(10, true);
            Result wynik2 = problem2.Solve(10, true);

            Assert.IsFalse((wynik1.getdodane().SequenceEqual(wynik2.getdodane())) && wynik1.getsum_value() ==
               wynik2.getsum_value() && wynik1.getsum_weight() == wynik2.getsum_weight(),
               "Kolejnosc przedmiotow przed sortowaniem nie powinna miec wplywu na wynik");


        }

        [TestMethod]
        public void czy_sortowanie_wplywa_na_wynik()
        {
            Problem plecak = new Problem(100, 1);

            Result wynik1 = plecak.Solve(100, true);
            Result wynik2 = plecak.Solve(100, false);

            Assert.IsFalse((wynik1.getdodane().SequenceEqual(wynik2.getdodane()))&&wynik1.getsum_value()==
               wynik2.getsum_value()&& wynik1.getsum_weight() == wynik2.getsum_weight(),
               "Sortowanie powinno mieæ wp³yw na rozwi¹zanie dla duzej pojemnosci i duzej liczby przedmiotow");

        }
        [TestMethod]
        public void test_konkretnej_instancji()
        {
            List<Item> tmp = new List<Item> { new Item(1, 2, 0), new Item(1, 5, 1), new Item(2, 12, 2), new Item(1, 7, 3), new Item(2, 9, 4) };
            Problem problem1 = new Problem(5, 1);
            problem1.setitems(tmp);
            Result wynik=problem1.Solve(2,true);

            int expexeted_sum_value = 12;
            int expexeted_sum_weight = 2;
            int expexeted_index1 = 1;
            int expexeted_index2 = 3;


            Assert.IsTrue(expexeted_sum_value == wynik.getsum_value(), "Prawidlowa sekwencja powinna wygladac inaczej");
            Assert.IsTrue(expexeted_sum_weight == wynik.getsum_weight(), "Prawidlowa sekwencja powinna wygladac inaczej");
            Assert.IsTrue(expexeted_index1 == wynik.getdodane()[0].getiterator() && expexeted_index2 == wynik.getdodane()[1].getiterator()
                || expexeted_index1 == wynik.getdodane()[1].getiterator() && expexeted_index2 == wynik.getdodane()[0].getiterator()
                , "Prawidlowa sekwencja powinna wygladac inaczej");


        }

        [TestMethod]
        public void czy_algorytm_dziala_dla_duzej_pojemnosci_plecaka_i_liczby_przedmiotow()
        {
            Problem plecak = new Problem(10000, 1);
            Result wynik = plecak.Solve(10000, true);
            Assert.IsTrue(wynik.getdodane().Count > 0, "Co najmniej jeden element powinien siê znaleŸæ");
        }
        [TestMethod]
        public void czy_algorytm_dziala_dla_duzej_liczby_przedmiotow()
        {
            
            Problem plecak = new Problem(10000, 1);
            Result wynik = plecak.Solve(100, true);
            Assert.IsTrue(wynik.getdodane().Count > 0, "Co najmniej jeden element powinien siê znaleŸæ");
        }
        [TestMethod]
        public void czy_algorytm_dziala_poprawnie_dla_ujemnej_pojemnosci_plecaka()
        {
            Problem plecak = new Problem(5, 1);
            Result wynik = plecak.Solve(-10, true); 
                                                    
            Assert.AreEqual(0, wynik.getdodane().Count, "Ujemna pojemnoœæ plecaka powinna daæ pusty wynik");
        }
        [TestMethod]
        public void czy_algorytm_dziala_poprawnie_dla_pustej_listy_przedmiotow_i_pojemnosci_zero()
        {
            Problem plecak = new Problem(0, 1);
            Result wynik = plecak.Solve(0, true); 
                                                  
            Assert.AreEqual(0, wynik.getdodane().Count, "Pusta lista przedmiotów i pojemnoœæ plecaka równa zero powinny daæ pusty wynik");
        }




    }
}