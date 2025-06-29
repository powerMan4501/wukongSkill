using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public abstract class ECSDataInitTemplate
{
	public AActor Owner;

	public int FilterNetRole;

	public ECSDataInitTemplate(Entity InitEntity, int NetRoleFilter)
	{
		Owner = ECSExtension.ToActor(InitEntity);
		FilterNetRole = NetRoleFilter;
	}

	public T GetData<T>() where T : class, IPersistentECSData, new()
	{
		return BGU_DataUtil.GetReadOnlyData<T>(Owner);
	}

	public T GetUnPersistentData<T>() where T : class, new()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(Owner);
	}

	public abstract void InitDataLateBeginPlay();

	public abstract void InitDataPreBeginPlay();

	public abstract void InitDataOnNew();
}
