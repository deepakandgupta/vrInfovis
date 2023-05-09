using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ToggleInfoBox : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isShown = false;
    private XRBaseInteractable interactable;

    public GameObject infoBox;
    private void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
    }

    private void OnEnable()
    {
        // Subscribe to the XRBaseInteractable events
        // Hover Events
        interactable.hoverEntered.AddListener(OnHoverEnter);
        interactable.hoverExited.AddListener(OnHoverExit);

  
    }

    private void OnDisable()
    {
        // Unsubscribe from the XRBaseInteractable events
        interactable.hoverEntered.RemoveListener(OnHoverEnter);
        interactable.hoverExited.RemoveListener(OnHoverExit);

    }
    

    public void OnHoverEnter(HoverEnterEventArgs args)
    {
        
        isShown = !isShown;
        if (infoBox != null) {
            infoBox.SetActive(isShown);
        }
    }

    public void OnHoverExit(HoverExitEventArgs args)
    {
    }
}
