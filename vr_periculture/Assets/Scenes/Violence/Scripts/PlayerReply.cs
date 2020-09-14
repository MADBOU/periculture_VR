using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerReply : MonoBehaviour
{
    //Player enters into the scene, he is in the first point of teleportation (consecutive teleport points appears meanwhile and he is free to move around OR not)
    //Only First two risques are accessible, he clicks on the transparent UI => deactivates, reply canvas appears, replies with a answer
    //Correct answer? Positive sound, green button : Negative sound, red button and correct answer (button) in green
    // At the end of last risque Xperience ends
    // A reply canvas for each risque

    public string correctAnswer;
    public Button[] replyButtons;
    private AudioSource _audioSource;
    private PlayAudioOnAnswer playAudioOnAnswer;
    void Start()
    {
        _audioSource = this.gameObject.GetComponent<AudioSource>();
        playAudioOnAnswer = GameObject.FindObjectOfType<PlayAudioOnAnswer>();
    }

    void Update()
    {

    }

    public void CheckForCorrectAnswer(Button button)
    {
        // Deactivate all other buttons and check for answers

        DeactivateAllButtons();
        if (button.gameObject.name.Contains(correctAnswer))
        {
            // Correct answer // Play the appropriate sound and green colour 
            _audioSource.clip = playAudioOnAnswer.correctAnswer;
            button.GetComponent<Image>().color = Color.green;
        }
        else
        {
            // Wrong answer // Play the appropriate sound and red colour // Correct answer in green colour
            _audioSource.clip = playAudioOnAnswer.wrongAnswer;
            button.GetComponent<Image>().color = Color.red;
            GetCorrectAnswer();
        }

        
    }

    private void DeactivateAllButtons()
    {
        foreach(Button _button in replyButtons)
        {
            _button.interactable = false;
        }
    }

    private void GetCorrectAnswer()
    {
        foreach(Button _button in replyButtons)
        {
            if(_button.gameObject.name.Contains(correctAnswer))
            {
                // This the correct answer button
                _button.GetComponent<Image>().color = Color.green;
            }
        }
    }
}
