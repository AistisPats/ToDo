using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class edit : MonoBehaviour
{
    public TMP_InputField descriptionText;
    public TaskUI tu;


    public void EditTask()
    {
        descriptionText.text = tu.task.Description;
        tu.DestroyTask();
    }
}
