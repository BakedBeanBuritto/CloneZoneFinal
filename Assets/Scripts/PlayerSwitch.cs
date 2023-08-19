using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public PlayerMovement MoveManager;
    public List<MonoBehaviour> CloneMovements = new List<MonoBehaviour>();
    public List<GameObject> CloneIndicators = new List<GameObject>();

    private int activeCloneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (CloneMovements.Count > 0)
        {
            CloneMovements[activeCloneIndex].enabled = true;
            CloneIndicators[activeCloneIndex].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            SwitchToNextClone();
        }
    }

    private void SwitchToNextClone()
    {
        CloneMovements[activeCloneIndex].enabled = false;
        CloneIndicators[activeCloneIndex].gameObject.SetActive(false);

        activeCloneIndex = (activeCloneIndex + 1) % CloneMovements.Count;

        CloneMovements[activeCloneIndex].enabled = true;
        CloneIndicators[activeCloneIndex].gameObject.SetActive(true);
    }
}
