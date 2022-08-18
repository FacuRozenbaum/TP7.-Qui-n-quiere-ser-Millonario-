using System;

namespace QQSM.Models
{ 
    public class Pozo
    {
        private int _importe; 
        private bool _valorSeguro;
        public Pozo(int importe, bool valorSeguro)
        {
            _importe = importe;
            _valorSeguro = valorSeguro;
        }

        public int importe
        {
            get {return _importe;}
            set{_importe = value;}
        }
        public bool valorSeguro
        {
            get {return _valorSeguro;}
            set{_valorSeguro = value;}
        }

    }
}