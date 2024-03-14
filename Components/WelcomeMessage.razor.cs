using Microsoft.AspNetCore.Components;

namespace FirstBlazorApp.Components;

/// <summary>
/// C# portion for the WelcomeMessage component.
/// </summary>
public partial class WelcomeMessage: ComponentBase {

    // This is the variable that holds the greeting that we will reference in our HTML.
    private string Greeting {get; set;}

    /// <summary>
    /// This method runs once the component is initialized.
    /// </summary>
    protected override void OnInitialized()
    {
        // Set our Greeting based on the current time.
        Greeting = GetGreetingFromTime(DateTime.Now.Hour);
    }

    /// <summary>
    /// Sets the greeting based on the current time.
    /// </summary>
    /// <param name="hourOfDay">The hour of the day (24 hour clock) as an int.</param>
    /// <returns>The greeting based on the hour of the day, as a string.</returns>
    private static string GetGreetingFromTime(int hourOfDay) {
        string greetingBasedOnHour;

        // Note, console logs show up in the web browser's console, not the terminal running this Blazor app!
        Console.WriteLine(hourOfDay);

        // Set our string based on the current hour of the day (in 24 hour format).
        if (hourOfDay >= 0 && hourOfDay <= 5) {
            greetingBasedOnHour = "Staying up late?";
        } else if (hourOfDay > 5 && hourOfDay <= 11) {
            greetingBasedOnHour = "Good morning!";
        } else if (hourOfDay > 11 && hourOfDay <= 17) {
            greetingBasedOnHour = "Good afternoon!";
        } else {
            greetingBasedOnHour = "Good evening!";
        }

        return greetingBasedOnHour;
    }

}