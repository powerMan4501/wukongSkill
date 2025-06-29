using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnMouseButtonUpEvent__DelegateSignature")]
public class FGSOnMouseButtonUpEvent : FMulticastDelegate<FGSOnMouseButtonUpEvent.Signature>
{
	public delegate void Signature(FPointerEvent InMouseEvent);

	private static bool GSOnMouseButtonUpEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress;

	private static int GSOnMouseButtonUpEvent__DelegateSignature_ParamsSize;

	private static bool GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_IsValid;

	private static FFieldAddress GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_PropertyAddress;

	private static int GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnMouseButtonUpEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnMouseButtonUpEvent__DelegateSignature");
		GSOnMouseButtonUpEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_PropertyAddress, GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InMouseEvent");
		GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		GSOnMouseButtonUpEvent__DelegateSignature_IsValid = GSOnMouseButtonUpEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnMouseButtonUpEvent__DelegateSignature", GSOnMouseButtonUpEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FPointerEvent InMouseEvent)
	{
		if (!GSOnMouseButtonUpEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnMouseButtonUpEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnMouseButtonUpEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnMouseButtonUpEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
			StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_Offset), 0, GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, InMouseEvent);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnMouseButtonUpEvent__DelegateSignature_InMouseEvent_PropertyAddress.Address, intPtr);
		}
	}
}
