﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ChummerHub.Areas.Identity.Pages.Account.Manage
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel'
    public class GenerateRecoveryCodesModel : PageModel
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel'
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<GenerateRecoveryCodesModel> _logger;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.GenerateRecoveryCodesModel(UserManager<ApplicationUser>, ILogger<GenerateRecoveryCodesModel>)'
        public GenerateRecoveryCodesModel(
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.GenerateRecoveryCodesModel(UserManager<ApplicationUser>, ILogger<GenerateRecoveryCodesModel>)'
            UserManager<ApplicationUser> userManager,
            ILogger<GenerateRecoveryCodesModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [TempData]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.RecoveryCodes'
        public string[] RecoveryCodes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.RecoveryCodes'

        [TempData]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.StatusMessage'
        public string StatusMessage { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.StatusMessage'

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.OnGetAsync()'
        public async Task<IActionResult> OnGetAsync()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.OnGetAsync()'
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var isTwoFactorEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
            if (!isTwoFactorEnabled)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                throw new InvalidOperationException($"Cannot generate recovery codes for user with ID '{userId}' because they do not have 2FA enabled.");
            }

            return Page();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.OnPostAsync()'
        public async Task<IActionResult> OnPostAsync()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'GenerateRecoveryCodesModel.OnPostAsync()'
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var isTwoFactorEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
            var userId = await _userManager.GetUserIdAsync(user);
            if (!isTwoFactorEnabled)
            {
                throw new InvalidOperationException($"Cannot generate recovery codes for user with ID '{userId}' as they do not have 2FA enabled.");
            }

            var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
            RecoveryCodes = recoveryCodes.ToArray();

            _logger.LogInformation("User with ID '{UserId}' has generated new 2FA recovery codes.", userId);
            StatusMessage = "You have generated new recovery codes.";
            return RedirectToPage("./ShowRecoveryCodes");
        }
    }
}