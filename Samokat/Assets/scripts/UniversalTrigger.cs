using UnityEngine;
using UnityEngine.UI;

public enum TriggerType
{
    triggerButton,
    triggerAnimation,
    triggerSound
}

public class UniversalTrigger : MonoBehaviour
{
    public TriggerType triggerType;
    public Image button = null;
    public Animator myAnim = null;
    public string animationName;
    public AudioSource mySource = null;
    public AudioClip myClip;
    public bool destroy = false;

    void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InteractionTrigger();
        }
    }

    public void InteractionTrigger()
    {
        if (triggerType == TriggerType.triggerButton)
        {
            button.enabled = true;
            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }

        if (triggerType == TriggerType.triggerAnimation)
        {
            myAnim.Play(animationName);
            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }

        if (triggerType == TriggerType.triggerSound)
        {
            mySource.PlayOneShot(myClip);
            if (destroy == true)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (button != null)
        {
            button.enabled = false;
        }
    }
}
