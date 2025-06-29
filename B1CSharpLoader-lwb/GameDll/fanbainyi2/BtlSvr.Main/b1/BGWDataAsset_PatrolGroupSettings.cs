using System;
using System.Collections.Generic;
using b1.CppExport;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings")]
public class BGWDataAsset_PatrolGroupSettings : UBGWDataAsset
{
	private static bool GroupIndexToUpdate_IsValid;

	private static int GroupIndexToUpdate_Offset;

	private static bool PatrolGroups_IsValid;

	private static int PatrolGroups_Offset;

	private static FFieldAddress PatrolGroups_PropertyAddress;

	private TArrayReadWriteMarshaler<FPatrolGroupSetting> PatrolGroups_Marshaler;

	private static bool ClearRepeatedSettings_IsValid;

	private static IntPtr ClearRepeatedSettings_FunctionAddress;

	private static int ClearRepeatedSettings_ParamsSize;

	private static bool ApplyAllPatrolGroupSettings_IsValid;

	private static IntPtr ApplyAllPatrolGroupSettings_FunctionAddress;

	private static int ApplyAllPatrolGroupSettings_ParamsSize;

	private static bool ClearAllPatrolGroupSettings_IsValid;

	private static IntPtr ClearAllPatrolGroupSettings_FunctionAddress;

	private static int ClearAllPatrolGroupSettings_ParamsSize;

	private static bool ApplySinglePatrolGroupSetting_IsValid;

	private static IntPtr ApplySinglePatrolGroupSetting_FunctionAddress;

	private static int ApplySinglePatrolGroupSetting_ParamsSize;

	private static bool ClearSinglePatrolGroupSetting_IsValid;

	private static IntPtr ClearSinglePatrolGroupSetting_FunctionAddress;

	private static int ClearSinglePatrolGroupSetting_ParamsSize;

