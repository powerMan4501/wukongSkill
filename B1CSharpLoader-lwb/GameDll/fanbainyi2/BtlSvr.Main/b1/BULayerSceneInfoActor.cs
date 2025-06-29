using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BULayerSceneInfoActor")]
internal class BULayerSceneInfoActor : ALayerSceneInfo
{
	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[USharpPath("/Script/b1-Managed.BULayerSceneInfoActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		BGW_LandLayerInfoMgr bGW_LandLayerInfoMgr = BGW_LandLayerInfoMgr.Get(this);
		if (!bGW_LandLayerInfoMgr.IsNullOrDestroyed())
		{
			bGW_LandLayerInfoMgr.RegisterLayerSceneActor(this);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BULayerSceneInfoActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BULayerSceneInfoActor bULayerSceneInfoActor = GCHelper.Find<b1.BULayerSceneInfoActor>(obj);
		bULayerSceneInfoActor.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BULayerSceneInfoActor");
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BULayerSceneInfoActor:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BULayerSceneInfoActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BULayerSceneInfoActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BULayerSceneInfoActor));
	}
}
