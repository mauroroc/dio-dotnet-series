using System;

namespace DIO.Series
{
  public class Serie : EntidadeBase
  {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Ativo { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      Id = id;
      Genero = genero;
      Titulo = titulo;
      Descricao = descricao;
      Ano = ano;
      Ativo = true;
    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "Genero: " + Genero + Environment.NewLine;
        retorno += "Titulo: " + Titulo + Environment.NewLine;
        retorno += "Descrição: " + Descricao + Environment.NewLine;
        retorno += "Ano de Inicio: " + Ano + Environment.NewLine;
        retorno += "Ativo: " + Ativo;
        return retorno;
    }

    public string retornaTitulo() {
        return Titulo;
    }

    public int retornaId() {
        return Id;
    }

    public bool retornaExcluido()
    {
        return Ativo; 
    }

    public void Desativar() {
        Ativo = false;
    }
  }
}