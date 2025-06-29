using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN GS Stop Interact Target Idle FX")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSStopInteractTargetIdleFX")]
internal class BAN_GSStopInteractTargetIdleFX : BAN_GSBase
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BAN_GSStopInteractTargetIdleFX:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		IBPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerInteractData, BPC_PlayerInteractData>(bGUCharacterCS.PlayerState);
		if (readOnlyData != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ECSExtension.ToActor(readOnlyData.CurrentInteractingEntityRef));
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_StopInteractTargetIdleFX?.Invoke(bGUCharacterCS);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSStopInteractTargetIdleFX:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSStopInteractTargetIdleFX bAN_GSStopInteractTargetIdleFX = GCHelper.Find<b1.BAN_GSStopInteractTargetIdleFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSStopInteractTargetIdleFX.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSStopInteractTargetIdleFX");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSStopInteractTargetIdleFX:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSStopInteractTargetIdleFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSStopInteractTargetIdleFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSStopInteractTargetIdleFX));
	}
}
