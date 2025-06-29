using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Parkour Anim Info")]
[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo")]
internal class BAN_GSParkourAnimInfo : BAN_GSBase
{
	private static bool AnimForwardMovement_IsValid;

	private static int AnimForwardMovement_Offset;

	private static bool AnimRightMovement_IsValid;

	private static int AnimRightMovement_Offset;

	private static bool AnimUpMovement_IsValid;

	private static int AnimUpMovement_Offset;

	private static bool SetAnimMovementValue_IsValid;

	private static IntPtr SetAnimMovementValue_FunctionAddress;

	private static int SetAnimMovementValue_ParamsSize;

	private static bool SetAnimMovementValue_Movement_IsValid;

	private static int SetAnimMovementValue_Movement_Offset;

	private static FFieldAddress SetAnimMovementValue_Movement_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimForwardMovement")]
	public float AnimForwardMovement
	{
		get
		{
			CheckDestroyed();
			if (!AnimForwardMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimForwardMovement");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimForwardMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimForwardMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimForwardMovement");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimForwardMovement_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimRightMovement")]
	public float AnimRightMovement
	{
		get
		{
			CheckDestroyed();
			if (!AnimRightMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimRightMovement");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimRightMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimRightMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimRightMovement");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimRightMovement_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimUpMovement")]
	public float AnimUpMovement
	{
		get
		{
			CheckDestroyed();
			if (!AnimUpMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimUpMovement");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimUpMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimUpMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSParkourAnimInfo:AnimUpMovement");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimUpMovement_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetParkourAnimTotalMovement.Invoke(AnimForwardMovement, AnimRightMovement, AnimUpMovement);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BAN_GSParkourAnimInfo:SetAnimMovementValue")]
	public void SetAnimMovementValue(FVector Movement)
	{
		AnimForwardMovement = Movement.X;
		AnimRightMovement = Movement.Y;
		AnimUpMovement = Movement.Z;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSParkourAnimInfo:SetAnimMovementValue")]
	private static void SetAnimMovementValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSParkourAnimInfo bAN_GSParkourAnimInfo = GCHelper.Find<b1.BAN_GSParkourAnimInfo>(obj);
		FVector animMovementValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, SetAnimMovementValue_Movement_Offset));
		bAN_GSParkourAnimInfo.SetAnimMovementValue(animMovementValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSParkourAnimInfo:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSParkourAnimInfo bAN_GSParkourAnimInfo = GCHelper.Find<b1.BAN_GSParkourAnimInfo>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSParkourAnimInfo.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSParkourAnimInfo:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSParkourAnimInfo bAN_GSParkourAnimInfo = GCHelper.Find<b1.BAN_GSParkourAnimInfo>(obj);
		bool value = bAN_GSParkourAnimInfo.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSParkourAnimInfo");
		AnimForwardMovement_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimForwardMovement");
		AnimForwardMovement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimForwardMovement", Classes.FFloatProperty);
		AnimRightMovement_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimRightMovement");
		AnimRightMovement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimRightMovement", Classes.FFloatProperty);
		AnimUpMovement_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimUpMovement");
		AnimUpMovement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimUpMovement", Classes.FFloatProperty);
		SetAnimMovementValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimMovementValue");
		SetAnimMovementValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimMovementValue_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetAnimMovementValue_Movement_PropertyAddress, SetAnimMovementValue_FunctionAddress, "Movement");
		SetAnimMovementValue_Movement_Offset = NativeReflection.GetPropertyOffset(SetAnimMovementValue_FunctionAddress, "Movement");
		SetAnimMovementValue_Movement_IsValid = NativeReflection.ValidatePropertyClass(SetAnimMovementValue_FunctionAddress, "Movement", Classes.FStructProperty);
		SetAnimMovementValue_IsValid = SetAnimMovementValue_FunctionAddress != IntPtr.Zero && SetAnimMovementValue_Movement_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSParkourAnimInfo:SetAnimMovementValue", SetAnimMovementValue_IsValid);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSParkourAnimInfo:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSParkourAnimInfo:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSParkourAnimInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSParkourAnimInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSParkourAnimInfo));
	}
}
