using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using NBA;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public class Login
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Login", null);

            }
            static public DataTable login(string Nome, string Password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Password", Password)
                };
                return dal.executarReader("select * from Login where Nome=@Nome and Password=@Password", sqlParams);
            }
        }
        public class Imagem
        {
            static public object loadpic(string Id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id", Id)
                  };
                return dal.executarScalar("select imagem from Clientes where Id=@Id", sqlParams);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Clientes", null);
            }

        }
        public class Jogadores
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Jogadores", null);
            }

            static public int InsertJogadores(string Nome, string DataNascimento, string Nacionalidade, string Posição,  string altura, string Peso, string NDaCamisola,byte[] imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@DataNascimento", DataNascimento),
                new SqlParameter("@Nacionalidade", Nacionalidade),
                new SqlParameter("@Posição", Posição),
                new SqlParameter("@altura", altura),
                new SqlParameter("@Peso", Peso),
                new SqlParameter("@NDaCamisola", NDaCamisola),
                new SqlParameter("@imagem", imagem)
                
                 };

                return dal.executarNonQuery("INSERT into Jogadores (Nome,DataNascimento,Nacionalidade,Posição,altura,Peso, NDaCamisola,Imagem) VALUES (@Nome,@DataNascimento,@Nacionalidade,@Posição,@altura,@Peso,@NDaCamisola,@imagem)", sqlParams);
            }


            static public int updateJogadores(string IdJogador, string Nome, string DataNascimento, string Nacionalidade, string Posição, string altura, string Peso,string NDaCamisola ,byte[] imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("IdJogador", IdJogador),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@DataNascimento", DataNascimento),
                new SqlParameter("@Nacionalidade", Nacionalidade),
                new SqlParameter("@Posição", Posição),
                new SqlParameter("@altura", altura),
                new SqlParameter("@Peso", Peso),
                new SqlParameter("@NDaCamisola",NDaCamisola),
                new SqlParameter("@imagem", imagem)    
            };
                return dal.executarNonQuery("update [Jogadores] set [Nome]=@Nome, [DataNascimento]=@DataNascimento, [Nacionalidade]=@Nacionalidade, [Posição]=@Posição, [Altura]=@Altura, [Peso]=@Peso,  [NDaCamisola]=@NDaCamisola, [imagem]=@imagem where [IdJogador]=@IdJogador", sqlParams);
            }

            static public DataTable LoadJogadorNome (string Nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                };
                return dal.executarReader("select * from Jogadores where Nome like @Nome", sqlParams);
            }


        }
        public class Treinador
            {

                static public DataTable Load()
                {
                    DAL dal = new DAL();
                    return dal.executarReader("select * from Treinador", null);
                }

                static public int InsertTreinador(string Nome, int idade, string DataNascimento, string Nacionalidade, int TotaldeJogos, int Vitorias, int Derrotas, int Anodecontratacao, byte[] imagem)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@Nome", Nome),
                    new SqlParameter("@Idade",idade),
                    new SqlParameter("@DataNascimento", DataNascimento),
                    new SqlParameter("@Nacionalidade", Nacionalidade),
                    new SqlParameter("@TotaldeJogos",TotaldeJogos),
                    new SqlParameter("@Vitorias",Vitorias),
                    new SqlParameter("@Derrotas",Derrotas),
                    new SqlParameter("@Anodecontratacao",Anodecontratacao),
                    new SqlParameter("@imagem", imagem)
                    
                 };

                    return dal.executarNonQuery("INSERT into Treinador (Nome,idade,DataNascimento,Nacionalidade,TotaldeJogos,Vitorias,Derrotas,Anodecontratacao,Imagem) VALUES (@Nome,@idade,@DataNascimento,@Nacionalidade,@TotaldeJogos,@Vitorias,@Derrotas,@Anodecontratacao,@imagem)", sqlParams);
                }


                static public int updateTreinador(string IdTreinador, string Nome, int idade, string DataNascimento, string Nacionalidade, int TotaldeJogos, int Vitorias, int Derrotas, int Anodecontratacao, byte[] imagem)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("IdTreinador", IdTreinador),
                    new SqlParameter("@Nome", Nome),
                    new SqlParameter("@Idade",idade),
                    new SqlParameter("@DataNascimento", DataNascimento),
                    new SqlParameter("@Nacionalidade", Nacionalidade),
                    new SqlParameter("@TotaldeJogos",TotaldeJogos),
                    new SqlParameter("@Vitorias",Vitorias),
                    new SqlParameter("@Derrotas",Derrotas),
                    new SqlParameter("@Anodecontratacao",Anodecontratacao),
                    new SqlParameter("@imagem", imagem)
                    
                  };
                    return dal.executarNonQuery("update [Treinador] set [Nome]=@Nome, [idade]=@idade,[DataNascimento]=@DataNascimento, [Nacionalidade]=@Nacionalidade,[TotaldeJogos]=@TotaldeJogos,[Vitorias]=@Vitorias,[Derrotas]=@Derrotas,[Anodecontratacao]=@Anodecontratacao,[imagem]=@imagem where [IdTreinador]=@IdTreinador", sqlParams);
                }
                
            static public DataTable LoadTreinadorNome(string Nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                };
                    return dal.executarReader("select * from Treinador where Nome like @Nome", sqlParams);
                }


            }
        public class Equipas
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Equipas", null);
            }

            static public int InsertEquipas(string Nome, byte[] Logo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Logo", Logo)
                
                 };

                return dal.executarNonQuery("INSERT into Equipas (Nome,Logo) VALUES (@Nome,@Logo)", sqlParams);
            }

            static public int UpdateEquipas(string IdEquipa, string Nome, byte[] Logo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("IdEquipa", IdEquipa),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Logo", Logo)
                
                 };

                return dal.executarNonQuery("UPDATE [Equipas] Set [Nome]=@Nome,[Logo]=@Logo WHERE [IdEquipa]=@IdEquipa)", sqlParams);
            }

            static public DataTable LoadEquipasNome(string Nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                };
                return dal.executarReader("select * from Equipas where Nome like @Nome", sqlParams);
            }


        }
        public class Jogos
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from DatasJogos", null);
            }

            static public int InsertDatasJogos(string IdEquipa, string DataDoJogo, string Local)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdEquipa", IdEquipa),
                    new SqlParameter("@DataDoJogo", DataDoJogo),
                    new SqlParameter("@Local", Local)
                 };

                return dal.executarNonQuery("INSERT into DatasJogos (IdEquipa, DataDoJogo, Local) VALUES (@IdEquipa, @DataDoJogo, @Local)", sqlParams);
            }

            static public int UpdateDatasJogos(string IdJogo, string IdEquipa, string DataDoJogo, string Local)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdJogo", IdJogo),
                    new SqlParameter("@IdEquipa", IdEquipa),
                    new SqlParameter("@DataDoJogo", DataDoJogo),
                    new SqlParameter("@Local", Local)

                    
                 };

                return dal.executarNonQuery("update [DatasJogos] set [IdEquipa]=@IdEquipa, [DataDoJogo]=@DataDoJogo, [Local]=@Local WHERE [IdJogo]=@IdJogo", sqlParams);
            }
            static public DataTable LoadJogosNome(string IdJogo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdJogo", IdJogo),
                };
                return dal.executarReader("select * from DatasJogos where IdJogo like @IdJogo", sqlParams);
            }

        }
        public class Resultados
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Resultados", null);
            }

            static public int InsertResultados(string IdJogo, string FirstQuarter, string SecondQuarter, string ThirdQuarter, string FourthQuarter, string OT, string Final, string VD)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdJogo", IdJogo),
                    new SqlParameter("@FirstQuarter", FirstQuarter),
                    new SqlParameter("@SecondQuarter", SecondQuarter),
                    new SqlParameter("@ThirdQuarter", ThirdQuarter),
                    new SqlParameter("@FourthQuarter", FourthQuarter),
                    new SqlParameter("@OT", OT),
                    new SqlParameter("@Final", Final),
                    new SqlParameter("@VD", VD)
                 };

                return dal.executarNonQuery("INSERT into Resultados (IdJogo,FirstQuarter,SecondQuarter,ThirdQuarter,FourthQuarter,OT,Final, VD) VALUES (@IdJogo, @FirstQuarter, @SecondQuarter, @ThirdQuarter, @FourthQuarter, @OT, @Final, @VD)", sqlParams);
            }

            static public int UpdateResultados(string IdEquipa, string IdJogo, string FirstQuarter, string SecondQuarter, string ThirdQuarter, string FourthQuarter, string OT, string Final, string VD)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdEquipa", IdEquipa),
                    new SqlParameter("@IdJogo", IdJogo),
                    new SqlParameter("@FirstQuarter", FirstQuarter),
                    new SqlParameter("@SecondQuarter", SecondQuarter),
                    new SqlParameter("@ThirdQuarter", ThirdQuarter),
                    new SqlParameter("@FourthQuarter", FourthQuarter),
                    new SqlParameter("@OT", OT),
                    new SqlParameter("@Final", Final),
                    new SqlParameter("@VD", VD)
                 };

                return dal.executarNonQuery("UPDATE [Resultados] SET [IdJogo]=@IdJogo, [FirstQuarter]=@FirstQuarter, [SecondQuarter]=@SecondQuarter, [ThirdQuarter]=@ThirdQuarter, [FourthQuarter]=@FourthQuarter, [OT]=@OT, [Final]=@Final, [VD]=@VD Where [IdEquipa]=@IdEquipa)", sqlParams);
            }


        }
        public class Estatisticas
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Estatísticas", null);
            }

            static public int InsertEstatisticas(string IdJogo, int Rebounds, int Blocks, int assists, string FreeThrow, int Turnovers, string ThreeFG, string FG, int Steals)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdJogo", IdJogo),
                    new SqlParameter("@Rebounds",Rebounds),
                    new SqlParameter("@Blocks", Blocks),
                    new SqlParameter("@assists", assists),
                    new SqlParameter("@FreeThrow",FreeThrow),
                    new SqlParameter("@Turnovers",Turnovers),
                    new SqlParameter("@ThreeFG",ThreeFG),
                    new SqlParameter("@FG",FG),
                    new SqlParameter("@Steals", Steals)
                    
                 };

                return dal.executarNonQuery("INSERT into Estatísticas (IdJogo,Rebounds,Blocks,assists,FreeThrow,Turnovers,ThreeFG,FG,Steals) VALUES (@IdJogo,@Rebounds,@Blocks,@assists,@FreeThrow,@Turnovers,@ThreeFG,@FG,@Steals)", sqlParams);
            }

            static public int UpdateEstatisticas(string IdEstatisticas, string IdJogo, int Rebounds, int Blocks, int assists, string FreeThrow, int Turnovers, string ThreeFG, string FG, int Steals)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@IdEstatisticas", IdEstatisticas),
                    new SqlParameter("@IdJogo", IdJogo),
                    new SqlParameter("@Rebounds",Rebounds),
                    new SqlParameter("@Blocks", Blocks),
                    new SqlParameter("@assists", assists),
                    new SqlParameter("@FreeThrow",FreeThrow),
                    new SqlParameter("@Turnovers",Turnovers),
                    new SqlParameter("@ThreeFG",ThreeFG),
                    new SqlParameter("@FG",FG),
                    new SqlParameter("@Steals", Steals)
                    
                 };

                return dal.executarNonQuery("UPDATE Estatísticas SET [IdJogo]=@IdJogo, [Rebounds]=@Rebounds,[Blocks]=@Blocks,[assists]=@assists,[FreeThrow]=@FreeThrow,[Turnovers]=@Turnovers,[ThreeFG]=@ThreeFG,[FG]=@FG,[Steals]=@Steals Where [IdEstatisticas]=@IdEstatisticas)", sqlParams);
            }

        }















        }
}




      
    
   



