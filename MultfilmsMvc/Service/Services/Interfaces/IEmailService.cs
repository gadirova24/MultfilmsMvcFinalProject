﻿using System;
namespace Service.Services.Interfaces
{
	public interface IEmailService
	{
        Task SendEmailAsync(string to, string subject, string body);
    }
}

