namespace Biblioteca
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno;
            dibujo = "";
            if (this.GetTinta() == 0)
            {
                retorno = false;
            }
            else
            {
                for (int i = 0; i < gasto; i++)
                {
                    if (this.GetTinta() != 0)
                    {
                        this.SetTinta(-1);
                        dibujo += "*";
                    }
                }
                Console.ForegroundColor = this.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                retorno = true;
            }

            return retorno;
        }

        public void Recargar()
        {
            short tintaCargar = (short)(cantidadTintaMaxima - this.tinta);

            this.SetTinta(tintaCargar);
        }

        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta <= cantidadTintaMaxima || this.tinta - tinta >= 0)
            {
                this.tinta += tinta;
            }
        }
    }
}