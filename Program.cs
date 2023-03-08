namespace Concesionaria;
class Program
{
    static void Main(string[] args)
    {
        Automovil auto1 = new Automovil();
        auto1.setId(1);
        auto1.setKilometraje(1000);
        auto1.setMarca("Marca1");
        auto1.setModelo("Modelo1");
        auto1.setPrecio(11000);

        Automovil auto2 = new Automovil();
        auto2.setId(2);
        auto2.setKilometraje(2000);
        auto2.setMarca("Marca2");
        auto2.setModelo("Modelo2");
        auto2.setPrecio(22000);

        Concesionaria concesionaria = new Concesionaria(5);
        concesionaria.AgregarAuto(auto1);
        concesionaria.AgregarAuto(auto2);

        concesionaria.MostrarAuto(auto1);
        concesionaria.MostrarAutos();
        concesionaria.EliminarAuto(auto1);
        concesionaria.MostrarAutos();
        concesionaria.VaciarConcesionaria();
        concesionaria.MostrarAutos();

    }
}
