using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    public GameObject egg;
    public GameObject enemy;
    [SerializeField] public AudioSource deathsfx;
    

    // Start is called before the first frame update
    void Start()
    {
     egg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(enemy);
            egg.SetActive(true);
            deathsfx.Play();
        }
    }
}
