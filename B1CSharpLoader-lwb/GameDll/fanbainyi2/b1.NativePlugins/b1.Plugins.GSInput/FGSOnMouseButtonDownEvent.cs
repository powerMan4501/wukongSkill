using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnMouseButtonDownEvent__DelegateSignature")]
public class FGSOnMouseButtonDownEvent : FMulticastDelegate<FGSOnMouseButtonDownEvent.Signature>
{
	public delegate void Signature(FPointerEvent InMouseEvent);

	private static bool GSOnMouseButtonDownEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress;

	private static int GSOnMouseButtonDownEvent__DelegateSignature_ParamsSize;

	private static bool GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_IsValid;

	private static FFieldAddress GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_PropertyAddress;

	private static int GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnMouseButtonDownEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnMouseButtonDownEvent__DelegateSignature");
		GSOnMouseButtonDownEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_PropertyAddress, GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		GSOnMouseButtonDownEvent__DelegateSignature_IsValid = GSOnMouseButtonDownEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnMouseButtonDownEvent__DelegateSignature", GSOnMouseButtonDownEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPointerEvent InMouseEvent)
	{
		if (!GSOnMouseButtonDownEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnMouseButtonDownEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnMouseButtonDownEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnMouseButtonDownEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_Offset), 0, GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, InMouseEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnMouseButtonDownEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
		}
	}
}
