using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour {

    public virtual Selectable Select()
    {
        return null;
    }

    public virtual Selectable Deselect()
    {
        return null;
    }
}
