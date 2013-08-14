using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	public GameObject note;
	public Transform[] origins;
	public float fps = 30.0f;
	
	private int[] notes = new int[]{1,0,0,2,0,0,3,0,0,4,0,0,1,0,0,2,0,0,3,0,0,4,0,0};
	private int indexNote;
	private int lastIndexNote;
	private float startTime;
	
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		indexNote = Mathf.FloorToInt( (Time.time - startTime) / (fps/1000) );
		
		if( indexNote >= notes.Length )
		{
			indexNote = 0;
			startTime = Time.time;
		}
		
		Debug.Log ("INDEX - "+indexNote);
		if( note != null && notes[indexNote] <= origins.Length && notes[indexNote] != 0 && indexNote != lastIndexNote )
		{
			GameObject go = Instantiate(note,origins[ notes[indexNote] - 1 ].position,origins[notes[indexNote] - 1].rotation) as GameObject;
			go.SendMessage("LetsGo",SendMessageOptions.DontRequireReceiver);
		}
		
		lastIndexNote = indexNote;
	}
}
