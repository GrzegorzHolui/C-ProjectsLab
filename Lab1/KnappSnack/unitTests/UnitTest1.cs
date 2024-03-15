using KnappSnack;
using System.Runtime.CompilerServices;

namespace unitTests
{

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        // Sprawdzenie, czy jeœli co najmniej jeden przedmiot spe³nia ograniczenia, to zwrócono co najmniej jeden element.
        public void checkIfAtLeastOneItemMeetsConstraintsThenSolutionContainsAtLeastOneItem()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);  // Meets the constraints
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            // when 
            Result solution = problem.solveKnappSnackProblem(5);

            // then
            Assert.IsTrue(solution.result.Count > 0);
        }
        [TestMethod]
        // Sprawdzenie, czy jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie.
        public void checkIfNoneProductAchieveConstraintsThenReturnEmptySolution()
        {
            // given
            List<Item> items = new List<Item>();
            Item gitara = new Item(1500, 1, 1);
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(gitara);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            Result expectedResult = new Result(0, 0, new List<Item>());

            // when 
            Result solution = problem.solveKnappSnackProblem(0);

            // then
            Assert.IsTrue(expectedResult.Equals(solution));
        }


        // Sprawdzenie, czy kolejnoœæ przedmiotów ma wp³ywa na znalezione rozwi¹zanie.
        [TestMethod]
        public void CheckIfItemOrderAffectsSolution()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);
            Item mikrofon = new Item(3000, 1, 4);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);
            items.Add(mikrofon);

            List<Item> reverseItems = new List<Item>();
            items.Add(stereo);
            items.Add(laptop);
            items.Add(guitar);
            items.Add(mikrofon);

            Problem problemOriginalOrder = new Problem(3, 10, items);
            Problem problemDifferentOrder = new Problem(3, 10, reverseItems);

            // when
            Result solutionOriginalOrder = problemOriginalOrder.solveKnappSnackProblem(2);
            Result solutionDifferentOrder = problemDifferentOrder.solveKnappSnackProblem(2);

            // then
            Assert.IsFalse(solutionOriginalOrder.Equals(solutionDifferentOrder));
        }


        [TestMethod]
        // Sprawdzenie poprawnoœci wyniku dla konkretnej instancji.
        public void checkIfSolutionIsCorrect()
        {
            // given
            List<Item> items = new List<Item>();
            Item gitara = new Item(1500, 1, 1);
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);
            Item mikrofon = new Item(30000, 1, 4);

            items.Add(gitara);
            items.Add(laptop);
            items.Add(stereo);
            items.Add(mikrofon);

            Problem problem = new Problem(3, 10, items);

            List<Item> expectedResultList = new List<Item> { mikrofon, gitara };
            Result expectedResult = new Result(2, 31500, expectedResultList);

            // when 
            Result solution = problem.solveKnappSnackProblem(2);

            // then
            Assert.IsTrue(expectedResult.Equals(solution));
        }



        [TestMethod]
        public void checkIfTotalWeightIsNotUnderZero()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);  // Meets the constraints
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            // when 
            Result solution = problem.solveKnappSnackProblem(5);

            // then
            Assert.IsFalse(solution.totalWeight < 0);
        }

        [TestMethod]
        public void checkIfTotalValueIsNotUnderZero()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);  // Meets the constraints
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            // when 
            Result solution = problem.solveKnappSnackProblem(5);

            // then
            Assert.IsFalse(solution.totalValue < 0);
        }

        [TestMethod]
        public void checkIfReturnedClassIsInstanceOfResult()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);  // Meets the constraints
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            // when 
            Result solution = problem.solveKnappSnackProblem(5);

            // then
            Assert.IsTrue(solution is Result);
        }


        [TestMethod]
        public void checkIfNumberOfReturnedItemsAreExactlyTwo()
        {
            // given
            List<Item> items = new List<Item>();
            Item guitar = new Item(1500, 1, 1);  // Meets the constraints
            Item laptop = new Item(2000, 3, 2);
            Item stereo = new Item(3000, 4, 3);

            items.Add(guitar);
            items.Add(laptop);
            items.Add(stereo);

            Problem problem = new Problem(3, 10, items);

            // when 
            Result solution = problem.solveKnappSnackProblem(5);

            // then
            Assert.IsTrue(solution.result.Count == 2);
        }


    }


}