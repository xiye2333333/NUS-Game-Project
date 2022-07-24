using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{
    public class HeroCanvas : MonoBehaviour
    {
        public GameObject ObtainImage;

        public GameObject ObtainText;

        public GameObject Hero;

        private float time;

        private Vector3 delta = Vector3.zero;

        public int Money;

        public int Wood;
        
        public int Stone;
        
        public int Iron;
        
        public int Gem;

        private void Update()
        {
            if (ObtainImage.active)
            {
                delta += Vector3.up * 50f * Time.deltaTime;
                ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position +
                    Vector3.up * 1.5f) + delta;
                Color color = ObtainImage.GetComponent<Image>().color;
                color.a = Mathf.Lerp(color.a, 0, Time.deltaTime * 2);
                ObtainImage.GetComponent<Image>().color = color;
                if (Time.time - time > 1f)
                {
                    delta = Vector3.zero;
                    ObtainImage.SetActive(false);
                }
            }
        }

        public void ObtainWood(int wood)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Wooden Plank");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + wood;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainStone(int stone)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Coal");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + stone;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainIron(int iron)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Silver Ingot");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + iron;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainGem(int gem)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Diamond");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + gem;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainHP(int hp)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Heart");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + hp;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainMP(int mp)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Blue Potion 3");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + mp;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainMoney(int money)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Golden Coin");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + money;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void ObtainMoney2()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Golden Coin");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + Money;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
        
        public void ObtainWood2()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Wooden Plank");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + Wood;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
        
        public void ObtainStone2()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Coal");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + Stone;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
        
        public void ObtainIron2()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Silver Ingot");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + Iron;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
        
        public void ObtainGem2()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Diamond");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + Gem;
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
        
        

        public void HelpInvoke(string MethodName,float time)
        {
            Invoke(MethodName, time);
        }
        
        
        public void UseBash()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Skill/Icon13");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "Use Bash!";
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }

        public void UseHolyLight()
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Skill/Icon11");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "Use Holy Light!";
            ObtainImage.transform.position =
                Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up * 1.5f);
        }
    }
}