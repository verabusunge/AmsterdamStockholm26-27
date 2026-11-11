using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;
    public float typingSpeed = 0.04f;
    public string[] lines;
    private int index;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueText.text = string.Empty;
        index = 0;
        dialoguePanel.gameObject.SetActive(false);
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        } 
    }

    void StartDialogue()
    {
        dialoguePanel.gameObject.SetActive(true);
        dialogueText.gameObject.SetActive(true);
        StartCoroutine(TypeLine());

        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextLine()
    {
        if (index >= lines.Length)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
            
        }
        else
        {
            dialogueText.gameObject.SetActive(false);
            dialoguePanel.gameObject.SetActive(false);
        }
    }
}
