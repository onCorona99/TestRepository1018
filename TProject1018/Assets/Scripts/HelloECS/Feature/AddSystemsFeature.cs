
/// <summary>
/// ���������Ҫ��ϵͳ System
/// </summary>
public class AddSystemsFeature : Feature
{
    // "AddSystemsFeature" ������ȡ
    public AddSystemsFeature(Contexts contexts) : base("AddSystemsFeature")
    {
        // ���ϵͳ
        Add(new HelloECSSystem(contexts));
        Add(new InitSystem(contexts));
    }
}