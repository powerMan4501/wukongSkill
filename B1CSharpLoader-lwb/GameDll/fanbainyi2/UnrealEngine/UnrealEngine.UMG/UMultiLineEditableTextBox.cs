using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.MultiLineEditableTextBox", "UMG", UnrealModuleType.Engine)]
public class UMultiLineEditableTextBox : UTextLayoutWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature")]
	public class FOnMultiLineEditableTextBoxCommittedEvent : FMulticastDelegate<FOnMultiLineEditableTextBoxCommittedEvent.Signature>
	{
		public delegate void Signature(FText Text, ETextCommit CommitMethod);

		private static bool OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset;

		private static bool OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid;

		private static FFieldAddress OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress;

		private static int OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMultiLineEditableTextBoxCommittedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature");
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_IsValid = OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_IsValid && OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature", OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text, ETextCommit CommitMethod)
		{
			if (!OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_Offset), 0, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				EnumMarshaler<ETextCommit>.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_Offset), 0, OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress.Address, CommitMethod);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature")]
	public class FOnMultiLineEditableTextBoxChangedEvent : FMulticastDelegate<FOnMultiLineEditableTextBoxChangedEvent.Signature>
	{
		public delegate void Signature(FText Text);

		private static bool OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMultiLineEditableTextBoxChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature");
			OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress, OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_IsValid = OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature", OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_Offset), 0, OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool TextStyle_IsValid;

	private static int TextStyle_Offset;

	private static bool IsReadOnly_IsValid;

	private static FFieldAddress IsReadOnly_PropertyAddress;

	private static int IsReadOnly_Offset;

	private static bool OnTextChanged_IsValid;

	private static int OnTextChanged_Offset;

	private FOnMultiLineEditableTextBoxChangedEvent OnTextChanged_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted_DelegateCached;

	private static bool SetTextStyle_IsValid;

	private static IntPtr SetTextStyle_FunctionAddress;

	private static int SetTextStyle_ParamsSize;

	private static bool SetTextStyle_InTextStyle_IsValid;

	private static FFieldAddress SetTextStyle_InTextStyle_PropertyAddress;

	private static int SetTextStyle_InTextStyle_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_InText_IsValid;

	private static FFieldAddress SetText_InText_PropertyAddress;

	private static int SetText_InText_Offset;

	private static bool SetIsReadOnly_IsValid;

	private static IntPtr SetIsReadOnly_FunctionAddress;

	private static int SetIsReadOnly_ParamsSize;

	private static bool SetIsReadOnly_bReadOnly_IsValid;

	private static FFieldAddress SetIsReadOnly_bReadOnly_PropertyAddress;

	private static int SetIsReadOnly_bReadOnly_Offset;

	private static bool SetHintText_IsValid;

	private static IntPtr SetHintText_FunctionAddress;

	private static int SetHintText_ParamsSize;

	private static bool SetHintText_InHintText_IsValid;

	private static FFieldAddress SetHintText_InHintText_PropertyAddress;

	private static int SetHintText_InHintText_Offset;

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

	private static bool GetText_IsValid;

	private static IntPtr GetText_FunctionAddress;

	private static int GetText_ParamsSize;

	private static bool GetText_ReturnValue_IsValid;

	private static FFieldAddress GetText_ReturnValue_PropertyAddress;

	private static int GetText_ReturnValue_Offset;

	private static bool GetHintText_IsValid;

	private static IntPtr GetHintText_FunctionAddress;

	private static int GetHintText_ParamsSize;

	private static bool GetHintText_ReturnValue_IsValid;

	private static FFieldAddress GetHintText_ReturnValue_PropertyAddress;

	private static int GetHintText_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:WidgetStyle")]
	public FEditableTextBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:WidgetStyle");
				return default(FEditableTextBoxStyle);
			}
			return FEditableTextBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:WidgetStyle");
			}
			else
			{
				FEditableTextBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:TextStyle")]
	public FTextBlockStyle TextStyle
	{
		get
		{
			CheckDestroyed();
			if (!TextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:TextStyle");
				return default(FTextBlockStyle);
			}
			return FTextBlockStyle.FromNative(IntPtr.Add(base.Address, TextStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:TextStyle");
			}
			else
			{
				FTextBlockStyle.ToNative(IntPtr.Add(base.Address, TextStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:bIsReadOnly")]
	public bool IsReadOnly
	{
		get
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:bIsReadOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:bIsReadOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:OnTextChanged")]
	public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTextChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:OnTextChanged");
				return new FOnMultiLineEditableTextBoxChangedEvent();
			}
			if (OnTextChanged_DelegateCached == null)
			{
				OnTextChanged_DelegateCached = new FOnMultiLineEditableTextBoxChangedEvent();
				OnTextChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextChanged_Offset));
			}
			return OnTextChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:OnTextCommitted")]
	public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableTextBox:OnTextCommitted");
				return new FOnMultiLineEditableTextBoxCommittedEvent();
			}
			if (OnTextCommitted_DelegateCached == null)
			{
				OnTextCommitted_DelegateCached = new FOnMultiLineEditableTextBoxCommittedEvent();
				OnTextCommitted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextCommitted_Offset));
			}
			return OnTextCommitted_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetTextStyle")]
	public unsafe void SetTextStyle(FTextBlockStyle InTextStyle)
	{
		CheckDestroyed();
		if (!SetTextStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetTextStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTextStyle_InTextStyle_PropertyAddress.Address, intPtr);
		FTextBlockStyle.ToNative(IntPtr.Add(intPtr, SetTextStyle_InTextStyle_Offset), 0, SetTextStyle_InTextStyle_PropertyAddress.Address, InTextStyle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextStyle_FunctionAddress, intPtr, SetTextStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTextStyle_InTextStyle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetText");
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
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetIsReadOnly")]
	public unsafe void SetIsReadOnly(bool bReadOnly)
	{
		CheckDestroyed();
		if (!SetIsReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetIsReadOnly");
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
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetHintText")]
	public unsafe void SetHintText(FText InHintText)
	{
		CheckDestroyed();
		if (!SetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetHintText");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetForegroundColor")]
	public unsafe void SetForegroundColor(FLinearColor color)
	{
		CheckDestroyed();
		if (!SetForegroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetForegroundColor");
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
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:SetError")]
	public unsafe void SetError(FText InError)
	{
		CheckDestroyed();
		if (!SetError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:SetError");
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
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:GetText");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.MultiLineEditableTextBox:GetHintText")]
	public unsafe string GetHintText()
	{
		CheckDestroyed();
		if (!GetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableTextBox:GetHintText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHintText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHintText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHintText_FunctionAddress, intPtr, GetHintText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetHintText_ReturnValue_Offset), 0, GetHintText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetHintText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMultiLineEditableTextBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMultiLineEditableTextBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMultiLineEditableTextBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.MultiLineEditableTextBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		TextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextStyle");
		TextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReadOnly_PropertyAddress, intPtr, "bIsReadOnly");
		IsReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsReadOnly");
		IsReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsReadOnly", Classes.FBoolProperty);
		OnTextChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextChanged");
		OnTextChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextChanged", Classes.FMulticastDelegateProperty);
		OnTextCommitted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextCommitted");
		OnTextCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextCommitted", Classes.FMulticastDelegateProperty);
		SetTextStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextStyle");
		SetTextStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextStyle_InTextStyle_PropertyAddress, SetTextStyle_FunctionAddress, "InTextStyle");
		SetTextStyle_InTextStyle_Offset = NativeReflectionCached.GetPropertyOffset(SetTextStyle_FunctionAddress, "InTextStyle");
		SetTextStyle_InTextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextStyle_FunctionAddress, "InTextStyle", Classes.FStructProperty);
		SetTextStyle_IsValid = SetTextStyle_FunctionAddress != IntPtr.Zero && SetTextStyle_InTextStyle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetTextStyle", SetTextStyle_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetText", SetText_IsValid);
		SetIsReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsReadOnly");
		SetIsReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsReadOnly_bReadOnly_PropertyAddress, SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsReadOnly_FunctionAddress, "bReadOnly", Classes.FBoolProperty);
		SetIsReadOnly_IsValid = SetIsReadOnly_FunctionAddress != IntPtr.Zero && SetIsReadOnly_bReadOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetIsReadOnly", SetIsReadOnly_IsValid);
		SetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHintText");
		SetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHintText_InHintText_PropertyAddress, SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_Offset = NativeReflectionCached.GetPropertyOffset(SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHintText_FunctionAddress, "InHintText", Classes.FTextProperty);
		SetHintText_IsValid = SetHintText_FunctionAddress != IntPtr.Zero && SetHintText_InHintText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetHintText", SetHintText_IsValid);
		SetForegroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForegroundColor");
		SetForegroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForegroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForegroundColor_color_PropertyAddress, SetForegroundColor_FunctionAddress, "color");
		SetForegroundColor_color_Offset = NativeReflectionCached.GetPropertyOffset(SetForegroundColor_FunctionAddress, "color");
		SetForegroundColor_color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForegroundColor_FunctionAddress, "color", Classes.FStructProperty);
		SetForegroundColor_IsValid = SetForegroundColor_FunctionAddress != IntPtr.Zero && SetForegroundColor_color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetForegroundColor", SetForegroundColor_IsValid);
		SetError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetError");
		SetError_ParamsSize = NativeReflection.GetFunctionParamsSize(SetError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetError_InError_PropertyAddress, SetError_FunctionAddress, "InError");
		SetError_InError_Offset = NativeReflectionCached.GetPropertyOffset(SetError_FunctionAddress, "InError");
		SetError_InError_IsValid = NativeReflectionCached.ValidatePropertyClass(SetError_FunctionAddress, "InError", Classes.FTextProperty);
		SetError_IsValid = SetError_FunctionAddress != IntPtr.Zero && SetError_InError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:SetError", SetError_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:GetText", GetText_IsValid);
		GetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHintText");
		GetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHintText_ReturnValue_PropertyAddress, GetHintText_FunctionAddress, "ReturnValue");
		GetHintText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHintText_FunctionAddress, "ReturnValue");
		GetHintText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHintText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetHintText_IsValid = GetHintText_FunctionAddress != IntPtr.Zero && GetHintText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableTextBox:GetHintText", GetHintText_IsValid);
	}
}
