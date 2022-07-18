using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject Hero;
    Vector3 heroPosition;

    private float cameraSpeed = 20f;

    private static CameraBehavior cb;

    public static CameraBehavior getCB
    {
        get { return cb; }
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
        heroPosition = Hero.transform.position;
        heroPosition.z = -10;
        heroPosition.y = 1.88f;
        // GetComponent<Transform>().position = heroPosition;
        // Camera camera = GetComponent<Camera>();
        // Debug.Log(camera.);
        // Debug.Log(camera.rect.xMax);
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
        {
            if (heroPosition.x > -21 && heroPosition.x < 21)
            {
                FollowHero();
            }
            else if (heroPosition.x <= -21){
                BackLeftHome();
            }
            else{
                BackRightHome();
            }
        }

        if (GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Running)
        {
            Vector3 tmp = transform.position +
                          Input.GetAxis("Horizontal") * transform.right * (cameraSpeed * Time.smoothDeltaTime);
            if (tmp.x > -21 && tmp.x < 21)
                transform.position +=
                    Input.GetAxis("Horizontal") * transform.right * (cameraSpeed * Time.smoothDeltaTime);
        }
        // Debug.Log(transform.position);
    }

    public void FollowHero()
    {
        heroPosition = Hero.transform.position;
        heroPosition.z = -10;
        heroPosition.y = 1.88f;
        this.transform.position = heroPosition;
    }

    public void BackLeftHome()
    {
        transform.position = new Vector3(-21f, 1.88f, -10f);
    }

    public void BackRightHome()
    {
        transform.position = new Vector3(21f, 1.88f, -10f);
    }
}