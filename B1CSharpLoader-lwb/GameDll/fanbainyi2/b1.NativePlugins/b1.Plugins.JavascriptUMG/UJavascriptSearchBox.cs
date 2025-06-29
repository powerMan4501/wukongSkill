using System;
using System.Runtime.CompilerServices;
using b1.Plugins.V8;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptSearchBox : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextCommittedEvent__DelegateSignature")]
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
			OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextCommittedEvent__DelegateSignature");
			OnEditableTextCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextCommittedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextCommittedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnEditableTextCommittedEvent__DelegateSignature_IsValid = OnEditableTextCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextCommittedEvent__DelegateSignature_Text_IsValid && OnEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextCommittedEvent__DelegateSignature", OnEditableTextCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text, ETextCommit CommitMethod)
		{
			if (!OnEditableTextCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextCommittedEvent__DelegateSignature");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextChangedEvent__DelegateSignature")]
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
			OnEditableTextChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextChangedEvent__DelegateSignature");
			OnEditableTextChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress, OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextChangedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnEditableTextChangedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnEditableTextChangedEvent__DelegateSignature_IsValid = OnEditableTextChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEditableTextChangedEvent__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextChangedEvent__DelegateSignature", OnEditableTextChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnEditableTextChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnEditableTextChangedEvent__DelegateSignature");
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

	private static bool JavascriptContext_IsValid;

	private static int JavascriptContext_Offset;

	private static bool OnTextChanged_IsValid;

	private static int OnTextChanged_Offset;

	private FOnEditableTextChangedEvent OnTextChanged_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnEditableTextCommittedEvent OnTextCommitted_DelegateCached;

	private static bool HintText_IsValid;

	private static int HintText_Offset;

	private FText HintText_TextCached;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_InText_IsValid;

	private static FFieldAddress SetText_InText_PropertyAddress;

	private static int SetText_InText_Offset;

	private static bool SetHintText_IsValid;

	private static IntPtr SetHintText_FunctionAddress;

	private static int SetHintText_ParamsSize;

	private static bool SetHintText_InHintText_IsValid;

	private static FFieldAddress SetHintText_InHintText_PropertyAddress;

	private static int SetHintText_InHintText_Offset;

	private static bool OnKeyDown_IsValid;

	private IntPtr OnKeyDown_InstanceFunctionAddress;

	private static IntPtr OnKeyDown_FunctionAddress;

	private static int OnKeyDown_ParamsSize;

	private static bool OnKeyDown_MyGeometry_IsValid;

	private static FFieldAddress OnKeyDown_MyGeometry_PropertyAddress;

	private static int OnKeyDown_MyGeometry_Offset;

	private static bool OnKeyDown_InKeyEvent_IsValid;

	private static FFieldAddress OnKeyDown_InKeyEvent_PropertyAddress;

	private static int OnKeyDown_InKeyEvent_Offset;

	private static bool OnKeyDown_ReturnValue_IsValid;

	private static FFieldAddress OnKeyDown_ReturnValue_PropertyAddress;

	private static int OnKeyDown_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:JavascriptContext")]
	public UJavascriptContext JavascriptContext
	{
		get
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:JavascriptContext");
				return null;
			}
			return UObjectMarshaler<UJavascriptContext>.FromNative(IntPtr.Add(base.Address, JavascriptContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:JavascriptContext");
			}
			else
			{
				UObjectMarshaler<UJavascriptContext>.ToNative(IntPtr.Add(base.Address, JavascriptContext_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:OnTextChanged")]
	public FOnEditableTextChangedEvent OnTextChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTextChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnTextChanged");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:OnTextCommitted")]
	public FOnEditableTextCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnTextCommitted");
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

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:HintText")]
	public FText HintText
	{
		get
		{
			CheckDestroyed();
			if (!HintText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:HintText");
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
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptSearchBox:HintText");
				return;
			}
			if (HintText_TextCached == null)
			{
				HintText_TextCached = new FText(IntPtr.Add(base.Address, HintText_Offset), createReference: false);
			}
			HintText_TextCached.CopyFrom(value);
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:SetText");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:SetHintText")]
	public unsafe void SetHintText(FText InHintText)
	{
		CheckDestroyed();
		if (!SetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:SetHintText");
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

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptSearchBox:OnKeyDown")]
	public unsafe FEventReply OnKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnKeyDown");
			return null;
		}
		if (OnKeyDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnKeyDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnKeyDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyDown_MyGeometry_Offset), 0, OnKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyDown_InKeyEvent_Offset), 0, OnKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyDown_InstanceFunctionAddress, intPtr, OnKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyDown_ReturnValue_Offset), 0, OnKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptSearchBox:OnKeyDown");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyDown_MyGeometry_Offset), 0, OnKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyDown_InKeyEvent_Offset), 0, OnKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyDown_FunctionAddress, intPtr, OnKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyDown_ReturnValue_Offset), 0, OnKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UJavascriptSearchBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptSearchBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptSearchBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptSearchBox");
		JavascriptContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JavascriptContext");
		JavascriptContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JavascriptContext", Classes.FObjectProperty);
		OnTextChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextChanged");
		OnTextChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextChanged", Classes.FMulticastDelegateProperty);
		OnTextCommitted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextCommitted");
		OnTextCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextCommitted", Classes.FMulticastDelegateProperty);
		HintText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HintText");
		HintText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HintText", Classes.FTextProperty);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptSearchBox:SetText", SetText_IsValid);
		SetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHintText");
		SetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHintText_InHintText_PropertyAddress, SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_Offset = NativeReflectionCached.GetPropertyOffset(SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHintText_FunctionAddress, "InHintText", Classes.FTextProperty);
		SetHintText_IsValid = SetHintText_FunctionAddress != IntPtr.Zero && SetHintText_InHintText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptSearchBox:SetHintText", SetHintText_IsValid);
		OnKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyDown");
		OnKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_MyGeometry_PropertyAddress, OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_InKeyEvent_PropertyAddress, OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_ReturnValue_PropertyAddress, OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyDown_IsValid = OnKeyDown_FunctionAddress != IntPtr.Zero && OnKeyDown_MyGeometry_IsValid && OnKeyDown_InKeyEvent_IsValid && OnKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptSearchBox:OnKeyDown", OnKeyDown_IsValid);
	}
}
