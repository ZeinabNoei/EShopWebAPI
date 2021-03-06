﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EShopAPI.Context;
using EShopAPI.Models;

namespace EShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private readonly EShopAPI_DBContext _context;

        public ProvincesController(EShopAPI_DBContext context)
        {
            _context = context;
        }

        // GET: api/Provinces
        [HttpGet]
        public IEnumerable<Province> GetProvince()
        {
            return _context.Province;
        }

        // GET: api/Provinces/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProvince([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var province = await _context.Province.FindAsync(id);

            if (province == null)
            {
                return NotFound();
            }

            return Ok(province);
        }

        // PUT: api/Provinces/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvince([FromRoute] int id, [FromBody] Province province)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != province.ID)
            {
                return BadRequest();
            }

            _context.Entry(province).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Provinces
        [HttpPost]
        public async Task<IActionResult> PostProvince([FromBody] Province province)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Province.Add(province);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProvince", new { id = province.ID }, province);
        }

        // DELETE: api/Provinces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvince([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var province = await _context.Province.FindAsync(id);
            if (province == null)
            {
                return NotFound();
            }

            _context.Province.Remove(province);
            await _context.SaveChangesAsync();

            return Ok(province);
        }

        private bool ProvinceExists(int id)
        {
            return _context.Province.Any(e => e.ID == id);
        }
    }
}