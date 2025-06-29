using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ComboBoxKey", "UMG", UnrealModuleType.Engine)]
public class UComboBoxKey : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.ComboBoxKey:OnSelectionChangedEvent__DelegateSignature")]
	public class FOnSelectionChangedEvent : FMulticastDelegate<FOnSelectionChangedEvent.Signature>
	{
		public delegate void Signature(FName SelectedItem, ESelectInfo SelectionType);

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
			OnSelectionChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.ComboBoxKey:OnSelectionChangedEvent__DelegateSignature");
			OnSelectionChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress, OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem");
			OnSelectionChangedEvent__DelegateSignature_SelectedItem_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem");
			OnSelectionChangedEvent__DelegateSignature_SelectedItem_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectedItem", Classes.FNameProperty);
			NativeReflectionCached.GetPropertyRef(ref OnSelectionChangedEvent__DelegateSignature_SelectionType_PropertyAddress, OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType");
			OnSelectionChangedEvent__DelegateSignature_SelectionType_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType");
			OnSelectionChangedEvent__DelegateSignature_SelectionType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChangedEvent__DelegateSignature_FunctionAddress, "SelectionType", Classes.FByteProperty);
			OnSelectionChangedEvent__DelegateSignature_IsValid = OnSelectionChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSelectionChangedEvent__DelegateSignature_SelectedItem_IsValid && OnSelectionChangedEvent__DelegateSignature_SelectionType_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:OnSelectionChangedEvent__DelegateSignature", OnSelectionChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FName SelectedItem, ESelectInfo SelectionType)
		{
			if (!OnSelectionChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:OnSelectionChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnSelectionChangedEvent__DelegateSignature_SelectedItem_Offset), 0, OnSelectionChangedEvent__DelegateSignature_SelectedItem_PropertyAddress.Address, SelectedItem);
				EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChangedEvent__DelegateSignature_SelectionType_Offset), 0, OnSelectionChangedEvent__DelegateSignature_SelectionType_PropertyAddress.Address, SelectionType);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.ComboBoxKey:OnOpeningEvent__DelegateSignature")]
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
			OnOpeningEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.ComboBoxKey:OnOpeningEvent__DelegateSignature");
			OnOpeningEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOpeningEvent__DelegateSignature_FunctionAddress);
			OnOpeningEvent__DelegateSignature_IsValid = OnOpeningEvent__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:OnOpeningEvent__DelegateSignature", OnOpeningEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnOpeningEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:OnOpeningEvent__DelegateSignature");
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

	[UDelegate]
	[UMetaPath("/Script/UMG.ComboBoxKey:GenerateWidgetEvent__DelegateSignature")]
	public class FGenerateWidgetEvent : FDelegate<FGenerateWidgetEvent.Signature>
	{
		public delegate UWidget Signature(FName Item);

		private static bool GenerateWidgetEvent__DelegateSignature_IsValid;

		private static IntPtr GenerateWidgetEvent__DelegateSignature_FunctionAddress;

		private static int GenerateWidgetEvent__DelegateSignature_ParamsSize;

		private static bool GenerateWidgetEvent__DelegateSignature_Item_IsValid;

		private static FFieldAddress GenerateWidgetEvent__DelegateSignature_Item_PropertyAddress;

		private static int GenerateWidgetEvent__DelegateSignature_Item_Offset;

		private static bool GenerateWidgetEvent__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GenerateWidgetEvent__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GenerateWidgetEvent__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGenerateWidgetEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GenerateWidgetEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.ComboBoxKey:GenerateWidgetEvent__DelegateSignature");
			GenerateWidgetEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateWidgetEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetEvent__DelegateSignature_Item_PropertyAddress, GenerateWidgetEvent__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetEvent__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetEvent__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetEvent__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetEvent__DelegateSignature_FunctionAddress, "Item", Classes.FNameProperty);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetEvent__DelegateSignature_ReturnValue_PropertyAddress, GenerateWidgetEvent__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetEvent__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetEvent__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetEvent__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetEvent__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			GenerateWidgetEvent__DelegateSignature_IsValid = GenerateWidgetEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && GenerateWidgetEvent__DelegateSignature_Item_IsValid && GenerateWidgetEvent__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:GenerateWidgetEvent__DelegateSignature", GenerateWidgetEvent__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(FName Item)
		{
			if (!GenerateWidgetEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:GenerateWidgetEvent__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GenerateWidgetEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateWidgetEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GenerateWidgetEvent__DelegateSignature_Item_Offset), 0, GenerateWidgetEvent__DelegateSignature_Item_PropertyAddress.Address, Item);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GenerateWidgetEvent__DelegateSignature_ReturnValue_Offset), 0, GenerateWidgetEvent__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool ItemStyle_IsValid;

	private static int ItemStyle_Offset;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

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

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnGenerateContentWidget_IsValid;

	private static int OnGenerateContentWidget_Offset;

	private FGenerateWidgetEvent OnGenerateContentWidget_DelegateCached;

	private static bool OnGenerateItemWidget_IsValid;

	private static int OnGenerateItemWidget_Offset;

	private FGenerateWidgetEvent OnGenerateItemWidget_DelegateCached;

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

	private static bool RemoveOption_IsValid;

	private static IntPtr RemoveOption_FunctionAddress;

	private static int RemoveOption_ParamsSize;

	private static bool RemoveOption_Option_IsValid;

	private static FFieldAddress RemoveOption_Option_PropertyAddress;

	private static int RemoveOption_Option_Offset;

	private static bool RemoveOption_ReturnValue_IsValid;

	private static FFieldAddress RemoveOption_ReturnValue_PropertyAddress;

	private static int RemoveOption_ReturnValue_Offset;

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

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:WidgetStyle")]
	public FComboBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:WidgetStyle");
				return default(FComboBoxStyle);
			}
			return FComboBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:WidgetStyle");
			}
			else
			{
				FComboBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:ItemStyle")]
	public FTableRowStyle ItemStyle
	{
		get
		{
			CheckDestroyed();
			if (!ItemStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ItemStyle");
				return default(FTableRowStyle);
			}
			return FTableRowStyle.FromNative(IntPtr.Add(base.Address, ItemStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ItemStyle");
			}
			else
			{
				FTableRowStyle.ToNative(IntPtr.Add(base.Address, ItemStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:ForegroundColor")]
	public FSlateColor ForegroundColor
	{
		get
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ForegroundColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, ForegroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ForegroundColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, ForegroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:ContentPadding")]
	public FMargin ContentPadding
	{
		get
		{
			CheckDestroyed();
			if (!ContentPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ContentPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ContentPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContentPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:ContentPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ContentPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:MaxListHeight")]
	public float MaxListHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxListHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:MaxListHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxListHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxListHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:MaxListHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxListHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:bHasDownArrow")]
	public bool HasDownArrow
	{
		get
		{
			CheckDestroyed();
			if (!HasDownArrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bHasDownArrow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasDownArrow_Offset), 0, HasDownArrow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasDownArrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bHasDownArrow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasDownArrow_Offset), 0, HasDownArrow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:bEnableGamepadNavigationMode")]
	public bool EnableGamepadNavigationMode
	{
		get
		{
			CheckDestroyed();
			if (!EnableGamepadNavigationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bEnableGamepadNavigationMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableGamepadNavigationMode_Offset), 0, EnableGamepadNavigationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableGamepadNavigationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bEnableGamepadNavigationMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableGamepadNavigationMode_Offset), 0, EnableGamepadNavigationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:bIsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:bIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:OnGenerateContentWidget")]
	public FGenerateWidgetEvent OnGenerateContentWidget
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateContentWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:OnGenerateContentWidget");
				return new FGenerateWidgetEvent();
			}
			if (OnGenerateContentWidget_DelegateCached == null)
			{
				OnGenerateContentWidget_DelegateCached = new FGenerateWidgetEvent();
				OnGenerateContentWidget_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateContentWidget_Offset));
			}
			return OnGenerateContentWidget_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:OnGenerateItemWidget")]
	public FGenerateWidgetEvent OnGenerateItemWidget
	{
		get
		{
			CheckDestroyed();
			if (!OnGenerateItemWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:OnGenerateItemWidget");
				return new FGenerateWidgetEvent();
			}
			if (OnGenerateItemWidget_DelegateCached == null)
			{
				OnGenerateItemWidget_DelegateCached = new FGenerateWidgetEvent();
				OnGenerateItemWidget_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGenerateItemWidget_Offset));
			}
			return OnGenerateItemWidget_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.ComboBoxKey:OnSelectionChanged")]
	public FOnSelectionChangedEvent OnSelectionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:OnSelectionChanged");
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
	[UMetaPath("/Script/UMG.ComboBoxKey:OnOpening")]
	public FOnOpeningEvent OnOpening
	{
		get
		{
			CheckDestroyed();
			if (!OnOpening_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ComboBoxKey:OnOpening");
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
	[UMetaPath("/Script/UMG.ComboBoxKey:SetSelectedOption")]
	public unsafe void SetSelectedOption(FName Option)
	{
		CheckDestroyed();
		if (!SetSelectedOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:SetSelectedOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSelectedOption_Option_Offset), 0, SetSelectedOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedOption_FunctionAddress, intPtr, SetSelectedOption_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxKey:RemoveOption")]
	public unsafe bool RemoveOption(FName Option)
	{
		CheckDestroyed();
		if (!RemoveOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:RemoveOption");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveOption_Option_Offset), 0, RemoveOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveOption_FunctionAddress, intPtr, RemoveOption_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveOption_ReturnValue_Offset), 0, RemoveOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ComboBoxKey:IsOpen")]
	public unsafe bool IsOpen()
	{
		CheckDestroyed();
		if (!IsOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:IsOpen");
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
	[UMetaPath("/Script/UMG.ComboBoxKey:GetSelectedOption")]
	public unsafe FName GetSelectedOption()
	{
		CheckDestroyed();
		if (!GetSelectedOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:GetSelectedOption");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedOption_FunctionAddress, intPtr, GetSelectedOption_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetSelectedOption_ReturnValue_Offset), 0, GetSelectedOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxKey:ClearSelection")]
	public unsafe void ClearSelection()
	{
		CheckDestroyed();
		if (!ClearSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:ClearSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSelection_FunctionAddress, argsSize: ClearSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxKey:ClearOptions")]
	public unsafe void ClearOptions()
	{
		CheckDestroyed();
		if (!ClearOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:ClearOptions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOptions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearOptions_FunctionAddress, argsSize: ClearOptions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ComboBoxKey:AddOption")]
	public unsafe void AddOption(FName Option)
	{
		CheckDestroyed();
		if (!AddOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ComboBoxKey:AddOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddOption_Option_Offset), 0, AddOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOption_FunctionAddress, intPtr, AddOption_ParamsSize);
	}

	static UComboBoxKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UComboBoxKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UComboBoxKey));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ComboBoxKey");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		ItemStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemStyle");
		ItemStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemStyle", Classes.FStructProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		ContentPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContentPadding");
		ContentPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContentPadding", Classes.FStructProperty);
		MaxListHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxListHeight");
		MaxListHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxListHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HasDownArrow_PropertyAddress, intPtr, "bHasDownArrow");
		HasDownArrow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasDownArrow");
		HasDownArrow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasDownArrow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGamepadNavigationMode_PropertyAddress, intPtr, "bEnableGamepadNavigationMode");
		EnableGamepadNavigationMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableGamepadNavigationMode");
		EnableGamepadNavigationMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableGamepadNavigationMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "bIsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocusable", Classes.FBoolProperty);
		OnGenerateContentWidget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGenerateContentWidget");
		OnGenerateContentWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGenerateContentWidget", Classes.FDelegateProperty);
		OnGenerateItemWidget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGenerateItemWidget");
		OnGenerateItemWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGenerateItemWidget", Classes.FDelegateProperty);
		OnSelectionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSelectionChanged");
		OnSelectionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSelectionChanged", Classes.FMulticastDelegateProperty);
		OnOpening_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnOpening");
		OnOpening_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnOpening", Classes.FMulticastDelegateProperty);
		SetSelectedOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedOption");
		SetSelectedOption_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedOption_Option_PropertyAddress, SetSelectedOption_FunctionAddress, "Option");
		SetSelectedOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedOption_FunctionAddress, "Option");
		SetSelectedOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedOption_FunctionAddress, "Option", Classes.FNameProperty);
		SetSelectedOption_IsValid = SetSelectedOption_FunctionAddress != IntPtr.Zero && SetSelectedOption_Option_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:SetSelectedOption", SetSelectedOption_IsValid);
		RemoveOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveOption");
		RemoveOption_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveOption_Option_PropertyAddress, RemoveOption_FunctionAddress, "Option");
		RemoveOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOption_FunctionAddress, "Option");
		RemoveOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOption_FunctionAddress, "Option", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveOption_ReturnValue_PropertyAddress, RemoveOption_FunctionAddress, "ReturnValue");
		RemoveOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOption_FunctionAddress, "ReturnValue");
		RemoveOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOption_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveOption_IsValid = RemoveOption_FunctionAddress != IntPtr.Zero && RemoveOption_Option_IsValid && RemoveOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:RemoveOption", RemoveOption_IsValid);
		IsOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOpen");
		IsOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOpen_ReturnValue_PropertyAddress, IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOpen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOpen_IsValid = IsOpen_FunctionAddress != IntPtr.Zero && IsOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:IsOpen", IsOpen_IsValid);
		GetSelectedOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedOption");
		GetSelectedOption_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedOption_ReturnValue_PropertyAddress, GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedOption_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetSelectedOption_IsValid = GetSelectedOption_FunctionAddress != IntPtr.Zero && GetSelectedOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:GetSelectedOption", GetSelectedOption_IsValid);
		ClearSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSelection");
		ClearSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelection_FunctionAddress);
		ClearSelection_IsValid = ClearSelection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:ClearSelection", ClearSelection_IsValid);
		ClearOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearOptions");
		ClearOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearOptions_FunctionAddress);
		ClearOptions_IsValid = ClearOptions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:ClearOptions", ClearOptions_IsValid);
		AddOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOption");
		AddOption_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOption_Option_PropertyAddress, AddOption_FunctionAddress, "Option");
		AddOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(AddOption_FunctionAddress, "Option");
		AddOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOption_FunctionAddress, "Option", Classes.FNameProperty);
		AddOption_IsValid = AddOption_FunctionAddress != IntPtr.Zero && AddOption_Option_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ComboBoxKey:AddOption", AddOption_IsValid);
	}
}
