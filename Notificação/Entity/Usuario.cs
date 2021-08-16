using Flunt.Notifications;
using Flunt.Validations;

namespace Notificação.Entity
{
    public class Usuario : Entity
    {

        public string Nome { get; private set; }

        public Endereco Endereco { get; set; }

        public Usuario(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(nome, nameof(Nome), "Nome não pode ser nulo")
                .IsNotNull(Endereco, nameof(Endereco), "Endereço não pode ser nulo")
                );

            if (Endereco != null)
                AddNotifications(Endereco.Notifications);

        }
    }
}
