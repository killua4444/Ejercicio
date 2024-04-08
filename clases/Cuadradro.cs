using System.Text;

namespace Tema9 {
class Cuadrado : Figura
{
    public double Lado { get; set; }

    public Cuadrado(int posX, int posY, string color, double lado) : base(posX, posY, color)
    {
        Lado = lado;
    }
        public override string QuienSoy()
        {
            this.quienSoy = "Soy una cuadrado";
            return base.QuienSoy();
        }
        public override string ToString()
        {
            StringBuilder texto = new();
            texto.AppendLine(base.ToString());
            texto.AppendLine($"Lado: {Lado}");
            return texto.ToString();
        }
        public override double Area()
        {
            return Lado * Lado;
        }
        public double Perimetro()
        {
            return Lado * 4;
        }
        
    }
}