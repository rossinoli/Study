using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ProdutosRegraNegocio
    {
        AcessoDados.ProdutosAcessoDados novoProduto;

        public void SalvarCategoria(string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.SalvarCategoria(nomeCategoria, descricaoCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarCategoria(int idCategoria, string nomeCategoria, string descricaoCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.AlterarCategoria(idCategoria, nomeCategoria, descricaoCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCategoria(int idCategoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.ExcluirCategoria(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarCategorias()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.ListarCategorias();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarUnidade(string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.SalvarUnidade(nomeUnidade, descricaoUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarUnidade(int idUnidade, string nomeUnidade, string descricaoUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.AlterarUnidade(idUnidade, nomeUnidade, descricaoUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirUnidade(int idUnidade)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.ExcluirUnidade(idUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarUnidades()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.ListarUnidades();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                           decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {
                Validar(codigoBarras, nome, descricao, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.Salvar(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra, valorVenda, margem, anotacoesProdutos, situacaoProdutos, dataCadastroProduto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                            decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto)
        {
            try
            {

                Validar(codigoBarras, nome, descricao, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.Alterar(idProduto, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra, valorVenda, margem, anotacoesProdutos, situacaoProdutos, dataCadastroProduto);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idProduto)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.Excluir(idProduto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
                
        private void Validar(string codigoBarras, string nome, string descricao, int idCategoria, int estoqueAtual,
            int estoqueMinimo, int idUnidade, decimal valorCompra, decimal margem, decimal valorVenda)
        {
            if (codigoBarras.Trim().Length == 0)
            {
                throw new Exception("O campo Código de Barras deve ser preenchido!");
            }

            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Descrição não pode ser vazio!");
            }

            if (idCategoria == 0)
            {
                throw new Exception("O campo Categoria não pode ser vazio!");
            }

            if (estoqueAtual == 0)
            {
                throw new Exception("O campo Estoque Atual não pode ser vazio!");
            }

            if (estoqueMinimo == 0)
            {
                throw new Exception("O campo Estoque Mínimo não pode ser vazio!");
            }

            if (idUnidade == 0)
            {
                throw new Exception("O campo Unidade do Produto não pode ser vazio!");
            }

            if (valorCompra == 0)
            {
                throw new Exception("O campo Custo não pode ser vazio!");
            }

            if (margem == 0)
            {
                throw new Exception("O campo Margem de Lucro % não pode ser vazio!");
            }

            if (valorVenda == 0)
            {
                throw new Exception("O campo Venda não pode ser vazio!");
            }
        }
    }
}