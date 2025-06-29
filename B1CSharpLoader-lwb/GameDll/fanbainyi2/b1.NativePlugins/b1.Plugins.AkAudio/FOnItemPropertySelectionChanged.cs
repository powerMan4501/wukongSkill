using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature")]
public class FOnItemPropertySelectionChanged : FMulticastDelegate<FOnItemPropertySelectionChanged.Signature>
{
	public delegate void Signature(string PropertySelected);

	private static bool OnItemPropertySelectionChanged__DelegateSignature_IsValid;

	private static IntPtr OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress;

	private static int OnItemPropertySelectionChanged__DelegateSignature_ParamsSize;

	private static bool OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid;

	private static FFieldAddress OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress;

	private static int OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemPropertySelectionChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature");
		OnItemPropertySelectionChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress, OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected");
		OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_Offset = NativeReflectionCached.GetPropertyOffset(OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected");
		OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress, "PropertySelected", Classes.FStrProperty);
		OnItemPropertySelectionChanged__DelegateSignature_IsValid = OnItemPropertySelectionChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature", OnItemPropertySelectionChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string PropertySelected)
	{
		if (!OnItemPropertySelectionChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemPropertySelectionChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemPropertySelectionChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_Offset), 0, OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress.Address, PropertySelected);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnItemPropertySelectionChanged__DelegateSignature_PropertySelected_PropertyAddress.Address, intPtr);
		}
	}
}
