using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Clases_Validacion
{
    public static class Validaciones
    {
        //Metodo para validar cadena de caracteres de ingreso
        //Con ref se trabaja por referencia a la variable
        public static bool ValidarCadena(ErrorProvider Error, TextBox textBox, ref bool estado)
        {
            estado = true;

            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[a-zA-Z éáóíú]*$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(textBox.Text))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese sólo letras y espacios.");
                    estado = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return estado;
        }

        public static bool ValidarNombreCompleto(ErrorProvider Error, TextBox textBox, ref bool estado)
        {
            estado = true;

            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[a-zA-Z éáóíú]*$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(textBox.Text) || !(textBox.Text.Length >= 3 && textBox.Text.Length <= 70))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese sólo entre 3 y 70 letras y espacios.");
                    estado = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return estado;
        }

        //Validacion para los ingresos de DNI
        public static bool ValidarDNI(ErrorProvider Error_dni, TextBox textBox_dni, ref bool estado)
        {
            estado = true;
            if (textBox_dni.Text == string.Empty)
            {
                Error_dni.SetError(textBox_dni, "Campo Vacío.");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[0-9]*$", RegexOptions.IgnoreCase);
                if (textBox_dni.TextLength != 8 || !texto.IsMatch(textBox_dni.Text))
                {
                    Error_dni.Clear();
                    Error_dni.SetError(textBox_dni, "Ingrese sólo 8 caracteres numéricos.");
                    estado = false;
                }
                else
                {
                    Error_dni.SetError(textBox_dni, "");
                }
            }
            return estado;
        }
        public static void ValidarStock(ErrorProvider Error, TextBox textStock, TextBox textStockMinimo)
        {
            if (textStock.Text == string.Empty || textStockMinimo.Text == string.Empty)
            {
                Error.SetError(textStock, "Uno de los Campos Stock está Vacío.");
                Error.SetError(textStockMinimo, "Uno de los Campos Stock está Vacío.");
            }
            else
            {
                if (!(Information.IsNumeric(textStock.Text) && Information.IsNumeric(textStockMinimo.Text)))
                {
                    Error.Clear();
                    Error.SetError(textStock, "Uno de los Campos Stock no tiene un valor entero.");
                    Error.SetError(textStockMinimo, "Uno de los Campos Stock no tiene un valor entero.");
                }
                else
                {
                    var num1 = Int32.Parse(textStock.Text);
                    var num2 = Int32.Parse(textStockMinimo.Text);
                    if (!(num1 >= num2))
                    {
                        Error.Clear();
                        Error.SetError(textStock, "Stock debe ser mayor o igual que el Stock Mínimo.");
                        Error.SetError(textStockMinimo, "Stock Mínimo debe ser menor o igual que el Stock.");
                    }
                    else
                    {
                        Error.Clear();
                        Error.SetError(textStock, "");
                        Error.SetError(textStockMinimo, "");
                    }
                }

            }
        }
        public static bool ValidarCaracterCad(ErrorProvider Error, TextBox textBox, ref bool estado)
        {
            estado = true;
            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo vacío");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[0-9a-zA-Z ,./éáóíú°-]*$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(textBox.Text))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese una cadena de caracteres válida");
                    estado = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return estado;
        }

        public static bool ValidarClave(ErrorProvider Error, TextBox textBox, ref bool estado)
        {
            estado = true;
            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                estado = false;
            }
            else
            { 
                if (textBox.Text.Length < 5)
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese una cadena de mínimo 5 caracteres");
                    estado = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return estado;
        }

        public static bool ValidarNumeroEntero(ErrorProvider Error, TextBox textBox, ref bool estado)
        {
            estado = true;
            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                estado = false;
            }
            else
            {
                if (!Information.IsNumeric(textBox.Text))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese un valor entero válido.");
                    estado = false;
                }
                else
                {
                    var num = Int32.Parse(textBox.Text);
                    if (num == 0)
                    {
                        Error.Clear();
                        Error.SetError(textBox, "No es posible ingresar 0");
                        estado = false;
                    }
                    else
                    {
                        Error.SetError(textBox, "");
                    }
                }
            }
            return estado;
        }

        public static bool ValidarDecimal(ErrorProvider Error, TextBox textBox, ref bool b_decimal)
        {
            b_decimal = true;
            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                b_decimal = false;
            }
            else
            {
                var texto = new Regex(@"^[0-9]+([\,|\.]{0,1}[0-9]{2}){0,1}$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(textBox.Text))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese un valor decimal válido.");
                    b_decimal = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return b_decimal;
        }

        public static bool validarPrecio(ErrorProvider p_Error, TextBox p_PrecioCompra, TextBox p_PrecioVenta, ref bool estado)
        {
            estado = true;
            if (p_PrecioCompra.Text == string.Empty || p_PrecioVenta.Text == string.Empty)
            {
                p_Error.SetError(p_PrecioCompra, "Uno de los campos de precio esta vacío");
                p_Error.SetError(p_PrecioVenta, "Uno de los campos de precio esta vacío");
                estado = false;
            }
            else
            {
                var texto = new Regex(@"^[0-9]+([\,|\.]{0,1}[0-9]{0,2}){0,1}$", RegexOptions.IgnoreCase);
                //var texto = new Regex(@"\d+(,\d{1,2})?", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(p_PrecioCompra.Text))
                {
                    p_Error.Clear();
                    p_Error.SetError(p_PrecioCompra, "El valor ingresado no corresponde a decimal.");
                    estado = false;
                }
                else
                {
                    if (!texto.IsMatch(p_PrecioVenta.Text))
                    {
                        p_Error.Clear();
                        p_Error.SetError(p_PrecioVenta, "El valor ingresado no corresponde a decimal.");
                        estado = false;
                    }
                    else
                    {
                        if (!texto.IsMatch(p_PrecioCompra.Text))
                        {
                            p_Error.Clear();
                            p_Error.SetError(p_PrecioCompra, "El valor ingresado no corresponde a decimal.");
                            estado = false;
                        }
                        else
                        {
                            var venta = Decimal.Parse(p_PrecioVenta.Text);
                            var compra = Decimal.Parse(p_PrecioCompra.Text);
                            if (!(venta >= compra))
                            {
                                p_Error.Clear();
                                p_Error.SetError(p_PrecioVenta, "El precio de venta debe ser mayor o igual al precio de compra");
                                p_Error.SetError(p_PrecioCompra, "El precio de compra debe ser menor o igual al precio de venta");
                                estado = false;
                            }
                            else
                            {
                                p_Error.Clear();
                                p_Error.SetError(p_PrecioVenta, "");
                                p_Error.SetError(p_PrecioCompra, "");
                                estado = true;
                            }
                        }

                    }
                }
            }
            return estado;
        }


        //Validación para ingreso de email
        public static bool ValidarEmail(ErrorProvider Error_email, TextBox textBox_email, ref bool estado)
        {
            estado = true;
            if (textBox_email.Text == string.Empty)
            {
                Error_email.SetError(textBox_email, "Campo Vacío.");
                estado = false;
            }
            else
            {
                var texto = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(textBox_email.Text))
                {
                    Error_email.Clear();
                    Error_email.SetError(textBox_email, "Ingrese un correo electrónico válido.");
                    estado = false;
                }
                else
                {
                    Error_email.SetError(textBox_email, "");
                }
            }

            return false;
        }

        //Validacion de ingreso de telefono
        public static bool ValidarTelefono(ErrorProvider Error, TextBox textBox, ref bool b_telefono)
        {
            b_telefono = true;
            if (textBox.Text == string.Empty)
            {
                Error.SetError(textBox, "Campo Vacío.");
                b_telefono = false;
            }
            else
            {
                var texto = new Regex("^[0-9]*$", RegexOptions.IgnoreCase);
                if (textBox.TextLength != 10 || !texto.IsMatch(textBox.Text))
                {
                    Error.Clear();
                    Error.SetError(textBox, "Ingrese sólo 10 caracteres numéricos.");
                    b_telefono = false;
                }
                else
                {
                    Error.SetError(textBox, "");
                }
            }
            return b_telefono;
        }
        public static bool ValidarCUIL(ErrorProvider Error_cuil, TextBox textBox_cuil, ref bool estado)
        {
            estado = true;
            if (textBox_cuil.Text == string.Empty)
            {
                Error_cuil.SetError(textBox_cuil, "Campo Vacío.");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[0-9]*$", RegexOptions.IgnoreCase);
                if (textBox_cuil.TextLength != 11 || !texto.IsMatch(textBox_cuil.Text))
                {
                    Error_cuil.Clear();
                    Error_cuil.SetError(textBox_cuil, "Ingrese sólo 11 caracteres numéricos.");
                    estado = false;
                }
                else
                {
                    Error_cuil.SetError(textBox_cuil, "");
                }
            }
            return estado;
        }

        //Validacón para la selección de comboBox
        public static bool ValidarComboBox(ErrorProvider p_Error, ComboBox p_comboBox, ref bool estado)
        {
            estado = true;
            if (p_comboBox.Text == string.Empty)
            {
                p_Error.SetError(p_comboBox, "No se seleccionó una opción válida.");
                estado = false;
            }
            else
            {
                var texto = new Regex("^[a-zA-Z éáóíú]*$", RegexOptions.IgnoreCase);
                if (!texto.IsMatch(p_comboBox.Text))
                {
                    p_Error.Clear();
                    p_Error.SetError(p_comboBox, "Seleccione una de las opciones válidas.");
                    estado = false;
                }
                else
                {
                    p_Error.SetError(p_comboBox, "");
                }
            }

            return estado;
        }

        public static void LimpiarProvider(ErrorProvider p_Error, Control p_control)
        {
            p_Error.SetError(p_control, "");
        }

        public static void LimpiarProviderV2(ErrorProvider p_Error, Control p_control, Control p_control2)
        {
            p_Error.SetError(p_control, "");
            p_Error.SetError(p_control2, "");
        }
    }
}
