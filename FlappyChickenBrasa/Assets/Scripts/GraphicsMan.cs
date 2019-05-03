using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsMan : Manager<GraphicsMan>
{
    bool isFullscreen = false;
    int scale = 1;

    protected override void Awake()
    {
        base.Awake();
        GetAllResolutions();    
    }

    void Start()
    {
        EnableVSync();

        if (Manager<DataMan>.Get().optionsData.IsFullScreen)
        {
            SetFullscreen();
        }
        else
        {
            SetScaleResolutionX(Manager<DataMan>.Get().optionsData.Scale);
        }

    }


    public Resolution[] resolutions;

    void GetAllResolutions()
    {
        resolutions = Screen.resolutions;
    }

    Resolution GetMaxResolution()
    {
        return resolutions[resolutions.Length - 1];       
    }

   

    public void DisableVSync()
    {
        QualitySettings.vSyncCount = 0;
    }

    public void EnableVSync()
    {
        QualitySettings.vSyncCount = 1;
        Limit60FPS();
    }


    public void Limit60FPS()
    {
        Application.targetFrameRate = 60;
    }

    

    public void SetFullscreen()
    {
        this.isFullscreen = true;
        Screen.SetResolution(GetMaxResolution().width, GetMaxResolution().height, this.isFullscreen);
        Screen.fullScreen = this.isFullscreen;

        Manager<DataMan>.Get().optionsData.IsFullScreen = this.isFullscreen;
        Manager<DataMan>.Get().optionsData.Scale = this.scale;
    }

    public void SetNativeResolution()
    {
        this.isFullscreen = false;
        this.scale = 0;
        Screen.fullScreen = this.isFullscreen;
        Screen.SetResolution(Constants.WIDTH, Constants.HIGH, this.isFullscreen);

        Manager<DataMan>.Get().optionsData.IsFullScreen = this.isFullscreen;
        Manager<DataMan>.Get().optionsData.Scale = this.scale;
    }

    public void SetScaleResolutionX(int _scale)
    {
        this.isFullscreen = false;
        this.scale = _scale;
        Screen.fullScreen = this.isFullscreen;
        Screen.SetResolution(Constants.WIDTH * this.scale, Constants.HIGH * scale, this.isFullscreen);

        Manager<DataMan>.Get().optionsData.IsFullScreen = this.isFullscreen;
        Manager<DataMan>.Get().optionsData.Scale = this.scale;
    }

    public void SetScaleResolution()
    {
        this.isFullscreen = false;
        this.scale = Manager<DataMan>.Get().optionsData.Scale;

        Screen.fullScreen = this.isFullscreen;
        Screen.SetResolution(Constants.WIDTH * this.scale, Constants.HIGH * scale, this.isFullscreen);

        Manager<DataMan>.Get().optionsData.IsFullScreen = this.isFullscreen;
        
    }
}
