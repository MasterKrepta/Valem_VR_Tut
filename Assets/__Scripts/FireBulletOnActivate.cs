using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform barrel;
    public float fireSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg0)
    {
        GameObject spawnedBullet = Instantiate(bulletPrefab, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = barrel.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
    }

}
