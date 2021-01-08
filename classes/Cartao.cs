namespace AulaPOO_Encapsulamento.classes
{
    public class Cartao
    {

        //ATRIBUTOS DA SUPERCLASSE
        private string numero;
        private string bandeira = "MasterCard";
        protected string token = "qwertyui";
        private string cvv = "596";
        protected float limiteDeSaldo = 5000;

        //ACESSADORES DA SUPERCLASSE 
        //são respossáveis por restringir o acesso dos atributos definidos com get (coletar) e set (enviar), o uso dos mesmos não precisam ser juntos, ambos funcionam de maneira distinta ao serem configurados, dependendo apenas da necessidade do sistema

        public string Numero
        {
            set {numero = value;} //neste caso, estou deixando o usuário definir a informação e a ENVIE para o sistema (CARTÃO)
            get {return numero;} //neste caso, estou permintindo ao sistema que ele também é capaz de exibir o numero do cartão, caso deseje (Program)
        }

        public string Bandeira
        {
            get {return bandeira;}
        }

        public string Token
        {
            get {return token;}
        }

        public string Cvv
        {
            set{cvv = value;}
        }

        public float LimiteDeSaldo
        {
            get {return limiteDeSaldo;}
        }


        //MÉTODOS DA SUPERCLASSE
        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo)
        {
            return true;
        }

        protected string ValidarToken(string codigo){
            
            if (codigo == token)
            {
        
            }else
            {
                System.Console.WriteLine("Código inválido");
            }


            return codigo; // COMO ACESSAR DA CLASSE HERDADA?
        }
    }
}