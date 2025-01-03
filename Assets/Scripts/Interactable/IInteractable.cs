using UnityEngine;

namespace Interactable
{
    public interface IInteractable
    {
        void Interact();
        string GetInteractText();
        Transform GetTransform();
    }
}