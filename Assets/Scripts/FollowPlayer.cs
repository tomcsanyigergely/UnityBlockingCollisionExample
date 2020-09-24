using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject followedPlayer;

    private Collider collider;
    private Collider followedPlayerCollider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
    }

    private void Start()
    {
        followedPlayerCollider = followedPlayer.GetComponent<Collider>();
    }

    private void Update()
    {
        transform.position = followedPlayer.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == followedPlayerCollider)
        {
            Physics.IgnoreCollision(collider, followedPlayerCollider, true);
            collider.isTrigger = false;
        }
    }
}
