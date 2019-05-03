using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontKillme : MonoBehaviour
{
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
