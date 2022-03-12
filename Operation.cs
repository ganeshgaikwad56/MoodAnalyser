using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Operation
    {

        /// <summary>
        /// Moods the analyze.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// 

        public string MoodAnalyze(string message)
        {
            return "HAPPY";
        }
        /// <summary>
        /// Checks the mood.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// 


        public string CheckMood(string message)
        {
            return "SAD";
        }
    }
}
