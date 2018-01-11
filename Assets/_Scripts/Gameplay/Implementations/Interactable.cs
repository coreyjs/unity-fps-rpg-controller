using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{

    #region Interactable Members
    public bool CanPickUp = true;

    public bool CanRotate = true;

    public string messageText = "This is an interactable object";

    private Transform _parent = null;

	private bool _itemIsCurrentlyHeld = false;

    private bool _isRotating = false;

    private Quaternion _defaultRotation;
    #endregion

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_itemIsCurrentlyHeld) 
		{
			transform.position = _parent.position;

			// lock down rotation
			if(!_isRotating) 
			{
				transform.rotation = _defaultRotation;
			}
		}

    }

	public bool CanPickupItem()
	{
		return _itemIsCurrentlyHeld ? false : true;
	}

    public void Drop()
    {
        Debug.Log("Interactable#Drop()");
		_itemIsCurrentlyHeld = false;
		transform.GetComponent<Rigidbody>().useGravity = true;
    }

    public void Pickup(Transform parent)
    {
        throw new System.NotImplementedException();
    }
}
