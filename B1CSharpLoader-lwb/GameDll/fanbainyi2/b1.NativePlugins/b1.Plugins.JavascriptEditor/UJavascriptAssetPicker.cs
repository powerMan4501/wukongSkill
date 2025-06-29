using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptAssetPicker : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue__DelegateSignature")]
	public class FOnSetDefaultValue : FDelegate<FOnSetDefaultValue.Signature>
	{
		public delegate void Signature(FText Value);

		private static bool OnSetDefaultValue__DelegateSignature_IsValid;

		private static IntPtr OnSetDefaultValue__DelegateSignature_FunctionAddress;

		private static int OnSetDefaultValue__DelegateSignature_ParamsSize;

		private static bool OnSetDefaultValue__DelegateSignature_Value_IsValid;

		private static FFieldAddress OnSetDefaultValue__DelegateSignature_Value_PropertyAddress;

		private static int OnSetDefaultValue__DelegateSignature_Value_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSetDefaultValue()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSetDefaultValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue__DelegateSignature");
			OnSetDefaultValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetDefaultValue__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSetDefaultValue__DelegateSignature_Value_PropertyAddress, OnSetDefaultValue__DelegateSignature_FunctionAddress, "Value");
			OnSetDefaultValue__DelegateSignature_Value_Offset = NativeReflectionCached.GetPropertyOffset(OnSetDefaultValue__DelegateSignature_FunctionAddress, "Value");
			OnSetDefaultValue__DelegateSignature_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetDefaultValue__DelegateSignature_FunctionAddress, "Value", Classes.FTextProperty);
			OnSetDefaultValue__DelegateSignature_IsValid = OnSetDefaultValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSetDefaultValue__DelegateSignature_Value_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue__DelegateSignature", OnSetDefaultValue__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Value)
		{
			if (!OnSetDefaultValue__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSetDefaultValue__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetDefaultValue__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnSetDefaultValue__DelegateSignature_Value_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnSetDefaultValue__DelegateSignature_Value_Offset), 0, OnSetDefaultValue__DelegateSignature_Value_PropertyAddress.Address, Value);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnSetDefaultValue__DelegateSignature_Value_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue__DelegateSignature")]
	public class FOnGetDefaultValue : FDelegate<FOnGetDefaultValue.Signature>
	{
		public delegate UObject Signature();

		private static bool OnGetDefaultValue__DelegateSignature_IsValid;

		private static IntPtr OnGetDefaultValue__DelegateSignature_FunctionAddress;

		private static int OnGetDefaultValue__DelegateSignature_ParamsSize;

		private static bool OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetDefaultValue__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetDefaultValue()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetDefaultValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue__DelegateSignature");
			OnGetDefaultValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetDefaultValue__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress, OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetDefaultValue__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetDefaultValue__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			OnGetDefaultValue__DelegateSignature_IsValid = OnGetDefaultValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetDefaultValue__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue__DelegateSignature", OnGetDefaultValue__DelegateSignature_IsValid);
		}

		private unsafe UObject Invoker()
		{
			if (!OnGetDefaultValue__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetDefaultValue__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetDefaultValue__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, OnGetDefaultValue__DelegateSignature_ReturnValue_Offset), 0, OnGetDefaultValue__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	private static bool OnGetDefaultValue_IsValid;

	private static int OnGetDefaultValue_Offset;

	private FOnGetDefaultValue OnGetDefaultValue_DelegateCached;

	private static bool OnSetDefaultValue_IsValid;

	private static int OnSetDefaultValue_Offset;

	private FOnSetDefaultValue OnSetDefaultValue_DelegateCached;

	private static bool SetCategoryObject_IsValid;

	private static IntPtr SetCategoryObject_FunctionAddress;

	private static int SetCategoryObject_ParamsSize;

	private static bool SetCategoryObject_InCategoryObject_IsValid;

	private static FFieldAddress SetCategoryObject_InCategoryObject_PropertyAddress;

	private static int SetCategoryObject_InCategoryObject_Offset;

	private static bool SetAllowedClasses_IsValid;

	private static IntPtr SetAllowedClasses_FunctionAddress;

	private static int SetAllowedClasses_ParamsSize;

	private static bool SetAllowedClasses_InAllowedClasses_IsValid;

	private static FFieldAddress SetAllowedClasses_InAllowedClasses_PropertyAddress;

	private static int SetAllowedClasses_InAllowedClasses_Offset;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue")]
	public FOnGetDefaultValue OnGetDefaultValue
	{
		get
		{
			CheckDestroyed();
			if (!OnGetDefaultValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:OnGetDefaultValue");
				return new FOnGetDefaultValue();
			}
			if (OnGetDefaultValue_DelegateCached == null)
			{
				OnGetDefaultValue_DelegateCached = new FOnGetDefaultValue();
				OnGetDefaultValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetDefaultValue_Offset));
			}
			return OnGetDefaultValue_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue")]
	public FOnSetDefaultValue OnSetDefaultValue
	{
		get
		{
			CheckDestroyed();
			if (!OnSetDefaultValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:OnSetDefaultValue");
				return new FOnSetDefaultValue();
			}
			if (OnSetDefaultValue_DelegateCached == null)
			{
				OnSetDefaultValue_DelegateCached = new FOnSetDefaultValue();
				OnSetDefaultValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSetDefaultValue_Offset));
			}
			return OnSetDefaultValue_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:SetCategoryObject")]
	public unsafe void SetCategoryObject(UObject InCategoryObject)
	{
		CheckDestroyed();
		if (!SetCategoryObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:SetCategoryObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCategoryObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCategoryObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetCategoryObject_InCategoryObject_Offset), 0, SetCategoryObject_InCategoryObject_PropertyAddress.Address, InCategoryObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCategoryObject_FunctionAddress, intPtr, SetCategoryObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptAssetPicker:SetAllowedClasses")]
	public unsafe void SetAllowedClasses(string InAllowedClasses)
	{
		CheckDestroyed();
		if (!SetAllowedClasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptAssetPicker:SetAllowedClasses");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowedClasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowedClasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowedClasses_InAllowedClasses_Offset), 0, SetAllowedClasses_InAllowedClasses_PropertyAddress.Address, InAllowedClasses);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowedClasses_FunctionAddress, intPtr, SetAllowedClasses_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAllowedClasses_InAllowedClasses_PropertyAddress.Address, intPtr);
	}

	static UJavascriptAssetPicker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptAssetPicker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptAssetPicker));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptAssetPicker");
		OnGetDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetDefaultValue");
		OnGetDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetDefaultValue", Classes.FDelegateProperty);
		OnSetDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSetDefaultValue");
		OnSetDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSetDefaultValue", Classes.FDelegateProperty);
		SetCategoryObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCategoryObject");
		SetCategoryObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCategoryObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCategoryObject_InCategoryObject_PropertyAddress, SetCategoryObject_FunctionAddress, "InCategoryObject");
		SetCategoryObject_InCategoryObject_Offset = NativeReflectionCached.GetPropertyOffset(SetCategoryObject_FunctionAddress, "InCategoryObject");
		SetCategoryObject_InCategoryObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCategoryObject_FunctionAddress, "InCategoryObject", Classes.FObjectProperty);
		SetCategoryObject_IsValid = SetCategoryObject_FunctionAddress != IntPtr.Zero && SetCategoryObject_InCategoryObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptAssetPicker:SetCategoryObject", SetCategoryObject_IsValid);
		SetAllowedClasses_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowedClasses");
		SetAllowedClasses_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowedClasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowedClasses_InAllowedClasses_PropertyAddress, SetAllowedClasses_FunctionAddress, "InAllowedClasses");
		SetAllowedClasses_InAllowedClasses_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowedClasses_FunctionAddress, "InAllowedClasses");
		SetAllowedClasses_InAllowedClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowedClasses_FunctionAddress, "InAllowedClasses", Classes.FStrProperty);
		SetAllowedClasses_IsValid = SetAllowedClasses_FunctionAddress != IntPtr.Zero && SetAllowedClasses_InAllowedClasses_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptAssetPicker:SetAllowedClasses", SetAllowedClasses_IsValid);
	}
}
