using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.BGWBlockingVolume", "UnrealExtent", UnrealModuleType.Game)]
public class ABGWBlockingVolume : AVolume, INavRelevantInterface, IInterface
{
	private static bool SyncBrushToBoxComponent_IsValid;

	private static IntPtr SyncBrushToBoxComponent_FunctionAddress;

	private static int SyncBrushToBoxComponent_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.BGWBlockingVolume:SyncBrushToBoxComponent")]
	public unsafe void SyncBrushToBoxComponent()
	{
		CheckDestroyed();
		if (!SyncBrushToBoxComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGWBlockingVolume:SyncBrushToBoxComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncBrushToBoxComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncBrushToBoxComponent_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SyncBrushToBoxComponent_FunctionAddress, argsSize: SyncBrushToBoxComponent_ParamsSize);
	}

	static ABGWBlockingVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWBlockingVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWBlockingVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.BGWBlockingVolume");
		SyncBrushToBoxComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SyncBrushToBoxComponent");
		SyncBrushToBoxComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncBrushToBoxComponent_FunctionAddress);
		SyncBrushToBoxComponent_IsValid = SyncBrushToBoxComponent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGWBlockingVolume:SyncBrushToBoxComponent", SyncBrushToBoxComponent_IsValid);
	}
}
