package janela2JA;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class janela extends JFrame{
	private JLabel lblNome;
	private JLabel lblSobrenome;
	
	private JTextField txtNome;
	private JTextField txtSobrenome;
	
	private JButton btnSalvar;
	
	public janela() {
		this.lblNome = new JLabel("Nome: ");
		this.lblSobrenome = new JLabel("Sobrenome: ");
		
		this.txtNome = new JTextField(10);
		this.txtSobrenome = new JTextField(10);
		
		this.btnSalvar = new JButton("Salvar");
		this.btnSalvar.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				System.out.println("olá");
				
			}
		});

		GridBagLayout layout = new GridBagLayout();
		GridBagConstraints coordenadas = new GridBagConstraints();
		
		this.setLayout(layout);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 0;
		layout.setConstraints(lblNome, coordenadas);
		this.getContentPane().add(lblNome);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 0;
		layout.setConstraints(txtNome, coordenadas);
		this.getContentPane().add(txtNome);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 1;
		layout.setConstraints(lblSobrenome, coordenadas);
		this.getContentPane().add(lblSobrenome);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 1;
		layout.setConstraints(txtSobrenome, coordenadas);
		this.getContentPane().add(txtSobrenome);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 2;
		coordenadas.gridwidth = 2;
		coordenadas.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(btnSalvar, coordenadas);
		this.getContentPane().add(btnSalvar);
		
		this.pack();
		this.setVisible(true);
		
	}
	
}
