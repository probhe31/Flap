using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudText : MonoBehaviour
{
    Text text;
    private void Awake()
    {
        text = this.GetComponent<Text>();
    }

    public void SetText(string val)
    {
        text.text = val;
    }

    public void SetText(int val)
    {
        text.text = ""+val;
    }
}
