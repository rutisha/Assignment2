using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary> ( CCC 2006 - junior problem)
        /// Calculate the total calories per order as per user input
        /// </summary>
        /// <param name="burger">The integer represents burger choice</param>
        /// <param name="drink">The integer represents drink choice</param>
        /// <param name="side">The integer represents side choice</param>
        /// <param name="dessert">The integer represents dessert choice</param>
        /// <returns>It returns the total calories from user input</returns>
        /// <example>
        /// localhost: GET xx/api/J1/menu/4/4/4/4 => Your total calorie count is : 0
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J1/menu/1/4/4/4 => Your total calorie count is : 461
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J1/menu/1/2/3/4 => Your total calorie count is : 691
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger,int drink, int side, int dessert)
        {
            int totalCalories = 0;

            if (burger >= 1 && burger <= 4)
            {
                int[] burgerCalories = { 461, 431, 420, 0 };
                totalCalories += burgerCalories[burger - 1];
            }

            if (drink >= 1 && drink <= 4)
            {
                int[] drinkCalories = { 130, 160, 118, 0 };
                totalCalories += drinkCalories[drink - 1];
            }

            if (side >= 1 && side <= 4)
            {
                int[] sideCalories = { 100, 57, 70, 0 };
                totalCalories += sideCalories[side - 1];
            }

            if (dessert >= 1 && dessert <= 4)
            {
                int[] dessertCalories = { 167, 266, 75, 0 };
                totalCalories += dessertCalories[dessert - 1];
            }

            return "Your total calorie count is : "+ totalCalories;
        }
    }
}
