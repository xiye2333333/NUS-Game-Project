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

        void Update()
        {
            transform.Find("PullDownText").GetComponent<Text>().text =
                "You need " + Gem + " gem to destory the building.";
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
            else
            {
                // GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayFail();
                // GameObject.Find("Upgrade").transform.Find("sure").gameObject.SetActive(false);
                // GameObject.Find("Upgrade").transform.Find("cancel").gameObject.SetActive(false);
                // GameObject.Find("Upgrade").transform.Find("cancel2").gameObject.SetActive(true);
                // if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Level < level)
                // {
                //     GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nInsufficient home level!";
                // }
                // else
                // {
                //     GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nNot enough resources!";
                // }
                Debug.Log("Not enough resources");
                GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayFail();
                GameObject.Find("PullDown").transform.Find("sure").gameObject.SetActive(false);
                GameObject.Find("PullDown").transform.Find("cancel").gameObject.SetActive(false);
                GameObject.Find("PullDown").transform.Find("cancel2").gameObject.SetActive(true);
                GameObject.Find("PullDownText").GetComponent<Text>().text = "Pull down Failed:\nInsufficient Gem!";
                // gameObject.SetActive(false);
                GameObject.Find("Canvas").transform.Find("BuildingInfo").GetComponent<Text>().text =
                    "PullDown Failed:\nNot enough resources!";
            }
        }

        public void OnClickCancel()
        {
            GameObject.Find("PullDown").transform.Find("sure").gameObject.SetActive(true);
            GameObject.Find("PullDown").transform.Find("cancel").gameObject.SetActive(true);
            GameObject.Find("PullDown").transform.Find("cancel2").gameObject.SetActive(false);
            GameObject.Find("PullDown").SetActive(false);
            if (GameObject.Find("Build Menu") == null)
            {
                GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
            }

            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
            {
                GameManager.getGM.SwitchToPause();
            }

            // gameObject.SetActive(false);
        }
    }
}