using Entitas;

public interface IAvatar
{
    //ECSWorld GetWorld();

    int GetEntityId();

    int GetGameObjectInstanceId();

    void Init(Entity entity);

    bool HasAvatarComponent<T>() where T : class, IAvatarComponent;

    T GetAvatarComponent<T>() where T : class, IAvatarComponent;

    void RegistAvatarComponent<T>(T avatarComponent) where T : class, IAvatarComponent;

    void SendEvent<T>(T evt) where T : IEvent;
}
