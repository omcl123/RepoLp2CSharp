﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Usuario
    {
        private int id;
        private string nickname;
        private string contrasena;
        private int _nroEntidad;
        private string _nombres;
        private string _aPaterno;
        private string _aMaterno;
        private string _email;
        private string _emailAlt;
        private Boolean _habilitado;
        private string direccion;
        private string dni;
        private string numeroTele;
        private int  _cargo;

        public Usuario()
        {

        }

        public int NroEntidad { get => _nroEntidad; set => _nroEntidad = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string APaterno { get => _aPaterno; set => _aPaterno = value; }
        public string AMaterno { get => _aMaterno; set => _aMaterno = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Habilitado { get => _habilitado; set => _habilitado = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NumeroTele { get => numeroTele; set => numeroTele = value; }
        public int Id { get => id; set => id = value; }
        public string EmailAlt { get => _emailAlt; set => _emailAlt = value; }
        public int Cargo { get => _cargo; set => _cargo = value; }
    }
}