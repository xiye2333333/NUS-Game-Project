using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    public Transform Target;
    private Camera maincamera;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Target!=null){
            Vector3 pos = maincamera.WorldToScreenPoint(Target.position);
            transform.position = pos;
        }
    }
}
