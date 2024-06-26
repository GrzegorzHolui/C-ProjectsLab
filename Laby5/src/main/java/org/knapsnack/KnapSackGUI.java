package org.knapsnack;

import javax.swing.*;
import javax.swing.border.TitledBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class KnapSackGUI {
    private JTextField textField1;
    private JTextField textField2;
    private JTextField textField3;
    private JTextArea textArea1;
    private JTextArea textArea2;
    private JButton button1;
    private JPanel mainPanel;

    public KnapSackGUI() {
        mainPanel = new JPanel();
        mainPanel.setLayout(new BorderLayout());

        JPanel inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(4, 2));
        inputPanel.setBorder(new TitledBorder("Input"));

        inputPanel.add(new JLabel("Number"));
        inputPanel.add(textField1);
        inputPanel.add(new JLabel("Seed"));
        inputPanel.add(textField2);
        inputPanel.add(new JLabel("Capacity"));
        inputPanel.add(textField3);
        inputPanel.add(button1);

        textArea1.setBorder(new TitledBorder("Wynik problemu plecakowego"));

        textArea2 = new JTextArea();
        textArea2.setBorder(new TitledBorder("Dane początkowe"));

        JSplitPane rightSplitPane = new JSplitPane(JSplitPane.VERTICAL_SPLIT, new JScrollPane(textArea1), new JScrollPane(textArea2));
        rightSplitPane.setResizeWeight(0.5);

        JSplitPane mainSplitPane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT, inputPanel, rightSplitPane);
        mainSplitPane.setResizeWeight(0.3);

        mainPanel.add(mainSplitPane, BorderLayout.CENTER);

        button1.addActionListener(e -> {
            textArea1.setText("");
            textArea2.setText("");
            int amountOfProducts = Integer.parseInt(textField1.getText());
            int seed = Integer.parseInt(textField2.getText());
            int capacity = Integer.parseInt(textField3.getText());
            Problem problem = new Problem(amountOfProducts, seed, 10, 1);
            Result solve = problem.solve(capacity);
            textArea1.append(solve.toString());
            textArea2.append(problem.toString());

        });
    }


    public JPanel getMainPanel() {
        return mainPanel;
    }

    {
// GUI initializer generated by IntelliJ IDEA GUI Designer
// >>> IMPORTANT!! <<<
// DO NOT EDIT OR ADD ANY CODE HERE!
        $$$setupUI$$$();
    }

    /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
    private void $$$setupUI$$$() {
        final JPanel panel1 = new JPanel();
        panel1.setLayout(new GridBagLayout());
        textField2 = new JTextField();
        GridBagConstraints gbc;
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 3;
        gbc.anchor = GridBagConstraints.WEST;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(textField2, gbc);
        textField1 = new JTextField();
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.weightx = 7.0;
        gbc.anchor = GridBagConstraints.WEST;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(textField1, gbc);
        final JLabel label1 = new JLabel();
        label1.setText("Number");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.anchor = GridBagConstraints.WEST;
        panel1.add(label1, gbc);
        final JLabel label2 = new JLabel();
        label2.setText("Seed");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 2;
        gbc.anchor = GridBagConstraints.WEST;
        panel1.add(label2, gbc);
        textField3 = new JTextField();
        textField3.setText("");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 5;
        gbc.anchor = GridBagConstraints.WEST;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(textField3, gbc);
        final JLabel label3 = new JLabel();
        label3.setText("Capacity");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 4;
        gbc.anchor = GridBagConstraints.WEST;
        panel1.add(label3, gbc);
        button1 = new JButton();
        button1.setText("Button");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 6;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(button1, gbc);
        final JScrollPane scrollPane1 = new JScrollPane();
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 7;
        gbc.weighty = 0.5;
        gbc.fill = GridBagConstraints.BOTH;
        panel1.add(scrollPane1, gbc);
        textArea1 = new JTextArea();
        textArea1.setEditable(false);
        textArea1.setText("");
        scrollPane1.setViewportView(textArea1);
    }
}
