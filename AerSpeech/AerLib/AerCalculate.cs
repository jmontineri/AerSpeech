using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace AerSpeech
{
    //This uses the open Calcatraz API that can handle most simple calculations.

    class AerCalculate
    {

        private WebClient _dataDownloader;

        public AerCalculate()
        {
            _dataDownloader = new WebClient();
        }

        public string CalculationResult(string query)
        {
            string result = _dataDownloader.DownloadString("https://www.calcatraz.com/calculator/api?c=" + WebUtility.UrlEncode(query)).Trim();
            if (result == "answer")
            {
                result = "I could not evaluate this calculation.";
            }
            return result;

        }
    }
}
