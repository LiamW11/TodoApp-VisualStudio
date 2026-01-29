using System.ComponentModel.DataAnnotations;

namespace YourApp.Models;

public sealed class TodoCreateModel
{
    [Required(ErrorMessage = "Titel krävs.")]
    [StringLength(50, ErrorMessage = "Max 50 tecken.")]
    public string Title { get; set; } = "";

    public bool Done { get; set; }
}