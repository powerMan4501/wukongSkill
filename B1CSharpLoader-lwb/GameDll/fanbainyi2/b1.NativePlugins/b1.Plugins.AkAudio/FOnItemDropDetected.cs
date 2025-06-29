using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemDropDetected__DelegateSignature")]
public class FOnItemDropDetected : FMulticastDelegate<FOnItemDropDetected.Signature>
{
	public delegate void Signature(Guid ItemDroppedID);

	private static bool OnItemDropDetected__DelegateSignature_IsValid;

	private static IntPtr OnItemDropDetected__DelegateSignature_FunctionAddress;

	private static int OnItemDropDetected__DelegateSignature_ParamsSize;

	private static bool OnItemDropDetected__DelegateSignature_ItemDroppedID_IsValid;

	private static FFieldAddress OnItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress;

	private static int OnItemDropDetected__DelegateSignature_ItemDroppedID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemDropDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemDropDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemDropDetected__DelegateSignature");
		OnItemDropDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemDropDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress, OnItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID");
		OnItemDropDetected__DelegateSignature_ItemDroppedID_Offset = NativeReflectionCached.GetPropertyOffset(OnItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID");
		OnItemDropDetected__DelegateSignature_ItemDroppedID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID", Classes.FStructProperty);
		OnItemDropDetected__DelegateSignature_IsValid = OnItemDropDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemDropDetected__DelegateSignature_ItemDroppedID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemDropDetected__DelegateSignature", OnItemDropDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(Guid ItemDroppedID)
	{
		if (!OnItemDropDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemDropDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemDropDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemDropDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, OnItemDropDetected__DelegateSignature_ItemDroppedID_Offset), 0, OnItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress.Address, ItemDroppedID);
			ProcessDelegate(intPtr);
		}
	}
}
