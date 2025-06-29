using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptRichTextBlockHyperlinkDecorator : URichTextBlockDecorator
{
	private static bool OnClick_IsValid;

	private static int OnClick_Offset;

	private FJavascriptHyperlinkSignature OnClick_DelegateCached;

	private static bool GetMetadata_IsValid;

	private static IntPtr GetMetadata_FunctionAddress;

	private static int GetMetadata_ParamsSize;

	private static bool GetMetadata_Key_IsValid;

	private static FFieldAddress GetMetadata_Key_PropertyAddress;

	private static int GetMetadata_Key_Offset;

	private static bool GetMetadata_ReturnValue_IsValid;

	private static FFieldAddress GetMetadata_ReturnValue_PropertyAddress;

	private static int GetMetadata_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator:OnClick")]
	public FJavascriptHyperlinkSignature OnClick
	{
		get
		{
			CheckDestroyed();
			if (!OnClick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator:OnClick");
				return new FJavascriptHyperlinkSignature();
			}
			if (OnClick_DelegateCached == null)
			{
				OnClick_DelegateCached = new FJavascriptHyperlinkSignature();
				OnClick_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClick_Offset));
			}
			return OnClick_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator:GetMetadata")]
	public unsafe string GetMetadata(string Key)
	{
		CheckDestroyed();
		if (!GetMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator:GetMetadata");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMetadata_Key_Offset), 0, GetMetadata_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMetadata_FunctionAddress, intPtr, GetMetadata_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMetadata_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMetadata_ReturnValue_Offset), 0, GetMetadata_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMetadata_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UJavascriptRichTextBlockHyperlinkDecorator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptRichTextBlockHyperlinkDecorator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptRichTextBlockHyperlinkDecorator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator");
		OnClick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnClick");
		OnClick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnClick", Classes.FMulticastDelegateProperty);
		GetMetadata_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMetadata");
		GetMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetadata_Key_PropertyAddress, GetMetadata_FunctionAddress, "Key");
		GetMetadata_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadata_FunctionAddress, "Key");
		GetMetadata_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadata_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetadata_ReturnValue_PropertyAddress, GetMetadata_FunctionAddress, "ReturnValue");
		GetMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadata_FunctionAddress, "ReturnValue");
		GetMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadata_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMetadata_IsValid = GetMetadata_FunctionAddress != IntPtr.Zero && GetMetadata_Key_IsValid && GetMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptRichTextBlockHyperlinkDecorator:GetMetadata", GetMetadata_IsValid);
	}
}
