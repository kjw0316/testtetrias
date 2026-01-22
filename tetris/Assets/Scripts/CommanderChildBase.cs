using UnityEngine;

public class CommanderChildBase : MonoBehaviour
{
    protected CommanderBase _commander;

    public virtual void Initialize(CommanderBase commander)
    {
        _commander = commander;
    }
}
