using System;
using Script.Staff;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Script.UI
{
    public class EquipmentBagBlockBehavior : MonoBehaviour, IPointerClickHandler
    {
        public Equipment Equipment;

        public bool isPutOn;

        public Sprite selfSprite;

        public GameObject back;

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
                    GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
                    Destroy(this);
                }

            }
        }

        // public void OnMouseEnter()
        // {
        //     back.GetComponent<Image>().color = new Color(109/255f, 205/255f, 205/255f, 255f);
        // }
        //
        // public void OnMouseExit()
        // {
        //     back.GetComponent<Image>().color = new Color(255/255f, 255/255f, 255/255f, 255/255f);
        // }
    }
}