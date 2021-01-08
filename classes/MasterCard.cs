namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        //ATRIBUTOS PRÓPRIOS DA SUBCLASSE MASTERCARD
        private int parcelas;

        //ACESSADOR
        public int Parcelas
        {
            get {return parcelas;}
            set {parcelas = value;}
        }



        //MÉTODOS PRÓRPIOS DA SUBCLASSE
        public string ComprarComDesconto(){
            return "";
        }

        

    }
}