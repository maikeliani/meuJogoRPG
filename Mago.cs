namespace Mentoria_3
{
    public class Mago : Heroi
    {
        public Mago(string nome, string ClasseFantastica) : base(nome, ClasseFantastica)
        {
        }

        public override string Atacar()
        {   Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,10);
            this.ValorUltimoAtaque = forcaDoAtaque;
            return  this.Nome + " Ataca com seu cajado e dá " + forcaDoAtaque + " de dano";
        }


        public  string Atacar(int bonus)
        {   Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,10)+bonus;
            this.ValorUltimoAtaque = forcaDoAtaque;
            
            return  this.Nome + " Ataca com bonus com seu cajado e dá " + forcaDoAtaque + " de dano";
        }


         


    }
}