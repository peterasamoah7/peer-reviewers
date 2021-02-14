using DataCollection.Models;
using DataCollection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewersController : ControllerBase
    {
        private readonly KeyPhraseService _keyPhraseService;
        private readonly ContentService _contentService;
        private readonly TokenService _tokenService;
        private readonly SearchService _searchService; 

        public ReviewersController(
            KeyPhraseService keyPhraseService, 
            ContentService contentService, 
            TokenService tokenService,
            SearchService searchService)
        {
            _keyPhraseService = keyPhraseService;
            _contentService = contentService;
            _tokenService = tokenService;
            _searchService = searchService; 
        }

        /// <summary>
        /// Upload paper to be reviewed
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]IFormCollection files)
        {
            var list = new List<string>();
            var file = files.Files[0];
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    list = _contentService.GetText(fileBytes); 
                }
            }

            var responses = new List<KeyPhraseReponse>();
            var authHeader = await _tokenService.GetAuthTokenAsync(); 
            foreach (var item in list)
            {
                responses.Add(await _keyPhraseService
                    .GetKeyPhrasesAsync(item, authHeader));
            }

            var keywords = _contentService.GetKeyWords(responses); 

            return Ok(keywords); 
        }

        /// <summary>
        /// Get matching reviewer papers
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string query) => 
            Ok(await _searchService.GetResultsAsync(query));
    }
}
