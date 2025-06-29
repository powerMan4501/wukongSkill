using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ClothingSystemRuntimeInterface;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor", "ClothingSystemRuntimeInterface", UnrealModuleType.Engine)]
public class UClothingSimulationInteractor : UObject
{
	private static bool SetNumSubsteps_IsValid;

	private static IntPtr SetNumSubsteps_FunctionAddress;

	private static int SetNumSubsteps_ParamsSize;

	private static bool SetNumSubsteps_NumSubsteps_IsValid;

	private static FFieldAddress SetNumSubsteps_NumSubsteps_PropertyAddress;

	private static int SetNumSubsteps_NumSubsteps_Offset;

	private static bool SetNumIterations_IsValid;

	private static IntPtr SetNumIterations_FunctionAddress;

	private static int SetNumIterations_ParamsSize;

	private static bool SetNumIterations_NumIterations_IsValid;

	private static FFieldAddress SetNumIterations_NumIterations_PropertyAddress;

	private static int SetNumIterations_NumIterations_Offset;

	private static bool SetMaxNumIterations_IsValid;

	private static IntPtr SetMaxNumIterations_FunctionAddress;

	private static int SetMaxNumIterations_ParamsSize;

	private static bool SetMaxNumIterations_MaxNumIterations_IsValid;

	private static FFieldAddress SetMaxNumIterations_MaxNumIterations_PropertyAddress;

	private static int SetMaxNumIterations_MaxNumIterations_Offset;

	private static bool SetAnimDriveSpringStiffness_IsValid;

	private static IntPtr SetAnimDriveSpringStiffness_FunctionAddress;

	private static int SetAnimDriveSpringStiffness_ParamsSize;

	private static bool SetAnimDriveSpringStiffness_InStiffness_IsValid;

	private static FFieldAddress SetAnimDriveSpringStiffness_InStiffness_PropertyAddress;

	private static int SetAnimDriveSpringStiffness_InStiffness_Offset;

	private static bool PhysicsAssetUpdated_IsValid;

	private static IntPtr PhysicsAssetUpdated_FunctionAddress;

	private static int PhysicsAssetUpdated_ParamsSize;

	private static bool GetSimulationTime_IsValid;

	private static IntPtr GetSimulationTime_FunctionAddress;

	private static int GetSimulationTime_ParamsSize;

	private static bool GetSimulationTime_ReturnValue_IsValid;

	private static FFieldAddress GetSimulationTime_ReturnValue_PropertyAddress;

	private static int GetSimulationTime_ReturnValue_Offset;

	private static bool GetNumSubsteps_IsValid;

	private static IntPtr GetNumSubsteps_FunctionAddress;

	private static int GetNumSubsteps_ParamsSize;

	private static bool GetNumSubsteps_ReturnValue_IsValid;

	private static FFieldAddress GetNumSubsteps_ReturnValue_PropertyAddress;

	private static int GetNumSubsteps_ReturnValue_Offset;

	private static bool GetNumKinematicParticles_IsValid;

	private static IntPtr GetNumKinematicParticles_FunctionAddress;

	private static int GetNumKinematicParticles_ParamsSize;

	private static bool GetNumKinematicParticles_ReturnValue_IsValid;

	private static FFieldAddress GetNumKinematicParticles_ReturnValue_PropertyAddress;

	private static int GetNumKinematicParticles_ReturnValue_Offset;

	private static bool GetNumIterations_IsValid;

	private static IntPtr GetNumIterations_FunctionAddress;

	private static int GetNumIterations_ParamsSize;

	private static bool GetNumIterations_ReturnValue_IsValid;

	private static FFieldAddress GetNumIterations_ReturnValue_PropertyAddress;

	private static int GetNumIterations_ReturnValue_Offset;

	private static bool GetNumDynamicParticles_IsValid;

	private static IntPtr GetNumDynamicParticles_FunctionAddress;

	private static int GetNumDynamicParticles_ParamsSize;

	private static bool GetNumDynamicParticles_ReturnValue_IsValid;

	private static FFieldAddress GetNumDynamicParticles_ReturnValue_PropertyAddress;

	private static int GetNumDynamicParticles_ReturnValue_Offset;

