import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class Janela extends JFrame {
	
	private JLabel lblIdade;
	private JLabel lblAltura;
	
	private JTextField txtIdade;
	private JTextField txtAltura;
	
	private JButton btnEnviar;
	
	public Janela() {
		this.lblIdade = new JLabel("Idade: ");
		this.lblAltura = new JLabel("Altura: ");
		
		this.txtIdade = new JTextField(10);
		this.txtAltura = new JTextField(10);
		
		this.btnEnviar = new JButton("Enviar");
		this.btnEnviar.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent btn) {
				// TODO Auto-generated method stub
				
				System.out.println("Idade: " + txtIdade.getText());
				System.out.println("Altura: " + txtAltura.getText());
			}
		});
		
		GridBagLayout layout = new GridBagLayout();
		GridBagConstraints coordenadas = new GridBagConstraints();
		
		this.setLayout(layout);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 0;
		coordenadas.insets = new Insets(2, 2, 2, 2);
		layout.setConstraints(lblIdade, coordenadas);
		this.getContentPane().add(lblIdade);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 0;
		layout.setConstraints(txtIdade, coordenadas);
		this.getContentPane().add(txtIdade);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 1;
		layout.setConstraints(lblAltura, coordenadas);
		this.getContentPane().add(lblAltura);
		
		coordenadas.gridx = 1;
		coordenadas.gridy = 1;
		layout.setConstraints(txtAltura, coordenadas);
		this.getContentPane().add(txtAltura);
		
		coordenadas.gridx = 0;
		coordenadas.gridy = 2;
		coordenadas.gridwidth = 2;
		coordenadas.fill = GridBagConstraints.HORIZONTAL;
		layout.setConstraints(btnEnviar, coordenadas);
		this.getContentPane().add(btnEnviar);
		
		this.pack();
		this.setVisible(true);
	}	

}
