using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public TaskUI tu;
    public void TrashTask()
    {
        tu.DestroyTask();
    }
}
