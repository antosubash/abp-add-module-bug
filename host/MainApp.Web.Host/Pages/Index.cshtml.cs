﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MainApp.Pages
{
    public class IndexModel : MainAppPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}