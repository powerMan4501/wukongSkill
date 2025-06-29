using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator
{
	private static bool GetQuerier_IsValid;

	private static IntPtr GetQuerier_FunctionAddress;

	private static int GetQuerier_ParamsSize;

	private static bool GetQuerier_ReturnValue_IsValid;

	private static FFieldAddress GetQuerier_ReturnValue_PropertyAddress;

	private static int GetQuerier_ReturnValue_Offset;

	private static bool DoItemGeneration_IsValid;

	private IntPtr DoItemGeneration_InstanceFunctionAddress;

	private static IntPtr DoItemGeneration_FunctionAddress;

	private static int DoItemGeneration_ParamsSize;

	private static bool DoItemGeneration_ContextLocations_IsValid;

	private static FFieldAddress DoItemGeneration_ContextLocations_PropertyAddress;

	private static int DoItemGeneration_ContextLocations_Offset;

	private static bool AddGeneratedVector_IsValid;

	private static IntPtr AddGeneratedVector_FunctionAddress;

	private static int AddGeneratedVector_ParamsSize;

	private static bool AddGeneratedVector_GeneratedVector_IsValid;

	private static FFieldAddress AddGeneratedVector_GeneratedVector_PropertyAddress;

	private static int AddGeneratedVector_GeneratedVector_Offset;

	private static bool AddGeneratedActor_IsValid;

	private static IntPtr AddGeneratedActor_FunctionAddress;

	private static int AddGeneratedActor_ParamsSize;

	private static bool AddGeneratedActor_GeneratedActor_IsValid;

	private static FFieldAddress AddGeneratedActor_GeneratedActor_PropertyAddress;

	private static int AddGeneratedActor_GeneratedActor_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase:GetQuerier")]
	public unsafe UObject GetQuerier()
	{
		CheckDestroyed();
		if (!GetQuerier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryGenerator_BlueprintBase:GetQuerier");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuerier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuerier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQuerier_FunctionAddress, intPtr, GetQuerier_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetQuerier_ReturnValue_Offset), 0, GetQuerier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase:DoItemGeneration")]
	public unsafe void DoItemGeneration(List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!DoItemGeneration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryGenerator_BlueprintBase:DoItemGeneration");
			return;
		}
		if (DoItemGeneration_InstanceFunctionAddress == IntPtr.Zero)
		{
			DoItemGeneration_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DoItemGeneration");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoItemGeneration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoItemGeneration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, DoItemGeneration_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DoItemGeneration_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoItemGeneration_InstanceFunctionAddress, intPtr, DoItemGeneration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoItemGeneration_ContextLocations_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void DoItemGeneration_Implementation(List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!DoItemGeneration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryGenerator_BlueprintBase:DoItemGeneration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoItemGeneration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoItemGeneration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, DoItemGeneration_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DoItemGeneration_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoItemGeneration_FunctionAddress, intPtr, DoItemGeneration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoItemGeneration_ContextLocations_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1149371393u)]
	[UMetaPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedVector")]
	public unsafe void AddGeneratedVector(FVector GeneratedVector)
	{
		CheckDestroyed();
		if (!AddGeneratedVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGeneratedVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGeneratedVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddGeneratedVector_GeneratedVector_Offset), 0, AddGeneratedVector_GeneratedVector_PropertyAddress.Address, GeneratedVector);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGeneratedVector_FunctionAddress, intPtr, AddGeneratedVector_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedActor")]
	public unsafe void AddGeneratedActor(AActor GeneratedActor)
	{
		CheckDestroyed();
		if (!AddGeneratedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGeneratedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGeneratedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddGeneratedActor_GeneratedActor_Offset), 0, AddGeneratedActor_GeneratedActor_PropertyAddress.Address, GeneratedActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGeneratedActor_FunctionAddress, intPtr, AddGeneratedActor_ParamsSize);
	}

	static UEnvQueryGenerator_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEnvQueryGenerator_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEnvQueryGenerator_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.EnvQueryGenerator_BlueprintBase");
		GetQuerier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetQuerier");
		GetQuerier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuerier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuerier_ReturnValue_PropertyAddress, GetQuerier_FunctionAddress, "ReturnValue");
		GetQuerier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuerier_FunctionAddress, "ReturnValue");
		GetQuerier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuerier_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetQuerier_IsValid = GetQuerier_FunctionAddress != IntPtr.Zero && GetQuerier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryGenerator_BlueprintBase:GetQuerier", GetQuerier_IsValid);
		DoItemGeneration_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoItemGeneration");
		DoItemGeneration_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGeneration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoItemGeneration_ContextLocations_PropertyAddress, DoItemGeneration_FunctionAddress, "ContextLocations");
		DoItemGeneration_ContextLocations_Offset = NativeReflectionCached.GetPropertyOffset(DoItemGeneration_FunctionAddress, "ContextLocations");
		DoItemGeneration_ContextLocations_IsValid = NativeReflectionCached.ValidatePropertyClass(DoItemGeneration_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGeneration_IsValid = DoItemGeneration_FunctionAddress != IntPtr.Zero && DoItemGeneration_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryGenerator_BlueprintBase:DoItemGeneration", DoItemGeneration_IsValid);
		AddGeneratedVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddGeneratedVector");
		AddGeneratedVector_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGeneratedVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGeneratedVector_GeneratedVector_PropertyAddress, AddGeneratedVector_FunctionAddress, "GeneratedVector");
		AddGeneratedVector_GeneratedVector_Offset = NativeReflectionCached.GetPropertyOffset(AddGeneratedVector_FunctionAddress, "GeneratedVector");
		AddGeneratedVector_GeneratedVector_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGeneratedVector_FunctionAddress, "GeneratedVector", Classes.FStructProperty);
		AddGeneratedVector_IsValid = AddGeneratedVector_FunctionAddress != IntPtr.Zero && AddGeneratedVector_GeneratedVector_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedVector", AddGeneratedVector_IsValid);
		AddGeneratedActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddGeneratedActor");
		AddGeneratedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGeneratedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGeneratedActor_GeneratedActor_PropertyAddress, AddGeneratedActor_FunctionAddress, "GeneratedActor");
		AddGeneratedActor_GeneratedActor_Offset = NativeReflectionCached.GetPropertyOffset(AddGeneratedActor_FunctionAddress, "GeneratedActor");
		AddGeneratedActor_GeneratedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGeneratedActor_FunctionAddress, "GeneratedActor", Classes.FObjectProperty);
		AddGeneratedActor_IsValid = AddGeneratedActor_FunctionAddress != IntPtr.Zero && AddGeneratedActor_GeneratedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryGenerator_BlueprintBase:AddGeneratedActor", AddGeneratedActor_IsValid);
	}
}
