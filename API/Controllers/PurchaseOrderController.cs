using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class PurchaseOrderController : BaseApiController
    {
        private readonly DataContext _context;
        public PurchaseOrderController(DataContext context) : base(context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseOrder>>> GetPurchaseOrders()
        {
            return await _context.PurhaseOrders.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder(PurchaseOrder purchaseOrder) {
            _context.PurhaseOrders.Add(purchaseOrder);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}