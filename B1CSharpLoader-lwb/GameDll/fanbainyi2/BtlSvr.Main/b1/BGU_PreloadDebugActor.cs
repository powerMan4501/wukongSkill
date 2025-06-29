using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor")]
public class BGU_PreloadDebugActor : ABGUActorBase
{
	private static bool EnablePreload_IsValid;

	private static int EnablePreload_Offset;

	private static FFieldAddress EnablePreload_PropertyAddress;

	private static bool EnableHitSceneItemPerformPreload_IsValid;

	private static int EnableHitSceneItemPerformPreload_Offset;

	private static FFieldAddress EnableHitSceneItemPerformPreload_PropertyAddress;

	private static bool EnableUnitTransPreloadPreload_IsValid;

	private static int EnableUnitTransPreloadPreload_Offset;

	private static FFieldAddress EnableUnitTransPreloadPreload_PropertyAddress;

	private static bool WhiteListPreloadTypeMap_IsValid;

	private static int WhiteListPreloadTypeMap_Offset;

	private static FFieldAddress WhiteListPreloadTypeMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, bool> WhiteListPreloadTypeMap_Marshaler;

	private static bool WhiteListPreloadTypeInfoMap_IsValid;

	private static int WhiteListPreloadTypeInfoMap_Offset;

	private static FFieldAddress WhiteListPreloadTypeInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, SkillTypeInfo> WhiteListPreloadTypeInfoMap_Marshaler;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("允许预加载")]
	[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor:EnablePreload")]
	public bool EnablePreload
	{
		get
		{
			CheckDestroyed();
			if (!EnablePreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnablePreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePreload_Offset), 0, EnablePreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnablePreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePreload_Offset), 0, EnablePreload_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("允许预加载砸地特效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnablePreload == true")]
	[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor:EnableHitSceneItemPerformPreload")]
	public bool EnableHitSceneItemPerformPreload
	{
		get
		{
			CheckDestroyed();
			if (!EnableHitSceneItemPerformPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnableHitSceneItemPerformPreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHitSceneItemPerformPreload_Offset), 0, EnableHitSceneItemPerformPreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHitSceneItemPerformPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnableHitSceneItemPerformPreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHitSceneItemPerformPreload_Offset), 0, EnableHitSceneItemPerformPreload_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnablePreload == true")]
	[DisplayName("允许预加载变身单位")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor:EnableUnitTransPreloadPreload")]
	public bool EnableUnitTransPreloadPreload
	{
		get
		{
			CheckDestroyed();
			if (!EnableUnitTransPreloadPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnableUnitTransPreloadPreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableUnitTransPreloadPreload_Offset), 0, EnableUnitTransPreloadPreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableUnitTransPreloadPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:EnableUnitTransPreloadPreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableUnitTransPreloadPreload_Offset), 0, EnableUnitTransPreloadPreload_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnablePreload == true")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("白名单Preload技能类型")]
	[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor:WhiteListPreloadTypeMap")]
	public TMapReadWrite<string, bool> WhiteListPreloadTypeMap
	{
		get
		{
			CheckDestroyed();
			if (!WhiteListPreloadTypeMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:WhiteListPreloadTypeMap");
				return null;
			}
			if (WhiteListPreloadTypeMap_Marshaler == null)
			{
				WhiteListPreloadTypeMap_Marshaler = new TMapReadWriteMarshaler<string, bool>(1, WhiteListPreloadTypeMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return WhiteListPreloadTypeMap_Marshaler.FromNative(IntPtr.Add(base.Address, WhiteListPreloadTypeMap_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "EnablePreload == true")]
	[DisplayName("白名单Preload技能类型对应ID序列")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_PreloadDebugActor:WhiteListPreloadTypeInfoMap")]
	public TMapReadWrite<string, SkillTypeInfo> WhiteListPreloadTypeInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!WhiteListPreloadTypeInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_PreloadDebugActor:WhiteListPreloadTypeInfoMap");
				return null;
			}
			if (WhiteListPreloadTypeInfoMap_Marshaler == null)
			{
				WhiteListPreloadTypeInfoMap_Marshaler = new TMapReadWriteMarshaler<string, SkillTypeInfo>(1, WhiteListPreloadTypeInfoMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.FromNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.ToNative);
			}
			return WhiteListPreloadTypeInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, WhiteListPreloadTypeInfoMap_Offset));
		}
	}

	public HashSet<int> GetWhiteListSkillID()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (KeyValuePair<string, bool> item in WhiteListPreloadTypeMap)
		{
			if (!item.Value || !WhiteListPreloadTypeInfoMap.ContainsKey(item.Key))
			{
				continue;
			}
			foreach (PairSkillIDBeginEnd skillIDBeginEnd in WhiteListPreloadTypeInfoMap.Get(item.Key).SkillIDBeginEndList)
			{
				for (int i = skillIDBeginEnd.SkillIDBegin; i < skillIDBeginEnd.SkillIDEnd; i++)
				{
					hashSet.Add(i);
				}
			}
		}
		return hashSet;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGU_PreloadDebugActor");
		NativeReflection.GetPropertyRef(ref EnablePreload_PropertyAddress, unrealStruct, "EnablePreload");
		EnablePreload_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnablePreload");
		EnablePreload_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnablePreload", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableHitSceneItemPerformPreload_PropertyAddress, unrealStruct, "EnableHitSceneItemPerformPreload");
		EnableHitSceneItemPerformPreload_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableHitSceneItemPerformPreload");
		EnableHitSceneItemPerformPreload_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableHitSceneItemPerformPreload", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableUnitTransPreloadPreload_PropertyAddress, unrealStruct, "EnableUnitTransPreloadPreload");
		EnableUnitTransPreloadPreload_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableUnitTransPreloadPreload");
		EnableUnitTransPreloadPreload_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableUnitTransPreloadPreload", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref WhiteListPreloadTypeMap_PropertyAddress, unrealStruct, "WhiteListPreloadTypeMap");
		WhiteListPreloadTypeMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WhiteListPreloadTypeMap");
		WhiteListPreloadTypeMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WhiteListPreloadTypeMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WhiteListPreloadTypeInfoMap_PropertyAddress, unrealStruct, "WhiteListPreloadTypeInfoMap");
		WhiteListPreloadTypeInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WhiteListPreloadTypeInfoMap");
		WhiteListPreloadTypeInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WhiteListPreloadTypeInfoMap", Classes.FMapProperty);
	}

	static BGU_PreloadDebugActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_PreloadDebugActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_PreloadDebugActor));
	}
}
