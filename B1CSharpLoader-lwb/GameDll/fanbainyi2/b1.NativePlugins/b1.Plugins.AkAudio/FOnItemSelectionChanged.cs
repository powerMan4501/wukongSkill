using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemSelectionChanged__DelegateSignature")]
public class FOnItemSelectionChanged : FMulticastDelegate<FOnItemSelectionChanged.Signature>
{
	public delegate void Signature(Guid ItemSelectedID);

	private static bool OnItemSelectionChanged__DelegateSignature_IsValid;

	private static IntPtr OnItemSelectionChanged__DelegateSignature_FunctionAddress;

	private static int OnItemSelectionChanged__DelegateSignature_ParamsSize;

	private static bool OnItemSelectionChanged__DelegateSignature_ItemSelectedID_IsValid;

	private static FFieldAddress OnItemSelectionChanged__DelegateSignature_ItemSelectedID_PropertyAddress;

	private static int OnItemSelectionChanged__DelegateSignature_ItemSelectedID_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemSelectionChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemSelectionChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemSelectionChanged__DelegateSignature");
		OnItemSelectionChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemSelectionChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemSelectionChanged__DelegateSignature_ItemSelectedID_PropertyAddress, OnItemSelectionChanged__DelegateSignature_FunctionAddress, "ItemSelectedID");
		OnItemSelectionChanged__DelegateSignature_ItemSelectedID_Offset = NativeReflectionCached.GetPropertyOffset(OnItemSelectionChanged__DelegateSignature_FunctionAddress, "ItemSelectedID");
		OnItemSelectionChanged__DelegateSignature_ItemSelectedID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemSelectionChanged__DelegateSignature_FunctionAddress, "ItemSelectedID", Classes.FStructProperty);
		OnItemSelectionChanged__DelegateSignature_IsValid = OnItemSelectionChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemSelectionChanged__DelegateSignature_ItemSelectedID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemSelectionChanged__DelegateSignature", OnItemSelectionChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(Guid ItemSelectedID)
	{
		if (!OnItemSelectionChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemSelectionChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemSelectionChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemSelectionChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, OnItemSelectionChanged__DelegateSignature_ItemSelectedID_Offset), 0, OnItemSelectionChanged__DelegateSignature_ItemSelectedID_PropertyAddress.Address, ItemSelectedID);
			ProcessDelegate(intPtr);
		}
	}
}
