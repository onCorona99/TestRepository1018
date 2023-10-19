using Cysharp.Threading.Tasks;
using Entitas;

public class AvatarManager : Singleton<AvatarManager>, IAvatarManager
{
    private static IAvatarManager _implement;
    public void SetAvatarManagerImplement(IAvatarManager implement)
    {
        _implement = implement;
    }

    public async UniTask<IAvatar> CreateAvatar(Entity entity, string location)
    {
        if (_implement == null)
        {
            return null;
        }
        return await _implement.CreateAvatar(entity, location);
    }

    public async UniTask<IAvatar> CreateAvatar(Entity entity, string location, bool pooled)
    {
        if (_implement == null)
        {
            return null;
        }
        return await _implement.CreateAvatar(entity, location, pooled);
    }

    public async UniTask<IAvatar> CreatePlayerAvatar(Entity entity, int playerCharacterId)
    {
        if (_implement == null)
        {
            return null;
        }
        return await _implement.CreatePlayerAvatar(entity, playerCharacterId);
    }

    public async UniTask<IAvatar> CreateEnemyAvatar(Entity entity, int enemyId)
    {
        if (_implement == null)
        {
            return null;
        }
        return await _implement.CreateEnemyAvatar(entity, enemyId);
    }

    public override void Dispose()
    {
        _implement.Dispose();
        _implement = null;
    }

    public IAvatar GetAvatar(Entity entity)
    {
        return _implement?.GetAvatar(entity);
    }

    public Entity GetEntity(IAvatar avatar)
    {
        return _implement?.GetEntity(avatar);
    }

    public Entity GetEntityByGameObjectInstanceId(int instanceId)
    {
        return _implement?.GetEntityByGameObjectInstanceId(instanceId);
    }

    public void RegistAvatarInfo(IAvatar avatar)
    {
        _implement?.RegistAvatarInfo(avatar);
    }

    public void DestroyAvatar(Entity entity, bool forceDestroy)
    {
        _implement?.DestroyAvatar(entity, forceDestroy);
    }

    public void DestroyAvatar(int entityId)
    {
        _implement?.DestroyAvatar(entityId);
    }
}