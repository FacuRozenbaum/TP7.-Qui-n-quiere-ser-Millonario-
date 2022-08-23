using System;

namespace QQSM.Models
{ 
    public class Respuesta
    {
        private int _idRespuesta;
        private int _idPregunta;
        private char _opcionRespuesta;
        private string _textoRespuesta;
        private bool _correcta;
        public Respuesta(int idRespuesta, int idPregunta, char opcionRespuesta, string textoRespuesta, bool correcta)
        {
            _idRespuesta = idRespuesta;
            _idPregunta = idPregunta;
            _opcionRespuesta = opcionRespuesta;
            _textoRespuesta = textoRespuesta;
            _correcta = correcta;
        }
        public Respuesta(){}

         public int idRespuesta
        {
            get {return _idRespuesta;}
            set{_idRespuesta = value;}
        }
        public int idPregunta
        {
            get {return _idPregunta;}
            set{_idPregunta = value;}
        }
          public char opcionRespuesta
        {
            get {return _opcionRespuesta;}
             set{_opcionRespuesta = value;}
        }
        public string textoRespuesta
        {
            get {return _textoRespuesta;}
            set{_textoRespuesta = value;}
        }
         public bool correcta
        {
            get {return _correcta;}
            set{_correcta = value;}
        }


    }
}