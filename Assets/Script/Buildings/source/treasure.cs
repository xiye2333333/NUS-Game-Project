using Script.BuildingSystem;
using Script.UI;
using UnityEngine;


public class treasure : Building
{
    public int addGem;
    public int day = 0;

    void Start()
    {
        level = 3;
        name = "Treasure Chest(max)";
        addGem = 1;
        Info = "Treasure Chest(max)\nGet 1 gem every day.\nIt appreciates your creation.";
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            day++;
            if (day % 1 == 0)
            {
                GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem += addGem;
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainGem(addGem);
                GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayDiamond();
            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(1))
        {
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
            {
                if (GameObject.Find("Build Menu") != null)
                    GameObject.Find("Build Menu").SetActive(false);
                if (GameObject.Find("BuildButton") != null)
                    GameObject.Find("BuildButton").gameObject.SetActive(false);
                if (GameObject.Find("BagButton") != null)
                    GameObject.Find("BagButton").gameObject.SetActive(false);
                GameManager.getGM.SwitchToUpgrading();
                
                GameObject.Find("Canvas").transform.Find("PullDown").gameObject.SetActive(true);
                GameObject.Find("PullDown").GetComponent<PullDown>().TargetBuilding = gameObject;
            }
        }
    }
    public override void Culculate()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem += 1;
    }
}