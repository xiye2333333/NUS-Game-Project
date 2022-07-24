using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossPanel : MonoBehaviour
{
    GameObject Hero;
    GameObject Boss;
    public GameObject Continue;

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
        Boss = GameObject.Find("Boss");
    }

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.getGM.isChallenge)
        {
            Continue.SetActive(false);
        }
        else
        {
            Continue.SetActive(true);
        }
    }

    public void OnClickContinue()
    {
        GameObject.Find("LossPanel").SetActive(false);
        if (BossBehavior.visiblity)
        {
            Boss = GameObject.Find("Boss");
            Hero = GameObject.Find("Hero");
            Boss.GetComponent<BossBehavior>().Reset();
        }
        //Hero.GetComponent<HeroBehavior>().Money /= 2;
        Hero.GetComponent<HeroBehavior>().death = false;
        Hero.GetComponent<HeroBehavior>().GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Hero Knight_0");
        Hero.GetComponent<HeroBehavior>().mAnimator.SetBool("Grounded",true);
        Hero.GetComponent<HeroBehavior>().mAnimator.SetTrigger("Block");
        
        // Hero.GetComponent<HeroBehavior>().mAnimator.SetInteger("AnimState", 1);
        // Hero.GetComponent<HeroBehavior>().mAnimator.SetTrigger("Run");
        Hero.GetComponent<HeroBehavior>().BackHome();
        Hero.GetComponent<HeroBehavior>().timer = 0f;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Monsters.Clear();
    }

    public void OnClickExit()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
}
