using UnityEngine;

public class Sky : MonoBehaviour
{
    private float last=-100;
    void Start()
    {
        GameObject.Find("Sky").GetComponent<SpriteRenderer>().color =
            new Color(100 / 255f, 100 / 255f, 255 / 255f, 120 / 255f);
    }

    void Update()
    {
        float x = GameObject.Find("Hero").GetComponent<Transform>().position.x;
        if (last > x)
        {
            GameObject.Find("Sky").GetComponent<SpriteRenderer>().color =
                new Color(100 / 255f, 100 / 255f, 255 / 255f, 120 / 255f);
        }
        else
        {
            if (x <= -20)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color(100/255f, (15.5f*x+565)/255, 255/255f,-4*x/255);
            if(x > -20 && x <= -10)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color(100/255f, 255/255f, (-15.5f*x-55)/255,-4*x/255);
            if(x > -10 && x <= 0)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color((15.5f*x+255)/255, 255/255f, 100/255f,-4*x/255);
            if(x > 0 && x <= 10)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color(255/255f, (-15.5f*x+255)/255, 100/255f,4*x/255);
            if(x > 10 && x <= 20)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color(255/255f, 100/255f, (15.5f*x-55)/255,4*x/255);
            if(x > 20)
                GameObject.Find("Sky").GetComponent<SpriteRenderer>().color = new Color((-15.5f*x+565)/255, 100/255f, 255/255f,4*x/255);
        }
    }
}