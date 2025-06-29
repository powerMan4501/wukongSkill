using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.ActorEditCompBase")]
public abstract class UActorEditCompBase : UEditorOnlyCompBase
{
	private readonly WeakReference<BGUCharacterCS> MonsterRef = new WeakReference<BGUCharacterCS>(null);

	private BGW_ECSWorld ECSWorld;

	private Entity DataEntity;

	private IECSWorldObj OwnerECS;

	protected BGUCharacterCS Monster
	{
		get
		{
			if (!MonsterRef.TryGetTarget(out var target))
			{
				return null;
			}
			return target;
		}
	}

	public virtual EActorEditCompDataConvertTiming DataConvertTiming => EActorEditCompDataConvertTiming.Init;

	public abstract void OnDataConvert(AActor Owner);

	public void PreDataConvert(AActor DataOwner)
	{
		if (DataOwner is IECSWorldObj iECSWorldObj)
		{
			DataEntity = iECSWorldObj.ECSEntity;
			ECSWorld = BGW_ECSWorld.Get(DataEntity);
			OwnerECS = iECSWorldObj;
		}
	}

	protected virtual void OnDataConvertInTamer(BGUCharacterCS InMonster)
	{
		MonsterRef.SetTarget(InMonster);
		OnDataConvert(InMonster);
	}

	protected T RequireWritableData<T>() where T : class, new()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(ECSWorld, DataEntity);
	}

	protected T RequireWritableData<T>(AActor Owner) where T : class, new()
	{
		if (Owner is BUTamerActor && Monster != null)
		{
			return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(Monster);
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(Owner);
	}

	public static void DoDataConvert(AActor Owner, EActorEditCompDataConvertTiming Timing)
	{
		List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UActorEditCompBase>());
		if (componentsByClass == null)
		{
			BGW_LogUtil.LogError("UActorEditCompBase DoDataConvert Comps == null");
		}
		foreach (UActorComponent item in componentsByClass)
		{
			if (Timing == (item as UActorEditCompBase).DataConvertTiming)
			{
				UActorEditCompBase uActorEditCompBase = (UActorEditCompBase)item;
				if (uActorEditCompBase.IsNullOrDestroyed())
				{
					BGW_LogUtil.LogError($"UActorEditCompBase DoDataConvert (UActorEditCompBase)Comp IsNullOrDestroyed Comp:{item}");
					continue;
				}
				uActorEditCompBase.PreDataConvert(Owner);
				uActorEditCompBase.OnDataConvert(Owner);
			}
		}
	}

	public static void DoDataConvertFromTamer(BUTamerActor Tamer, BGUCharacterCS Monster, EActorEditCompDataConvertTiming Timing)
	{
		List<UActorComponent> componentsByClass = Tamer.GetComponentsByClass(UClass.GetClass<UActorEditCompBase>());
		if (componentsByClass == null)
		{
			BGW_LogUtil.LogError("UActorEditCompBase DoDataConvert Comps == null");
		}
		foreach (UActorComponent item in componentsByClass)
		{
			UActorEditCompBase uActorEditCompBase = (UActorEditCompBase)item;
			if (uActorEditCompBase.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError($"UActorEditCompBase DoDataConvert (UActorEditCompBase)Comp IsNullOrDestroyed Comp:{item}");
			}
			else if (Timing == uActorEditCompBase.DataConvertTiming)
			{
				uActorEditCompBase.PreDataConvert(Monster);
				uActorEditCompBase.OnDataConvertInTamer(Monster);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.ActorEditCompBase");
	}

	static UActorEditCompBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UActorEditCompBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorEditCompBase));
	}
}
