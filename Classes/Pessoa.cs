using er2.Interfaces;

namespace er2.Classes
{
    public abstract class Pessoa : IPessoa
    {

        // Atributos //
        public string ?nome {get; set;}

        public string ?endereco {get; set;}

        public float ?rendimento {get; set;}


        // Metodos //
        public abstract float PagarImposto(float rendimento);
    }
}