	[BlueprintReadWrite]
	[Category("SinglePatrolGroupSetting")]
	[DisplayName("单独更新巡逻小队编号")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:GroupIndexToUpdate")]
	public int GroupIndexToUpdate
	{
		get
		{
			CheckDestroyed();
			if (!GroupIndexToUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:GroupIndexToUpdate");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GroupIndexToUpdate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupIndexToUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:GroupIndexToUpdate");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GroupIndexToUpdate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:PatrolGroups")]
	public TArrayReadWrite<FPatrolGroupSetting> PatrolGroups
	{
		get
		{
			CheckDestroyed();
			if (!PatrolGroups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:PatrolGroups");
				return null;
			}
			if (PatrolGroups_Marshaler == null)
			{
				PatrolGroups_Marshaler = new TArrayReadWriteMarshaler<FPatrolGroupSetting>(1, PatrolGroups_PropertyAddress, CachedMarshalingDelegates<FPatrolGroupSetting, FPatrolGroupSetting>.FromNative, CachedMarshalingDelegates<FPatrolGroupSetting, FPatrolGroupSetting>.ToNative);
			}
			return PatrolGroups_Marshaler.FromNative(IntPtr.Add(base.Address, PatrolGroups_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("PatrolGroupSettings")]
	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("更新所有巡逻小队配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplyAllPatrolGroupSettings")]
	public void ApplyAllPatrolGroupSettings()
	{
		ClearRepeatedSettings();
		for (int i = 0; i < PatrolGroups.Count; i++)
		{
			FPatrolGroupSetting value = PatrolGroups[i];
			bool flag = false;
			FTransform fTransform = FTransform.Default;
			value.GroupFormation.Clear();
			foreach (FGsActorGuidReference groupMember in value.GroupMembers)
			{
				TSoftObject<AActor> actorRef = groupMember.ActorRef;
				if (!(actorRef.Value == null))
				{
					if (!flag)
					{
						actorRef = groupMember.ActorRef;
						fTransform = actorRef.Value.GetActorTransform();
						flag = true;
					}
					else
					{
						List<FVector> groupFormation = value.GroupFormation;
						GSE_NativeMathFuncs.Del_InverseTransformLocation inverseTransformLocation = MathLib.InverseTransformLocation;
						FTransform t = fTransform;
						actorRef = groupMember.ActorRef;
						groupFormation.Add(inverseTransformLocation(t, BGUFuncLibActorTransformCS.BGUGetActorLocation(actorRef.Value)));
					}
				}
			}
			PatrolGroups[i] = value;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("PatrolGroupSettings")]
	[UMeta(MDFunc.CallInEditor)]
	[DisplayName("清除所有巡逻小队配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearAllPatrolGroupSettings")]
	public void ClearAllPatrolGroupSettings()
	{
		ClearRepeatedSettings();
		for (int i = 0; i < PatrolGroups.Count; i++)
		{
			FPatrolGroupSetting value = PatrolGroups[i];
			value.GroupFormation.Clear();
			PatrolGroups[i] = value;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("清除重复单位配置")]
	[UMeta(MDFunc.CallInEditor)]
	[Category("PatrolGroupSettings")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearRepeatedSettings")]
	public void ClearRepeatedSettings()
	{
		HashSet<TSoftObject<AActor>> hashSet = new HashSet<TSoftObject<AActor>>();
		for (int i = 0; i < PatrolGroups.Count; i++)
		{
			FPatrolGroupSetting value = PatrolGroups[i];
			for (int num = value.GroupMembers.Count - 1; num >= 0; num--)
			{
				if (hashSet.Contains(value.GroupMembers[num].ActorRef))
				{
					value.GroupMembers.RemoveAt(num);
				}
				else
				{
					hashSet.Add(value.GroupMembers[num].ActorRef);
				}
			}
			PatrolGroups[i] = value;
		}
	}

	[DisplayName("更新单个巡逻小队配置")]
	[UMeta(MDFunc.CallInEditor)]
	[Category("SinglePatrolGroupSetting")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplySinglePatrolGroupSetting")]
	public void ApplySinglePatrolGroupSetting()
	{
		if (GroupIndexToUpdate >= PatrolGroups.Count || GroupIndexToUpdate < 0)
		{
			return;
		}
		FPatrolGroupSetting value = PatrolGroups[GroupIndexToUpdate];
		bool flag = false;
		FTransform fTransform = FTransform.Default;
		value.GroupFormation.Clear();
		foreach (FGsActorGuidReference groupMember in value.GroupMembers)
		{
			TSoftObject<AActor> actorRef = groupMember.ActorRef;
			if (!(actorRef.Value == null))
			{
				if (!flag)
				{
					actorRef = groupMember.ActorRef;
					fTransform = actorRef.Value.GetActorTransform();
					flag = true;
				}
				else
				{
					List<FVector> groupFormation = value.GroupFormation;
					GSE_NativeMathFuncs.Del_InverseTransformLocation inverseTransformLocation = MathLib.InverseTransformLocation;
					FTransform t = fTransform;
					actorRef = groupMember.ActorRef;
					groupFormation.Add(inverseTransformLocation(t, BGUFuncLibActorTransformCS.BGUGetActorLocation(actorRef.Value)));
				}
			}
		}
		PatrolGroups[GroupIndexToUpdate] = value;
	}

	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[Category("SinglePatrolGroupSetting")]
	[DisplayName("清除单个巡逻小队配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearSinglePatrolGroupSetting")]
	public void ClearSinglePatrolGroupSetting()
	{
		if (GroupIndexToUpdate < PatrolGroups.Count && GroupIndexToUpdate >= 0)
		{
			FPatrolGroupSetting value = PatrolGroups[GroupIndexToUpdate];
			value.GroupFormation.Clear();
			PatrolGroups[GroupIndexToUpdate] = value;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearRepeatedSettings")]
	private static void ClearRepeatedSettings__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_PatrolGroupSettings bGWDataAsset_PatrolGroupSettings = GCHelper.Find<BGWDataAsset_PatrolGroupSettings>(obj);
		bGWDataAsset_PatrolGroupSettings.ClearRepeatedSettings();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplyAllPatrolGroupSettings")]
	private static void ApplyAllPatrolGroupSettings__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_PatrolGroupSettings bGWDataAsset_PatrolGroupSettings = GCHelper.Find<BGWDataAsset_PatrolGroupSettings>(obj);
		bGWDataAsset_PatrolGroupSettings.ApplyAllPatrolGroupSettings();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearAllPatrolGroupSettings")]
	private static void ClearAllPatrolGroupSettings__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_PatrolGroupSettings bGWDataAsset_PatrolGroupSettings = GCHelper.Find<BGWDataAsset_PatrolGroupSettings>(obj);
		bGWDataAsset_PatrolGroupSettings.ClearAllPatrolGroupSettings();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplySinglePatrolGroupSetting")]
	private static void ApplySinglePatrolGroupSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_PatrolGroupSettings bGWDataAsset_PatrolGroupSettings = GCHelper.Find<BGWDataAsset_PatrolGroupSettings>(obj);
		bGWDataAsset_PatrolGroupSettings.ApplySinglePatrolGroupSetting();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearSinglePatrolGroupSetting")]
	private static void ClearSinglePatrolGroupSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_PatrolGroupSettings bGWDataAsset_PatrolGroupSettings = GCHelper.Find<BGWDataAsset_PatrolGroupSettings>(obj);
		bGWDataAsset_PatrolGroupSettings.ClearSinglePatrolGroupSetting();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings");
		GroupIndexToUpdate_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupIndexToUpdate");
		GroupIndexToUpdate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupIndexToUpdate", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PatrolGroups_PropertyAddress, intPtr, "PatrolGroups");
		PatrolGroups_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatrolGroups");
		PatrolGroups_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatrolGroups", Classes.FArrayProperty);
		ClearRepeatedSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearRepeatedSettings");
		ClearRepeatedSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearRepeatedSettings_FunctionAddress);
		ClearRepeatedSettings_IsValid = ClearRepeatedSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearRepeatedSettings", ClearRepeatedSettings_IsValid);
		ApplyAllPatrolGroupSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyAllPatrolGroupSettings");
		ApplyAllPatrolGroupSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyAllPatrolGroupSettings_FunctionAddress);
		ApplyAllPatrolGroupSettings_IsValid = ApplyAllPatrolGroupSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplyAllPatrolGroupSettings", ApplyAllPatrolGroupSettings_IsValid);
		ClearAllPatrolGroupSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAllPatrolGroupSettings");
		ClearAllPatrolGroupSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllPatrolGroupSettings_FunctionAddress);
		ClearAllPatrolGroupSettings_IsValid = ClearAllPatrolGroupSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearAllPatrolGroupSettings", ClearAllPatrolGroupSettings_IsValid);
		ApplySinglePatrolGroupSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplySinglePatrolGroupSetting");
		ApplySinglePatrolGroupSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySinglePatrolGroupSetting_FunctionAddress);
		ApplySinglePatrolGroupSetting_IsValid = ApplySinglePatrolGroupSetting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ApplySinglePatrolGroupSetting", ApplySinglePatrolGroupSetting_IsValid);
		ClearSinglePatrolGroupSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSinglePatrolGroupSetting");
		ClearSinglePatrolGroupSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSinglePatrolGroupSetting_FunctionAddress);
		ClearSinglePatrolGroupSetting_IsValid = ClearSinglePatrolGroupSetting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_PatrolGroupSettings:ClearSinglePatrolGroupSetting", ClearSinglePatrolGroupSetting_IsValid);
	}

	static BGWDataAsset_PatrolGroupSettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PatrolGroupSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PatrolGroupSettings));
	}
}
