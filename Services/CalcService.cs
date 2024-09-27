namespace lr_three.Services
{
    public interface ICalcService
    {
        double Add(double x, double y);
        double Subtraction(double x, double y);
        double Multiplication(double x, double y);
        double Divide(double x, double y);
    }
    public class CalcService: ICalcService
    {
        private readonly IConfiguration _configuration;
        public CalcService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public double Add(double x, double y){ return x + y; }
        public double Subtraction(double x, double y){ return x - y; }
        public double Multiplication(double x, double y){ return x * y; }
        public double Divide(double x, double y){return x / y; }
    }
}
