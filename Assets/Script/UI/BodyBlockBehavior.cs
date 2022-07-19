using Script.Staff;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Script.UI
{
    public class BodyBlockBehavior: MonoBehaviour,IPointerClickHandler

    {
        public Equipment Equipment;

        public string BlockSpritePath = "halfcustomizible/rounded/Slot3D_rounded_HCC";


        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == 0)
            {
                Equipment.PutDown();
                GetComponent<Image>().sprite = Resources.Load<Sprite>(BlockSpritePath);
                GetComponent<Image>().color = new Color(255, 255, 255, 0);
                Destroy(this);
            }
        }
    }
}