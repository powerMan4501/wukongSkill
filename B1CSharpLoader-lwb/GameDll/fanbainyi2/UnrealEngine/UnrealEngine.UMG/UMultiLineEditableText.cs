using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.MultiLineEditableText", "UMG", UnrealModuleType.Engine)]
public class UMultiLineEditableText : UTextLayoutWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature")]
	public class FOnMultiLineEditableTextCommittedEvent : FMulticastDelegate<FOnMultiLineEditableTextCommittedEvent.Signature>
	{
		public delegate void Signature(FText Text, ETextCommit CommitMethod);

		private static bool OnMultiLineEditableTextCommittedEvent__DelegateSignature_IsValid;

		private static IntPtr OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress;

		private static int OnMultiLineEditableTextCommittedEvent__DelegateSignature_ParamsSize;

		private static bool OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_Offset;

		private static bool OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid;

		private static FFieldAddress OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress;

		private static int OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMultiLineEditableTextCommittedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature");
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress, OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress, OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod");
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress, "CommitMethod", Classes.FByteProperty);
			OnMultiLineEditableTextCommittedEvent__DelegateSignature_IsValid = OnMultiLineEditableTextCommittedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_IsValid && OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature", OnMultiLineEditableTextCommittedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text, ETextCommit CommitMethod)
		{
			if (!OnMultiLineEditableTextCommittedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMultiLineEditableTextCommittedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMultiLineEditableTextCommittedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_Offset), 0, OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				EnumMarshaler<ETextCommit>.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_Offset), 0, OnMultiLineEditableTextCommittedEvent__DelegateSignature_CommitMethod_PropertyAddress.Address, CommitMethod);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnMultiLineEditableTextCommittedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature")]
	public class FOnMultiLineEditableTextChangedEvent : FMulticastDelegate<FOnMultiLineEditableTextChangedEvent.Signature>
	{
		public delegate void Signature(FText Text);

		private static bool OnMultiLineEditableTextChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnMultiLineEditableTextChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress;

		private static int OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMultiLineEditableTextChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature");
			OnMultiLineEditableTextChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress, OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text");
			OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnMultiLineEditableTextChangedEvent__DelegateSignature_IsValid = OnMultiLineEditableTextChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature", OnMultiLineEditableTextChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnMultiLineEditableTextChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMultiLineEditableTextChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMultiLineEditableTextChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_Offset), 0, OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, Text);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnMultiLineEditableTextChangedEvent__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool IsReadOnly_IsValid;

	private static FFieldAddress IsReadOnly_PropertyAddress;

	private static int IsReadOnly_Offset;

	private static bool OnTextChanged_IsValid;

	private static int OnTextChanged_Offset;

	private FOnMultiLineEditableTextChangedEvent OnTextChanged_DelegateCached;

	private static bool OnTextCommitted_IsValid;

	private static int OnTextCommitted_Offset;

	private FOnMultiLineEditableTextCommittedEvent OnTextCommitted_DelegateCached;

	private static bool SetWidgetStyle_IsValid;

	private static IntPtr SetWidgetStyle_FunctionAddress;

	private static int SetWidgetStyle_ParamsSize;

	private static bool SetWidgetStyle_InWidgetStyle_IsValid;

	private static FFieldAddress SetWidgetStyle_InWidgetStyle_PropertyAddress;

	private static int SetWidgetStyle_InWidgetStyle_Offset;

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
	[UMetaPath("/Script/UMG.MultiLineEditableText:WidgetStyle")]
	public FTextBlockStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:WidgetStyle");
				return default(FTextBlockStyle);
			}
			return FTextBlockStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:WidgetStyle");
			}
			else
			{
				FTextBlockStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableText:bIsReadOnly")]
	public bool IsReadOnly
	{
		get
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:bIsReadOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:bIsReadOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsReadOnly_Offset), 0, IsReadOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableText:OnTextChanged")]
	public FOnMultiLineEditableTextChangedEvent OnTextChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTextChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:OnTextChanged");
				return new FOnMultiLineEditableTextChangedEvent();
			}
			if (OnTextChanged_DelegateCached == null)
			{
				OnTextChanged_DelegateCached = new FOnMultiLineEditableTextChangedEvent();
				OnTextChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextChanged_Offset));
			}
			return OnTextChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.MultiLineEditableText:OnTextCommitted")]
	public FOnMultiLineEditableTextCommittedEvent OnTextCommitted
	{
		get
		{
			CheckDestroyed();
			if (!OnTextCommitted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MultiLineEditableText:OnTextCommitted");
				return new FOnMultiLineEditableTextCommittedEvent();
			}
			if (OnTextCommitted_DelegateCached == null)
			{
				OnTextCommitted_DelegateCached = new FOnMultiLineEditableTextCommittedEvent();
				OnTextCommitted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTextCommitted_Offset));
			}
			return OnTextCommitted_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.MultiLineEditableText:SetWidgetStyle")]
	public unsafe void SetWidgetStyle(FTextBlockStyle InWidgetStyle)
	{
		CheckDestroyed();
		if (!SetWidgetStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:SetWidgetStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidgetStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidgetStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetWidgetStyle_InWidgetStyle_PropertyAddress.Address, intPtr);
		FTextBlockStyle.ToNative(IntPtr.Add(intPtr, SetWidgetStyle_InWidgetStyle_Offset), 0, SetWidgetStyle_InWidgetStyle_PropertyAddress.Address, InWidgetStyle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWidgetStyle_FunctionAddress, intPtr, SetWidgetStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetWidgetStyle_InWidgetStyle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MultiLineEditableText:SetText")]
	public unsafe void SetText(FText InText)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:SetText");
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
	[UMetaPath("/Script/UMG.MultiLineEditableText:SetIsReadOnly")]
	public unsafe void SetIsReadOnly(bool bReadOnly)
	{
		CheckDestroyed();
		if (!SetIsReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:SetIsReadOnly");
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
	[UMetaPath("/Script/UMG.MultiLineEditableText:SetHintText")]
	public unsafe void SetHintText(FText InHintText)
	{
		CheckDestroyed();
		if (!SetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:SetHintText");
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
	[UMetaPath("/Script/UMG.MultiLineEditableText:GetText")]
	public unsafe string GetText()
	{
		CheckDestroyed();
		if (!GetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:GetText");
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
	[UMetaPath("/Script/UMG.MultiLineEditableText:GetHintText")]
	public unsafe string GetHintText()
	{
		CheckDestroyed();
		if (!GetHintText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MultiLineEditableText:GetHintText");
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

	static UMultiLineEditableText()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMultiLineEditableText)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMultiLineEditableText));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.MultiLineEditableText");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReadOnly_PropertyAddress, intPtr, "bIsReadOnly");
		IsReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsReadOnly");
		IsReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsReadOnly", Classes.FBoolProperty);
		OnTextChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextChanged");
		OnTextChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextChanged", Classes.FMulticastDelegateProperty);
		OnTextCommitted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTextCommitted");
		OnTextCommitted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTextCommitted", Classes.FMulticastDelegateProperty);
		SetWidgetStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWidgetStyle");
		SetWidgetStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidgetStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidgetStyle_InWidgetStyle_PropertyAddress, SetWidgetStyle_FunctionAddress, "InWidgetStyle");
		SetWidgetStyle_InWidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(SetWidgetStyle_FunctionAddress, "InWidgetStyle");
		SetWidgetStyle_InWidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidgetStyle_FunctionAddress, "InWidgetStyle", Classes.FStructProperty);
		SetWidgetStyle_IsValid = SetWidgetStyle_FunctionAddress != IntPtr.Zero && SetWidgetStyle_InWidgetStyle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:SetWidgetStyle", SetWidgetStyle_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_InText_PropertyAddress, SetText_FunctionAddress, "InText");
		SetText_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "InText");
		SetText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "InText", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:SetText", SetText_IsValid);
		SetIsReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsReadOnly");
		SetIsReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsReadOnly_bReadOnly_PropertyAddress, SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetIsReadOnly_FunctionAddress, "bReadOnly");
		SetIsReadOnly_bReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsReadOnly_FunctionAddress, "bReadOnly", Classes.FBoolProperty);
		SetIsReadOnly_IsValid = SetIsReadOnly_FunctionAddress != IntPtr.Zero && SetIsReadOnly_bReadOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:SetIsReadOnly", SetIsReadOnly_IsValid);
		SetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHintText");
		SetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHintText_InHintText_PropertyAddress, SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_Offset = NativeReflectionCached.GetPropertyOffset(SetHintText_FunctionAddress, "InHintText");
		SetHintText_InHintText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHintText_FunctionAddress, "InHintText", Classes.FTextProperty);
		SetHintText_IsValid = SetHintText_FunctionAddress != IntPtr.Zero && SetHintText_InHintText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:SetHintText", SetHintText_IsValid);
		GetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetText");
		GetText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetText_ReturnValue_PropertyAddress, GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText_FunctionAddress, "ReturnValue");
		GetText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetText_IsValid = GetText_FunctionAddress != IntPtr.Zero && GetText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:GetText", GetText_IsValid);
		GetHintText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHintText");
		GetHintText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHintText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHintText_ReturnValue_PropertyAddress, GetHintText_FunctionAddress, "ReturnValue");
		GetHintText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHintText_FunctionAddress, "ReturnValue");
		GetHintText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHintText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetHintText_IsValid = GetHintText_FunctionAddress != IntPtr.Zero && GetHintText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MultiLineEditableText:GetHintText", GetHintText_IsValid);
	}
}
