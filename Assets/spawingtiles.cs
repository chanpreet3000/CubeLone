using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawingtiles : MonoBehaviour
{
    public GameObject Ground;
    public Transform Player;   
    public int initialtiles = 3;
    public float tilesize = 50f;

    private Vector3 spawnposition = Vector3.zero;

    private void Update()
    {
        if(spawnposition.z - Player.position.z < initialtiles*tilesize)
        {
            Instantiate(Ground, spawnposition, Quaternion.identity);
            spawnposition.z = spawnposition.z + tilesize;
        }
    }
}
