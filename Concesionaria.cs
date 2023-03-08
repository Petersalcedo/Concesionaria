namespace Concesionaria;

public class Concesionaria
{
    private List<Automovil> automoviles;
    private int limiteAutomoviles;
    private int numeroAutomoviles;

    public Concesionaria(int limiteAutomoviles)
    {
        this.limiteAutomoviles = limiteAutomoviles;
        this.automoviles = new List<Automovil>();
        this.numeroAutomoviles = 0;
    }

    public void AgregarAuto(Automovil automovil)
    {
        if(automovil != null && this.automoviles.Count() < this.limiteAutomoviles)
        {
            this.automoviles.Add(automovil);
        }
    }

    public void MostrarAuto(Automovil automovil)
    {
        foreach(Automovil auto in this.automoviles)
        {
            if(auto.getId() == automovil.getId())
            {
                Console.WriteLine(auto.ToString());
                Console.WriteLine("______________________________________________");
                return;
            }
        }
    }

    public void EliminarAuto(Automovil automovil)
    {
        if(automovil != null)
        {
            foreach(Automovil auto in this.automoviles)
            {
                if(auto.getId() == automovil.getId())
                {
                    this.automoviles.Remove(auto);
                    Console.WriteLine("Auto eliminado");
                    return;
                }
            }
        }
    }

    public void MostrarAutos()
    {
        if(this.automoviles.Count() > 0)
        {
            foreach(Automovil auto in this.automoviles)
            {
                Console.WriteLine(auto.ToString());
            }
             Console.WriteLine("______________________________________________");

        }
        else
        {
            Console.WriteLine("No hay autos");
        }
    }

    public void VaciarConcesionaria()
    {
        this.automoviles.Clear();
    }

    public void setAutomoviles(List<Automovil> automoviles)
    {
        this.automoviles = automoviles;
    }

    public List<Automovil> getAutomoviles()
    {
        return this.automoviles;
    }

    public void setLimiteAutomoviles(int limiteAutomoviles)
    {
        this.limiteAutomoviles = limiteAutomoviles;
    }

    public int getLimiteAutomoviles()
    {
        return this.limiteAutomoviles;
    }

    public void setNumeroAutomoviles(int numeroAutomoviles)
    {
        this.numeroAutomoviles = numeroAutomoviles;
    }

    public int getNumeroAutomoviles()
    {
        return this.numeroAutomoviles;
    }
}