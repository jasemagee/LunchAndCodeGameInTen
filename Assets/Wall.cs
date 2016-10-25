using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{

    private bool begunAttack = false;
    private float speed = 4f;


	// Use this for initialization
	void Start () {
	    DeleteRandomChild();
        Invoke("BeginAttack", 2f);
	}
	
	// Update is called once per frame
	void Update () {
	    if (begunAttack)
	    {
	        transform.position =new Vector3(transform.position.x,
                transform.position.y, 
                transform.position.z + (speed*Time.deltaTime));
	    }
	}

    private void BeginAttack()
    {
        begunAttack = true;
    }

    void DeleteRandomChild()
    {
        var randomChildIndex = Random.Range(0, transform.childCount);
        Destroy(transform.GetChild(randomChildIndex).gameObject);
    }
}
