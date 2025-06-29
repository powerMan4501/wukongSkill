using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature")]
public class FOnPrimaryAssetClassLoaded : FMulticastDelegate<FOnPrimaryAssetClassLoaded.Signature>
{
	public delegate void Signature(TSubclassOf<UObject> Loaded);

	private static bool OnPrimaryAssetClassLoaded__DelegateSignature_IsValid;

	private static IntPtr OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress;

	private static int OnPrimaryAssetClassLoaded__DelegateSignature_ParamsSize;

	private static bool OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_IsValid;

	private static FFieldAddress OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_PropertyAddress;

	private static int OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPrimaryAssetClassLoaded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature");
		OnPrimaryAssetClassLoaded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_PropertyAddress, OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_Offset = NativeReflectionCached.GetPropertyOffset(OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress, "Loaded");
		OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress, "Loaded", Classes.FClassProperty);
		OnPrimaryAssetClassLoaded__DelegateSignature_IsValid = OnPrimaryAssetClassLoaded__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature", OnPrimaryAssetClassLoaded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(TSubclassOf<UObject> Loaded)
	{
		if (!OnPrimaryAssetClassLoaded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPrimaryAssetClassLoaded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPrimaryAssetClassLoaded__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_Offset), 0, OnPrimaryAssetClassLoaded__DelegateSignature_Loaded_PropertyAddress.Address, Loaded);
			ProcessDelegate(intPtr);
		}
	}
}
