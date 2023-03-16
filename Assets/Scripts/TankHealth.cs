using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;

    public GameObject tankExplotion;

    public AudioClip tankExplosionAudio;

    public Slider hpSlider;

    private int hpTotal;


	// Use this for initialization
	void Start () {

        hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
    
    
    }
    void TakeDamage()
    {
        if (hp <= 0) return;
        hp -= Random.Range(10, 20);
        hpSlider.value =(float) hp / hpTotal;
        if (hp <= 0)   //受到伤害后血量为0，死亡
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tankExplotion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);

        }
    }
	
}
