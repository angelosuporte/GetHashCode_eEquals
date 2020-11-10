namespace GetHashCode_eEquals.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        //Precisa implementar GetHashCode e Equals porque quando o tipo é class ele compara por referencia de memória. Com a implementação abaixo 
        //será possível comparar o conteúdo

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Produto))
            {
                return false;
            }
            Produto outro = obj as Produto;
            return Nome.Equals(outro.Nome) && Preco.Equals(outro.Preco);
        }
    }
}