	private static bool GetNumCloths_IsValid;

	private static IntPtr GetNumCloths_FunctionAddress;

	private static int GetNumCloths_ParamsSize;

	private static bool GetNumCloths_ReturnValue_IsValid;

	private static FFieldAddress GetNumCloths_ReturnValue_PropertyAddress;

	private static int GetNumCloths_ReturnValue_Offset;

	private static bool GetClothingInteractor_IsValid;

	private static IntPtr GetClothingInteractor_FunctionAddress;

	private static int GetClothingInteractor_ParamsSize;

	private static bool GetClothingInteractor_ClothingAssetName_IsValid;

	private static FFieldAddress GetClothingInteractor_ClothingAssetName_PropertyAddress;

	private static int GetClothingInteractor_ClothingAssetName_Offset;

	private static bool GetClothingInteractor_ReturnValue_IsValid;

	private static FFieldAddress GetClothingInteractor_ReturnValue_PropertyAddress;

	private static int GetClothingInteractor_ReturnValue_Offset;

	private static bool EnableGravityOverride_IsValid;

	private static IntPtr EnableGravityOverride_FunctionAddress;

	private static int EnableGravityOverride_ParamsSize;

	private static bool EnableGravityOverride_InVector_IsValid;

	private static FFieldAddress EnableGravityOverride_InVector_PropertyAddress;

	private static int EnableGravityOverride_InVector_Offset;

	private static bool DisableGravityOverride_IsValid;

	private static IntPtr DisableGravityOverride_FunctionAddress;

	private static int DisableGravityOverride_ParamsSize;

	private static bool ClothConfigUpdated_IsValid;

	private static IntPtr ClothConfigUpdated_FunctionAddress;

