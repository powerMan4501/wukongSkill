using System;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UDelegate]
[UMetaPath("/Script/JavascriptEditor.OnGenerateInvalidCellWidget__DelegateSignature")]
public class FOnGenerateInvalidCellWidget : FDelegate<FOnGenerateInvalidCellWidget.Signature>
{
	public delegate FJavascriptSlateWidget Signature();

	private static bool OnGenerateInvalidCellWidget__DelegateSignature_IsValid;

	private static IntPtr OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress;

	private static int OnGenerateInvalidCellWidget__DelegateSignature_ParamsSize;

	private static bool OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_PropertyAddress;

	private static int OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnGenerateInvalidCellWidget()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.OnGenerateInvalidCellWidget__DelegateSignature");
		OnGenerateInvalidCellWidget__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_PropertyAddress, OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress, "ReturnValue");
		OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress, "ReturnValue");
		OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnGenerateInvalidCellWidget__DelegateSignature_IsValid = OnGenerateInvalidCellWidget__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.OnGenerateInvalidCellWidget__DelegateSignature", OnGenerateInvalidCellWidget__DelegateSignature_IsValid);
	}

	private unsafe FJavascriptSlateWidget Invoker()
	{
		if (!OnGenerateInvalidCellWidget__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.OnGenerateInvalidCellWidget__DelegateSignature");
			return default(FJavascriptSlateWidget);
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnGenerateInvalidCellWidget__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGenerateInvalidCellWidget__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			ProcessDelegate(intPtr);
			FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_Offset), 0, OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_PropertyAddress.Address);
			NativeReflection.DestroyValue_InContainer(OnGenerateInvalidCellWidget__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
			return result;
		}
		return default(FJavascriptSlateWidget);
	}
}
