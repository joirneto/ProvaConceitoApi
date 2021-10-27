using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaConceitoApi.Models;
using System.Data.SqlClient;
using ProvaConceitoApi.infra;
using Microsoft.Extensions.Options;
using Dapper;

namespace ProvaConceitoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IOptions<ConnectionString> connectionString;

        public ClienteController(IOptions<ConnectionString> connectionString)
        {
            this.connectionString = connectionString;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteModel>>> Get()
        {
            var sql = "SELECT * FROM DBO.Cliente";
            IEnumerable<ClienteModel> result;

            using (var conn = new SqlConnection(connectionString.Value.ProvaConceito))
            {
                result = await conn.QueryAsync<ClienteModel>(sql);
            }
            return Ok(result);
        }
    }
}

