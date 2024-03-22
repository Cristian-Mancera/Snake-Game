using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    bool up = false;
    bool down = false;
    bool left = false;
    bool right = false;
    int MovInd = 4;

    public void ClickUp()
    {

        up = true;
    }
    public void ReleaseUp()
    {

        up = false;
    }
    public void ClickDown()
    {

        down = true;
    }
    public void ReleaseDown()
    {

        down = false;
    }
    public void ClickLeft()
    {

        left = true;
    }
    public void ReleaseLeft()
    {

        left = false;
    }
    public void ClickRight()
    {

        right = true;
    }
    public void ReleaseRight()
    {

        right = false;
    }


    private void FixedUpdate()
    {
        if(up){
            MovInd = 3;
        }
        if(down){
            MovInd = 2;
        }
        if(left){
            MovInd = 1;
        }
        if(right){
            MovInd = 0;
        }


        if (MovInd == 0)
            gameObject.transform.Translate(1f * Time.deltaTime, 0, 0);
            left = false;
        if (MovInd == 1)
            gameObject.transform.Translate(-1f * Time.deltaTime, 0, 0);
            right = false;
        if (MovInd == 2)
            gameObject.transform.Translate(0, -1f * Time.deltaTime, 0);
            up = false;
        if (MovInd == 3)
            gameObject.transform.Translate(0, 1f * Time.deltaTime, 0);
            down = false;

    }





}
