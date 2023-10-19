using Entitas;
using UnityEngine;

/// <summary>
/// 控制器，挂在在Unity场景中执行的
/// </summary>
public class GameController : MonoBehaviour
{
    private Systems _systems;


    // Start is called before the first frame update
    void Start()
    {
        // 获取上下文
        var context = Contexts.sharedInstance;
        // "Systems" 名称自取即可
        _systems = new Feature("Systems").Add(new AddSystemsFeature(context));
        // 初始化
        _systems.Initialize();

        EventSystem.Instance.SendEvent<GameLaunchEvent>(new GameLaunchEvent());
    }

    // Update is called once per frame
    void Update()
    {
        // 执行
        _systems.Execute();
        // 清除
        _systems.Cleanup();
    }
}