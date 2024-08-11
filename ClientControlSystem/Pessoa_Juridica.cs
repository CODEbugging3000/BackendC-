namespace ClientControlSystem
{
    class Pessoa_Juridica : Clientes
    {
        public string CNPJ {get; set;}
        public string IE {get; set;}
        public override void Pagar_Imposto(float v)
            {
                this.Valor = v;
                this.Valor_imposto = this.Valor * 20 / 100;
                this.Total = this.Valor + this.Valor_imposto;
            }
    }
}
