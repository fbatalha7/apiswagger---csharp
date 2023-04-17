namespace apinetcore.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set;}
        public static List<Clientes> Mylist { get; set; }

        public static List<Clientes> Getclients()
        {
            List<Clientes> lista = new List<Clientes>();

            if (Mylist == null || Mylist.Count == 0)
            {
                lista.Add(new Clientes { Idade = 22, Nome = "Felipe", Id = 1 });
                lista.Add(new Clientes { Idade = 22, Nome = "Felipe", Id = 2 });
            }

            if (Mylist == null)
                Mylist = lista;


            return Mylist;
        }
    }
}
