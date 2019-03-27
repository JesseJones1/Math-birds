using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip projectileShot, projectileHit, obstacleHit, playerWin, playerLose;

    static AudioSource audiosrc;
	// Use this for initialization
	void Start () {
        projectileShot = Resources.Load<AudioClip>("ascend");
        Debug.Log(projectileShot);
        projectileHit = Resources.Load<AudioClip>("impact");
        obstacleHit = Resources.Load<AudioClip>("woodfallfx");
        playerWin = Resources.Load<AudioClip>("win");
        playerLose = Resources.Load<AudioClip>("lose");

        audiosrc = GetComponent<AudioSource>();
    }
	

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "ascend":
                audiosrc.PlayOneShot(projectileShot);
                Debug.Log("Sound SHould play");
                break;
            case "impact":
                audiosrc.PlayOneShot(projectileHit);
                break;
            case "woodfallfx":
                audiosrc.PlayOneShot(obstacleHit);
                break;
            case "win":
                audiosrc.PlayOneShot(playerWin);
                break;
            case "lose":
                audiosrc.PlayOneShot(playerLose);
                break;

        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
