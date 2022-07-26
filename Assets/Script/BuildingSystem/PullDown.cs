using UnityEngine;

namespace Script.BuildingSystem
{
    public class PullDown : MonoBehaviour
    {
        public GameObject Hero;

        public GameObject TargetBuilding;

        private int Gem = 2;
        
        public void OnClickSure()
        {
            HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
            if (heroBehavior.Gem >= Gem)
            {
                heroBehavior.Gem -= Gem;
                TargetBuilding.GetComponent<Building>().PullDown();
                GameManager.getGM.Buildings.Remove(TargetBuilding);
                heroBehavior.BuildingList.Remove(TargetBuilding);
                Destroy(TargetBuilding);
                if (GameObject.Find("Build Menu") == null)
                {
                    GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
                    GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
                }

                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
                {
                    GameManager.getGM.SwitchToPause();
                }
                gameObject.SetActive(false);
            }

        }

        public void OnClickCancel()
        {
            
            if (GameObject.Find("Build Menu") == null)
            {
                GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
            }

            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
            {
                GameManager.getGM.SwitchToPause();
            }
            
            gameObject.SetActive(false);
        }
    }
}