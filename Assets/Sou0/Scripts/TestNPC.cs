using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNPC : NPC
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    public override void ActionKey()
    {
        if (enable)
        {
            Debug.Log("��ȣ�ۿ�");
            switch (Type)
            {
                case InteractionType.NONE:
                    Debug.LogError("Ÿ�Ծ���");
                    break;
                case InteractionType.SHOP:
                    Debug.Log("��������");
                    break;
            }
        }
    }
}
