using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class Diploma : MonoBehaviour
{
    public Text date_diplome;
    public Text nom_user;
    //public GameObject diplome;
    //public GameObject button;
    Add_user add_user_name; 
    
    string screenshot_diploma_FolderName;
    public GameObject diploma_camera;
    private Send_email sender_mail;
    bool once = true;
    string filename = "";
    // Start is called before the first frame update
    void Start()
    {
        screenshot_diploma_FolderName = Application.persistentDataPath + "/civr/Obsevation/" + "Diplome";
        add_user_name = GameObject.FindObjectOfType<Add_user>(); 
        nom_user.text = add_user_name.prenom_s + " " + add_user_name.nom_s; 
        date_diplome.text = System.DateTime.Now.ToString("dd-MM-yyyy");
        sender_mail = GameObject.FindObjectOfType<Send_email>();
        Diplome_shoot();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) && once)
        {
            Shot_diploma();
            sender_mail.Sending_mail("C:/Users/Mehdi/AppData/LocalLow/CIVR/UNTVR44/civr/Diplome/mehdi_boukhris   2020-08-28  11-55-26.png","aaaa","BBBBBB");
            once = false;
        }
    }
    
    public void Diplome_shoot()
    {
        try
        {
            if (!Directory.Exists(screenshot_diploma_FolderName))
            {
                Debug.Log("   ///////////////    " + screenshot_diploma_FolderName);
                Directory.CreateDirectory(screenshot_diploma_FolderName);

            }
        }
        catch (IOException ex)
        {
            Debug.Log("///erooor//// "+screenshot_diploma_FolderName);
        }

        Shot_diploma();
        // ScreenCapture.CaptureScreenshot(screenshot_diploma_FolderName+"/" + add_user_name.prenom_s + "_" + add_user_name.nom_s+ "   " + DateTime.Now.ToString("yyyy-MM-dd  HH-mm-ss") + ".jpg");

        // sender_mail.Sending_mail(filename, "Diplome de "+add_user_name.prenom_s + "_" + add_user_name.nom_s + "   " + DateTime.Now.ToString("yyyy-MM-dd  HH-mm-ss"), add_user_name.prenom_s + " " + add_user_name.nom_s + " a realisé l'experience chasse aux risques, il/elle a obtenue le score de :  "+ correction.risque_detected.Count.ToString()+"/"+ risque_total.text);
        sender_mail.Sending_mail(filename, "certificat de " + add_user_name.prenom_s + " " + add_user_name.nom_s + " du  " + DateTime.Now.ToString("dd-MM-yyyy  HH-mm-ss"), "Bonjour,\n Voici le certificat de réalisation de l’expérience Observation de " + add_user_name.prenom_s + " " + add_user_name.nom_s + "\n Sincèrement,");
        


    }


    public void Shot_diploma()
    {

        diploma_camera.SetActive(true);
        int resWidth = Mathf.RoundToInt(Screen.width );
        int resHeight = Mathf.RoundToInt(Screen.height);
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        diploma_camera.GetComponent<Camera>().targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        diploma_camera.GetComponent<Camera>().Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        diploma_camera.GetComponent<Camera>().targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        byte[] bytes = screenShot.EncodeToPNG();
        filename = screenshot_diploma_FolderName + "/" + add_user_name.prenom_s + "_" + add_user_name.nom_s + "   " + DateTime.Now.ToString("yyyy-MM-dd  HH-mm-ss")+".png";
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("(Temporal) Screenshot saveeeeeeed as {0}", filename));
        diploma_camera.SetActive(false);
        //saveBigImage.sprite = SpriteFromPath(filename);


        // LoadGallery(saveContent);
        //System.IO.File.Copy(filename, Application.persistentDataPath + "/" + screenshotFolderName + "/" + System.IO.Path.GetFileName(currentShot));
        //photoModePanel.SetActive(false);
        //basePanel.SetActive(true);
        //photoSavePanel.SetActive (true);
        // Screen.lockCursor = false;
        //Photo_number++;
        //count_photo.text = "Pellicule utilisée: " + Photo_number + "/" + Max_photos;
        //correct.Risque_present();

    }


}
