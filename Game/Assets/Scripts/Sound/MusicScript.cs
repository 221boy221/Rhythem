using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MusicScript : MonoBehaviour {
    private static MusicScript instance = null;
    public static MusicScript Instance { get { return instance; } }

    private void Awake() {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Play() {
        audio.Play();
    }

    public void Stop() {
        audio.Stop();
    }
}
