using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Trigger ReSet HoldShield ")]
[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield")]
internal class BAN_GSReSetHoldShield : BAN_GSBase
{
	private static bool IsRemove_IsValid;

	private static int IsRemove_Offset;

	private static FFieldAddress IsRemove_PropertyAddress;

	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool PartID_IsValid;

	private static int PartID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:IsRemove")]
	public bool IsRemove
	{
		get
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:IsRemove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:IsRemove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:ABPSetting")]
	public BGWDataAsset_AbpHumanoidSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:ABPSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.ToNative(IntPtr.Add(base.Address, ABPSetting_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:PartID")]
	public int PartID
	{
		get
		{
			CheckDestroyed();
			if (!PartID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:PartID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PartID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PartID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSReSetHoldShield:PartID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PartID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null) || !(aActor as ABGUCharacter != null) || !(aActor.World != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_ReSetShieldPartState.Invoke(IsRemove, PartID);
			if (ABPSetting != null)
			{
				bUS_GSEventCollection.Evt_ChangeABPSetting.Invoke(ABPSetting);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSReSetHoldShield:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSReSetHoldShield:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSReSetHoldShield bAN_GSReSetHoldShield = GCHelper.Find<b1.BAN_GSReSetHoldShield>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSReSetHoldShield.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSReSetHoldShield:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSReSetHoldShield bAN_GSReSetHoldShield = GCHelper.Find<b1.BAN_GSReSetHoldShield>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bAN_GSReSetHoldShield.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSReSetHoldShield:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSReSetHoldShield bAN_GSReSetHoldShield = GCHelper.Find<b1.BAN_GSReSetHoldShield>(obj);
		bool value = bAN_GSReSetHoldShield.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSReSetHoldShield");
		NativeReflection.GetPropertyRef(ref IsRemove_PropertyAddress, intPtr, "IsRemove");
		IsRemove_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRemove");
		IsRemove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRemove", Classes.FBoolProperty);
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSetting", Classes.FObjectProperty);
		PartID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PartID");
		PartID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PartID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSReSetHoldShield:GSNotifyCS", GSNotifyCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSReSetHoldShield:GSValidateInputCS", GSValidateInputCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSReSetHoldShield:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSReSetHoldShield()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSReSetHoldShield)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSReSetHoldShield));
	}
}
