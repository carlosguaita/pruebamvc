using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using pruebamvc.Models;
using pruebamvc.Services;

namespace pruebamvc.Controllers;

public class HomeController : Controller
{
    private readonly IServicioApi _servicioApi;

    public HomeController(IServicioApi servicioApi)
    {
        _servicioApi = servicioApi;
    }

    public async Task<IActionResult> Index()
    {
        List<Producto> listProducto = new List<Producto>();
        try
        {
            listProducto = await _servicioApi.ListarProductos();
        }catch(Exception ex)
        {
            
        }

        //ViewBag.model = listProducto;
        return View(listProducto);
    }

    public async Task<IActionResult> Producto(string codigo)
    {
        Producto producto = new Producto();

        ViewBag.Accion = "Nuevo Producto";
        if (codigo != null)
        {
            producto = await _servicioApi.ObtenerProducto(codigo);
            ViewBag.Accion = "Editar Producto";
        }

        //ViewBag.model = listProducto;
        return View(producto);
    }



    [HttpPost]
    public async Task<IActionResult> Guardar(Producto producto)
    {
        string httpStatusCode = HttpStatusCode.BadRequest.ToString();
       if (producto.codigo==null)
        {
            httpStatusCode = await _servicioApi.GuardarProducto(producto);
        }
        else
        {
            httpStatusCode = await _servicioApi.EditarProducto(producto.codigo,producto);
        }

        if (httpStatusCode.Equals(HttpStatusCode.OK.ToString()))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NoContent();
        }

        //ViewBag.model = listProducto;
       
    }

    [HttpGet]
    public async Task<IActionResult> Guardar(string codigo)
    {
        string httpStatusCode = HttpStatusCode.BadRequest.ToString();
       
        httpStatusCode = await _servicioApi.BorrarProducto(codigo)
      

        if (httpStatusCode.Equals(HttpStatusCode.OK.ToString()))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NoContent();
        }

        //ViewBag.model = listProducto;

    }


    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Page2()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

