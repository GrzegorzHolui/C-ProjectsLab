package org.knapsnack;

import javax.swing.*;

public class Main {

    public static void main(String[] args) {

        JFrame frame = new JFrame("KnapSack GUI");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setContentPane(new KnapSackGUI().getMainPanel());
        frame.setSize(800, 600);
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }
}

