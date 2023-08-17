using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public PlayerMovement MoveManager;
    public FenceCloneMovement FenceClone;
    public LazerCloneMovement LazerClone;

    public GameObject PlayerIndicator;
    public GameObject FenceCloneIndiator;
    public GameObject LazerCloneIndicator;

    public bool PlayerActive = true;
    public bool FenceCloneActive = false;
    public bool LazerCloneActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToFenceClone()
    {
        FenceCloneActive = true;

        if (FenceCloneActive==true)
        {
            MoveManager.enabled = false;
            LazerClone.enabled = false;
            FenceClone.enabled = true;

            PlayerActive = false;
            LazerCloneActive = false;

            FenceCloneIndiator.gameObject.SetActive(true);
            LazerCloneIndicator.gameObject.SetActive(false);
            PlayerIndicator.gameObject.SetActive(false);
        }
    }

    public void SwitchToLazerClone()
    {
        LazerCloneActive = true;

        if (LazerCloneActive == true)
        {
            MoveManager.enabled = false;
            LazerClone.enabled = true;
            FenceClone.enabled = false;

            PlayerActive = false;
            FenceCloneActive = false;

            LazerCloneIndicator.gameObject.SetActive(true);
            FenceCloneIndiator.gameObject.SetActive(false);
            PlayerIndicator.gameObject.SetActive(false);
        }
    }

    public void SwitchToPlayer()
    {
        PlayerActive = true;

        if (PlayerActive == true)
        {
            MoveManager.enabled = true;
            LazerClone.enabled = false;
            FenceClone.enabled = false;

            FenceCloneActive = false;
            LazerCloneActive = false;

            PlayerIndicator.gameObject.SetActive(true);
            LazerCloneIndicator.gameObject.SetActive(false);
            FenceCloneIndiator.gameObject.SetActive(false);
        }
    }
}
