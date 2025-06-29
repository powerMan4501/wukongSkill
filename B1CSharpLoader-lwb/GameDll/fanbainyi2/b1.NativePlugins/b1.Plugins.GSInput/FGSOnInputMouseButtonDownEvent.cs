using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputMouseButtonDownEvent__DelegateSignature")]
public class FGSOnInputMouseButtonDownEvent : FMulticastDelegate<FGSOnInputMouseButtonDownEvent.Signature>
{
	public delegate void Signature(FKey InKey);

	private static bool GSOnInputMouseButtonDownEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputMouseButtonDownEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputMouseButtonDownEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputMouseButtonDownEvent__DelegateSignature");
		GSOnInputMouseButtonDownEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		GSOnInputMouseButtonDownEvent__DelegateSignature_IsValid = GSOnInputMouseButtonDownEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputMouseButtonDownEvent__DelegateSignature", GSOnInputMouseButtonDownEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey)
	{
		if (!GSOnInputMouseButtonDownEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputMouseButtonDownEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputMouseButtonDownEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputMouseButtonDownEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_Offset), 0, GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputMouseButtonDownEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
