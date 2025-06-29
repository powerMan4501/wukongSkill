using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUEQSObject", "b1", UnrealModuleType.Game)]
public class UBGUEQSObject : UObject
{
	private static bool FBUE_RunEQSFinish_IsValid;

	private static int FBUE_RunEQSFinish_Offset;

	private FBUE_RunEQSFinish FBUE_RunEQSFinish_DelegateCached;

	private static bool EQSRun_IsValid;

	private static IntPtr EQSRun_FunctionAddress;

	private static int EQSRun_ParamsSize;

	private static bool EQSRun_EQSPath_IsValid;

	private static FFieldAddress EQSRun_EQSPath_PropertyAddress;

	private static int EQSRun_EQSPath_Offset;

	private static bool EQSRun_Querier_IsValid;

	private static FFieldAddress EQSRun_Querier_PropertyAddress;

	private static int EQSRun_Querier_Offset;

	private static bool EQSRun_Reason_IsValid;

	private static FFieldAddress EQSRun_Reason_PropertyAddress;

	private static int EQSRun_Reason_Offset;

	private static bool EQSRun__ExParam_IsValid;

	private static FFieldAddress EQSRun__ExParam_PropertyAddress;

	private static int EQSRun__ExParam_Offset;

	private static bool EQSRun_ReturnValue_IsValid;

	private static FFieldAddress EQSRun_ReturnValue_PropertyAddress;

	private static int EQSRun_ReturnValue_Offset;

	private static bool EQSObjRunWithCustomParams_IsValid;

	private static IntPtr EQSObjRunWithCustomParams_FunctionAddress;

	private static int EQSObjRunWithCustomParams_ParamsSize;

	private static bool EQSObjRunWithCustomParams_EnvQueryObj_IsValid;

	private static FFieldAddress EQSObjRunWithCustomParams_EnvQueryObj_PropertyAddress;

	private static int EQSObjRunWithCustomParams_EnvQueryObj_Offset;

	private static bool EQSObjRunWithCustomParams_Querier_IsValid;

	private static FFieldAddress EQSObjRunWithCustomParams_Querier_PropertyAddress;

	private static int EQSObjRunWithCustomParams_Querier_Offset;

	private static bool EQSObjRunWithCustomParams_Reason_IsValid;

	private static FFieldAddress EQSObjRunWithCustomParams_Reason_PropertyAddress;

	private static int EQSObjRunWithCustomParams_Reason_Offset;

	private static bool EQSObjRunWithCustomParams_NamedParams_IsValid;

	private static FFieldAddress EQSObjRunWithCustomParams_NamedParams_PropertyAddress;

	private static int EQSObjRunWithCustomParams_NamedParams_Offset;

	private static bool EQSObjRunWithCustomParams_ReturnValue_IsValid;

	private static FFieldAddress EQSObjRunWithCustomParams_ReturnValue_PropertyAddress;

	private static int EQSObjRunWithCustomParams_ReturnValue_Offset;

	private static bool EQSObjRunInstantWithCustomParams_IsValid;

	private static IntPtr EQSObjRunInstantWithCustomParams_FunctionAddress;

	private static int EQSObjRunInstantWithCustomParams_ParamsSize;

	private static bool EQSObjRunInstantWithCustomParams_EnvQueryObj_IsValid;

	private static FFieldAddress EQSObjRunInstantWithCustomParams_EnvQueryObj_PropertyAddress;

	private static int EQSObjRunInstantWithCustomParams_EnvQueryObj_Offset;

	private static bool EQSObjRunInstantWithCustomParams_Querier_IsValid;

	private static FFieldAddress EQSObjRunInstantWithCustomParams_Querier_PropertyAddress;

	private static int EQSObjRunInstantWithCustomParams_Querier_Offset;

	private static bool EQSObjRunInstantWithCustomParams_NamedParams_IsValid;

	private static FFieldAddress EQSObjRunInstantWithCustomParams_NamedParams_PropertyAddress;

	private static int EQSObjRunInstantWithCustomParams_NamedParams_Offset;

	private static bool EQSObjRunInstantWithCustomParams_Locations_IsValid;

	private static FFieldAddress EQSObjRunInstantWithCustomParams_Locations_PropertyAddress;

	private static int EQSObjRunInstantWithCustomParams_Locations_Offset;

