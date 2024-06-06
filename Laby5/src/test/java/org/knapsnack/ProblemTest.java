package org.knapsnack;


import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

class ProblemTest {


    @Test
    public void shouldReturnTrueIfOneProductPerformConstraints() {
        // given
        List<Product> products = new ArrayList<>();
        products.add(new Product(1, 8, 5));
        products.add(new Product(2, 5, 16));
        products.add(new Product(0, 6, 14));
        Problem problem = new Problem(products);

        // when
        Result solve = problem.solve(15);

        // then
        Assertions.assertTrue(solve.amount >= 1);
    }

    @Test
    public void shouldReturnFalseIfAllProductsNotPerformConstraints() {
        // given
        List<Product> products = new ArrayList<>();
        products.add(new Product(1, 8, 20));
        products.add(new Product(2, 5, 16));
        products.add(new Product(0, 6, 17));
        Problem problem = new Problem(products);

        // when
        Result solve = problem.solve(15);

        // then
        Assertions.assertEquals(0, solve.amount);
    }


    @Test
    public void shouldCheckThatAllProductsInSolutionAreInRangeFrom1To10() {
        // given
        Problem problem = new Problem(5, 2, 10, 1);

        // when
        Result solve = problem.solve(15);

        // then
        for (Product product : solve.resultProblemList) {
            Assertions.assertTrue(product.weight >= 1 && product.weight <= 10);
            Assertions.assertTrue(product.value >= 1 && product.value <= 10);
        }
    }


    @Test
    public void shouldReturnThatWeightIs15AndValueIs33() {
        // given
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

        // when
        Result solve = problem.solve(15);

        // then
        Assertions.assertEquals(15, solve.sumWeight);
        Assertions.assertEquals(33, solve.sumValue);
    }


}