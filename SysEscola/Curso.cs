using System;

namespace SysEscola {

 public class Curso
{
    public string Nome { get; }
    public List<Disciplina> Disciplinas { get; } = new List<Disciplina>();
    public List<Aluno> AlunosMatriculados { get; } = new List<Aluno>();

    public Curso(string nome)
    {
        Nome = nome;
    }

    public void AdicionarDisciplina(Disciplina disciplina)
    {
        Disciplinas.Add(disciplina);
    }



    public void ListarCursosEDisciplinas()
    {
        Console.WriteLine($"— Cursos que oferecemos são: —\n\n{Nome}:");

        foreach (var disciplina in Disciplinas)
        {
            Console.WriteLine($"\tDisciplinas:");
            Console.WriteLine($"\t\t{disciplina.Nome} - \"{disciplina.Ementa}\" e {disciplina.CargaHoraria} horas");
        }
    }

    public void ListarAlunosMatriculados()
    {
        Console.WriteLine($"\n— Alunos Matriculados —\n");

        foreach (var aluno in AlunosMatriculados)
        {
            Console.WriteLine($"Aluno {aluno.Nome} matriculado no curso {Nome}");
        }
    }

    public void ListarProfessoresEDisciplinas()
    {
        Console.WriteLine($"\n— Professores das disciplinas —");

        foreach (var disciplina in Disciplinas)
        {
            Console.WriteLine($"\tDisciplina - {disciplina.Nome} - Professor => {disciplina.Professor.Nome}");
        }
    }

    public void ListarInformacoesProfessores()
    {
        Console.WriteLine("\n— Sobre os professores —");

        foreach (var disciplina in Disciplinas)
        {
            Console.WriteLine($"{disciplina.Professor.Nome} tem {disciplina.Professor.Idade} anos");
        }
    }

    public void ListarInformacoesAlunos()
    {
        Console.WriteLine("\n— Sobre os alunos —");

        foreach (var aluno in AlunosMatriculados)
        {
            Console.WriteLine($"{aluno.Nome} tem {aluno.Idade} anos");
        }
    }
}
}