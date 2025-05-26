namespace backend.Utils
{
    public static class Logger
    {
        static string PastaLog = "Logs";
        static string caminhoArquivoLog = Path.Combine(PastaLog, $"tatsu-{DateTime.Now:yyyy-MM-dd}.txt");
        public static void CriarLog(string conteudo)
        {
            try
            {
                // Verifica se a pasta de logs existe, se não, cria
                if (!Directory.Exists(PastaLog))
                {
                    Directory.CreateDirectory(PastaLog);
                    Console.WriteLine("Diretório criado com sucesso.");
                }

                if (!File.Exists(caminhoArquivoLog))
                {
                    File.WriteAllText(caminhoArquivoLog, conteudo);
                }
                else
                {
                    File.Delete(caminhoArquivoLog);
                    File.WriteAllText(caminhoArquivoLog, conteudo);
                }
            }
            catch{ 
                //ignore
            }
        }
    }
}
