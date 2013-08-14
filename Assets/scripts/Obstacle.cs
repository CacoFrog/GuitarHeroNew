using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	private bool start = false;
	public float speed = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if( !start )
			return;
		
		this.transform.position += Vector3.back*Time.deltaTime*speed*GameController.Instance.GameSpeedMultiply;
		
	}
	
	void OnTriggerEnter(Collider otherCollider)
	{
		
		whenCollided(otherCollider);
	}
	
	void OnTriggerStay(Collider otherCollider)
	{
		whenCollided(otherCollider);
	}
	
	private void whenCollided(Collider otherCollider)
	{
		Debug.Log("COLLIDER");
		
		if( otherCollider.gameObject.name == "NoteDestroyer" )
		{
			Destroy( this.gameObject );
		}
	}
	
	public void LetsGo()
	{
		start = true;
	}
}
