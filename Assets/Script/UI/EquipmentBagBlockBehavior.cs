using System;
using Script.Staff;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Script.UI
{
    public class EquipmentBagBlockBehavior : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler
    {
        public Equipment Equipment;

        public bool isPutOn;

        public Sprite selfSprite;

        public GameObject back;

        public GameObject InfoText;

        // public void OnMouseDown()
        // {
        //     throw new NotImplementedException();
        // }

        public void OnPointerClick(PointerEventData eventData)
        {
            // HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            // Debug.Log("Put on");
            if (eventData.button == 0)
            {
                if (Equipment.BodyBlockIsEmpty())
                {
                    Equipment.PutUp();
                    isPutOn = true;
                    gameObject.GetComponent<Image>().sprite = selfSprite;
                    back.GetComponent<Image>().color = new Color(255/255f, 255/255f, 255/255f, 255/255f);
                    GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayEquipment();
                    Destroy(this);
                }

            }
        }

        private void OnMouseEnter()
        {
            Debug.Log(1);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            string text = "";
            text += Equipment.name + "\n";
            text += Equipment.info + "\n";
            InfoText.GetComponent<Text>().text = text;
        }
    }
}