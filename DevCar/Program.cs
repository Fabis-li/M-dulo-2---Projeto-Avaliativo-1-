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

            PopLista(repository);
            MenuScreen.Iniciar(repository);
        }

        static void PopLista(VeiculosRepository repository)
        {
            repository.ListaDeVeiculos.Add(new MotoTriciculoModel(new DateTime(2021, 05, 22), "CG", "PLF2345", 5000M, "Branco", 100, 2));
            repository.ListaDeVeiculos.Add(new MotoTriciculoModel(new DateTime(2021, 05, 12), "Triciculo", "ABC2345", 350000M, "Preto", 1330, 3));
            repository.ListaDeVeiculos.Add(new CarroModel(new DateTime(2022,07, 15),"Celta", "DIL1537", 7000M, "Vermelho", 4, "Gasolina", 20));
            repository.ListaDeVeiculos.Add(new CaminhoneteModel(new DateTime(2021, 05, 12), "Alaskan", "VLB1234", 320000M, "Roxa", 4, "Diesel", 300, 190 ));
        }

       
       
    }

 }
