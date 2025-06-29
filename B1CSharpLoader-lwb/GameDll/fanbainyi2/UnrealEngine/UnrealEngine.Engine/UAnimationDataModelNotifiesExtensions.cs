using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimationDataModelNotifiesExtensions", "Engine", UnrealModuleType.Engine)]
public class UAnimationDataModelNotifiesExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetPayload_IsValid;

	private static IntPtr GetPayload_FunctionAddress;

	private static int GetPayload_ParamsSize;

	private static bool GetPayload_Payload_IsValid;

	private static FFieldAddress GetPayload_Payload_PropertyAddress;

	private static int GetPayload_Payload_Offset;

	private static bool GetPayload_ReturnValue_IsValid;

	private static FFieldAddress GetPayload_ReturnValue_PropertyAddress;

	private static int GetPayload_ReturnValue_Offset;

	private static bool CopyPayload_IsValid;

	private static IntPtr CopyPayload_FunctionAddress;

	private static int CopyPayload_ParamsSize;

	private static bool CopyPayload_Payload_IsValid;

	private static FFieldAddress CopyPayload_Payload_PropertyAddress;

	private static int CopyPayload_Payload_Offset;

	private static bool CopyPayload_ExpectedStruct_IsValid;

	private static FFieldAddress CopyPayload_ExpectedStruct_PropertyAddress;

	private static int CopyPayload_ExpectedStruct_Offset;

	private static bool CopyPayload_OutPayload_IsValid;

	private static FFieldAddress CopyPayload_OutPayload_PropertyAddress;

	private static int CopyPayload_OutPayload_Offset;

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/Engine.AnimationDataModelNotifiesExtensions:GetPayload")]
	public unsafe static FEmptyPayload GetPayload(FAnimDataModelNotifPayload Payload)
	{
		if (!GetPayload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataModelNotifiesExtensions:GetPayload");
			return default(FEmptyPayload);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPayload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPayload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPayload_Payload_PropertyAddress.Address, intPtr);
		FAnimDataModelNotifPayload.ToNative(IntPtr.Add(intPtr, GetPayload_Payload_Offset), 0, GetPayload_Payload_PropertyAddress.Address, Payload);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPayload_FunctionAddress, intPtr, GetPayload_ParamsSize);
		return BlittableTypeMarshaler<FEmptyPayload>.FromNative(IntPtr.Add(intPtr, GetPayload_ReturnValue_Offset), 0, GetPayload_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/Engine.AnimationDataModelNotifiesExtensions:CopyPayload")]
	public unsafe static void CopyPayload(FAnimDataModelNotifPayload Payload, UScriptStruct ExpectedStruct, ref FEmptyPayload OutPayload)
	{
		if (!CopyPayload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataModelNotifiesExtensions:CopyPayload");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPayload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPayload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CopyPayload_Payload_PropertyAddress.Address, intPtr);
		FAnimDataModelNotifPayload.ToNative(IntPtr.Add(intPtr, CopyPayload_Payload_Offset), 0, CopyPayload_Payload_PropertyAddress.Address, Payload);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, CopyPayload_ExpectedStruct_Offset), 0, CopyPayload_ExpectedStruct_PropertyAddress.Address, ExpectedStruct);
		BlittableTypeMarshaler<FEmptyPayload>.ToNative(IntPtr.Add(intPtr, CopyPayload_OutPayload_Offset), 0, CopyPayload_OutPayload_PropertyAddress.Address, OutPayload);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyPayload_FunctionAddress, intPtr, CopyPayload_ParamsSize);
		OutPayload = BlittableTypeMarshaler<FEmptyPayload>.FromNative(IntPtr.Add(intPtr, CopyPayload_OutPayload_Offset), 0, CopyPayload_OutPayload_PropertyAddress.Address);
	}

	static UAnimationDataModelNotifiesExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationDataModelNotifiesExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationDataModelNotifiesExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimationDataModelNotifiesExtensions");
		GetPayload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPayload");
		GetPayload_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPayload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPayload_Payload_PropertyAddress, GetPayload_FunctionAddress, "Payload");
		GetPayload_Payload_Offset = NativeReflectionCached.GetPropertyOffset(GetPayload_FunctionAddress, "Payload");
		GetPayload_Payload_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPayload_FunctionAddress, "Payload", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPayload_ReturnValue_PropertyAddress, GetPayload_FunctionAddress, "ReturnValue");
		GetPayload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPayload_FunctionAddress, "ReturnValue");
		GetPayload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPayload_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPayload_IsValid = GetPayload_FunctionAddress != IntPtr.Zero && GetPayload_Payload_IsValid && GetPayload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataModelNotifiesExtensions:GetPayload", GetPayload_IsValid);
		CopyPayload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyPayload");
		CopyPayload_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPayload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPayload_Payload_PropertyAddress, CopyPayload_FunctionAddress, "Payload");
		CopyPayload_Payload_Offset = NativeReflectionCached.GetPropertyOffset(CopyPayload_FunctionAddress, "Payload");
		CopyPayload_Payload_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPayload_FunctionAddress, "Payload", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPayload_ExpectedStruct_PropertyAddress, CopyPayload_FunctionAddress, "ExpectedStruct");
		CopyPayload_ExpectedStruct_Offset = NativeReflectionCached.GetPropertyOffset(CopyPayload_FunctionAddress, "ExpectedStruct");
		CopyPayload_ExpectedStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPayload_FunctionAddress, "ExpectedStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPayload_OutPayload_PropertyAddress, CopyPayload_FunctionAddress, "OutPayload");
		CopyPayload_OutPayload_Offset = NativeReflectionCached.GetPropertyOffset(CopyPayload_FunctionAddress, "OutPayload");
		CopyPayload_OutPayload_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPayload_FunctionAddress, "OutPayload", Classes.FStructProperty);
		CopyPayload_IsValid = CopyPayload_FunctionAddress != IntPtr.Zero && CopyPayload_Payload_IsValid && CopyPayload_ExpectedStruct_IsValid && CopyPayload_OutPayload_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataModelNotifiesExtensions:CopyPayload", CopyPayload_IsValid);
	}
}
