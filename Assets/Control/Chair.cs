using UnityEngine;

public class Chair : Interactable
{

    public bool isOn;

    private void Start()
    {
        
    }

    

    public override string GetDescription()
    {
        if (!isOn) return "Нажмите [E], чтобы сесть";
        return "Нажмите [E], чтобы встать";
    }

    public override void Interact()
    {
        if (!isOn)
        {
            FindObjectOfType<Control>().StartLesson();
            isOn = !isOn;
        }
        else
        {
            FindObjectOfType<Control>().LeaveLesson();
            isOn = !isOn;
        }
            
    }
}
