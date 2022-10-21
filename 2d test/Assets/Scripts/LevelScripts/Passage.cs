
using UnityEngine;

public class Passage : MonoBehaviour
{/*
    public Transform connection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 position = player.transform.position;
        position.x = this.connection.position.x;
        //position.y = this.connection.position.y;

        gameObject.transform.position = position;

    }*/
    public GameObject Player;
    public Transform OtherSide;

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
            Player.gameObject.transform.position = new Vector3(OtherSide.position.x, Player.gameObject.transform.position.y, 0);
        }
    }
}