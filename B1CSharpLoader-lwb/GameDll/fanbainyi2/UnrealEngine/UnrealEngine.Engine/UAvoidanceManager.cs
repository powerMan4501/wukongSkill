using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549412uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AvoidanceManager", "Engine", UnrealModuleType.Engine)]
public class UAvoidanceManager : UObject
{
	private static bool RegisterMovementComponent_IsValid;

	private static IntPtr RegisterMovementComponent_FunctionAddress;

	private static int RegisterMovementComponent_ParamsSize;

	private static bool RegisterMovementComponent_MovementComp_IsValid;

	private static FFieldAddress RegisterMovementComponent_MovementComp_PropertyAddress;

	private static int RegisterMovementComponent_MovementComp_Offset;

	private static bool RegisterMovementComponent_AvoidanceWeight_IsValid;

	private static FFieldAddress RegisterMovementComponent_AvoidanceWeight_PropertyAddress;

	private static int RegisterMovementComponent_AvoidanceWeight_Offset;

	private static bool RegisterMovementComponent_ReturnValue_IsValid;

	private static FFieldAddress RegisterMovementComponent_ReturnValue_PropertyAddress;

	private static int RegisterMovementComponent_ReturnValue_Offset;

	private static bool GetObjectCount_IsValid;

	private static IntPtr GetObjectCount_FunctionAddress;

	private static int GetObjectCount_ParamsSize;

	private static bool GetObjectCount_ReturnValue_IsValid;

	private static FFieldAddress GetObjectCount_ReturnValue_PropertyAddress;

	private static int GetObjectCount_ReturnValue_Offset;

	private static bool GetNewAvoidanceUID_IsValid;

	private static IntPtr GetNewAvoidanceUID_FunctionAddress;

	private static int GetNewAvoidanceUID_ParamsSize;

	private static bool GetNewAvoidanceUID_ReturnValue_IsValid;

	private static FFieldAddress GetNewAvoidanceUID_ReturnValue_PropertyAddress;

	private static int GetNewAvoidanceUID_ReturnValue_Offset;

	private static bool GetAvoidanceVelocityForComponent_IsValid;

	private static IntPtr GetAvoidanceVelocityForComponent_FunctionAddress;

	private static int GetAvoidanceVelocityForComponent_ParamsSize;

	private static bool GetAvoidanceVelocityForComponent_MovementComp_IsValid;

	private static FFieldAddress GetAvoidanceVelocityForComponent_MovementComp_PropertyAddress;

	private static int GetAvoidanceVelocityForComponent_MovementComp_Offset;

	private static bool GetAvoidanceVelocityForComponent_ReturnValue_IsValid;

	private static FFieldAddress GetAvoidanceVelocityForComponent_ReturnValue_PropertyAddress;

