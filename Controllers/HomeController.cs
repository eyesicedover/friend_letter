using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Produces("text/html")]
        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient("Eric");
            myLetterVariable.SetSender("John");
            return View(myLetterVariable);
        }

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/journal")]
        public ActionResult Journal()
        {
            return View();
        }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("GreetingCard", myLetterVariable);
        }

        [Produces("text/html")]
        [Route("/favorite_photos")]
        public ActionResult FavoritePhotos()
        {
            return View();
        }
    }
}
