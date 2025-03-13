using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChanger : MonoBehaviour
{
    [SerializeField] Text uiText;
    [SerializeField] float letterDelay = 0.1f;
    [SerializeField] string text7 = "Welcome";
    [SerializeField] string text8 = "In order to survive this place";
    [SerializeField] string text9 = "You will need my help";
    [SerializeField] string text4 = "Bring me money and I will help you";
    [SerializeField] string text5 = "Thank you for the money";
    [SerializeField] string text6 = "Take this to bring your sanity down";
    [SerializeField] string text1 = "More text...";
    [SerializeField] string text2 = "More text...";
    [SerializeField] string text3 = "More text...";
    
    [SerializeField] AudioSource audioSource; 
    [SerializeField] AudioClip letterSound; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text7));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text8));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text9));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text4));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text5));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text6));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text1));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text2));
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            StopAllCoroutines();
            StartCoroutine(ChangeTextLetterByLetter(text3));
        }
    }

    IEnumerator ChangeTextLetterByLetter(string newText)
    {
        uiText.text = "";

        foreach (char letter in newText)
        {
            uiText.text += letter;

            if (audioSource != null && letterSound != null)
            {
                audioSource.clip = letterSound;
                audioSource.time = 0f;
                audioSource.Play();

                yield return new WaitForSeconds(letterDelay);
                audioSource.Stop();
            }
            
            yield return new WaitForSeconds(letterDelay);
        }
    }
}
