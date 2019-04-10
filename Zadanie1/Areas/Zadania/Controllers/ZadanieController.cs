using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie1.Areas.Zadania.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;
using OfficeOpenXml;

namespace Zadanie1.Areas.Zadania.Controllers
{
    public class ZadanieController : Controller

    {
        private DaneContext _context;
        public ZadanieController()
        {
            _context = new DaneContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Zadania/Home
        public ActionResult Index(string sortBy, int? page, int? pageCount)
        {
            ViewBag.CurrentSort = sortBy;
            ViewBag.CurrentPageCount = pageCount;

            ViewBag.SortNazwa = string.IsNullOrEmpty(sortBy) ? "id" : "";
            ViewBag.SortDataRozpoczeciaParameter = sortBy == "data_rozpoczecia" ? "data_rozpoczecia*" : "data_rozpoczecia";
            ViewBag.SortDataZakonczeniaParameter = sortBy == "data_zakonczenia" ? "data_zakonczenia*" : "data_zakonczenia";
            ViewBag.SortStatusParameter = sortBy == "status" ? "status*" : "status";
            ViewBag.SortPriorytetParameter = sortBy == "priorytet" ? "priorytet*" : "priorytet";
            var zadania = _context.Dane.ToList();
            List<Dane> orderedList = zadania;
            switch (sortBy)
            {
                case "id":
                    orderedList = zadania.OrderBy(a => a.DaneId).ToList();
                    break;
                case "data_rozpoczecia*":
                    orderedList = zadania.OrderByDescending(a => a.data_rozpoczecia).ToList();
                    break;
                case "data_rozpoczecia":
                    orderedList = zadania.OrderBy(a => a.data_rozpoczecia).ToList();
                    break;

                case "data_zakonczenia*":
                    orderedList = zadania.OrderByDescending(a => a.data_zakonczenia).ToList();
                    break;
                case "data_zakonczenia":
                    orderedList = zadania.OrderBy(a => a.data_zakonczenia).ToList();
                    break;

                case "status*":
                    orderedList = zadania.OrderByDescending(a => a.status).ToList();
                    break;
                case "status":
                    orderedList = zadania.OrderBy(a => a.status).ToList();
                    break;

                case "priorytet*":
                    orderedList = zadania.OrderByDescending(a => a.priorytet).ToList();
                    break;
                case "priorytet":
                    orderedList = zadania.OrderBy(a => a.priorytet).ToList();
                    break;



            }
            int pageSize = (pageCount ?? 10);
            int pageNumber = (page ?? 1);
            return View(orderedList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult IndexTiles(string sortBy, int? page, int? pageCount,Dane dane)
        {
            ViewBag.CurrentSort = sortBy;
            ViewBag.CurrentPageCount = pageCount;

            ViewBag.SortNazwa = string.IsNullOrEmpty(sortBy) ? "id" : "";
            ViewBag.SortIdParameter = sortBy == "id" ? "id*" : "id";
            ViewBag.SortDataRozpoczeciaParameter = sortBy == "data_rozpoczecia" ? "data_rozpoczecia*" : "data_rozpoczecia";
            ViewBag.SortDataZakonczeniaParameter = sortBy == "data_zakonczenia" ? "data_zakonczenia*" : "data_zakonczenia";
            ViewBag.SortStatusParameter = sortBy == "status" ? "status*" : "status";
            ViewBag.SortPriorytetParameter = sortBy == "priorytet" ? "priorytet*" : "priorytet";


            var zadania = _context.Dane.ToList();
            List<Dane> orderedList = zadania;
            switch (sortBy)
            {
                case "id":
                    orderedList = zadania.OrderBy(a => a.DaneId).ToList();
                    break;
                case "data_rozpoczecia*":
                    orderedList = zadania.OrderByDescending(a => a.data_rozpoczecia).ToList();
                    break;
                case "data_rozpoczecia":
                    orderedList = zadania.OrderBy(a => a.data_rozpoczecia).ToList();
                    break;

                case "data_zakonczenia*":
                    orderedList = zadania.OrderByDescending(a => a.data_zakonczenia).ToList();
                    break;
                case "data_zakonczenia":
                    orderedList = zadania.OrderBy(a => a.data_zakonczenia).ToList();
                    break;

                case "status*":
                    orderedList = zadania.OrderByDescending(a => a.status).ToList();
                    break;
                case "status":
                    orderedList = zadania.OrderBy(a => a.status).ToList();
                    break;

                case "priorytet*":
                    orderedList = zadania.OrderByDescending(a => a.priorytet).ToList();
                    break;
                case "priorytet":
                    orderedList = zadania.OrderBy(a => a.priorytet).ToList();
                    break;



            }
            int pageSize = (pageCount ?? 10);
            int pageNumber = (page ?? 1);
            return View(orderedList.ToPagedList(pageNumber, pageSize));
        }




        public ActionResult Create()
        {
            return PartialView();
        }

        public ActionResult Details(int id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = _context.Dane.SingleOrDefault(c => c.DaneId == id);
            if (task == null)
                return HttpNotFound();

            return PartialView(task);

        }
        public ActionResult Delete(int id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = _context.Dane.SingleOrDefault(c => c.DaneId == id);
            if (task == null)
                return HttpNotFound();

            return PartialView(task);

        }
        [HttpPost]
        public ActionResult DeleteConfirm(Dane dane)
        {
            var daneInDb = _context.Dane.SingleOrDefault(c => c.DaneId == dane.DaneId);
            if (daneInDb == null)
                return HttpNotFound();
            _context.Dane.Remove(daneInDb);
            _context.SaveChanges();
            //tutaj jeszcze dodaj obsluge viewbaga, ktory bedzie wysylal msg, aby wyswietlic komunikat, ze udalo sie usunac element
            return RedirectToAction("Index","Zadanie");
        }
        public ActionResult Edit(int id)
        {
            //znajdz zadanie o okreslonym id
            Dane task = _context.Dane.SingleOrDefault(c => c.DaneId == id);
            if (task == null)
                return HttpNotFound();

            return PartialView(task);
        }


        [HttpPost]
        public ActionResult Save(Dane dane)
        {
            //jezeli jakims cudem uda sie wprowadzic zle dane, to zostanie przekierowany do Index
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index","Zadanie");
            }
            //gdy id == 0, to jest otrzymywany z create, jezeli jest rozny od 0, to z edita
            if (dane.DaneId == 0)
            {
                //tutaj wstaw viewbaga z msg, ze udalo sie dodac nowy element
                _context.Dane.Add(dane);

            }
            else
            {
                //tutaj wstaw viewbaga z msg, ze udalo sie edytowac element
                var taskInDb = _context.Dane.Single(m => m.DaneId == dane.DaneId);
                taskInDb.temat = dane.temat;
                taskInDb.czynnosc = dane.czynnosc;
                taskInDb.opis = dane.opis;
                taskInDb.priorytet = dane.priorytet;
                taskInDb.status = dane.status;
                taskInDb.procent_zakonczenia = dane.procent_zakonczenia;
                taskInDb.data_rozpoczecia = dane.data_rozpoczecia;
                taskInDb.data_zakonczenia = dane.data_zakonczenia;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Zadanie");

        }


        public ActionResult SaveAsExcel()
        {

            IPagedList<Dane> model = (IPagedList<Dane>)TempData["FullModel"];
            if (model == null)
                RedirectToAction("IndexTiles", "Zadanie");
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("excel");

            ws.Cells["A1"].Value = "Czynnosc";
            ws.Cells["B1"].Value = "Temat";
            ws.Cells["C1"].Value = "Data Rozpoczęcia";
            ws.Cells["D1"].Value = "Data Zakończenia";
            ws.Cells["E1"].Value = "Status";
            ws.Cells["F1"].Value = "Priorytet";
            ws.Cells["G1"].Value = "Procent zakończenia";
            int rowStart = 2;
            foreach (var item in model)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.czynnosc;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.temat;
                ws.Cells[string.Format("C{0}", rowStart)].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.data_rozpoczecia;
                ws.Cells[string.Format("D{0}", rowStart)].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[string.Format("D{0}", rowStart)].Value = item.data_zakonczenia;
                ws.Cells[string.Format("E{0}", rowStart)].Value = item.status;
                ws.Cells[string.Format("F{0}", rowStart)].Value = item.priorytet;
                ws.Cells[string.Format("G{0}", rowStart)].Value = item.procent_zakonczenia;
                rowStart++;
            }
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            string excelName = "ToDo";

            using (var memoryStream = new MemoryStream())
            {
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment; filename=" + excelName + ".xlsx");
                pck.SaveAs(memoryStream);
                memoryStream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.End();

                return Redirect("index");
            }
        }

        public ActionResult SaveAsPdf()
        {
            /*dodawanie do pdf juz dziala, ale jeszcze trzeba dodac nowy widok,
            do ktorego bedzie przekazywany model,
            poniewaz wybrane rozwiazanie przerabia otrzymana strone na pdf
            W przyszlosci można zastosować inne rozwiazanie np. RazorPDF, iTexta, albo IronPDF
            fajnym rozwiazaniem wydaje sie byc kendo UI, ale jest drogi :D*/
            /*trzeba jeszcze dodac:
             * zapytanie, czy na pewno zapisac
             * dodac pytanie o nazwe
             * ewentualnie gdzie zapisac*/
            {
                var model = TempData["FullModel"];
                //Code to get content
                return new Rotativa.ViewAsPdf("Index", model) { FileName = "TestViewAsPdf.pdf" };
            }


        }



    }
}