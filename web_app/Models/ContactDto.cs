using System.ComponentModel.DataAnnotations;

namespace web_app.Models; 


public class ContactDto {
    
    // Specifies that the FirstName property is required and provides a custom error message.
    [Required(ErrorMessage = "This field is required")]
    public string FirstName { get; set; } = "";

    // Specifies that the LastName property is required and provides a custom error message.
    [Required(ErrorMessage = "This field is required")]
    public string LastName { get; set; } = "";

    // Specifies that the Email property is required and provides a custom error message.
    // and validate that the value is in a valid email address format.
    [Required(ErrorMessage = "This field is required")]
    [EmailAddress] 
    public string Email { get; set; } = "";

    // Specifies that the Message property is required and provides a custom error message.
    [Required(ErrorMessage = "This field is required")]
    public string Message { get; set; } = "";
}
