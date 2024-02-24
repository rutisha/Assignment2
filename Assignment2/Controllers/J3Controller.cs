using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary> ( CCC 2021 - junior problem )
        /// Secret Intruction with 5 digits in sequence which represents a direction and number of steps to take
        /// </summary>
        /// <param name="a">The integer represents first digit</param>
        /// <param name="b">The integer represents second digit</param>
        /// <param name="c">The integer represents third digit</param>
        /// <param name="d">The integer represents fourth digit</param>
        /// <param name="e">The integer represents fifth digit</param>
        /// <returns>It returns direction and number of steps to take further</returns>
        /// <example>
        /// localhost: GET xx/api/J3/secretcode/5/7/2/3/4 => right 234
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J3/secretcode/0/0/9/0/7 => right 907
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J3/secretcode/3/4/1/0/0 => left 100
        /// </example>
        [HttpGet]
        [Route("api/J3/Secretcode/{a}/{b}/{c}/{d}/{e}")]

        public string Secretcode(int a,int b,int c, int d, int e)
        {

            int sum = a + b;
            if (sum % 2 == 0)
            {
                return "right " + c + d + e;
            }
            else
            {
                return "left " + c + d + e;
            }
        }
    }
}
