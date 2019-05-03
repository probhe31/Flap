using UnityEngine;
using System.Collections;

public class Manager<T> : MonoBehaviour where T:Manager<T> {

    private static T instance;    

    protected virtual void Awake()
    {
        Manager<T>.instance = (T)this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    void OnDestroy()
    {
        Manager<T>.instance = (T)null;
    }

    public static T Get()
    {       
        if (null == Manager<T>.instance)
            return FindObjectOfType<T>();

        return Manager<T>.instance;
    }

}
