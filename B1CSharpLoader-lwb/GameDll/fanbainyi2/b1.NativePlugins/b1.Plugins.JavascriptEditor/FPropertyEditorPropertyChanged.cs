using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UDelegate]
[UMetaPath("/Script/JavascriptEditor.PropertyEditorPropertyChanged__DelegateSignature")]
public class FPropertyEditorPropertyChanged : FMulticastDelegate<FPropertyEditorPropertyChanged.Signature>
{
	public delegate void Signature(FName PropertyName, FName MemberPropertyName);

	private static bool PropertyEditorPropertyChanged__DelegateSignature_IsValid;

	private static IntPtr PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress;

	private static int PropertyEditorPropertyChanged__DelegateSignature_ParamsSize;

	private static bool PropertyEditorPropertyChanged__DelegateSignature_PropertyName_IsValid;

	private static FFieldAddress PropertyEditorPropertyChanged__DelegateSignature_PropertyName_PropertyAddress;

	private static int PropertyEditorPropertyChanged__DelegateSignature_PropertyName_Offset;

	private static bool PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_IsValid;

	private static FFieldAddress PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_PropertyAddress;

	private static int PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPropertyEditorPropertyChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.PropertyEditorPropertyChanged__DelegateSignature");
		PropertyEditorPropertyChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PropertyEditorPropertyChanged__DelegateSignature_PropertyName_PropertyAddress, PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "PropertyName");
		PropertyEditorPropertyChanged__DelegateSignature_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "PropertyName");
		PropertyEditorPropertyChanged__DelegateSignature_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_PropertyAddress, PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "MemberPropertyName");
		PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "MemberPropertyName");
		PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress, "MemberPropertyName", Classes.FNameProperty);
		PropertyEditorPropertyChanged__DelegateSignature_IsValid = PropertyEditorPropertyChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && PropertyEditorPropertyChanged__DelegateSignature_PropertyName_IsValid && PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditorPropertyChanged__DelegateSignature", PropertyEditorPropertyChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName PropertyName, FName MemberPropertyName)
	{
		if (!PropertyEditorPropertyChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditorPropertyChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PropertyEditorPropertyChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PropertyEditorPropertyChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PropertyEditorPropertyChanged__DelegateSignature_PropertyName_Offset), 0, PropertyEditorPropertyChanged__DelegateSignature_PropertyName_PropertyAddress.Address, PropertyName);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_Offset), 0, PropertyEditorPropertyChanged__DelegateSignature_MemberPropertyName_PropertyAddress.Address, MemberPropertyName);
			ProcessDelegate(intPtr);
		}
	}
}
