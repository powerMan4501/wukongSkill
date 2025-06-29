using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnMouseMoveEvent__DelegateSignature")]
public class FGSOnMouseMoveEvent : FMulticastDelegate<FGSOnMouseMoveEvent.Signature>
{
	public delegate void Signature(FPointerEvent InMouseEvent);

	private static bool GSOnMouseMoveEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnMouseMoveEvent__DelegateSignature_FunctionAddress;

	private static int GSOnMouseMoveEvent__DelegateSignature_ParamsSize;

	private static bool GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_IsValid;

	private static FFieldAddress GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_PropertyAddress;

	private static int GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnMouseMoveEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnMouseMoveEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnMouseMoveEvent__DelegateSignature");
		GSOnMouseMoveEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnMouseMoveEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_PropertyAddress, GSOnMouseMoveEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnMouseMoveEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnMouseMoveEvent__DelegateSignature_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		GSOnMouseMoveEvent__DelegateSignature_IsValid = GSOnMouseMoveEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnMouseMoveEvent__DelegateSignature", GSOnMouseMoveEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPointerEvent InMouseEvent)
	{
		if (!GSOnMouseMoveEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnMouseMoveEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnMouseMoveEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnMouseMoveEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_Offset), 0, GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, InMouseEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnMouseMoveEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
		}
	}
}
