using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UDelegate]
[UMetaPath("/Script/JavascriptUMG.JavascriptHyperlinkSignature__DelegateSignature")]
public class FJavascriptHyperlinkSignature : FMulticastDelegate<FJavascriptHyperlinkSignature.Signature>
{
	public delegate void Signature(UJavascriptRichTextBlockHyperlinkDecorator Self);

	private static bool JavascriptHyperlinkSignature__DelegateSignature_IsValid;

	private static IntPtr JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress;

	private static int JavascriptHyperlinkSignature__DelegateSignature_ParamsSize;

	private static bool JavascriptHyperlinkSignature__DelegateSignature_Self_IsValid;

	private static FFieldAddress JavascriptHyperlinkSignature__DelegateSignature_Self_PropertyAddress;

	private static int JavascriptHyperlinkSignature__DelegateSignature_Self_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FJavascriptHyperlinkSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptHyperlinkSignature__DelegateSignature");
		JavascriptHyperlinkSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JavascriptHyperlinkSignature__DelegateSignature_Self_PropertyAddress, JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress, "Self");
		JavascriptHyperlinkSignature__DelegateSignature_Self_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress, "Self");
		JavascriptHyperlinkSignature__DelegateSignature_Self_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress, "Self", Classes.FObjectProperty);
		JavascriptHyperlinkSignature__DelegateSignature_IsValid = JavascriptHyperlinkSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptHyperlinkSignature__DelegateSignature_Self_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptHyperlinkSignature__DelegateSignature", JavascriptHyperlinkSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UJavascriptRichTextBlockHyperlinkDecorator Self)
	{
		if (!JavascriptHyperlinkSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptHyperlinkSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(JavascriptHyperlinkSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptHyperlinkSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UJavascriptRichTextBlockHyperlinkDecorator>.ToNative(IntPtr.Add(intPtr, JavascriptHyperlinkSignature__DelegateSignature_Self_Offset), 0, JavascriptHyperlinkSignature__DelegateSignature_Self_PropertyAddress.Address, Self);
			ProcessDelegate(intPtr);
		}
	}
}
