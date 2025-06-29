using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnAnyKeyTriggerEvent__DelegateSignature")]
public class FGSOnAnyKeyTriggerEvent : FMulticastDelegate<FGSOnAnyKeyTriggerEvent.Signature>
{
	public delegate void Signature(FKey Key);

	private static bool GSOnAnyKeyTriggerEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress;

	private static int GSOnAnyKeyTriggerEvent__DelegateSignature_ParamsSize;

	private static bool GSOnAnyKeyTriggerEvent__DelegateSignature_Key_IsValid;

	private static FFieldAddress GSOnAnyKeyTriggerEvent__DelegateSignature_Key_PropertyAddress;

	private static int GSOnAnyKeyTriggerEvent__DelegateSignature_Key_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnAnyKeyTriggerEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnAnyKeyTriggerEvent__DelegateSignature");
		GSOnAnyKeyTriggerEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnAnyKeyTriggerEvent__DelegateSignature_Key_PropertyAddress, GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress, "Key");
		GSOnAnyKeyTriggerEvent__DelegateSignature_Key_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress, "Key");
		GSOnAnyKeyTriggerEvent__DelegateSignature_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress, "Key", Classes.FStructProperty);
		GSOnAnyKeyTriggerEvent__DelegateSignature_IsValid = GSOnAnyKeyTriggerEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnAnyKeyTriggerEvent__DelegateSignature_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnAnyKeyTriggerEvent__DelegateSignature", GSOnAnyKeyTriggerEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FKey Key)
	{
		if (!GSOnAnyKeyTriggerEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnAnyKeyTriggerEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnAnyKeyTriggerEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnAnyKeyTriggerEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnAnyKeyTriggerEvent__DelegateSignature_Key_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, GSOnAnyKeyTriggerEvent__DelegateSignature_Key_Offset), 0, GSOnAnyKeyTriggerEvent__DelegateSignature_Key_PropertyAddress.Address, Key);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnAnyKeyTriggerEvent__DelegateSignature_Key_PropertyAddress.Address, intPtr);
		}
	}
}
