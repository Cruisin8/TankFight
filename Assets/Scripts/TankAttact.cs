using UnityEngine;
using System.Collections;

public class TankAttact : MonoBehaviour {

    public GameObject shellPrefab;

    public KeyCode FireKey = KeyCode.Space;

    public float shellSpeed = 10;

    private Transform FirePosition;

    public AudioClip shotAudio;



	// Use this for initialization
	void Start () {
        FirePosition = transform.Find("FirePosition");

	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(FireKey)) {
            AudioSource.PlayClipAtPoint(shotAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, FirePosition.position, FirePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
	
	}
}
