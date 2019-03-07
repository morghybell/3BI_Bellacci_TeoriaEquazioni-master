using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Test per metodo IsDetermined
        [TestMethod]
        public void IsDeterminedTest()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 5;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDeterminedTest1()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 0;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDeterminedTest2()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 0;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDeterminedTest3()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 6;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }



        //Test per metodo IsInconsisted
        [TestMethod]
        public void IsInconsistedTest()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 5;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsInconsisted(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsInconsistedTest1()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 0;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsInconsisted(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsInconsistedTest2()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 0;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsInconsisted(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsInconsistedTest3()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 6;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsInconsisted(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }




        //Test per metodo IsIndetermined
        [TestMethod]
        public void IsIndeterminedTest()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 5;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsIndetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsIndeterminedTest1()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 0;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsIndetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsIndeterminedTest2()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 0;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsIndetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsIndeterminedTest3()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 6;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsIndetermined(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }





        //Test per metodo IsDegree2
        [TestMethod]
        public void IsDegree2Test()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 5;
            double n3 = 6;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDegree2(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDegree2Test1()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 0;
            double n3 = 6;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDegree2(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDegree2Test2()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 6;
            double n3 = 0;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDegree2(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDegree2Test3()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            bool ris_atteso = false;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDegree2(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void IsDegree2Test4()
        {
            //valori passati al metodo da testare
            double n1 = 5;
            double n2 = 6;
            double n3 = 7;
            bool ris_atteso = true;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            bool ris_calcolato = EquazioniLibrary.Equazioni.IsDegree2(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }



        //Test per il metodo Delta
        [TestMethod]
        public void DeltaTest1()
        {
            //valori passati al metodo da testare
            double n1 = -2;
            double n2 = 2;
            double n3 = 1;
            double ris_atteso = 12;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            double ris_calcolato = EquazioniLibrary.Equazioni.Delta(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void DeltaTest2()
        {
            //valori passati al metodo da testare
            double n1 = 2;
            double n2 = 2;
            double n3 = 1;
            double ris_atteso = -4;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            double ris_calcolato = EquazioniLibrary.Equazioni.Delta(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void DeltaTest3()
        {
            //valori passati al metodo da testare
            double n1 = 4;
            double n2 = 4;
            double n3 = 1;
            double ris_atteso = 0;

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            double ris_calcolato = EquazioniLibrary.Equazioni.Delta(n1, n2, n3);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }




        //Test per il metodo EquationDegree1
        [TestMethod]
        public void EquationDegree1Test1()
        {
            //valori passati al metodo da testare
            double n1 = 2;
            double n2 = 4;
            string ris_atteso = "-2";

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            string ris_calcolato = EquazioniLibrary.Equazioni.EquationDegree1(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void EquationDegree1Test2()
        {
            //valori passati al metodo da testare
            double n1 = 4;
            double n2 = -8;
            string ris_atteso = "2";

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            string ris_calcolato = EquazioniLibrary.Equazioni.EquationDegree1(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void EquationDegree1Test3()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 5;
            string ris_atteso = "impossibile";

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            string ris_calcolato = EquazioniLibrary.Equazioni.EquationDegree1(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }

        [TestMethod]
        public void EquationDegree1Test4()
        {
            //valori passati al metodo da testare
            double n1 = 0;
            double n2 = 0;
            string ris_atteso = "indeterminata";

            //descrivo tutto il percorso che il metodo deve fare per arrivare su ris_calcolato
            string ris_calcolato = EquazioniLibrary.Equazioni.EquationDegree1(n1, n2);
            //test che afferma che se ris_atteso e ris_calcolato sono uguali allora va bene
            Assert.AreEqual(ris_atteso, ris_calcolato);
        }
    }
}
