/*
 * @fileoverview    {Autenticacion} se encarga de realizar tareas específicas.
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code Autenticacion}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Autenticacion {

        [Key]
        public String? StrUsuario { get; set; }
        public String? StrContrasena { get; set; }

    }

}