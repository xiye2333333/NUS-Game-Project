using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public GameObject introductionImage;

    public GameObject introductionText;

    private Text introText;

    private float step = 0;

    private int cnt = 0;

    private string text = "";

    public GameObject Hero;

    public GameObject StorePage;
    
    public GameObject bag;

    // Start is called before the first frame update
    void Start()
    {
        introText = introductionText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (step == 0)
        {
            text =
                "Welcome to the game!\nPlease click me to start a guidance.\nIf you close this window, it will not show again.";
        }
        else if (step >= 1 && step < 2)
        {
            if (step == 1)
            {
                text =
                    "Try to use <color=#FF0000>A/D</color> to move your screen.\n This will work when game is paused like now." +
                    "\nTry <color=#FF0000>D</color> first.";
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (step == 1.1f)
                {
                    step = 2;
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                text = "Try to use <color=#FF0000>A</color> to move your screen.";
                step = 1.1f;
            }
        }
        else if (step >= 2 && step < 3)
        {
            if (step == 2)
            {
                text =
                    "You can also try to move your <color=#FF0000>mouse</color> on the screen side to move your screen.\n " +
                    "This will work when game is paused like now." +
                    "\nTry the right side of the screen first.";
            }

            if (Input.mousePosition.x < 10)
            {
                if (step == 2.1f)
                {
                    step = 3;
                }
            }

            if (Input.mousePosition.x > Screen.width - 10)
            {
                text = "Try left side!";
                step = 2.1f;
            }
        }
        else if (step >= 3 && step < 4)
        {
            if (step == 3)
            {
                text = "Now try to press <color=#FF0000>space</color> to start the game.";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    text = "Now try to press <color=#FF0000>space</color> to stop the game.";
                    step = 3.1f;
                }
            }
            else if (step == 3.1f)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    step = 4f;
                }
            }
        }
        else if (step >= 4 && step < 5)
        {
            if (step == 4)
            {
                text = "Now let's try to build your first building!\n" +
                       "Click <color=#FF0000>build</color> button to open the build menu.";
            }
            else if (step == 4.1f)
            {
                text = "Click the first build (hunted house). \nIt will create a monster when the hero pass it.\n" +
                       "Defeat the monster to get some money and other resources.";
            }
            else if (step == 4.2f)
            {
                text = "Choose a valid place to build it!\n" +
                       "<color=#FF0000>Red</color> means invalid or lacking of resource, <color=#66CD00>green</color> means valid.";
                if (Hero.GetComponent<HeroBehavior>().BuildingList.Count > 0)
                {
                    step = 5f;
                }
            }
        }
        else if (step >= 5 && step < 6)
        {
            if (step == 5)
            {
                text = "Now your first day is started!\n" +
                       "Please watching the hero fight with the monster to know the fighting part.";
                if (Hero.GetComponent<HeroBehavior>().Money > 300)
                {
                    step = 6f;
                }
            }
        }
        else if (step >= 6 && step < 7)
        {
            text =
                   "Now you can click <color=#FF0000>speed up</color>button or double press H to run out of the first day.";
            if (TimeManager.GlobalDay == 2)
            {
                step = 7f;
            }
        }
        else if (step >= 7f && step < 8f)
        {
            if (step == 7)
            {
                text = "Here comes a merchant!\n" +
                       "Click him to open the store page. \n" +
                       "He will tell you some plot everyday when you open the store.";
                if (StorePage.active)
                {
                    step = 7.1f;
                }
            }else if (step == 7.1f)
            {
                text = "Click the <color=#FF0000>knife</color> to buy it!.";
                if (Hero.GetComponent<HeroBehavior>().EquipmentBag.Count != 0)
                {
                    step = 8f;
                }
            }
        } else if (step >= 8f && step < 9f)
        {
            if (step == 8f)
            {
                text = "Now close the store and click the <color=#FF0000>bag button</color> to open your bag!";
                if (bag.active && !StorePage.active)
                {
                    step = 8.1f;
                }
            } else if (step == 8.1f)
            {
                text = "Now you can click the <color=#FF0000>knife</color> to put on it!\n" +
                       "The weapon will increase your attack power. Make it easier to defeat the monster.";
                if (Hero.GetComponent<HeroBehavior>().Weapon != null)
                {
                    step = 9f;
                }
            }
        } else if (step >= 9f)
        {
            if (step == 9f)
            {
                text = "Now all the introductions are finished!\n" +
                       "You can close this window and enjoy the game!\n" +
                       "If you still have questions, please click the <color=#FF0000>help button</color>.";
            }
        }

        introText.text = text;
    }

    public void OnClick()
    {
        if (step == 0)
        {
            step = 1;
        }
    }

    public void OnClickBuildButton()
    {
        if (step == 4)
        {
            step = 4.1f;
        }
    }

    public void OnClickHuntedHouse()
    {
        if (step == 4.1f)
        {
            step = 4.2f;
        }
    }
    

}