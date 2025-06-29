using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature")]
public class FOnWwiseItemDropDetected : FMulticastDelegate<FOnWwiseItemDropDetected.Signature>
{
	public delegate void Signature(Guid ItemDroppedID);

	private static bool OnWwiseItemDropDetected__DelegateSignature_IsValid;

	private static IntPtr OnWwiseItemDropDetected__DelegateSignature_FunctionAddress;

	private static int OnWwiseItemDropDetected__DelegateSignature_ParamsSize;

	private static bool OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_IsValid;

	private static FFieldAddress OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress;

	private static int OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnWwiseItemDropDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnWwiseItemDropDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature");
		OnWwiseItemDropDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWwiseItemDropDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress, OnWwiseItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID");
		OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_Offset = NativeReflectionCached.GetPropertyOffset(OnWwiseItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID");
		OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWwiseItemDropDetected__DelegateSignature_FunctionAddress, "ItemDroppedID", Classes.FStructProperty);
		OnWwiseItemDropDetected__DelegateSignature_IsValid = OnWwiseItemDropDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature", OnWwiseItemDropDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(Guid ItemDroppedID)
	{
		if (!OnWwiseItemDropDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnWwiseItemDropDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWwiseItemDropDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_Offset), 0, OnWwiseItemDropDetected__DelegateSignature_ItemDroppedID_PropertyAddress.Address, ItemDroppedID);
			ProcessDelegate(intPtr);
		}
	}
}
