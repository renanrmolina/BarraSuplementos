using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarraSuplementos.Data;
using BarraSuplementos.Models;

namespace BarraSuplementos.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutosController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Produtos.Include(p => p.Categoria).Include(p => p.Marca);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome");
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nome");
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Lancamento,QtdEstoque,ValorAtual,ValorDesconto,Imagem,CategoriaId,MarcaId")] Produto produto, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();

                if (formFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = produto.Id.ToString() + Path.GetExtension(formFile.FileName);
                    string uploads = Path.Combine(wwwRootPath, @"img\produtos");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                    produto.Imagem = "/img/produtos/" + fileName;
                    await _context.SaveChangesAsync();
                }


                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", produto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nome", produto.MarcaId);
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", produto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nome", produto.MarcaId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Lancamento,QtdEstoque,ValorAtual,ValorDesconto,Imagem,CategoriaId,MarcaId")] Produto produto, IFormFile formFile)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (formFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;

                        if (produto.Imagem != null)
                        {
                            string oldFile = Path.Combine(wwwRootPath, produto.Imagem.TrimStart('\\'));
                            if (System.IO.File.Exists(oldFile))
                            {
                                System.IO.File.Delete(oldFile);
                            }
                        }

                        string fileName = produto.Id.ToString() + Path.GetExtension(formFile.FileName);
                        string uploads = Path.Combine(wwwRootPath, @"img\produtos");
                        string newFile = Path.Combine(uploads, fileName);
                        using (var stream = new FileStream(newFile, FileMode.Create))
                        {
                            formFile.CopyTo(stream);
                        }
                        produto.Imagem = "/img/produtos/" + fileName;
                        await _context.SaveChangesAsync();
                    }


                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", produto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nome", produto.MarcaId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'AppDbContext.Produtos'  is null.");
            }
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
