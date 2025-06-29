using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptToolbarButtonContext : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:TextDelegate__DelegateSignature")]
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
			TextDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptToolbarButtonContext:TextDelegate__DelegateSignature");
			TextDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TextDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref TextDelegate__DelegateSignature_ReturnValue_PropertyAddress, TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			TextDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			TextDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FTextProperty);
			TextDelegate__DelegateSignature_IsValid = TextDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && TextDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:TextDelegate__DelegateSignature", TextDelegate__DelegateSignature_IsValid);
		}

		private unsafe string Invoker()
		{
			if (!TextDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:TextDelegate__DelegateSignature");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptExecuteActionWithEditingObject__DelegateSignature")]
	public class FJavascriptExecuteActionWithEditingObject : FDelegate<FJavascriptExecuteActionWithEditingObject.Signature>
	{
		public delegate void Signature(UObject EditingObject);

		private static bool JavascriptExecuteActionWithEditingObject__DelegateSignature_IsValid;

		private static IntPtr JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress;

		private static int JavascriptExecuteActionWithEditingObject__DelegateSignature_ParamsSize;

		private static bool JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid;

		private static FFieldAddress JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress;

		private static int JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptExecuteActionWithEditingObject()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptExecuteActionWithEditingObject__DelegateSignature");
			JavascriptExecuteActionWithEditingObject__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress, JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject", Classes.FObjectProperty);
			JavascriptExecuteActionWithEditingObject__DelegateSignature_IsValid = JavascriptExecuteActionWithEditingObject__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptExecuteActionWithEditingObject__DelegateSignature", JavascriptExecuteActionWithEditingObject__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UObject EditingObject)
		{
			if (!JavascriptExecuteActionWithEditingObject__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptExecuteActionWithEditingObject__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptExecuteActionWithEditingObject__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptExecuteActionWithEditingObject__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset), 0, JavascriptExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress.Address, EditingObject);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptCanExecuteActionWithEditingObject__DelegateSignature")]
	public class FJavascriptCanExecuteActionWithEditingObject : FDelegate<FJavascriptCanExecuteActionWithEditingObject.Signature>
	{
		public delegate bool Signature(UObject EditingObject);

		private static bool JavascriptCanExecuteActionWithEditingObject__DelegateSignature_IsValid;

		private static IntPtr JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress;

		private static int JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ParamsSize;

		private static bool JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid;

		private static FFieldAddress JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress;

		private static int JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset;

		private static bool JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress;

		private static int JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptCanExecuteActionWithEditingObject()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptCanExecuteActionWithEditingObject__DelegateSignature");
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject");
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "EditingObject", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			JavascriptCanExecuteActionWithEditingObject__DelegateSignature_IsValid = JavascriptCanExecuteActionWithEditingObject__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_IsValid && JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptCanExecuteActionWithEditingObject__DelegateSignature", JavascriptCanExecuteActionWithEditingObject__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(UObject EditingObject)
		{
			if (!JavascriptCanExecuteActionWithEditingObject__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:JavascriptCanExecuteActionWithEditingObject__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_Offset), 0, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_EditingObject_PropertyAddress.Address, EditingObject);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_Offset), 0, JavascriptCanExecuteActionWithEditingObject__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:IconDelegate__DelegateSignature")]
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
			IconDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptToolbarButtonContext:IconDelegate__DelegateSignature");
			IconDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(IconDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref IconDelegate__DelegateSignature_ReturnValue_PropertyAddress, IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			IconDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			IconDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IconDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			IconDelegate__DelegateSignature_IsValid = IconDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && IconDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:IconDelegate__DelegateSignature", IconDelegate__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptSlateIcon Invoker()
		{
			if (!IconDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:IconDelegate__DelegateSignature");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:BoolDelegate__DelegateSignature")]
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
			BoolDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptToolbarButtonContext:BoolDelegate__DelegateSignature");
			BoolDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BoolDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref BoolDelegate__DelegateSignature_ReturnValue_PropertyAddress, BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			BoolDelegate__DelegateSignature_IsValid = BoolDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && BoolDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:BoolDelegate__DelegateSignature", BoolDelegate__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker()
		{
			if (!BoolDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:BoolDelegate__DelegateSignature");
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

	private static bool OnExecuteAction_IsValid;

	private static int OnExecuteAction_Offset;

	private FJavascriptExecuteActionWithEditingObject OnExecuteAction_DelegateCached;

	private static bool OnCanExecuteAction_IsValid;

	private static int OnCanExecuteAction_Offset;

	private FJavascriptCanExecuteActionWithEditingObject OnCanExecuteAction_DelegateCached;

	private static bool OnIsActionChecked_IsValid;

	private static int OnIsActionChecked_Offset;

	private FJavascriptCanExecuteActionWithEditingObject OnIsActionChecked_DelegateCached;

	private static bool OnIsActionButtonVisible_IsValid;

	private static int OnIsActionButtonVisible_Offset;

	private FJavascriptCanExecuteActionWithEditingObject OnIsActionButtonVisible_DelegateCached;

	private static bool UnmarkReferencedObject_IsValid;

	private static IntPtr UnmarkReferencedObject_FunctionAddress;

	private static int UnmarkReferencedObject_ParamsSize;

	private static bool MarkReferencedObject_IsValid;

	private static IntPtr MarkReferencedObject_FunctionAddress;

	private static int MarkReferencedObject_ParamsSize;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetLabel")]
	public FTextDelegate OnGetLabel
	{
		get
		{
			CheckDestroyed();
			if (!OnGetLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetLabel");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetTooltip")]
	public FTextDelegate OnGetTooltip
	{
		get
		{
			CheckDestroyed();
			if (!OnGetTooltip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetTooltip");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetIcon")]
	public FIconDelegate OnGetIcon
	{
		get
		{
			CheckDestroyed();
			if (!OnGetIcon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnGetIcon");
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
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnExecuteAction")]
	public FJavascriptExecuteActionWithEditingObject OnExecuteAction
	{
		get
		{
			CheckDestroyed();
			if (!OnExecuteAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnExecuteAction");
				return new FJavascriptExecuteActionWithEditingObject();
			}
			if (OnExecuteAction_DelegateCached == null)
			{
				OnExecuteAction_DelegateCached = new FJavascriptExecuteActionWithEditingObject();
				OnExecuteAction_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnExecuteAction_Offset));
			}
			return OnExecuteAction_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnCanExecuteAction")]
	public FJavascriptCanExecuteActionWithEditingObject OnCanExecuteAction
	{
		get
		{
			CheckDestroyed();
			if (!OnCanExecuteAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnCanExecuteAction");
				return new FJavascriptCanExecuteActionWithEditingObject();
			}
			if (OnCanExecuteAction_DelegateCached == null)
			{
				OnCanExecuteAction_DelegateCached = new FJavascriptCanExecuteActionWithEditingObject();
				OnCanExecuteAction_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCanExecuteAction_Offset));
			}
			return OnCanExecuteAction_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnIsActionChecked")]
	public FJavascriptCanExecuteActionWithEditingObject OnIsActionChecked
	{
		get
		{
			CheckDestroyed();
			if (!OnIsActionChecked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnIsActionChecked");
				return new FJavascriptCanExecuteActionWithEditingObject();
			}
			if (OnIsActionChecked_DelegateCached == null)
			{
				OnIsActionChecked_DelegateCached = new FJavascriptCanExecuteActionWithEditingObject();
				OnIsActionChecked_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnIsActionChecked_Offset));
			}
			return OnIsActionChecked_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnIsActionButtonVisible")]
	public FJavascriptCanExecuteActionWithEditingObject OnIsActionButtonVisible
	{
		get
		{
			CheckDestroyed();
			if (!OnIsActionButtonVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:OnIsActionButtonVisible");
				return new FJavascriptCanExecuteActionWithEditingObject();
			}
			if (OnIsActionButtonVisible_DelegateCached == null)
			{
				OnIsActionButtonVisible_DelegateCached = new FJavascriptCanExecuteActionWithEditingObject();
				OnIsActionButtonVisible_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnIsActionButtonVisible_Offset));
			}
			return OnIsActionButtonVisible_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:UnmarkReferencedObject")]
	public unsafe void UnmarkReferencedObject()
	{
		CheckDestroyed();
		if (!UnmarkReferencedObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:UnmarkReferencedObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnmarkReferencedObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnmarkReferencedObject_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnmarkReferencedObject_FunctionAddress, argsSize: UnmarkReferencedObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptToolbarButtonContext:MarkReferencedObject")]
	public unsafe void MarkReferencedObject()
	{
		CheckDestroyed();
		if (!MarkReferencedObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptToolbarButtonContext:MarkReferencedObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkReferencedObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkReferencedObject_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: MarkReferencedObject_FunctionAddress, argsSize: MarkReferencedObject_ParamsSize);
	}

	static UJavascriptToolbarButtonContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptToolbarButtonContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptToolbarButtonContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptToolbarButtonContext");
		OnGetLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetLabel");
		OnGetLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetLabel", Classes.FDelegateProperty);
		OnGetTooltip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetTooltip");
		OnGetTooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetTooltip", Classes.FDelegateProperty);
		OnGetIcon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetIcon");
		OnGetIcon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetIcon", Classes.FDelegateProperty);
		OnExecuteAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnExecuteAction");
		OnExecuteAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnExecuteAction", Classes.FDelegateProperty);
		OnCanExecuteAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnCanExecuteAction");
		OnCanExecuteAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnCanExecuteAction", Classes.FDelegateProperty);
		OnIsActionChecked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnIsActionChecked");
		OnIsActionChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnIsActionChecked", Classes.FDelegateProperty);
		OnIsActionButtonVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnIsActionButtonVisible");
		OnIsActionButtonVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnIsActionButtonVisible", Classes.FDelegateProperty);
		UnmarkReferencedObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnmarkReferencedObject");
		UnmarkReferencedObject_ParamsSize = NativeReflection.GetFunctionParamsSize(UnmarkReferencedObject_FunctionAddress);
		UnmarkReferencedObject_IsValid = UnmarkReferencedObject_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:UnmarkReferencedObject", UnmarkReferencedObject_IsValid);
		MarkReferencedObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkReferencedObject");
		MarkReferencedObject_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkReferencedObject_FunctionAddress);
		MarkReferencedObject_IsValid = MarkReferencedObject_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptToolbarButtonContext:MarkReferencedObject", MarkReferencedObject_IsValid);
	}
}
