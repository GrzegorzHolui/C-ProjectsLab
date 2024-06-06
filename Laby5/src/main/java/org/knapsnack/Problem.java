package org.knapsnack;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Problem {
    int amountOfProducts;
    int seed;
    int upperBound;
    int lowBoard;
    Random random;
    List<Product> productList;

    public Problem(int amountOfProducts, int seed, int upperBound, int lowBoard) {
        this.amountOfProducts = amountOfProducts;
        this.seed = seed;
        this.upperBound = upperBound;
        this.lowBoard = lowBoard;
        this.random = new Random(seed);
        this.productList = generateItems();
    }

    public Problem(List<Product> productList) {
        this.productList = productList;
    }

    private List<Product> generateItems() {
        List<Product> result = new ArrayList<>();

        for (int i = 0; i < amountOfProducts; i++) {
            int weight = random.nextInt(this.upperBound - this.lowBoard + 1) + this.lowBoard;
            int value = random.nextInt(this.upperBound - this.lowBoard + 1) + this.lowBoard;
            Product product = new Product(i, weight, value);
            result.add(product);
        }

        return result;
    }

    public Result solve(int capacity) {
        List<Product> productListToSolve = new ArrayList<>(productList);
        productListToSolve.sort((e1, e2) -> Double.compare(e2.ratio, e1.ratio));
        List<Product> resultList = new ArrayList<>();
        while (capacity > 0 && !productListToSolve.isEmpty()) {
            Product product = productListToSolve.get(0);
            if ((capacity - product.weight) >= 0) {
                resultList.add(product);
                capacity -= product.weight;
            } else {
                productListToSolve.remove(0);
            }
        }
        if (resultList.isEmpty()) {
            return new Result(new ArrayList<>());
        } else {
            return new Result(resultList);
        }
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();

        for (Product product : productList) {
            result.append(product);
        }

        return result.toString();

    }

    public static void main(String[] args) {
        List<Product> products = new ArrayList<>();
        products.add(new Product(0, 6, 9));
        products.add(new Product(1, 8, 4));
        products.add(new Product(2, 5, 5));
        products.add(new Product(3, 5, 7));
        products.add(new Product(4, 9, 9));
        products.add(new Product(5, 10, 4));
        products.add(new Product(6, 8, 4));
        products.add(new Product(7, 3, 5));
        products.add(new Product(8, 3, 3));
        products.add(new Product(9, 7, 10));

        Problem problem = new Problem(products);
        Result solve = problem.solve(15);

        System.out.println(solve);


    }
}
