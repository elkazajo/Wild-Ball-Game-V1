using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(SceneManager.GetActiveScene().buildIndex < 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
