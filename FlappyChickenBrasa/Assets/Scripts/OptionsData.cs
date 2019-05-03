using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsData
{
    ValueKey<bool> _isFullScreen = new ValueKey<bool>("options_isFullScreen_key", false);
    ValueKey<int> _scale = new ValueKey<int>("options_scale_key", 1);
    ValueKey<string> _language = new ValueKey<string>("options_language_key", "EN");
    ValueKey<float> _sfxVolume = new ValueKey<float>("options_sfxVolume_key", 1);
    ValueKey<float> _musicVolume = new ValueKey<float>("options_musicVolume_key", 1);
   
    public bool IsFullScreen
    {
        get
        {
            PlayerPrefUtils.LoadValue(ref _isFullScreen);
            return _isFullScreen.value;
        }
        set
        {
            PlayerPrefUtils.SetValue(value, ref _isFullScreen);
        }
    }

    public int Scale
    {
        get
        {
            PlayerPrefUtils.LoadValue(ref _scale);
            return _scale.value;
        }
        set
        {
            PlayerPrefUtils.SetValue(value, ref _scale);
        }
    }

    public string Language
    {
        get
        {
            PlayerPrefUtils.LoadValue(ref _language);
            return _language.value;
        }
        set
        {
            PlayerPrefUtils.SetValue(value, ref _language);
        }
    }

    public float SfxVolume
    {
        get
        {
            PlayerPrefUtils.LoadValue(ref _sfxVolume);
            return _sfxVolume.value;
        }
        set
        {
            PlayerPrefUtils.SetValue(value, ref _sfxVolume);
        }
    }

    public float MusicVolume
    {
        get
        {
            PlayerPrefUtils.LoadValue(ref _musicVolume);
            return _musicVolume.value;
        }
        set
        {
            PlayerPrefUtils.SetValue(value, ref _musicVolume);
        }
    }


    public void LoadData()
    {
        PlayerPrefUtils.LoadValue(ref _isFullScreen);
        PlayerPrefUtils.LoadValue(ref _scale);
        PlayerPrefUtils.LoadValue(ref _language);
        PlayerPrefUtils.LoadValue(ref _sfxVolume);
        PlayerPrefUtils.LoadValue(ref _musicVolume);
    }

    public void SetDefaults()
    {
        PlayerPrefUtils.SetDefaultValue(ref _isFullScreen);
        PlayerPrefUtils.SetDefaultValue(ref _scale);
        PlayerPrefUtils.SetDefaultValue(ref _language);
        PlayerPrefUtils.SetDefaultValue(ref _sfxVolume);
        PlayerPrefUtils.SetDefaultValue(ref _musicVolume);
    }

}
