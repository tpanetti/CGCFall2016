using UnityEngine;
using System.Collections;

public class GenericMove : MonoBehaviour {
  public KeyCode left;
  public KeyCode right;
  public KeyCode jump;
  public KeyCode shoot;

  public float movSpeed;
  public float jumpForce;
  public float shootSpeed;

  public bool canJump;


	// Use this for initialization
	void Start () {
	 movSpeed = 50.0f;
   jumpForce = 30.0f;
   shootSpeed = 300.0f;
   canJump = true;



	}
	
	// Update is called once per frame
	void Update () {
	 //Let's check for our movement
    if(Input.GetKey(this.left)){
      this.transform.Translate(Vector2.left*movSpeed*Time.deltaTime);
    }

    if(Input.GetKey(this.right)){
      this.transform.Translate(Vector2.right*movSpeed*Time.deltaTime);
    }

    if(Input.GetKeyDown(this.jump) && this.canJump) {
        // this.canJump = false;
      this.transform.Translate(Vector2.up*jumpForce);
    }
    if(Input.GetKeyDown(this.shoot)) {
      //TODO: this

    }

	}



  void OnCollisionEnter2D(Collision2D collInfo){
    Debug.Log("Collision Enter");
    if(collInfo.gameObject.name == "Terrain")
      canJump = true;
  }
  void OnCollisionExit2D(Collision2D collInfo){
    Debug.Log("Collision Exit");
    if(collInfo.gameObject.name == "Terrain")
      canJump = false;
  }
}
