using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System;

public class Send_email : MonoBehaviour
{


    string FilePath = "";
    //string AttachmentName = "ATTACHNAME";
    string FileName = "";
    public void Sending_mail(string AttachmentName , string subject , string body_email)
    {
        
//#if UNITY_EDITOR
        //FilePath = string.Format(@"Assets/StreamingAssets/{0}", AttachmentName);
        FilePath = AttachmentName;
   // #else
             /*FilePath = Application.persistentDataPath + "/" + AttachmentName;
             if(!File.Exists(FilePath)) {
                 WWW loadImage = new WWW("jar:file://" + Application.dataPath + "!/assets/" + AttachmentName);
                 while(!loadImage.isDone) {}
                 File.WriteAllBytes(FilePath, loadImage.bytes);
             }*/
//#endif

        FileName = FilePath;
 
         MailMessage mail = new MailMessage();

             mail.From = new MailAddress("civr.client@gmail.com.com");
             mail.To.Add("luzcare.oculus@gmail.com ");
              mail.Subject = subject;
              mail.Body = body_email;
 
         Attachment data = new Attachment(FileName, System.Net.Mime.MediaTypeNames.Application.Octet);
    // Add time stamp information for the file.
    System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
    disposition.CreationDate = System.IO.File.GetCreationTime(FileName);
             disposition.ModificationDate = System.IO.File.GetLastWriteTime(FileName);
             disposition.ReadDate = System.IO.File.GetLastAccessTime(FileName);
 
         mail.Attachments.Add(data);
 
         SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
    smtpServer.Port = 587;
         smtpServer.Credentials = new System.Net.NetworkCredential("civr.client@gmail.com", "Lamouche13");
         smtpServer.EnableSsl = true;
         ServicePointManager.ServerCertificateValidationCallback = 
             delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
             return true;
             };
         try {
             smtpServer.Send(mail);
            Debug.Log("email sent with success");
             } catch (Exception e) {

                 Debug.Log(e.GetBaseException ());
             }



    }













    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
