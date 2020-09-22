using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace VRKeys
{
    public class VR_keyboard : MonoBehaviour
    {
        // Start is called before the first frame update
        // public GameObject vr_keyboard;
        // public Keyboard keyboard;
        public  GameObject beam;
        GameObject laser;
        private void OnEnable()
        {
          //  keyboard.Enable();
        }
        void Start()
        {
            laser = GameObject.Find("LaserBeam");
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Show_keyboard(GameObject keyboardvr)
        {
            keyboardvr.SetActive(true);
            keyboardvr.GetComponent<Keyboard>().Enable();
            Debug.Log("keyboard sould appear");
            beam.SetActive(false);
            laser.SetActive(false);

        }
        public void Hide_keyboard(GameObject keyboardvr)
        {
           // keyboardvr.GetComponent<Keyboard>().DisableInput();
            Debug.Log("keyboard sould disapearappear");
            keyboardvr.SetActive(false);
            beam.SetActive(true);
            laser.SetActive(true);
        }
    }
}