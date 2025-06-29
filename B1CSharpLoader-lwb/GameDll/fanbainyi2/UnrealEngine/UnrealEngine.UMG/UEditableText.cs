using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.EditableText", "UMG", UnrealModuleType.Engine)]
public class UEditableText : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature")]
	public class FOnEditableTextCommittedEvent : FMulticastDelegate<FOnEditableTextCommittedEvent.Signature>
	{
		public delegate void Signature(FText Text, ETextCommit CommitMethod);

		private static bool OnEditableTextCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnEditableTextCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnEditableTextCommittedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnEditableTextCommittedEvent__DelegateSignature_Text_Offset;

		private static bool OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid;

		private static FFieldAddress OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress;

		private static int OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnEditableTextCommittedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature");
			OnEditableTextCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextCommittedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextCommittedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnEditableTextCommittedEvent__DelegateSignature_IsValid = OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextCommittedEvent__DelegateSignature_Text_IsValid && OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature", OnEditableTextCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text, ETextCommit CommitMethod)
		{
			if (!OnEditableTextCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnEditableTextCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditableTextCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnEditableTextCommittedEvent__DelegateSignature_Text_Offset), 0, OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				EnumMarshaler<ETextCommit>.ToNative(IntPtr.Add(intPtr, OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset), 0, OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress.Address, CommitMethod);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature")]
	public class FOnEditableTextChangedEvent : FMulticastDelegate<FOnEditableTextChangedEvent.Signature>
	{
		public delegate void Signature(FText Text);

		private static bool OnEditableTextChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnEditableTextChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnEditableTextChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnEditableTextChangedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnEditableTextChangedEvent__DelegateSignature_Text_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnEditableTextChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnEditableTextChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature");
			OnEditableTextChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextChangedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextChangedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnEditableTextChangedEvent__DelegateSignature_IsValid = OnEditableTextChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextChangedEvent__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature", OnEditableTextChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnEditableTextChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnEditableTextChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditableTextChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnEditableTextChangedEvent__DelegateSignature_Text_Offset), 0, OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool HintText_IsValid;

	private static int HintText_Offset;

	private FText HintText_TextCached;

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

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

	private FOnEditableTextChangedEvent OnTextChanged_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnEditableTextCommittedEvent OnTextCommitted_DelegateCached;

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

	private static bool SetIsReadOnly_InbIsReadyOnly_IsValid;

	private static FFieldAddress SetIsReadOnly_InbIsReadyOnly_PropertyAddress;

	private static int SetIsReadOnly_InbIsReadyOnly_Offset;

	private static bool SetIsPassword_IsValid;

	private static IntPtr SetIsPassword_FunctionAddress;

	private static int SetIsPassword_ParamsSize;

	private static bool SetIsPassword_InbIsPassword_IsValid;

	private static FFieldAddress SetIsPassword_InbIsPassword_PropertyAddress;

	private static int SetIsPassword_InbIsPassword_Offset;

	private static bool SetHintText_IsValid;

	private static IntPtr SetHintText_FunctionAddress;

	private static int SetHintText_ParamsSize;

	private static bool SetHintText_InHintText_IsValid;

	private static FFieldAddress SetHintText_InHintText_PropertyAddress;

	private static int SetHintText_InHintText_Offset;

	private static bool GetText_IsValid;

	private static IntPtr GetText_FunctionAddress;

	private static int GetText_ParamsSize;

	private static bool GetText_ReturnValue_IsValid;

	private static FFieldAddress GetText_ReturnValue_PropertyAddress;

	private static int GetText_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.EditableText:HintText")]
	public FText HintText
	{
		get
		{
			CheckDestroyed();
			if (!HintText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:HintText");
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
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:HintText");
				return;
			}
			if (HintText_TextCached == null)
			{
				HintText_TextCached = new FText(IntPtr.Add(base.Address, HintText_Offset), createReference: false);
			}
			HintText_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.EditableText:WidgetStyle")]
	public FEditableTextStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:WidgetStyle");
				return default(FEditableTextStyle);
			}
			return FEditableTextStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:WidgetStyle");
			}
			else
			{
				FEditableTextStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.EditableText:Justification")]
	public ETextJustify Justification
	{
		get
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:Justification");
				return ETextJustify.Left;
			}
			return EnumMarshaler<ETextJustify>.FromNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:Justification");
			}
			else
			{
				EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.EditableText:OverflowPolicy")]
	public ETextOverflowPolicy OverflowPolicy
	{
		get
		{
			CheckDestroyed();
			if (!OverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:OverflowPolicy");
				return ETextOverflowPolicy.Clip;
			}
			return EnumMarshaler<ETextOverflowPolicy>.FromNative(IntPtr.Add(base.Address, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverflowPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:OverflowPolicy");
			}
			else
			{
				EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(base.Address, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/UMG.EditableText:ShapedTextOptions")]
	public FShapedTextOptions ShapedTextOptions
	{
		get
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:ShapedTextOptions");
				return default(FShapedTextOptions);
			}
			return FShapedTextOptions.FromNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShapedTextOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:ShapedTextOptions");
			}
			else
			{
				FShapedTextOptions.ToNative(IntPtr.Add(base.Address, ShapedTextOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.EditableText:OnTextChanged")]
	public FOnEditableTextChangedEvent OnTextChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTextChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:OnTextChanged");
				return new FOnEditableTextChangedEvent();
			}
			if (OnTextChanged_DelegateCached == null)
			{
				OnTextChanged_DelegateCached = new FOnEditableTextChangedEvent();
				OnTextChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextChanged_Offset));
			}
			return OnTextChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.EditableText:OnTextCommitted")]
	public FOnEditableTextCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.EditableText:OnTextCommitted");
				return new FOnEditableTextCommittedEvent();
			}
			if (OnTextCommitted_DelegateCached == null)
			{
				OnTextCommitted_DelegateCached = new FOnEditableTextCommittedEvent();
				OnTextCommitted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextCommitted_Offset));
			}
			return OnTextCommitted_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableText:SetTextOverflowPolicy")]
	public unsafe void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy)
	{
		CheckDestroyed();
		if (!SetTextOverflowPolicy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetTextOverflowPolicy");
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
	[UMetaPath("/Script/UMG.EditableText:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetText");
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
	[UMetaPath("/Script/UMG.EditableText:SetJustification")]
	public unsafe void SetJustification(ETextJustify InJustification)
	{
		CheckDestroyed();
		if (!SetJustification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetJustification");
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
	[UMetaPath("/Script/UMG.EditableText:SetIsReadOnly")]
	public unsafe void SetIsReadOnly(bool InbIsReadyOnly)
	{
		CheckDestroyed();
		if (!SetIsReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetIsReadOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsReadOnly_InbIsReadyOnly_Offset), 0, SetIsReadOnly_InbIsReadyOnly_PropertyAddress.Address, InbIsReadyOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsReadOnly_FunctionAddress, intPtr, SetIsReadOnly_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableText:SetIsPassword")]
	public unsafe void SetIsPassword(bool InbIsPassword)
	{
		CheckDestroyed();
		if (!SetIsPassword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetIsPassword");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsPassword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsPassword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsPassword_InbIsPassword_Offset), 0, SetIsPassword_InbIsPassword_PropertyAddress.Address, InbIsPassword);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsPassword_FunctionAddress, intPtr, SetIsPassword_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.EditableText:SetHintText")]
	public unsafe void SetHintText(FText InHintText)
	{
		CheckDestroyed();
		if (!SetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:SetHintText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHintText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHintText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetHintText_InHintText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetHintText_InHintText_Offset), 0, SetHintText_InHintText_PropertyAddress.Address, InHintText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHintText_FunctionAddress, intPtr, SetHintText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetHintText_InHintText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.EditableText:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.EditableText:GetText");
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

	static UEditableText()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditableText)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditableText));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.EditableText");
		HintText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HintText");
		HintText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HintText", Classes.FTextProperty);
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetTextOverflowPolicy", SetTextOverflowPolicy_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetText", SetText_IsValid);
		SetJustification_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetJustification");
		SetJustification_ParamsSize = NativeReflection.GetFunctionParamsSize(SetJustification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetJustification_InJustification_PropertyAddress, SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_Offset = NativeReflectionCached.GetPropertyOffset(SetJustification_FunctionAddress, "InJustification");
		SetJustification_InJustification_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJustification_FunctionAddress, "InJustification", Classes.FByteProperty);
		SetJustification_IsValid = SetJustification_FunctionAddress != IntPtr.Zero && SetJustification_InJustification_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetJustification", SetJustification_IsValid);
		SetIsReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsReadOnly");
		SetIsReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsReadOnly_InbIsReadyOnly_PropertyAddress, SetIsReadOnly_FunctionAddress, "InbIsReadyOnly");
		SetIsReadOnly_InbIsReadyOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetIsReadOnly_FunctionAddress, "InbIsReadyOnly");
		SetIsReadOnly_InbIsReadyOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsReadOnly_FunctionAddress, "InbIsReadyOnly", Classes.FBoolProperty);
		SetIsReadOnly_IsValid = SetIsReadOnly_FunctionAddress != IntPtr.Zero && SetIsReadOnly_InbIsReadyOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetIsReadOnly", SetIsReadOnly_IsValid);
		SetIsPassword_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsPassword");
		SetIsPassword_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsPassword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsPassword_InbIsPassword_PropertyAddress, SetIsPassword_FunctionAddress, "InbIsPassword");
		SetIsPassword_InbIsPassword_Offset = NativeReflectionCached.GetPropertyOffset(SetIsPassword_FunctionAddress, "InbIsPassword");
		SetIsPassword_InbIsPassword_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsPassword_FunctionAddress, "InbIsPassword", Classes.FBoolProperty);
		SetIsPassword_IsValid = SetIsPassword_FunctionAddress != IntPtr.Zero && SetIsPassword_InbIsPassword_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetIsPassword", SetIsPassword_IsValid);
		SetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHintText");
		SetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHintText_InHintText_PropertyAddress, SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_Offset = NativeReflectionCached.GetPropertyOffset(SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHintText_FunctionAddress, "InHintText", Classes.FTextProperty);
		SetHintText_IsValid = SetHintText_FunctionAddress != IntPtr.Zero && SetHintText_InHintText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:SetHintText", SetHintText_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.EditableText:GetText", GetText_IsValid);
	}
}
