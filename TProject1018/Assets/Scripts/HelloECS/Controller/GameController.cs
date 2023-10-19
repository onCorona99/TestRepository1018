using Entitas;
using UnityEngine;

/// <summary>
/// ��������������Unity������ִ�е�
/// </summary>
public class GameController : MonoBehaviour
{
    private Systems _systems;


    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ������
        var context = Contexts.sharedInstance;
        // "Systems" ������ȡ����
        _systems = new Feature("Systems").Add(new AddSystemsFeature(context));
        // ��ʼ��
        _systems.Initialize();

        EventSystem.Instance.SendEvent<GameLaunchEvent>(new GameLaunchEvent());
    }

    // Update is called once per frame
    void Update()
    {
        // ִ��
        _systems.Execute();
        // ���
        _systems.Cleanup();
    }
}