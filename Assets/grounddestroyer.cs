using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounddestroyer : MonoBehaviour
{
    private Transform Player;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {
        if(Player.position.z-transform.position.z > 100f)
        {
            Destroy(gameObject);
        }
    }
}
