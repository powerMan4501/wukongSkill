using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UDelegate]
[UMetaPath("/Script/Water.OnPontoonEnteredWater__DelegateSignature")]
public class FOnPontoonEnteredWater : FMulticastDelegate<FOnPontoonEnteredWater.Signature>
{
	public delegate void Signature(FSphericalPontoon Pontoon);

	private static bool OnPontoonEnteredWater__DelegateSignature_IsValid;

	private static IntPtr OnPontoonEnteredWater__DelegateSignature_FunctionAddress;

	private static int OnPontoonEnteredWater__DelegateSignature_ParamsSize;

	private static bool OnPontoonEnteredWater__DelegateSignature_Pontoon_IsValid;

	private static FFieldAddress OnPontoonEnteredWater__DelegateSignature_Pontoon_PropertyAddress;

	private static int OnPontoonEnteredWater__DelegateSignature_Pontoon_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPontoonEnteredWater()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPontoonEnteredWater__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Water.OnPontoonEnteredWater__DelegateSignature");
		OnPontoonEnteredWater__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPontoonEnteredWater__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPontoonEnteredWater__DelegateSignature_Pontoon_PropertyAddress, OnPontoonEnteredWater__DelegateSignature_FunctionAddress, "Pontoon");
		OnPontoonEnteredWater__DelegateSignature_Pontoon_Offset = NativeReflectionCached.GetPropertyOffset(OnPontoonEnteredWater__DelegateSignature_FunctionAddress, "Pontoon");
		OnPontoonEnteredWater__DelegateSignature_Pontoon_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPontoonEnteredWater__DelegateSignature_FunctionAddress, "Pontoon", Classes.FStructProperty);
		OnPontoonEnteredWater__DelegateSignature_IsValid = OnPontoonEnteredWater__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPontoonEnteredWater__DelegateSignature_Pontoon_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.OnPontoonEnteredWater__DelegateSignature", OnPontoonEnteredWater__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FSphericalPontoon Pontoon)
	{
		if (!OnPontoonEnteredWater__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.OnPontoonEnteredWater__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPontoonEnteredWater__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPontoonEnteredWater__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnPontoonEnteredWater__DelegateSignature_Pontoon_PropertyAddress.Address, intPtr);
			FSphericalPontoon.ToNative(IntPtr.Add(intPtr, OnPontoonEnteredWater__DelegateSignature_Pontoon_Offset), 0, OnPontoonEnteredWater__DelegateSignature_Pontoon_PropertyAddress.Address, Pontoon);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnPontoonEnteredWater__DelegateSignature_Pontoon_PropertyAddress.Address, intPtr);
		}
	}
}
