using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_dashboard_simulator.Functions
{
    class PolynomialRegression
    {
        /*
              1.1997120734392095 * 10^5   * x^0
            - 6.1764042332381614 * 10^3   * x^1
            + 1.5223889299553051 * 10^2   * x^2
            - 2.0742989096757034 * 10^0   * x^3
            + 1.6400298034880120 * 10^-2  * x^4
            - 7.4740510035536787 * 10^-5  * x^5
            + 1.8182131609111327 * 10^-7  * x^6
            - 1.8260451643838959 * 10^-10 * x^7
        */

        /// <summary>
        /// Calculate polynomial regression for speed
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Speed(int x)
        {
            return (Int32)(
                1.1997120734392095 * Math.Pow(10, 5) * Math.Pow(x, 0)
              - 6.1764042332381614 * Math.Pow(10, 3) * Math.Pow(x, 1)
              + 1.5223889299553051 * Math.Pow(10, 2) * Math.Pow(x, 2)
              - 2.0742989096757034 * Math.Pow(10, 0) * Math.Pow(x, 3)
              + 1.6400298034880120 * Math.Pow(10, -2) * Math.Pow(x, 4)
              - 7.4740510035536787 * Math.Pow(10, -5) * Math.Pow(x, 5)
              + 1.8182131609111327 * Math.Pow(10, -7) * Math.Pow(x, 6)
              - 1.8260451643838959 * Math.Pow(10, -10) * Math.Pow(x, 7));
        }

        /// <summary>
        /// Calculate polynomial regression for revolutions
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Revolutions(int x)
        {
            return (Int32)(
                5.9914752855764797 * Math.Pow(10, 4) * Math.Pow(x, 0)
              + 4.6964021800399944 * Math.Pow(10, 0) * Math.Pow(x, 1)
              - 8.4104199692731973 * Math.Pow(10, -2) * Math.Pow(x, 2)
              + 7.7811071729090364 * Math.Pow(10, -5) * Math.Pow(x, 3)
              - 3.3939914844982059 * Math.Pow(10, -8) * Math.Pow(x, 4)
              + 8.2834324131321289 * Math.Pow(10, -12) * Math.Pow(x, 5)
              - 1.1589748077420485 * Math.Pow(10, -15) * Math.Pow(x, 6)
              + 8.6967500271198971 * Math.Pow(10, -20) * Math.Pow(x, 7)
              - 2.7159561097267300 * Math.Pow(10, -24) * Math.Pow(x, 8));
        }
    }
}
