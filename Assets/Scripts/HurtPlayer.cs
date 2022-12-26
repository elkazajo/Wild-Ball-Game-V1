using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtPlayer : MonoBehaviour
{
    public Canvas hurtCanvas;
    private GameObject player;
    private ParticleSystem playerParticleSystem;

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerParticleSystem = GameObject.Find("Player Particle System").GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Hurt());            
        }
    }

    public IEnumerator Hurt()
    {        
        hurtCanvas.enabled = true;
        playerParticleSystem.transform.position = player.transform.position;
        player.SetActive(false);
        playerParticleSystem.Play();        
        yield return new WaitForSeconds(1.5f);        
        hurtCanvas.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
