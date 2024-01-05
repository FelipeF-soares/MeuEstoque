using MeuEstoque.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstoque.Models;

public class ControleEstoque
{
    private string _nomePagador;
    private string _nomeRecebedor;
    private string _secaoOrigem;
    private string _secaoDestino;
    private Material _materialPago;
    private int _quantidadeRetirada;

    public bool ValidaERegistrar(string nomePagador, string nomeRecebedor, string secaoOrigem, string secaoDestino, Material materialPago, int quantidadeRetirada)
    {
        _nomePagador = nomePagador;
        _nomeRecebedor = nomeRecebedor;
        _secaoOrigem = secaoOrigem;
        _secaoDestino = secaoDestino;
        _materialPago = materialPago;
        _quantidadeRetirada = quantidadeRetirada;

        if (quantidadeRetirada > materialPago.Quantidade)
        {
            throw new ArgumentException("Quantidade Solicitada é maior que o estoque");

        }else if(quantidadeRetirada <= 0 || _materialPago.Id.Equals(null) )
        {
            throw new ArgumentException("O Valor Digitado não é válido");
        }
        else
        {
           return RealizarPagamentoDeMaterial();
        }
    }

    private bool RealizarPagamentoDeMaterial()
    {
        bool sucesso = false;
        try
        {
            QueryDB queryDB = new QueryDB("Controle_Estoque");
            sucesso = queryDB.PagarMaterial(_nomePagador,_nomeRecebedor,_secaoOrigem,_secaoDestino,_materialPago.Id,_quantidadeRetirada);
            if(sucesso)
            {
                DiminuiEstoque();
                Recibo recibo = new Recibo(_nomePagador, _nomeRecebedor, _secaoOrigem, _secaoDestino, _materialPago, _quantidadeRetirada);
                GeraPDF geraPDF = new GeraPDF(recibo);
                geraPDF.Materiais();
                geraPDF.AbriArquivo();
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private void DiminuiEstoque()
    {
        _materialPago.Quantidade = _materialPago.Quantidade - _quantidadeRetirada;
        QueryDB queryDB = new QueryDB("Materiais");
        queryDB.AtualizarMaterial(_materialPago);
    }
}
