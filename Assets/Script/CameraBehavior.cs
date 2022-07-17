using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject Hero;
    Vector3 heroPosition;

    private float cameraSpeed = 20f;

    private static CameraBehavior cb;

    public static CameraBehavior getCB{
        get{
            return cb;
        }
    }

    private void Awake()
    {
        cb = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heroPosition.z = -10;
        heroPosition.y = 1.88f;
        // GetComponent<Transform>().position = heroPosition;
        // Camera camera = GetComponent<Camera>();
        // Debug.Log(camera.);
        // Debug.Log(camera.rect.xMax);
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
        {
            FollowHero();
        }

        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause){
            transform.position += Input.GetAxis("Horizontal") * transform.right * (cameraSpeed * Time.smoothDeltaTime);
        }
    }

    public void FollowHero(){
        heroPosition = Hero.transform.position;
        heroPosition.z -= 1f;
        this.transform.position = heroPosition;
    }
}
