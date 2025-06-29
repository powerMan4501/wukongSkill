using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UDelegate]
[UMetaPath("/Script/GSInput.GSOnInputMouseWheelOrGestureEvent__DelegateSignature")]
public class FGSOnInputMouseWheelOrGestureEvent : FMulticastDelegate<FGSOnInputMouseWheelOrGestureEvent.Signature>
{
	public delegate void Signature(float InWheelDelta);

	private static bool GSOnInputMouseWheelOrGestureEvent__DelegateSignature_IsValid;

	private static IntPtr GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress;

	private static int GSOnInputMouseWheelOrGestureEvent__DelegateSignature_ParamsSize;

	private static bool GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_IsValid;

	private static FFieldAddress GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_PropertyAddress;

	private static int GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnInputMouseWheelOrGestureEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSInput.GSOnInputMouseWheelOrGestureEvent__DelegateSignature");
		GSOnInputMouseWheelOrGestureEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_PropertyAddress, GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress, "InWheelDelta");
		GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_Offset = NativeReflectionCached.GetPropertyOffset(GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress, "InWheelDelta");
		GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress, "InWheelDelta", Classes.FFloatProperty);
		GSOnInputMouseWheelOrGestureEvent__DelegateSignature_IsValid = GSOnInputMouseWheelOrGestureEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOnInputMouseWheelOrGestureEvent__DelegateSignature", GSOnInputMouseWheelOrGestureEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float InWheelDelta)
	{
		if (!GSOnInputMouseWheelOrGestureEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOnInputMouseWheelOrGestureEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnInputMouseWheelOrGestureEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnInputMouseWheelOrGestureEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_Offset), 0, GSOnInputMouseWheelOrGestureEvent__DelegateSignature_InWheelDelta_PropertyAddress.Address, InWheelDelta);
			ProcessDelegate(intPtr);
		}
	}
}
