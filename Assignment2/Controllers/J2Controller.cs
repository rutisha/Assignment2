using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary> ( CCC 2006 - junior problem)
        /// Calculate total number of ways we get sum of 10 using the number sides on two dice.
        /// </summary>
        /// <param name="m">The integer represents the no. of sides on first dice</param>
        /// <param name="n">The integer represents the no. of sides of second dice</param>
        /// <returns>Total number ways to get the sum 10</returns>
        /// <example>
        /// localhost: GET xx/api/J2/Dicegame/6/8 => There are 5 total ways to get the sum 10.
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J2/Dicegame/12/4 => There are 4 total ways to get the sum 10.
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J2/Dicegame/3/3 => There are 0 total ways to get the sum 10.
        /// </example>
        /// <example>
        /// localhost: GET xx/api/J2/Dicegame/5/5 => There are 1 total ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/Dicegame/{m}/{n}")]
        public string Dicegame (int m, int n)
        {
            int ways = 0;

            for(int i=1; i<=m; i++) { 
            
               for(int j=1; j<=n; j++ )
                {
                    if( i + j == 10) 
                    {  
                        ways++; 
                    }
                    
                }
            }

            return "There are " + ways + " to get the sum 10.";
        }
    }
}
