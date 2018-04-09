package view;

import java.awt.Container;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextField;

public class Calculadora extends JFrame{

	JTextField txtVisor = new JTextField();
	
	JButton btnMC = new JButton("MC");
	JButton btnMR = new JButton("MR");
	JButton btnMS = new JButton("MS");
	JButton btnMais = new JButton("M+");
	JButton btnMenos = new JButton("M-");
	
	JButton btnBackspace = new JButton("<--");
	JButton btnCE = new JButton("CE");
	JButton btnC = new JButton("C");
	JButton btnMaisMenos = new JButton("+/-");
	JButton btnRaiz = new JButton("V");
	
	JButton btnSete = new JButton("7");
	JButton btnOito = new JButton("8");
	JButton btnNove = new JButton("9");
	JButton btnDiv = new JButton("/");
	JButton btnPorc = new JButton("%");
	
	JButton btnQuatro = new JButton("4");
	JButton btnCinco = new JButton("5");
	JButton btnSeis = new JButton("6");
	JButton btnMult = new JButton("*");
	JButton btnUmBarraX = new JButton("1/x");
	
	JButton btnUm = new JButton("1");
	JButton btnDois = new JButton("2");
	JButton btnTres = new JButton("3");
	JButton btnSubt = new JButton("-");
	
	JButton btnResult = new JButton("=");
	
	JButton btnZero = new JButton("0");
	JButton btnDecimal = new JButton(",");
	JButton btnAdic = new JButton("+");
	
	public Calculadora() {
		super("Calculadora");
		
		Container paine = this.getContentPane();
		paine.setLayout(null);
		
		int btnY = 10, btnX = 170, btnl = 76, btnh = 48;
		
		txtVisor.setBounds(btnY, 60, 398, 100);
		paine.add(txtVisor);
		
		//Botões
		btnMC.setBounds(btnY, btnX, btnl, btnh);
		paine.add(btnMC);
		
		btnMR.setBounds(btnY+80, btnX, btnl, btnh);
		paine.add(btnMR);
		
		btnMS.setBounds(btnY+(80*2), btnX, btnl, btnh);
		paine.add(btnMS);
		
		btnMais.setBounds(btnY+(80*3), btnX, btnl, btnh);
		paine.add(btnMais);
		
		btnMenos.setBounds(btnY+(80*4), btnX, btnl, btnh);
		paine.add(btnMenos);
		
		this.setSize(440, 624);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setResizable(false);
	}

	public static void main(String[] args) {
		Calculadora Calc = new Calculadora();
	}

}
