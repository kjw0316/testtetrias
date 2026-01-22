using UnityEngine;

public class TitleCommander : CommanderBase
{
    [SerializeField]
    private CommanderChildBase[] _childCommanders;

    public void Awake()
    {
        foreach (var childCommander in _childCommanders)
        {
            childCommander.Initialize(commander: this);
        }
    }
    public void StartGame()
    {
        Managers.Game.SetState(GameState.Game);
    }
}