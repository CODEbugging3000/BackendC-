namespace ClientControlSystem
{
    class Clientes
    {
        public string Nome {get; set;}
        public string Endereco {get; set;}

        //Os atributos no vídeo estão com o set como protected porém o código não estava funcionando corretamente então troquei para public
        //e funcionou ¯\_(ツ)_/¯
        public float Valor {get; set;}
        public float Valor_imposto {get; set;}
        public float Total {get; set;}
        public virtual void Pagar_Imposto(float v)
            {
                this.Valor = v;
                this.Valor_imposto = this.Valor * 10 / 100;
                this.Total = this.Valor + this.Valor_imposto;
            }
    }
}
