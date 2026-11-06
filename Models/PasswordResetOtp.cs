using System;

public class PasswordResetOtp
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? Otp { get; set; }
    public DateTime ExpiryDate { get; set; }
    public DateTime CreatedAt { get; set; }
}
