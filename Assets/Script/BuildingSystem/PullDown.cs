using UnityEngine;
using UnityEngine.UI;
namespace Script.BuildingSystem
{
    public class PullDown : MonoBehaviour
    {
        public GameObject Hero;

        public GameObject TargetBuilding;

        //public static int Gem;
        private int Gem = 2;

        public static int PullDownCnt = 1;

        void Update() {
            transform.Find("PullDownText").GetComponent<Text>().text = "You need " + Gem + " gem to destory the building.";
        }
        
        public void OnClickSure()
        {
            HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
            if (heroBehavior.Gem >= Gem)
            {
                heroBehavior.Gem -= Gem;
                PullDownCnt++;
                Gem += 2;
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
            else{
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
                GameObject.Find("Canvas").transform.Find("BuildingInfo").GetComponent<Text>().text = "PullDown Failed:\nNot enough resources!";
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