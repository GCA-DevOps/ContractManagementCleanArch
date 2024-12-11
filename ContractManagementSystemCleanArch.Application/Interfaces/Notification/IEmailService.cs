﻿namespace CMS.Domain.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message, byte[] attachmentData, string attachmentName);
    }
}
