using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour

{
    public float movmentspeed = 2;
    public float jumpforce = 1;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movment,0,0) * Time.deltaTime * movmentspeed;

        
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }
        
    }
}
