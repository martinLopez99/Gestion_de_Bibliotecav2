using System;
using System.Net.Mail;
using System.Net;
using Gestion_de_Bibliotecav2.DAL;

namespace Gestion_de_Bibliotecav2.Dominio
{
    public class Notificacion
    {
        private int iID;
        private DateTime iFechaHoraEnvio;
        private Prestamo iPrestamo;
        //private readonly ISmtpClient smtpClient; // Cambiando a la interfaz MailKit


        public Notificacion(Prestamo pPrestamo) // Cambiando el tipo de parámetro
        {
            iFechaHoraEnvio = DateTime.Now;
            iPrestamo = pPrestamo;
        }

        public void EnviarNotificacionDeVencimiento(Usuario pUsuario)
        {
            // Verificar si el préstamo tiene un usuario asociado
            if (iPrestamo.Usuario != null)
            {
                // Cuerpo del correo
                string cuerpoCorreo = $"Hola {pUsuario.Nombre},\n\n" +
                                      $"Queremos recordarte que el préstamo con ID {iPrestamo.ID} está próximo a vencer.\n" +
                                      $"Detalles del préstamo:\n" +
                                      $"- Fecha de entrega: {iPrestamo.FechaEntrega}\n" +
                                      $"- Fecha de vencimiento: {iPrestamo.FechaVencimiento}\n" +
                                      $"- Libro prestado: {iPrestamo.Ejemplar.Libro.Nombre}\n\n" +
                                      $"No responder a este correo.\n\n" +
                                      $"Gracias por utilizar nuestra biblioteca.";
                String fromAddress = "Email...";
                String address = pUsuario.Email;

                SmtpClient email = new SmtpClient
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential(fromAddress, "Contraseña...")
                };

                String asunto = "Vencimiento de Prestamo";
                String body = cuerpoCorreo;

                try
                {
                    email.Send(fromAddress,address,asunto,body);
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine("Error al enviar el correo: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El préstamo no tiene un usuario asociado, no se puede enviar el correo.");
            }
        }

        // Getter para iFechaHoraEnvio
        public DateTime GetFechaHoraEnvio()
        {
            return iFechaHoraEnvio;
        }

        // Setter para iFechaHoraEnvio
        public void SetFechaHoraEnvio(DateTime fechaHoraEnvio)
        {
            iFechaHoraEnvio = fechaHoraEnvio;
        }

        // Getter para iPrestamo
        public Prestamo GetPrestamo()
        {
            return iPrestamo;
        }

        // Setter para iPrestamo
        public void SetPrestamo(Prestamo prestamo)
        {
            iPrestamo = prestamo;
        }

    }
}
