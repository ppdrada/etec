package calculadora;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class calc extends JFrame{
	private JLabel lblNum1;
	private JLabel lblNum2;
	private JLabel lblresu;
	
	private JTextField txtNum1;
	private JTextField txtNum2;
	private JTextField txtresu;
	
	private JButton mais;
	private JButton menos;
	private JButton vezes;
	private JButton divisao;
	private JLabel aviso;
	
	public calc() {
		this.lblNum1 = new JLabel("Num1 ");
		this.lblNum2 = new JLabel("Num2 ");
		this.lblresu = new JLabel("Resu ");
		
		this.txtNum1 = new JTextField(5);
		this.txtNum2 = new JTextField(5);
		this.txtresu = new JTextField(5);
		
		this.aviso = new JLabel();
		
		this.mais = new JButton("+");
		this.mais.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				double num1, num2, resu;
				num1 = Double.parseDouble(txtNum1.getText());
				num2 = Double.parseDouble(txtNum2.getText());
				resu = num1+num2;
				txtresu.setText(String.valueOf(resu));
			}
		});
		
		this.menos = new JButton("-");
		this.menos.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				double num1, num2, resu;
				num1 = Double.parseDouble(txtNum1.getText());
				num2 = Double.parseDouble(txtNum2.getText());
				resu = num1-num2;
				txtresu.setText(String.valueOf(resu));
			}
		});
		
		this.vezes = new JButton("X");
		this.vezes.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				double num1, num2, resu;
				num1 = Double.parseDouble(txtNum1.getText());
				num2 = Double.parseDouble(txtNum2.getText());
				resu = num1*num2;
				txtresu.setText(String.valueOf(resu));
			}
		});
		
		this.divisao = new JButton("/");
		this.divisao.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				double num1, num2, resu;
				num1 = Double.parseDouble(txtNum1.getText());
				num2 = Double.parseDouble(txtNum2.getText());
				resu = num1/num2;
				txtresu.setText(String.valueOf(resu));
			}
		});
		
		GridBagLayout layout = new GridBagLayout();
		GridBagConstraints coordenadas = new GridBagConstraints();
		
this.setLayout(layout);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 0;
		
		layout.setConstraints(lblNum1, coordenadas);
		this.getContentPane().add(lblNum1);
		
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 1;
		layout.setConstraints(lblNum2, coordenadas);
		this.getContentPane().add(lblNum2);
		
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 3;
		layout.setConstraints(mais, coordenadas);
		this.getContentPane().add(mais);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 3;
		layout.setConstraints(menos, coordenadas);
		this.getContentPane().add(menos);
		
		coordenadas.gridx = 2;
		coordenadas.gridy = 3;
		layout.setConstraints(vezes, coordenadas);
		this.getContentPane().add(vezes);
		
		coordenadas.gridx = 3;
		coordenadas.gridy = 3;
		layout.setConstraints(divisao, coordenadas);
		this.getContentPane().add(divisao);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 4;
		layout.setConstraints(lblresu, coordenadas);
		this.getContentPane().add(lblresu);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 4;
		coordenadas.gridwidth = 2;
		coordenadas.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(txtresu, coordenadas);
		this.getContentPane().add(txtresu);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 0;
		coordenadas.gridwidth = 2;
		coordenadas.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(txtNum1, coordenadas);
		this.getContentPane().add(txtNum1);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 1;
		coordenadas.gridwidth = 2;
		coordenadas.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(txtNum2, coordenadas);
		this.getContentPane().add(txtNum2);
		
		this.pack();
		this.setVisible(true);
		
	}
}
