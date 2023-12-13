using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCLoadAvatar : MonoBehaviour
{
    public int index = 2;
    public SkinnedMeshRenderer[] bodyMeshes;

    [Header("hair on off setting")]
    public  bool isTurnedon = true;
    private void Start()
    {
        Debug.Log("this is a cc load avatar");

        GetBodyMeshes();
        
    }

    private void GetBodyMeshes()
    {
        int count = transform.childCount;
        Debug.Log(count);
        bodyMeshes = new SkinnedMeshRenderer[count];
        for (int i = 0; i < count -1; i++)
        {
            var childRender = transform.GetChild(i).GetComponent<SkinnedMeshRenderer>();
            if(childRender != null )
            {
                bodyMeshes[i] = childRender;
                Debug.Log("child " + i  + "name" + childRender.name);
            }
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            TurnHairOnOff();
        }
    }

    private void TurnHairOnOff()
    {
       

        if(isTurnedon)
        {
            bodyMeshes[index].gameObject.SetActive(false);
            isTurnedon=false;
        }
        else
        {
            bodyMeshes[index].gameObject.SetActive(true);
            isTurnedon=true;
        }
    }


}
