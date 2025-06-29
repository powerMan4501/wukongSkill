using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("带次要目标信息播放DBC")]
[USharpPath("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo")]
public class BAN_PlayDBCWithTargetInfo : BAN_GSBase
{
	private static bool DBCOwnerType_IsValid;

	private static int DBCOwnerType_Offset;

	private static FFieldAddress DBCOwnerType_PropertyAddress;

	private static bool MinorTargetType_IsValid;

	private static int MinorTargetType_Offset;

	private static FFieldAddress MinorTargetType_PropertyAddress;

	private static bool DBC_IsValid;

	private static int DBC_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC持有者类型")]
	[USharpPath("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBCOwnerType")]
	public EANTriggerEffectTargetType DBCOwnerType
	{
		get
		{
			CheckDestroyed();
			if (!DBCOwnerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBCOwnerType");
				return EANTriggerEffectTargetType.Owner;
			}
			return EnumMarshaler<EANTriggerEffectTargetType>.FromNative(IntPtr.Add(base.Address, DBCOwnerType_Offset), 0, DBCOwnerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DBCOwnerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBCOwnerType");
			}
			else
			{
				EnumMarshaler<EANTriggerEffectTargetType>.ToNative(IntPtr.Add(base.Address, DBCOwnerType_Offset), 0, DBCOwnerType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("次要目标类型")]
	[USharpPath("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:MinorTargetType")]
	public EANTriggerEffectTargetType MinorTargetType
	{
		get
		{
			CheckDestroyed();
			if (!MinorTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:MinorTargetType");
				return EANTriggerEffectTargetType.Owner;
			}
			return EnumMarshaler<EANTriggerEffectTargetType>.FromNative(IntPtr.Add(base.Address, MinorTargetType_Offset), 0, MinorTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MinorTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:MinorTargetType");
			}
			else
			{
				EnumMarshaler<EANTriggerEffectTargetType>.ToNative(IntPtr.Add(base.Address, MinorTargetType_Offset), 0, MinorTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBC")]
	public UBGWDataAsset DBC
	{
		get
		{
			CheckDestroyed();
			if (!DBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBC");
				return null;
			}
			return UObjectMarshaler<UBGWDataAsset>.FromNative(IntPtr.Add(base.Address, DBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:DBC");
			}
			else
			{
				UObjectMarshaler<UBGWDataAsset>.ToNative(IntPtr.Add(base.Address, DBC_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DBCOwnerType = EANTriggerEffectTargetType.Owner;
		MinorTargetType = EANTriggerEffectTargetType.Owner;
	}

	[USharpPath("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null) || !(aActor as ABGUCharacter != null) || !(aActor.World != null))
		{
			return;
		}
		AActor effectTarget = BAN_GSTriggerEffect.GetEffectTarget(aActor, DBCOwnerType);
		AActor effectTarget2 = BAN_GSTriggerEffect.GetEffectTarget(aActor, MinorTargetType);
		if (effectTarget.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(effectTarget);
		if (bUS_GSEventCollection != null)
		{
			USceneComponent emitterDispOwnerComp = null;
			ACharacter aCharacter = effectTarget2 as ACharacter;
			if (aCharacter != null)
			{
				emitterDispOwnerComp = aCharacter.Mesh;
			}
			bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(DBC, out var _, emitterDispOwnerComp);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_PlayDBCWithTargetInfo bAN_PlayDBCWithTargetInfo = GCHelper.Find<BAN_PlayDBCWithTargetInfo>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_PlayDBCWithTargetInfo.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo");
		NativeReflection.GetPropertyRef(ref DBCOwnerType_PropertyAddress, intPtr, "DBCOwnerType");
		DBCOwnerType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBCOwnerType");
		DBCOwnerType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBCOwnerType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MinorTargetType_PropertyAddress, intPtr, "MinorTargetType");
		MinorTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinorTargetType");
		MinorTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinorTargetType", Classes.FEnumProperty);
		DBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC");
		DBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC", Classes.FObjectProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_PlayDBCWithTargetInfo:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_PlayDBCWithTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_PlayDBCWithTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_PlayDBCWithTargetInfo));
	}
}
