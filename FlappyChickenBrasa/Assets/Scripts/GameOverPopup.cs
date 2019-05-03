using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPopup : MonoBehaviour
{
    public void Show()
    {
        this.gameObject.SetActive(false);
    }

    public void Hide()
    {
        this.gameObject.SetActive(true);

    }
}
