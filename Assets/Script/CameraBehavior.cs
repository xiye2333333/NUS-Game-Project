using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 heroPosition = Hero.transform.position;
        heroPosition.z = -10;
        heroPosition.y = 1.88f;
        // GetComponent<Transform>().position = heroPosition;
        // Camera camera = GetComponent<Camera>();
        // Debug.Log(camera.);
        // Debug.Log(camera.rect.xMax);
        if (heroPosition.x >= -21)
        {
            transform.position = heroPosition;
        }

        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause){
            if (Input.GetKey(KeyCode.A)){

            }
            if (Input.GetKey(KeyCode.D)){
                
            }
        }
    }
}
