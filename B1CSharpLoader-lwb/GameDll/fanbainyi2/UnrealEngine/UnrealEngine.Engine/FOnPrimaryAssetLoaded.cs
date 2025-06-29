using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature")]
public class FOnPrimaryAssetLoaded : FMulticastDelegate<FOnPrimaryAssetLoaded.Signature>
{
	public delegate void Signature(UObject Loaded);

	private static bool OnPrimaryAssetLoaded__DelegateSignature_IsValid;

	private static IntPtr OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress;

	private static int OnPrimaryAssetLoaded__DelegateSignature_ParamsSize;

	private static bool OnPrimaryAssetLoaded__DelegateSignature_Loaded_IsValid;

	private static FFieldAddress OnPrimaryAssetLoaded__DelegateSignature_Loaded_PropertyAddress;

	private static int OnPrimaryAssetLoaded__DelegateSignature_Loaded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPrimaryAssetLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature");
		OnPrimaryAssetLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPrimaryAssetLoaded__DelegateSignature_Loaded_PropertyAddress, OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetLoaded__DelegateSignature_Loaded_Offset = NativeReflectionCached.GetPropertyOffset(OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetLoaded__DelegateSignature_Loaded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress, "Loaded", Classes.FObjectProperty);
		OnPrimaryAssetLoaded__DelegateSignature_IsValid = OnPrimaryAssetLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPrimaryAssetLoaded__DelegateSignature_Loaded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature", OnPrimaryAssetLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Loaded)
	{
		if (!OnPrimaryAssetLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPrimaryAssetLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPrimaryAssetLoaded__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPrimaryAssetLoaded__DelegateSignature_Loaded_Offset), 0, OnPrimaryAssetLoaded__DelegateSignature_Loaded_PropertyAddress.Address, Loaded);
			ProcessDelegate(intPtr);
		}
	}
}
