using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptIntSpinBox : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature")]
	public class FOnSpinBoxValueCommittedEvent : FMulticastDelegate<FOnSpinBoxValueCommittedEvent.Signature>
	{
		public delegate void Signature(int InValue, ETextCommit CommitMethod);

		private static bool OnSpinBoxValueCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnSpinBoxValueCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_IsValid;

		private static FFieldAddress OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_PropertyAddress;

		private static int OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_Offset;

		private static bool OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_IsValid;

		private static FFieldAddress OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress;

		private static int OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSpinBoxValueCommittedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature");
			OnSpinBoxValueCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_PropertyAddress, OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "InValue");
			OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_Offset = NativeReflectionCached.GetPropertyOffset(OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "InValue");
			OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "InValue", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnSpinBoxValueCommittedEvent__DelegateSignature_IsValid = OnSpinBoxValueCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_IsValid && OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature", OnSpinBoxValueCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(int InValue, ETextCommit CommitMethod)
		{
			if (!OnSpinBoxValueCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSpinBoxValueCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSpinBoxValueCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_Offset), 0, OnSpinBoxValueCommittedEvent__DelegateSignature_InValue_PropertyAddress.Address, InValue);
				EnumMarshaler<ETextCommit>.ToNative(IntPtr.Add(intPtr, OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_Offset), 0, OnSpinBoxValueCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress.Address, CommitMethod);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueChangedEvent__DelegateSignature")]
	public class FOnSpinBoxValueChangedEvent : FMulticastDelegate<FOnSpinBoxValueChangedEvent.Signature>
	{
		public delegate void Signature(int InValue);

		private static bool OnSpinBoxValueChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnSpinBoxValueChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnSpinBoxValueChangedEvent__DelegateSignature_InValue_IsValid;

		private static FFieldAddress OnSpinBoxValueChangedEvent__DelegateSignature_InValue_PropertyAddress;

		private static int OnSpinBoxValueChangedEvent__DelegateSignature_InValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSpinBoxValueChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueChangedEvent__DelegateSignature");
			OnSpinBoxValueChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSpinBoxValueChangedEvent__DelegateSignature_InValue_PropertyAddress, OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress, "InValue");
			OnSpinBoxValueChangedEvent__DelegateSignature_InValue_Offset = NativeReflectionCached.GetPropertyOffset(OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress, "InValue");
			OnSpinBoxValueChangedEvent__DelegateSignature_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress, "InValue", Classes.FIntProperty);
			OnSpinBoxValueChangedEvent__DelegateSignature_IsValid = OnSpinBoxValueChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSpinBoxValueChangedEvent__DelegateSignature_InValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueChangedEvent__DelegateSignature", OnSpinBoxValueChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(int InValue)
		{
			if (!OnSpinBoxValueChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxValueChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSpinBoxValueChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSpinBoxValueChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnSpinBoxValueChangedEvent__DelegateSignature_InValue_Offset), 0, OnSpinBoxValueChangedEvent__DelegateSignature_InValue_PropertyAddress.Address, InValue);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature")]
	public class FOnSpinBoxBeginSliderMovement : FMulticastDelegate<FOnSpinBoxBeginSliderMovement.Signature>
	{
		public delegate void Signature();

		private static bool OnSpinBoxBeginSliderMovement__DelegateSignature_IsValid;

		private static IntPtr OnSpinBoxBeginSliderMovement__DelegateSignature_FunctionAddress;

		private static int OnSpinBoxBeginSliderMovement__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSpinBoxBeginSliderMovement()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSpinBoxBeginSliderMovement__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature");
			OnSpinBoxBeginSliderMovement__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSpinBoxBeginSliderMovement__DelegateSignature_FunctionAddress);
			OnSpinBoxBeginSliderMovement__DelegateSignature_IsValid = OnSpinBoxBeginSliderMovement__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature", OnSpinBoxBeginSliderMovement__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnSpinBoxBeginSliderMovement__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSpinBoxBeginSliderMovement__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSpinBoxBeginSliderMovement__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool Delta_IsValid;

	private static int Delta_Offset;

	private static bool SliderExponent_IsValid;

	private static int SliderExponent_Offset;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool Justification_IsValid;

	private static FFieldAddress Justification_PropertyAddress;

	private static int Justification_Offset;

	private static bool MinDesiredWidth_IsValid;

	private static int MinDesiredWidth_Offset;

	private static bool ClearKeyboardFocusOnCommit_IsValid;

	private static FFieldAddress ClearKeyboardFocusOnCommit_PropertyAddress;

	private static int ClearKeyboardFocusOnCommit_Offset;

	private static bool SelectAllTextOnCommit_IsValid;

	private static FFieldAddress SelectAllTextOnCommit_PropertyAddress;

	private static int SelectAllTextOnCommit_Offset;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

	private static bool OnValueChanged_IsValid;

	private static int OnValueChanged_Offset;

	private FOnSpinBoxValueChangedEvent OnValueChanged_DelegateCached;

	private static bool OnValueCommitted_IsValid;

	private static int OnValueCommitted_Offset;

	private FOnSpinBoxValueCommittedEvent OnValueCommitted_DelegateCached;

	private static bool OnBeginSliderMovement_IsValid;

	private static int OnBeginSliderMovement_Offset;

	private FOnSpinBoxBeginSliderMovement OnBeginSliderMovement_DelegateCached;

	private static bool OnEndSliderMovement_IsValid;

	private static int OnEndSliderMovement_Offset;

	private FOnSpinBoxValueChangedEvent OnEndSliderMovement_DelegateCached;

	private static bool SetValue_IsValid;

	private static IntPtr SetValue_FunctionAddress;

	private static int SetValue_ParamsSize;

	private static bool SetValue_NewValue_IsValid;

	private static FFieldAddress SetValue_NewValue_PropertyAddress;

	private static int SetValue_NewValue_Offset;

	private static bool SetMinValue_IsValid;

	private static IntPtr SetMinValue_FunctionAddress;

	private static int SetMinValue_ParamsSize;

	private static bool SetMinValue_NewValue_IsValid;

	private static FFieldAddress SetMinValue_NewValue_PropertyAddress;

	private static int SetMinValue_NewValue_Offset;

	private static bool SetMinSliderValue_IsValid;

	private static IntPtr SetMinSliderValue_FunctionAddress;

	private static int SetMinSliderValue_ParamsSize;

	private static bool SetMinSliderValue_NewValue_IsValid;

	private static FFieldAddress SetMinSliderValue_NewValue_PropertyAddress;

	private static int SetMinSliderValue_NewValue_Offset;

	private static bool SetMaxValue_IsValid;

	private static IntPtr SetMaxValue_FunctionAddress;

	private static int SetMaxValue_ParamsSize;

	private static bool SetMaxValue_NewValue_IsValid;

	private static FFieldAddress SetMaxValue_NewValue_PropertyAddress;

	private static int SetMaxValue_NewValue_Offset;

	private static bool SetMaxSliderValue_IsValid;

	private static IntPtr SetMaxSliderValue_FunctionAddress;

	private static int SetMaxSliderValue_ParamsSize;

	private static bool SetMaxSliderValue_NewValue_IsValid;

	private static FFieldAddress SetMaxSliderValue_NewValue_PropertyAddress;

	private static int SetMaxSliderValue_NewValue_Offset;

	private static bool SetForegroundColor_IsValid;

	private static IntPtr SetForegroundColor_FunctionAddress;

	private static int SetForegroundColor_ParamsSize;

	private static bool SetForegroundColor_InForegroundColor_IsValid;

	private static FFieldAddress SetForegroundColor_InForegroundColor_PropertyAddress;

	private static int SetForegroundColor_InForegroundColor_Offset;

	private static bool GetValue_IsValid;

	private static IntPtr GetValue_FunctionAddress;

	private static int GetValue_ParamsSize;

	private static bool GetValue_ReturnValue_IsValid;

	private static FFieldAddress GetValue_ReturnValue_PropertyAddress;

	private static int GetValue_ReturnValue_Offset;

	private static bool GetMinValue_IsValid;

	private static IntPtr GetMinValue_FunctionAddress;

	private static int GetMinValue_ParamsSize;

	private static bool GetMinValue_ReturnValue_IsValid;

	private static FFieldAddress GetMinValue_ReturnValue_PropertyAddress;

	private static int GetMinValue_ReturnValue_Offset;

	private static bool GetMinSliderValue_IsValid;

	private static IntPtr GetMinSliderValue_FunctionAddress;

	private static int GetMinSliderValue_ParamsSize;

	private static bool GetMinSliderValue_ReturnValue_IsValid;

	private static FFieldAddress GetMinSliderValue_ReturnValue_PropertyAddress;

	private static int GetMinSliderValue_ReturnValue_Offset;

	private static bool GetMaxValue_IsValid;

	private static IntPtr GetMaxValue_FunctionAddress;

	private static int GetMaxValue_ParamsSize;

	private static bool GetMaxValue_ReturnValue_IsValid;

	private static FFieldAddress GetMaxValue_ReturnValue_PropertyAddress;

	private static int GetMaxValue_ReturnValue_Offset;

	private static bool GetMaxSliderValue_IsValid;

	private static IntPtr GetMaxSliderValue_FunctionAddress;

	private static int GetMaxSliderValue_ParamsSize;

	private static bool GetMaxSliderValue_ReturnValue_IsValid;

	private static FFieldAddress GetMaxSliderValue_ReturnValue_PropertyAddress;

	private static int GetMaxSliderValue_ReturnValue_Offset;

	private static bool ClearMinValue_IsValid;

	private static IntPtr ClearMinValue_FunctionAddress;

	private static int ClearMinValue_ParamsSize;

	private static bool ClearMinSliderValue_IsValid;

	private static IntPtr ClearMinSliderValue_FunctionAddress;

	private static int ClearMinSliderValue_ParamsSize;

	private static bool ClearMaxValue_IsValid;

	private static IntPtr ClearMaxValue_FunctionAddress;

	private static int ClearMaxValue_ParamsSize;

	private static bool ClearMaxSliderValue_IsValid;

	private static IntPtr ClearMaxSliderValue_FunctionAddress;

	private static int ClearMaxSliderValue_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:WidgetStyle")]
	public FSpinBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:WidgetStyle");
				return default(FSpinBoxStyle);
			}
			return FSpinBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:WidgetStyle");
			}
			else
			{
				FSpinBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:Delta")]
	public int Delta
	{
		get
		{
			CheckDestroyed();
			if (!Delta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Delta");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Delta_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Delta");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Delta_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SliderExponent")]
	public int SliderExponent
	{
		get
		{
			CheckDestroyed();
			if (!SliderExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SliderExponent");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SliderExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SliderExponent");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SliderExponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055765uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:Font")]
	public FSlateFontInfo Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Font");
				return default(FSlateFontInfo);
			}
			return FSlateFontInfo.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Font");
			}
			else
			{
				FSlateFontInfo.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:Justification")]
	public ETextJustify Justification
	{
		get
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Justification");
				return ETextJustify.Left;
			}
			return EnumMarshaler<ETextJustify>.FromNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Justification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:Justification");
			}
			else
			{
				EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(base.Address, Justification_Offset), 0, Justification_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:MinDesiredWidth")]
	public int MinDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:MinDesiredWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:MinDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearKeyboardFocusOnCommit")]
	public bool ClearKeyboardFocusOnCommit
	{
		get
		{
			CheckDestroyed();
			if (!ClearKeyboardFocusOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearKeyboardFocusOnCommit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClearKeyboardFocusOnCommit_Offset), 0, ClearKeyboardFocusOnCommit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClearKeyboardFocusOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearKeyboardFocusOnCommit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClearKeyboardFocusOnCommit_Offset), 0, ClearKeyboardFocusOnCommit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SelectAllTextOnCommit")]
	public bool SelectAllTextOnCommit
	{
		get
		{
			CheckDestroyed();
			if (!SelectAllTextOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SelectAllTextOnCommit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SelectAllTextOnCommit_Offset), 0, SelectAllTextOnCommit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelectAllTextOnCommit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SelectAllTextOnCommit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SelectAllTextOnCommit_Offset), 0, SelectAllTextOnCommit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ForegroundColor")]
	public FSlateColor ForegroundColor
	{
		get
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ForegroundColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, ForegroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ForegroundColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, ForegroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnValueChanged")]
	public FOnSpinBoxValueChangedEvent OnValueChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnValueChanged");
				return new FOnSpinBoxValueChangedEvent();
			}
			if (OnValueChanged_DelegateCached == null)
			{
				OnValueChanged_DelegateCached = new FOnSpinBoxValueChangedEvent();
				OnValueChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueChanged_Offset));
			}
			return OnValueChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnValueCommitted")]
	public FOnSpinBoxValueCommittedEvent OnValueCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnValueCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnValueCommitted");
				return new FOnSpinBoxValueCommittedEvent();
			}
			if (OnValueCommitted_DelegateCached == null)
			{
				OnValueCommitted_DelegateCached = new FOnSpinBoxValueCommittedEvent();
				OnValueCommitted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueCommitted_Offset));
			}
			return OnValueCommitted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnBeginSliderMovement")]
	public FOnSpinBoxBeginSliderMovement OnBeginSliderMovement
	{
		get
		{
			CheckDestroyed();
			if (!OnBeginSliderMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnBeginSliderMovement");
				return new FOnSpinBoxBeginSliderMovement();
			}
			if (OnBeginSliderMovement_DelegateCached == null)
			{
				OnBeginSliderMovement_DelegateCached = new FOnSpinBoxBeginSliderMovement();
				OnBeginSliderMovement_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBeginSliderMovement_Offset));
			}
			return OnBeginSliderMovement_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:OnEndSliderMovement")]
	public FOnSpinBoxValueChangedEvent OnEndSliderMovement
	{
		get
		{
			CheckDestroyed();
			if (!OnEndSliderMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:OnEndSliderMovement");
				return new FOnSpinBoxValueChangedEvent();
			}
			if (OnEndSliderMovement_DelegateCached == null)
			{
				OnEndSliderMovement_DelegateCached = new FOnSpinBoxValueChangedEvent();
				OnEndSliderMovement_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndSliderMovement_Offset));
			}
			return OnEndSliderMovement_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetValue")]
	public unsafe void SetValue(int NewValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetValue_NewValue_Offset), 0, SetValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinValue")]
	public unsafe void SetMinValue(int NewValue)
	{
		CheckDestroyed();
		if (!SetMinValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMinValue_NewValue_Offset), 0, SetMinValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinValue_FunctionAddress, intPtr, SetMinValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinSliderValue")]
	public unsafe void SetMinSliderValue(int NewValue)
	{
		CheckDestroyed();
		if (!SetMinSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinSliderValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinSliderValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMinSliderValue_NewValue_Offset), 0, SetMinSliderValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinSliderValue_FunctionAddress, intPtr, SetMinSliderValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxValue")]
	public unsafe void SetMaxValue(int NewValue)
	{
		CheckDestroyed();
		if (!SetMaxValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaxValue_NewValue_Offset), 0, SetMaxValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxValue_FunctionAddress, intPtr, SetMaxValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxSliderValue")]
	public unsafe void SetMaxSliderValue(int NewValue)
	{
		CheckDestroyed();
		if (!SetMaxSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxSliderValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxSliderValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaxSliderValue_NewValue_Offset), 0, SetMaxSliderValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxSliderValue_FunctionAddress, intPtr, SetMaxSliderValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:SetForegroundColor")]
	public unsafe void SetForegroundColor(FSlateColor InForegroundColor)
	{
		CheckDestroyed();
		if (!SetForegroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:SetForegroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForegroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForegroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetForegroundColor_InForegroundColor_PropertyAddress.Address, intPtr);
		FSlateColor.ToNative(IntPtr.Add(intPtr, SetForegroundColor_InForegroundColor_Offset), 0, SetForegroundColor_InForegroundColor_PropertyAddress.Address, InForegroundColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForegroundColor_FunctionAddress, intPtr, SetForegroundColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetForegroundColor_InForegroundColor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:GetValue")]
	public unsafe int GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:GetValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinValue")]
	public unsafe int GetMinValue()
	{
		CheckDestroyed();
		if (!GetMinValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinValue_FunctionAddress, intPtr, GetMinValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMinValue_ReturnValue_Offset), 0, GetMinValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinSliderValue")]
	public unsafe int GetMinSliderValue()
	{
		CheckDestroyed();
		if (!GetMinSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinSliderValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMinSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMinSliderValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMinSliderValue_FunctionAddress, intPtr, GetMinSliderValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMinSliderValue_ReturnValue_Offset), 0, GetMinSliderValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxValue")]
	public unsafe int GetMaxValue()
	{
		CheckDestroyed();
		if (!GetMaxValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxValue_FunctionAddress, intPtr, GetMaxValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaxValue_ReturnValue_Offset), 0, GetMaxValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxSliderValue")]
	public unsafe int GetMaxSliderValue()
	{
		CheckDestroyed();
		if (!GetMaxSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxSliderValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxSliderValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxSliderValue_FunctionAddress, intPtr, GetMaxSliderValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaxSliderValue_ReturnValue_Offset), 0, GetMaxSliderValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinValue")]
	public unsafe void ClearMinValue()
	{
		CheckDestroyed();
		if (!ClearMinValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMinValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMinValue_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMinValue_FunctionAddress, argsSize: ClearMinValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinSliderValue")]
	public unsafe void ClearMinSliderValue()
	{
		CheckDestroyed();
		if (!ClearMinSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinSliderValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMinSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMinSliderValue_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMinSliderValue_FunctionAddress, argsSize: ClearMinSliderValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxValue")]
	public unsafe void ClearMaxValue()
	{
		CheckDestroyed();
		if (!ClearMaxValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaxValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaxValue_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMaxValue_FunctionAddress, argsSize: ClearMaxValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxSliderValue")]
	public unsafe void ClearMaxSliderValue()
	{
		CheckDestroyed();
		if (!ClearMaxSliderValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxSliderValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaxSliderValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaxSliderValue_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMaxSliderValue_FunctionAddress, argsSize: ClearMaxSliderValue_ParamsSize);
	}

	static UJavascriptIntSpinBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptIntSpinBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptIntSpinBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptIntSpinBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		Delta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Delta");
		Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Delta", Classes.FIntProperty);
		SliderExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderExponent");
		SliderExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderExponent", Classes.FIntProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Justification_PropertyAddress, intPtr, "Justification");
		Justification_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Justification");
		Justification_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Justification", Classes.FByteProperty);
		MinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredWidth");
		MinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearKeyboardFocusOnCommit_PropertyAddress, intPtr, "ClearKeyboardFocusOnCommit");
		ClearKeyboardFocusOnCommit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClearKeyboardFocusOnCommit");
		ClearKeyboardFocusOnCommit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClearKeyboardFocusOnCommit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectAllTextOnCommit_PropertyAddress, intPtr, "SelectAllTextOnCommit");
		SelectAllTextOnCommit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectAllTextOnCommit");
		SelectAllTextOnCommit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectAllTextOnCommit", Classes.FBoolProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		OnValueChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueChanged");
		OnValueChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueChanged", Classes.FMulticastDelegateProperty);
		OnValueCommitted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueCommitted");
		OnValueCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueCommitted", Classes.FMulticastDelegateProperty);
		OnBeginSliderMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBeginSliderMovement");
		OnBeginSliderMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBeginSliderMovement", Classes.FMulticastDelegateProperty);
		OnEndSliderMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEndSliderMovement");
		OnEndSliderMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEndSliderMovement", Classes.FMulticastDelegateProperty);
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_NewValue_PropertyAddress, SetValue_FunctionAddress, "NewValue");
		SetValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "NewValue");
		SetValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetValue", SetValue_IsValid);
		SetMinValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinValue");
		SetMinValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinValue_NewValue_PropertyAddress, SetMinValue_FunctionAddress, "NewValue");
		SetMinValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMinValue_FunctionAddress, "NewValue");
		SetMinValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinValue_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetMinValue_IsValid = SetMinValue_FunctionAddress != IntPtr.Zero && SetMinValue_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinValue", SetMinValue_IsValid);
		SetMinSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinSliderValue");
		SetMinSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinSliderValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinSliderValue_NewValue_PropertyAddress, SetMinSliderValue_FunctionAddress, "NewValue");
		SetMinSliderValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMinSliderValue_FunctionAddress, "NewValue");
		SetMinSliderValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinSliderValue_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetMinSliderValue_IsValid = SetMinSliderValue_FunctionAddress != IntPtr.Zero && SetMinSliderValue_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMinSliderValue", SetMinSliderValue_IsValid);
		SetMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxValue");
		SetMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxValue_NewValue_PropertyAddress, SetMaxValue_FunctionAddress, "NewValue");
		SetMaxValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxValue_FunctionAddress, "NewValue");
		SetMaxValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxValue_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetMaxValue_IsValid = SetMaxValue_FunctionAddress != IntPtr.Zero && SetMaxValue_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxValue", SetMaxValue_IsValid);
		SetMaxSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxSliderValue");
		SetMaxSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxSliderValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxSliderValue_NewValue_PropertyAddress, SetMaxSliderValue_FunctionAddress, "NewValue");
		SetMaxSliderValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxSliderValue_FunctionAddress, "NewValue");
		SetMaxSliderValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxSliderValue_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetMaxSliderValue_IsValid = SetMaxSliderValue_FunctionAddress != IntPtr.Zero && SetMaxSliderValue_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetMaxSliderValue", SetMaxSliderValue_IsValid);
		SetForegroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForegroundColor");
		SetForegroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForegroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForegroundColor_InForegroundColor_PropertyAddress, SetForegroundColor_FunctionAddress, "InForegroundColor");
		SetForegroundColor_InForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(SetForegroundColor_FunctionAddress, "InForegroundColor");
		SetForegroundColor_InForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForegroundColor_FunctionAddress, "InForegroundColor", Classes.FStructProperty);
		SetForegroundColor_IsValid = SetForegroundColor_FunctionAddress != IntPtr.Zero && SetForegroundColor_InForegroundColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:SetForegroundColor", SetForegroundColor_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:GetValue", GetValue_IsValid);
		GetMinValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMinValue");
		GetMinValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinValue_ReturnValue_PropertyAddress, GetMinValue_FunctionAddress, "ReturnValue");
		GetMinValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMinValue_FunctionAddress, "ReturnValue");
		GetMinValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMinValue_IsValid = GetMinValue_FunctionAddress != IntPtr.Zero && GetMinValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinValue", GetMinValue_IsValid);
		GetMinSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMinSliderValue");
		GetMinSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMinSliderValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMinSliderValue_ReturnValue_PropertyAddress, GetMinSliderValue_FunctionAddress, "ReturnValue");
		GetMinSliderValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMinSliderValue_FunctionAddress, "ReturnValue");
		GetMinSliderValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMinSliderValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMinSliderValue_IsValid = GetMinSliderValue_FunctionAddress != IntPtr.Zero && GetMinSliderValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMinSliderValue", GetMinSliderValue_IsValid);
		GetMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxValue");
		GetMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxValue_ReturnValue_PropertyAddress, GetMaxValue_FunctionAddress, "ReturnValue");
		GetMaxValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxValue_FunctionAddress, "ReturnValue");
		GetMaxValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaxValue_IsValid = GetMaxValue_FunctionAddress != IntPtr.Zero && GetMaxValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxValue", GetMaxValue_IsValid);
		GetMaxSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxSliderValue");
		GetMaxSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxSliderValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxSliderValue_ReturnValue_PropertyAddress, GetMaxSliderValue_FunctionAddress, "ReturnValue");
		GetMaxSliderValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxSliderValue_FunctionAddress, "ReturnValue");
		GetMaxSliderValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxSliderValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaxSliderValue_IsValid = GetMaxSliderValue_FunctionAddress != IntPtr.Zero && GetMaxSliderValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:GetMaxSliderValue", GetMaxSliderValue_IsValid);
		ClearMinValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMinValue");
		ClearMinValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMinValue_FunctionAddress);
		ClearMinValue_IsValid = ClearMinValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinValue", ClearMinValue_IsValid);
		ClearMinSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMinSliderValue");
		ClearMinSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMinSliderValue_FunctionAddress);
		ClearMinSliderValue_IsValid = ClearMinSliderValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMinSliderValue", ClearMinSliderValue_IsValid);
		ClearMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMaxValue");
		ClearMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaxValue_FunctionAddress);
		ClearMaxValue_IsValid = ClearMaxValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxValue", ClearMaxValue_IsValid);
		ClearMaxSliderValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMaxSliderValue");
		ClearMaxSliderValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaxSliderValue_FunctionAddress);
		ClearMaxSliderValue_IsValid = ClearMaxSliderValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptIntSpinBox:ClearMaxSliderValue", ClearMaxSliderValue_IsValid);
	}
}
