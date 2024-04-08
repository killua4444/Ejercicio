using System.Text;

namespace Tema9 {
class Circulo : Figura
{
    public int Radio { get; set; }

    public Circulo(int posX, int posY, string color, int radio) : base(posX, posY, color)
    {
        Radio = radio;
    }
        public override string QuienSoy()
        {
            this.quienSoy = "Soy una circulo";
            return base.QuienSoy();
        }
        public override string ToString()
        {
            StringBuilder texto = new();
            texto.AppendLine(base.ToString());
            texto.AppendLine($"Radio: {Radio}");
            return texto.ToString();
        }
        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
        //mostrar círculo en listado
        public string MostrarCirculo()
        {
            return ToString();
        }
        
    }
}