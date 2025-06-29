using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AnimNotify_GSFootStep")]
internal class UAnimNotify_GSFootStep : BAN_GSBase
{
	private static bool FootStepType_IsValid;

	private static int FootStepType_Offset;

	private static FFieldAddress FootStepType_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimNotify_GSFootStep:FootStepType")]
	public EFootStepType FootStepType
	{
		get
		{
			CheckDestroyed();
			if (!FootStepType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AnimNotify_GSFootStep:FootStepType");
				return EFootStepType.LeftFoot;
			}
			return EnumMarshaler<EFootStepType>.FromNative(IntPtr.Add(base.Address, FootStepType_Offset), 0, FootStepType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FootStepType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AnimNotify_GSFootStep:FootStepType");
			}
			else
			{
				EnumMarshaler<EFootStepType>.ToNative(IntPtr.Add(base.Address, FootStepType_Offset), 0, FootStepType_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.AnimNotify_GSFootStep:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (aActor != null && aActor.World != null)
		{
			BUS_EventCollectionCS.Get(aActor)?.Evt_TriggerFootStep.Invoke(FootStepType, IsFromNotify: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.AnimNotify_GSFootStep:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UAnimNotify_GSFootStep uAnimNotify_GSFootStep = GCHelper.Find<b1.UAnimNotify_GSFootStep>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		uAnimNotify_GSFootStep.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AnimNotify_GSFootStep");
		NativeReflection.GetPropertyRef(ref FootStepType_PropertyAddress, intPtr, "FootStepType");
		FootStepType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootStepType");
		FootStepType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootStepType", Classes.FEnumProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AnimNotify_GSFootStep:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static UAnimNotify_GSFootStep()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UAnimNotify_GSFootStep)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UAnimNotify_GSFootStep));
	}
}
