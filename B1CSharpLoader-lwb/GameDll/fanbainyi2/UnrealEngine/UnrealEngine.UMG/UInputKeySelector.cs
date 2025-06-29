using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.InputKeySelector", "UMG", UnrealModuleType.Engine)]
public class UInputKeySelector : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature")]
	public class FOnKeySelected : FMulticastDelegate<FOnKeySelected.Signature>
	{
		public delegate void Signature(FInputChord SelectedKey);

		private static bool OnKeySelected__DelegateSignature_IsValid;

		private static IntPtr OnKeySelected__DelegateSignature_FunctionAddress;

		private static int OnKeySelected__DelegateSignature_ParamsSize;

		private static bool OnKeySelected__DelegateSignature_SelectedKey_IsValid;

		private static FFieldAddress OnKeySelected__DelegateSignature_SelectedKey_PropertyAddress;

		private static int OnKeySelected__DelegateSignature_SelectedKey_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnKeySelected()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnKeySelected__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature");
			OnKeySelected__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeySelected__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnKeySelected__DelegateSignature_SelectedKey_PropertyAddress, OnKeySelected__DelegateSignature_FunctionAddress, "SelectedKey");
			OnKeySelected__DelegateSignature_SelectedKey_Offset = NativeReflectionCached.GetPropertyOffset(OnKeySelected__DelegateSignature_FunctionAddress, "SelectedKey");
			OnKeySelected__DelegateSignature_SelectedKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeySelected__DelegateSignature_FunctionAddress, "SelectedKey", Classes.FStructProperty);
			OnKeySelected__DelegateSignature_IsValid = OnKeySelected__DelegateSignature_FunctionAddress != IntPtr.Zero && OnKeySelected__DelegateSignature_SelectedKey_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature", OnKeySelected__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FInputChord SelectedKey)
		{
			if (!OnKeySelected__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnKeySelected__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeySelected__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnKeySelected__DelegateSignature_SelectedKey_PropertyAddress.Address, intPtr);
				FInputChord.ToNative(IntPtr.Add(intPtr, OnKeySelected__DelegateSignature_SelectedKey_Offset), 0, OnKeySelected__DelegateSignature_SelectedKey_PropertyAddress.Address, SelectedKey);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnKeySelected__DelegateSignature_SelectedKey_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature")]
	public class FOnIsSelectingKeyChanged : FMulticastDelegate<FOnIsSelectingKeyChanged.Signature>
	{
		public delegate void Signature();

		private static bool OnIsSelectingKeyChanged__DelegateSignature_IsValid;

		private static IntPtr OnIsSelectingKeyChanged__DelegateSignature_FunctionAddress;

		private static int OnIsSelectingKeyChanged__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnIsSelectingKeyChanged()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnIsSelectingKeyChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature");
			OnIsSelectingKeyChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnIsSelectingKeyChanged__DelegateSignature_FunctionAddress);
			OnIsSelectingKeyChanged__DelegateSignature_IsValid = OnIsSelectingKeyChanged__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature", OnIsSelectingKeyChanged__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnIsSelectingKeyChanged__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnIsSelectingKeyChanged__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnIsSelectingKeyChanged__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool TextStyle_IsValid;

	private static int TextStyle_Offset;

	private static bool SelectedKey_IsValid;

	private static int SelectedKey_Offset;

	private static bool Margin_IsValid;

	private static int Margin_Offset;

	private static bool KeySelectionText_IsValid;

	private static int KeySelectionText_Offset;

	private FText KeySelectionText_TextCached;

	private static bool NoKeySpecifiedText_IsValid;

	private static int NoKeySpecifiedText_Offset;

	private FText NoKeySpecifiedText_TextCached;

	private static bool AllowModifierKeys_IsValid;

	private static FFieldAddress AllowModifierKeys_PropertyAddress;

	private static int AllowModifierKeys_Offset;

	private static bool AllowGamepadKeys_IsValid;

	private static FFieldAddress AllowGamepadKeys_PropertyAddress;

	private static int AllowGamepadKeys_Offset;

	private static bool EscapeKeys_IsValid;

	private static FFieldAddress EscapeKeys_PropertyAddress;

	private static int EscapeKeys_Offset;

	private TArrayReadOnlyMarshaler<FKey> EscapeKeys_MarshalerCached;

	private static bool OnKeySelected_IsValid;

	private static int OnKeySelected_Offset;

	private FOnKeySelected OnKeySelected_DelegateCached;

	private static bool OnIsSelectingKeyChanged_IsValid;

	private static int OnIsSelectingKeyChanged_Offset;

	private FOnIsSelectingKeyChanged OnIsSelectingKeyChanged_DelegateCached;

	private static bool SetTextBlockVisibility_IsValid;

	private static IntPtr SetTextBlockVisibility_FunctionAddress;

	private static int SetTextBlockVisibility_ParamsSize;

	private static bool SetTextBlockVisibility_InVisibility_IsValid;

	private static FFieldAddress SetTextBlockVisibility_InVisibility_PropertyAddress;

	private static int SetTextBlockVisibility_InVisibility_Offset;

	private static bool SetSelectedKey_IsValid;

	private static IntPtr SetSelectedKey_FunctionAddress;

	private static int SetSelectedKey_ParamsSize;

	private static bool SetSelectedKey_InSelectedKey_IsValid;

	private static FFieldAddress SetSelectedKey_InSelectedKey_PropertyAddress;

	private static int SetSelectedKey_InSelectedKey_Offset;

	private static bool SetNoKeySpecifiedText_IsValid;

	private static IntPtr SetNoKeySpecifiedText_FunctionAddress;

	private static int SetNoKeySpecifiedText_ParamsSize;

	private static bool SetNoKeySpecifiedText_InNoKeySpecifiedText_IsValid;

	private static FFieldAddress SetNoKeySpecifiedText_InNoKeySpecifiedText_PropertyAddress;

	private static int SetNoKeySpecifiedText_InNoKeySpecifiedText_Offset;

	private static bool SetKeySelectionText_IsValid;

	private static IntPtr SetKeySelectionText_FunctionAddress;

	private static int SetKeySelectionText_ParamsSize;

	private static bool SetKeySelectionText_InKeySelectionText_IsValid;

	private static FFieldAddress SetKeySelectionText_InKeySelectionText_PropertyAddress;

	private static int SetKeySelectionText_InKeySelectionText_Offset;

	private static bool SetEscapeKeys_IsValid;

	private static IntPtr SetEscapeKeys_FunctionAddress;

	private static int SetEscapeKeys_ParamsSize;

	private static bool SetEscapeKeys_InKeys_IsValid;

	private static FFieldAddress SetEscapeKeys_InKeys_PropertyAddress;

	private static int SetEscapeKeys_InKeys_Offset;

	private static bool SetAllowModifierKeys_IsValid;

	private static IntPtr SetAllowModifierKeys_FunctionAddress;

	private static int SetAllowModifierKeys_ParamsSize;

	private static bool SetAllowModifierKeys_bInAllowModifierKeys_IsValid;

	private static FFieldAddress SetAllowModifierKeys_bInAllowModifierKeys_PropertyAddress;

	private static int SetAllowModifierKeys_bInAllowModifierKeys_Offset;

	private static bool SetAllowGamepadKeys_IsValid;

	private static IntPtr SetAllowGamepadKeys_FunctionAddress;

	private static int SetAllowGamepadKeys_ParamsSize;

	private static bool SetAllowGamepadKeys_bInAllowGamepadKeys_IsValid;

	private static FFieldAddress SetAllowGamepadKeys_bInAllowGamepadKeys_PropertyAddress;

	private static int SetAllowGamepadKeys_bInAllowGamepadKeys_Offset;

	private static bool GetIsSelectingKey_IsValid;

	private static IntPtr GetIsSelectingKey_FunctionAddress;

	private static int GetIsSelectingKey_ParamsSize;

	private static bool GetIsSelectingKey_ReturnValue_IsValid;

	private static FFieldAddress GetIsSelectingKey_ReturnValue_PropertyAddress;

	private static int GetIsSelectingKey_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:WidgetStyle")]
	public FButtonStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:WidgetStyle");
				return default(FButtonStyle);
			}
			return FButtonStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:WidgetStyle");
			}
			else
			{
				FButtonStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:TextStyle")]
	public FTextBlockStyle TextStyle
	{
		get
		{
			CheckDestroyed();
			if (!TextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:TextStyle");
				return default(FTextBlockStyle);
			}
			return FTextBlockStyle.FromNative(IntPtr.Add(base.Address, TextStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:TextStyle");
			}
			else
			{
				FTextBlockStyle.ToNative(IntPtr.Add(base.Address, TextStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055764uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:SelectedKey")]
	public FInputChord SelectedKey
	{
		get
		{
			CheckDestroyed();
			if (!SelectedKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:SelectedKey");
				return default(FInputChord);
			}
			return FInputChord.FromNative(IntPtr.Add(base.Address, SelectedKey_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:SelectedKey");
			}
			else
			{
				FInputChord.ToNative(IntPtr.Add(base.Address, SelectedKey_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:Margin")]
	public FMargin Margin
	{
		get
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:Margin");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Margin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:Margin");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Margin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:KeySelectionText")]
	public FText KeySelectionText
	{
		get
		{
			CheckDestroyed();
			if (!KeySelectionText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:KeySelectionText");
				return null;
			}
			if (KeySelectionText_TextCached == null)
			{
				KeySelectionText_TextCached = new FText(IntPtr.Add(base.Address, KeySelectionText_Offset), createReference: false);
			}
			return KeySelectionText_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!KeySelectionText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:KeySelectionText");
				return;
			}
			if (KeySelectionText_TextCached == null)
			{
				KeySelectionText_TextCached = new FText(IntPtr.Add(base.Address, KeySelectionText_Offset), createReference: false);
			}
			KeySelectionText_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:NoKeySpecifiedText")]
	public FText NoKeySpecifiedText
	{
		get
		{
			CheckDestroyed();
			if (!NoKeySpecifiedText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:NoKeySpecifiedText");
				return null;
			}
			if (NoKeySpecifiedText_TextCached == null)
			{
				NoKeySpecifiedText_TextCached = new FText(IntPtr.Add(base.Address, NoKeySpecifiedText_Offset), createReference: false);
			}
			return NoKeySpecifiedText_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!NoKeySpecifiedText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:NoKeySpecifiedText");
				return;
			}
			if (NoKeySpecifiedText_TextCached == null)
			{
				NoKeySpecifiedText_TextCached = new FText(IntPtr.Add(base.Address, NoKeySpecifiedText_Offset), createReference: false);
			}
			NoKeySpecifiedText_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:bAllowModifierKeys")]
	public bool AllowModifierKeys
	{
		get
		{
			CheckDestroyed();
			if (!AllowModifierKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:bAllowModifierKeys");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowModifierKeys_Offset), 0, AllowModifierKeys_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowModifierKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:bAllowModifierKeys");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowModifierKeys_Offset), 0, AllowModifierKeys_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:bAllowGamepadKeys")]
	public bool AllowGamepadKeys
	{
		get
		{
			CheckDestroyed();
			if (!AllowGamepadKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:bAllowGamepadKeys");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowGamepadKeys_Offset), 0, AllowGamepadKeys_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowGamepadKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:bAllowGamepadKeys");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowGamepadKeys_Offset), 0, AllowGamepadKeys_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:EscapeKeys")]
	public TArrayReadOnly<FKey> EscapeKeys
	{
		get
		{
			CheckDestroyed();
			if (!EscapeKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:EscapeKeys");
				return null;
			}
			if (EscapeKeys_MarshalerCached == null)
			{
				EscapeKeys_MarshalerCached = new TArrayReadOnlyMarshaler<FKey>(1, EscapeKeys_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative);
			}
			return EscapeKeys_MarshalerCached.FromNative(IntPtr.Add(base.Address, EscapeKeys_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:OnKeySelected")]
	public FOnKeySelected OnKeySelected
	{
		get
		{
			CheckDestroyed();
			if (!OnKeySelected_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:OnKeySelected");
				return new FOnKeySelected();
			}
			if (OnKeySelected_DelegateCached == null)
			{
				OnKeySelected_DelegateCached = new FOnKeySelected();
				OnKeySelected_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnKeySelected_Offset));
			}
			return OnKeySelected_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged")]
	public FOnIsSelectingKeyChanged OnIsSelectingKeyChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnIsSelectingKeyChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged");
				return new FOnIsSelectingKeyChanged();
			}
			if (OnIsSelectingKeyChanged_DelegateCached == null)
			{
				OnIsSelectingKeyChanged_DelegateCached = new FOnIsSelectingKeyChanged();
				OnIsSelectingKeyChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnIsSelectingKeyChanged_Offset));
			}
			return OnIsSelectingKeyChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetTextBlockVisibility")]
	public unsafe void SetTextBlockVisibility(ESlateVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetTextBlockVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetTextBlockVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextBlockVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextBlockVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(intPtr, SetTextBlockVisibility_InVisibility_Offset), 0, SetTextBlockVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextBlockVisibility_FunctionAddress, intPtr, SetTextBlockVisibility_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetSelectedKey")]
	public unsafe void SetSelectedKey(FInputChord InSelectedKey)
	{
		CheckDestroyed();
		if (!SetSelectedKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetSelectedKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSelectedKey_InSelectedKey_PropertyAddress.Address, intPtr);
		FInputChord.ToNative(IntPtr.Add(intPtr, SetSelectedKey_InSelectedKey_Offset), 0, SetSelectedKey_InSelectedKey_PropertyAddress.Address, InSelectedKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedKey_FunctionAddress, intPtr, SetSelectedKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSelectedKey_InSelectedKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetNoKeySpecifiedText")]
	public unsafe void SetNoKeySpecifiedText(FText InNoKeySpecifiedText)
	{
		CheckDestroyed();
		if (!SetNoKeySpecifiedText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetNoKeySpecifiedText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNoKeySpecifiedText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNoKeySpecifiedText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetNoKeySpecifiedText_InNoKeySpecifiedText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetNoKeySpecifiedText_InNoKeySpecifiedText_Offset), 0, SetNoKeySpecifiedText_InNoKeySpecifiedText_PropertyAddress.Address, InNoKeySpecifiedText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNoKeySpecifiedText_FunctionAddress, intPtr, SetNoKeySpecifiedText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNoKeySpecifiedText_InNoKeySpecifiedText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetKeySelectionText")]
	public unsafe void SetKeySelectionText(FText InKeySelectionText)
	{
		CheckDestroyed();
		if (!SetKeySelectionText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetKeySelectionText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetKeySelectionText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetKeySelectionText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetKeySelectionText_InKeySelectionText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetKeySelectionText_InKeySelectionText_Offset), 0, SetKeySelectionText_InKeySelectionText_PropertyAddress.Address, InKeySelectionText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetKeySelectionText_FunctionAddress, intPtr, SetKeySelectionText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetKeySelectionText_InKeySelectionText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetEscapeKeys")]
	public unsafe void SetEscapeKeys(List<FKey> InKeys)
	{
		CheckDestroyed();
		if (!SetEscapeKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetEscapeKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEscapeKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEscapeKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FKey>(1, SetEscapeKeys_InKeys_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative).ToNative(IntPtr.Add(intPtr, SetEscapeKeys_InKeys_Offset), InKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEscapeKeys_FunctionAddress, intPtr, SetEscapeKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEscapeKeys_InKeys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetAllowModifierKeys")]
	public unsafe void SetAllowModifierKeys(bool bInAllowModifierKeys)
	{
		CheckDestroyed();
		if (!SetAllowModifierKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetAllowModifierKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowModifierKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowModifierKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowModifierKeys_bInAllowModifierKeys_Offset), 0, SetAllowModifierKeys_bInAllowModifierKeys_PropertyAddress.Address, bInAllowModifierKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowModifierKeys_FunctionAddress, intPtr, SetAllowModifierKeys_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InputKeySelector:SetAllowGamepadKeys")]
	public unsafe void SetAllowGamepadKeys(bool bInAllowGamepadKeys)
	{
		CheckDestroyed();
		if (!SetAllowGamepadKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:SetAllowGamepadKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowGamepadKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowGamepadKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowGamepadKeys_bInAllowGamepadKeys_Offset), 0, SetAllowGamepadKeys_bInAllowGamepadKeys_PropertyAddress.Address, bInAllowGamepadKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowGamepadKeys_FunctionAddress, intPtr, SetAllowGamepadKeys_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.InputKeySelector:GetIsSelectingKey")]
	public unsafe bool GetIsSelectingKey()
	{
		CheckDestroyed();
		if (!GetIsSelectingKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InputKeySelector:GetIsSelectingKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsSelectingKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsSelectingKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsSelectingKey_FunctionAddress, intPtr, GetIsSelectingKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsSelectingKey_ReturnValue_Offset), 0, GetIsSelectingKey_ReturnValue_PropertyAddress.Address);
	}

	static UInputKeySelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputKeySelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputKeySelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.InputKeySelector");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		TextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextStyle");
		TextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextStyle", Classes.FStructProperty);
		SelectedKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedKey");
		SelectedKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedKey", Classes.FStructProperty);
		Margin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Margin");
		Margin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Margin", Classes.FStructProperty);
		KeySelectionText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeySelectionText");
		KeySelectionText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeySelectionText", Classes.FTextProperty);
		NoKeySpecifiedText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NoKeySpecifiedText");
		NoKeySpecifiedText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NoKeySpecifiedText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowModifierKeys_PropertyAddress, intPtr, "bAllowModifierKeys");
		AllowModifierKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowModifierKeys");
		AllowModifierKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowModifierKeys", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowGamepadKeys_PropertyAddress, intPtr, "bAllowGamepadKeys");
		AllowGamepadKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowGamepadKeys");
		AllowGamepadKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowGamepadKeys", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EscapeKeys_PropertyAddress, intPtr, "EscapeKeys");
		EscapeKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EscapeKeys");
		EscapeKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EscapeKeys", Classes.FArrayProperty);
		OnKeySelected_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnKeySelected");
		OnKeySelected_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnKeySelected", Classes.FMulticastDelegateProperty);
		OnIsSelectingKeyChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnIsSelectingKeyChanged");
		OnIsSelectingKeyChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnIsSelectingKeyChanged", Classes.FMulticastDelegateProperty);
		SetTextBlockVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextBlockVisibility");
		SetTextBlockVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextBlockVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextBlockVisibility_InVisibility_PropertyAddress, SetTextBlockVisibility_FunctionAddress, "InVisibility");
		SetTextBlockVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetTextBlockVisibility_FunctionAddress, "InVisibility");
		SetTextBlockVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextBlockVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetTextBlockVisibility_IsValid = SetTextBlockVisibility_FunctionAddress != IntPtr.Zero && SetTextBlockVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetTextBlockVisibility", SetTextBlockVisibility_IsValid);
		SetSelectedKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedKey");
		SetSelectedKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedKey_InSelectedKey_PropertyAddress, SetSelectedKey_FunctionAddress, "InSelectedKey");
		SetSelectedKey_InSelectedKey_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedKey_FunctionAddress, "InSelectedKey");
		SetSelectedKey_InSelectedKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedKey_FunctionAddress, "InSelectedKey", Classes.FStructProperty);
		SetSelectedKey_IsValid = SetSelectedKey_FunctionAddress != IntPtr.Zero && SetSelectedKey_InSelectedKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetSelectedKey", SetSelectedKey_IsValid);
		SetNoKeySpecifiedText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNoKeySpecifiedText");
		SetNoKeySpecifiedText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNoKeySpecifiedText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNoKeySpecifiedText_InNoKeySpecifiedText_PropertyAddress, SetNoKeySpecifiedText_FunctionAddress, "InNoKeySpecifiedText");
		SetNoKeySpecifiedText_InNoKeySpecifiedText_Offset = NativeReflectionCached.GetPropertyOffset(SetNoKeySpecifiedText_FunctionAddress, "InNoKeySpecifiedText");
		SetNoKeySpecifiedText_InNoKeySpecifiedText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNoKeySpecifiedText_FunctionAddress, "InNoKeySpecifiedText", Classes.FTextProperty);
		SetNoKeySpecifiedText_IsValid = SetNoKeySpecifiedText_FunctionAddress != IntPtr.Zero && SetNoKeySpecifiedText_InNoKeySpecifiedText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetNoKeySpecifiedText", SetNoKeySpecifiedText_IsValid);
		SetKeySelectionText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetKeySelectionText");
		SetKeySelectionText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetKeySelectionText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetKeySelectionText_InKeySelectionText_PropertyAddress, SetKeySelectionText_FunctionAddress, "InKeySelectionText");
		SetKeySelectionText_InKeySelectionText_Offset = NativeReflectionCached.GetPropertyOffset(SetKeySelectionText_FunctionAddress, "InKeySelectionText");
		SetKeySelectionText_InKeySelectionText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetKeySelectionText_FunctionAddress, "InKeySelectionText", Classes.FTextProperty);
		SetKeySelectionText_IsValid = SetKeySelectionText_FunctionAddress != IntPtr.Zero && SetKeySelectionText_InKeySelectionText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetKeySelectionText", SetKeySelectionText_IsValid);
		SetEscapeKeys_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEscapeKeys");
		SetEscapeKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEscapeKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEscapeKeys_InKeys_PropertyAddress, SetEscapeKeys_FunctionAddress, "InKeys");
		SetEscapeKeys_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetEscapeKeys_FunctionAddress, "InKeys");
		SetEscapeKeys_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEscapeKeys_FunctionAddress, "InKeys", Classes.FArrayProperty);
		SetEscapeKeys_IsValid = SetEscapeKeys_FunctionAddress != IntPtr.Zero && SetEscapeKeys_InKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetEscapeKeys", SetEscapeKeys_IsValid);
		SetAllowModifierKeys_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowModifierKeys");
		SetAllowModifierKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowModifierKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowModifierKeys_bInAllowModifierKeys_PropertyAddress, SetAllowModifierKeys_FunctionAddress, "bInAllowModifierKeys");
		SetAllowModifierKeys_bInAllowModifierKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowModifierKeys_FunctionAddress, "bInAllowModifierKeys");
		SetAllowModifierKeys_bInAllowModifierKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowModifierKeys_FunctionAddress, "bInAllowModifierKeys", Classes.FBoolProperty);
		SetAllowModifierKeys_IsValid = SetAllowModifierKeys_FunctionAddress != IntPtr.Zero && SetAllowModifierKeys_bInAllowModifierKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetAllowModifierKeys", SetAllowModifierKeys_IsValid);
		SetAllowGamepadKeys_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowGamepadKeys");
		SetAllowGamepadKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowGamepadKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowGamepadKeys_bInAllowGamepadKeys_PropertyAddress, SetAllowGamepadKeys_FunctionAddress, "bInAllowGamepadKeys");
		SetAllowGamepadKeys_bInAllowGamepadKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowGamepadKeys_FunctionAddress, "bInAllowGamepadKeys");
		SetAllowGamepadKeys_bInAllowGamepadKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowGamepadKeys_FunctionAddress, "bInAllowGamepadKeys", Classes.FBoolProperty);
		SetAllowGamepadKeys_IsValid = SetAllowGamepadKeys_FunctionAddress != IntPtr.Zero && SetAllowGamepadKeys_bInAllowGamepadKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:SetAllowGamepadKeys", SetAllowGamepadKeys_IsValid);
		GetIsSelectingKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsSelectingKey");
		GetIsSelectingKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsSelectingKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsSelectingKey_ReturnValue_PropertyAddress, GetIsSelectingKey_FunctionAddress, "ReturnValue");
		GetIsSelectingKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsSelectingKey_FunctionAddress, "ReturnValue");
		GetIsSelectingKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsSelectingKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsSelectingKey_IsValid = GetIsSelectingKey_FunctionAddress != IntPtr.Zero && GetIsSelectingKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InputKeySelector:GetIsSelectingKey", GetIsSelectingKey_IsValid);
	}
}
