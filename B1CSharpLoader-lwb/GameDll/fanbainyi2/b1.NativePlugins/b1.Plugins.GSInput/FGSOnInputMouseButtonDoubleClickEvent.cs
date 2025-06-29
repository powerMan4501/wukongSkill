using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputMouseButtonDoubleClickEvent__DelegateSignature")]
public class FGSOnInputMouseButtonDoubleClickEvent : FMulticastDelegate<FGSOnInputMouseButtonDoubleClickEvent.Signature>
{
	public delegate void Signature(FKey InKey);

	private static bool GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputMouseButtonDoubleClickEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputMouseButtonDoubleClickEvent__DelegateSignature");
		GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_IsValid = GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputMouseButtonDoubleClickEvent__DelegateSignature", GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey)
	{
		if (!GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputMouseButtonDoubleClickEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_Offset), 0, GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputMouseButtonDoubleClickEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
