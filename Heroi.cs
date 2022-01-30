namespace Mentoria_3
{
    public class Heroi
    {


        public Heroi(string nome, string ClasseFantastica)
        {
            this.Nome = nome;
            PontosDeVida = 100;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeMagia = 50;   

           }



           
                public string Nome { get; set; }
        public int PontosDeVida { get; set; }

        public string ClasseFantastica { get; set; }

        public int Nivel { get; set; }
        public int PontosDeMagia { get; set; }
        public int ValorUltimoAtaque { get; set; }



        public override string ToString()
        {
            return "Meu nome é" + this.Nome + "\n"
            + "Meu nível é: " + this.Nivel + "\n"
            + " Minha classe é: " + this.ClasseFantastica + "\n"
            + "  meus total de pontos de vida é: " + this.PontosDeVida + "\n"
            + " meus total de pontos de magia: " + this.PontosDeMagia;


        }


        public virtual string Atacar() // virtual significa que pode ser herdado
        {

            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 20);
            this.ValorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca com sua espada e dá " + forcaDoAtaque + " de dano \n";

        }

        public virtual void ReceberDano(int danoRecebido)
        {
            this.PontosDeVida -= danoRecebido;

        }


    }
}