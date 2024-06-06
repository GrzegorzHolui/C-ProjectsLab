package org.knapsnack;

import java.util.List;
import java.util.stream.Collectors;

public class Result {

    List<Product> resultProblemList;

    int sumWeight;
    int amount;
    int sumValue;

    public Result(List<Product> resultProblemList) {
        this.resultProblemList = resultProblemList;
        this.sumValue = resultProblemList.stream().map(product -> product.value).reduce(Integer::sum).orElse(0);
        this.sumWeight = resultProblemList.stream().map(product -> product.weight).reduce(Integer::sum).orElse(0);
        this.amount = resultProblemList.size();
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();

        for (Product product : resultProblemList) {
            result.append(product);
        }

        return result.toString();

    }
}
