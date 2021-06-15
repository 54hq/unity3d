using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PAClip 
{
    None,
    Idle,
    Run,
    //NormalAttack,
}

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    public string[] Clips = new string[] { "None", "Idle", "Run" };
    // Start is called before the first frame update
    void Start()
    {
        animator = this.transform.GetComponent<Animator>();
    }
    public void play(PAClip clip)
    {
        ResetState();
        animator.SetBool(clip.ToString(), true);

    }
    private void ResetState()
    {
        for (int i = 0; i < Clips.Length; i++)
        {
            animator.SetBool(Clips[i], false);
        }
    }
}
    //A事件
/*    public void DoSkillAEvent()
    {
        SpawnEffect("A");
    }
}*/
    // Update is called once per frame
/*    void Update()
    {
        
    }
}*/
