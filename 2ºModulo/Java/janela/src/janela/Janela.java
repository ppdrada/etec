package janela;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class Janela extends JFrame {
	private JLabel lblnome;
	private JLabel lblsobrenome;
	private JTextField txtnome;
	private JTextField txtsobrenome;
	private JButton btnsalvar;
	
	public Janela() {
		this.lblnome = new JLabel("Nome: "); // new = criando um objeto para o local de memoria
		this.lblsobrenome = new JLabel("Sobrenome: ");
		this.txtnome = new JTextField(10);
		this.txtsobrenome = new JTextField(10);
		this.btnsalvar = new JButton("Salvar");
		
		GridBagLayout layout =  new GridBagLayout();
		GridBagConstraints coordenada = new GridBagConstraints();
		
		this.setLayout(layout);
		
		coordenada .gridx = 0;
		coordenada .gridy = 0;
		layout.setConstraints(lblnome, coordenada);
		this.getContentPane().add(lblnome);

		coordenada.gridx = 0;
		coordenada.gridy = 1;
		layout.setConstraints(lblsobrenome, coordenada);
		this.getContentPane().add(lblsobrenome);
		
		coordenada.gridx = 1;
		coordenada.gridy = 0;
		layout.setConstraints(txtnome, coordenada);
		this.getContentPane().add(txtnome);
		
		coordenada.gridx = 1;
		coordenada.gridy = 1;
		layout.setConstraints(txtsobrenome, coordenada);
		this.getContentPane().add(txtsobrenome);
		
		
		coordenada.gridx = 0;
		coordenada.gridy = 2;
		coordenada.gridwidth = 2;
		coordenada.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(btnsalvar, coordenada);
		this.getContentPane().add(btnsalvar);
		
		this.setVisible(true);
	}
	}

