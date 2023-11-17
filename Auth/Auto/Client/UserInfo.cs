// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace BlazorAuthAuto.Client
{
	// Add properties to this class and update the server and client AuthenticationStateProviders
	// to expose more information about the authenticated user to the client.
	public class UserInfo
	{
		public required string UserId { get; set; }
		public required string Email { get; set; }
	}
}
