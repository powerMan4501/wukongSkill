using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.LandedSignature__DelegateSignature")]
public class FLandedSignature : FMulticastDelegate<FLandedSignature.Signature>
{
	public delegate void Signature(FHitResult Hit);

	private static bool LandedSignature__DelegateSignature_IsValid;

	private static IntPtr LandedSignature__DelegateSignature_FunctionAddress;

	private static int LandedSignature__DelegateSignature_ParamsSize;

	private static bool LandedSignature__DelegateSignature_Hit_IsValid;

	private static FFieldAddress LandedSignature__DelegateSignature_Hit_PropertyAddress;

	private static int LandedSignature__DelegateSignature_Hit_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FLandedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		LandedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.LandedSignature__DelegateSignature");
		LandedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(LandedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LandedSignature__DelegateSignature_Hit_PropertyAddress, LandedSignature__DelegateSignature_FunctionAddress, "Hit");
		LandedSignature__DelegateSignature_Hit_Offset = NativeReflectionCached.GetPropertyOffset(LandedSignature__DelegateSignature_FunctionAddress, "Hit");
		LandedSignature__DelegateSignature_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(LandedSignature__DelegateSignature_FunctionAddress, "Hit", Classes.FStructProperty);
		LandedSignature__DelegateSignature_IsValid = LandedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && LandedSignature__DelegateSignature_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LandedSignature__DelegateSignature", LandedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FHitResult Hit)
	{
		if (!LandedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LandedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(LandedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LandedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(LandedSignature__DelegateSignature_Hit_PropertyAddress.Address, intPtr);
			FHitResult.ToNative(IntPtr.Add(intPtr, LandedSignature__DelegateSignature_Hit_Offset), 0, LandedSignature__DelegateSignature_Hit_PropertyAddress.Address, Hit);
			ProcessDelegate(intPtr);
		}
	}
}
