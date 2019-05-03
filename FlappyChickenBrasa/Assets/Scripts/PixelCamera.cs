using UnityEngine;
using System.Collections;

[AddComponentMenu("Util/Pixel Perfect Camera")]
public class PixelCamera : MonoBehaviour
{
	Camera _camera;
	private static PixelCamera _instance;

	public static PixelCamera Instance
	{
		get
		{
			return _instance;
		}
	}

	void Awake() 
	{
		if (_instance == null) 
		{
			_instance = this;
		}

		_camera = this.GetComponent<Camera>();
		ApplyFormulaPixelPerfect();
	
	}      

    void Update()
    {
        ApplyFormulaPixelPerfect();
    }

	void ApplyFormulaPixelPerfect() 
	{
		_camera.orthographicSize = (Constants.HIGH / Constants.PPU) * 0.5f;
    }
}
