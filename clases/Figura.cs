using System.Text;

namespace Tema9 {
    public abstract class Figura(int posX, int posY, string color)
    {
        protected String quienSoy = "Soy una figura";
        // Automatic properties
        public int PosicionX { get; set; } = posX;
        public int PosicionY { get; set; } = posY;
        public string Color { get; set; } = color;

        public virtual string QuienSoy()
        {
            return quienSoy;
        }
        public override string ToString()
        {
            StringBuilder texto = new();
            texto.Append("Posición X: ");
            texto.Append(PosicionX);
            texto.Append(System.Environment.NewLine);
            texto.Append("Posición Y: ");
            texto.Append(PosicionY);
            texto.Append(System.Environment.NewLine);
            texto.Append("Color: ");
            texto.Append(Color);
            return texto.ToString();
        }
        public abstract double Area();
    }
}