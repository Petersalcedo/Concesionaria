namespace Concesionaria;

public class Automovil{
    private int id;
    private string marca = "";
    private string modelo = "";
    private int kilometraje;
    private int precio;


    public void setId(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return this.id;
    }

    public void setMarca(string marca)
    {
        this.marca = marca;
    }

    public string getMarca()
    {
        return this.marca;
    }

    public void setModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public string getModelo()
    {
        return this.modelo;
    }

    public void setKilometraje(int km)
    {
        this.kilometraje = km;
    }

    public int getKilometraje()
    {
        return this.kilometraje;
    }

    public void setPrecio(int precio)
    {
        this.precio = precio;
    }

    public int getPrecio()
    {
        return this.precio;
    }

    public override string ToString()
    {
        return "ID: " + this.id + ", " + "Marca: "+  this.marca + "," + "Modelo: " +  this.modelo + ", " +  "KM: " + this.kilometraje + ", " + "Precio: " + this.precio;
    }
}
