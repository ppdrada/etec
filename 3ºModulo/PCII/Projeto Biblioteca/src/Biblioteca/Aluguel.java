package Biblioteca;

public class Aluguel extends Livro {
	
	private String nomeLocador;
	private int diasLocado;
	private int diaLocacao;
	private int mesLocacao;
	private int anoLocacao;
	

	public Aluguel(String titulo, String isbn, String autor,String editora,String genero,String ano_puplicacao, String nomeLocador, double valor, int diasLocado,int diaLocacao,int mesLocacao,int anoLocacao, int devolucao,double atraso )
	{
		super(titulo, isbn,autor,editora,genero,ano_puplicacao);
		this.nomeLocador = nomeLocador;
		valor= valorLocacao(0);
		this.diasLocado = diasLocado;			
		this.diaLocacao = diaLocacao;
		this.mesLocacao = mesLocacao;
		this.anoLocacao = anoLocacao;
		devolucao= devolucao(0);
		atraso=valorLocacao(0);
		
	}
	
	///////////////////////////
	public String getNomeLocador() {
		return nomeLocador;
	}

	public void setNomeLocador(String nomeLocador) {
		this.nomeLocador = nomeLocador;
	}	
	public int getDiasLocado() {
		return diasLocado;
	}
	public void setDiasLocado(int diasLocado) {
		this.diasLocado = diasLocado;
	}
	public int getDiaLocacao() {
		return diaLocacao;
	}
	public void setDiaLocacao(int diaLocacao) {
		this.diaLocacao = diaLocacao;
	}
	public int getMesLocacao() {
		return mesLocacao;
	}
	public void setMesLocacao(int mesLocacao) {
		this.mesLocacao = mesLocacao;
	}
	public int getAnoLocacao() {
		return anoLocacao;
	}
	public void setAnoLocacao(int anoLocacao) {
		this.anoLocacao = anoLocacao;
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public double valorLocacao(double valor) {
		return valor;
	}
	
	public int devolucao(int devolu ) {
		
		return devolu;
	}
	
	
	public void getAluguel() {
		int devolu = devolucao(18);
		System.out.println("\n    Aluguel   ");
		
		System.out.println("\nTitulo: " + getTitulo());
		System.out.println("ISBN: " + getIsbn());
		System.out.println("Autor: " + getAutor());
		System.out.println("Gêreno: " + getGenero() );
		System.out.println("Ano de Publicação: " + getAno_puplicacao());
		System.out.println("Nome do Locador: " + getNomeLocador());
		System.out.println("Valor da Locação : R$" + valorLocacao(10));
		System.out.println("Dias Locado: " + getDiasLocado());
		System.out.println("Dia de Locação: " + getDiaLocacao());
		System.out.println("Mês de Locação: " + getMesLocacao());
		System.out.println("Ano de Locação: " + getAnoLocacao());
		System.out.println("Dia de devolução: " + devolu);
		System.out.println("Dias de atraso: " + ((devolu - getDiaLocacao()) - getDiasLocado()));
		
	}


	
	
}
