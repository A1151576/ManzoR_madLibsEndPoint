/*
                        Rafael Manzo
                    Reverse it Challenge end point
                        10/26/2022
    Peer review: Madeline Gowan - Works as intended. I like the simplicity of the story while also still allowing for a lot of words to be inputed.
*/
using Microsoft.AspNetCore.Mvc;

namespace ManzoR_oddOrEven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddlyController : ControllerBase
{
    [HttpGet]
    [Route("evenOdd/{name}/{verb}/{location}/{snacks}/{person}/{disease}/{animal}")]
    public string strangley(string name, string verb, string location, string snacks, string person, string disease, string animal)
    {
        return $"Yesterday i {verb} to the {location} to get some {snacks} for {person} because they've been sick with {disease} that they've contracted from our pet {animal}.";
    }


}
