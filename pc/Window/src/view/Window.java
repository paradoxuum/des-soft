package view;

import java.awt.Container;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;

public class Window extends JFrame {
	
	JTextArea Mensagem = new JTextArea(15, 30);
	JScrollPane Rolagem = new JScrollPane(Mensagem);
	
	public Window() {
		super ("Window");
		
		Container paine = this.getContentPane();
		paine.setLayout(null);
		
		Rolagem.setBounds(20, 20, 360, 150);
		paine.add(Rolagem);
		
		this.setSize(400, 500);
		this.setVisible(true);
		this.setResizable(false);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		
		Window Dez = new Window();
		
	}
}