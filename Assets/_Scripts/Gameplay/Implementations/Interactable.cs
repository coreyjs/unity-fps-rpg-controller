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

    public void Drop()
    {
        throw new System.NotImplementedException();
    }

    public void Pickup(Transform parent)
    {
        throw new System.NotImplementedException();
    }
}
