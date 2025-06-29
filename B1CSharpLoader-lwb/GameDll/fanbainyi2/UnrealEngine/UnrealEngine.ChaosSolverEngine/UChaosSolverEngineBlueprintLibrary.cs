using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary", "ChaosSolverEngine", UnrealModuleType.Engine)]
public class UChaosSolverEngineBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ConvertPhysicsCollisionToHitResult_IsValid;

	private static IntPtr ConvertPhysicsCollisionToHitResult_FunctionAddress;

	private static int ConvertPhysicsCollisionToHitResult_ParamsSize;

	private static bool ConvertPhysicsCollisionToHitResult_PhysicsCollision_IsValid;

	private static FFieldAddress ConvertPhysicsCollisionToHitResult_PhysicsCollision_PropertyAddress;

	private static int ConvertPhysicsCollisionToHitResult_PhysicsCollision_Offset;

	private static bool ConvertPhysicsCollisionToHitResult_ReturnValue_IsValid;

	private static FFieldAddress ConvertPhysicsCollisionToHitResult_ReturnValue_PropertyAddress;

	private static int ConvertPhysicsCollisionToHitResult_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary:ConvertPhysicsCollisionToHitResult")]
	public unsafe static FHitResult ConvertPhysicsCollisionToHitResult(FChaosPhysicsCollisionInfo PhysicsCollision)
	{
		if (!ConvertPhysicsCollisionToHitResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary:ConvertPhysicsCollisionToHitResult");
			return default(FHitResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertPhysicsCollisionToHitResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertPhysicsCollisionToHitResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertPhysicsCollisionToHitResult_PhysicsCollision_PropertyAddress.Address, intPtr);
		FChaosPhysicsCollisionInfo.ToNative(IntPtr.Add(intPtr, ConvertPhysicsCollisionToHitResult_PhysicsCollision_Offset), 0, ConvertPhysicsCollisionToHitResult_PhysicsCollision_PropertyAddress.Address, PhysicsCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertPhysicsCollisionToHitResult_FunctionAddress, intPtr, ConvertPhysicsCollisionToHitResult_ParamsSize);
		return FHitResult.FromNative(IntPtr.Add(intPtr, ConvertPhysicsCollisionToHitResult_ReturnValue_Offset), 0, ConvertPhysicsCollisionToHitResult_ReturnValue_PropertyAddress.Address);
	}

	static UChaosSolverEngineBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChaosSolverEngineBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChaosSolverEngineBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary");
		ConvertPhysicsCollisionToHitResult_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertPhysicsCollisionToHitResult");
		ConvertPhysicsCollisionToHitResult_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertPhysicsCollisionToHitResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertPhysicsCollisionToHitResult_PhysicsCollision_PropertyAddress, ConvertPhysicsCollisionToHitResult_FunctionAddress, "PhysicsCollision");
		ConvertPhysicsCollisionToHitResult_PhysicsCollision_Offset = NativeReflectionCached.GetPropertyOffset(ConvertPhysicsCollisionToHitResult_FunctionAddress, "PhysicsCollision");
		ConvertPhysicsCollisionToHitResult_PhysicsCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertPhysicsCollisionToHitResult_FunctionAddress, "PhysicsCollision", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertPhysicsCollisionToHitResult_ReturnValue_PropertyAddress, ConvertPhysicsCollisionToHitResult_FunctionAddress, "ReturnValue");
		ConvertPhysicsCollisionToHitResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertPhysicsCollisionToHitResult_FunctionAddress, "ReturnValue");
		ConvertPhysicsCollisionToHitResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertPhysicsCollisionToHitResult_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertPhysicsCollisionToHitResult_IsValid = ConvertPhysicsCollisionToHitResult_FunctionAddress != IntPtr.Zero && ConvertPhysicsCollisionToHitResult_PhysicsCollision_IsValid && ConvertPhysicsCollisionToHitResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary:ConvertPhysicsCollisionToHitResult", ConvertPhysicsCollisionToHitResult_IsValid);
	}
}
