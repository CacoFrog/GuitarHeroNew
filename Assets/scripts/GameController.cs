using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public float GameSpeedMultiply = 1.0f;
	
	public static GameController Instance;

	
	// Use this for initialization
	void Start () {
		if( Instance == null )
			Instance = this;
		else
			Destroy(this);
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
