namespace _25E2_4_TP1_Console.Exercicio5;

public class DownloadManager
{
    public event EventHandler<bool>? Download;
    public void VerificaDownload(bool verDownload)
    {
        if(verDownload)
        {
            Download?.Invoke(this, verDownload);	
        }
    }

}