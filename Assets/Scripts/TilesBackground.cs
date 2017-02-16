using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesBackground : MonoBehaviour {

	public int textureSize = 32;
	public bool scaleHorizontally = true;
	public bool scaleVertically = true;

	// Use this for initialization
	void Start () {

		var newWidt = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
		var newHeigth = !scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));

		transform.localScale = new Vector3(newWidt * textureSize, newHeigth * textureSize, 1);
		GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidt,newHeigth,1);

	}
	

}
