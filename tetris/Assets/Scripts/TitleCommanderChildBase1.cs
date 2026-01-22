using UnityEngine;

public class TitleCommanderChildBase : CommanderChildBase
{
    protected TitleCommander _titleCommander;

    public override void Initialize(CommanderBase commander)
    {
        base.Initialize(commander);
        _titleCommander = commander as TitleCommander;
    }
}
