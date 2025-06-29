using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorToolbar", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorToolbar : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorToolbar:OnHook__DelegateSignature")]
	public class FOnHook : FDelegate<FOnHook.Signature>
	{
		public delegate FJavascriptMenuBuilder Signature();

		private static bool OnHook__DelegateSignature_IsValid;

		private static IntPtr OnHook__DelegateSignature_FunctionAddress;

		private static int OnHook__DelegateSignature_ParamsSize;

		private static bool OnHook__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnHook__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnHook__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnHook()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnHook__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorToolbar:OnHook__DelegateSignature");
			OnHook__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHook__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnHook__DelegateSignature_ReturnValue_PropertyAddress, OnHook__DelegateSignature_FunctionAddress, "ReturnValue");
			OnHook__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnHook__DelegateSignature_FunctionAddress, "ReturnValue");
			OnHook__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHook__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnHook__DelegateSignature_IsValid = OnHook__DelegateSignature_FunctionAddress != IntPtr.Zero && OnHook__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorToolbar:OnHook__DelegateSignature", OnHook__DelegateSignature_IsValid);
		}

		private unsafe FJavascriptMenuBuilder Invoker()
		{
			if (!OnHook__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorToolbar:OnHook__DelegateSignature");
				return default(FJavascriptMenuBuilder);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnHook__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnHook__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return FJavascriptMenuBuilder.FromNative(IntPtr.Add(intPtr, OnHook__DelegateSignature_ReturnValue_Offset), 0, OnHook__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FJavascriptMenuBuilder);
		}
	}

	static UJavascriptEditorToolbar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorToolbar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorToolbar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorToolbar");
	}
}
