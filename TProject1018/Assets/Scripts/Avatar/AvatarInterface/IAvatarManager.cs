using Cysharp.Threading.Tasks;
using Entitas;

public interface IAvatarManager
{
    void RegistAvatarInfo(IAvatar avatar);

    IAvatar GetAvatar(Entity entity);

    Entity GetEntity(IAvatar avatar);

    Entity GetEntityByGameObjectInstanceId(int instanceId);

    void Dispose();

    UniTask<IAvatar> CreatePlayerAvatar(Entity entity, int playerCharacterId);
    UniTask<IAvatar> CreateAvatar(Entity entity, string location);
    UniTask<IAvatar> CreateAvatar(Entity entity, string location, bool pooled);
    UniTask<IAvatar> CreateEnemyAvatar(Entity entity, int enemyId);
    void DestroyAvatar(Entity entity, bool forceDestroy);
    void DestroyAvatar(int entityId);
}
