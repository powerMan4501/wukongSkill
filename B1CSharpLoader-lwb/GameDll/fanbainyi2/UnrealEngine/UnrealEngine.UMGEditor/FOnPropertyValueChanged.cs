using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UDelegate]
[UMetaPath("/Script/UMGEditor.OnPropertyValueChanged__DelegateSignature")]
public class FOnPropertyValueChanged : FMulticastDelegate<FOnPropertyValueChanged.Signature>
{
	public delegate void Signature(FName PropertyName);

	private static bool OnPropertyValueChanged__DelegateSignature_IsValid;

	private static IntPtr OnPropertyValueChanged__DelegateSignature_FunctionAddress;

	private static int OnPropertyValueChanged__DelegateSignature_ParamsSize;

	private static bool OnPropertyValueChanged__DelegateSignature_PropertyName_IsValid;

	private static FFieldAddress OnPropertyValueChanged__DelegateSignature_PropertyName_PropertyAddress;

	private static int OnPropertyValueChanged__DelegateSignature_PropertyName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnPropertyValueChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnPropertyValueChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMGEditor.OnPropertyValueChanged__DelegateSignature");
		OnPropertyValueChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyValueChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyValueChanged__DelegateSignature_PropertyName_PropertyAddress, OnPropertyValueChanged__DelegateSignature_FunctionAddress, "PropertyName");
		OnPropertyValueChanged__DelegateSignature_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyValueChanged__DelegateSignature_FunctionAddress, "PropertyName");
		OnPropertyValueChanged__DelegateSignature_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyValueChanged__DelegateSignature_FunctionAddress, "PropertyName", Classes.FNameProperty);
		OnPropertyValueChanged__DelegateSignature_IsValid = OnPropertyValueChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPropertyValueChanged__DelegateSignature_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.OnPropertyValueChanged__DelegateSignature", OnPropertyValueChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName PropertyName)
	{
		if (!OnPropertyValueChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.OnPropertyValueChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnPropertyValueChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyValueChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnPropertyValueChanged__DelegateSignature_PropertyName_Offset), 0, OnPropertyValueChanged__DelegateSignature_PropertyName_PropertyAddress.Address, PropertyName);
			ProcessDelegate(intPtr);
		}
	}
}
