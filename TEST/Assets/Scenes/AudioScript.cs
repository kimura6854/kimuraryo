using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioScript : MonoBehaviour
{
    //public AudioClip sound1;
    AudioSource audioSource;
    Dictionary<string, AudioClipInfo> audioClips = new Dictionary<string, AudioClipInfo>();
    GameObject soundPlayerObj;
    class AudioClipInfo
    {
        public string resourceName;
        public string name;
        public AudioClip clip;

        public AudioClipInfo(string resourceName, string name)
        {
            this.resourceName = resourceName;
            this.name = name;
        }
    }
    //コンストラクタ
    //SE名とファイル名登録
    public AudioScript()
    {
        //SE及びBGM追加場所
        audioClips.Add("se001", new AudioClipInfo("se001", "7"));
      //  audioClips.Add("bgm001", new AudioClipInfo("Encounter_loop", "bgm001"));
    }
    //SE再生
    public bool playSE(string seName)
    {
        //登録したSE名の中からseNameと同じ物を探し再生
        if (audioClips.ContainsKey(seName) == false)
            return false; // not register

        AudioClipInfo info = audioClips[seName];

        // Load
        if (info.clip == null)
            info.clip = (AudioClip)Resources.Load(info.resourceName);

        if (soundPlayerObj == null)
        {
            soundPlayerObj = new GameObject("SoundPlayer");
            audioSource = soundPlayerObj.AddComponent<AudioSource>();
        }

        // SE再生
        audioSource.PlayOneShot(info.clip);

        return true;
    }
    //BGM再生　ループ
    public bool playBGM(string seName)
    {
        //登録したSE名の中からseNameと同じ物を探し再生
        if (audioClips.ContainsKey(seName) == false)
            return false; // not register

        AudioClipInfo info = audioClips[seName];

        // Load
        if (info.clip == null)
            info.clip = (AudioClip)Resources.Load(info.resourceName);

        if (soundPlayerObj == null)
        {
            soundPlayerObj = new GameObject("SoundPlayer");
            audioSource = soundPlayerObj.AddComponent<AudioSource>();
        }

        // Play BGM
        audioSource.clip=info.clip;
        audioSource.loop = true;
        audioSource.Play();
        return true;
    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    obj = this.gameObject;

    //    audiosource =obj.AddComponent<AudioSource>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyUp(KeyCode.P))
    //    {
    //        audiosource.Stop();
    //        audiosource.PlayOneShot(sound1);

    //    }
    //    //ボリューム調整
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        audiosource.volume += 0.01f;
    //    }
    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        audiosource.volume -= 0.01f;
    //    }

    //}
    ////再生
    //void soundplay()
    //{
    //    audiosource.PlayOneShot(sound1);
    //}
    ////停止
    //void soundstop()
    //{
    //    audiosource.Stop();
    //}
    ////
}
