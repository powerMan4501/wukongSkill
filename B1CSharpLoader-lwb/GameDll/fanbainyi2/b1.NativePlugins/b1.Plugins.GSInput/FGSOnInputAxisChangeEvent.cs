using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputAxisChangeEvent__DelegateSignature")]
public class FGSOnInputAxisChangeEvent : FMulticastDelegate<FGSOnInputAxisChangeEvent.Signature>
{
	public delegate void Signature(FKey InKey, float InAxisValue);

	private static bool GSOnInputAxisChangeEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputAxisChangeEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputAxisChangeEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputAxisChangeEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputAxisChangeEvent__DelegateSignature_InKey_Offset;

	private static bool GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_IsValid;

	private static FFieldAddress GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_PropertyAddress;

	private static int GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputAxisChangeEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputAxisChangeEvent__DelegateSignature");
		GSOnInputAxisChangeEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputAxisChangeEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputAxisChangeEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputAxisChangeEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_PropertyAddress, GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InAxisValue");
		GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InAxisValue");
		GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress, "InAxisValue", Classes.FFloatProperty);
		GSOnInputAxisChangeEvent__DelegateSignature_IsValid = GSOnInputAxisChangeEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputAxisChangeEvent__DelegateSignature_InKey_IsValid && GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputAxisChangeEvent__DelegateSignature", GSOnInputAxisChangeEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey, float InAxisValue)
	{
		if (!GSOnInputAxisChangeEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputAxisChangeEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputAxisChangeEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputAxisChangeEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputAxisChangeEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputAxisChangeEvent__DelegateSignature_InKey_Offset), 0, GSOnInputAxisChangeEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_Offset), 0, GSOnInputAxisChangeEvent__DelegateSignature_InAxisValue_PropertyAddress.Address, InAxisValue);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputAxisChangeEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
