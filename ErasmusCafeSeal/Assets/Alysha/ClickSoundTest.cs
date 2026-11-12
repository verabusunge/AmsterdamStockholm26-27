using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickSoundTest : MonoBehaviour
{
    [SerializeField] private Button soundButton;
    [SerializeField] private AudioClip sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundButton.onClick.AddListener(PlaySound);
    }

    public void PlaySound()
    {
        AudioManager.Instance.PlaySFX(sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
