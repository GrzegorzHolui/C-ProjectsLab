package org.knapsnack;

public class Product {
    int name;
    int value;
    int weight;
    double ratio;

    public Product(int weight, int value) {
        this.weight = weight;
        this.value = value;
        this.ratio = (double) value / weight;
    }

    public Product(int name, int value, int weight) {
        this.name = name;
        this.value = value;
        this.weight = weight;
        this.ratio = (double) value / weight;
    }


    @Override
    public String toString() {
        return "No: " + this.name + " v: " + this.value + " w: " + this.weight + "\n";
    }
}
