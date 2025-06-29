using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.LandscapeModifierVolume", "UnrealExtent", UnrealModuleType.Game)]
public class ALandscapeModifierVolume : AVolume
{
	private static bool RecomputeHeightMap_IsValid;

	private static IntPtr RecomputeHeightMap_FunctionAddress;

	private static int RecomputeHeightMap_ParamsSize;

	[UFunction(Flags = 604242945u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeModifierVolume:RecomputeHeightMap")]
	public unsafe void RecomputeHeightMap()
	{
		CheckDestroyed();
		if (!RecomputeHeightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeModifierVolume:RecomputeHeightMap");
			return;
		}
		IntPtr intPtr;
		if (NativeReflection.IsOptimized)
		{
			byte* ptr = stackalloc byte[(int)(uint)(RecomputeHeightMap_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			new Span<byte>(ptr2, RecomputeHeightMap_ParamsSize).Fill(0);
			intPtr = new IntPtr(ptr2);
		}
		else
		{
			byte* address = stackalloc byte[(int)(uint)(RecomputeHeightMap_ParamsSize + 16)];
			intPtr = NativeReflection.StackAllocAlign(address);
			FMemory.Memzero(intPtr, RecomputeHeightMap_ParamsSize);
		}
		if (NativeReflection.IsOptimized)
		{
			NativeReflection.InvokeFunctionOptimized(base.Address, RecomputeHeightMap_FunctionAddress, intPtr, RecomputeHeightMap_ParamsSize);
		}
		else
		{
			NativeReflection.InvokeFunction(base.Address, RecomputeHeightMap_FunctionAddress, intPtr, RecomputeHeightMap_ParamsSize);
		}
	}

	static ALandscapeModifierVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapeModifierVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapeModifierVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.LandscapeModifierVolume");
		RecomputeHeightMap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeHeightMap");
		RecomputeHeightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeHeightMap_FunctionAddress);
		RecomputeHeightMap_IsValid = RecomputeHeightMap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeModifierVolume:RecomputeHeightMap", RecomputeHeightMap_IsValid);
	}
}
