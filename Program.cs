// See https://aka.ms/new-console-template for more information

 namespace Mentoria_3
{
    class Program
    {

         static void Main(String[]args)
        {

            Heroi heroi = new Heroi("Arus","heroi");
            
            Inimigo mumia = new Inimigo("Faraó", "morto-vivo");
            
            
            //System.Console.WriteLine(heroi.ToString()); // metodo ToString() retorna o namespace
            // OBS: digitar --> System.Console.WriteLine(heroi) // é o mesmo que escrever heroi.ToString().. 
            //ToString() é um metodo padrão, invocado sozinh oquando vc nao chama nenhum outro metodo

            

            System.Console.WriteLine(" A quantidade de pontos de vida do "+ heroi.Nome + " é: " +  heroi.PontosDeVida);
            System.Console.WriteLine(" A quantidade de pontos de vida do "+ mumia.Nome + " é: " +  mumia.PontosDeVida + "\n \n") ;
            


            System.Console.WriteLine(heroi.Atacar());
            System.Console.WriteLine(mumia.Atacar()); 
            
            while (heroi.PontosDeVida>0 && mumia.PontosDeVida>0)
            {
    
                if (heroi.ValorUltimoAtaque == mumia.ValorUltimoAtaque) 
                {
                    System.Console.WriteLine("\nEMPATE!!! ambos deram dano de :  \n \n"+ heroi.ValorUltimoAtaque );
                    
                    System.Console.WriteLine(heroi.Atacar());
                    System.Console.WriteLine(mumia.Atacar()); 
                } else if ( (heroi.ValorUltimoAtaque > mumia.ValorUltimoAtaque) && (heroi.PontosDeVida > 0 && mumia.PontosDeVida > 0) )
                        {
                                mumia.ReceberDano(heroi.ValorUltimoAtaque - mumia.ValorUltimoAtaque);
                                System.Console.WriteLine(heroi.Nome  + "  venceu esse round!"); 

                                if(mumia.PontosDeVida <= 0) 
                                {
                                    System.Console.WriteLine("\n\n" + heroi.Nome + " VENCEU A BATALHA! A MÚMIA MORREU!!!");
                                    break;
                                } else{
                                        System.Console.WriteLine("--> A quantidade de pontos de vida do "+ heroi.Nome + " é: " +  heroi.PontosDeVida);
                                        System.Console.WriteLine("--> A quantidade de pontos de vida do "+ mumia.Nome + " é: \n \n" +  mumia.PontosDeVida);
                
                                        System.Console.WriteLine(heroi.Atacar());
                                        System.Console.WriteLine(mumia.Atacar()); 
                        }
                
                
                } else
                    {
                     heroi.ReceberDano(mumia.ValorUltimoAtaque - heroi.ValorUltimoAtaque);
                     System.Console.WriteLine(mumia.Nome  + "  venceu esse round!\n");  
                        if (heroi.PontosDeVida <= 0)  
                        {     
                            System.Console.WriteLine(" \n\n FIM DA BATALHA !!! A MÚMIA VENCEU!!!"); 
                            break;   
                        } else 
                             {
                                System.Console.WriteLine("--> A quantidade de pontos de vida do "+ heroi.Nome + " é: " +  heroi.PontosDeVida);
                                System.Console.WriteLine("--> A quantidade de pontos de vida do "+ mumia.Nome + " é: \n \n" +  mumia.PontosDeVida);

                
                                System.Console.WriteLine(heroi.Atacar());
                                System.Console.WriteLine(mumia.Atacar()); 
                             }  
                    }
            }// fecha laço while

            
            




            






        }   




    }

}
 

