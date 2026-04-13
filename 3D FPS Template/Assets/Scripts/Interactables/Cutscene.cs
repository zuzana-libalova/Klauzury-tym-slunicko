using UnityEngine;
using UnityEngine.Playables;


public class Cutscene : Interactable
{
    public float duration = 5;
    public PlayableDirector playableDirector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Interact(Collider other)
    {
        base.Interact(other);
        PlayCutscene();
        
        // Invoke has a bit strange way of writing - you need to wrap the method name into nameof(MethodName) or just type it as string "MethodName"
        Invoke(nameof(StopCutscene),duration);
    }
    void PlayCutscene()
    {
        if (playableDirector != null)
            playableDirector.Play();

        FindFirstObjectByType<FirstPersonController.FirstPersonController>().CanMove=false;

        
    }

    void StopCutscene()
    {
        FindFirstObjectByType<FirstPersonController.FirstPersonController>().CanMove=true;        
    }
}

