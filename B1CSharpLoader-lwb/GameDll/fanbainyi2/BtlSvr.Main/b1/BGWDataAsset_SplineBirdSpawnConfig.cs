using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig")]
public class BGWDataAsset_SplineBirdSpawnConfig : UBGWDataAsset
{
	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	private static bool GlobalRefreshCoolDown_IsValid;

	private static int GlobalRefreshCoolDown_Offset;

	private static bool SplineUseProtectTime_IsValid;

	private static int SplineUseProtectTime_Offset;

	private static bool SplineFilterDist_IsValid;

	private static int SplineFilterDist_Offset;

	private static bool MaxCoutInWorld_IsValid;

	private static int MaxCoutInWorld_Offset;

	private static bool SpawnGap_IsValid;

	private static int SpawnGap_Offset;

	private static bool FXAnimalTemplateList_IsValid;

	private static int FXAnimalTemplateList_Offset;

	private static FFieldAddress FXAnimalTemplateList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<BGUFXAnimalActor>> FXAnimalTemplateList_Marshaler;

	private static bool FXAnimalTemplateMap_IsValid;

	private static int FXAnimalTemplateMap_Offset;

	private static FFieldAddress FXAnimalTemplateMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, TSubclassOf<BGUFXAnimalActor>> FXAnimalTemplateMap_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:bEnableDebug")]
	public bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("全局刷新CD")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:GlobalRefreshCoolDown")]
	public float GlobalRefreshCoolDown
	{
		get
		{
			CheckDestroyed();
			if (!GlobalRefreshCoolDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:GlobalRefreshCoolDown");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlobalRefreshCoolDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalRefreshCoolDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:GlobalRefreshCoolDown");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlobalRefreshCoolDown_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Spline使用保护时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineUseProtectTime")]
	public float SplineUseProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!SplineUseProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineUseProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SplineUseProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineUseProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineUseProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SplineUseProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("SplineStartPos离玩家的距离")]
	[EditAnywhere]
	[DisplayName("Spline筛选距离范围")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineFilterDist")]
	public FFloatRange SplineFilterDist
	{
		get
		{
			CheckDestroyed();
			if (!SplineFilterDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineFilterDist");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, SplineFilterDist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineFilterDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SplineFilterDist");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, SplineFilterDist_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("同时存在的特效数量上限")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:MaxCoutInWorld")]
	public int MaxCoutInWorld
	{
		get
		{
			CheckDestroyed();
			if (!MaxCoutInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:MaxCoutInWorld");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCoutInWorld_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCoutInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:MaxCoutInWorld");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCoutInWorld_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("不同种类特效生物的生成间隔")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SpawnGap")]
	public FFloatRange SpawnGap
	{
		get
		{
			CheckDestroyed();
			if (!SpawnGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SpawnGap");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, SpawnGap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:SpawnGap");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, SpawnGap_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("随机特效生物列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:FXAnimalTemplateList")]
	public TArrayReadWrite<TSubclassOf<BGUFXAnimalActor>> FXAnimalTemplateList
	{
		get
		{
			CheckDestroyed();
			if (!FXAnimalTemplateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:FXAnimalTemplateList");
				return null;
			}
			if (FXAnimalTemplateList_Marshaler == null)
			{
				FXAnimalTemplateList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<BGUFXAnimalActor>>(1, FXAnimalTemplateList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.ToNative);
			}
			return FXAnimalTemplateList_Marshaler.FromNative(IntPtr.Add(base.Address, FXAnimalTemplateList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("飞鸟模板映射")]
	[Tooltip("key为场景中SplineActor所带的Tag,第一个Tag必须是FlyBirdSpline，用以标识它是飞鸟用的Spline, 第二个Tag是用来映射使用哪个飞鸟模板")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:FXAnimalTemplateMap")]
	public TMapReadWrite<FName, TSubclassOf<BGUFXAnimalActor>> FXAnimalTemplateMap
	{
		get
		{
			CheckDestroyed();
			if (!FXAnimalTemplateMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig:FXAnimalTemplateMap");
				return null;
			}
			if (FXAnimalTemplateMap_Marshaler == null)
			{
				FXAnimalTemplateMap_Marshaler = new TMapReadWriteMarshaler<FName, TSubclassOf<BGUFXAnimalActor>>(1, FXAnimalTemplateMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.ToNative);
			}
			return FXAnimalTemplateMap_Marshaler.FromNative(IntPtr.Add(base.Address, FXAnimalTemplateMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SplineBirdSpawnConfig");
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, unrealStruct, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebug", Classes.FBoolProperty);
		GlobalRefreshCoolDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GlobalRefreshCoolDown");
		GlobalRefreshCoolDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GlobalRefreshCoolDown", Classes.FFloatProperty);
		SplineUseProtectTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineUseProtectTime");
		SplineUseProtectTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineUseProtectTime", Classes.FFloatProperty);
		SplineFilterDist_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineFilterDist");
		SplineFilterDist_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineFilterDist", Classes.FStructProperty);
		MaxCoutInWorld_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxCoutInWorld");
		MaxCoutInWorld_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxCoutInWorld", Classes.FIntProperty);
		SpawnGap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnGap");
		SpawnGap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnGap", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref FXAnimalTemplateList_PropertyAddress, unrealStruct, "FXAnimalTemplateList");
		FXAnimalTemplateList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FXAnimalTemplateList");
		FXAnimalTemplateList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FXAnimalTemplateList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FXAnimalTemplateMap_PropertyAddress, unrealStruct, "FXAnimalTemplateMap");
		FXAnimalTemplateMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FXAnimalTemplateMap");
		FXAnimalTemplateMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FXAnimalTemplateMap", Classes.FMapProperty);
	}

	static BGWDataAsset_SplineBirdSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SplineBirdSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SplineBirdSpawnConfig));
	}
}
