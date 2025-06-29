using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UDelegate]
[UMetaPath("/Script/InterchangeEngine.OnImportDoneDynamic__DelegateSignature")]
public class FOnImportDoneDynamic : FDelegate<FOnImportDoneDynamic.Signature>
{
	public delegate void Signature(List<UObject> Objects);

	private static bool OnImportDoneDynamic__DelegateSignature_IsValid;

	private static IntPtr OnImportDoneDynamic__DelegateSignature_FunctionAddress;

	private static int OnImportDoneDynamic__DelegateSignature_ParamsSize;

	private static bool OnImportDoneDynamic__DelegateSignature_Objects_IsValid;

	private static FFieldAddress OnImportDoneDynamic__DelegateSignature_Objects_PropertyAddress;

	private static int OnImportDoneDynamic__DelegateSignature_Objects_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnImportDoneDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnImportDoneDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/InterchangeEngine.OnImportDoneDynamic__DelegateSignature");
		OnImportDoneDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnImportDoneDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnImportDoneDynamic__DelegateSignature_Objects_PropertyAddress, OnImportDoneDynamic__DelegateSignature_FunctionAddress, "Objects");
		OnImportDoneDynamic__DelegateSignature_Objects_Offset = NativeReflectionCached.GetPropertyOffset(OnImportDoneDynamic__DelegateSignature_FunctionAddress, "Objects");
		OnImportDoneDynamic__DelegateSignature_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(OnImportDoneDynamic__DelegateSignature_FunctionAddress, "Objects", Classes.FArrayProperty);
		OnImportDoneDynamic__DelegateSignature_IsValid = OnImportDoneDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnImportDoneDynamic__DelegateSignature_Objects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.OnImportDoneDynamic__DelegateSignature", OnImportDoneDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<UObject> Objects)
	{
		if (!OnImportDoneDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.OnImportDoneDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnImportDoneDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnImportDoneDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<UObject>(1, OnImportDoneDynamic__DelegateSignature_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OnImportDoneDynamic__DelegateSignature_Objects_Offset), Objects);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnImportDoneDynamic__DelegateSignature_Objects_PropertyAddress.Address, intPtr);
		}
	}
}
