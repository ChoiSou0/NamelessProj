using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inven_Mgr : MonoBehaviour
{
    public List<Slot> slot = new List<Slot>();
    public int MaxSlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NoSlotWarning();                                                                                                              
    }

    private void NoSlotWarning()
    {
        if (slot.Count == MaxSlot)
            Debug.Log("�κ��丮�� �� á���ϴ�");
    }
}
