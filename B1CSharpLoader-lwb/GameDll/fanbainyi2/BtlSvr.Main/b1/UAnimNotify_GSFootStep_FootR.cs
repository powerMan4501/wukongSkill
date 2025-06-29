using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AnimNotify_GSFootStep_FootR")]
internal class UAnimNotify_GSFootStep_FootR : b1.UAnimNotify_GSFootStep
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.AnimNotify_GSFootStep_FootR:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		base.FootStepType = EFootStepType.RightFoot;
		base.GSNotifyCS_Implementation(NotifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.AnimNotify_GSFootStep_FootR:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UAnimNotify_GSFootStep_FootR uAnimNotify_GSFootStep_FootR = GCHelper.Find<b1.UAnimNotify_GSFootStep_FootR>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		uAnimNotify_GSFootStep_FootR.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.AnimNotify_GSFootStep_FootR");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AnimNotify_GSFootStep_FootR:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static UAnimNotify_GSFootStep_FootR()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UAnimNotify_GSFootStep_FootR)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UAnimNotify_GSFootStep_FootR));
	}
}
