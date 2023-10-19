
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class HelloECSSystem : ReactiveSystem<GameEntity>,IEventHandler<GameLaunchEvent>
{
    /// <summary>
    /// ��������������������
    /// Ŀǰ������ֻ�� Game��Input
    /// ���� HelloECSComponent ����� Game,�� contexts.game
    /// </summary>
    /// <param name="contexts"></param>
    public HelloECSSystem(Contexts contexts) : base(contexts.game)
    {
        EventSystem.Instance.RegistEventHandler<GameLaunchEvent>(this);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.HelloECS);
    }

    /// <summary>
    /// ���������ж��������Ƿ��������� Component
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected override bool Filter(GameEntity entity)
    {
        return entity.hasHelloECS;
    }

    /// <summary>
    /// ����ִ�еĴ���
    /// </summary>
    /// <param name="entities"></param>
    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            Debug.Log(entity.helloECS.message);
        }
    }

    public void ReceiveEvent(GameLaunchEvent evt)
    {
        Debug.Log("GameLaunch");
    }
}