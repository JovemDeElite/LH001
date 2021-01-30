using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LH001.Domain.Api.v1;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace LH001.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> OnGet()
        {
            //var accessToken = await HttpContext.GetTokenAsync("access_token");
            var resultado = await new ChamadaDesenvolvedor(_configuration["URLs:LH.Service"]).Listar();
            //var retorno = JsonConvert.DeserializeObject<List<LH001.Domain.Entidades.Tb_Desenvolvedor>>(await resultado.Content.ReadAsStringAsync());
            return Page();
        }
    }
}
