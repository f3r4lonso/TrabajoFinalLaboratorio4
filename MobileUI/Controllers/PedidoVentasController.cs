using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MobileUI.Models;

namespace MobileUI.Controllers
{
    public class PedidoVentasController : Controller
    {
        private OrdenesDBConnection db = new OrdenesDBConnection();

        // GET: PedidoVentas
        public ActionResult Index()
        {
            var pedidoVentas = db.PedidoVentas.Include(p => p.Cliente);
            return View(pedidoVentas.ToList());
        }

        // GET: PedidoVentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoVenta pedidoVenta = db.PedidoVentas.Find(id);
            if (pedidoVenta == null)
            {
                return HttpNotFound();
            }
            return View(pedidoVenta);
        }

        // GET: PedidoVentas/Create
        public ActionResult Create()
        {
            ViewBag.ClienteID = new SelectList(db.Clientes, "Id", "RazonSocial");
            return View();
        }

        // POST: PedidoVentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FechaEstimadaEntrega,GastosEnvio,Estado,Entregado,FechaPedido,NroPedido,SubTotal,MontoTotal,ClienteID")] PedidoVenta pedidoVenta)
        {
            if (ModelState.IsValid)
            {
                db.PedidoVentas.Add(pedidoVenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteID = new SelectList(db.Clientes, "Id", "RazonSocial", pedidoVenta.ClienteID);
            return View(pedidoVenta);
        }

        // GET: PedidoVentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoVenta pedidoVenta = db.PedidoVentas.Find(id);
            if (pedidoVenta == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteID = new SelectList(db.Clientes, "Id", "RazonSocial", pedidoVenta.ClienteID);
            return View(pedidoVenta);
        }

        // POST: PedidoVentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FechaEstimadaEntrega,GastosEnvio,Estado,Entregado,FechaPedido,NroPedido,SubTotal,MontoTotal,ClienteID")] PedidoVenta pedidoVenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidoVenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteID = new SelectList(db.Clientes, "Id", "RazonSocial", pedidoVenta.ClienteID);
            return View(pedidoVenta);
        }

        // GET: PedidoVentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoVenta pedidoVenta = db.PedidoVentas.Find(id);
            if (pedidoVenta == null)
            {
                return HttpNotFound();
            }
            return View(pedidoVenta);
        }

        // POST: PedidoVentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidoVenta pedidoVenta = db.PedidoVentas.Find(id);
            db.PedidoVentas.Remove(pedidoVenta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
