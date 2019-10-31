package Biblioteca;

public class Venda extends Livro {
	private String datavenda;
	private String nomeProprietario;
	private double valorVenda;
	
	public Venda(String titulo, String isbn, String autor,String editora,String genero,String ano_puplicacao, String datavenda, String nomeProprietario, double valorVenda, double capa, double direito, double logistica, double imposto, double lucro)
	{
		super(titulo, isbn,autor,editora,genero,ano_puplicacao);
		this.datavenda = datavenda;
		this.nomeProprietario =nomeProprietario;
		this.valorVenda = valorVenda;
		capa= calcularValor(1);
		direito = calcularValor(2);
		logistica= calcularValor(3);
		imposto= calcularValor(4);
		lucro= calcularValor(0);
	}
	//////////////////////////////////////////////////////////////////////////////////////////
	public String getDatavenda() {
		return datavenda;
	}
	public void setDatavenda(String datavenda) {
		this.datavenda = datavenda;
	}
	public String getNomeProprietario() {
		return nomeProprietario;
	}
	public void setNomeProprietario(String nomeProprietario) {
		this.nomeProprietario = nomeProprietario;
	}
	public double getValorVenda() {
		return valorVenda;
	}
	public void setValorVenda(double valorVenda) {
		this.valorVenda = valorVenda;
	}
	/////////////////////////////////////////////////////////////////////////////
	
	public double calcularValor(double elemento) {
		double capa = getValorVenda() -(15.0 * 100.0);
		if(elemento == 1) return capa;
		double direitos = getValorVenda() -(35.0 *100.0);
		if(elemento == 2) return direitos;
		double logistica = getValorVenda() -(10.0 *100.0);
		if(elemento == 3) return logistica;
		double impostos = getValorVenda() -(8.0 *100.0);
		if(elemento == 4) return impostos;
		return getValorVenda()-(32.0 *100.0);
		
	}
	
	public void getvenda() {
		System.out.println("       Venda   ");
		System.out.println("\nTitulo: " + getTitulo());
		System.out.println("ISBN: " + getIsbn());
		System.out.println("Autor: " + getAutor());
		System.out.println("Gêreno: " + getGenero() );
		System.out.println("Ano de Publicação: " + getAno_puplicacao());
		System.out.println("Data de venda: " + getDatavenda());
		System.out.println("Nome do proprietario: " + getNomeProprietario());
		System.out.println("Valor da venda: " + getValorVenda());
		System.out.println("Valor da Capa: " + calcularValor(1));
		System.out.println("Valor do Direitos autorais: " + calcularValor(2));
		System.out.println("Valor de logistica: " + calcularValor(3));
		System.out.println("Valor do imposto: " + calcularValor(4));
		System.out.println("lucro: " + calcularValor(0));
		
		
	}
	
	
}
