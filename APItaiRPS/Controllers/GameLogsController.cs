using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APItaiRPS;
using APItaiRPS.Data;

namespace APItaiRPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameLogsController : ControllerBase
    {
        private readonly DataContext _context;

        public GameLogsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/GameLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameLog>>> GetGameLogs()
        {
            return await _context.GameLogs.ToListAsync();
        }

        // GET: api/GameLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameLog>> GetGameLog(int id)
        {
            var gameLog = await _context.GameLogs.FindAsync(id);

            if (gameLog == null)
            {
                return NotFound();
            }

            return gameLog;
        }

        // PUT: api/GameLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameLog(int id, GameLog gameLog)
        {
            if (id != gameLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(gameLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameLogExists(id))
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

        // POST: api/GameLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GameLog>> PostGameLog(GameLog gameLog)
        {
            _context.GameLogs.Add(gameLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameLog", new { id = gameLog.Id }, gameLog);
        }

        // DELETE: api/GameLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameLog(int id)
        {
            var gameLog = await _context.GameLogs.FindAsync(id);
            if (gameLog == null)
            {
                return NotFound();
            }

            _context.GameLogs.Remove(gameLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameLogExists(int id)
        {
            return _context.GameLogs.Any(e => e.Id == id);
        }
    }
}