using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptColorPicker", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptColorPicker : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChangedEvent__DelegateSignature")]
	public class FOnColorChangedEvent : FMulticastDelegate<FOnColorChangedEvent.Signature>
	{
		public delegate void Signature(FLinearColor Color);

		private static bool OnColorChangedEvent__DelegateSignature_IsValid;

		private static IntPtr OnColorChangedEvent__DelegateSignature_FunctionAddress;

		private static int OnColorChangedEvent__DelegateSignature_ParamsSize;

		private static bool OnColorChangedEvent__DelegateSignature_Color_IsValid;

		private static FFieldAddress OnColorChangedEvent__DelegateSignature_Color_PropertyAddress;

		private static int OnColorChangedEvent__DelegateSignature_Color_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnColorChangedEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnColorChangedEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChangedEvent__DelegateSignature");
			OnColorChangedEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnColorChangedEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnColorChangedEvent__DelegateSignature_Color_PropertyAddress, OnColorChangedEvent__DelegateSignature_FunctionAddress, "Color");
			OnColorChangedEvent__DelegateSignature_Color_Offset = NativeReflectionCached.GetPropertyOffset(OnColorChangedEvent__DelegateSignature_FunctionAddress, "Color");
			OnColorChangedEvent__DelegateSignature_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(OnColorChangedEvent__DelegateSignature_FunctionAddress, "Color", Classes.FStructProperty);
			OnColorChangedEvent__DelegateSignature_IsValid = OnColorChangedEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnColorChangedEvent__DelegateSignature_Color_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChangedEvent__DelegateSignature", OnColorChangedEvent__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FLinearColor Color)
		{
			if (!OnColorChangedEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChangedEvent__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnColorChangedEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnColorChangedEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, OnColorChangedEvent__DelegateSignature_Color_Offset), 0, OnColorChangedEvent__DelegateSignature_Color_PropertyAddress.Address, Color);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool OnColorChanged_IsValid;

	private static int OnColorChanged_Offset;

	private FOnColorChangedEvent OnColorChanged_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChanged")]
	public FOnColorChangedEvent OnColorChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnColorChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptColorPicker:OnColorChanged");
				return new FOnColorChangedEvent();
			}
			if (OnColorChanged_DelegateCached == null)
			{
				OnColorChanged_DelegateCached = new FOnColorChangedEvent();
				OnColorChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnColorChanged_Offset));
			}
			return OnColorChanged_DelegateCached;
		}
	}

	static UJavascriptColorPicker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptColorPicker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptColorPicker));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptColorPicker");
		OnColorChanged_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnColorChanged");
		OnColorChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnColorChanged", Classes.FMulticastDelegateProperty);
	}
}