	private static bool EQSObjRunInstantWithCustomParams_Scores_IsValid;

	private static FFieldAddress EQSObjRunInstantWithCustomParams_Scores_PropertyAddress;

	private static int EQSObjRunInstantWithCustomParams_Scores_Offset;

	private static bool EQSObjRunInstant_IsValid;

	private static IntPtr EQSObjRunInstant_FunctionAddress;

	private static int EQSObjRunInstant_ParamsSize;

	private static bool EQSObjRunInstant_EnvQueryObj_IsValid;

	private static FFieldAddress EQSObjRunInstant_EnvQueryObj_PropertyAddress;

	private static int EQSObjRunInstant_EnvQueryObj_Offset;

	private static bool EQSObjRunInstant_Querier_IsValid;

	private static FFieldAddress EQSObjRunInstant_Querier_PropertyAddress;

	private static int EQSObjRunInstant_Querier_Offset;

	private static bool EQSObjRunInstant_Locations_IsValid;

	private static FFieldAddress EQSObjRunInstant_Locations_PropertyAddress;

	private static int EQSObjRunInstant_Locations_Offset;

	private static bool EQSObjRunInstant_Scores_IsValid;

	private static FFieldAddress EQSObjRunInstant_Scores_PropertyAddress;

	private static int EQSObjRunInstant_Scores_Offset;

	private static bool EQSObjRun_IsValid;

	private static IntPtr EQSObjRun_FunctionAddress;

	private static int EQSObjRun_ParamsSize;

	private static bool EQSObjRun_EnvQueryObj_IsValid;

	private static FFieldAddress EQSObjRun_EnvQueryObj_PropertyAddress;

	private static int EQSObjRun_EnvQueryObj_Offset;

	private static bool EQSObjRun_Querier_IsValid;

	private static FFieldAddress EQSObjRun_Querier_PropertyAddress;

	private static int EQSObjRun_Querier_Offset;

	private static bool EQSObjRun_Reason_IsValid;

	private static FFieldAddress EQSObjRun_Reason_PropertyAddress;

	private static int EQSObjRun_Reason_Offset;

	private static bool EQSObjRun__ExParam_IsValid;

	private static FFieldAddress EQSObjRun__ExParam_PropertyAddress;

	private static int EQSObjRun__ExParam_Offset;

	private static bool EQSObjRun_ReturnValue_IsValid;

	private static FFieldAddress EQSObjRun_ReturnValue_PropertyAddress;

