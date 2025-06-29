using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptGraphEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptGraphTextPropertyEditableTextBox : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin__DelegateSignature")]
	public class FOnGetGraphPin : FDelegate<FOnGetGraphPin.Signature>
	{
		public delegate FJavascriptEdGraphPin Signature();

		private static bool OnGetGraphPin__DelegateSignature_IsValid;

		private static IntPtr OnGetGraphPin__DelegateSignature_FunctionAddress;

		private static int OnGetGraphPin__DelegateSignature_ParamsSize;

		private static bool OnGetGraphPin__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetGraphPin__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetGraphPin__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetGraphPin()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetGraphPin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin__DelegateSignature");
			OnGetGraphPin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetGraphPin__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetGraphPin__DelegateSignature_ReturnValue_PropertyAddress, OnGetGraphPin__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetGraphPin__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetGraphPin__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetGraphPin__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetGraphPin__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnGetGraphPin__DelegateSignature_IsValid = OnGetGraphPin__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetGraphPin__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin__DelegateSignature", OnGetGraphPin__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptEdGraphPin Invoker()
		{
			if (!OnGetGraphPin__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin__DelegateSignature");
				return default(FJavascriptEdGraphPin);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetGraphPin__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetGraphPin__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return FJavascriptEdGraphPin.FromNative(IntPtr.Add(intPtr, OnGetGraphPin__DelegateSignature_ReturnValue_Offset), 0, OnGetGraphPin__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FJavascriptEdGraphPin);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue__DelegateSignature")]
	public class FOnGetDefaultValue : FDelegate<FOnGetDefaultValue.Signature>
	{
		public delegate FJavascriptTextProperty Signature();

		private static bool OnGetDefaultValue__DelegateSignature_IsValid;

		private static IntPtr OnGetDefaultValue__DelegateSignature_FunctionAddress;

		private static int OnGetDefaultValue__DelegateSignature_ParamsSize;

		private static bool OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetDefaultValue__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetDefaultValue()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetDefaultValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue__DelegateSignature");
			OnGetDefaultValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetDefaultValue__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress, OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetDefaultValue__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnGetDefaultValue__DelegateSignature_IsValid = OnGetDefaultValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue__DelegateSignature", OnGetDefaultValue__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptTextProperty Invoker()
		{
			if (!OnGetDefaultValue__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue__DelegateSignature");
				return default(FJavascriptTextProperty);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetDefaultValue__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetDefaultValue__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FJavascriptTextProperty result = FJavascriptTextProperty.FromNative(IntPtr.Add(intPtr, OnGetDefaultValue__DelegateSignature_ReturnValue_Offset), 0, OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FJavascriptTextProperty);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature")]
	public class FOnEditableTextBoxCommittedEvent : FMulticastDelegate<FOnEditableTextBoxCommittedEvent.Signature>
	{
		public delegate void Signature(FJavascriptTextProperty TextProperty);

		private static bool OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_IsValid;

		private static FFieldAddress OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_PropertyAddress;

		private static int OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnEditableTextBoxCommittedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature");
			OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_PropertyAddress, OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "TextProperty");
			OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "TextProperty");
			OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "TextProperty", Classes.FStructProperty);
			OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid = OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature", OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FJavascriptTextProperty TextProperty)
		{
			if (!OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_PropertyAddress.Address, intPtr);
				FJavascriptTextProperty.ToNative(IntPtr.Add(intPtr, OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_Offset), 0, OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_PropertyAddress.Address, TextProperty);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnEditableTextBoxCommittedEvent__DelegateSignature_TextProperty_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool OnGetGraphPin_IsValid;

	private static int OnGetGraphPin_Offset;

	private FOnGetGraphPin OnGetGraphPin_DelegateCached;

	private static bool OnGetDefaultValue_IsValid;

	private static int OnGetDefaultValue_Offset;

	private FOnGetDefaultValue OnGetDefaultValue_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnEditableTextBoxCommittedEvent OnTextCommitted_DelegateCached;

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool WrapTextAt_IsValid;

	private static int WrapTextAt_Offset;

	private static bool AutoWrapText_IsValid;

	private static FFieldAddress AutoWrapText_PropertyAddress;

	private static int AutoWrapText_Offset;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin")]
	public FOnGetGraphPin OnGetGraphPin
	{
		get
		{
			CheckDestroyed();
			if (!OnGetGraphPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetGraphPin");
				return new FOnGetGraphPin();
			}
			if (OnGetGraphPin_DelegateCached == null)
			{
				OnGetGraphPin_DelegateCached = new FOnGetGraphPin();
				OnGetGraphPin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetGraphPin_Offset));
			}
			return OnGetGraphPin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue")]
	public FOnGetDefaultValue OnGetDefaultValue
	{
		get
		{
			CheckDestroyed();
			if (!OnGetDefaultValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnGetDefaultValue");
				return new FOnGetDefaultValue();
			}
			if (OnGetDefaultValue_DelegateCached == null)
			{
				OnGetDefaultValue_DelegateCached = new FOnGetDefaultValue();
				OnGetDefaultValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetDefaultValue_Offset));
			}
			return OnGetDefaultValue_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnTextCommitted")]
	public FOnEditableTextBoxCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:OnTextCommitted");
				return new FOnEditableTextBoxCommittedEvent();
			}
			if (OnTextCommitted_DelegateCached == null)
			{
				OnTextCommitted_DelegateCached = new FOnEditableTextBoxCommittedEvent();
				OnTextCommitted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextCommitted_Offset));
			}
			return OnTextCommitted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WidgetStyle")]
	public FEditableTextBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WidgetStyle");
				return default(FEditableTextBoxStyle);
			}
			return FEditableTextBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WidgetStyle");
			}
			else
			{
				FEditableTextBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WrapTextAt")]
	public float WrapTextAt
	{
		get
		{
			CheckDestroyed();
			if (!WrapTextAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WrapTextAt");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WrapTextAt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WrapTextAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:WrapTextAt");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WrapTextAt_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:AutoWrapText")]
	public bool AutoWrapText
	{
		get
		{
			CheckDestroyed();
			if (!AutoWrapText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:AutoWrapText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoWrapText_Offset), 0, AutoWrapText_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoWrapText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox:AutoWrapText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoWrapText_Offset), 0, AutoWrapText_PropertyAddress.Address, value);
			}
		}
	}

	static UJavascriptGraphTextPropertyEditableTextBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptGraphTextPropertyEditableTextBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptGraphTextPropertyEditableTextBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/JavascriptGraphEditor.JavascriptGraphTextPropertyEditableTextBox");
		OnGetGraphPin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetGraphPin");
		OnGetGraphPin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetGraphPin", Classes.FDelegateProperty);
		OnGetDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetDefaultValue");
		OnGetDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetDefaultValue", Classes.FDelegateProperty);
		OnTextCommitted_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnTextCommitted");
		OnTextCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnTextCommitted", Classes.FMulticastDelegateProperty);
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WidgetStyle", Classes.FStructProperty);
		WrapTextAt_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WrapTextAt");
		WrapTextAt_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WrapTextAt", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoWrapText_PropertyAddress, unrealStruct, "AutoWrapText");
		AutoWrapText_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AutoWrapText");
		AutoWrapText_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AutoWrapText", Classes.FBoolProperty);
	}
}
