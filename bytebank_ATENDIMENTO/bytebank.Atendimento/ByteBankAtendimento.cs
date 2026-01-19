using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebankException;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
#nullable disable
    internal class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(123, "456789-0"){Saldo = 100, Titular = new Cliente{Cpf="11111", Nome ="Henrique"}},
            new ContaCorrente(321, "987654-0"){Saldo = 200, Titular = new Cliente{Cpf="22222", Nome ="Pedro"}},
            new ContaCorrente(213, "654321-0"){Saldo = 300, Titular = new Cliente{Cpf="33333", Nome ="Maria"}},
        };
        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                do
                {
                    Console.Clear();
                    Console.WriteLine("=====================");
                    Console.WriteLine("= Atendimento Cliente =");
                    Console.WriteLine("=== 1- Cadastrar conta ===");
                    Console.WriteLine("=== 2- Listar contas ===");
                    Console.WriteLine("=== 3- Remover conta ===");
                    Console.WriteLine("=== 4- Ordenar contas ===");
                    Console.WriteLine("=== 5- Pesquisar conta ===");
                    Console.WriteLine("=== 6- Sair ===");
                    Console.WriteLine("\n");
                    Console.Write("Digite uma opção: ");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception ex)
                    {

                        throw new ByteBankException(ex.Message);
                    }
                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção inválida, tente novamente.");
                            break;
                    }

                } while (opcao != '6');
            }
            catch (ByteBankException excecao)
            {

                Console.WriteLine($"{excecao.Message}");
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Obrigado por utilizar o ByteBank, até mais!");
            Console.ReadLine();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("= Pesquisar Contas =");
            Console.WriteLine("=====================");
            Console.WriteLine("\n");
            Console.Write("Insira 1 para pesquisar por NÚMERO DA CONTA, 2 para pesquisar por CPF DO TITULAR ou 3 para NÚMERO DA AGÊNCIA: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.Write("Informe o número da conta: ");
                        string numeoroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumConta(numeoroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do titular: ");
                        string cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCpfTitular(cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.Write($"Informe o número da Agência: ");
                        int numeroAgencia = int.Parse(Console.ReadLine());
                        var contasDaAgencia = ConsultaPorAgencia(numeroAgencia);
                        ExibirListaDeContas(contasDaAgencia);
                        Console.ReadLine();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada!");
                    break;

            }
        }

        private void ExibirListaDeContas(List<ContaCorrente> contasDaAgencia)
        {
            if (contasDaAgencia == null)
            {
                Console.WriteLine("Nenhuma conta encontrada para essa agência.");
            }
            else
            {
                foreach (ContaCorrente conta in contasDaAgencia)
                {
                    Console.WriteLine(conta.ToString());
                    Console.WriteLine("---------------------");
                }
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
                        from conta in _listaDeContas
                        where conta.Numero_agencia == numeroAgencia
                        select conta).ToList();
            return consulta;
        }

        private ContaCorrente ConsultaPorCpfTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for(int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf) )
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            //return conta;
            return _listaDeContas.Where(conta => conta.Titular.Cpf.Equals(cpf)).FirstOrDefault();
        }

        private ContaCorrente ConsultaPorNumConta(string? numeoroConta)
        {
            //ContaCorrente conta = null;
            //for(int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Conta.Equals(numeoroConta))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            return _listaDeContas.Where(conta => conta.Conta.Equals(numeoroConta)).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort(); //esse objeto conta corrente deveria implementar o IComparable, para definir a lógica de comparação com o Sort
            Console.WriteLine("Contas ordenadas com sucesso!");
            Console.ReadLine();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("= Remover Conta =");
            Console.WriteLine("=====================");
            Console.WriteLine("\n");
            Console.Write("Insira o número da conta que deseja remover: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente contaCorrente = null;
            foreach (ContaCorrente conta in _listaDeContas)
            {
                if (conta.Conta.Equals(numeroConta))
                {
                    contaCorrente = conta;
                }
            }
            if (contaCorrente != null)
            {
                _listaDeContas.Remove(contaCorrente);
                Console.WriteLine($"Conta {contaCorrente} removida com sucesso!");
            }
            else
            {
                Console.WriteLine($"Conta {contaCorrente} não encontrada.");
            }
            Console.ReadLine();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("= Cadastrar Conta =");
            Console.WriteLine("=====================");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                Console.ReadLine();
                return;
            }
            foreach (ContaCorrente conta in _listaDeContas)
            {
                //Console.WriteLine($"Número da Conta: {conta.Conta}, Agência: {conta.Numero_agencia}, Titular: {conta.Titular.Nome}, Saldo: {conta.Saldo}");
                Console.WriteLine(conta.ToString());
                Console.WriteLine("---------------------");
                Console.ReadLine();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("= Cadastrar Conta =");
            Console.WriteLine("=====================");
            Console.WriteLine("\n");
            Console.Write("Informe os dados da conta: ");

            Console.Write("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente novaConta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da nova conta: {novaConta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            novaConta.Saldo = double.Parse(Console.ReadLine());
            Console.Write("Informe nome do titular: ");
            novaConta.Titular.Nome = Console.ReadLine();
            Console.Write("Informe CPF do titular: ");
            novaConta.Titular.Cpf = Console.ReadLine();
            Console.Write("Informe Profissão do titular: ");
            novaConta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(novaConta);
            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadLine();
        }
    }
}
