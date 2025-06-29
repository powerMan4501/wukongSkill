using System;
using UnrealEngine.Runtime;

namespace b1;

[Tooltip("原地生成一个Static Mesh Actor，可配置特殊材质")]
[DisplayName("Spawn StaticMesh Actor At Location")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor")]
public class BAN_GSSpawnStaticMeshActor : BAN_GSBase
{
	private static bool bAttachToOwner_IsValid;

	private static int bAttachToOwner_Offset;

	private static FFieldAddress bAttachToOwner_PropertyAddress;

	private static bool StaticMeshActorSetting_IsValid;

	private static int StaticMeshActorSetting_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[Category("SpawnSettings")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:bAttachToOwner")]
	public bool bAttachToOwner
	{
		get
		{
			CheckDestroyed();
			if (!bAttachToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:bAttachToOwner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAttachToOwner_Offset), 0, bAttachToOwner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAttachToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:bAttachToOwner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAttachToOwner_Offset), 0, bAttachToOwner_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnSettings")]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:StaticMeshActorSetting")]
	public BGWDataAsset_StaticMeshActorSetting StaticMeshActorSetting
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshActorSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:StaticMeshActorSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_StaticMeshActorSetting>.FromNative(IntPtr.Add(base.Address, StaticMeshActorSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshActorSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:StaticMeshActorSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_StaticMeshActorSetting>.ToNative(IntPtr.Add(base.Address, StaticMeshActorSetting_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BGS_EventCollectionCS.Get(bGUCharacterCS).Evt_OnSpawnStaticMeshActor.Invoke(StaticMeshActorSetting, bGUCharacterCS, bAttachToOwner);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSSpawnStaticMeshActor bAN_GSSpawnStaticMeshActor = GCHelper.Find<BAN_GSSpawnStaticMeshActor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSpawnStaticMeshActor.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor");
		NativeReflection.GetPropertyRef(ref bAttachToOwner_PropertyAddress, intPtr, "bAttachToOwner");
		bAttachToOwner_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttachToOwner");
		bAttachToOwner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttachToOwner", Classes.FBoolProperty);
		StaticMeshActorSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaticMeshActorSetting");
		StaticMeshActorSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaticMeshActorSetting", Classes.FObjectProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSpawnStaticMeshActor:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSpawnStaticMeshActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSSpawnStaticMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSSpawnStaticMeshActor));
	}
}
