using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810029217uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.EnvQueryContext_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UEnvQueryContext_BlueprintBase : UEnvQueryContext
{
	private static bool ProvideSingleLocation_IsValid;

	private IntPtr ProvideSingleLocation_InstanceFunctionAddress;

	private static IntPtr ProvideSingleLocation_FunctionAddress;

	private static int ProvideSingleLocation_ParamsSize;

	private static bool ProvideSingleLocation_QuerierObject_IsValid;

	private static FFieldAddress ProvideSingleLocation_QuerierObject_PropertyAddress;

	private static int ProvideSingleLocation_QuerierObject_Offset;

	private static bool ProvideSingleLocation_QuerierActor_IsValid;

	private static FFieldAddress ProvideSingleLocation_QuerierActor_PropertyAddress;

	private static int ProvideSingleLocation_QuerierActor_Offset;

	private static bool ProvideSingleLocation_ResultingLocation_IsValid;

	private static FFieldAddress ProvideSingleLocation_ResultingLocation_PropertyAddress;

	private static int ProvideSingleLocation_ResultingLocation_Offset;

	private static bool ProvideSingleActor_IsValid;

	private IntPtr ProvideSingleActor_InstanceFunctionAddress;

	private static IntPtr ProvideSingleActor_FunctionAddress;

	private static int ProvideSingleActor_ParamsSize;

	private static bool ProvideSingleActor_QuerierObject_IsValid;

	private static FFieldAddress ProvideSingleActor_QuerierObject_PropertyAddress;

	private static int ProvideSingleActor_QuerierObject_Offset;

	private static bool ProvideSingleActor_QuerierActor_IsValid;

	private static FFieldAddress ProvideSingleActor_QuerierActor_PropertyAddress;

	private static int ProvideSingleActor_QuerierActor_Offset;

	private static bool ProvideSingleActor_ResultingActor_IsValid;

	private static FFieldAddress ProvideSingleActor_ResultingActor_PropertyAddress;

	private static int ProvideSingleActor_ResultingActor_Offset;

	private static bool ProvideLocationsSet_IsValid;

	private IntPtr ProvideLocationsSet_InstanceFunctionAddress;

	private static IntPtr ProvideLocationsSet_FunctionAddress;

	private static int ProvideLocationsSet_ParamsSize;

	private static bool ProvideLocationsSet_QuerierObject_IsValid;

	private static FFieldAddress ProvideLocationsSet_QuerierObject_PropertyAddress;

	private static int ProvideLocationsSet_QuerierObject_Offset;

	private static bool ProvideLocationsSet_QuerierActor_IsValid;

	private static FFieldAddress ProvideLocationsSet_QuerierActor_PropertyAddress;

	private static int ProvideLocationsSet_QuerierActor_Offset;

	private static bool ProvideLocationsSet_ResultingLocationSet_IsValid;

	private static FFieldAddress ProvideLocationsSet_ResultingLocationSet_PropertyAddress;

	private static int ProvideLocationsSet_ResultingLocationSet_Offset;

	private static bool ProvideActorsSet_IsValid;

	private IntPtr ProvideActorsSet_InstanceFunctionAddress;

	private static IntPtr ProvideActorsSet_FunctionAddress;

	private static int ProvideActorsSet_ParamsSize;

	private static bool ProvideActorsSet_QuerierObject_IsValid;

	private static FFieldAddress ProvideActorsSet_QuerierObject_PropertyAddress;

	private static int ProvideActorsSet_QuerierObject_Offset;

	private static bool ProvideActorsSet_QuerierActor_IsValid;

	private static FFieldAddress ProvideActorsSet_QuerierActor_PropertyAddress;

	private static int ProvideActorsSet_QuerierActor_Offset;

	private static bool ProvideActorsSet_ResultingActorsSet_IsValid;

	private static FFieldAddress ProvideActorsSet_ResultingActorsSet_PropertyAddress;

	private static int ProvideActorsSet_ResultingActorsSet_Offset;

	[UFunction(Flags = 1220675584u)]
	[UMetaPath("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleLocation")]
	public unsafe void ProvideSingleLocation(UObject QuerierObject, AActor QuerierActor, out FVector ResultingLocation)
	{
		CheckDestroyed();
		if (!ProvideSingleLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleLocation");
			ResultingLocation = default(FVector);
			return;
		}
		if (ProvideSingleLocation_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideSingleLocation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideSingleLocation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocation_QuerierObject_Offset), 0, ProvideSingleLocation_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocation_QuerierActor_Offset), 0, ProvideSingleLocation_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleLocation_InstanceFunctionAddress, intPtr, ProvideSingleLocation_ParamsSize);
		ResultingLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ProvideSingleLocation_ResultingLocation_Offset), 0, ProvideSingleLocation_ResultingLocation_PropertyAddress.Address);
	}

	protected unsafe virtual void ProvideSingleLocation_Implementation(UObject QuerierObject, AActor QuerierActor, out FVector ResultingLocation)
	{
		CheckDestroyed();
		if (!ProvideSingleLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleLocation");
			ResultingLocation = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocation_QuerierObject_Offset), 0, ProvideSingleLocation_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocation_QuerierActor_Offset), 0, ProvideSingleLocation_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleLocation_FunctionAddress, intPtr, ProvideSingleLocation_ParamsSize);
		ResultingLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ProvideSingleLocation_ResultingLocation_Offset), 0, ProvideSingleLocation_ResultingLocation_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleActor")]
	public unsafe void ProvideSingleActor(UObject QuerierObject, AActor QuerierActor, out AActor ResultingActor)
	{
		CheckDestroyed();
		if (!ProvideSingleActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleActor");
			ResultingActor = null;
			return;
		}
		if (ProvideSingleActor_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideSingleActor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideSingleActor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleActor_QuerierObject_Offset), 0, ProvideSingleActor_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleActor_QuerierActor_Offset), 0, ProvideSingleActor_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleActor_InstanceFunctionAddress, intPtr, ProvideSingleActor_ParamsSize);
		ResultingActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ProvideSingleActor_ResultingActor_Offset), 0, ProvideSingleActor_ResultingActor_PropertyAddress.Address);
	}

	protected unsafe virtual void ProvideSingleActor_Implementation(UObject QuerierObject, AActor QuerierActor, out AActor ResultingActor)
	{
		CheckDestroyed();
		if (!ProvideSingleActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleActor");
			ResultingActor = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleActor_QuerierObject_Offset), 0, ProvideSingleActor_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleActor_QuerierActor_Offset), 0, ProvideSingleActor_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleActor_FunctionAddress, intPtr, ProvideSingleActor_ParamsSize);
		ResultingActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ProvideSingleActor_ResultingActor_Offset), 0, ProvideSingleActor_ResultingActor_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideLocationsSet")]
	public unsafe void ProvideLocationsSet(UObject QuerierObject, AActor QuerierActor, out List<FVector> ResultingLocationSet)
	{
		CheckDestroyed();
		if (!ProvideLocationsSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideLocationsSet");
			ResultingLocationSet = null;
			return;
		}
		if (ProvideLocationsSet_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideLocationsSet_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideLocationsSet");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideLocationsSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideLocationsSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSet_QuerierObject_Offset), 0, ProvideLocationsSet_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSet_QuerierActor_Offset), 0, ProvideLocationsSet_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideLocationsSet_InstanceFunctionAddress, intPtr, ProvideLocationsSet_ParamsSize);
		ResultingLocationSet = new TArrayCopyMarshaler<FVector>(1, ProvideLocationsSet_ResultingLocationSet_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ProvideLocationsSet_ResultingLocationSet_Offset));
		NativeReflection.DestroyValue_InContainer(ProvideLocationsSet_ResultingLocationSet_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ProvideLocationsSet_Implementation(UObject QuerierObject, AActor QuerierActor, out List<FVector> ResultingLocationSet)
	{
		CheckDestroyed();
		if (!ProvideLocationsSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideLocationsSet");
			ResultingLocationSet = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideLocationsSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideLocationsSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSet_QuerierObject_Offset), 0, ProvideLocationsSet_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSet_QuerierActor_Offset), 0, ProvideLocationsSet_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideLocationsSet_FunctionAddress, intPtr, ProvideLocationsSet_ParamsSize);
		ResultingLocationSet = new TArrayCopyMarshaler<FVector>(1, ProvideLocationsSet_ResultingLocationSet_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ProvideLocationsSet_ResultingLocationSet_Offset));
		NativeReflection.DestroyValue_InContainer(ProvideLocationsSet_ResultingLocationSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideActorsSet")]
	public unsafe void ProvideActorsSet(UObject QuerierObject, AActor QuerierActor, out List<AActor> ResultingActorsSet)
	{
		CheckDestroyed();
		if (!ProvideActorsSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideActorsSet");
			ResultingActorsSet = null;
			return;
		}
		if (ProvideActorsSet_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideActorsSet_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideActorsSet");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideActorsSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideActorsSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideActorsSet_QuerierObject_Offset), 0, ProvideActorsSet_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideActorsSet_QuerierActor_Offset), 0, ProvideActorsSet_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideActorsSet_InstanceFunctionAddress, intPtr, ProvideActorsSet_ParamsSize);
		ResultingActorsSet = new TArrayCopyMarshaler<AActor>(1, ProvideActorsSet_ResultingActorsSet_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ProvideActorsSet_ResultingActorsSet_Offset));
		NativeReflection.DestroyValue_InContainer(ProvideActorsSet_ResultingActorsSet_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ProvideActorsSet_Implementation(UObject QuerierObject, AActor QuerierActor, out List<AActor> ResultingActorsSet)
	{
		CheckDestroyed();
		if (!ProvideActorsSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideActorsSet");
			ResultingActorsSet = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideActorsSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideActorsSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideActorsSet_QuerierObject_Offset), 0, ProvideActorsSet_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideActorsSet_QuerierActor_Offset), 0, ProvideActorsSet_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideActorsSet_FunctionAddress, intPtr, ProvideActorsSet_ParamsSize);
		ResultingActorsSet = new TArrayCopyMarshaler<AActor>(1, ProvideActorsSet_ResultingActorsSet_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ProvideActorsSet_ResultingActorsSet_Offset));
		NativeReflection.DestroyValue_InContainer(ProvideActorsSet_ResultingActorsSet_PropertyAddress.Address, intPtr);
	}

	static UEnvQueryContext_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEnvQueryContext_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEnvQueryContext_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.EnvQueryContext_BlueprintBase");
		ProvideSingleLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideSingleLocation");
		ProvideSingleLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleLocation_QuerierObject_PropertyAddress, ProvideSingleLocation_FunctionAddress, "QuerierObject");
		ProvideSingleLocation_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleLocation_FunctionAddress, "QuerierObject");
		ProvideSingleLocation_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleLocation_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleLocation_QuerierActor_PropertyAddress, ProvideSingleLocation_FunctionAddress, "QuerierActor");
		ProvideSingleLocation_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleLocation_FunctionAddress, "QuerierActor");
		ProvideSingleLocation_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleLocation_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleLocation_ResultingLocation_PropertyAddress, ProvideSingleLocation_FunctionAddress, "ResultingLocation");
		ProvideSingleLocation_ResultingLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleLocation_FunctionAddress, "ResultingLocation");
		ProvideSingleLocation_ResultingLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleLocation_FunctionAddress, "ResultingLocation", Classes.FStructProperty);
		ProvideSingleLocation_IsValid = ProvideSingleLocation_FunctionAddress != IntPtr.Zero && ProvideSingleLocation_QuerierObject_IsValid && ProvideSingleLocation_QuerierActor_IsValid && ProvideSingleLocation_ResultingLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleLocation", ProvideSingleLocation_IsValid);
		ProvideSingleActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideSingleActor");
		ProvideSingleActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleActor_QuerierObject_PropertyAddress, ProvideSingleActor_FunctionAddress, "QuerierObject");
		ProvideSingleActor_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleActor_FunctionAddress, "QuerierObject");
		ProvideSingleActor_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleActor_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleActor_QuerierActor_PropertyAddress, ProvideSingleActor_FunctionAddress, "QuerierActor");
		ProvideSingleActor_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleActor_FunctionAddress, "QuerierActor");
		ProvideSingleActor_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleActor_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleActor_ResultingActor_PropertyAddress, ProvideSingleActor_FunctionAddress, "ResultingActor");
		ProvideSingleActor_ResultingActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleActor_FunctionAddress, "ResultingActor");
		ProvideSingleActor_ResultingActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleActor_FunctionAddress, "ResultingActor", Classes.FObjectProperty);
		ProvideSingleActor_IsValid = ProvideSingleActor_FunctionAddress != IntPtr.Zero && ProvideSingleActor_QuerierObject_IsValid && ProvideSingleActor_QuerierActor_IsValid && ProvideSingleActor_ResultingActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideSingleActor", ProvideSingleActor_IsValid);
		ProvideLocationsSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideLocationsSet");
		ProvideLocationsSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideLocationsSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideLocationsSet_QuerierObject_PropertyAddress, ProvideLocationsSet_FunctionAddress, "QuerierObject");
		ProvideLocationsSet_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideLocationsSet_FunctionAddress, "QuerierObject");
		ProvideLocationsSet_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideLocationsSet_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideLocationsSet_QuerierActor_PropertyAddress, ProvideLocationsSet_FunctionAddress, "QuerierActor");
		ProvideLocationsSet_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideLocationsSet_FunctionAddress, "QuerierActor");
		ProvideLocationsSet_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideLocationsSet_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideLocationsSet_ResultingLocationSet_PropertyAddress, ProvideLocationsSet_FunctionAddress, "ResultingLocationSet");
		ProvideLocationsSet_ResultingLocationSet_Offset = NativeReflectionCached.GetPropertyOffset(ProvideLocationsSet_FunctionAddress, "ResultingLocationSet");
		ProvideLocationsSet_ResultingLocationSet_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideLocationsSet_FunctionAddress, "ResultingLocationSet", Classes.FArrayProperty);
		ProvideLocationsSet_IsValid = ProvideLocationsSet_FunctionAddress != IntPtr.Zero && ProvideLocationsSet_QuerierObject_IsValid && ProvideLocationsSet_QuerierActor_IsValid && ProvideLocationsSet_ResultingLocationSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideLocationsSet", ProvideLocationsSet_IsValid);
		ProvideActorsSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProvideActorsSet");
		ProvideActorsSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideActorsSet_QuerierObject_PropertyAddress, ProvideActorsSet_FunctionAddress, "QuerierObject");
		ProvideActorsSet_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideActorsSet_FunctionAddress, "QuerierObject");
		ProvideActorsSet_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideActorsSet_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideActorsSet_QuerierActor_PropertyAddress, ProvideActorsSet_FunctionAddress, "QuerierActor");
		ProvideActorsSet_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideActorsSet_FunctionAddress, "QuerierActor");
		ProvideActorsSet_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideActorsSet_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideActorsSet_ResultingActorsSet_PropertyAddress, ProvideActorsSet_FunctionAddress, "ResultingActorsSet");
		ProvideActorsSet_ResultingActorsSet_Offset = NativeReflectionCached.GetPropertyOffset(ProvideActorsSet_FunctionAddress, "ResultingActorsSet");
		ProvideActorsSet_ResultingActorsSet_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideActorsSet_FunctionAddress, "ResultingActorsSet", Classes.FArrayProperty);
		ProvideActorsSet_IsValid = ProvideActorsSet_FunctionAddress != IntPtr.Zero && ProvideActorsSet_QuerierObject_IsValid && ProvideActorsSet_QuerierActor_IsValid && ProvideActorsSet_ResultingActorsSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryContext_BlueprintBase:ProvideActorsSet", ProvideActorsSet_IsValid);
	}
}
