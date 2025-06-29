using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnMouseWheelEvent__DelegateSignature")]
public class FGSOnMouseWheelEvent : FMulticastDelegate<FGSOnMouseWheelEvent.Signature>
{
	public delegate void Signature(FPointerEvent InWheelEvent);

	private static bool GSOnMouseWheelEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnMouseWheelEvent__DelegateSignature_FunctionAddress;

	private static int GSOnMouseWheelEvent__DelegateSignature_ParamsSize;

	private static bool GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_IsValid;

	private static FFieldAddress GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_PropertyAddress;

	private static int GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnMouseWheelEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnMouseWheelEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnMouseWheelEvent__DelegateSignature");
		GSOnMouseWheelEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnMouseWheelEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_PropertyAddress, GSOnMouseWheelEvent__DelegateSignature_FunctionAddress, "InWheelEvent");
		GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnMouseWheelEvent__DelegateSignature_FunctionAddress, "InWheelEvent");
		GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnMouseWheelEvent__DelegateSignature_FunctionAddress, "InWheelEvent", Classes.FStructProperty);
		GSOnMouseWheelEvent__DelegateSignature_IsValid = GSOnMouseWheelEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnMouseWheelEvent__DelegateSignature", GSOnMouseWheelEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPointerEvent InWheelEvent)
	{
		if (!GSOnMouseWheelEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnMouseWheelEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnMouseWheelEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnMouseWheelEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_Offset), 0, GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_PropertyAddress.Address, InWheelEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnMouseWheelEvent__DelegateSignature_InWheelEvent_PropertyAddress.Address, intPtr);
		}
	}
}
