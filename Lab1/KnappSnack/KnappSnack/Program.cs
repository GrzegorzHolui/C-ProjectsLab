using KnappSnack;
using System.Collections;

List<Item> items = new List<Item>();

Item gitara = new Item(1500, 1, 1);
Item laptop = new Item(2000, 3, 2);
Item stereo = new Item(3000, 4, 3);
Item mikrofon = new Item(30000, 1, 4);

items.Add(gitara);
items.Add(laptop);
items.Add(stereo);
items.Add(mikrofon);


int amountOfProducts = items.Count;
int seed = 10;


Problem problem = new Problem(10, 1);

Result result = problem.solveKnappSnackProblem(20);

Console.WriteLine(result);
