using System;

namespace QQSM.Models
{ 
    public class Jugador
    {
        private int _idJugador; 
        private string _nombre;
        private DateTime _fechaHora;
        private int _pozoGanado;
        private bool _comidinDobleChance;
        private bool _comidin50;
        private bool _comodinSaltear;
        public Jugador(int idJugador, string nombre, DateTime fechaHora, int pozoGanado, bool comidinDobleChance, bool comidin50, bool comodinSaltear)
        {
            _idJugador = idJugador;
            _nombre = nombre;
            _fechaHora = fechaHora;
            _pozoGanado = pozoGanado;
            _comidinDobleChance = comidinDobleChance;
            _comidin50 = comidin50;
            _comodinSaltear = comodinSaltear;
        }
        public Jugador(){}

         public int idJugador
        {
            get {return _idJugador;}
            set{_idJugador = value;}
        }
        public string nombre
        {
            get {return _nombre;}
            set{_nombre = value;}
        }
          public DateTime fechaHora
        {
            get {return _fechaHora;}
            set{_fechaHora = value;}
        }
        public int pozoGanado
        {
            get {return _pozoGanado;}
            set{_pozoGanado = value;}
        }
        public bool comidinDobleChance
        {
            get {return _comidinDobleChance;}
            set{_comidinDobleChance = value;}
        }
        public bool comidin50
        {
            get {return _comidin50;}
            set{_comidin50 = value;}
        }
        public bool comodinSaltear
        {
            get {return _comodinSaltear;}
            set{_comodinSaltear = value;}
        }


    }
}