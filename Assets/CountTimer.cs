using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using TMPro;

public class CountTimer : MonoBehaviour
{


    public float startingTime = 15f;

    [SerializeField] TextMeshProUGUI countdownText;

    public GameObject FinishScreen;

    public GameObject ThePlayer;
    // public Transform TeleportTarget;

    public AudioClip clip;
    public AudioSource TimeLeft;

    public float currentTime;

    public GameObject Fruits, Minerals;

    void Start()
    {
        currentTime = startingTime;

        StartCoroutine(PlaySoundTime(startingTime - 10));

        StartCoroutine(Teleport(startingTime));
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        countdownText.text = currentTime.ToString("0");

    }

    IEnumerator PlaySoundTime(float time)
    {
        yield return new WaitForSeconds(time);

        TimeLeft.PlayOneShot(clip);
    }




    IEnumerator Teleport(float time)
    {

        Destroy(GetComponent<FruitControl>());

        yield return new WaitForSeconds(time);

        Time.timeScale = 0;

        ThePlayer.transform.position = new Vector3(-171.97f, 12.248f, 164.17f);


    }



}
