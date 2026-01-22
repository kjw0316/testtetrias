using UnityEngine;

public class GameCommander : MonoBehaviour
{
    /*
        점수
        맵 map 2차원 배열
        움직이고 있는 블록 blockCtrl
        홀딩 하고 있는 블록 blockCtrl
        나올 예정인 블록 spawner - blockCtrl[4]
     */

    public static GameCommander Instance;
    public Map map;

    private void Awake()
    {
        Instance = this;
    }
}
