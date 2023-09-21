using System;

namespace TesteRedeService
{
	internal class clsTeste
	{
        public decimal codigo { get; set; }
        public string descricao { get; set; }

        public clsTeste(decimal codigo)
        {
            this.codigo = codigo;
            descricao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
