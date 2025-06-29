using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Swicth Move State")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_SwicthMoveState")]
internal class BANS_SwicthMoveState : BANS_GSBase
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

	[Category("MoveMode")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_SwicthMoveState:MovementMode")]
	public EMovementMode MovementMode
	{
		get
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SwicthMoveState:MovementMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SwicthMoveState:MovementMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, MovementMode_Offset), 0, MovementMode_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null && BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(bGUCharacterCS) != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, (int)MovementMode, 0u, GetUniqueID(), bSetDefaultProperty: false, "BANS_GSSwitchMoveState");
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ResetProperty.Invoke(0u, GetUniqueID());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SwicthMoveState bANS_SwicthMoveState = GCHelper.Find<b1.BANS_SwicthMoveState>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_SwicthMoveState.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SwicthMoveState bANS_SwicthMoveState = GCHelper.Find<b1.BANS_SwicthMoveState>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_SwicthMoveState.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_SwicthMoveState");
		NativeReflection.GetPropertyRef(ref MovementMode_PropertyAddress, intPtr, "MovementMode");
		MovementMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MovementMode");
		MovementMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MovementMode", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SwicthMoveState:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_SwicthMoveState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_SwicthMoveState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_SwicthMoveState));
	}
}
