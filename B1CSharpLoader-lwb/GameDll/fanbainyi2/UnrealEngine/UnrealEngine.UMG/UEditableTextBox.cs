using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.EditableTextBox", "UMG", UnrealModuleType.Engine)]
public class UEditableTextBox : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature")]
	public class FOnEditableTextBoxCommittedEvent : FMulticastDelegate<FOnEditableTextBoxCommittedEvent.Signature>
	{
		public delegate void Signature(FText Text, ETextCommit CommitMethod);

		private static bool OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset;

		private static bool OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid;

		private static FFieldAddress OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress;

		private static int OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset;

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
			OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature");
			OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid = OnEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid && OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature", OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text, ETextCommit CommitMethod)
		{
			if (!OnEditableTextBoxCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset), 0, OnEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				EnumMarshaler<ETextCommit>.ToNative(IntPtr.Add(intPtr, OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset), 0, OnEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress.Address, CommitMethod);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature")]
	public class FOnEditableTextBoxChangedEvent : FMulticastDelegate<FOnEditableTextBoxChangedEvent.Signature>
	{
		public delegate void Signature(FText Text);

		private static bool OnEditableTextBoxChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnEditableTextBoxChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnEditableTextBoxChangedEvent__DelegateSignature_Text_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnEditableTextBoxChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature");
			OnEditableTextBoxChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextBoxChangedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnEditableTextBoxChangedEvent__DelegateSignature_IsValid = OnEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature", OnEditableTextBoxChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnEditableTextBoxChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnEditableTextBoxChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditableTextBoxChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnEditableTextBoxChangedEvent__DelegateSignature_Text_Offset), 0, OnEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool HintText_IsValid;

	private static int HintText_Offset;

	private FText HintText_TextCached;

	private static bool IsReadOnly_IsValid;

	private static FFieldAddress IsReadOnly_PropertyAddress;

	private static int IsReadOnly_Offset;

	private static bool IsPassword_IsValid;

	private static FFieldAddress IsPassword_PropertyAddress;

	private static int IsPassword_Offset;

	private static bool MinimumDesiredWidth_IsValid;

	private static int MinimumDesiredWidth_Offset;

	private static bool IsCaretMovedWhenGainFocus_IsValid;

	private static FFieldAddress IsCaretMovedWhenGainFocus_PropertyAddress;

	private static int IsCaretMovedWhenGainFocus_Offset;

	private static bool SelectAllTextWhenFocused_IsValid;

	private static FFieldAddress SelectAllTextWhenFocused_PropertyAddress;

	private static int SelectAllTextWhenFocused_Offset;

	private static bool RevertTextOnEscape_IsValid;

	private static FFieldAddress RevertTextOnEscape_PropertyAddress;

	private static int RevertTextOnEscape_Offset;

	private static bool ClearKeyboardFocusOnCommit_IsValid;

	private static FFieldAddress ClearKeyboardFocusOnCommit_PropertyAddress;

	private static int ClearKeyboardFocusOnCommit_Offset;

	private static bool SelectAllTextOnCommit_IsValid;

	private static FFieldAddress SelectAllTextOnCommit_PropertyAddress;

	private static int SelectAllTextOnCommit_Offset;

	private static bool Justification_IsValid;

	private static FFieldAddress Justification_PropertyAddress;

	private static int Justification_Offset;

	private static bool OverflowPolicy_IsValid;

	private static FFieldAddress OverflowPolicy_PropertyAddress;

	private static int OverflowPolicy_Offset;

	private static bool ShapedTextOptions_IsValid;

	private static int ShapedTextOptions_Offset;

	private static bool OnTextChanged_IsValid;

	private static int OnTextChanged_Offset;

	private FOnEditableTextBoxChangedEvent OnTextChanged_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnEditableTextBoxCommittedEvent OnTextCommitted_DelegateCached;

	private static bool SetTextOverflowPolicy_IsValid;

	private static IntPtr SetTextOverflowPolicy_FunctionAddress;

	private static int SetTextOverflowPolicy_ParamsSize;

	private static bool SetTextOverflowPolicy_InOverflowPolicy_IsValid;

	private static FFieldAddress SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress;

	private static int SetTextOverflowPolicy_InOverflowPolicy_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_InText_IsValid;

	private static FFieldAddress SetText_InText_PropertyAddress;

	private static int SetText_InText_Offset;

	private static bool SetJustification_IsValid;

	private static IntPtr SetJustification_FunctionAddress;

	private static int SetJustification_ParamsSize;

	private static bool SetJustification_InJustification_IsValid;

	private static FFieldAddress SetJustification_InJustification_PropertyAddress;

	private static int SetJustification_InJustification_Offset;

	private static bool SetIsReadOnly_IsValid;

	private static IntPtr SetIsReadOnly_FunctionAddress;

	private static int SetIsReadOnly_ParamsSize;

	private static bool SetIsReadOnly_bReadOnly_IsValid;

	private static FFieldAddress SetIsReadOnly_bReadOnly_PropertyAddress;

	private static int SetIsReadOnly_bReadOnly_Offset;

	private static bool SetIsPassword_IsValid;

	private static IntPtr SetIsPassword_FunctionAddress;

	private static int SetIsPassword_ParamsSize;

	private static bool SetIsPassword_bIsPassword_IsValid;

	private static FFieldAddress SetIsPassword_bIsPassword_PropertyAddress;

	private static int SetIsPassword_bIsPassword_Offset;

	private static bool SetHintText_IsValid;

	private static IntPtr SetHintText_FunctionAddress;

	private static int SetHintText_ParamsSize;

	private static bool SetHintText_InText_IsValid;

	private static FFieldAddress SetHintText_InText_PropertyAddress;

	private static int SetHintText_InText_Offset;

	private static bool SetForegroundColor_IsValid;

	private static IntPtr SetForegroundColor_FunctionAddress;

	private static int SetForegroundColor_ParamsSize;

	private static bool SetForegroundColor_color_IsValid;

	private static FFieldAddress SetForegroundColor_color_PropertyAddress;

	private static int SetForegroundColor_color_Offset;

	private static bool SetError_IsValid;

	private static IntPtr SetError_FunctionAddress;

	private static int SetError_ParamsSize;

	private static bool SetError_InError_IsValid;

	private static FFieldAddress SetError_InError_PropertyAddress;

	private static int SetError_InError_Offset;

	private static bool HasError_IsValid;

	private static IntPtr HasError_FunctionAddress;

	private static int HasError_ParamsSize;

	private static bool HasError_ReturnValue_IsValid;

	private static FFieldAddress HasError_ReturnValue_PropertyAddress;

	private static int HasError_ReturnValue_Offset;

	private static bool GetText_IsValid;

	private static IntPtr GetText_FunctionAddress;

	private static int GetText_ParamsSize;

	private static bool GetText_ReturnValue_IsValid;

	private static FFieldAddress GetText_ReturnValue_PropertyAddress;

	private static int GetText_ReturnValue_Offset;

	private static bool ClearError_IsValid;

	private static IntPtr ClearError_FunctionAddress;

	private static int ClearError_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:WidgetStyle")]
	public FEditableTextBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:WidgetStyle");
				return default(FEditableTextBoxStyle);
			}
			return FEditableTextBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:WidgetStyle");
			}
			else
			{
				FEditableTextBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:HintText")]
	public FText HintText
	{
		get
		{
			CheckDestroyed();
			if (!HintText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:HintText");
				return null;
			}
			if (HintText_TextCached == null)
			{
				HintText_TextCached = new FText(IntPtr.Add(base.Address, HintText_Offset), createReference: false);
			}
			return HintText_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!HintText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:HintText");
				return;
			}
			if (HintText_TextCached == null)
			{
				HintText_TextCached = new FText(IntPtr.Add(base.Address, HintText_Offset), createReference: false);
			}
			HintText_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:IsReadOnly")]
	public bool IsReadOnly
	{
		get
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsReadOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsReadOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:IsPassword")]
	public bool IsPassword
	{
		get
		{
			CheckDestroyed();
			if (!IsPassword_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsPassword");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPassword_Offset), 0, IsPassword_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPassword_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsPassword");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPassword_Offset), 0, IsPassword_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:MinimumDesiredWidth")]
	public float MinimumDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinimumDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:MinimumDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:MinimumDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:IsCaretMovedWhenGainFocus")]
	public bool IsCaretMovedWhenGainFocus
	{
		get
		{
			CheckDestroyed();
			if (!IsCaretMovedWhenGainFocus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsCaretMovedWhenGainFocus");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCaretMovedWhenGainFocus_Offset), 0, IsCaretMovedWhenGainFocus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCaretMovedWhenGainFocus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:IsCaretMovedWhenGainFocus");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCaretMovedWhenGainFocus_Offset), 0, IsCaretMovedWhenGainFocus_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:SelectAllTextWhenFocused")]
	public bool SelectAllTextWhenFocused
	{
		get
		{
			CheckDestroyed();
			if (!SelectAllTextWhenFocused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:SelectAllTextWhenFocused");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SelectAllTextWhenFocused_Offset), 0, SelectAllTextWhenFocused_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelectAllTextWhenFocused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:SelectAllTextWhenFocused");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SelectAllTextWhenFocused_Offset), 0, SelectAllTextWhenFocused_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:RevertTextOnEscape")]
	public bool RevertTextOnEscape
	{
		get
		{
			CheckDestroyed();
			if (!RevertTextOnEscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:RevertTextOnEscape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RevertTextOnEscape_Offset), 0, RevertTextOnEscape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RevertTextOnEscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:RevertTextOnEscape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RevertTextOnEscape_Offset), 0, RevertTextOnEscape_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:ClearKeyboardFocusOnCommit")]
	public bool ClearKeyboardFocusOnCommit
	{
		get
		{
			CheckDestroyed();
			if (!ClearKeyboardFocusOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:ClearKeyboardFocusOnCommit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClearKeyboardFocusOnCommit_Offset), 0, ClearKeyboardFocusOnCommit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClearKeyboardFocusOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:ClearKeyboardFocusOnCommit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClearKeyboardFocusOnCommit_Offset), 0, ClearKeyboardFocusOnCommit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:SelectAllTextOnCommit")]
	public bool SelectAllTextOnCommit
	{
		get
		{
			CheckDestroyed();
			if (!SelectAllTextOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:SelectAllTextOnCommit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SelectAllTextOnCommit_Offset), 0, SelectAllTextOnCommit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelectAllTextOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:SelectAllTextOnCommit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SelectAllTextOnCommit_Offset), 0, SelectAllTextOnCommit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:Justification")]
	public ETextJustify Justification
	{
		get
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:Justification");
				return ETextJustify.Left;
			}
			return EnumMarshaler<ETextJustify>.FromNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:Justification");
			}
			else
			{
				EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:OverflowPolicy")]
	public ETextOverflowPolicy OverflowPolicy
	{
		get
		{
			CheckDestroyed();
			if (!OverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:OverflowPolicy");
				return ETextOverflowPolicy.Clip;
			}
			return EnumMarshaler<ETextOverflowPolicy>.FromNative(IntPtr.Add(base.Address, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:OverflowPolicy");
			}
			else
			{
				EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(base.Address, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:ShapedTextOptions")]
	public FShapedTextOptions ShapedTextOptions
	{
		get
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:ShapedTextOptions");
				return default(FShapedTextOptions);
			}
			return FShapedTextOptions.FromNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:ShapedTextOptions");
			}
			else
			{
				FShapedTextOptions.ToNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:OnTextChanged")]
	public FOnEditableTextBoxChangedEvent OnTextChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTextChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:OnTextChanged");
				return new FOnEditableTextBoxChangedEvent();
			}
			if (OnTextChanged_DelegateCached == null)
			{
				OnTextChanged_DelegateCached = new FOnEditableTextBoxChangedEvent();
				OnTextChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextChanged_Offset));
			}
			return OnTextChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.EditableTextBox:OnTextCommitted")]
	public FOnEditableTextBoxCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableTextBox:OnTextCommitted");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetTextOverflowPolicy")]
	public unsafe void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy)
	{
		CheckDestroyed();
		if (!SetTextOverflowPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetTextOverflowPolicy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextOverflowPolicy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextOverflowPolicy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(intPtr, SetTextOverflowPolicy_InOverflowPolicy_Offset), 0, SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress.Address, InOverflowPolicy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextOverflowPolicy_FunctionAddress, intPtr, SetTextOverflowPolicy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetText_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetText_InText_Offset), 0, SetText_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetText_FunctionAddress, intPtr, SetText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetText_InText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetJustification")]
	public unsafe void SetJustification(ETextJustify InJustification)
	{
		CheckDestroyed();
		if (!SetJustification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetJustification");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetJustification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetJustification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(intPtr, SetJustification_InJustification_Offset), 0, SetJustification_InJustification_PropertyAddress.Address, InJustification);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetJustification_FunctionAddress, intPtr, SetJustification_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetIsReadOnly")]
	public unsafe void SetIsReadOnly(bool bReadOnly)
	{
		CheckDestroyed();
		if (!SetIsReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetIsReadOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsReadOnly_bReadOnly_Offset), 0, SetIsReadOnly_bReadOnly_PropertyAddress.Address, bReadOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsReadOnly_FunctionAddress, intPtr, SetIsReadOnly_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetIsPassword")]
	public unsafe void SetIsPassword(bool bIsPassword)
	{
		CheckDestroyed();
		if (!SetIsPassword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetIsPassword");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsPassword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsPassword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsPassword_bIsPassword_Offset), 0, SetIsPassword_bIsPassword_PropertyAddress.Address, bIsPassword);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsPassword_FunctionAddress, intPtr, SetIsPassword_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetHintText")]
	public unsafe void SetHintText(FText InText)
	{
		CheckDestroyed();
		if (!SetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetHintText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHintText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHintText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetHintText_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetHintText_InText_Offset), 0, SetHintText_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHintText_FunctionAddress, intPtr, SetHintText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetHintText_InText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetForegroundColor")]
	public unsafe void SetForegroundColor(FLinearColor color)
	{
		CheckDestroyed();
		if (!SetForegroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetForegroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForegroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForegroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetForegroundColor_color_Offset), 0, SetForegroundColor_color_PropertyAddress.Address, color);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForegroundColor_FunctionAddress, intPtr, SetForegroundColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:SetError")]
	public unsafe void SetError(FText InError)
	{
		CheckDestroyed();
		if (!SetError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:SetError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetError_InError_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetError_InError_Offset), 0, SetError_InError_PropertyAddress.Address, InError);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetError_FunctionAddress, intPtr, SetError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetError_InError_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.EditableTextBox:HasError")]
	public unsafe bool HasError()
	{
		CheckDestroyed();
		if (!HasError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:HasError");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasError_FunctionAddress, intPtr, HasError_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasError_ReturnValue_Offset), 0, HasError_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.EditableTextBox:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:GetText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetText_FunctionAddress, intPtr, GetText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetText_ReturnValue_Offset), 0, GetText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableTextBox:ClearError")]
	public unsafe void ClearError()
	{
		CheckDestroyed();
		if (!ClearError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableTextBox:ClearError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearError_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearError_FunctionAddress, argsSize: ClearError_ParamsSize);
	}

	static UEditableTextBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditableTextBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditableTextBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.EditableTextBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		HintText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HintText");
		HintText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HintText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReadOnly_PropertyAddress, intPtr, "IsReadOnly");
		IsReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsReadOnly");
		IsReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsReadOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPassword_PropertyAddress, intPtr, "IsPassword");
		IsPassword_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsPassword");
		IsPassword_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsPassword", Classes.FBoolProperty);
		MinimumDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumDesiredWidth");
		MinimumDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumDesiredWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCaretMovedWhenGainFocus_PropertyAddress, intPtr, "IsCaretMovedWhenGainFocus");
		IsCaretMovedWhenGainFocus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCaretMovedWhenGainFocus");
		IsCaretMovedWhenGainFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCaretMovedWhenGainFocus", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectAllTextWhenFocused_PropertyAddress, intPtr, "SelectAllTextWhenFocused");
		SelectAllTextWhenFocused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectAllTextWhenFocused");
		SelectAllTextWhenFocused_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectAllTextWhenFocused", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RevertTextOnEscape_PropertyAddress, intPtr, "RevertTextOnEscape");
		RevertTextOnEscape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RevertTextOnEscape");
		RevertTextOnEscape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RevertTextOnEscape", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearKeyboardFocusOnCommit_PropertyAddress, intPtr, "ClearKeyboardFocusOnCommit");
		ClearKeyboardFocusOnCommit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClearKeyboardFocusOnCommit");
		ClearKeyboardFocusOnCommit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClearKeyboardFocusOnCommit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectAllTextOnCommit_PropertyAddress, intPtr, "SelectAllTextOnCommit");
		SelectAllTextOnCommit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectAllTextOnCommit");
		SelectAllTextOnCommit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectAllTextOnCommit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Justification_PropertyAddress, intPtr, "Justification");
		Justification_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Justification");
		Justification_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Justification", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OverflowPolicy_PropertyAddress, intPtr, "OverflowPolicy");
		OverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverflowPolicy");
		OverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverflowPolicy", Classes.FEnumProperty);
		ShapedTextOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapedTextOptions");
		ShapedTextOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapedTextOptions", Classes.FStructProperty);
		OnTextChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextChanged");
		OnTextChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextChanged", Classes.FMulticastDelegateProperty);
		OnTextCommitted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextCommitted");
		OnTextCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextCommitted", Classes.FMulticastDelegateProperty);
		SetTextOverflowPolicy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextOverflowPolicy");
		SetTextOverflowPolicy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextOverflowPolicy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextOverflowPolicy_InOverflowPolicy_PropertyAddress, SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy");
		SetTextOverflowPolicy_InOverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextOverflowPolicy_FunctionAddress, "InOverflowPolicy", Classes.FEnumProperty);
		SetTextOverflowPolicy_IsValid = SetTextOverflowPolicy_FunctionAddress != IntPtr.Zero && SetTextOverflowPolicy_InOverflowPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetTextOverflowPolicy", SetTextOverflowPolicy_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetText", SetText_IsValid);
		SetJustification_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetJustification");
		SetJustification_ParamsSize = NativeReflection.GetFunctionParamsSize(SetJustification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetJustification_InJustification_PropertyAddress, SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_Offset = NativeReflectionCached.GetPropertyOffset(SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJustification_FunctionAddress, "InJustification", Classes.FByteProperty);
		SetJustification_IsValid = SetJustification_FunctionAddress != IntPtr.Zero && SetJustification_InJustification_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetJustification", SetJustification_IsValid);
		SetIsReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsReadOnly");
		SetIsReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsReadOnly_bReadOnly_PropertyAddress, SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsReadOnly_FunctionAddress, "bReadOnly", Classes.FBoolProperty);
		SetIsReadOnly_IsValid = SetIsReadOnly_FunctionAddress != IntPtr.Zero && SetIsReadOnly_bReadOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetIsReadOnly", SetIsReadOnly_IsValid);
		SetIsPassword_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsPassword");
		SetIsPassword_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsPassword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsPassword_bIsPassword_PropertyAddress, SetIsPassword_FunctionAddress, "bIsPassword");
		SetIsPassword_bIsPassword_Offset = NativeReflectionCached.GetPropertyOffset(SetIsPassword_FunctionAddress, "bIsPassword");
		SetIsPassword_bIsPassword_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsPassword_FunctionAddress, "bIsPassword", Classes.FBoolProperty);
		SetIsPassword_IsValid = SetIsPassword_FunctionAddress != IntPtr.Zero && SetIsPassword_bIsPassword_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetIsPassword", SetIsPassword_IsValid);
		SetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHintText");
		SetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHintText_InText_PropertyAddress, SetHintText_FunctionAddress, "InText");
		SetHintText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetHintText_FunctionAddress, "InText");
		SetHintText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHintText_FunctionAddress, "InText", Classes.FTextProperty);
		SetHintText_IsValid = SetHintText_FunctionAddress != IntPtr.Zero && SetHintText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetHintText", SetHintText_IsValid);
		SetForegroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForegroundColor");
		SetForegroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForegroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForegroundColor_color_PropertyAddress, SetForegroundColor_FunctionAddress, "color");
		SetForegroundColor_color_Offset = NativeReflectionCached.GetPropertyOffset(SetForegroundColor_FunctionAddress, "color");
		SetForegroundColor_color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForegroundColor_FunctionAddress, "color", Classes.FStructProperty);
		SetForegroundColor_IsValid = SetForegroundColor_FunctionAddress != IntPtr.Zero && SetForegroundColor_color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetForegroundColor", SetForegroundColor_IsValid);
		SetError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetError");
		SetError_ParamsSize = NativeReflection.GetFunctionParamsSize(SetError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetError_InError_PropertyAddress, SetError_FunctionAddress, "InError");
		SetError_InError_Offset = NativeReflectionCached.GetPropertyOffset(SetError_FunctionAddress, "InError");
		SetError_InError_IsValid = NativeReflectionCached.ValidatePropertyClass(SetError_FunctionAddress, "InError", Classes.FTextProperty);
		SetError_IsValid = SetError_FunctionAddress != IntPtr.Zero && SetError_InError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:SetError", SetError_IsValid);
		HasError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasError");
		HasError_ParamsSize = NativeReflection.GetFunctionParamsSize(HasError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasError_ReturnValue_PropertyAddress, HasError_FunctionAddress, "ReturnValue");
		HasError_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasError_FunctionAddress, "ReturnValue");
		HasError_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasError_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasError_IsValid = HasError_FunctionAddress != IntPtr.Zero && HasError_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:HasError", HasError_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:GetText", GetText_IsValid);
		ClearError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearError");
		ClearError_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearError_FunctionAddress);
		ClearError_IsValid = ClearError_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableTextBox:ClearError", ClearError_IsValid);
	}
}
