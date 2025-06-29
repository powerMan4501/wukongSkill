using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnMouseButtonDoubleClickEvent__DelegateSignature")]
public class FGSOnMouseButtonDoubleClickEvent : FMulticastDelegate<FGSOnMouseButtonDoubleClickEvent.Signature>
{
	public delegate void Signature(FPointerEvent InMouseEvent);

	private static bool GSOnMouseButtonDoubleClickEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress;

	private static int GSOnMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize;

	private static bool GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_IsValid;

	private static FFieldAddress GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_PropertyAddress;

	private static int GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnMouseButtonDoubleClickEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnMouseButtonDoubleClickEvent__DelegateSignature");
		GSOnMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_PropertyAddress, GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		GSOnMouseButtonDoubleClickEvent__DelegateSignature_IsValid = GSOnMouseButtonDoubleClickEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnMouseButtonDoubleClickEvent__DelegateSignature", GSOnMouseButtonDoubleClickEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPointerEvent InMouseEvent)
	{
		if (!GSOnMouseButtonDoubleClickEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnMouseButtonDoubleClickEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnMouseButtonDoubleClickEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_Offset), 0, GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, InMouseEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnMouseButtonDoubleClickEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
		}
	}
}
