using MeuEstoque.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuEstoque.DataBase;

public class QueryDB
{
    private string _tabela;
    private LocalDB localDB;

    public QueryDB(string tabela)
    {
        try
        {
            localDB = new LocalDB();
            _tabela = tabela;
        }
        catch(Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }

    public void Incluir(Material material)
    {
        string nome = material.Nome;
        string descricao = material.Descricao;
        int quantidade = material.Quantidade;

        string command = $"INSERT INTO {_tabela} (Nome, Descricao, Quantidade) VALUES ('{nome}','{descricao}',{quantidade}) ";
        try
        {
            localDB.SqlCommand(command);
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Material PesquisarPorId(string id)
    {
        Material material = new Material();
        string query = $"SELECT Id, Nome, Descricao, Quantidade FROM {_tabela} WHERE Id = {id}";
        try
        {
            var table = localDB.SqlQuery(query);
            if(table.Rows.Count > 0)
            {
                material.Id = Int32.Parse( table.Rows[0]["Id"].ToString());
                material.Nome = table.Rows[0]["Nome"].ToString();
                material.Descricao = table.Rows[0]["Descricao"].ToString();
                material.Quantidade = Int32.Parse( table.Rows[0]["Quantidade"].ToString());
                return material;
            }
            else
            {
                throw new Exception("Id Inválido");
            }
            
        }
        catch(Exception ex)
        {
            throw new Exception (ex.Message);
        }
    }

    public DataTable ListaMateriais()
    {
        string query = $"SELECT * FROM {_tabela} ";
        try
        {
            var table = localDB.SqlQuery(query);
            return table;
        }
        catch(Exception ex)
        {
            throw new  Exception (ex.Message );
        }
    }

    public void AtualizarMaterial(Material material)
    {
        int quantidade = material.Quantidade;
        int id = material.Id;

        string comand = $"UPDATE {_tabela} SET Quantidade = {quantidade} WHERE Id = {id}";
        try
        {
            localDB.SqlCommand(comand);

        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public bool PagarMaterial(string nomePagador,string nomeRecebedor,string secaoOrigem,string secaoDestino,int materialPagoId, int quantidadeRetirada)
    {
        string command = $"INSERT INTO {_tabela} (NomePagador, NomeRecebedor, SecaoOrigem, SecaoDEstino,QuantidadeRetirada,MaterialPagoId) VALUES ('{nomePagador}','{nomeRecebedor}','{secaoOrigem}','{secaoDestino}',{quantidadeRetirada},{materialPagoId})";
        try
        {
            localDB.SqlCommand(command);
            return true;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public DataTable RelatorioDeSaídaDeMateriai()
    {
        string query = $"SELECT * FROM {_tabela}";
        try
        {
            var table = localDB.SqlQuery(query);
            return table;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
