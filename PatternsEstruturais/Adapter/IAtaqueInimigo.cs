using System;

namespace Adapter
{
    public interface IAtaqueInimigo
    {
        void ArmaFogo();
        void Movimenta();
        void Pilotar(String piloto);
    }
}
