using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	#region Fields

/// <summary>
/// The number of degrees which the card will rotate on each frame update.
/// </summary>
	public float RotationRate = -0.05f;

	#endregion

	#region Methods

/// <summary>
/// This update method will slowly rotate the card along the Y-axis.
/// </summary>
	public void Update() {
		gameObject.transform.Rotate(0.0f, RotationRate, 0.0f);
	}

	#endregion
}