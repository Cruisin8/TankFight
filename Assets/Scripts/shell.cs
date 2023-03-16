using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour
{
    public GameObject shellExplosionPrefab;

    public  AudioClip shellExplosionAudio;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position);
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "Tank")
        {
            collider.SendMessage("TakeDamage");

        }
    }

} 
