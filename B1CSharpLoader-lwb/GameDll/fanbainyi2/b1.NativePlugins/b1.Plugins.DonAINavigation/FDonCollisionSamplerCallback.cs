using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UDelegate]
[UMetaPath("/Script/DonAINavigation.DonCollisionSamplerCallback__DelegateSignature")]
public class FDonCollisionSamplerCallback : FDelegate<FDonCollisionSamplerCallback.Signature>
{
	public delegate void Signature(bool bTaskSuccessful);

	private static bool DonCollisionSamplerCallback__DelegateSignature_IsValid;

	private static IntPtr DonCollisionSamplerCallback__DelegateSignature_FunctionAddress;

	private static int DonCollisionSamplerCallback__DelegateSignature_ParamsSize;

	private static bool DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_IsValid;

	private static FFieldAddress DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_PropertyAddress;

	private static int DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDonCollisionSamplerCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DonCollisionSamplerCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DonAINavigation.DonCollisionSamplerCallback__DelegateSignature");
		DonCollisionSamplerCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DonCollisionSamplerCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_PropertyAddress, DonCollisionSamplerCallback__DelegateSignature_FunctionAddress, "bTaskSuccessful");
		DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(DonCollisionSamplerCallback__DelegateSignature_FunctionAddress, "bTaskSuccessful");
		DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(DonCollisionSamplerCallback__DelegateSignature_FunctionAddress, "bTaskSuccessful", Classes.FBoolProperty);
		DonCollisionSamplerCallback__DelegateSignature_IsValid = DonCollisionSamplerCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonCollisionSamplerCallback__DelegateSignature", DonCollisionSamplerCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bTaskSuccessful)
	{
		if (!DonCollisionSamplerCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonCollisionSamplerCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DonCollisionSamplerCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DonCollisionSamplerCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_Offset), 0, DonCollisionSamplerCallback__DelegateSignature_bTaskSuccessful_PropertyAddress.Address, bTaskSuccessful);
			ProcessDelegate(intPtr);
		}
	}
}
