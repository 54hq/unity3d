using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//收集输入集
public class InputCtrl : MonoBehaviour
{
    void SendInputCMD(KeyCode keyCode)
    {
        C2S.Instance.Key = keyCode.GetHashCode();
        Ray ray;
        RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            C2S.Instance.MousePosition = hit.point;
        }
        // PlayerFSM playerFSM = new PlayerFSM();
        // PlayerFSM. = c2sMSG;
        /*    c2sMSG.ID = 1;
        c2sMSG.key = keyCode.GetHashCode();*//*
         Ray ray;
        RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           if(Physics.Raycast(ray,out hit))
            {

           }*/
    }
    void Update()
    {
        C2S.Instance.Init();
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SendInputCMD(KeyCode.Mouse1);
        }


    }
}

    /*    // Start is called before the first frame update
        void Start()
        {

        }*/