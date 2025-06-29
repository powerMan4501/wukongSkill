using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputMouseButtonUpEvent__DelegateSignature")]
public class FGSOnInputMouseButtonUpEvent : FMulticastDelegate<FGSOnInputMouseButtonUpEvent.Signature>
{
	public delegate void Signature(FKey InKey);

	private static bool GSOnInputMouseButtonUpEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputMouseButtonUpEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_IsValid;

	private static FFieldAddress GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_PropertyAddress;

	private static int GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputMouseButtonUpEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputMouseButtonUpEvent__DelegateSignature");
		GSOnInputMouseButtonUpEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_PropertyAddress, GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InKey");
		GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InKey", Classes.FStructProperty);
		GSOnInputMouseButtonUpEvent__DelegateSignature_IsValid = GSOnInputMouseButtonUpEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputMouseButtonUpEvent__DelegateSignature", GSOnInputMouseButtonUpEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey InKey)
	{
		if (!GSOnInputMouseButtonUpEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputMouseButtonUpEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputMouseButtonUpEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputMouseButtonUpEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_Offset), 0, GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_PropertyAddress.Address, InKey);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnInputMouseButtonUpEvent__DelegateSignature_InKey_PropertyAddress.Address, intPtr);
		}
	}
}
