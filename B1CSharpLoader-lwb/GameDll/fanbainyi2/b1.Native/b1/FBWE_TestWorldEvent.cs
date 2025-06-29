using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BWE_TestWorldEvent__DelegateSignature")]
public class FBWE_TestWorldEvent : FMulticastDelegate<FBWE_TestWorldEvent.Signature>
{
	public delegate void Signature(float AxisValue);

	private static bool BWE_TestWorldEvent__DelegateSignature_IsValid;

	private static IntPtr BWE_TestWorldEvent__DelegateSignature_FunctionAddress;

	private static int BWE_TestWorldEvent__DelegateSignature_ParamsSize;

	private static bool BWE_TestWorldEvent__DelegateSignature_AxisValue_IsValid;

	private static FFieldAddress BWE_TestWorldEvent__DelegateSignature_AxisValue_PropertyAddress;

	private static int BWE_TestWorldEvent__DelegateSignature_AxisValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBWE_TestWorldEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BWE_TestWorldEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BWE_TestWorldEvent__DelegateSignature");
		BWE_TestWorldEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BWE_TestWorldEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BWE_TestWorldEvent__DelegateSignature_AxisValue_PropertyAddress, BWE_TestWorldEvent__DelegateSignature_FunctionAddress, "AxisValue");
		BWE_TestWorldEvent__DelegateSignature_AxisValue_Offset = NativeReflectionCached.GetPropertyOffset(BWE_TestWorldEvent__DelegateSignature_FunctionAddress, "AxisValue");
		BWE_TestWorldEvent__DelegateSignature_AxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BWE_TestWorldEvent__DelegateSignature_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		BWE_TestWorldEvent__DelegateSignature_IsValid = BWE_TestWorldEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && BWE_TestWorldEvent__DelegateSignature_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWE_TestWorldEvent__DelegateSignature", BWE_TestWorldEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float AxisValue)
	{
		if (!BWE_TestWorldEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWE_TestWorldEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BWE_TestWorldEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BWE_TestWorldEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BWE_TestWorldEvent__DelegateSignature_AxisValue_Offset), 0, BWE_TestWorldEvent__DelegateSignature_AxisValue_PropertyAddress.Address, AxisValue);
			ProcessDelegate(intPtr);
		}
	}
}
