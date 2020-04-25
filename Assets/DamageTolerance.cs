using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTolerance : MonoBehaviour
{
    public PlayerMovement toleranceData;
    public Text toleranceText;

    // Update is called once per frame
    void Update()
    {
        toleranceText.text = toleranceData.remainingLife.ToString();
    }
}
