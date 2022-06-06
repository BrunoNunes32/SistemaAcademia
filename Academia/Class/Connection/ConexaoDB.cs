﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Class.Connection
{
    public class ConexaoDB
    {


            SqlConnection con = new SqlConnection();

            //CONSTRUTOR
            public ConexaoDB(){
            //CONECTANDO AO BANCO DE DADOS
            //Data Source=BHAN-ACER;Initial Catalog=SistemaAcademia;Integrated Security=True
            con.ConnectionString = @"Data Source=BHAN-ACER;Initial Catalog=SistemaAcademia;Integrated Security=True"; 
                                    
            }            

            public SqlConnection conectar()
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                return con;

            }
            public SqlConnection desconectar()
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                return con;

            }
        }
    
}