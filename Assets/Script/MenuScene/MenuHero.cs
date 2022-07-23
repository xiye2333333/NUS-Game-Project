using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = GetComponent<Transform>().position;
        position += Vector3.right * 1f * Time.smoothDeltaTime;
        GetComponent<Transform>().position = position;
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(-27, transform.position.y, transform.position.z);
        }
        GetComponent<Animator>().SetInteger("AnimState", 1);
        GetComponent<Animator>().SetBool("Grounded", true);
    }
}
