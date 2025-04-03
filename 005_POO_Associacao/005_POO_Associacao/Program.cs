using _005_POO_Associacao;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "ANA";
pessoa.Idade = 22;

Endereco end = new Endereco();
end.Rua = "Rua da Alegria";
end.Cidade = "Guará";
end.Numero = "22";
end.Bairro = "Pedregulho";
end.UF = "SP";


pessoa.EnderecoResidencial = end;

pessoa.ExibirDadosPessoa();