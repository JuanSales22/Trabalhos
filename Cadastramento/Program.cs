using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace trabalhomenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continua = true;
            List<Cadastros> listaPessoa = new List<Cadastros>();
            do
            {

                Console.WriteLine("--------Menu de cdastro--------");
                Console.WriteLine(" 01 - Incluir");
                Console.WriteLine(" 02 - Alterar");
                Console.WriteLine(" 03 - Excluir");
                Console.WriteLine(" 04 - Listar");
                Console.WriteLine(" 05 - Pesquisar");
                Console.WriteLine(" 09 - Sair ");
                Console.WriteLine("Digite sua opção:");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "01":
                        List<Cadastros> Cadastro = new List<Cadastros>();
                        Console.WriteLine("Cadastro de pessoa");
                        Console.Write("Nome");
                        string nome = Console.ReadLine();
                        Console.Write("Apelido");
                        string apelido = Console.ReadLine();
                        Console.Write("ID");
                        int id =  int.Parse(Console.ReadLine());

                        listaPessoa.Add(new Cadastros(nome, apelido, id));
               
                        break;



                    case "02":
                        Console.WriteLine("Alterar");
                        Console.WriteLine("Digite o ID que deseja alterar: ");
                        int altereID = int.Parse(Console.ReadLine());
                        Cadastros alter = listaPessoa.Find(x => x.ID == altereID);
                        if (alter != null)
                        {
                            Console.WriteLine($" Nome:{alter.Nome}");
                            Console.WriteLine($" Apelido:{alter.Apelido}");
                            Console.WriteLine($" ID:{alter.ID}");
                            Console.WriteLine("Digite a nova ID: ");
                            int novoID = int.Parse(Console.ReadLine());
                            alter.ID = novoID;
                       
                        }
                        else
                        {
                            Console.WriteLine("Valor não encontrado!");
                        }
                        break;

                    case "03":
                        Console.WriteLine("Excluir");
                        Console.WriteLine("Digite o ID que deseja excluir: ");
                        int excluirID = int.Parse(Console.ReadLine());
                        Cadastros exclu = listaPessoa.Find(x => x.ID == excluirID);
                        if (excluirID != null)
                        {
                            Console.WriteLine($" Nome:{exclu.Nome}");
                            Console.WriteLine($" Apelido:{exclu.Apelido}");
                            Console.WriteLine($" ID:{exclu.ID}");
                            Console.WriteLine("Deseja excluir esta id? Digite  (s) para sim e (n) para não. ");
                            string simnao = Console.ReadLine();
                            switch(simnao)
                            {
                                case "s":
                                    listaPessoa.Remove(exclu);
                                    Console.WriteLine("Removido com sucesso!! ");
                                    break;
                                case "n":
                                    break;


                            }

                        }
                        else
                        {
                            Console.WriteLine(" ID não encontrada! ");
                        }
                        break;

                    case "04":

                        Console.WriteLine("Listar");

                        foreach(Cadastros listar in listaPessoa)
                        {

                            Console.WriteLine($" Nome: {listar.Nome} ");
                            Console.WriteLine($" Apelido: {listar.Apelido} ");
                            Console.WriteLine($" ID: {listar.ID} ");

                        }


                        break;





                    case "05":
                        Console.WriteLine("Pesquisar");

                        Console.WriteLine("Coloque o ID a ser mostrado: ");
                        int pesquisaID = int.Parse(Console.ReadLine());
                        Cadastros pesq = listaPessoa.Find(x => x.ID == pesquisaID);
                        if (pesq != null)
                        {

                            Console.WriteLine($" Nome: {pesq.Nome} ");
                            Console.WriteLine($" Apelido: {pesq.Apelido} ");
                            Console.WriteLine($" ID: {pesq.ID} ");
                        }
                        else
                        {
                            Console.WriteLine("Este ID não existe no sistema!!");
                        }

                        break;


                    case "06":
                        Console.WriteLine("Sair");

                        Environment.Exit(06);
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("opcão nao existente.");
                        break;

                }
            } while (continua);

        }

    }

}