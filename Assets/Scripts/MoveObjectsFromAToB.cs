using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectsFromAToB : MonoBehaviour
{
    public Transform target_1;
    public Transform target_2;
    
    public float smoothing;

    void Start()
    {
        StartCoroutine(MoveColumn());
    }

    IEnumerator MoveColumn()
    {
        while (true)
        {
            while (Vector3.Distance(transform.position, target_1.position) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target_1.position, smoothing * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(1f);

            while (Vector3.Distance(transform.position, target_2.position) > 0.05f)
            {
                transform.position = Vector3.Lerp(transform.position, target_2.position, smoothing * Time.deltaTime);
                yield return null;
            }
        }
    }    
}
