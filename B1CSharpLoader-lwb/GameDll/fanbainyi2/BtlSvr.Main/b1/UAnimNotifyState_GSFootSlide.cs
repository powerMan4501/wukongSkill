using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AnimNotifyState_GSFootSlide")]
internal class UAnimNotifyState_GSFootSlide : BANS_GSBase
{
	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[USharpPath("/Script/b1-Managed.AnimNotifyState_GSFootSlide:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_FootSlideBegin.Invoke(TotalDuration);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.AnimNotifyState_GSFootSlide:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UAnimNotifyState_GSFootSlide uAnimNotifyState_GSFootSlide = GCHelper.Find<b1.UAnimNotifyState_GSFootSlide>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		uAnimNotifyState_GSFootSlide.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.AnimNotifyState_GSFootSlide");
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AnimNotifyState_GSFootSlide:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static UAnimNotifyState_GSFootSlide()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UAnimNotifyState_GSFootSlide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UAnimNotifyState_GSFootSlide));
	}
}
