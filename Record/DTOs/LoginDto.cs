namespace Record.DTOs;

public record class Login(
    string Email,
    string Password,
    bool RememberMe = true);

