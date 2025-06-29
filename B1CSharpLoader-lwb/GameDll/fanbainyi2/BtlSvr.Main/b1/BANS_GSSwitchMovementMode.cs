using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Switch Movement Mode")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSwitchMovementMode")]
internal class BANS_GSSwitchMovementMode : BANS_GSBase
{
	private static bool MovementMode_IsValid;

	private static int MovementMode_Offset;

	private static FFieldAddress MovementMode_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSwitchMovementMode:MovementMode")]
	public EMovementMode MovementMode
	{
		get
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSwitchMovementMode:MovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSwitchMovementMode:MovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(owner) != null)
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, (int)MovementMode, 0u, GetUniqueID(), bSetDefaultProperty: false, "BANS_GSSwitchMovementMode");
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_ResetProperty.Invoke(0u, GetUniqueID());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSwitchMovementMode bANS_GSSwitchMovementMode = GCHelper.Find<b1.BANS_GSSwitchMovementMode>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSwitchMovementMode.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSwitchMovementMode bANS_GSSwitchMovementMode = GCHelper.Find<b1.BANS_GSSwitchMovementMode>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSwitchMovementMode.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSwitchMovementMode");
		NativeReflection.GetPropertyRef(ref MovementMode_PropertyAddress, intPtr, "MovementMode");
		MovementMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MovementMode");
		MovementMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MovementMode", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSwitchMovementMode:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSwitchMovementMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSwitchMovementMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSwitchMovementMode));
	}
}
