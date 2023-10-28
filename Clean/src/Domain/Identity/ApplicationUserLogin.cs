// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Microsoft.AspNetCore.Identity;

namespace BlazorAuthClean.Domain.Identity;

public class ApplicationUserLogin: IdentityUserLogin<string>
{
	public virtual ApplicationUser User { get; set; } = default!;
}

