﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstoque.Models;

public class Recibo
{
    private string _nomePagador;
    private string _nomeRecebedor;
    private string _secaoOrigem;
    private string _secaoDestino;
    private Material _materialPago;
    private int _quantidadeRetirada;

    public Recibo(string nomePagador, string nomeRecebedor, string secaoOrigem, string secaoDestino, Material materialPago, int quantidadeRetirada)
    {
        _nomePagador = nomePagador;
        _nomeRecebedor = nomeRecebedor;
        _secaoOrigem = "Telemática";
        _secaoDestino = secaoDestino;
        _materialPago = materialPago;
        _quantidadeRetirada = quantidadeRetirada;
    }

    public override string ToString()
    {
        return $"Seção {_secaoOrigem} \nO {_nomeRecebedor} recebeu dessa Seção o Material abaixo descrito:\n{_materialPago.Nome} {_materialPago.Descricao} quantidade: {_quantidadeRetirada} unidades.\n com destino a Seção: {_secaoDestino}.";
    }
}
