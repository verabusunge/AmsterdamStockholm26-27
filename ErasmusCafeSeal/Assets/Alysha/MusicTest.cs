using UnityEngine;

public class MusicTest : MonoBehaviour
{
    [SerializeField] private AudioClip music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.Instance.PlaySFX(music);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
