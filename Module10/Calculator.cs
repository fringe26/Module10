// See https://aka.ms/new-console-template for more information
public class Calculator : ICalculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public void Start()
    {
        _logger.Event("Calculator starting...");
        Thread.Sleep(2000);

        try
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            double num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, num2));

        }catch(Exception ex)
        {
            _logger.Error(ex.Message);
        }
        finally
        {
            _logger.Event("Calculator turn off");
        }

        

    }

    public double Calculate(double num1, double num2)
    {
        return num1+ num2;
    }
}