	private static int ClothConfigUpdated_ParamsSize;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumSubsteps")]
	public unsafe void SetNumSubsteps(int NumSubsteps = 1)
	{
		CheckDestroyed();
		if (!SetNumSubsteps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumSubsteps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumSubsteps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumSubsteps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumSubsteps_NumSubsteps_Offset), 0, SetNumSubsteps_NumSubsteps_PropertyAddress.Address, NumSubsteps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumSubsteps_FunctionAddress, intPtr, SetNumSubsteps_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumIterations")]
	public unsafe void SetNumIterations(int NumIterations = 1)
	{
		CheckDestroyed();
		if (!SetNumIterations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumIterations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumIterations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumIterations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumIterations_NumIterations_Offset), 0, SetNumIterations_NumIterations_PropertyAddress.Address, NumIterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumIterations_FunctionAddress, intPtr, SetNumIterations_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetMaxNumIterations")]
	public unsafe void SetMaxNumIterations(int MaxNumIterations = 10)
	{
		CheckDestroyed();
		if (!SetMaxNumIterations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetMaxNumIterations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxNumIterations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxNumIterations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaxNumIterations_MaxNumIterations_Offset), 0, SetMaxNumIterations_MaxNumIterations_PropertyAddress.Address, MaxNumIterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxNumIterations_FunctionAddress, intPtr, SetMaxNumIterations_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetAnimDriveSpringStiffness")]
	public unsafe void SetAnimDriveSpringStiffness(float InStiffness)
	{
		CheckDestroyed();
		if (!SetAnimDriveSpringStiffness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetAnimDriveSpringStiffness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimDriveSpringStiffness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimDriveSpringStiffness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimDriveSpringStiffness_InStiffness_Offset), 0, SetAnimDriveSpringStiffness_InStiffness_PropertyAddress.Address, InStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimDriveSpringStiffness_FunctionAddress, intPtr, SetAnimDriveSpringStiffness_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:PhysicsAssetUpdated")]
	public unsafe void PhysicsAssetUpdated()
	{
		CheckDestroyed();
		if (!PhysicsAssetUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:PhysicsAssetUpdated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PhysicsAssetUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PhysicsAssetUpdated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PhysicsAssetUpdated_FunctionAddress, argsSize: PhysicsAssetUpdated_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetSimulationTime")]
	public unsafe float GetSimulationTime()
	{
		CheckDestroyed();
		if (!GetSimulationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetSimulationTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSimulationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSimulationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSimulationTime_FunctionAddress, intPtr, GetSimulationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSimulationTime_ReturnValue_Offset), 0, GetSimulationTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumSubsteps")]
	public unsafe int GetNumSubsteps()
	{
		CheckDestroyed();
		if (!GetNumSubsteps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumSubsteps");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSubsteps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSubsteps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSubsteps_FunctionAddress, intPtr, GetNumSubsteps_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSubsteps_ReturnValue_Offset), 0, GetNumSubsteps_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumKinematicParticles")]
	public unsafe int GetNumKinematicParticles()
	{
		CheckDestroyed();
		if (!GetNumKinematicParticles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumKinematicParticles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumKinematicParticles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumKinematicParticles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumKinematicParticles_FunctionAddress, intPtr, GetNumKinematicParticles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumKinematicParticles_ReturnValue_Offset), 0, GetNumKinematicParticles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumIterations")]
	public unsafe int GetNumIterations()
	{
		CheckDestroyed();
		if (!GetNumIterations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumIterations");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumIterations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumIterations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumIterations_FunctionAddress, intPtr, GetNumIterations_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumIterations_ReturnValue_Offset), 0, GetNumIterations_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumDynamicParticles")]
	public unsafe int GetNumDynamicParticles()
	{
		CheckDestroyed();
		if (!GetNumDynamicParticles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumDynamicParticles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumDynamicParticles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumDynamicParticles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumDynamicParticles_FunctionAddress, intPtr, GetNumDynamicParticles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumDynamicParticles_ReturnValue_Offset), 0, GetNumDynamicParticles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumCloths")]
	public unsafe int GetNumCloths()
	{
		CheckDestroyed();
		if (!GetNumCloths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumCloths");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumCloths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumCloths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumCloths_FunctionAddress, intPtr, GetNumCloths_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumCloths_ReturnValue_Offset), 0, GetNumCloths_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetClothingInteractor")]
	public unsafe UClothingInteractor GetClothingInteractor(string ClothingAssetName)
	{
		CheckDestroyed();
		if (!GetClothingInteractor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetClothingInteractor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClothingInteractor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClothingInteractor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetClothingInteractor_ClothingAssetName_Offset), 0, GetClothingInteractor_ClothingAssetName_PropertyAddress.Address, ClothingAssetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetClothingInteractor_FunctionAddress, intPtr, GetClothingInteractor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetClothingInteractor_ClothingAssetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UClothingInteractor>.FromNative(IntPtr.Add(intPtr, GetClothingInteractor_ReturnValue_Offset), 0, GetClothingInteractor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:EnableGravityOverride")]
	public unsafe void EnableGravityOverride(FVector InVector)
	{
		CheckDestroyed();
		if (!EnableGravityOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:EnableGravityOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableGravityOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableGravityOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, EnableGravityOverride_InVector_Offset), 0, EnableGravityOverride_InVector_PropertyAddress.Address, InVector);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableGravityOverride_FunctionAddress, intPtr, EnableGravityOverride_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:DisableGravityOverride")]
	public unsafe void DisableGravityOverride()
	{
		CheckDestroyed();
		if (!DisableGravityOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:DisableGravityOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableGravityOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableGravityOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableGravityOverride_FunctionAddress, argsSize: DisableGravityOverride_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:ClothConfigUpdated")]
	public unsafe void ClothConfigUpdated()
	{
		CheckDestroyed();
		if (!ClothConfigUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:ClothConfigUpdated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClothConfigUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClothConfigUpdated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClothConfigUpdated_FunctionAddress, argsSize: ClothConfigUpdated_ParamsSize);
	}

	static UClothingSimulationInteractor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UClothingSimulationInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UClothingSimulationInteractor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor");
		SetNumSubsteps_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNumSubsteps");
		SetNumSubsteps_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumSubsteps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumSubsteps_NumSubsteps_PropertyAddress, SetNumSubsteps_FunctionAddress, "NumSubsteps");
		SetNumSubsteps_NumSubsteps_Offset = NativeReflectionCached.GetPropertyOffset(SetNumSubsteps_FunctionAddress, "NumSubsteps");
		SetNumSubsteps_NumSubsteps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumSubsteps_FunctionAddress, "NumSubsteps", Classes.FIntProperty);
		SetNumSubsteps_IsValid = SetNumSubsteps_FunctionAddress != IntPtr.Zero && SetNumSubsteps_NumSubsteps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumSubsteps", SetNumSubsteps_IsValid);
		SetNumIterations_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNumIterations");
		SetNumIterations_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumIterations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumIterations_NumIterations_PropertyAddress, SetNumIterations_FunctionAddress, "NumIterations");
		SetNumIterations_NumIterations_Offset = NativeReflectionCached.GetPropertyOffset(SetNumIterations_FunctionAddress, "NumIterations");
		SetNumIterations_NumIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumIterations_FunctionAddress, "NumIterations", Classes.FIntProperty);
		SetNumIterations_IsValid = SetNumIterations_FunctionAddress != IntPtr.Zero && SetNumIterations_NumIterations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetNumIterations", SetNumIterations_IsValid);
		SetMaxNumIterations_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMaxNumIterations");
		SetMaxNumIterations_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxNumIterations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxNumIterations_MaxNumIterations_PropertyAddress, SetMaxNumIterations_FunctionAddress, "MaxNumIterations");
		SetMaxNumIterations_MaxNumIterations_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxNumIterations_FunctionAddress, "MaxNumIterations");
		SetMaxNumIterations_MaxNumIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxNumIterations_FunctionAddress, "MaxNumIterations", Classes.FIntProperty);
		SetMaxNumIterations_IsValid = SetMaxNumIterations_FunctionAddress != IntPtr.Zero && SetMaxNumIterations_MaxNumIterations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetMaxNumIterations", SetMaxNumIterations_IsValid);
		SetAnimDriveSpringStiffness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAnimDriveSpringStiffness");
		SetAnimDriveSpringStiffness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimDriveSpringStiffness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimDriveSpringStiffness_InStiffness_PropertyAddress, SetAnimDriveSpringStiffness_FunctionAddress, "InStiffness");
		SetAnimDriveSpringStiffness_InStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimDriveSpringStiffness_FunctionAddress, "InStiffness");
		SetAnimDriveSpringStiffness_InStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimDriveSpringStiffness_FunctionAddress, "InStiffness", Classes.FFloatProperty);
		SetAnimDriveSpringStiffness_IsValid = SetAnimDriveSpringStiffness_FunctionAddress != IntPtr.Zero && SetAnimDriveSpringStiffness_InStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:SetAnimDriveSpringStiffness", SetAnimDriveSpringStiffness_IsValid);
		PhysicsAssetUpdated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PhysicsAssetUpdated");
		PhysicsAssetUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(PhysicsAssetUpdated_FunctionAddress);
		PhysicsAssetUpdated_IsValid = PhysicsAssetUpdated_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:PhysicsAssetUpdated", PhysicsAssetUpdated_IsValid);
		GetSimulationTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSimulationTime");
		GetSimulationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSimulationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSimulationTime_ReturnValue_PropertyAddress, GetSimulationTime_FunctionAddress, "ReturnValue");
		GetSimulationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSimulationTime_FunctionAddress, "ReturnValue");
		GetSimulationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSimulationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSimulationTime_IsValid = GetSimulationTime_FunctionAddress != IntPtr.Zero && GetSimulationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetSimulationTime", GetSimulationTime_IsValid);
		GetNumSubsteps_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumSubsteps");
		GetNumSubsteps_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSubsteps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSubsteps_ReturnValue_PropertyAddress, GetNumSubsteps_FunctionAddress, "ReturnValue");
		GetNumSubsteps_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSubsteps_FunctionAddress, "ReturnValue");
		GetNumSubsteps_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSubsteps_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSubsteps_IsValid = GetNumSubsteps_FunctionAddress != IntPtr.Zero && GetNumSubsteps_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumSubsteps", GetNumSubsteps_IsValid);
		GetNumKinematicParticles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumKinematicParticles");
		GetNumKinematicParticles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumKinematicParticles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumKinematicParticles_ReturnValue_PropertyAddress, GetNumKinematicParticles_FunctionAddress, "ReturnValue");
		GetNumKinematicParticles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumKinematicParticles_FunctionAddress, "ReturnValue");
		GetNumKinematicParticles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumKinematicParticles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumKinematicParticles_IsValid = GetNumKinematicParticles_FunctionAddress != IntPtr.Zero && GetNumKinematicParticles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumKinematicParticles", GetNumKinematicParticles_IsValid);
		GetNumIterations_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumIterations");
		GetNumIterations_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumIterations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumIterations_ReturnValue_PropertyAddress, GetNumIterations_FunctionAddress, "ReturnValue");
		GetNumIterations_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumIterations_FunctionAddress, "ReturnValue");
		GetNumIterations_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumIterations_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumIterations_IsValid = GetNumIterations_FunctionAddress != IntPtr.Zero && GetNumIterations_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumIterations", GetNumIterations_IsValid);
		GetNumDynamicParticles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumDynamicParticles");
		GetNumDynamicParticles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumDynamicParticles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumDynamicParticles_ReturnValue_PropertyAddress, GetNumDynamicParticles_FunctionAddress, "ReturnValue");
		GetNumDynamicParticles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumDynamicParticles_FunctionAddress, "ReturnValue");
		GetNumDynamicParticles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumDynamicParticles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumDynamicParticles_IsValid = GetNumDynamicParticles_FunctionAddress != IntPtr.Zero && GetNumDynamicParticles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumDynamicParticles", GetNumDynamicParticles_IsValid);
		GetNumCloths_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumCloths");
		GetNumCloths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumCloths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumCloths_ReturnValue_PropertyAddress, GetNumCloths_FunctionAddress, "ReturnValue");
		GetNumCloths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumCloths_FunctionAddress, "ReturnValue");
		GetNumCloths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumCloths_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumCloths_IsValid = GetNumCloths_FunctionAddress != IntPtr.Zero && GetNumCloths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetNumCloths", GetNumCloths_IsValid);
		GetClothingInteractor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetClothingInteractor");
		GetClothingInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClothingInteractor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClothingInteractor_ClothingAssetName_PropertyAddress, GetClothingInteractor_FunctionAddress, "ClothingAssetName");
		GetClothingInteractor_ClothingAssetName_Offset = NativeReflectionCached.GetPropertyOffset(GetClothingInteractor_FunctionAddress, "ClothingAssetName");
		GetClothingInteractor_ClothingAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClothingInteractor_FunctionAddress, "ClothingAssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClothingInteractor_ReturnValue_PropertyAddress, GetClothingInteractor_FunctionAddress, "ReturnValue");
		GetClothingInteractor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClothingInteractor_FunctionAddress, "ReturnValue");
		GetClothingInteractor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClothingInteractor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetClothingInteractor_IsValid = GetClothingInteractor_FunctionAddress != IntPtr.Zero && GetClothingInteractor_ClothingAssetName_IsValid && GetClothingInteractor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:GetClothingInteractor", GetClothingInteractor_IsValid);
		EnableGravityOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableGravityOverride");
		EnableGravityOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableGravityOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableGravityOverride_InVector_PropertyAddress, EnableGravityOverride_FunctionAddress, "InVector");
		EnableGravityOverride_InVector_Offset = NativeReflectionCached.GetPropertyOffset(EnableGravityOverride_FunctionAddress, "InVector");
		EnableGravityOverride_InVector_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableGravityOverride_FunctionAddress, "InVector", Classes.FStructProperty);
		EnableGravityOverride_IsValid = EnableGravityOverride_FunctionAddress != IntPtr.Zero && EnableGravityOverride_InVector_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:EnableGravityOverride", EnableGravityOverride_IsValid);
		DisableGravityOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisableGravityOverride");
		DisableGravityOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableGravityOverride_FunctionAddress);
		DisableGravityOverride_IsValid = DisableGravityOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:DisableGravityOverride", DisableGravityOverride_IsValid);
		ClothConfigUpdated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClothConfigUpdated");
		ClothConfigUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(ClothConfigUpdated_FunctionAddress);
		ClothConfigUpdated_IsValid = ClothConfigUpdated_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeInterface.ClothingSimulationInteractor:ClothConfigUpdated", ClothConfigUpdated_IsValid);
	}
}
