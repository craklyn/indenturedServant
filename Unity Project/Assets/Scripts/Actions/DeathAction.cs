using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : GameAction {
    
    public override void DoAction()
    {
        Destroy(gameObject);
    }
}
