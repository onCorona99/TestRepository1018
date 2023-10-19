using Cysharp.Threading.Tasks;
using Entitas;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理ECS对象在Unity中的显示对象的对应关系
/// </summary>
public class AvatarManagerImpl : IAvatarManager
{
    /// <summary>
    /// 映射表
    /// </summary>
    private Dictionary<int, IAvatar> _avatarDict = new Dictionary<int, IAvatar>();
    private Dictionary<int, int> _gameobjectInstanceIdToEntityId = new Dictionary<int, int>();


    public AvatarManagerImpl()
    {
    }


    public void RegistAvatarInfo(IAvatar avatar)
    {
        var instanceId = avatar.GetGameObjectInstanceId();
        var entityId = avatar.GetEntityId();
        _avatarDict[entityId] = avatar;
        _gameobjectInstanceIdToEntityId[instanceId] = entityId;
    }

    public IAvatar GetAvatar(Entity entity)
    {
        //_avatarDict.TryGetValue(entity.EntityId, out var avatar);
        //return avatar;
        return null;
    }

    public Entity GetEntity(IAvatar avatar)
    {
        //return _world.GetEntity(avatar.GetEntityId());
        return null;
    }

    public Entity GetEntityByGameObjectInstanceId(int instanceId)
    {
        if (!_gameobjectInstanceIdToEntityId.TryGetValue(instanceId, out var entityId))
        {
            return null;
        }
        //return _world.GetEntity(entityId);
        return null;
    }


    public void Dispose()
    {
    }

    public async UniTask<IAvatar> CreatePlayerAvatar(Entity entity, int playerCharacterId)
    {
        //var playerConfig = GameConfigManager.Instance.Tables.TableCharacter.Get(playerCharacterId);
        //var prefab = await GameplayController.Instance.UnitManager.LoadAssetAsync<GameObject>(playerConfig.CharacterPrefab,
        //    GameplayController.Instance.Cancel.Token);
        //var go = GameObject.Instantiate(prefab);
        //go.name = playerConfig.CharacterPrefab;
        //if (!entity.IsAlive)
        //{
        //    GameplayController.Instance.UnitManager.ReleaseGameObject(go);
        //    return null;
        //}
        //var avatar = go.GetComponent<IAvatar>();
        //avatar.Init(entity);
        //return avatar;
        return null;
    }

    public async UniTask<IAvatar> CreateAvatar(Entity entity, string prefabName)
    {
        //var go = await GameplayController.Instance.UnitManager.CreateGameObject(prefabName, true, GameplayController.Instance.Cancel.Token);
        //go.name = prefabName;
        //if (!entity.IsAlive)
        //{
        //    GameplayController.Instance.UnitManager.ReleaseGameObject(go);
        //    return null;
        //}
        //var avatar = go.GetComponent<IAvatar>();
        //avatar.Init(entity);
        //return avatar;
        return null;

    }

    public async UniTask<IAvatar> CreateAvatar(Entity entity, string prefabName, bool fromPool)
    {
        //var go = await GameplayController.Instance.UnitManager.CreateGameObject(prefabName, fromPool, GameplayController.Instance.Cancel.Token);
        //go.name = prefabName;
        //if (!entity.IsAlive)
        //{
        //    GameplayController.Instance.UnitManager.ReleaseGameObject(go);
        //    return null;
        //}
        //var avatar = go.GetComponent<IAvatar>();
        //avatar.Init(entity);
        //return avatar;
        return null;

    }

    public async UniTask<IAvatar> CreateEnemyAvatar(Entity entity, int enemyId)
    {
        //var config = GameConfigManager.Instance.Tables.TableEnemy.Get(enemyId);
        //var go = await GameplayController.Instance.UnitManager.CreateGameObject(config.RenderPrefab, true, GameplayController.Instance.Cancel.Token);
        //go.name = config.RenderPrefab;
        //if (!entity.IsAlive)
        //{
        //    GameplayController.Instance.UnitManager.ReleaseGameObject(go);
        //    return null;
        //}
        //var avatar = go.GetComponent<IAvatar>();
        //avatar.Init(entity);
        //return avatar;
        return null;
    }



    public void DestroyAvatar(int entityId)
    {
        //_avatarDict.TryGetValue(entityId, out var avatarReference);
        //var avatar = avatarReference as UnityECSAvatar;
        //if (avatar == null)
        //{
        //    return;
        //}
        //_avatarDict.Remove(entityId);
        //_gameobjectInstanceIdToEntityId.Remove(avatar.gameObject.GetInstanceID());
        //if (avatar.DisablePoolFlag)
        //{
        //    GameObject.Destroy(avatar.gameObject);
        //}
        //else
        //{
        //    GameplayController.Instance.UnitManager.ReleaseGameObject(avatar.gameObject);
        //}
    }

    public void DestroyAvatar(Entity entity, bool forcceDestroy = false)
    {
        //var avatar = GetAvatar(entity) as UnityECSAvatar;
        //if (avatar == null)
        //{
        //    return;
        //}
        //var lifecycle = avatar.GetAvatarComponent<IAvatarLifecycle>();
        //if (lifecycle != null && !forcceDestroy)
        //{
        //    lifecycle.OnDeath();
        //    avatar.Dispose();
        //}
        //else
        //{
        //    _avatarDict.Remove(entity.EntityId);
        //    _gameobjectInstanceIdToEntityId.Remove(avatar.gameObject.GetInstanceID());
        //    avatar.Dispose();
        //    if (avatar.DisablePoolFlag)
        //    {
        //        GameObject.Destroy(avatar.gameObject);
        //    }
        //    else
        //    {
        //        GameplayController.Instance.UnitManager.ReleaseGameObject(avatar.gameObject);
        //    }
        //}
    }
}
