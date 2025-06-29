using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.LandscapeHeightModifierVolume", "UnrealExtent", UnrealModuleType.Game)]
public class ALandscapeHeightModifierVolume : AVolume
{
	private static bool RecomputeHeightMap_IsValid;

	private static IntPtr RecomputeHeightMap_FunctionAddress;

	private static int RecomputeHeightMap_ParamsSize;

	[UFunction(Flags = 604242945u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeHeightModifierVolume:RecomputeHeightMap")]
	public unsafe void RecomputeHeightMap()
	{
		CheckDestroyed();
		if (!RecomputeHeightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeHeightModifierVolume:RecomputeHeightMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeHeightMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeHeightMap_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputeHeightMap_FunctionAddress, argsSize: RecomputeHeightMap_ParamsSize);
	}

	static ALandscapeHeightModifierVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapeHeightModifierVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapeHeightModifierVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.LandscapeHeightModifierVolume");
		RecomputeHeightMap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeHeightMap");
		RecomputeHeightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeHeightMap_FunctionAddress);
		RecomputeHeightMap_IsValid = RecomputeHeightMap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeHeightModifierVolume:RecomputeHeightMap", RecomputeHeightMap_IsValid);
	}
}
