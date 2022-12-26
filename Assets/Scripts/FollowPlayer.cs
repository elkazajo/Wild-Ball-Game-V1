using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowThePlayer();
    }

    void FollowThePlayer()
    { 
        if(playerTransform)
        transform.position = playerTransform.position + offset;
    }
}
