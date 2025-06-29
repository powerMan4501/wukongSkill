using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UDelegate]
[UMetaPath("/Script/InterchangeEngine.OnObjectImportDoneDynamic__DelegateSignature")]
public class FOnObjectImportDoneDynamic : FDelegate<FOnObjectImportDoneDynamic.Signature>
{
	public delegate void Signature(UObject Object);

	private static bool OnObjectImportDoneDynamic__DelegateSignature_IsValid;

	private static IntPtr OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress;

	private static int OnObjectImportDoneDynamic__DelegateSignature_ParamsSize;

	private static bool OnObjectImportDoneDynamic__DelegateSignature_Object_IsValid;

	private static FFieldAddress OnObjectImportDoneDynamic__DelegateSignature_Object_PropertyAddress;

	private static int OnObjectImportDoneDynamic__DelegateSignature_Object_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnObjectImportDoneDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/InterchangeEngine.OnObjectImportDoneDynamic__DelegateSignature");
		OnObjectImportDoneDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnObjectImportDoneDynamic__DelegateSignature_Object_PropertyAddress, OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress, "Object");
		OnObjectImportDoneDynamic__DelegateSignature_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress, "Object");
		OnObjectImportDoneDynamic__DelegateSignature_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress, "Object", Classes.FObjectProperty);
		OnObjectImportDoneDynamic__DelegateSignature_IsValid = OnObjectImportDoneDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnObjectImportDoneDynamic__DelegateSignature_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.OnObjectImportDoneDynamic__DelegateSignature", OnObjectImportDoneDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Object)
	{
		if (!OnObjectImportDoneDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.OnObjectImportDoneDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnObjectImportDoneDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnObjectImportDoneDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnObjectImportDoneDynamic__DelegateSignature_Object_Offset), 0, OnObjectImportDoneDynamic__DelegateSignature_Object_PropertyAddress.Address, Object);
			ProcessDelegate(intPtr);
		}
	}
}
