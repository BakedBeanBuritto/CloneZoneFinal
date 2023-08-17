using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void Level1()
    {
        SceneManager.LoadScene("ButtonIntro");
    }

    public void Level2()
    {
        SceneManager.LoadScene("FenceLevel1");
    }

    public void Level3()
    {
        SceneManager.LoadScene("FenceLevel2");
    }

    public void Level4()
    {
        SceneManager.LoadScene("LazerIntro");
    }

    public void Level5()
    {
        SceneManager.LoadScene("LazerLevel2");
    }

    public void Level6()
    {
        SceneManager.LoadScene("LazerLevel3");
    }

    public void Level7()
    {
        SceneManager.LoadScene("FLCombo1");
    }

}
