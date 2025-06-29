using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputKeyUpEvent__DelegateSignature")]
public class FGSOnInputKeyUpEvent : FMulticastDelegate<FGSOnInputKeyUpEvent.Signature>
{
	public delegate void Signature(FKey InKey);

	private static bool GSOnInputKeyUpEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputKeyUpEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputKeyUpEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputKeyUpEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputKeyUpEvent__DelegateSignature_InKey_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputKeyUpEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputKeyUpEvent__DelegateSignature");
		GSOnInputKeyUpEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputKeyUpEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputKeyUpEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputKeyUpEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		GSOnInputKeyUpEvent__DelegateSignature_IsValid = GSOnInputKeyUpEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputKeyUpEvent__DelegateSignature_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputKeyUpEvent__DelegateSignature", GSOnInputKeyUpEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey)
	{
		if (!GSOnInputKeyUpEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputKeyUpEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputKeyUpEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputKeyUpEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputKeyUpEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputKeyUpEvent__DelegateSignature_InKey_Offset), 0, GSOnInputKeyUpEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputKeyUpEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
