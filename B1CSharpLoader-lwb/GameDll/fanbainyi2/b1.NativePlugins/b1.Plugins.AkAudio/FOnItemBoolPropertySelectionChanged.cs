using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature")]
public class FOnItemBoolPropertySelectionChanged : FMulticastDelegate<FOnItemBoolPropertySelectionChanged.Signature>
{
	public delegate void Signature(string PropertySelected);

	private static bool OnItemBoolPropertySelectionChanged__DelegateSignature_IsValid;

	private static IntPtr OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress;

	private static int OnItemBoolPropertySelectionChanged__DelegateSignature_ParamsSize;

	private static bool OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid;

	private static FFieldAddress OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress;

	private static int OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemBoolPropertySelectionChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature");
		OnItemBoolPropertySelectionChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress, OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected");
		OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_Offset = NativeReflectionCached.GetPropertyOffset(OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected");
		OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected", Classes.FStrProperty);
		OnItemBoolPropertySelectionChanged__DelegateSignature_IsValid = OnItemBoolPropertySelectionChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature", OnItemBoolPropertySelectionChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertySelected)
	{
		if (!OnItemBoolPropertySelectionChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemBoolPropertySelectionChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemBoolPropertySelectionChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_Offset), 0, OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress.Address, PropertySelected);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnItemBoolPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress.Address, intPtr);
		}
	}
}
