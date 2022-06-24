using PizzariaCSharp.Controller;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("SIMULANDO UMA API");
Console.WriteLine();

//var repositoryBebidas = new BebidaRepository();
var controllerBebida = new BebidaController(new BebidaRepository());

//ssimulando o consumo da API

//Cadastro de bebida;
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca-cola Lata", 5.00));
var bebida2 = controllerBebida.Adicionar(new Bebida("Coca-cola 2Lt", 10.00));

//Obter todas as bebidas
var bebidas = controllerBebida.Obtertodos();

//Obeter por id
var bebidaObtida = controllerBebida.ObterPorId(bebida1.Id);

//Atualizar uma bebida
bebida1.Valor = 6.00;
var bebidaAtualizada = controllerBebida.Atualizar(bebida1.Id, bebida1);

//Deletar uma bebida
controllerBebida.Remover(bebida2.Id);


var resultado = controllerBebida.Obtertodos();