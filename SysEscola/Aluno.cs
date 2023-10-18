using System;

namespace SysEscola {

    public class Aluno : Pessoa
{
    public Aluno(string nome, int idade) : base(nome, idade)
    {
    }

    public void MatricularEmCurso(Curso curso)
    {
        curso.AlunosMatriculados.Add(this);
    }

    public void ListarInformacoesAluno()
    {
        Console.WriteLine($"— Sobre os alunos —\n{Nome} tem {Idade} anos");
    }
}
}