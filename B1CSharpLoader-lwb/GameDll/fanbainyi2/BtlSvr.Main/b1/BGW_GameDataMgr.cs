using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GameDataMgr")]
public class BGW_GameDataMgr : GameInstanceSystemBaseUObj
{
	private static BGW_GameDataMgr s_Instance;

	private static bool UObjectDataOwner_IsValid;

	private static int UObjectDataOwner_Offset;

	private static FFieldAddress UObjectDataOwner_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> UObjectDataOwner_Marshaler;

	private Dictionary<Type, object> DataCollection { get; } = new Dictionary<Type, object>();

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_GameDataMgr:UObjectDataOwner")]
	private TArrayReadWrite<UObject> UObjectDataOwner
	{
		get
		{
			CheckDestroyed();
			if (!UObjectDataOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_GameDataMgr:UObjectDataOwner");
				return null;
			}
			if (UObjectDataOwner_Marshaler == null)
			{
				UObjectDataOwner_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, UObjectDataOwner_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return UObjectDataOwner_Marshaler.FromNative(IntPtr.Add(base.Address, UObjectDataOwner_Offset));
		}
	}

	public static BGW_GameDataMgr Get(UObject WorldCtx)
	{
		if (s_Instance == null)
		{
			s_Instance = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(WorldCtx);
		}
		return s_Instance;
	}

	public override void OnAttach()
	{
		DataCollection.Clear();
		CreateDataClass<BIC_GlobalActorData>();
		CreateDataClass<BIC_LevelData>();
		CreateDataClass<BIC_CollectionGroupData>();
		CreateDataClass<BIC_MovieData>();
		CreateDataClass<BIC_TaskData>();
		CreateDataClass<BIC_TeleportStateData>();
		CreateDataClass<BIC_TeleportPointsData>();
		CreateDataClass<BIC_DreamTeleportData>();
		CreateDataClass<BIC_StateMachineData>();
		CreateDataClass<BIC_ResetActorData>();
		CreateDataClass<b1.BIC_CalliopeAssetData>();
		CreateDataClass<BIC_PersistentECSData>();
		CreateDataClass<BIC_GMRebirthData>();
		CreateDataClass<BIC_DeathData>();
		CreateDataClass<BIC_LevelStateManageData>();
		CreateDataClass<BIC_SubLevelStreamingMgrData>();
		CreateDataClass<BIC_CheatData>();
		CreateDataClass<BIC_TeleportData>();
		CreateDataClass<BIC_BossRushData>();
		CreateDataClass<BIC_BossRushBattleData>();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		UObjectDataOwner.Clear();
		DataCollection.Clear();
	}

	protected T CreateDataClass<T>() where T : class, new()
	{
		Type typeFromHandle = typeof(T);
		T val;
		if (DataCollection.ContainsKey(typeFromHandle))
		{
			val = DataCollection[typeFromHandle] as T;
		}
		else
		{
			val = new T();
			DataCollection.Add(typeFromHandle, val);
		}
		return val;
	}

	protected T CreateData<T>() where T : UObject
	{
		Type typeFromHandle = typeof(T);
		T val;
		if (DataCollection.ContainsKey(typeFromHandle))
		{
			val = DataCollection[typeFromHandle] as T;
		}
		else
		{
			val = UObject.NewObject<T>(this);
			DataCollection.Add(typeFromHandle, val);
			UObjectDataOwner.Add(val);
		}
		return val;
	}

	public T GetGameInstanceWritableData<T>() where T : class
	{
		return (T)GetGameInstanceWritableData(typeof(T));
	}

	public object GetGameInstanceWritableData(Type InType)
	{
		if (DataCollection.TryGetValue(InType, out var value))
		{
			return value;
		}
		return null;
	}

	public IT GetGameInstanceReadonlyData<IT, T>() where IT : class where T : class, IT
	{
		return (IT)(T)GetGameInstanceWritableData(typeof(T));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_GameDataMgr");
		NativeReflection.GetPropertyRef(ref UObjectDataOwner_PropertyAddress, unrealStruct, "UObjectDataOwner");
		UObjectDataOwner_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UObjectDataOwner");
		UObjectDataOwner_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UObjectDataOwner", Classes.FArrayProperty);
	}

	static BGW_GameDataMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GameDataMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GameDataMgr));
	}
}
