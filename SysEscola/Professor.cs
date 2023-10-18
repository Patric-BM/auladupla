using System;

namespace SysEscola {

public class Professor : Pessoa
{
    public Professor(string nome, int idade) : base(nome, idade)
    {
    }

    public void AtribuirDisciplina(Disciplina disciplina)
    {
        disciplina.Professor = this;
    }

    public void ListarInformacoesProfessor()
    {
        Console.WriteLine($"— Sobre os professores —\n{Nome} tem {Idade} anos");
    }
}
 
}
