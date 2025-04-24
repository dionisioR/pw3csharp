
using _006_POO_Heranca;

Endereco endereco = new Endereco("Rua das neves", "22",
    "Pedregulho", "Guará", "SP");

Aluno al =  new Aluno("Juca", "Silva", "DS",
    "Matutino", 2025, endereco );

al.ExibirDados();