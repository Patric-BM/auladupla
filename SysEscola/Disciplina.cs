using System;

namespace SysEscola {

 public class Disciplina
{
    public string Nome { get; }
    public string Ementa { get; }
    public int CargaHoraria { get; }
    public Professor Professor { get; set; }

    public Disciplina(string nome, string ementa, int cargaHoraria)
    {
        Nome = nome;
        Ementa = ementa;
        CargaHoraria = cargaHoraria;
    }
}
}