using UnityEngine;
using System.Collections;

public class SnapToAtom : MonoBehaviour {

	Rigidbody parentRB;

	void Start () {
		parentRB = transform.parent.GetComponent<Rigidbody>();
	}

	void Update()
	{
		
	}

	void OnTriggerEnter (Collider other) {
		Vector3 otherParentPos = other.transform.parent.position;
		Vector3 newPos;
		if (other.gameObject.CompareTag ("Atom")) {
			if (otherParentPos.x < other.transform.position.x) {
				newPos = new Vector3(otherParentPos.x + 0.5f + 0.5f, otherParentPos.y, otherParentPos.z);
			} else {
				newPos = new Vector3(otherParentPos.x - 0.5f - 0.5f, otherParentPos.y, otherParentPos.z);
			}
			parentRB.MovePosition (newPos);
		}
	}
}
