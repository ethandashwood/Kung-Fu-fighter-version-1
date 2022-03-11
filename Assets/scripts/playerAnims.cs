using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnims : MonoBehaviour
{
    static bool playWalkingAnim;
    static bool playIdleAnim;
    static bool playPunchAnim;

    private Animator anim;

    void Start()
    {
        playWalkingAnim = false;
        playIdleAnim = false;
        playPunchAnim = false;

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        

        if (playWalkingAnim)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }


        if (playIdleAnim)
        {
            anim.SetBool("isIdle", true);
        }
        else
        {
            anim.SetBool("isIdle", false);
        }

    }

    public void PlayerWalking()
    {
        playWalkingAnim = true;

    }

    public void PlayerIdle()
    {
        playIdleAnim = true;
    }

    public void PlayerPunch()
    {

    }

    IEnumerator PunchWait()
    {
        anim.SetBool("isPunch", true);

        yield return new WaitForSeconds(2);

        anim.SetBool("isPunch", false);

    }


}
