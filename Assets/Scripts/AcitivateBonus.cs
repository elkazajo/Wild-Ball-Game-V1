using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitivateBonus : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private GameObject sphere;

    private void Start()
    {
        particleSystem = GetComponentInChildren<ParticleSystem>();
        sphere = GameObject.Find("BonusBody");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(sphere);
            particleSystem.Play();
        }
        
    }
}
