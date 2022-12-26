using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnabler : MonoBehaviour
{
    public GameObject trap;
    public GameObject trapEnabler;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && trapEnabler.gameObject.CompareTag("TrapDestroyer"))
        {
            Destroy(trap);
        }
        if (other.gameObject.CompareTag("Player") && trapEnabler.gameObject.CompareTag("TrapEmerger"))
        {
            trapEnabler.SetActive(false);
            trap.SetActive(true);
        }
    }
}
