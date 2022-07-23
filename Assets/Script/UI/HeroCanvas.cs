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
        private void Update()
        {
            if (ObtainImage.active)
            {
                delta += Vector3.up * 50f * Time.deltaTime;
                ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position+
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
            ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up*1.5f);
        }
        
        public void ObtainStone(int stone)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Coal");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + stone;
            ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up*1.5f);
        }
        
        public void ObtainIron(int iron)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Silver Ingot");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + iron;
            ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up*1.5f);
        }

        public void ObtainGem(int gem)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Diamond");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + gem;
            ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up*1.5f);
        }
        
        public void ObtainHP(int hp)
        {
            time = Time.time;
            ObtainImage.SetActive(true);
            ObtainImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Staff/Heart");
            ObtainImage.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ObtainText.GetComponent<Text>().text = "+ " + hp;
            ObtainImage.transform.position = Camera.main.WorldToScreenPoint(Hero.transform.position + Vector3.up*1.5f);
        }
        
        
    }
}