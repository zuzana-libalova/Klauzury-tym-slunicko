using System;
using Core;
using TMPro;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class Dialogue : Interactable

{
    
    
    [System.Serializable]
    public class DialogueLine
    {
        public string Text;

    }
    public List <DialogueLine> dialog;
    int index = 0;
    private TextMeshProUGUI dialogueUI;
    private void Start()
    {
        dialogueUI = Interface.Instance.dialogueUI;
    }

    // Show dialogue when interaction starts
    public override void Interact(Collider other)
    {
        base.Interact(other);
        dialogueUI.text = dialog[index].Text;
        
        if (index<dialog.Count-1)
        {
            index+=1;
            
        }
        
    }

    // Clear dialogue when interaction stops
    public override void StopInteraction(Collider other)
    {
        base.StopInteraction(other);

        dialogueUI.text = "";
    }
}
