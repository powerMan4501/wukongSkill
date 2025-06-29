using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UDelegate]
[UMetaPath("/Script/Water.OnPontoonExitedWater__DelegateSignature")]
public class FOnPontoonExitedWater : FMulticastDelegate<FOnPontoonExitedWater.Signature>
{
	public delegate void Signature(FSphericalPontoon Pontoon);

	private static bool OnPontoonExitedWater__DelegateSignature_IsValid;

	private static IntPtr OnPontoonExitedWater__DelegateSignature_FunctionAddress;

	private static int OnPontoonExitedWater__DelegateSignature_ParamsSize;

	private static bool OnPontoonExitedWater__DelegateSignature_Pontoon_IsValid;

	private static FFieldAddress OnPontoonExitedWater__DelegateSignature_Pontoon_PropertyAddress;

	private static int OnPontoonExitedWater__DelegateSignature_Pontoon_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPontoonExitedWater()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPontoonExitedWater__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Water.OnPontoonExitedWater__DelegateSignature");
		OnPontoonExitedWater__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPontoonExitedWater__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPontoonExitedWater__DelegateSignature_Pontoon_PropertyAddress, OnPontoonExitedWater__DelegateSignature_FunctionAddress, "Pontoon");
		OnPontoonExitedWater__DelegateSignature_Pontoon_Offset = NativeReflectionCached.GetPropertyOffset(OnPontoonExitedWater__DelegateSignature_FunctionAddress, "Pontoon");
		OnPontoonExitedWater__DelegateSignature_Pontoon_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPontoonExitedWater__DelegateSignature_FunctionAddress, "Pontoon", Classes.FStructProperty);
		OnPontoonExitedWater__DelegateSignature_IsValid = OnPontoonExitedWater__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPontoonExitedWater__DelegateSignature_Pontoon_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.OnPontoonExitedWater__DelegateSignature", OnPontoonExitedWater__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FSphericalPontoon Pontoon)
	{
		if (!OnPontoonExitedWater__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.OnPontoonExitedWater__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPontoonExitedWater__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPontoonExitedWater__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnPontoonExitedWater__DelegateSignature_Pontoon_PropertyAddress.Address, intPtr);
			FSphericalPontoon.ToNative(IntPtr.Add(intPtr, OnPontoonExitedWater__DelegateSignature_Pontoon_Offset), 0, OnPontoonExitedWater__DelegateSignature_Pontoon_PropertyAddress.Address, Pontoon);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPontoonExitedWater__DelegateSignature_Pontoon_PropertyAddress.Address, intPtr);
		}
	}
}
