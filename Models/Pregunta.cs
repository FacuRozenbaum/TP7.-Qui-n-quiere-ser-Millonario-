using System;

namespace QQSM.Models
{ 
    public class Pregunta
    {
        private int _idPregunta;
        private string _textoPregunta;
        private int _nivelDificultad;
        public Pregunta(int idPregunta, string textoPregunta, int nivelDificultad)
        {
            _idPregunta = idPregunta;
            _textoPregunta = textoPregunta;
            _nivelDificultad = nivelDificultad;
        }
        public Pregunta(){}
        public int idPregunta
        {
            get {return _idPregunta;}
            set{_idPregunta = value;}
        }
          public string textoPregunta
        {
            get {return _textoPregunta;}
             set{_textoPregunta = value;}
        }
          public int nivelDificultad
        {
            get {return _nivelDificultad;}
             set{_nivelDificultad = value;}
        }
    }
}