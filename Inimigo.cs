namespace Mentoria_3
{
    public class Inimigo : Heroi
    {

        
        public Inimigo(string nome, string ClasseFantastica) : base(nome, ClasseFantastica)
        {

            this.Nome = nome;
            PontosDeVida =150;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel=1;
            this.PontosDeMagia=0;
        }

        public override string Atacar()
        {   Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,15);
            this.ValorUltimoAtaque = forcaDoAtaque;
            return  this.Nome + " Ataca com sua garra  e dá " + forcaDoAtaque + " de dano \n";
        }

        

    }
}