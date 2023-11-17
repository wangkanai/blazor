// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using BlazorAuthAuto.Data;

using Microsoft.AspNetCore.Identity;

namespace BlazorAuthAuto.Components.Account
{
	internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
	{
		public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
		{
			var user = await userManager.GetUserAsync(context.User);

			if (user is null)
			{
				redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
			}

			return user;
		}
	}
}
