using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioTriggerComp")]
internal class BUS_AudioTriggerComp : UBaseActorComp
{
	private b1.BUC_AudioTriggerConfigData AudioTriggerConfigData;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[USharpPath("/Script/b1-Managed.BUS_AudioTriggerComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		AudioTriggerConfigData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.BUC_AudioTriggerConfigData>(GetOwner());
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AudioTriggerComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUS_AudioTriggerComp bUS_AudioTriggerComp = GCHelper.Find<b1.BUS_AudioTriggerComp>(obj);
		bUS_AudioTriggerComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioTriggerComp");
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AudioTriggerComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BUS_AudioTriggerComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AudioTriggerComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AudioTriggerComp));
	}
}
