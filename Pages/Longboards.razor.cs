using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components;
namespace FirstBlazorApp.Pages;

public partial class Longboards : ComponentBase
{

    private List<Longboard> LongboardCollection = [
        new Longboard
                {
                    Name = "Sector 9 Dropper",
                    Description = "Downhill longboard designed for speed and stability.",
                    Speed = "High",
                    Style = "Downhill"
                },
                new Longboard
                {
                    Name = "Loaded Tan Tien",
                    Description = "Versatile longboard for cruising, carving, and freestyle tricks.",
                    Speed = "Medium",
                    Style = "Freestyle"
                },
                new Longboard
                {
                    Name = "Arbor Axis",
                    Description = "Classic pintail design suitable for cruising and carving.",
                    Speed = "Medium",
                    Style = "Cruising"
                },
                new Longboard
                {
                    Name = "Rayne Demonseed",
                    Description = "Longboard designed for downhill speed and stability.",
                    Speed = "High",
                    Style = "Downhill"
                },
                new Longboard
                {
                    Name = "Landyachtz Switchblade",
                    Description = "Popular freeride longboard known for its versatility and stability.",
                    Speed = "High",
                    Style = "Freeride"
                },
                new Longboard
                {
                    Name = "Loaded Dervish Sama",
                    Description = "Flexible longboard with a lively feel, ideal for carving and dancing.",
                    Speed = "Medium",
                    Style = "Dancing"
                },
                new Longboard
                {
                    Name = "Original Skateboards Pintail 40",
                    Description = "Classic pintail shape perfect for cruising and commuting.",
                    Speed = "Medium",
                    Style = "Cruising"
                },
                new Longboard
                {
                    Name = "Bustin Sportster",
                    Description = "Low-profile longboard for commuting and pushing.",
                    Speed = "Medium",
                    Style = "Commuting"
                },
                new Longboard
                {
                    Name = "Loaded Bhangra",
                    Description = "Longboard designed for dancing and freestyle performance.",
                    Speed = "Medium",
                    Style = "Dancing"
                },
                new Longboard
                {
                    Name = "Earthwing Supermodel",
                    Description = "Affordable downhill longboard with stable and predictable handling.",
                    Speed = "High",
                    Style = "Downhill"
                }
            ];

    // Holds our reference for the inputs to create a new longboard from.
    Longboard newLongboard = new Longboard();

    /// <summary>
    /// Adds the new longboard to our collection. (No validation, we will worry about that next week!)
    /// Also resets the newLongboard to a blank longboard.
    /// </summary>
    void AddLongboard()
    {
        LongboardCollection.Add(newLongboard);
        newLongboard = new Longboard();
    }

}