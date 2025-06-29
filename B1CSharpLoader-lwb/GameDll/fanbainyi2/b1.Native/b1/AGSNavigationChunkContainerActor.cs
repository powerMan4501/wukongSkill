using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSNavigationChunkContainerActor", "UnrealExtent", UnrealModuleType.Game)]
public class AGSNavigationChunkContainerActor : APartitionActor
{
	private static bool CleanUpActor_IsValid;

	private static IntPtr CleanUpActor_FunctionAddress;

	private static int CleanUpActor_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GSNavigationChunkContainerActor:CleanUpActor")]
	public unsafe void CleanUpActor()
	{
		CheckDestroyed();
		if (!CleanUpActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSNavigationChunkContainerActor:CleanUpActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanUpActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanUpActor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CleanUpActor_FunctionAddress, argsSize: CleanUpActor_ParamsSize);
	}

	static AGSNavigationChunkContainerActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSNavigationChunkContainerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSNavigationChunkContainerActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.GSNavigationChunkContainerActor");
		CleanUpActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CleanUpActor");
		CleanUpActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanUpActor_FunctionAddress);
		CleanUpActor_IsValid = CleanUpActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSNavigationChunkContainerActor:CleanUpActor", CleanUpActor_IsValid);
	}
}
