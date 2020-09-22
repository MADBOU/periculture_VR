using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_user : MonoBehaviour
{
    public string prenom_s { get; set; }
    public string nom_s { get; set; }
    public int selected_toggle { get; set; }
    private static Add_user staticValueInstance;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (staticValueInstance == null)
            staticValueInstance = this;
        else
            Object.Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
