using System;

namespace maquinaCafe.classe
{
    public class MaquinaCafe
    {
        //Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?
        public int acucarDisponivel;

        //Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.
        public string FazerCafe(){
            return "";
        }

        public int FazerCafe(int cafe){
            this.acucarDisponivel = acucarDisponivel - cafe;
            
            if (acucarDisponivel > 0)
            {
                Console.WriteLine("Quantidade de açucar verificada... Fazendo café");
            }else{
                 Console.WriteLine("Esta quantidade de açucar esta indisponivel, seu café será sem açucar");
                
            }
            return acucarDisponivel;
            
            

        }
    }
}