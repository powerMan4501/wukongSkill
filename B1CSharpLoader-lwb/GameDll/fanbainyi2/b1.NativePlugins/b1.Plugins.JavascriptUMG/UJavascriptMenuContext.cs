using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptMenuContext : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:ExecuteAction__DelegateSignature")]
	public class FExecuteAction : FDelegate<FExecuteAction.Signature>
	{
		public delegate void Signature();

		private static bool ExecuteAction__DelegateSignature_IsValid;

		private static IntPtr ExecuteAction__DelegateSignature_FunctionAddress;

		private static int ExecuteAction__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FExecuteAction()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			ExecuteAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMenuContext:ExecuteAction__DelegateSignature");
			ExecuteAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteAction__DelegateSignature_FunctionAddress);
			ExecuteAction__DelegateSignature_IsValid = ExecuteAction__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMenuContext:ExecuteAction__DelegateSignature", ExecuteAction__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!ExecuteAction__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMenuContext:ExecuteAction__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(ExecuteAction__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteAction__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:BoolDelegate__DelegateSignature")]
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
			BoolDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMenuContext:BoolDelegate__DelegateSignature");
			BoolDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BoolDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref BoolDelegate__DelegateSignature_ReturnValue_PropertyAddress, BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			BoolDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			BoolDelegate__DelegateSignature_IsValid = BoolDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && BoolDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMenuContext:BoolDelegate__DelegateSignature", BoolDelegate__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker()
		{
			if (!BoolDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMenuContext:BoolDelegate__DelegateSignature");
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

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:ActionCheckStateDelegate__DelegateSignature")]
	public class FActionCheckStateDelegate : FDelegate<FActionCheckStateDelegate.Signature>
	{
		public delegate ECheckBoxState Signature();

		private static bool ActionCheckStateDelegate__DelegateSignature_IsValid;

		private static IntPtr ActionCheckStateDelegate__DelegateSignature_FunctionAddress;

		private static int ActionCheckStateDelegate__DelegateSignature_ParamsSize;

		private static bool ActionCheckStateDelegate__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress ActionCheckStateDelegate__DelegateSignature_ReturnValue_PropertyAddress;

		private static int ActionCheckStateDelegate__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FActionCheckStateDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			ActionCheckStateDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptMenuContext:ActionCheckStateDelegate__DelegateSignature");
			ActionCheckStateDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionCheckStateDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref ActionCheckStateDelegate__DelegateSignature_ReturnValue_PropertyAddress, ActionCheckStateDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			ActionCheckStateDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ActionCheckStateDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
			ActionCheckStateDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionCheckStateDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
			ActionCheckStateDelegate__DelegateSignature_IsValid = ActionCheckStateDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && ActionCheckStateDelegate__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptMenuContext:ActionCheckStateDelegate__DelegateSignature", ActionCheckStateDelegate__DelegateSignature_IsValid);
		}

		private unsafe ECheckBoxState Invoker()
		{
			if (!ActionCheckStateDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptMenuContext:ActionCheckStateDelegate__DelegateSignature");
				return ECheckBoxState.Unchecked;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(ActionCheckStateDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionCheckStateDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, ActionCheckStateDelegate__DelegateSignature_ReturnValue_Offset), 0, ActionCheckStateDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return ECheckBoxState.Unchecked;
		}
	}

	private static bool OnCanExecute_IsValid;

	private static int OnCanExecute_Offset;

	private FBoolDelegate OnCanExecute_DelegateCached;

	private static bool OnExecute_IsValid;

	private static int OnExecute_Offset;

	private FExecuteAction OnExecute_DelegateCached;

	private static bool OnGetActionCheckState_IsValid;

	private static int OnGetActionCheckState_Offset;

	private FActionCheckStateDelegate OnGetActionCheckState_DelegateCached;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:OnCanExecute")]
	public FBoolDelegate OnCanExecute
	{
		get
		{
			CheckDestroyed();
			if (!OnCanExecute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptMenuContext:OnCanExecute");
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

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:OnExecute")]
	public FExecuteAction OnExecute
	{
		get
		{
			CheckDestroyed();
			if (!OnExecute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptMenuContext:OnExecute");
				return new FExecuteAction();
			}
			if (OnExecute_DelegateCached == null)
			{
				OnExecute_DelegateCached = new FExecuteAction();
				OnExecute_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnExecute_Offset));
			}
			return OnExecute_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptMenuContext:OnGetActionCheckState")]
	public FActionCheckStateDelegate OnGetActionCheckState
	{
		get
		{
			CheckDestroyed();
			if (!OnGetActionCheckState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptMenuContext:OnGetActionCheckState");
				return new FActionCheckStateDelegate();
			}
			if (OnGetActionCheckState_DelegateCached == null)
			{
				OnGetActionCheckState_DelegateCached = new FActionCheckStateDelegate();
				OnGetActionCheckState_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetActionCheckState_Offset));
			}
			return OnGetActionCheckState_DelegateCached;
		}
	}

	static UJavascriptMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptMenuContext");
		OnCanExecute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnCanExecute");
		OnCanExecute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnCanExecute", Classes.FDelegateProperty);
		OnExecute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnExecute");
		OnExecute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnExecute", Classes.FDelegateProperty);
		OnGetActionCheckState_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnGetActionCheckState");
		OnGetActionCheckState_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnGetActionCheckState", Classes.FDelegateProperty);
	}
}
