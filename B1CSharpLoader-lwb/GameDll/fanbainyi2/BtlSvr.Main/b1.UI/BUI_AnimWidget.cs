using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_AnimWidget")]
public class BUI_AnimWidget : UUserWidget
{
	public Action<int> Evt_AnimationSequence;

	private static bool OnAnimationSequenceEvent_IsValid;

	private static IntPtr OnAnimationSequenceEvent_FunctionAddress;

	private static int OnAnimationSequenceEvent_ParamsSize;

	private static bool OnAnimationSequenceEvent_Param_IsValid;

	private static int OnAnimationSequenceEvent_Param_Offset;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_AnimWidget:OnAnimationSequenceEvent")]
	protected void OnAnimationSequenceEvent(int Param)
	{
		Evt_AnimationSequence?.Invoke(Param);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_AnimWidget:OnAnimationSequenceEvent")]
	private static void OnAnimationSequenceEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_AnimWidget bUI_AnimWidget = GCHelper.Find<BUI_AnimWidget>(obj);
		int param = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnAnimationSequenceEvent_Param_Offset));
		bUI_AnimWidget.OnAnimationSequenceEvent(param);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_AnimWidget");
		OnAnimationSequenceEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAnimationSequenceEvent");
		OnAnimationSequenceEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationSequenceEvent_FunctionAddress);
		OnAnimationSequenceEvent_Param_Offset = NativeReflection.GetPropertyOffset(OnAnimationSequenceEvent_FunctionAddress, "Param");
		OnAnimationSequenceEvent_Param_IsValid = NativeReflection.ValidatePropertyClass(OnAnimationSequenceEvent_FunctionAddress, "Param", Classes.FIntProperty);
		OnAnimationSequenceEvent_IsValid = OnAnimationSequenceEvent_FunctionAddress != IntPtr.Zero && OnAnimationSequenceEvent_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_AnimWidget:OnAnimationSequenceEvent", OnAnimationSequenceEvent_IsValid);
	}

	static BUI_AnimWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_AnimWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_AnimWidget));
	}
}
