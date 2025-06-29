using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature")]
public class FOnPrimaryAssetClassListLoaded : FMulticastDelegate<FOnPrimaryAssetClassListLoaded.Signature>
{
	public delegate void Signature(List<TSubclassOf<UObject>> Loaded);

	private static bool OnPrimaryAssetClassListLoaded__DelegateSignature_IsValid;

	private static IntPtr OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress;

	private static int OnPrimaryAssetClassListLoaded__DelegateSignature_ParamsSize;

	private static bool OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_IsValid;

	private static FFieldAddress OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_PropertyAddress;

	private static int OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPrimaryAssetClassListLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature");
		OnPrimaryAssetClassListLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_PropertyAddress, OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_Offset = NativeReflectionCached.GetPropertyOffset(OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress, "Loaded", Classes.FArrayProperty);
		OnPrimaryAssetClassListLoaded__DelegateSignature_IsValid = OnPrimaryAssetClassListLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature", OnPrimaryAssetClassListLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<TSubclassOf<UObject>> Loaded)
	{
		if (!OnPrimaryAssetClassListLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPrimaryAssetClassListLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPrimaryAssetClassListLoaded__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_Offset), Loaded);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPrimaryAssetClassListLoaded__DelegateSignature_Loaded_PropertyAddress.Address, intPtr);
		}
	}
}
