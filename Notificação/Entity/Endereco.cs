using Flunt.Notifications;
using Flunt.Validations;

namespace Notificação.Entity
{
    public class Endereco : ViewObject
    {     
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }

        public Endereco(string rua, string bairro, string numero, string complemento)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(rua, nameof(Rua), "Rua não pode ser nula")
                .IsNotNullOrEmpty(bairro, nameof(Bairro), "Bairro não pode ser nula")
                .IsNotNullOrEmpty(numero, nameof(Numero), "Rua não pode ser nula"));
        }

    }
}
