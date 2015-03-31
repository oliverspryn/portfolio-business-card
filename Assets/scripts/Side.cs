using UnityEngine;
using System.Collections;

public class Side : MonoBehaviour {
	#region Fields

/// <summary>
/// The URL of the texture to apply to this side of the card.
/// </summary>
	public string URL = "https://www.google.com/images/srpr/logo11w.png";

	#endregion

	#region Methods

/// <summary>
/// Initializes the texture for this side of the card and loads the texture
/// from the internet.
/// </summary>
/// 
/// <returns>The object which loads the material from the internet</returns>
	public IEnumerator Start() {
		Renderer ren = gameObject.GetComponent<Renderer>();

	//Hide the object until the texture is loaded
		ren.enabled = false;

	//Synchronously load the texture
		WWW www = new WWW(URL);
		yield return www;
		ren.material.mainTexture = www.texture;

	//Now show the object
		ren.enabled = true;
	}

	#endregion
}