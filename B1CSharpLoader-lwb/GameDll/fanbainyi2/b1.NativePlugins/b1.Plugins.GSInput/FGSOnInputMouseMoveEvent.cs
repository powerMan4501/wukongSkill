using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputMouseMoveEvent__DelegateSignature")]
public class FGSOnInputMouseMoveEvent : FMulticastDelegate<FGSOnInputMouseMoveEvent.Signature>
{
	public delegate void Signature(FVector2D InMousePos);

	private static bool GSOnInputMouseMoveEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputMouseMoveEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_IsValid;

	private static FFieldAddress GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_PropertyAddress;

	private static int GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputMouseMoveEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputMouseMoveEvent__DelegateSignature");
		GSOnInputMouseMoveEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_PropertyAddress, GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress, "InMousePos");
		GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress, "InMousePos");
		GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress, "InMousePos", Classes.FStructProperty);
		GSOnInputMouseMoveEvent__DelegateSignature_IsValid = GSOnInputMouseMoveEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputMouseMoveEvent__DelegateSignature", GSOnInputMouseMoveEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FVector2D InMousePos)
	{
		if (!GSOnInputMouseMoveEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputMouseMoveEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputMouseMoveEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputMouseMoveEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_Offset), 0, GSOnInputMouseMoveEvent__DelegateSignature_InMousePos_PropertyAddress.Address, InMousePos);
			ProcessDelegate(intPtr);
		}
	}
}
