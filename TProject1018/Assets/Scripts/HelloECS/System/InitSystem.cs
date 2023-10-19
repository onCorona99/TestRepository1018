
using Entitas;

/// <summary>
/// ��ʼ��ϵͳ
/// </summary>
public class InitSystem : IInitializeSystem
{
    private readonly GameContext mGameContext;

    /// <summary>
    /// ���캯������ȡ������
    /// </summary>
    /// <param name="contexts"></param>
    public InitSystem(Contexts contexts)
    {
        mGameContext = contexts.game;
    }

    /// <summary>
    /// ��ʼ��
    /// </summary>
    public void Initialize()
    {
        mGameContext.CreateEntity().AddHelloECS("Hello ECS Entitas����");
    }
}