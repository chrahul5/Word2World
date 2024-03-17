/*
* This file defines the pistol's fire bullet behaviour.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulltet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPosition;
    public float fireSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void FireBullet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPosition.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity =
            spawnPosition.forward * fireSpeed;
        Debug.Log(spawnPosition.forward);
        Destroy(spawnedBullet, 5);
    }
}
