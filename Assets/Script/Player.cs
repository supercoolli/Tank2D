using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Animator m_animator;


    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    private float MoveVer(float ver, float hor)
    {
        if (hor != 0)
            return 0;
        return ver;
    }

    private float MoveHor(float ver, float hor)
    {
        if (ver != 0)
            return 0;
        return hor;
    }

    private void Move()
    {
        float ver = Input.GetAxisRaw("Vertical");

        float hor = Input.GetAxisRaw("Horizontal");

        Vector3 v2 = new Vector2(MoveHor(ver, hor), MoveVer(ver, hor));

        transform.position += v2 * Time.deltaTime * moveSpeed;

        if(v2.x != 0)
        {
            if (v2.x > 0) m_animator.SetInteger("Dir", 0);
            else m_animator.SetInteger("Dir", 1);
        }
        else
        {
            //if (v2.y > 0) m_animator.SetBool("Hor", true);
            //else m_animator.SetBool("Hor", false);
        }

    }
}
