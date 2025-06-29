using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ComboBoxString", "UMG", UnrealModuleType.Engine)]
public class UComboBoxString : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature")]
	public class FOnSelectionChangedEvent : FMulticastDelegate<FOnSelectionChangedEvent.Signature>
	{
		public delegate void Signature(string SelectedItem, ESelectInfo SelectionType);

		private static bool OnSelectionChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnSelectionChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnSelectionChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnSelectionChangedEvent__DelegateSignature_SelectedItem_IsValid;

		private static FFieldAddress OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress;

		private static int OnSelectionChangedEvent__DelegateSignature_SelectedItem_Offset;

		private static bool OnSelectionChangedEvent__DelegateSignature_SelectionType_IsValid;

		private static FFieldAddress OnSelectionChangedEvent__DelegateSignature_SelectionType_PropertyAddress;

		private static int OnSelectionChangedEvent__DelegateSignature_SelectionType_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSelectionChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSelectionChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature");
			OnSelectionChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress, OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem");
			OnSelectionChangedEvent__DelegateSignature_SelectedItem_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem");
			OnSelectionChangedEvent__DelegateSignature_SelectedItem_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref OnSelectionChangedEvent__DelegateSignature_SelectionType_PropertyAddress, OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType");
			OnSelectionChangedEvent__DelegateSignature_SelectionType_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType");
			OnSelectionChangedEvent__DelegateSignature_SelectionType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType", Classes.FByteProperty);
			OnSelectionChangedEvent__DelegateSignature_IsValid = OnSelectionChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSelectionChangedEvent__DelegateSignature_SelectedItem_IsValid && OnSelectionChangedEvent__DelegateSignature_SelectionType_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature", OnSelectionChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string SelectedItem, ESelectInfo SelectionType)
		{
			if (!OnSelectionChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnSelectionChangedEvent__DelegateSignature_SelectedItem_Offset), 0, OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress.Address, SelectedItem);
				EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChangedEvent__DelegateSignature_SelectionType_Offset), 0, OnSelectionChangedEvent__DelegateSignature_SelectionType_PropertyAddress.Address, SelectionType);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature")]
	public class FOnOpeningEvent : FMulticastDelegate<FOnOpeningEvent.Signature>
	{
		public delegate void Signature();

		private static bool OnOpeningEvent__DelegateSignature_IsValid;

		private static IntPtr OnOpeningEvent__DelegateSignature_FunctionAddress;

		private static int OnOpeningEvent__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnOpeningEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnOpeningEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature");
			OnOpeningEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOpeningEvent__DelegateSignature_FunctionAddress);
			OnOpeningEvent__DelegateSignature_IsValid = OnOpeningEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature", OnOpeningEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnOpeningEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnOpeningEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOpeningEvent__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool ItemStyle_IsValid;

	private static int ItemStyle_Offset;

	private static bool ContentPadding_IsValid;

	private static int ContentPadding_Offset;

	private static bool MaxListHeight_IsValid;

	private static int MaxListHeight_Offset;

	private static bool HasDownArrow_IsValid;

	private static FFieldAddress HasDownArrow_PropertyAddress;

	private static int HasDownArrow_Offset;

	private static bool EnableGamepadNavigationMode_IsValid;

	private static FFieldAddress EnableGamepadNavigationMode_PropertyAddress;

	private static int EnableGamepadNavigationMode_Offset;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnGenerateWidgetEvent_IsValid;

	private static int OnGenerateWidgetEvent_Offset;

	private FGenerateWidgetForString OnGenerateWidgetEvent_DelegateCached;

	private static bool OnSelectionChanged_IsValid;

	private static int OnSelectionChanged_Offset;

	private FOnSelectionChangedEvent OnSelectionChanged_DelegateCached;

	private static bool OnOpening_IsValid;

	private static int OnOpening_Offset;

	private FOnOpeningEvent OnOpening_DelegateCached;

	private static bool SetSelectedOption_IsValid;

	private static IntPtr SetSelectedOption_FunctionAddress;

	private static int SetSelectedOption_ParamsSize;

	private static bool SetSelectedOption_Option_IsValid;

	private static FFieldAddress SetSelectedOption_Option_PropertyAddress;

	private static int SetSelectedOption_Option_Offset;

	private static bool SetSelectedIndex_IsValid;

	private static IntPtr SetSelectedIndex_FunctionAddress;

	private static int SetSelectedIndex_ParamsSize;

	private static bool SetSelectedIndex_Index_IsValid;

	private static FFieldAddress SetSelectedIndex_Index_PropertyAddress;

	private static int SetSelectedIndex_Index_Offset;

	private static bool RemoveOption_IsValid;

	private static IntPtr RemoveOption_FunctionAddress;

	private static int RemoveOption_ParamsSize;

	private static bool RemoveOption_Option_IsValid;

	private static FFieldAddress RemoveOption_Option_PropertyAddress;

	private static int RemoveOption_Option_Offset;

	private static bool RemoveOption_ReturnValue_IsValid;

	private static FFieldAddress RemoveOption_ReturnValue_PropertyAddress;

	private static int RemoveOption_ReturnValue_Offset;

	private static bool RefreshOptions_IsValid;

	private static IntPtr RefreshOptions_FunctionAddress;

	private static int RefreshOptions_ParamsSize;

	private static bool IsOpen_IsValid;

	private static IntPtr IsOpen_FunctionAddress;

	private static int IsOpen_ParamsSize;

	private static bool IsOpen_ReturnValue_IsValid;

	private static FFieldAddress IsOpen_ReturnValue_PropertyAddress;

	private static int IsOpen_ReturnValue_Offset;

	private static bool GetSelectedOption_IsValid;

	private static IntPtr GetSelectedOption_FunctionAddress;

	private static int GetSelectedOption_ParamsSize;

	private static bool GetSelectedOption_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedOption_ReturnValue_PropertyAddress;

	private static int GetSelectedOption_ReturnValue_Offset;

	private static bool GetSelectedIndex_IsValid;

	private static IntPtr GetSelectedIndex_FunctionAddress;

	private static int GetSelectedIndex_ParamsSize;

	private static bool GetSelectedIndex_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedIndex_ReturnValue_PropertyAddress;

	private static int GetSelectedIndex_ReturnValue_Offset;

	private static bool GetOptionCount_IsValid;

	private static IntPtr GetOptionCount_FunctionAddress;

	private static int GetOptionCount_ParamsSize;

	private static bool GetOptionCount_ReturnValue_IsValid;

	private static FFieldAddress GetOptionCount_ReturnValue_PropertyAddress;

	private static int GetOptionCount_ReturnValue_Offset;

	private static bool GetOptionAtIndex_IsValid;

	private static IntPtr GetOptionAtIndex_FunctionAddress;

	private static int GetOptionAtIndex_ParamsSize;

	private static bool GetOptionAtIndex_Index_IsValid;

	private static FFieldAddress GetOptionAtIndex_Index_PropertyAddress;

	private static int GetOptionAtIndex_Index_Offset;

	private static bool GetOptionAtIndex_ReturnValue_IsValid;

	private static FFieldAddress GetOptionAtIndex_ReturnValue_PropertyAddress;

	private static int GetOptionAtIndex_ReturnValue_Offset;

	private static bool FindOptionIndex_IsValid;

	private static IntPtr FindOptionIndex_FunctionAddress;

	private static int FindOptionIndex_ParamsSize;

	private static bool FindOptionIndex_Option_IsValid;

	private static FFieldAddress FindOptionIndex_Option_PropertyAddress;

	private static int FindOptionIndex_Option_Offset;

	private static bool FindOptionIndex_ReturnValue_IsValid;

	private static FFieldAddress FindOptionIndex_ReturnValue_PropertyAddress;

	private static int FindOptionIndex_ReturnValue_Offset;

	private static bool ClearSelection_IsValid;

	private static IntPtr ClearSelection_FunctionAddress;

	private static int ClearSelection_ParamsSize;

	private static bool ClearOptions_IsValid;

	private static IntPtr ClearOptions_FunctionAddress;

	private static int ClearOptions_ParamsSize;

	private static bool AddOption_IsValid;

	private static IntPtr AddOption_FunctionAddress;

	private static int AddOption_ParamsSize;

	private static bool AddOption_Option_IsValid;

	private static FFieldAddress AddOption_Option_PropertyAddress;

	private static int AddOption_Option_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:WidgetStyle")]
	public FComboBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:WidgetStyle");
				return default(FComboBoxStyle);
			}
			return FComboBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:WidgetStyle");
			}
			else
			{
				FComboBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:ItemStyle")]
	public FTableRowStyle ItemStyle
	{
		get
		{
			CheckDestroyed();
			if (!ItemStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ItemStyle");
				return default(FTableRowStyle);
			}
			return FTableRowStyle.FromNative(IntPtr.Add(base.Address, ItemStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ItemStyle");
			}
			else
			{
				FTableRowStyle.ToNative(IntPtr.Add(base.Address, ItemStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:ContentPadding")]
	public FMargin ContentPadding
	{
		get
		{
			CheckDestroyed();
			if (!ContentPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ContentPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ContentPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContentPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ContentPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ContentPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:MaxListHeight")]
	public float MaxListHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxListHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:MaxListHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxListHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxListHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:MaxListHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxListHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:HasDownArrow")]
	public bool HasDownArrow
	{
		get
		{
			CheckDestroyed();
			if (!HasDownArrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:HasDownArrow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasDownArrow_Offset), 0, HasDownArrow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasDownArrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:HasDownArrow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasDownArrow_Offset), 0, HasDownArrow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:EnableGamepadNavigationMode")]
	public bool EnableGamepadNavigationMode
	{
		get
		{
			CheckDestroyed();
			if (!EnableGamepadNavigationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:EnableGamepadNavigationMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableGamepadNavigationMode_Offset), 0, EnableGamepadNavigationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableGamepadNavigationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:EnableGamepadNavigationMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableGamepadNavigationMode_Offset), 0, EnableGamepadNavigationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055765uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:Font")]
	public FSlateFontInfo Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:Font");
				return default(FSlateFontInfo);
			}
			return FSlateFontInfo.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:Font");
			}
			else
			{
				FSlateFontInfo.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:ForegroundColor")]
	public FSlateColor ForegroundColor
	{
		get
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ForegroundColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, ForegroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:ForegroundColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, ForegroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:bIsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:bIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:bIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:OnGenerateWidgetEvent")]
	public FGenerateWidgetForString OnGenerateWidgetEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateWidgetEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:OnGenerateWidgetEvent");
				return new FGenerateWidgetForString();
			}
			if (OnGenerateWidgetEvent_DelegateCached == null)
			{
				OnGenerateWidgetEvent_DelegateCached = new FGenerateWidgetForString();
				OnGenerateWidgetEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateWidgetEvent_Offset));
			}
			return OnGenerateWidgetEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:OnSelectionChanged")]
	public FOnSelectionChangedEvent OnSelectionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:OnSelectionChanged");
				return new FOnSelectionChangedEvent();
			}
			if (OnSelectionChanged_DelegateCached == null)
			{
				OnSelectionChanged_DelegateCached = new FOnSelectionChangedEvent();
				OnSelectionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectionChanged_Offset));
			}
			return OnSelectionChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.ComboBoxString:OnOpening")]
	public FOnOpeningEvent OnOpening
	{
		get
		{
			CheckDestroyed();
			if (!OnOpening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxString:OnOpening");
				return new FOnOpeningEvent();
			}
			if (OnOpening_DelegateCached == null)
			{
				OnOpening_DelegateCached = new FOnOpeningEvent();
				OnOpening_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnOpening_Offset));
			}
			return OnOpening_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:SetSelectedOption")]
	public unsafe void SetSelectedOption(string Option)
	{
		CheckDestroyed();
		if (!SetSelectedOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:SetSelectedOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSelectedOption_Option_Offset), 0, SetSelectedOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedOption_FunctionAddress, intPtr, SetSelectedOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSelectedOption_Option_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:SetSelectedIndex")]
	public unsafe void SetSelectedIndex(int Index)
	{
		CheckDestroyed();
		if (!SetSelectedIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:SetSelectedIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSelectedIndex_Index_Offset), 0, SetSelectedIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedIndex_FunctionAddress, intPtr, SetSelectedIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:RemoveOption")]
	public unsafe bool RemoveOption(string Option)
	{
		CheckDestroyed();
		if (!RemoveOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:RemoveOption");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveOption_Option_Offset), 0, RemoveOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveOption_FunctionAddress, intPtr, RemoveOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveOption_Option_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveOption_ReturnValue_Offset), 0, RemoveOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:RefreshOptions")]
	public unsafe void RefreshOptions()
	{
		CheckDestroyed();
		if (!RefreshOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:RefreshOptions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshOptions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshOptions_FunctionAddress, argsSize: RefreshOptions_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:IsOpen")]
	public unsafe bool IsOpen()
	{
		CheckDestroyed();
		if (!IsOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:IsOpen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOpen_FunctionAddress, intPtr, IsOpen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOpen_ReturnValue_Offset), 0, IsOpen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:GetSelectedOption")]
	public unsafe string GetSelectedOption()
	{
		CheckDestroyed();
		if (!GetSelectedOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:GetSelectedOption");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedOption_FunctionAddress, intPtr, GetSelectedOption_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSelectedOption_ReturnValue_Offset), 0, GetSelectedOption_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectedOption_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:GetSelectedIndex")]
	public unsafe int GetSelectedIndex()
	{
		CheckDestroyed();
		if (!GetSelectedIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:GetSelectedIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedIndex_FunctionAddress, intPtr, GetSelectedIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectedIndex_ReturnValue_Offset), 0, GetSelectedIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:GetOptionCount")]
	public unsafe int GetOptionCount()
	{
		CheckDestroyed();
		if (!GetOptionCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:GetOptionCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOptionCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOptionCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOptionCount_FunctionAddress, intPtr, GetOptionCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOptionCount_ReturnValue_Offset), 0, GetOptionCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:GetOptionAtIndex")]
	public unsafe string GetOptionAtIndex(int Index)
	{
		CheckDestroyed();
		if (!GetOptionAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:GetOptionAtIndex");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOptionAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOptionAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetOptionAtIndex_Index_Offset), 0, GetOptionAtIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOptionAtIndex_FunctionAddress, intPtr, GetOptionAtIndex_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetOptionAtIndex_ReturnValue_Offset), 0, GetOptionAtIndex_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOptionAtIndex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxString:FindOptionIndex")]
	public unsafe int FindOptionIndex(string Option)
	{
		CheckDestroyed();
		if (!FindOptionIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:FindOptionIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOptionIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOptionIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindOptionIndex_Option_Offset), 0, FindOptionIndex_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindOptionIndex_FunctionAddress, intPtr, FindOptionIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindOptionIndex_Option_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindOptionIndex_ReturnValue_Offset), 0, FindOptionIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:ClearSelection")]
	public unsafe void ClearSelection()
	{
		CheckDestroyed();
		if (!ClearSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:ClearSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSelection_FunctionAddress, argsSize: ClearSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:ClearOptions")]
	public unsafe void ClearOptions()
	{
		CheckDestroyed();
		if (!ClearOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:ClearOptions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOptions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearOptions_FunctionAddress, argsSize: ClearOptions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxString:AddOption")]
	public unsafe void AddOption(string Option)
	{
		CheckDestroyed();
		if (!AddOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxString:AddOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddOption_Option_Offset), 0, AddOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOption_FunctionAddress, intPtr, AddOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddOption_Option_PropertyAddress.Address, intPtr);
	}

	static UComboBoxString()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UComboBoxString)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UComboBoxString));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ComboBoxString");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		ItemStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemStyle");
		ItemStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemStyle", Classes.FStructProperty);
		ContentPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContentPadding");
		ContentPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContentPadding", Classes.FStructProperty);
		MaxListHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxListHeight");
		MaxListHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxListHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HasDownArrow_PropertyAddress, intPtr, "HasDownArrow");
		HasDownArrow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HasDownArrow");
		HasDownArrow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HasDownArrow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGamepadNavigationMode_PropertyAddress, intPtr, "EnableGamepadNavigationMode");
		EnableGamepadNavigationMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableGamepadNavigationMode");
		EnableGamepadNavigationMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableGamepadNavigationMode", Classes.FBoolProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "bIsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocusable", Classes.FBoolProperty);
		OnGenerateWidgetEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGenerateWidgetEvent");
		OnGenerateWidgetEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGenerateWidgetEvent", Classes.FDelegateProperty);
		OnSelectionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSelectionChanged");
		OnSelectionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSelectionChanged", Classes.FMulticastDelegateProperty);
		OnOpening_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnOpening");
		OnOpening_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnOpening", Classes.FMulticastDelegateProperty);
		SetSelectedOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedOption");
		SetSelectedOption_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedOption_Option_PropertyAddress, SetSelectedOption_FunctionAddress, "Option");
		SetSelectedOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedOption_FunctionAddress, "Option");
		SetSelectedOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedOption_FunctionAddress, "Option", Classes.FStrProperty);
		SetSelectedOption_IsValid = SetSelectedOption_FunctionAddress != IntPtr.Zero && SetSelectedOption_Option_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:SetSelectedOption", SetSelectedOption_IsValid);
		SetSelectedIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedIndex");
		SetSelectedIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedIndex_Index_PropertyAddress, SetSelectedIndex_FunctionAddress, "Index");
		SetSelectedIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedIndex_FunctionAddress, "Index");
		SetSelectedIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedIndex_FunctionAddress, "Index", Classes.FIntProperty);
		SetSelectedIndex_IsValid = SetSelectedIndex_FunctionAddress != IntPtr.Zero && SetSelectedIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:SetSelectedIndex", SetSelectedIndex_IsValid);
		RemoveOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveOption");
		RemoveOption_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveOption_Option_PropertyAddress, RemoveOption_FunctionAddress, "Option");
		RemoveOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOption_FunctionAddress, "Option");
		RemoveOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOption_FunctionAddress, "Option", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveOption_ReturnValue_PropertyAddress, RemoveOption_FunctionAddress, "ReturnValue");
		RemoveOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOption_FunctionAddress, "ReturnValue");
		RemoveOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOption_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveOption_IsValid = RemoveOption_FunctionAddress != IntPtr.Zero && RemoveOption_Option_IsValid && RemoveOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:RemoveOption", RemoveOption_IsValid);
		RefreshOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshOptions");
		RefreshOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshOptions_FunctionAddress);
		RefreshOptions_IsValid = RefreshOptions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:RefreshOptions", RefreshOptions_IsValid);
		IsOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOpen");
		IsOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOpen_ReturnValue_PropertyAddress, IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOpen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOpen_IsValid = IsOpen_FunctionAddress != IntPtr.Zero && IsOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:IsOpen", IsOpen_IsValid);
		GetSelectedOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedOption");
		GetSelectedOption_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedOption_ReturnValue_PropertyAddress, GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedOption_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSelectedOption_IsValid = GetSelectedOption_FunctionAddress != IntPtr.Zero && GetSelectedOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:GetSelectedOption", GetSelectedOption_IsValid);
		GetSelectedIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedIndex");
		GetSelectedIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedIndex_ReturnValue_PropertyAddress, GetSelectedIndex_FunctionAddress, "ReturnValue");
		GetSelectedIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedIndex_FunctionAddress, "ReturnValue");
		GetSelectedIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectedIndex_IsValid = GetSelectedIndex_FunctionAddress != IntPtr.Zero && GetSelectedIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:GetSelectedIndex", GetSelectedIndex_IsValid);
		GetOptionCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOptionCount");
		GetOptionCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOptionCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOptionCount_ReturnValue_PropertyAddress, GetOptionCount_FunctionAddress, "ReturnValue");
		GetOptionCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOptionCount_FunctionAddress, "ReturnValue");
		GetOptionCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOptionCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetOptionCount_IsValid = GetOptionCount_FunctionAddress != IntPtr.Zero && GetOptionCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:GetOptionCount", GetOptionCount_IsValid);
		GetOptionAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOptionAtIndex");
		GetOptionAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOptionAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOptionAtIndex_Index_PropertyAddress, GetOptionAtIndex_FunctionAddress, "Index");
		GetOptionAtIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetOptionAtIndex_FunctionAddress, "Index");
		GetOptionAtIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOptionAtIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOptionAtIndex_ReturnValue_PropertyAddress, GetOptionAtIndex_FunctionAddress, "ReturnValue");
		GetOptionAtIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOptionAtIndex_FunctionAddress, "ReturnValue");
		GetOptionAtIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOptionAtIndex_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOptionAtIndex_IsValid = GetOptionAtIndex_FunctionAddress != IntPtr.Zero && GetOptionAtIndex_Index_IsValid && GetOptionAtIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:GetOptionAtIndex", GetOptionAtIndex_IsValid);
		FindOptionIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindOptionIndex");
		FindOptionIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOptionIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOptionIndex_Option_PropertyAddress, FindOptionIndex_FunctionAddress, "Option");
		FindOptionIndex_Option_Offset = NativeReflectionCached.GetPropertyOffset(FindOptionIndex_FunctionAddress, "Option");
		FindOptionIndex_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOptionIndex_FunctionAddress, "Option", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOptionIndex_ReturnValue_PropertyAddress, FindOptionIndex_FunctionAddress, "ReturnValue");
		FindOptionIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindOptionIndex_FunctionAddress, "ReturnValue");
		FindOptionIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOptionIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindOptionIndex_IsValid = FindOptionIndex_FunctionAddress != IntPtr.Zero && FindOptionIndex_Option_IsValid && FindOptionIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:FindOptionIndex", FindOptionIndex_IsValid);
		ClearSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSelection");
		ClearSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelection_FunctionAddress);
		ClearSelection_IsValid = ClearSelection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:ClearSelection", ClearSelection_IsValid);
		ClearOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearOptions");
		ClearOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearOptions_FunctionAddress);
		ClearOptions_IsValid = ClearOptions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:ClearOptions", ClearOptions_IsValid);
		AddOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOption");
		AddOption_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOption_Option_PropertyAddress, AddOption_FunctionAddress, "Option");
		AddOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(AddOption_FunctionAddress, "Option");
		AddOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOption_FunctionAddress, "Option", Classes.FStrProperty);
		AddOption_IsValid = AddOption_FunctionAddress != IntPtr.Zero && AddOption_Option_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxString:AddOption", AddOption_IsValid);
	}
}