	private static int EQSObjRun_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUEQSObject:FBUE_RunEQSFinish")]
	public FBUE_RunEQSFinish FBUE_RunEQSFinish
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_RunEQSFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUEQSObject:FBUE_RunEQSFinish");
				return new FBUE_RunEQSFinish();
			}
			if (FBUE_RunEQSFinish_DelegateCached == null)
			{
				FBUE_RunEQSFinish_DelegateCached = new FBUE_RunEQSFinish();
				FBUE_RunEQSFinish_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_RunEQSFinish_Offset));
			}
			return FBUE_RunEQSFinish_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUEQSObject:EQSRun")]
	public unsafe int EQSRun(string EQSPath, AActor Querier, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam)
	{
		CheckDestroyed();
		if (!EQSRun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEQSObject:EQSRun");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EQSRun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSRun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EQSRun_EQSPath_Offset), 0, EQSRun_EQSPath_PropertyAddress.Address, EQSPath);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EQSRun_Querier_Offset), 0, EQSRun_Querier_PropertyAddress.Address, Querier);
		EnumMarshaler<EBGURunEQSObjReason>.ToNative(IntPtr.Add(intPtr, EQSRun_Reason_Offset), 0, EQSRun_Reason_PropertyAddress.Address, Reason);
		NativeReflection.InitializeValue_InContainer(EQSRun__ExParam_PropertyAddress.Address, intPtr);
		FGSEQSExParam.ToNative(IntPtr.Add(intPtr, EQSRun__ExParam_Offset), 0, EQSRun__ExParam_PropertyAddress.Address, _ExParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, EQSRun_FunctionAddress, intPtr, EQSRun_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EQSRun_EQSPath_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, EQSRun_ReturnValue_Offset), 0, EQSRun_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGUEQSObject:EQSObjRunWithCustomParams")]
	public unsafe int EQSObjRunWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, List<FGSEnvNamedValue> NamedParams)
	{
		CheckDestroyed();
		if (!EQSObjRunWithCustomParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEQSObject:EQSObjRunWithCustomParams");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EQSObjRunWithCustomParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSObjRunWithCustomParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(intPtr, EQSObjRunWithCustomParams_EnvQueryObj_Offset), 0, EQSObjRunWithCustomParams_EnvQueryObj_PropertyAddress.Address, EnvQueryObj);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EQSObjRunWithCustomParams_Querier_Offset), 0, EQSObjRunWithCustomParams_Querier_PropertyAddress.Address, Querier);
		EnumMarshaler<EBGURunEQSObjReason>.ToNative(IntPtr.Add(intPtr, EQSObjRunWithCustomParams_Reason_Offset), 0, EQSObjRunWithCustomParams_Reason_PropertyAddress.Address, Reason);
		new TArrayCopyMarshaler<FGSEnvNamedValue>(1, EQSObjRunWithCustomParams_NamedParams_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative).ToNative(IntPtr.Add(intPtr, EQSObjRunWithCustomParams_NamedParams_Offset), NamedParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, EQSObjRunWithCustomParams_FunctionAddress, intPtr, EQSObjRunWithCustomParams_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EQSObjRunWithCustomParams_NamedParams_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, EQSObjRunWithCustomParams_ReturnValue_Offset), 0, EQSObjRunWithCustomParams_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGUEQSObject:EQSObjRunInstantWithCustomParams")]
	public unsafe void EQSObjRunInstantWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, List<FGSEnvNamedValue> NamedParams, out List<FVector> Locations, out List<float> Scores)
	{
		CheckDestroyed();
		if (!EQSObjRunInstantWithCustomParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEQSObject:EQSObjRunInstantWithCustomParams");
			Locations = null;
			Scores = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EQSObjRunInstantWithCustomParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSObjRunInstantWithCustomParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(intPtr, EQSObjRunInstantWithCustomParams_EnvQueryObj_Offset), 0, EQSObjRunInstantWithCustomParams_EnvQueryObj_PropertyAddress.Address, EnvQueryObj);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EQSObjRunInstantWithCustomParams_Querier_Offset), 0, EQSObjRunInstantWithCustomParams_Querier_PropertyAddress.Address, Querier);
		new TArrayCopyMarshaler<FGSEnvNamedValue>(1, EQSObjRunInstantWithCustomParams_NamedParams_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative).ToNative(IntPtr.Add(intPtr, EQSObjRunInstantWithCustomParams_NamedParams_Offset), NamedParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, EQSObjRunInstantWithCustomParams_FunctionAddress, intPtr, EQSObjRunInstantWithCustomParams_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EQSObjRunInstantWithCustomParams_NamedParams_PropertyAddress.Address, intPtr);
		Locations = new TArrayCopyMarshaler<FVector>(1, EQSObjRunInstantWithCustomParams_Locations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, EQSObjRunInstantWithCustomParams_Locations_Offset));
		NativeReflection.DestroyValue_InContainer(EQSObjRunInstantWithCustomParams_Locations_PropertyAddress.Address, intPtr);
		Scores = new TArrayCopyMarshaler<float>(1, EQSObjRunInstantWithCustomParams_Scores_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, EQSObjRunInstantWithCustomParams_Scores_Offset));
		NativeReflection.DestroyValue_InContainer(EQSObjRunInstantWithCustomParams_Scores_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGUEQSObject:EQSObjRunInstant")]
	public unsafe void EQSObjRunInstant(UEnvQuery EnvQueryObj, AActor Querier, out List<FVector> Locations, out List<float> Scores)
	{
		CheckDestroyed();
		if (!EQSObjRunInstant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEQSObject:EQSObjRunInstant");
			Locations = null;
			Scores = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EQSObjRunInstant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSObjRunInstant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(intPtr, EQSObjRunInstant_EnvQueryObj_Offset), 0, EQSObjRunInstant_EnvQueryObj_PropertyAddress.Address, EnvQueryObj);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EQSObjRunInstant_Querier_Offset), 0, EQSObjRunInstant_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeFunctionOptimized(base.Address, EQSObjRunInstant_FunctionAddress, intPtr, EQSObjRunInstant_ParamsSize);
		Locations = new TArrayCopyMarshaler<FVector>(1, EQSObjRunInstant_Locations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, EQSObjRunInstant_Locations_Offset));
		NativeReflection.DestroyValue_InContainer(EQSObjRunInstant_Locations_PropertyAddress.Address, intPtr);
		Scores = new TArrayCopyMarshaler<float>(1, EQSObjRunInstant_Scores_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, EQSObjRunInstant_Scores_Offset));
		NativeReflection.DestroyValue_InContainer(EQSObjRunInstant_Scores_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUEQSObject:EQSObjRun")]
	public unsafe int EQSObjRun(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam)
	{
		CheckDestroyed();
		if (!EQSObjRun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEQSObject:EQSObjRun");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EQSObjRun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSObjRun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(intPtr, EQSObjRun_EnvQueryObj_Offset), 0, EQSObjRun_EnvQueryObj_PropertyAddress.Address, EnvQueryObj);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EQSObjRun_Querier_Offset), 0, EQSObjRun_Querier_PropertyAddress.Address, Querier);
		EnumMarshaler<EBGURunEQSObjReason>.ToNative(IntPtr.Add(intPtr, EQSObjRun_Reason_Offset), 0, EQSObjRun_Reason_PropertyAddress.Address, Reason);
		NativeReflection.InitializeValue_InContainer(EQSObjRun__ExParam_PropertyAddress.Address, intPtr);
		FGSEQSExParam.ToNative(IntPtr.Add(intPtr, EQSObjRun__ExParam_Offset), 0, EQSObjRun__ExParam_PropertyAddress.Address, _ExParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, EQSObjRun_FunctionAddress, intPtr, EQSObjRun_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, EQSObjRun_ReturnValue_Offset), 0, EQSObjRun_ReturnValue_PropertyAddress.Address);
	}

	static UBGUEQSObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUEQSObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUEQSObject));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUEQSObject");
		FBUE_RunEQSFinish_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FBUE_RunEQSFinish");
		FBUE_RunEQSFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FBUE_RunEQSFinish", Classes.FMulticastDelegateProperty);
		EQSRun_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EQSRun");
		EQSRun_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSRun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EQSRun_EQSPath_PropertyAddress, EQSRun_FunctionAddress, "EQSPath");
		EQSRun_EQSPath_Offset = NativeReflectionCached.GetPropertyOffset(EQSRun_FunctionAddress, "EQSPath");
		EQSRun_EQSPath_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSRun_FunctionAddress, "EQSPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSRun_Querier_PropertyAddress, EQSRun_FunctionAddress, "Querier");
		EQSRun_Querier_Offset = NativeReflectionCached.GetPropertyOffset(EQSRun_FunctionAddress, "Querier");
		EQSRun_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSRun_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSRun_Reason_PropertyAddress, EQSRun_FunctionAddress, "Reason");
		EQSRun_Reason_Offset = NativeReflectionCached.GetPropertyOffset(EQSRun_FunctionAddress, "Reason");
		EQSRun_Reason_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSRun_FunctionAddress, "Reason", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSRun__ExParam_PropertyAddress, EQSRun_FunctionAddress, "_ExParam");
		EQSRun__ExParam_Offset = NativeReflectionCached.GetPropertyOffset(EQSRun_FunctionAddress, "_ExParam");
		EQSRun__ExParam_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSRun_FunctionAddress, "_ExParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSRun_ReturnValue_PropertyAddress, EQSRun_FunctionAddress, "ReturnValue");
		EQSRun_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EQSRun_FunctionAddress, "ReturnValue");
		EQSRun_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSRun_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		EQSRun_IsValid = EQSRun_FunctionAddress != IntPtr.Zero && EQSRun_EQSPath_IsValid && EQSRun_Querier_IsValid && EQSRun_Reason_IsValid && EQSRun__ExParam_IsValid && EQSRun_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEQSObject:EQSRun", EQSRun_IsValid);
		EQSObjRunWithCustomParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EQSObjRunWithCustomParams");
		EQSObjRunWithCustomParams_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSObjRunWithCustomParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunWithCustomParams_EnvQueryObj_PropertyAddress, EQSObjRunWithCustomParams_FunctionAddress, "EnvQueryObj");
		EQSObjRunWithCustomParams_EnvQueryObj_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunWithCustomParams_FunctionAddress, "EnvQueryObj");
		EQSObjRunWithCustomParams_EnvQueryObj_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunWithCustomParams_FunctionAddress, "EnvQueryObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunWithCustomParams_Querier_PropertyAddress, EQSObjRunWithCustomParams_FunctionAddress, "Querier");
		EQSObjRunWithCustomParams_Querier_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunWithCustomParams_FunctionAddress, "Querier");
		EQSObjRunWithCustomParams_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunWithCustomParams_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunWithCustomParams_Reason_PropertyAddress, EQSObjRunWithCustomParams_FunctionAddress, "Reason");
		EQSObjRunWithCustomParams_Reason_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunWithCustomParams_FunctionAddress, "Reason");
		EQSObjRunWithCustomParams_Reason_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunWithCustomParams_FunctionAddress, "Reason", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunWithCustomParams_NamedParams_PropertyAddress, EQSObjRunWithCustomParams_FunctionAddress, "NamedParams");
		EQSObjRunWithCustomParams_NamedParams_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunWithCustomParams_FunctionAddress, "NamedParams");
		EQSObjRunWithCustomParams_NamedParams_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunWithCustomParams_FunctionAddress, "NamedParams", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunWithCustomParams_ReturnValue_PropertyAddress, EQSObjRunWithCustomParams_FunctionAddress, "ReturnValue");
		EQSObjRunWithCustomParams_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunWithCustomParams_FunctionAddress, "ReturnValue");
		EQSObjRunWithCustomParams_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunWithCustomParams_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		EQSObjRunWithCustomParams_IsValid = EQSObjRunWithCustomParams_FunctionAddress != IntPtr.Zero && EQSObjRunWithCustomParams_EnvQueryObj_IsValid && EQSObjRunWithCustomParams_Querier_IsValid && EQSObjRunWithCustomParams_Reason_IsValid && EQSObjRunWithCustomParams_NamedParams_IsValid && EQSObjRunWithCustomParams_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEQSObject:EQSObjRunWithCustomParams", EQSObjRunWithCustomParams_IsValid);
		EQSObjRunInstantWithCustomParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EQSObjRunInstantWithCustomParams");
		EQSObjRunInstantWithCustomParams_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSObjRunInstantWithCustomParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstantWithCustomParams_EnvQueryObj_PropertyAddress, EQSObjRunInstantWithCustomParams_FunctionAddress, "EnvQueryObj");
		EQSObjRunInstantWithCustomParams_EnvQueryObj_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstantWithCustomParams_FunctionAddress, "EnvQueryObj");
		EQSObjRunInstantWithCustomParams_EnvQueryObj_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstantWithCustomParams_FunctionAddress, "EnvQueryObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstantWithCustomParams_Querier_PropertyAddress, EQSObjRunInstantWithCustomParams_FunctionAddress, "Querier");
		EQSObjRunInstantWithCustomParams_Querier_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstantWithCustomParams_FunctionAddress, "Querier");
		EQSObjRunInstantWithCustomParams_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstantWithCustomParams_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstantWithCustomParams_NamedParams_PropertyAddress, EQSObjRunInstantWithCustomParams_FunctionAddress, "NamedParams");
		EQSObjRunInstantWithCustomParams_NamedParams_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstantWithCustomParams_FunctionAddress, "NamedParams");
		EQSObjRunInstantWithCustomParams_NamedParams_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstantWithCustomParams_FunctionAddress, "NamedParams", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstantWithCustomParams_Locations_PropertyAddress, EQSObjRunInstantWithCustomParams_FunctionAddress, "Locations");
		EQSObjRunInstantWithCustomParams_Locations_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstantWithCustomParams_FunctionAddress, "Locations");
		EQSObjRunInstantWithCustomParams_Locations_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstantWithCustomParams_FunctionAddress, "Locations", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstantWithCustomParams_Scores_PropertyAddress, EQSObjRunInstantWithCustomParams_FunctionAddress, "Scores");
		EQSObjRunInstantWithCustomParams_Scores_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstantWithCustomParams_FunctionAddress, "Scores");
		EQSObjRunInstantWithCustomParams_Scores_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstantWithCustomParams_FunctionAddress, "Scores", Classes.FArrayProperty);
		EQSObjRunInstantWithCustomParams_IsValid = EQSObjRunInstantWithCustomParams_FunctionAddress != IntPtr.Zero && EQSObjRunInstantWithCustomParams_EnvQueryObj_IsValid && EQSObjRunInstantWithCustomParams_Querier_IsValid && EQSObjRunInstantWithCustomParams_NamedParams_IsValid && EQSObjRunInstantWithCustomParams_Locations_IsValid && EQSObjRunInstantWithCustomParams_Scores_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEQSObject:EQSObjRunInstantWithCustomParams", EQSObjRunInstantWithCustomParams_IsValid);
		EQSObjRunInstant_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EQSObjRunInstant");
		EQSObjRunInstant_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSObjRunInstant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstant_EnvQueryObj_PropertyAddress, EQSObjRunInstant_FunctionAddress, "EnvQueryObj");
		EQSObjRunInstant_EnvQueryObj_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstant_FunctionAddress, "EnvQueryObj");
		EQSObjRunInstant_EnvQueryObj_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstant_FunctionAddress, "EnvQueryObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstant_Querier_PropertyAddress, EQSObjRunInstant_FunctionAddress, "Querier");
		EQSObjRunInstant_Querier_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstant_FunctionAddress, "Querier");
		EQSObjRunInstant_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstant_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstant_Locations_PropertyAddress, EQSObjRunInstant_FunctionAddress, "Locations");
		EQSObjRunInstant_Locations_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstant_FunctionAddress, "Locations");
		EQSObjRunInstant_Locations_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstant_FunctionAddress, "Locations", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRunInstant_Scores_PropertyAddress, EQSObjRunInstant_FunctionAddress, "Scores");
		EQSObjRunInstant_Scores_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRunInstant_FunctionAddress, "Scores");
		EQSObjRunInstant_Scores_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRunInstant_FunctionAddress, "Scores", Classes.FArrayProperty);
		EQSObjRunInstant_IsValid = EQSObjRunInstant_FunctionAddress != IntPtr.Zero && EQSObjRunInstant_EnvQueryObj_IsValid && EQSObjRunInstant_Querier_IsValid && EQSObjRunInstant_Locations_IsValid && EQSObjRunInstant_Scores_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEQSObject:EQSObjRunInstant", EQSObjRunInstant_IsValid);
		EQSObjRun_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EQSObjRun");
		EQSObjRun_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSObjRun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRun_EnvQueryObj_PropertyAddress, EQSObjRun_FunctionAddress, "EnvQueryObj");
		EQSObjRun_EnvQueryObj_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRun_FunctionAddress, "EnvQueryObj");
		EQSObjRun_EnvQueryObj_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRun_FunctionAddress, "EnvQueryObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRun_Querier_PropertyAddress, EQSObjRun_FunctionAddress, "Querier");
		EQSObjRun_Querier_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRun_FunctionAddress, "Querier");
		EQSObjRun_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRun_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRun_Reason_PropertyAddress, EQSObjRun_FunctionAddress, "Reason");
		EQSObjRun_Reason_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRun_FunctionAddress, "Reason");
		EQSObjRun_Reason_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRun_FunctionAddress, "Reason", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRun__ExParam_PropertyAddress, EQSObjRun_FunctionAddress, "_ExParam");
		EQSObjRun__ExParam_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRun_FunctionAddress, "_ExParam");
		EQSObjRun__ExParam_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRun_FunctionAddress, "_ExParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EQSObjRun_ReturnValue_PropertyAddress, EQSObjRun_FunctionAddress, "ReturnValue");
		EQSObjRun_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EQSObjRun_FunctionAddress, "ReturnValue");
		EQSObjRun_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSObjRun_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		EQSObjRun_IsValid = EQSObjRun_FunctionAddress != IntPtr.Zero && EQSObjRun_EnvQueryObj_IsValid && EQSObjRun_Querier_IsValid && EQSObjRun_Reason_IsValid && EQSObjRun__ExParam_IsValid && EQSObjRun_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEQSObject:EQSObjRun", EQSObjRun_IsValid);
	}
}
