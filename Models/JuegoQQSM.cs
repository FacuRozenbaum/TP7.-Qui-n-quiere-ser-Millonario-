using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;


namespace QQSM.Models
{
    public static class JuegoQQSM
    {
        private static int _preguntaActual;
        private static char _respuestaCorrectaActual;
        private static int _posicionPozo;
        private static int _pozoAcumuladoSeguro;
        private static int _pozoAcumulado;
        private static bool _comidin50;
        private static bool _comidinDobleChance;
        private static bool _comodinSaltear;
        private static List<Pozo> _listaPozo = new List<Pozo>();
        private static Jugador _player;

        private static string _connectionString = @"Server=A-PHZ2-CIDI-043;DataBase=JuegoQQSM;Trusted_Connection=True;";

        public static Jugador IniciarJuego(string nombre)
        {
            _preguntaActual = 0;
            _respuestaCorrectaActual = '\0';
            _posicionPozo = 0;
            _pozoAcumuladoSeguro = 0;
            _pozoAcumulado = 0;
            _comidin50 = true;
            _comidinDobleChance = true;
            _comodinSaltear= true;
            _listaPozo = new List<Pozo>() {new Pozo (2000,false), new Pozo (5000,false), new Pozo (10000,false), new Pozo (20000,false), new Pozo (30000,true),new Pozo (50000,false),new Pozo (70000,false),new Pozo (100000,false),new Pozo (130000,false),new Pozo (180000,true),new Pozo (300000,false),new Pozo (500000,false),new Pozo (750000,false),new Pozo (1000000,false),new Pozo (2000000,true)};
            _player = new Jugador(-1, nombre, DateTime.Now, 0, true, true, true);

            string sql = "INSERT INTO Jugadores (nombre, fechaHora,pozoGanado,comidinDobleChance,comidin50,comodinSaltear) VALUES (@pNombre, @pFechaHora, @pPozoGanado, @pComidinDobleChance, @pComidin50, @pComodinSaltear)";
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                DB.Execute(sql, new{pNombre = _player.nombre, pFechaHora = _player.fechaHora, pPozoGanado = _player.pozoGanado, pComidinDobleChance = _player.comidinDobleChance, pComidin50 = _player.comidin50, pComodinSaltear = _player.comodinSaltear});
            }
            return _player;
        }

        public static Pregunta ObtenerProximaPregunta()
        {
            _preguntaActual++;
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Preguntas WHERE idPregunta = @pPreguntaActual";
                return DB.QueryFirstOrDefault<Pregunta>(sql,new{pPreguntaActual=_preguntaActual});
            }
        }

        public static List<Respuesta> ObtenerRespuestas()
        {
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Respuesta WHERE idPregunta = @pPreguntaActual";
                List<Respuesta> Respuestas = DB.Query<Respuesta>(sql,new{pPreguntaActual=_preguntaActual}).ToList();
                for(int i = 0; i<Respuestas.Count;i++)
                {
                    if(Respuestas[i].correcta == true)
                    {
                        _respuestaCorrectaActual = Respuestas[i].opcionRespuesta;
                    } 
                }
                return Respuestas;
            }
        }

        // public static Respuesta RespuestaUsuario(char Opcion, string OpcionComodin)
        // {
            

        // }

        public static List<Pozo> ListarPozo()
        {
            return _listaPozo;
        }
        public static int DevolverPosicionPozo ()
        {
            return _posicionPozo;
        }
        public static Jugador DevolverJugador()
        {
            return _player;

        }




    }
}