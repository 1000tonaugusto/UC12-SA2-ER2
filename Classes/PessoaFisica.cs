using er2.Interfaces;

namespace er2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        // Atributos
        public string ?cpf {get; set;}

        public DateTime ?dataNascumento {get; set;}

        // Metodos
        public bool validarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
        

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}