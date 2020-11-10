namespace GetHashCode_eEquals.Entities
{
    struct Ponto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ponto(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        //Não precisa implementar GetHashCode e Equals porque quando o tipo é struct ele compara por conteúdo
    }
}
