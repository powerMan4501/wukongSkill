using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ParticleSystem", "Engine", UnrealModuleType.Engine)]
public class UParticleSystem : UFXSystemAsset
{
	private static bool ContainsEmitterType_IsValid;

	private static IntPtr ContainsEmitterType_FunctionAddress;

	private static int ContainsEmitterType_ParamsSize;

	private static bool ContainsEmitterType_TypeData_IsValid;

	private static FFieldAddress ContainsEmitterType_TypeData_PropertyAddress;

	private static int ContainsEmitterType_TypeData_Offset;

	private static bool ContainsEmitterType_ReturnValue_IsValid;

	private static FFieldAddress ContainsEmitterType_ReturnValue_PropertyAddress;

	private static int ContainsEmitterType_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystem:ContainsEmitterType")]
	public unsafe bool ContainsEmitterType(TSubclassOf<UObject> TypeData)
	{
		CheckDestroyed();
		if (!ContainsEmitterType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystem:ContainsEmitterType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ContainsEmitterType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ContainsEmitterType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ContainsEmitterType_TypeData_Offset), 0, ContainsEmitterType_TypeData_PropertyAddress.Address, TypeData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ContainsEmitterType_FunctionAddress, intPtr, ContainsEmitterType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ContainsEmitterType_ReturnValue_Offset), 0, ContainsEmitterType_ReturnValue_PropertyAddress.Address);
	}

	static UParticleSystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UParticleSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UParticleSystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.ParticleSystem");
		ContainsEmitterType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ContainsEmitterType");
		ContainsEmitterType_ParamsSize = NativeReflection.GetFunctionParamsSize(ContainsEmitterType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ContainsEmitterType_TypeData_PropertyAddress, ContainsEmitterType_FunctionAddress, "TypeData");
		ContainsEmitterType_TypeData_Offset = NativeReflectionCached.GetPropertyOffset(ContainsEmitterType_FunctionAddress, "TypeData");
		ContainsEmitterType_TypeData_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainsEmitterType_FunctionAddress, "TypeData", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ContainsEmitterType_ReturnValue_PropertyAddress, ContainsEmitterType_FunctionAddress, "ReturnValue");
		ContainsEmitterType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ContainsEmitterType_FunctionAddress, "ReturnValue");
		ContainsEmitterType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainsEmitterType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ContainsEmitterType_IsValid = ContainsEmitterType_FunctionAddress != IntPtr.Zero && ContainsEmitterType_TypeData_IsValid && ContainsEmitterType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystem:ContainsEmitterType", ContainsEmitterType_IsValid);
	}
}
