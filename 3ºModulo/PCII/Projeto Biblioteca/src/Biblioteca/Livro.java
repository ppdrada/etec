package Biblioteca;




public class Livro {
	private String titulo;
	private String isbn;
	private String autor;
	private String editora;
	private String genero;
	private String ano_puplicacao;
	

	
	public Livro(String titulo, String isbn, String autor,String editora,String genero,String ano_puplicacao)
	{
		this.setTitulo(titulo);
		this.setIsbn(isbn);
		this.setAutor(autor);
		this.setEditora(editora);
		this.setGenero(genero);
		this.setAno_puplicacao(ano_puplicacao);

	}
	////////////////////////
	public String getTitulo() {
		return titulo;
	}
	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}
	public String getIsbn() {
		return isbn;
	}
	public void setIsbn(String isbn) {
		this.isbn = isbn;
	}
	public String getAutor() {
		return autor;
	}
	public void setAutor(String autor) {
		this.autor = autor;
	}
	public String getEditora() {
		return editora;
	}
	public void setEditora(String editora) {
		this.editora = editora;
	}
	public String getGenero() {
		return genero;
	}
	public void setGenero(String genero) {
		this.genero = genero;
	}
	public String getAno_puplicacao() {
		return ano_puplicacao;
	}
	public void setAno_puplicacao(String ano_puplicacao) {
		this.ano_puplicacao = ano_puplicacao;
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////~
	

	public void imprimeDados() {
		
		
	}
	
	public void tempoPublicacao() {
		
		this.setAno_puplicacao(ano_puplicacao);
	}
	public void getLivro() {
		 
		System.out.println("\nTitulo: " + getTitulo());
		System.out.println("ISBN: " + getIsbn());
		System.out.println("Autor: " + getAutor());
		System.out.println("Gêreno: " + getGenero() );
		System.out.println("Ano de Publicação: " + getAno_puplicacao());
		
		
	 }

	
	

}
