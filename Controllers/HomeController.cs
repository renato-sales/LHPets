using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01,"Robson", "343.789.098-43", "nome@email.com", "Pegasus");
        Cliente cliente2 = new Cliente(02,"Arthur", "434.867.452-89", "nome@email.com", "Pit");
        Cliente cliente3 = new Cliente(03,"Maria", "434.867.785-00", "nome@email.com", "Tob");
        Cliente cliente4 = new Cliente(04,"Ana", "434.867.231-90", "nome@email.com", "Rex");
        Cliente cliente5 = new Cliente(05,"Felipe", "434.867.645-76", "nome@email.com", "Pank");

        List<Cliente> clientes = new List<Cliente>();
        clientes.Add(cliente1);
        clientes.Add(cliente2);
        clientes.Add(cliente3);
        clientes.Add(cliente4);
        clientes.Add(cliente5);

        ViewBag.listaClientes = clientes;

        Fornecedor fornecedor1 = new Fornecedor(01,"TEC PEC", "343.789.098/0001", "nome@email.com");
        Fornecedor fornecedor2 = new Fornecedor(02,"PARK POP", "098.543.132/0001", "nome@email.com");
        Fornecedor fornecedor3 = new Fornecedor(03,"BANK TAE", "332.541.098/0001", "nome@email.com");
        Fornecedor fornecedor4 = new Fornecedor(04,"LUGU DAE", "990.541.653/0001", "nome@email.com");
        Fornecedor fornecedor5 = new Fornecedor(05,"PEQE PAY", "556.067.421/0001", "nome@email.com");

        List<Fornecedor> fornecedores = new List<Fornecedor>();
        fornecedores.Add(fornecedor1);
        fornecedores.Add(fornecedor2);
        fornecedores.Add(fornecedor3);
        fornecedores.Add(fornecedor4);
        fornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = fornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
