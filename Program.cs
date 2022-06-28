using PizzariaCSharp.Controller;
using PizzariaCSharp.Enum;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("SIMULANDO UMA API");
Console.WriteLine();

//var repositoryBebidas = new BebidaRepository();
var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor =  new SaborController(new SaborRepository());
var controllerPizza = new PizzaController(new PizzaRepository());
var controllerPedido = new PedidoController(new PedidoRepository());
var controllerCliente = new ClienteController(new ClienteRepository());

//simulando o consumo da API

//Cadastro de bebida;
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca-cola Lata", 5.00));
var bebida2 = controllerBebida.Adicionar(new Bebida("Coca-cola 2Lt", 10.00));

var sabor1 = controllerSabor.Adicionar(new Sabor("4 Queijos","teste"));
var sabor2 = controllerSabor.Adicionar(new Sabor("Margheritta","teste"));
var sabor3 = controllerSabor.Adicionar(new Sabor("Calabresa","teste"));
var sabor4 = controllerSabor.Adicionar(new Sabor("Portuguesa","teste"));
var listaSabores = new List<Sabor>
{
    sabor1,
    sabor2,
    sabor3,
    sabor4
};

var cliente1 = controllerCliente.Adicionar(new Cliente(){Nome ="Francisco da Silva", Telefone = "2222-2222"});
var cliente2 = controllerCliente.Adicionar(new Cliente(){Nome ="Maria da Silva", Telefone = "2222-3333"});

var pizza1 = controllerPizza.Adicionar(new Pizza(ETipoPizza.GIGANTE, ETipoBorda.SEM_BORDA, new List<Sabor>(){sabor1, sabor2}, 60.00));
var pizza2 = controllerPizza.Adicionar(new Pizza(ETipoPizza.GRANDE, ETipoBorda.SEM_BORDA, new List<Sabor>(){sabor2, sabor3}, 40.00));
var pizza3 = controllerPizza.Adicionar(new Pizza(ETipoPizza.PEQUENA, ETipoBorda.SEM_BORDA, new List<Sabor>(){sabor1}, 30.00));
var pizza4 = controllerPizza.Adicionar(new Pizza(ETipoPizza.GIGANTE, ETipoBorda.SEM_BORDA, new List<Sabor>(){sabor2}, 65.00));

var pedido1 = new Pedido(cliente1);
var pedido2 = new Pedido(cliente2);
var valor1 = pedido1
    .AdcionarPizza(pizza1)
    .AdcionarBebida(bebida1)
    .ObterValorTotal();
pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido1);

var valor2 = pedido2
    .AdcionarBebida(bebida2)
    .AdcionarPizza(pizza3)
    .AdcionarPizza(pizza2)
    .ObterValorTotal();
pedido2.FinalizarPedido();
controllerPedido.Adicionar(pedido2);