	private static int GetAvoidanceVelocityForComponent_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AvoidanceManager:RegisterMovementComponent")]
	public unsafe bool RegisterMovementComponent(UMovementComponent MovementComp, float AvoidanceWeight = 0.5f)
	{
		CheckDestroyed();
		if (!RegisterMovementComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AvoidanceManager:RegisterMovementComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterMovementComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterMovementComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovementComponent>.ToNative(IntPtr.Add(intPtr, RegisterMovementComponent_MovementComp_Offset), 0, RegisterMovementComponent_MovementComp_PropertyAddress.Address, MovementComp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RegisterMovementComponent_AvoidanceWeight_Offset), 0, RegisterMovementComponent_AvoidanceWeight_PropertyAddress.Address, AvoidanceWeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterMovementComponent_FunctionAddress, intPtr, RegisterMovementComponent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RegisterMovementComponent_ReturnValue_Offset), 0, RegisterMovementComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AvoidanceManager:GetObjectCount")]
	public unsafe int GetObjectCount()
	{
		CheckDestroyed();
		if (!GetObjectCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AvoidanceManager:GetObjectCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectCount_FunctionAddress, intPtr, GetObjectCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetObjectCount_ReturnValue_Offset), 0, GetObjectCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AvoidanceManager:GetNewAvoidanceUID")]
	public unsafe int GetNewAvoidanceUID()
	{
		CheckDestroyed();
		if (!GetNewAvoidanceUID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AvoidanceManager:GetNewAvoidanceUID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNewAvoidanceUID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNewAvoidanceUID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNewAvoidanceUID_FunctionAddress, intPtr, GetNewAvoidanceUID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNewAvoidanceUID_ReturnValue_Offset), 0, GetNewAvoidanceUID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.AvoidanceManager:GetAvoidanceVelocityForComponent")]
	public unsafe FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp)
	{
		CheckDestroyed();
		if (!GetAvoidanceVelocityForComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AvoidanceManager:GetAvoidanceVelocityForComponent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvoidanceVelocityForComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvoidanceVelocityForComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovementComponent>.ToNative(IntPtr.Add(intPtr, GetAvoidanceVelocityForComponent_MovementComp_Offset), 0, GetAvoidanceVelocityForComponent_MovementComp_PropertyAddress.Address, MovementComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAvoidanceVelocityForComponent_FunctionAddress, intPtr, GetAvoidanceVelocityForComponent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAvoidanceVelocityForComponent_ReturnValue_Offset), 0, GetAvoidanceVelocityForComponent_ReturnValue_PropertyAddress.Address);
	}

	static UAvoidanceManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAvoidanceManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAvoidanceManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AvoidanceManager");
		RegisterMovementComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterMovementComponent");
		RegisterMovementComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterMovementComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterMovementComponent_MovementComp_PropertyAddress, RegisterMovementComponent_FunctionAddress, "MovementComp");
		RegisterMovementComponent_MovementComp_Offset = NativeReflectionCached.GetPropertyOffset(RegisterMovementComponent_FunctionAddress, "MovementComp");
		RegisterMovementComponent_MovementComp_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterMovementComponent_FunctionAddress, "MovementComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterMovementComponent_AvoidanceWeight_PropertyAddress, RegisterMovementComponent_FunctionAddress, "AvoidanceWeight");
		RegisterMovementComponent_AvoidanceWeight_Offset = NativeReflectionCached.GetPropertyOffset(RegisterMovementComponent_FunctionAddress, "AvoidanceWeight");
		RegisterMovementComponent_AvoidanceWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterMovementComponent_FunctionAddress, "AvoidanceWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterMovementComponent_ReturnValue_PropertyAddress, RegisterMovementComponent_FunctionAddress, "ReturnValue");
		RegisterMovementComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RegisterMovementComponent_FunctionAddress, "ReturnValue");
		RegisterMovementComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterMovementComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RegisterMovementComponent_IsValid = RegisterMovementComponent_FunctionAddress != IntPtr.Zero && RegisterMovementComponent_MovementComp_IsValid && RegisterMovementComponent_AvoidanceWeight_IsValid && RegisterMovementComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AvoidanceManager:RegisterMovementComponent", RegisterMovementComponent_IsValid);
		GetObjectCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectCount");
		GetObjectCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectCount_ReturnValue_PropertyAddress, GetObjectCount_FunctionAddress, "ReturnValue");
		GetObjectCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectCount_FunctionAddress, "ReturnValue");
		GetObjectCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetObjectCount_IsValid = GetObjectCount_FunctionAddress != IntPtr.Zero && GetObjectCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AvoidanceManager:GetObjectCount", GetObjectCount_IsValid);
		GetNewAvoidanceUID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNewAvoidanceUID");
		GetNewAvoidanceUID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNewAvoidanceUID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNewAvoidanceUID_ReturnValue_PropertyAddress, GetNewAvoidanceUID_FunctionAddress, "ReturnValue");
		GetNewAvoidanceUID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNewAvoidanceUID_FunctionAddress, "ReturnValue");
		GetNewAvoidanceUID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNewAvoidanceUID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNewAvoidanceUID_IsValid = GetNewAvoidanceUID_FunctionAddress != IntPtr.Zero && GetNewAvoidanceUID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AvoidanceManager:GetNewAvoidanceUID", GetNewAvoidanceUID_IsValid);
		GetAvoidanceVelocityForComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAvoidanceVelocityForComponent");
		GetAvoidanceVelocityForComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvoidanceVelocityForComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvoidanceVelocityForComponent_MovementComp_PropertyAddress, GetAvoidanceVelocityForComponent_FunctionAddress, "MovementComp");
		GetAvoidanceVelocityForComponent_MovementComp_Offset = NativeReflectionCached.GetPropertyOffset(GetAvoidanceVelocityForComponent_FunctionAddress, "MovementComp");
		GetAvoidanceVelocityForComponent_MovementComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvoidanceVelocityForComponent_FunctionAddress, "MovementComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvoidanceVelocityForComponent_ReturnValue_PropertyAddress, GetAvoidanceVelocityForComponent_FunctionAddress, "ReturnValue");
		GetAvoidanceVelocityForComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvoidanceVelocityForComponent_FunctionAddress, "ReturnValue");
		GetAvoidanceVelocityForComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvoidanceVelocityForComponent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAvoidanceVelocityForComponent_IsValid = GetAvoidanceVelocityForComponent_FunctionAddress != IntPtr.Zero && GetAvoidanceVelocityForComponent_MovementComp_IsValid && GetAvoidanceVelocityForComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AvoidanceManager:GetAvoidanceVelocityForComponent", GetAvoidanceVelocityForComponent_IsValid);
	}
}
