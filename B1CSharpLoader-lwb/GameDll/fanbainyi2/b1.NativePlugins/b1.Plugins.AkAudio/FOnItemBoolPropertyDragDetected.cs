using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature")]
public class FOnItemBoolPropertyDragDetected : FMulticastDelegate<FOnItemBoolPropertyDragDetected.Signature>
{
	public delegate void Signature(string PropertyDragged);

	private static bool OnItemBoolPropertyDragDetected__DelegateSignature_IsValid;

	private static IntPtr OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress;

	private static int OnItemBoolPropertyDragDetected__DelegateSignature_ParamsSize;

	private static bool OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid;

	private static FFieldAddress OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress;

	private static int OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemBoolPropertyDragDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature");
		OnItemBoolPropertyDragDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress, OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged");
		OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_Offset = NativeReflectionCached.GetPropertyOffset(OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged");
		OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress, "PropertyDragged", Classes.FStrProperty);
		OnItemBoolPropertyDragDetected__DelegateSignature_IsValid = OnItemBoolPropertyDragDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature", OnItemBoolPropertyDragDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertyDragged)
	{
		if (!OnItemBoolPropertyDragDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemBoolPropertyDragDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemBoolPropertyDragDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_Offset), 0, OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress.Address, PropertyDragged);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnItemBoolPropertyDragDetected__DelegateSignature_PropertyDragged_PropertyAddress.Address, intPtr);
		}
	}
}
