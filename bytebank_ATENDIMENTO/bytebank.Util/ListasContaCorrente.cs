using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListasContaCorrente
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public ListasContaCorrente(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void AdicionarConta(ContaCorrente conta)
        {
            Console.WriteLine($"Adicionar item na próxima posição {_proximaPosicao}");
            VerificarCapacidadeArray(_proximaPosicao + 1);
            _itens[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        private void VerificarCapacidadeArray(int tamanho)
        {
            if (_itens.Length >= tamanho)
            {
                return;
            }
            Console.WriteLine($"Aumentando capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void RemoverConta(ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }
            if (indiceItem == -1)
            {
                return;
            }
            Console.WriteLine($"Removendo item na posição {indiceItem}");
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }
        public void ExibirLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    ContaCorrente contaAtual = _itens[i];
                    Console.WriteLine($"Conta na posição {i}: Agência {contaAtual.Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperarItemIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        public int Tamanho 
        { 
            get
            {
                return _proximaPosicao;
            }
        }
        public ContaCorrente this[int indice] //tornou a clasee indexavel
        {
            get
            {
                return RecuperarItemIndice(indice);
            }
        }
    }
}
