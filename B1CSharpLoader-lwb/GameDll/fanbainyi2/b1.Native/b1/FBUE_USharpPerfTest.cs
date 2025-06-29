using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BUE_USharpPerfTest__DelegateSignature")]
public class FBUE_USharpPerfTest : FMulticastDelegate<FBUE_USharpPerfTest.Signature>
{
	public delegate void Signature(int AttrID, int RealNewValue, int RealOrgValue, int ExpectChangeValue);

	private static bool BUE_USharpPerfTest__DelegateSignature_IsValid;

	private static IntPtr BUE_USharpPerfTest__DelegateSignature_FunctionAddress;

	private static int BUE_USharpPerfTest__DelegateSignature_ParamsSize;

	private static bool BUE_USharpPerfTest__DelegateSignature_AttrID_IsValid;

	private static FFieldAddress BUE_USharpPerfTest__DelegateSignature_AttrID_PropertyAddress;

	private static int BUE_USharpPerfTest__DelegateSignature_AttrID_Offset;

	private static bool BUE_USharpPerfTest__DelegateSignature_RealNewValue_IsValid;

	private static FFieldAddress BUE_USharpPerfTest__DelegateSignature_RealNewValue_PropertyAddress;

	private static int BUE_USharpPerfTest__DelegateSignature_RealNewValue_Offset;

	private static bool BUE_USharpPerfTest__DelegateSignature_RealOrgValue_IsValid;

	private static FFieldAddress BUE_USharpPerfTest__DelegateSignature_RealOrgValue_PropertyAddress;

	private static int BUE_USharpPerfTest__DelegateSignature_RealOrgValue_Offset;

	private static bool BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_IsValid;

	private static FFieldAddress BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_PropertyAddress;

	private static int BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBUE_USharpPerfTest()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BUE_USharpPerfTest__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BUE_USharpPerfTest__DelegateSignature");
		BUE_USharpPerfTest__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BUE_USharpPerfTest__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BUE_USharpPerfTest__DelegateSignature_AttrID_PropertyAddress, BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "AttrID");
		BUE_USharpPerfTest__DelegateSignature_AttrID_Offset = NativeReflectionCached.GetPropertyOffset(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "AttrID");
		BUE_USharpPerfTest__DelegateSignature_AttrID_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "AttrID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_USharpPerfTest__DelegateSignature_RealNewValue_PropertyAddress, BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealNewValue");
		BUE_USharpPerfTest__DelegateSignature_RealNewValue_Offset = NativeReflectionCached.GetPropertyOffset(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealNewValue");
		BUE_USharpPerfTest__DelegateSignature_RealNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealNewValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_USharpPerfTest__DelegateSignature_RealOrgValue_PropertyAddress, BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealOrgValue");
		BUE_USharpPerfTest__DelegateSignature_RealOrgValue_Offset = NativeReflectionCached.GetPropertyOffset(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealOrgValue");
		BUE_USharpPerfTest__DelegateSignature_RealOrgValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "RealOrgValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_PropertyAddress, BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "ExpectChangeValue");
		BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_Offset = NativeReflectionCached.GetPropertyOffset(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "ExpectChangeValue");
		BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BUE_USharpPerfTest__DelegateSignature_FunctionAddress, "ExpectChangeValue", Classes.FIntProperty);
		BUE_USharpPerfTest__DelegateSignature_IsValid = BUE_USharpPerfTest__DelegateSignature_FunctionAddress != IntPtr.Zero && BUE_USharpPerfTest__DelegateSignature_AttrID_IsValid && BUE_USharpPerfTest__DelegateSignature_RealNewValue_IsValid && BUE_USharpPerfTest__DelegateSignature_RealOrgValue_IsValid && BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUE_USharpPerfTest__DelegateSignature", BUE_USharpPerfTest__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int AttrID, int RealNewValue, int RealOrgValue, int ExpectChangeValue)
	{
		if (!BUE_USharpPerfTest__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUE_USharpPerfTest__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BUE_USharpPerfTest__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BUE_USharpPerfTest__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_USharpPerfTest__DelegateSignature_AttrID_Offset), 0, BUE_USharpPerfTest__DelegateSignature_AttrID_PropertyAddress.Address, AttrID);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_USharpPerfTest__DelegateSignature_RealNewValue_Offset), 0, BUE_USharpPerfTest__DelegateSignature_RealNewValue_PropertyAddress.Address, RealNewValue);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_USharpPerfTest__DelegateSignature_RealOrgValue_Offset), 0, BUE_USharpPerfTest__DelegateSignature_RealOrgValue_PropertyAddress.Address, RealOrgValue);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_Offset), 0, BUE_USharpPerfTest__DelegateSignature_ExpectChangeValue_PropertyAddress.Address, ExpectChangeValue);
			ProcessDelegate(intPtr);
		}
	}
}
