using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptComboButton : UContentWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnIsOpenChanged__DelegateSignature")]
	public class FOnIsOpenChanged : FDelegate<FOnIsOpenChanged.Signature>
	{
		public delegate void Signature(bool Value);

		private static bool OnIsOpenChanged__DelegateSignature_IsValid;

		private static IntPtr OnIsOpenChanged__DelegateSignature_FunctionAddress;

		private static int OnIsOpenChanged__DelegateSignature_ParamsSize;

		private static bool OnIsOpenChanged__DelegateSignature_Value_IsValid;

		private static FFieldAddress OnIsOpenChanged__DelegateSignature_Value_PropertyAddress;

		private static int OnIsOpenChanged__DelegateSignature_Value_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnIsOpenChanged()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnIsOpenChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButton:OnIsOpenChanged__DelegateSignature");
			OnIsOpenChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnIsOpenChanged__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnIsOpenChanged__DelegateSignature_Value_PropertyAddress, OnIsOpenChanged__DelegateSignature_FunctionAddress, "Value");
			OnIsOpenChanged__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(OnIsOpenChanged__DelegateSignature_FunctionAddress, "Value");
			OnIsOpenChanged__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(OnIsOpenChanged__DelegateSignature_FunctionAddress, "Value", Classes.FBoolProperty);
			OnIsOpenChanged__DelegateSignature_IsValid = OnIsOpenChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnIsOpenChanged__DelegateSignature_Value_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButton:OnIsOpenChanged__DelegateSignature", OnIsOpenChanged__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(bool Value)
		{
			if (!OnIsOpenChanged__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnIsOpenChanged__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnIsOpenChanged__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnIsOpenChanged__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnIsOpenChanged__DelegateSignature_Value_Offset), 0, OnIsOpenChanged__DelegateSignature_Value_PropertyAddress.Address, Value);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnGetContent__DelegateSignature")]
	public class FOnGetContent : FDelegate<FOnGetContent.Signature>
	{
		public delegate FJavascriptSlateWidget Signature();

		private static bool OnGetContent__DelegateSignature_IsValid;

		private static IntPtr OnGetContent__DelegateSignature_FunctionAddress;

		private static int OnGetContent__DelegateSignature_ParamsSize;

		private static bool OnGetContent__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetContent__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetContent__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetContent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetContent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButton:OnGetContent__DelegateSignature");
			OnGetContent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetContent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetContent__DelegateSignature_ReturnValue_PropertyAddress, OnGetContent__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetContent__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetContent__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetContent__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetContent__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnGetContent__DelegateSignature_IsValid = OnGetContent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetContent__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButton:OnGetContent__DelegateSignature", OnGetContent__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptSlateWidget Invoker()
		{
			if (!OnGetContent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnGetContent__DelegateSignature");
				return default(FJavascriptSlateWidget);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetContent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetContent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, OnGetContent__DelegateSignature_ReturnValue_Offset), 0, OnGetContent__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(OnGetContent__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FJavascriptSlateWidget);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened__DelegateSignature")]
	public class FOnComboBoxOpened : FDelegate<FOnComboBoxOpened.Signature>
	{
		public delegate void Signature();

		private static bool OnComboBoxOpened__DelegateSignature_IsValid;

		private static IntPtr OnComboBoxOpened__DelegateSignature_FunctionAddress;

		private static int OnComboBoxOpened__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnComboBoxOpened()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnComboBoxOpened__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened__DelegateSignature");
			OnComboBoxOpened__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnComboBoxOpened__DelegateSignature_FunctionAddress);
			OnComboBoxOpened__DelegateSignature_IsValid = OnComboBoxOpened__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened__DelegateSignature", OnComboBoxOpened__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnComboBoxOpened__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnComboBoxOpened__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnComboBoxOpened__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool OnGetMenuContent_IsValid;

	private static int OnGetMenuContent_Offset;

	private FOnGetContent OnGetMenuContent_DelegateCached;

	private static bool OnMenuOpenChanged_IsValid;

	private static int OnMenuOpenChanged_Offset;

	private FOnIsOpenChanged OnMenuOpenChanged_DelegateCached;

	private static bool OnComboBoxOpened_IsValid;

	private static int OnComboBoxOpened_Offset;

	private FOnComboBoxOpened OnComboBoxOpened_DelegateCached;

	private static bool SetIsOpen_IsValid;

	private static IntPtr SetIsOpen_FunctionAddress;

	private static int SetIsOpen_ParamsSize;

	private static bool SetIsOpen_InIsOpen_IsValid;

	private static FFieldAddress SetIsOpen_InIsOpen_PropertyAddress;

	private static int SetIsOpen_InIsOpen_Offset;

	private static bool SetIsOpen_bFocusMenu_IsValid;

	private static FFieldAddress SetIsOpen_bFocusMenu_PropertyAddress;

	private static int SetIsOpen_bFocusMenu_Offset;

	[UProperty(Flags = (PropFlags)4503668347372032uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnGetMenuContent")]
	public FOnGetContent OnGetMenuContent
	{
		get
		{
			CheckDestroyed();
			if (!OnGetMenuContent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnGetMenuContent");
				return new FOnGetContent();
			}
			if (OnGetMenuContent_DelegateCached == null)
			{
				OnGetMenuContent_DelegateCached = new FOnGetContent();
				OnGetMenuContent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetMenuContent_Offset));
			}
			return OnGetMenuContent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372032uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnMenuOpenChanged")]
	public FOnIsOpenChanged OnMenuOpenChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnMenuOpenChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnMenuOpenChanged");
				return new FOnIsOpenChanged();
			}
			if (OnMenuOpenChanged_DelegateCached == null)
			{
				OnMenuOpenChanged_DelegateCached = new FOnIsOpenChanged();
				OnMenuOpenChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMenuOpenChanged_Offset));
			}
			return OnMenuOpenChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372032uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened")]
	public FOnComboBoxOpened OnComboBoxOpened
	{
		get
		{
			CheckDestroyed();
			if (!OnComboBoxOpened_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButton:OnComboBoxOpened");
				return new FOnComboBoxOpened();
			}
			if (OnComboBoxOpened_DelegateCached == null)
			{
				OnComboBoxOpened_DelegateCached = new FOnComboBoxOpened();
				OnComboBoxOpened_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComboBoxOpened_Offset));
			}
			return OnComboBoxOpened_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButton:SetIsOpen")]
	public unsafe void SetIsOpen(bool InIsOpen, bool bFocusMenu)
	{
		CheckDestroyed();
		if (!SetIsOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButton:SetIsOpen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsOpen_InIsOpen_Offset), 0, SetIsOpen_InIsOpen_PropertyAddress.Address, InIsOpen);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsOpen_bFocusMenu_Offset), 0, SetIsOpen_bFocusMenu_PropertyAddress.Address, bFocusMenu);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsOpen_FunctionAddress, intPtr, SetIsOpen_ParamsSize);
	}

	static UJavascriptComboButton()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptComboButton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptComboButton));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptComboButton");
		OnGetMenuContent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetMenuContent");
		OnGetMenuContent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetMenuContent", Classes.FDelegateProperty);
		OnMenuOpenChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMenuOpenChanged");
		OnMenuOpenChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMenuOpenChanged", Classes.FDelegateProperty);
		OnComboBoxOpened_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComboBoxOpened");
		OnComboBoxOpened_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComboBoxOpened", Classes.FDelegateProperty);
		SetIsOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsOpen");
		SetIsOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsOpen_InIsOpen_PropertyAddress, SetIsOpen_FunctionAddress, "InIsOpen");
		SetIsOpen_InIsOpen_Offset = NativeReflectionCached.GetPropertyOffset(SetIsOpen_FunctionAddress, "InIsOpen");
		SetIsOpen_InIsOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsOpen_FunctionAddress, "InIsOpen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIsOpen_bFocusMenu_PropertyAddress, SetIsOpen_FunctionAddress, "bFocusMenu");
		SetIsOpen_bFocusMenu_Offset = NativeReflectionCached.GetPropertyOffset(SetIsOpen_FunctionAddress, "bFocusMenu");
		SetIsOpen_bFocusMenu_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsOpen_FunctionAddress, "bFocusMenu", Classes.FBoolProperty);
		SetIsOpen_IsValid = SetIsOpen_FunctionAddress != IntPtr.Zero && SetIsOpen_InIsOpen_IsValid && SetIsOpen_bFocusMenu_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButton:SetIsOpen", SetIsOpen_IsValid);
	}
}
