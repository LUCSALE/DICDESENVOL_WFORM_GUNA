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

        private static string m_versao = "";
        public static string versao
        {
            get { return m_versao; }
            set { m_versao = value; }
        }

        private static string m_opcao = "";
        public static string opcao
        {
            get { return m_opcao; }
            set { m_opcao = value; }
        }

        private static string m_nome_entidade = "";
        public static string nome_entidade
        {
            get { return m_nome_entidade; }
            set { m_nome_entidade = value; }
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

        private static bool m_Logado = false;
        public static bool Logado
        {
            get { return m_Logado; }
            set { m_Logado = value; }
        }

        private static string m_Usuario = "";
        public static string Usuario
        {
            get { return m_Usuario; }
            set { m_Usuario = value; }
        }


        //public string Usuario { get; set; }
    }


    public static class InfoPesq
    {
        private static int m_ID = 0;
        public static int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

    }
}