 using DevCar.Repositories;
 using DevCar.Models;
 using DevCar.Screen;
 
 namespace DevCar.Models
 {
    public class Program
    {
        static void Main(string[] args)
        {
            VeiculosRepository repository = new VeiculosRepository();
            MenuScreen.Iniciar(repository);
        }

       
       
    }

 }
