using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemDragDetected__DelegateSignature")]
public class FOnItemDragDetected : FMulticastDelegate<FOnItemDragDetected.Signature>
{
	public delegate void Signature(Guid ItemDraggedID, string ItemDraggedName);

	private static bool OnItemDragDetected__DelegateSignature_IsValid;

	private static IntPtr OnItemDragDetected__DelegateSignature_FunctionAddress;

	private static int OnItemDragDetected__DelegateSignature_ParamsSize;

	private static bool OnItemDragDetected__DelegateSignature_ItemDraggedID_IsValid;

	private static FFieldAddress OnItemDragDetected__DelegateSignature_ItemDraggedID_PropertyAddress;

	private static int OnItemDragDetected__DelegateSignature_ItemDraggedID_Offset;

	private static bool OnItemDragDetected__DelegateSignature_ItemDraggedName_IsValid;

	private static FFieldAddress OnItemDragDetected__DelegateSignature_ItemDraggedName_PropertyAddress;

	private static int OnItemDragDetected__DelegateSignature_ItemDraggedName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemDragDetected()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemDragDetected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemDragDetected__DelegateSignature");
		OnItemDragDetected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemDragDetected__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemDragDetected__DelegateSignature_ItemDraggedID_PropertyAddress, OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedID");
		OnItemDragDetected__DelegateSignature_ItemDraggedID_Offset = NativeReflectionCached.GetPropertyOffset(OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedID");
		OnItemDragDetected__DelegateSignature_ItemDraggedID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnItemDragDetected__DelegateSignature_ItemDraggedName_PropertyAddress, OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedName");
		OnItemDragDetected__DelegateSignature_ItemDraggedName_Offset = NativeReflectionCached.GetPropertyOffset(OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedName");
		OnItemDragDetected__DelegateSignature_ItemDraggedName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemDragDetected__DelegateSignature_FunctionAddress, "ItemDraggedName", Classes.FStrProperty);
		OnItemDragDetected__DelegateSignature_IsValid = OnItemDragDetected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemDragDetected__DelegateSignature_ItemDraggedID_IsValid && OnItemDragDetected__DelegateSignature_ItemDraggedName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemDragDetected__DelegateSignature", OnItemDragDetected__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(Guid ItemDraggedID, string ItemDraggedName)
	{
		if (!OnItemDragDetected__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemDragDetected__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemDragDetected__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemDragDetected__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, OnItemDragDetected__DelegateSignature_ItemDraggedID_Offset), 0, OnItemDragDetected__DelegateSignature_ItemDraggedID_PropertyAddress.Address, ItemDraggedID);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnItemDragDetected__DelegateSignature_ItemDraggedName_Offset), 0, OnItemDragDetected__DelegateSignature_ItemDraggedName_PropertyAddress.Address, ItemDraggedName);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnItemDragDetected__DelegateSignature_ItemDraggedName_PropertyAddress.Address, intPtr);
		}
	}
}
