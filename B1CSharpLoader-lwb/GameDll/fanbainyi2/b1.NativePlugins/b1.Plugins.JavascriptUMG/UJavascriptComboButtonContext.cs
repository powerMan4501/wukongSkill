using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptComboButtonContext : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:TextDelegate__DelegateSignature")]
	public class FTextDelegate : FDelegate<FTextDelegate.Signature>
	{
		public delegate string Signature();

		private static bool TextDelegate__DelegateSignature_IsValid;

		private static IntPtr TextDelegate__DelegateSignature_FunctionAddress;

		private static int TextDelegate__DelegateSignature_ParamsSize;

		private static bool TextDelegate__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress TextDelegate__DelegateSignature_ReturnValue_PropertyAddress;

		private static int TextDelegate__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FTextDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			TextDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButtonContext:TextDelegate__DelegateSignature");
			TextDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TextDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref TextDelegate__DelegateSignature_ReturnValue_PropertyAddress, TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			TextDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			TextDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FTextProperty);
			TextDelegate__DelegateSignature_IsValid = TextDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && TextDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButtonContext:TextDelegate__DelegateSignature", TextDelegate__DelegateSignature_IsValid);
		}

		private unsafe string Invoker()
		{
			if (!TextDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:TextDelegate__DelegateSignature");
				return FStringMarshaler.DefaultString;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(TextDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextDelegate__DelegateSignature_ReturnValue_Offset), 0, TextDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
				string result = fText.ToString();
				NativeReflection.DestroyValue_InContainer(TextDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return FStringMarshaler.DefaultString;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:JavascriptGetWidgetWithEditingObject__DelegateSignature")]
	public class FJavascriptGetWidgetWithEditingObject : FDelegate<FJavascriptGetWidgetWithEditingObject.Signature>
	{
		public delegate FJavascriptSlateWidget Signature(UObject EditingObject);

		private static bool JavascriptGetWidgetWithEditingObject__DelegateSignature_IsValid;

		private static IntPtr JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress;

		private static int JavascriptGetWidgetWithEditingObject__DelegateSignature_ParamsSize;

		private static bool JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_IsValid;

		private static FFieldAddress JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_PropertyAddress;

		private static int JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_Offset;

		private static bool JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress;

		private static int JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptGetWidgetWithEditingObject()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButtonContext:JavascriptGetWidgetWithEditingObject__DelegateSignature");
			JavascriptGetWidgetWithEditingObject__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_PropertyAddress, JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress, JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			JavascriptGetWidgetWithEditingObject__DelegateSignature_IsValid = JavascriptGetWidgetWithEditingObject__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_IsValid && JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButtonContext:JavascriptGetWidgetWithEditingObject__DelegateSignature", JavascriptGetWidgetWithEditingObject__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptSlateWidget Invoker(UObject EditingObject)
		{
			if (!JavascriptGetWidgetWithEditingObject__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:JavascriptGetWidgetWithEditingObject__DelegateSignature");
				return default(FJavascriptSlateWidget);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptGetWidgetWithEditingObject__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptGetWidgetWithEditingObject__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_Offset), 0, JavascriptGetWidgetWithEditingObject__DelegateSignature_EditingObject_PropertyAddress.Address, EditingObject);
				ProcessDelegate(intPtr);
				FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_Offset), 0, JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(JavascriptGetWidgetWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FJavascriptSlateWidget);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:IconDelegate__DelegateSignature")]
	public class FIconDelegate : FDelegate<FIconDelegate.Signature>
	{
		public delegate FJavascriptSlateIcon Signature();

		private static bool IconDelegate__DelegateSignature_IsValid;

		private static IntPtr IconDelegate__DelegateSignature_FunctionAddress;

		private static int IconDelegate__DelegateSignature_ParamsSize;

		private static bool IconDelegate__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress IconDelegate__DelegateSignature_ReturnValue_PropertyAddress;

		private static int IconDelegate__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FIconDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			IconDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButtonContext:IconDelegate__DelegateSignature");
			IconDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(IconDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref IconDelegate__DelegateSignature_ReturnValue_PropertyAddress, IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			IconDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			IconDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			IconDelegate__DelegateSignature_IsValid = IconDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && IconDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButtonContext:IconDelegate__DelegateSignature", IconDelegate__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptSlateIcon Invoker()
		{
			if (!IconDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:IconDelegate__DelegateSignature");
				return default(FJavascriptSlateIcon);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(IconDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IconDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return FJavascriptSlateIcon.FromNative(IntPtr.Add(intPtr, IconDelegate__DelegateSignature_ReturnValue_Offset), 0, IconDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FJavascriptSlateIcon);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:BoolDelegate__DelegateSignature")]
	public class FBoolDelegate : FDelegate<FBoolDelegate.Signature>
	{
		public delegate bool Signature();

		private static bool BoolDelegate__DelegateSignature_IsValid;

		private static IntPtr BoolDelegate__DelegateSignature_FunctionAddress;

		private static int BoolDelegate__DelegateSignature_ParamsSize;

		private static bool BoolDelegate__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress BoolDelegate__DelegateSignature_ReturnValue_PropertyAddress;

		private static int BoolDelegate__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FBoolDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			BoolDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptComboButtonContext:BoolDelegate__DelegateSignature");
			BoolDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BoolDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref BoolDelegate__DelegateSignature_ReturnValue_PropertyAddress, BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			BoolDelegate__DelegateSignature_IsValid = BoolDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && BoolDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptComboButtonContext:BoolDelegate__DelegateSignature", BoolDelegate__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker()
		{
			if (!BoolDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:BoolDelegate__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(BoolDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoolDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoolDelegate__DelegateSignature_ReturnValue_Offset), 0, BoolDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	private static bool OnGetLabel_IsValid;

	private static int OnGetLabel_Offset;

	private FTextDelegate OnGetLabel_DelegateCached;

	private static bool OnGetTooltip_IsValid;

	private static int OnGetTooltip_Offset;

	private FTextDelegate OnGetTooltip_DelegateCached;

	private static bool OnGetIcon_IsValid;

	private static int OnGetIcon_Offset;

	private FIconDelegate OnGetIcon_DelegateCached;

	private static bool OnGetWidget_IsValid;

	private static int OnGetWidget_Offset;

	private FJavascriptGetWidgetWithEditingObject OnGetWidget_DelegateCached;

	private static bool OnCanExecute_IsValid;

	private static int OnCanExecute_Offset;

	private FBoolDelegate OnCanExecute_DelegateCached;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetLabel")]
	public FTextDelegate OnGetLabel
	{
		get
		{
			CheckDestroyed();
			if (!OnGetLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetLabel");
				return new FTextDelegate();
			}
			if (OnGetLabel_DelegateCached == null)
			{
				OnGetLabel_DelegateCached = new FTextDelegate();
				OnGetLabel_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetLabel_Offset));
			}
			return OnGetLabel_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetTooltip")]
	public FTextDelegate OnGetTooltip
	{
		get
		{
			CheckDestroyed();
			if (!OnGetTooltip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetTooltip");
				return new FTextDelegate();
			}
			if (OnGetTooltip_DelegateCached == null)
			{
				OnGetTooltip_DelegateCached = new FTextDelegate();
				OnGetTooltip_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetTooltip_Offset));
			}
			return OnGetTooltip_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetIcon")]
	public FIconDelegate OnGetIcon
	{
		get
		{
			CheckDestroyed();
			if (!OnGetIcon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetIcon");
				return new FIconDelegate();
			}
			if (OnGetIcon_DelegateCached == null)
			{
				OnGetIcon_DelegateCached = new FIconDelegate();
				OnGetIcon_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetIcon_Offset));
			}
			return OnGetIcon_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetWidget")]
	public FJavascriptGetWidgetWithEditingObject OnGetWidget
	{
		get
		{
			CheckDestroyed();
			if (!OnGetWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:OnGetWidget");
				return new FJavascriptGetWidgetWithEditingObject();
			}
			if (OnGetWidget_DelegateCached == null)
			{
				OnGetWidget_DelegateCached = new FJavascriptGetWidgetWithEditingObject();
				OnGetWidget_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetWidget_Offset));
			}
			return OnGetWidget_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptComboButtonContext:OnCanExecute")]
	public FBoolDelegate OnCanExecute
	{
		get
		{
			CheckDestroyed();
			if (!OnCanExecute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptComboButtonContext:OnCanExecute");
				return new FBoolDelegate();
			}
			if (OnCanExecute_DelegateCached == null)
			{
				OnCanExecute_DelegateCached = new FBoolDelegate();
				OnCanExecute_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCanExecute_Offset));
			}
			return OnCanExecute_DelegateCached;
		}
	}

	static UJavascriptComboButtonContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptComboButtonContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptComboButtonContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptComboButtonContext");
		OnGetLabel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetLabel");
		OnGetLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetLabel", Classes.FDelegateProperty);
		OnGetTooltip_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetTooltip");
		OnGetTooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetTooltip", Classes.FDelegateProperty);
		OnGetIcon_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetIcon");
		OnGetIcon_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetIcon", Classes.FDelegateProperty);
		OnGetWidget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetWidget");
		OnGetWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetWidget", Classes.FDelegateProperty);
		OnCanExecute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnCanExecute");
		OnCanExecute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnCanExecute", Classes.FDelegateProperty);
	}
}
