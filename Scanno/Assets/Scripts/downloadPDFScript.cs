using System.Diagnostics;
using System.IO;
using UnityEngine;

public class downloadPDFScript : MonoBehaviour
{
    ProcessStartInfo process;

    private void Start()
    {
        //string TempFilePath = @"\Documents\rapportKF.pdf";
        //var directorypath = Application.dataPath + TempFilePath;
        //process = new ProcessStartInfo("AcroRd32.exe", directorypath);
        //Process.Start(process);
    }
    public void test()
    {
        downloadPDF();
    }
    public void downloadPDF()
    {

        string TempFilePath = "Assets/Documents/rapportKF.pdf";
        //var directorypath = Application.dataPath + TempFilePath;
        if (File.Exists(TempFilePath))
        {
            print("on progresse");
            Application.OpenURL("file:///" + TempFilePath);
            print("coucou");
            //Application.OpenURL("file:///"+directorypath);
            //Application.Quit();
            //string namePDF = "rapportKF";
            //TextAsset pdfTem = Resources.Load("PDFs/" + namePDF, typeof(TextAsset)) as TextAsset;
            //System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + namePDF + ".pdf", pdfTem.bytes);
            //Application.OpenURL(Application.persistentDataPath + "/" + namePDF + ".pdf");
        }
        else
        {
            print("quit");
            Application.Quit();
        }
    }

    public void newDownload()
    {
        //var test = AssetDatabase.LoadAssetAtPath<>("Assets/Resources/rapportKF.pdf");
        //Application.OpenURL("file:///"+"rapportKF");
        //string namePDF = "rapportKF";
        //TextAsset pdfTem = Resources.Load("PDFs/"+namePDF, typeof(TextAsset)) as TextAsset;
        //System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + namePDF + ".pdf", pdfTem.bytes);
        //Application.OpenURL(Application.persistentDataPath + "/" + namePDF + ".pdf");
        //TextAsset pdfTerm = Resources.Load("PDFs/"+"rapportKF", typeof(TextAsset)) as TextAsset;
        //System.IO.File.WriteAllBytes(Application.persistentDataPath +"/"+"rapportKF"+".pdf", pdfTerm.bytes);
        //Application.OpenURL(Application.persistentDataPath + "/" + "rapportKF" + "pdf");
        //var document = new Document();
        //document.Pages.Add();
        //var memoryStream = new System.IO.MemoryStream();
        //document.Save(memoryStream);
        //var byteArray = memoryStream.ToArray();
        //Application.OpenURL(byteArray.Length);
    }
}
