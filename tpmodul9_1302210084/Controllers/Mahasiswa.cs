using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210084.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        public static List<MahasiswaC> _data = new List<MahasiswaC>
        {
            new MahasiswaC("Surya Aulia", "1302210084"),
            new MahasiswaC("Risjad Shidqi", "1302213045"),
            new MahasiswaC("Ashar Syahbudi", "1302210070"),
            new MahasiswaC("Zhafran Hafiz", "1302210036"),
            new MahasiswaC("Gifari Juliandri", "1302210087"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<MahasiswaC> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public MahasiswaC Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] MahasiswaC value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}
