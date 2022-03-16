using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem Flash;
    public GameObject NewPrefab;

    public AudioClip audioShoot = null;
    private AudioSource gun_AudioSource;

    

    // Update is called once per frame

    private void Awake()
    {
        gun_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();


        }
    }

    void Shoot()
    {
        Flash.Play();
        gun_AudioSource.PlayOneShot(audioShoot);
        

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {

                target.Die();
                Instantiate(NewPrefab, target.transform);
            }
        }
    }
}
