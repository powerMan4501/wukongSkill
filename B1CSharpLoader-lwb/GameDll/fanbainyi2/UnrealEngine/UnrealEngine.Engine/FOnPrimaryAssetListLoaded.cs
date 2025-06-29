using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature")]
public class FOnPrimaryAssetListLoaded : FMulticastDelegate<FOnPrimaryAssetListLoaded.Signature>
{
	public delegate void Signature(List<UObject> Loaded);

	private static bool OnPrimaryAssetListLoaded__DelegateSignature_IsValid;

	private static IntPtr OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress;

	private static int OnPrimaryAssetListLoaded__DelegateSignature_ParamsSize;

	private static bool OnPrimaryAssetListLoaded__DelegateSignature_Loaded_IsValid;

	private static FFieldAddress OnPrimaryAssetListLoaded__DelegateSignature_Loaded_PropertyAddress;

	private static int OnPrimaryAssetListLoaded__DelegateSignature_Loaded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPrimaryAssetListLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature");
		OnPrimaryAssetListLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPrimaryAssetListLoaded__DelegateSignature_Loaded_PropertyAddress, OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetListLoaded__DelegateSignature_Loaded_Offset = NativeReflectionCached.GetPropertyOffset(OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetListLoaded__DelegateSignature_Loaded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress, "Loaded", Classes.FArrayProperty);
		OnPrimaryAssetListLoaded__DelegateSignature_IsValid = OnPrimaryAssetListLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPrimaryAssetListLoaded__DelegateSignature_Loaded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature", OnPrimaryAssetListLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<UObject> Loaded)
	{
		if (!OnPrimaryAssetListLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPrimaryAssetListLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPrimaryAssetListLoaded__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<UObject>(1, OnPrimaryAssetListLoaded__DelegateSignature_Loaded_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OnPrimaryAssetListLoaded__DelegateSignature_Loaded_Offset), Loaded);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPrimaryAssetListLoaded__DelegateSignature_Loaded_PropertyAddress.Address, intPtr);
		}
	}
}
