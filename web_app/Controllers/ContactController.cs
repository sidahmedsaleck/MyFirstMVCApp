using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers;

public class ContactController : Controller {

    // Private readonly fields to store email and address information.
    private readonly string email = "contact@horizon.com";
    private readonly string address = "Hammam Sousse, TUNISIA";

    //Function that Handles requests to the default Index action.
    public IActionResult Index()
    {
        // Passes the email to the view using ViewData.
        ViewData["ContactEmail"] = email;

        // Passes the address to the view using ViewBag.
        ViewBag.ContactAddress = address;

        // Returns the default view for the action.
        return View();
    }

    // POST: Handles form submissions to the Index action.
    [HttpPost]
    public IActionResult Index(ContactDto model) {
        
        // Reassigns the email and address to ViewData and ViewBag for use in the view.
        ViewData["ContactEmail"] = email;
        ViewBag.ContactAddress = address;

        // Checks if the model state is valid.
        if (!ModelState.IsValid) {
            // If the model state is invalid, redisplays the form with the current data.
            return View(model);
        }

        // Sets a success message to be displayed in the view after form submission.
        ViewBag.ContactSuccessMessage = "Your message is received with success";

        // Clears the model state.
        ModelState.Clear();

        // Returns the default view.
        return View();
    }
}
