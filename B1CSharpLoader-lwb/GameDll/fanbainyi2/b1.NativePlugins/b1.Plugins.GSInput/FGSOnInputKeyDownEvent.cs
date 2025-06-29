using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputKeyDownEvent__DelegateSignature")]
public class FGSOnInputKeyDownEvent : FMulticastDelegate<FGSOnInputKeyDownEvent.Signature>
{
	public delegate void Signature(FKey InKey);

	private static bool GSOnInputKeyDownEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputKeyDownEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputKeyDownEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputKeyDownEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputKeyDownEvent__DelegateSignature_InKey_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputKeyDownEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputKeyDownEvent__DelegateSignature");
		GSOnInputKeyDownEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputKeyDownEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputKeyDownEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputKeyDownEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		GSOnInputKeyDownEvent__DelegateSignature_IsValid = GSOnInputKeyDownEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputKeyDownEvent__DelegateSignature_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputKeyDownEvent__DelegateSignature", GSOnInputKeyDownEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey)
	{
		if (!GSOnInputKeyDownEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputKeyDownEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputKeyDownEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputKeyDownEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputKeyDownEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputKeyDownEvent__DelegateSignature_InKey_Offset), 0, GSOnInputKeyDownEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputKeyDownEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
