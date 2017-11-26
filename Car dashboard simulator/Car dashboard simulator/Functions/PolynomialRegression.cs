using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_dashboard_simulator.Functions
{
    class PolynomialRegression
    {
        /// <summary>
        /// Calculate polynomial regression for speed
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Speed(int x)
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
    }
}
