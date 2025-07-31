using System;
namespace dicdesenvol
{


    public static class InfoApp
    {
        private static string m_local = "";
        public static string local
        {
            get { return m_local; }
            set { m_local = value; }
        }

        private static string m_sistema = "";
        public static string sistema
        {
            get { return m_sistema; }
            set { m_sistema = value; }
        }

        private static string m_dirfoto = "";
        public static string dirfoto
        {
            get { return m_dirfoto; }
            set { m_dirfoto = value; }
        }
    }

    public static class InfoSenha
    {
        private static string m_Senha = "";
        public static string Senha
        {
            get { return m_Senha; }
            set { m_Senha = value; }
        }

        private static string m_SalvaSenha = "";
        public static string SalvaSenha
        {
            get { return m_SalvaSenha; }
            set { m_SalvaSenha = value; }
        }
    }
}