using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScriptMarionette : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Marionette"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

}
