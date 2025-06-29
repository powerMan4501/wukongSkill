using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptLazyExtenderDelegates : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:JavascriptGetExtender__DelegateSignature")]
	public class FJavascriptGetExtender : FDelegate<FJavascriptGetExtender.Signature>
	{
		public delegate FJavascriptExtender Signature(FJavascriptUICommandList List, List<UObject> EditingObjects);

		private static bool JavascriptGetExtender__DelegateSignature_IsValid;

		private static IntPtr JavascriptGetExtender__DelegateSignature_FunctionAddress;

		private static int JavascriptGetExtender__DelegateSignature_ParamsSize;

		private static bool JavascriptGetExtender__DelegateSignature_List_IsValid;

		private static FFieldAddress JavascriptGetExtender__DelegateSignature_List_PropertyAddress;

		private static int JavascriptGetExtender__DelegateSignature_List_Offset;

		private static bool JavascriptGetExtender__DelegateSignature_EditingObjects_IsValid;

		private static FFieldAddress JavascriptGetExtender__DelegateSignature_EditingObjects_PropertyAddress;

		private static int JavascriptGetExtender__DelegateSignature_EditingObjects_Offset;

		private static bool JavascriptGetExtender__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress JavascriptGetExtender__DelegateSignature_ReturnValue_PropertyAddress;

		private static int JavascriptGetExtender__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptGetExtender()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptGetExtender__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:JavascriptGetExtender__DelegateSignature");
			JavascriptGetExtender__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptGetExtender__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptGetExtender__DelegateSignature_List_PropertyAddress, JavascriptGetExtender__DelegateSignature_FunctionAddress, "List");
			JavascriptGetExtender__DelegateSignature_List_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptGetExtender__DelegateSignature_FunctionAddress, "List");
			JavascriptGetExtender__DelegateSignature_List_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptGetExtender__DelegateSignature_FunctionAddress, "List", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref JavascriptGetExtender__DelegateSignature_EditingObjects_PropertyAddress, JavascriptGetExtender__DelegateSignature_FunctionAddress, "EditingObjects");
			JavascriptGetExtender__DelegateSignature_EditingObjects_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptGetExtender__DelegateSignature_FunctionAddress, "EditingObjects");
			JavascriptGetExtender__DelegateSignature_EditingObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptGetExtender__DelegateSignature_FunctionAddress, "EditingObjects", Classes.FArrayProperty);
			NativeReflectionCached.GetPropertyRef(ref JavascriptGetExtender__DelegateSignature_ReturnValue_PropertyAddress, JavascriptGetExtender__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptGetExtender__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptGetExtender__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptGetExtender__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptGetExtender__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			JavascriptGetExtender__DelegateSignature_IsValid = JavascriptGetExtender__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptGetExtender__DelegateSignature_List_IsValid && JavascriptGetExtender__DelegateSignature_EditingObjects_IsValid && JavascriptGetExtender__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:JavascriptGetExtender__DelegateSignature", JavascriptGetExtender__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptExtender Invoker(FJavascriptUICommandList List, List<UObject> EditingObjects)
		{
			if (!JavascriptGetExtender__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:JavascriptGetExtender__DelegateSignature");
				return default(FJavascriptExtender);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptGetExtender__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptGetExtender__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(JavascriptGetExtender__DelegateSignature_List_PropertyAddress.Address, intPtr);
				FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, JavascriptGetExtender__DelegateSignature_List_Offset), 0, JavascriptGetExtender__DelegateSignature_List_PropertyAddress.Address, List);
				new TArrayCopyMarshaler<UObject>(1, JavascriptGetExtender__DelegateSignature_EditingObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, JavascriptGetExtender__DelegateSignature_EditingObjects_Offset), EditingObjects);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(JavascriptGetExtender__DelegateSignature_List_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(JavascriptGetExtender__DelegateSignature_EditingObjects_PropertyAddress.Address, intPtr);
				FJavascriptExtender result = FJavascriptExtender.FromNative(IntPtr.Add(intPtr, JavascriptGetExtender__DelegateSignature_ReturnValue_Offset), 0, JavascriptGetExtender__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(JavascriptGetExtender__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FJavascriptExtender);
		}
	}

	private static bool GetExtender_IsValid;

	private static int GetExtender_Offset;

	private FJavascriptGetExtender GetExtender_DelegateCached;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:GetExtender")]
	public FJavascriptGetExtender GetExtender
	{
		get
		{
			CheckDestroyed();
			if (!GetExtender_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates:GetExtender");
				return new FJavascriptGetExtender();
			}
			if (GetExtender_DelegateCached == null)
			{
				GetExtender_DelegateCached = new FJavascriptGetExtender();
				GetExtender_DelegateCached.SetAddress(IntPtr.Add(base.Address, GetExtender_Offset));
			}
			return GetExtender_DelegateCached;
		}
	}

	static UJavascriptLazyExtenderDelegates()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptLazyExtenderDelegates)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptLazyExtenderDelegates));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptLazyExtenderDelegates");
		GetExtender_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GetExtender");
		GetExtender_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GetExtender", Classes.FDelegateProperty);
	}
}
