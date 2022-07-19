using System;
using Script.Staff;
using Unity.VisualScripting;
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

        // public void OnMouseDown()
        // {
        //     throw new NotImplementedException();
        // }

        public void OnPointerClick(PointerEventData eventData)
        {
            // HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            Debug.Log("Put on");
            if (eventData.button == 0)
            {
                Equipment.PutUp();
                isPutOn = true;
                gameObject.GetComponent<Image>().sprite = selfSprite;
                Destroy(this);
            }
        }
    }
}