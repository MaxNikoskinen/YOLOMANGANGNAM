using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStartTrigger : MonoBehaviour
{
    public GameObject bossBar;

    private AudioManager audioManagerScript;

    private void Start()
    {
        audioManagerScript = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bossBar.SetActive(true);
            audioManagerScript.Play("Boss Music");

            Destroy(gameObject);
        }
    }
}
