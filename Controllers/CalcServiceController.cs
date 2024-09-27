using lr_three.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.RegularExpressions;

namespace lr_three.Controllers
{
    [ApiController]
    [Route("calc")]
    public class CalcServiceController: ControllerBase
    {
        private readonly ICalcService _service;
        public CalcServiceController(ICalcService service)
        {
            _service = service;
        }
        [HttpGet("{queryString}")]
        public string Index(string queryString)
        {

            string plusMinus = @"[+-]?";
            string findCalcSign = @"[+*-]";
            string findDouble = @"\d+\.\d+";

            Regex regex = new Regex($@"({plusMinus})({findDouble})\s*({findCalcSign})\s*({plusMinus})({findDouble})");
            Match match = regex.Match(queryString);

            if (!match.Success) return "Error";

            string firstNumber = match.Groups[1].Value + match.Groups[2];
            string secondNumber = match.Groups[4].Value + match.Groups[5];
            string sign = match.Groups[3].Value;

            double x, y;

            if (double.TryParse(firstNumber, CultureInfo.InvariantCulture, out x) && double.TryParse(secondNumber, CultureInfo.InvariantCulture, out y))
            {
                if(sign == "+") return $"x({x}) + y({y}) = {_service.Add(x, y)}";
                else if (sign == "-") return $"x({x}) - y({y}) = {_service.Subtraction(x, y)}";
                else return $"x({x}) * y({y}) = {_service.Multiplication(x, y)}";
            }
            else
            {
                return $"Error";
            }
        }
        [HttpGet("{firstNumber}/{secondNumber}")]
        public string Index(string firstNumber, string secondNumber)
        {
            double x, y;
            if (double.TryParse(firstNumber, CultureInfo.InvariantCulture, out x) && double.TryParse(secondNumber, CultureInfo.InvariantCulture, out y))
            {
                return $"x({x}) / y({y}) = {_service.Divide(x, y)}";
            }
            else
            {
                return $"Error";
            }
        }
    }
}
