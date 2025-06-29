using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PlatformInterfaceDelegate__DelegateSignature")]
public class FPlatformInterfaceDelegate : FDelegate<FPlatformInterfaceDelegate.Signature>
{
	public delegate void Signature(FPlatformInterfaceDelegateResult Result);

	private static bool PlatformInterfaceDelegate__DelegateSignature_IsValid;

	private static IntPtr PlatformInterfaceDelegate__DelegateSignature_FunctionAddress;

	private static int PlatformInterfaceDelegate__DelegateSignature_ParamsSize;

	private static bool PlatformInterfaceDelegate__DelegateSignature_Result_IsValid;

	private static FFieldAddress PlatformInterfaceDelegate__DelegateSignature_Result_PropertyAddress;

	private static int PlatformInterfaceDelegate__DelegateSignature_Result_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPlatformInterfaceDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PlatformInterfaceDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformInterfaceDelegate__DelegateSignature");
		PlatformInterfaceDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformInterfaceDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlatformInterfaceDelegate__DelegateSignature_Result_PropertyAddress, PlatformInterfaceDelegate__DelegateSignature_FunctionAddress, "Result");
		PlatformInterfaceDelegate__DelegateSignature_Result_Offset = NativeReflectionCached.GetPropertyOffset(PlatformInterfaceDelegate__DelegateSignature_FunctionAddress, "Result");
		PlatformInterfaceDelegate__DelegateSignature_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformInterfaceDelegate__DelegateSignature_FunctionAddress, "Result", Classes.FStructProperty);
		PlatformInterfaceDelegate__DelegateSignature_IsValid = PlatformInterfaceDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformInterfaceDelegate__DelegateSignature_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformInterfaceDelegate__DelegateSignature", PlatformInterfaceDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPlatformInterfaceDelegateResult Result)
	{
		if (!PlatformInterfaceDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformInterfaceDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PlatformInterfaceDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformInterfaceDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(PlatformInterfaceDelegate__DelegateSignature_Result_PropertyAddress.Address, intPtr);
			FPlatformInterfaceDelegateResult.ToNative(IntPtr.Add(intPtr, PlatformInterfaceDelegate__DelegateSignature_Result_Offset), 0, PlatformInterfaceDelegate__DelegateSignature_Result_PropertyAddress.Address, Result);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(PlatformInterfaceDelegate__DelegateSignature_Result_PropertyAddress.Address, intPtr);
		}
	}
}
