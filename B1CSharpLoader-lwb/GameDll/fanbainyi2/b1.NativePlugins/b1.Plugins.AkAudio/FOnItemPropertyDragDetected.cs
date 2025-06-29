using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature")]
public class FOnItemPropertyDragDetected : FMulticastDelegate<FOnItemPropertyDragDetected.Signature>
{
	public delegate void Signature(string PropertyDragged);

	private static bool OnItemPropertyDragDetected__DelegateSignature_IsValid;

	private static IntPtr OnItemPropertyDragDetected__DelegateSignature_FunctionAddress;

	private static int OnItemPropertyDragDetected__DelegateSignature_ParamsSize;

	private static bool OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid;

	private static FFieldAddress OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress;

	private static int OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemPropertyDragDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemPropertyDragDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature");
		OnItemPropertyDragDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemPropertyDragDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress, OnItemPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged");
		OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_Offset = NativeReflectionCached.GetPropertyOffset(OnItemPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged");
		OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged", Classes.FStrProperty);
		OnItemPropertyDragDetected__DelegateSignature_IsValid = OnItemPropertyDragDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature", OnItemPropertyDragDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertyDragged)
	{
		if (!OnItemPropertyDragDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemPropertyDragDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemPropertyDragDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_Offset), 0, OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress.Address, PropertyDragged);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnItemPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress.Address, intPtr);
		}
	}
}
