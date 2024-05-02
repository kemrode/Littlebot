using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittlebotDiscours : MonoBehaviour
{
    private AudioSource discours;

    [SerializeField]
    AudioClip discoursIntro;

    [SerializeField]
    AudioClip discoursFin;

    [SerializeField]
    AudioClip criTerreur;

    [SerializeField]
    AudioClip discoursSecret;

    [SerializeField]
    AudioClip discoursContent;

    [SerializeField]
    AudioClip enoughCoins;

    [SerializeField]
    AudioClip findCard;

    private float voiceLevel = 0.35f;

    private void Awake()
    {
        discours = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        tellIntro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void tellingSettings(AudioClip clip)
    {
        discours.playOnAwake = false;
        discours.loop = false;
        discours.volume = voiceLevel;
        discours.PlayOneShot(clip);
    }

    private void tellIntro()
    {
        discours.playOnAwake = true;
        discours.loop = false;
        discours.volume = voiceLevel;
        discours.PlayOneShot(discoursIntro);
    }

    public void tellEnoughCoins()
    {
        discours.playOnAwake = false;
        discours.loop = false;
        discours.volume = voiceLevel;
        discours.PlayOneShot(enoughCoins);
    }

    public void tellEnd()
    {
        discours.playOnAwake = false;
        discours.loop = false;
        discours.volume = voiceLevel;
        discours.PlayOneShot(discoursFin);
    }

    public void tellTerror()
    {
        this.tellingSettings(criTerreur);
    }

    public void tellSecret()
    {
        this.tellingSettings(discoursSecret);
    }

    public void tellFindCard()
    {
        this.tellingSettings(findCard);
    }

    public void tellItIsHappy()
    {
        this.tellingSettings(discoursContent);
    }
}
