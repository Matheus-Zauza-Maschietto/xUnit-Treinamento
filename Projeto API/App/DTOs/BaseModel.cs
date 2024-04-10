namespace App.DTOs;

public record class BaseModel<T>(List<T?> results);
