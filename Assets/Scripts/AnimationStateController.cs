using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    public Animator anim;
    private string[] dialogList;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        dialogList = new string[] {
            "Genesis8Female|Begruessung",
            "Genesis8Female|SchonmalInPraxis",
            "Genesis8Female|Fieber",
            "Genesis8Female|HabenSieSchmerzen",
            "Genesis8Female|StelleSchmerzen",
            "Genesis8Female|Zeigen",
            "Genesis8Female|NehmeBlutAb",
            "Genesis8Female|AngstVorSpritzen",
            "Genesis8Female|LinkerArm",
            "Genesis8Female|Arbeitsunfähigkeitsbescheinigung",
            "Genesis8Female|VorneNeuerTermin",
            "Genesis8Female|FallsNochEtwasIst",
            "Genesis8Female|GuteBesserung",
            "Genesis8Female|AufWiedersehen"
        };

        index = 0;
    }

    // Call this method when clicker is used
    public void playNextAnimation()
    {
        if (index < dialogList.Length)
        {
            anim.Play(dialogList[index]);
            index++;
        }
    }
}
