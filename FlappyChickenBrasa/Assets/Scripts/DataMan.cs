using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMan : Manager<DataMan>
{
    public UserData userData;
    public OptionsData optionsData;
    ValueKey<bool> hasData = new ValueKey<bool>("hasData_key", false);

    protected override void Awake()
    {
        base.Awake();
        Initialize();
    }

    public void Initialize()
    {
        userData = new UserData();
        optionsData = new OptionsData();
        LoadOrCreate(); 
    }


    public void LoadOrCreate()
    {
        if (!PlayerPrefUtils.HasKey(hasData.key))
        {
            Debug.Log("creating default options data");
            PlayerPrefUtils.SetValue(true, ref hasData);
            this.userData.SetDefaults();
            this.optionsData.SetDefaults();
        }
        else
        {
            Debug.Log("laoding default options data");
            this.userData.LoadData();
            this.optionsData.LoadData();
        }
    }


    public void Reset()
    {
        userData.SetDefaults();
        optionsData.SetDefaults();       
    }

}
