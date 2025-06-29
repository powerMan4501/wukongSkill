using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.LandscapePhysicalMatModifierVolume", "UnrealExtent", UnrealModuleType.Game)]
public class ALandscapePhysicalMatModifierVolume : AVolume
{
	private static bool RecomputePhysicalMaterial_IsValid;

	private static IntPtr RecomputePhysicalMaterial_FunctionAddress;

	private static int RecomputePhysicalMaterial_ParamsSize;

	[UFunction(Flags = 604242945u)]
	[UMetaPath("/Script/UnrealExtent.LandscapePhysicalMatModifierVolume:RecomputePhysicalMaterial")]
	public unsafe void RecomputePhysicalMaterial()
	{
		CheckDestroyed();
		if (!RecomputePhysicalMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapePhysicalMatModifierVolume:RecomputePhysicalMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputePhysicalMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputePhysicalMaterial_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputePhysicalMaterial_FunctionAddress, argsSize: RecomputePhysicalMaterial_ParamsSize);
	}

	static ALandscapePhysicalMatModifierVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapePhysicalMatModifierVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapePhysicalMatModifierVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.LandscapePhysicalMatModifierVolume");
		RecomputePhysicalMaterial_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputePhysicalMaterial");
		RecomputePhysicalMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputePhysicalMaterial_FunctionAddress);
		RecomputePhysicalMaterial_IsValid = RecomputePhysicalMaterial_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapePhysicalMatModifierVolume:RecomputePhysicalMaterial", RecomputePhysicalMaterial_IsValid);
	}
}
