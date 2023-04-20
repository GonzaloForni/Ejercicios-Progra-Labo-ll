using System.Runtime.InteropServices;

namespace Cartuchera
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor() { return this.color; }

        public short GetTinta() { return this.tinta; }

        private void SetTinta(short tinta)
        {
            short tintaResultante;

            tintaResultante = (short)(this.tinta + tinta);

            if(tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar()
        {
            short tintaFaltante = (short)(100 - this.tinta);

            this.SetTinta(tintaFaltante);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool comprobante = false;
            dibujo = "";

            if (gasto > 0 && this.tinta >= gasto)
            {
                this.SetTinta((short)(0 - gasto));
                comprobante = true;
                
                for (int i = 0; i < gasto; i++) { dibujo += "*"; }
            }

            return comprobante;
        }
    }
}