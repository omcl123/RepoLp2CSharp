﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Grupo
    {
        private int _id;
        private string _nombre;
        private Permiso _permiso;
        private BindingList<Usuario> listaUsuarios;

        public Grupo()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public BindingList<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public Permiso Permiso { get => _permiso; set => _permiso = value; }
    }
}