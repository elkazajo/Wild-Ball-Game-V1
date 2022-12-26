using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReloader : MonoBehaviour
{
    private GameObject player;
    private ParticleSystem playerParticleSystem;

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerParticleSystem = GameObject.Find("Player Particle System").GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        playerParticleSystem.transform.position = player.transform.position;
        player.SetActive(false);
        playerParticleSystem.Play();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
