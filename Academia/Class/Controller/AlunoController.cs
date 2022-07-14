using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Class.Connection;
using Academia.Class.Model;
using System.Windows.Forms;

namespace Academia.Class.Controller
{

    public class AlunoController
    {
        readonly ConexaoDB conexao = new ConexaoDB();
        readonly SqlCommand cmd = new SqlCommand();
        //SqlDataReader leitor = new SqlDataReader();
        public string mensagem;

        public bool Inserir(AlunoModel aluno)
        {
            //DANDO O COMANDO QUE SERÁ EXECUTADO NO BANCO DE DADOS | BITATIVO 1 POIS SE ESTA CADASTRANDO, ELE ESTA ATIVO
            cmd.CommandText = "INSERT INTO tblAluno(nome, CPF, dtNascimento, telefone, celular, sexo, bitAtivo, email, dataCadastro) VALUES(@nome, @CPF, @dtNascimento, @telefone, @celular, @sexo, 1, @email, GETDATE())"; 

            //PARAMETROS 
            if (aluno.Nome != "" && aluno.Nome != null)
            {
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
            }
            else
            {
                mensagem = "Campo NOME é obrigatório!";
                return false;
            }

            if (aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            else
            {
                mensagem = "Campo CPF é obrigatório!";
                return false;
            }

            if (aluno.DtNascimento != "" && aluno.DtNascimento != null)
            {
                cmd.Parameters.Add("@dtNascimento", SqlDbType.VarChar).Value = aluno.DtNascimento;
            }
            else
            {
                mensagem = "Campo DATA DE NASCIMENTO é obrigatório!";
                return false;
            }

            if (aluno.Sexo != "" && aluno.Sexo != null)
            {
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = aluno.Sexo;
            }
            else
            {
                mensagem = "Campo SEXO é obrigatório!";
                return false;
            }

            if (aluno.Telefone != "" && aluno.Telefone != null)
            {
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = aluno.Telefone;
            }
            else
            {
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = "";
            }

            if (aluno.Celular != "" && aluno.Celular != null)
            {
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = aluno.Celular;
            }
            else
            {
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = "";
            }

            if (aluno.Email != "" && aluno.Email != null)
            {
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
            }
            else
            {
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = "";
            }

            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno inserido com sucesso!";
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha na inserção do aluno! \n" + error;
                return false;
            }

        }

        public bool Deletar(AlunoModel aluno)
        {
            cmd.CommandText = "DELETE FROM tblAluno WHERE CPF = '@CPF'";

            if(aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            else
            {
                mensagem = "É obrigatório informar o CPF!";
                return false;
            }

            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno deletado com sucesso!";//INFORMANDO A MENSAGEM DE CONCLUSÃO
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha ao deletar o aluno! \n" + error;//INFORMANDO A MENSAGEM DE ERRO NO PROCESSO, E MOSTRANDO O ERRO
                return false;
            }

        }

        public bool ConsultarExistencia(AlunoModel aluno)
        {
            cmd.CommandText = "SELECT COUNT(*) AS EXISTENCIA FROM tblAluno WHERE CPF = '@CPF'";

            if (aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            else
            {
                mensagem = "É obrigatório informar o CPF!";
                return false;
            }

            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno deletado com sucesso!";//INFORMANDO A MENSAGEM DE CONCLUSÃO
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha ao consultar a existência aluno! \n" + error;//INFORMANDO A MENSAGEM DE ERRO NO PROCESSO, E MOSTRANDO O ERRO
                return false;
            }

           // return true;
        }

    }
    
}
