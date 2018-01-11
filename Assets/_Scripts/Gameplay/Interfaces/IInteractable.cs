using System;
using UnityEngine;

public interface IInteractable
{
    void Drop();

    void Pickup(Transform parent);
}