using System;
using System.Collections.Generic;

namespace SysEscola {
    
class Program
{
    static void Main()
    {
        Curso engenharia = new Curso("Engenharia da Computação");
        Curso biomedicina = new Curso("Biomedicina");

        Disciplina matematica = new Disciplina("Matemática", "Estudos matemáticos", 60);
        Disciplina calculoI = new Disciplina("Cálculo I", "Coisa de doido", 70);
        Disciplina fisica = new Disciplina("Física", "Estudo de física", 40);
        Disciplina programacao = new Disciplina("Programação", "Estudo de programação", 80);

        Disciplina anatomia = new Disciplina("Anatomia", "estudo da anatomia humana", 40);
        Disciplina analisesClinicas = new Disciplina("Análises Clínicas", "estudos de células, tecidos e outros agentes nível molecular", 60);
        Disciplina fisiologia = new Disciplina("Fisiologia", "estudos fisiológicos", 80);
        Disciplina toxicologia = new Disciplina("Toxicologia", "estudo de substâncias tóxicas", 70);

        engenharia.AdicionarDisciplina(matematica);
        engenharia.AdicionarDisciplina(calculoI);
        engenharia.AdicionarDisciplina(fisica);
        engenharia.AdicionarDisciplina(programacao);

        biomedicina.AdicionarDisciplina(anatomia);
        biomedicina.AdicionarDisciplina(analisesClinicas);
        biomedicina.AdicionarDisciplina(fisiologia);
        biomedicina.AdicionarDisciplina(toxicologia);

        Professor rodrigo = new Professor("Rodrigo Freitas", 45);
        Professor manuel = new Professor("Manuel Costa", 30);
        Professor andre = new Professor("André Ribeiro", 50);
        Professor amanda = new Professor("Amanda Matovanni", 34);
        Professor maria = new Professor("Maria Costa", 28);
        Professor ana = new Professor("Ana Souza", 38);
        Professor roberto = new Professor("Roberto Sanches", 45);
        Professor algusto = new Professor("Algusto Reis", 56);

        rodrigo.AtribuirDisciplina(matematica);
        manuel.AtribuirDisciplina(calculoI);
        andre.AtribuirDisciplina(fisica);
        amanda.AtribuirDisciplina(programacao);
        maria.AtribuirDisciplina(anatomia);
        ana.AtribuirDisciplina(analisesClinicas);
        roberto.AtribuirDisciplina(fisiologia);
        algusto.AtribuirDisciplina(toxicologia);



        Aluno patric = new Aluno("Patric", 30);
        Aluno miguel = new Aluno("miguel", 30);

        patric.MatricularEmCurso(engenharia);
        miguel.MatricularEmCurso(biomedicina);

        engenharia.ListarCursosEDisciplinas();
        biomedicina.ListarCursosEDisciplinas();

        engenharia.ListarAlunosMatriculados();
        biomedicina.ListarAlunosMatriculados();

        engenharia.ListarProfessoresEDisciplinas();
        biomedicina.ListarProfessoresEDisciplinas();

        engenharia.ListarInformacoesProfessores();
        biomedicina.ListarInformacoesProfessores();

        engenharia.ListarInformacoesAlunos();
        biomedicina.ListarInformacoesAlunos();
    }
}
}







