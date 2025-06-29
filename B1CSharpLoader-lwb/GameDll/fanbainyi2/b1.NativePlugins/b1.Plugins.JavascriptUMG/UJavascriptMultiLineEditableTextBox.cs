using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptMultiLineEditableTextBox : UMultiLineEditableTextBox
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:SetText__DelegateSignature")]
	public class FSetText : FDelegate<FSetText.Signature>
	{
		public delegate void Signature(string InText, FJavascriptTextLayout TextLayout);

		private static bool SetText__DelegateSignature_IsValid;

		private static IntPtr SetText__DelegateSignature_FunctionAddress;

		private static int SetText__DelegateSignature_ParamsSize;

		private static bool SetText__DelegateSignature_InText_IsValid;

		private static FFieldAddress SetText__DelegateSignature_InText_PropertyAddress;

		private static int SetText__DelegateSignature_InText_Offset;

		private static bool SetText__DelegateSignature_TextLayout_IsValid;

		private static FFieldAddress SetText__DelegateSignature_TextLayout_PropertyAddress;

		private static int SetText__DelegateSignature_TextLayout_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSetText()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SetText__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:SetText__DelegateSignature");
			SetText__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref SetText__DelegateSignature_InText_PropertyAddress, SetText__DelegateSignature_FunctionAddress, "InText");
			SetText__DelegateSignature_InText_Offset = NativeReflectionCached.GetPropertyOffset(SetText__DelegateSignature_FunctionAddress, "InText");
			SetText__DelegateSignature_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText__DelegateSignature_FunctionAddress, "InText", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref SetText__DelegateSignature_TextLayout_PropertyAddress, SetText__DelegateSignature_FunctionAddress, "TextLayout");
			SetText__DelegateSignature_TextLayout_Offset = NativeReflectionCached.GetPropertyOffset(SetText__DelegateSignature_FunctionAddress, "TextLayout");
			SetText__DelegateSignature_TextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText__DelegateSignature_FunctionAddress, "TextLayout", Classes.FStructProperty);
			SetText__DelegateSignature_IsValid = SetText__DelegateSignature_FunctionAddress != IntPtr.Zero && SetText__DelegateSignature_InText_IsValid && SetText__DelegateSignature_TextLayout_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:SetText__DelegateSignature", SetText__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string InText, FJavascriptTextLayout TextLayout)
		{
			if (!SetText__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:SetText__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SetText__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetText__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetText__DelegateSignature_InText_Offset), 0, SetText__DelegateSignature_InText_PropertyAddress.Address, InText);
				NativeReflection.InitializeValue_InContainer(SetText__DelegateSignature_TextLayout_PropertyAddress.Address, intPtr);
				FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, SetText__DelegateSignature_TextLayout_Offset), 0, SetText__DelegateSignature_TextLayout_PropertyAddress.Address, TextLayout);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(SetText__DelegateSignature_InText_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(SetText__DelegateSignature_TextLayout_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled__DelegateSignature")]
	public class FOnVScrollBarUserScrolled : FMulticastDelegate<FOnVScrollBarUserScrolled.Signature>
	{
		public delegate void Signature(float Offset);

		private static bool OnVScrollBarUserScrolled__DelegateSignature_IsValid;

		private static IntPtr OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress;

		private static int OnVScrollBarUserScrolled__DelegateSignature_ParamsSize;

		private static bool OnVScrollBarUserScrolled__DelegateSignature_Offset_IsValid;

		private static FFieldAddress OnVScrollBarUserScrolled__DelegateSignature_Offset_PropertyAddress;

		private static int OnVScrollBarUserScrolled__DelegateSignature_Offset_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnVScrollBarUserScrolled()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled__DelegateSignature");
			OnVScrollBarUserScrolled__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnVScrollBarUserScrolled__DelegateSignature_Offset_PropertyAddress, OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress, "Offset");
			OnVScrollBarUserScrolled__DelegateSignature_Offset_Offset = NativeReflectionCached.GetPropertyOffset(OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress, "Offset");
			OnVScrollBarUserScrolled__DelegateSignature_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress, "Offset", Classes.FFloatProperty);
			OnVScrollBarUserScrolled__DelegateSignature_IsValid = OnVScrollBarUserScrolled__DelegateSignature_FunctionAddress != IntPtr.Zero && OnVScrollBarUserScrolled__DelegateSignature_Offset_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled__DelegateSignature", OnVScrollBarUserScrolled__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(float Offset)
		{
			if (!OnVScrollBarUserScrolled__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnVScrollBarUserScrolled__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnVScrollBarUserScrolled__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnVScrollBarUserScrolled__DelegateSignature_Offset_Offset), 0, OnVScrollBarUserScrolled__DelegateSignature_Offset_PropertyAddress.Address, Offset);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GetText__DelegateSignature")]
	public class FGetText__DelegateSignature_281D727D : FDelegate<FGetText__DelegateSignature_281D727D.Signature>
	{
		public delegate string Signature(FJavascriptTextLayout TextLayout);

		private static bool GetText__DelegateSignature_281D727D_IsValid;

		private static IntPtr GetText__DelegateSignature_281D727D_FunctionAddress;

		private static int GetText__DelegateSignature_281D727D_ParamsSize;

		private static bool GetText__DelegateSignature_281D727D_TextLayout_IsValid;

		private static FFieldAddress GetText__DelegateSignature_281D727D_TextLayout_PropertyAddress;

		private static int GetText__DelegateSignature_281D727D_TextLayout_Offset;

		private static bool GetText__DelegateSignature_281D727D_ReturnValue_IsValid;

		private static FFieldAddress GetText__DelegateSignature_281D727D_ReturnValue_PropertyAddress;

		private static int GetText__DelegateSignature_281D727D_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetText__DelegateSignature_281D727D()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetText__DelegateSignature_281D727D_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GetText__DelegateSignature");
			GetText__DelegateSignature_281D727D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText__DelegateSignature_281D727D_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetText__DelegateSignature_281D727D_TextLayout_PropertyAddress, GetText__DelegateSignature_281D727D_FunctionAddress, "TextLayout");
			GetText__DelegateSignature_281D727D_TextLayout_Offset = NativeReflectionCached.GetPropertyOffset(GetText__DelegateSignature_281D727D_FunctionAddress, "TextLayout");
			GetText__DelegateSignature_281D727D_TextLayout_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText__DelegateSignature_281D727D_FunctionAddress, "TextLayout", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref GetText__DelegateSignature_281D727D_ReturnValue_PropertyAddress, GetText__DelegateSignature_281D727D_FunctionAddress, "ReturnValue");
			GetText__DelegateSignature_281D727D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText__DelegateSignature_281D727D_FunctionAddress, "ReturnValue");
			GetText__DelegateSignature_281D727D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText__DelegateSignature_281D727D_FunctionAddress, "ReturnValue", Classes.FStrProperty);
			GetText__DelegateSignature_281D727D_IsValid = GetText__DelegateSignature_281D727D_FunctionAddress != IntPtr.Zero && GetText__DelegateSignature_281D727D_TextLayout_IsValid && GetText__DelegateSignature_281D727D_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GetText__DelegateSignature", GetText__DelegateSignature_281D727D_IsValid);
		}

		private unsafe string Invoker(FJavascriptTextLayout TextLayout)
		{
			if (!GetText__DelegateSignature_281D727D_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GetText__DelegateSignature");
				return FStringMarshaler.DefaultString;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetText__DelegateSignature_281D727D_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetText__DelegateSignature_281D727D_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(GetText__DelegateSignature_281D727D_TextLayout_PropertyAddress.Address, intPtr);
				FJavascriptTextLayout.ToNative(IntPtr.Add(intPtr, GetText__DelegateSignature_281D727D_TextLayout_Offset), 0, GetText__DelegateSignature_281D727D_TextLayout_PropertyAddress.Address, TextLayout);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(GetText__DelegateSignature_281D727D_TextLayout_PropertyAddress.Address, intPtr);
				string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetText__DelegateSignature_281D727D_ReturnValue_Offset), 0, GetText__DelegateSignature_281D727D_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(GetText__DelegateSignature_281D727D_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return FStringMarshaler.DefaultString;
		}
	}

	private static bool OnVScrollBarUserScrolled_IsValid;

	private static int OnVScrollBarUserScrolled_Offset;

	private FOnVScrollBarUserScrolled OnVScrollBarUserScrolled_DelegateCached;

	private static bool ScrollTo_IsValid;

	private static IntPtr ScrollTo_FunctionAddress;

	private static int ScrollTo_ParamsSize;

	private static bool ScrollTo_Line_IsValid;

	private static FFieldAddress ScrollTo_Line_PropertyAddress;

	private static int ScrollTo_Line_Offset;

	private static bool ScrollTo_Offset_IsValid;

	private static FFieldAddress ScrollTo_Offset_PropertyAddress;

	private static int ScrollTo_Offset_Offset;

	private static bool Refresh_IsValid;

	private static IntPtr Refresh_FunctionAddress;

	private static int Refresh_ParamsSize;

	private static bool GoTo_IsValid;

	private static IntPtr GoTo_FunctionAddress;

	private static int GoTo_ParamsSize;

	private static bool GoTo_Line_IsValid;

	private static FFieldAddress GoTo_Line_PropertyAddress;

	private static int GoTo_Line_Offset;

	private static bool GoTo_Offset_IsValid;

	private static FFieldAddress GoTo_Offset_PropertyAddress;

	private static int GoTo_Offset_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled")]
	public FOnVScrollBarUserScrolled OnVScrollBarUserScrolled
	{
		get
		{
			CheckDestroyed();
			if (!OnVScrollBarUserScrolled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:OnVScrollBarUserScrolled");
				return new FOnVScrollBarUserScrolled();
			}
			if (OnVScrollBarUserScrolled_DelegateCached == null)
			{
				OnVScrollBarUserScrolled_DelegateCached = new FOnVScrollBarUserScrolled();
				OnVScrollBarUserScrolled_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnVScrollBarUserScrolled_Offset));
			}
			return OnVScrollBarUserScrolled_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:ScrollTo")]
	public unsafe void ScrollTo(int Line, int Offset)
	{
		CheckDestroyed();
		if (!ScrollTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:ScrollTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScrollTo_Line_Offset), 0, ScrollTo_Line_PropertyAddress.Address, Line);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScrollTo_Offset_Offset), 0, ScrollTo_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScrollTo_FunctionAddress, intPtr, ScrollTo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:Refresh")]
	public unsafe void Refresh()
	{
		CheckDestroyed();
		if (!Refresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:Refresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Refresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Refresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Refresh_FunctionAddress, argsSize: Refresh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GoTo")]
	public unsafe void GoTo(int Line, int Offset)
	{
		CheckDestroyed();
		if (!GoTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GoTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GoTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GoTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GoTo_Line_Offset), 0, GoTo_Line_PropertyAddress.Address, Line);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GoTo_Offset_Offset), 0, GoTo_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeFunctionOptimized(base.Address, GoTo_FunctionAddress, intPtr, GoTo_ParamsSize);
	}

	static UJavascriptMultiLineEditableTextBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptMultiLineEditableTextBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptMultiLineEditableTextBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox");
		OnVScrollBarUserScrolled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnVScrollBarUserScrolled");
		OnVScrollBarUserScrolled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnVScrollBarUserScrolled", Classes.FMulticastDelegateProperty);
		ScrollTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollTo");
		ScrollTo_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScrollTo_Line_PropertyAddress, ScrollTo_FunctionAddress, "Line");
		ScrollTo_Line_Offset = NativeReflectionCached.GetPropertyOffset(ScrollTo_FunctionAddress, "Line");
		ScrollTo_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollTo_FunctionAddress, "Line", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ScrollTo_Offset_PropertyAddress, ScrollTo_FunctionAddress, "Offset");
		ScrollTo_Offset_Offset = NativeReflectionCached.GetPropertyOffset(ScrollTo_FunctionAddress, "Offset");
		ScrollTo_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollTo_FunctionAddress, "Offset", Classes.FIntProperty);
		ScrollTo_IsValid = ScrollTo_FunctionAddress != IntPtr.Zero && ScrollTo_Line_IsValid && ScrollTo_Offset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:ScrollTo", ScrollTo_IsValid);
		Refresh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Refresh");
		Refresh_ParamsSize = NativeReflection.GetFunctionParamsSize(Refresh_FunctionAddress);
		Refresh_IsValid = Refresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:Refresh", Refresh_IsValid);
		GoTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GoTo");
		GoTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GoTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GoTo_Line_PropertyAddress, GoTo_FunctionAddress, "Line");
		GoTo_Line_Offset = NativeReflectionCached.GetPropertyOffset(GoTo_FunctionAddress, "Line");
		GoTo_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(GoTo_FunctionAddress, "Line", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GoTo_Offset_PropertyAddress, GoTo_FunctionAddress, "Offset");
		GoTo_Offset_Offset = NativeReflectionCached.GetPropertyOffset(GoTo_FunctionAddress, "Offset");
		GoTo_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(GoTo_FunctionAddress, "Offset", Classes.FIntProperty);
		GoTo_IsValid = GoTo_FunctionAddress != IntPtr.Zero && GoTo_Line_IsValid && GoTo_Offset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMultiLineEditableTextBox:GoTo", GoTo_IsValid);
	}
}
