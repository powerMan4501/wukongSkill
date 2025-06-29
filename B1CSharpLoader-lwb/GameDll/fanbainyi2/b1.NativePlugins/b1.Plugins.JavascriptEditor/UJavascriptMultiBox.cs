using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptMultiBox", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptMultiBox : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMultiBox:OnHook__DelegateSignature")]
	public class FOnHook : FDelegate<FOnHook.Signature>
	{
		public delegate void Signature(FName Id, UJavascriptMultiBox Self, FJavascriptMenuBuilder CurrentBuilder);

		private static bool OnHook__DelegateSignature_IsValid;

		private static IntPtr OnHook__DelegateSignature_FunctionAddress;

		private static int OnHook__DelegateSignature_ParamsSize;

		private static bool OnHook__DelegateSignature_Id_IsValid;

		private static FFieldAddress OnHook__DelegateSignature_Id_PropertyAddress;

		private static int OnHook__DelegateSignature_Id_Offset;

		private static bool OnHook__DelegateSignature_Self_IsValid;

		private static FFieldAddress OnHook__DelegateSignature_Self_PropertyAddress;

		private static int OnHook__DelegateSignature_Self_Offset;

		private static bool OnHook__DelegateSignature_CurrentBuilder_IsValid;

		private static FFieldAddress OnHook__DelegateSignature_CurrentBuilder_PropertyAddress;

		private static int OnHook__DelegateSignature_CurrentBuilder_Offset;

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
			OnHook__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptMultiBox:OnHook__DelegateSignature");
			OnHook__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHook__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnHook__DelegateSignature_Id_PropertyAddress, OnHook__DelegateSignature_FunctionAddress, "Id");
			OnHook__DelegateSignature_Id_Offset = NativeReflectionCached.GetPropertyOffset(OnHook__DelegateSignature_FunctionAddress, "Id");
			OnHook__DelegateSignature_Id_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHook__DelegateSignature_FunctionAddress, "Id", Classes.FNameProperty);
			NativeReflectionCached.GetPropertyRef(ref OnHook__DelegateSignature_Self_PropertyAddress, OnHook__DelegateSignature_FunctionAddress, "Self");
			OnHook__DelegateSignature_Self_Offset = NativeReflectionCached.GetPropertyOffset(OnHook__DelegateSignature_FunctionAddress, "Self");
			OnHook__DelegateSignature_Self_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHook__DelegateSignature_FunctionAddress, "Self", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnHook__DelegateSignature_CurrentBuilder_PropertyAddress, OnHook__DelegateSignature_FunctionAddress, "CurrentBuilder");
			OnHook__DelegateSignature_CurrentBuilder_Offset = NativeReflectionCached.GetPropertyOffset(OnHook__DelegateSignature_FunctionAddress, "CurrentBuilder");
			OnHook__DelegateSignature_CurrentBuilder_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHook__DelegateSignature_FunctionAddress, "CurrentBuilder", Classes.FStructProperty);
			OnHook__DelegateSignature_IsValid = OnHook__DelegateSignature_FunctionAddress != IntPtr.Zero && OnHook__DelegateSignature_Id_IsValid && OnHook__DelegateSignature_Self_IsValid && OnHook__DelegateSignature_CurrentBuilder_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptMultiBox:OnHook__DelegateSignature", OnHook__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FName Id, UJavascriptMultiBox Self, FJavascriptMenuBuilder CurrentBuilder)
		{
			if (!OnHook__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptMultiBox:OnHook__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnHook__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnHook__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnHook__DelegateSignature_Id_Offset), 0, OnHook__DelegateSignature_Id_PropertyAddress.Address, Id);
				UObjectMarshaler<UJavascriptMultiBox>.ToNative(IntPtr.Add(intPtr, OnHook__DelegateSignature_Self_Offset), 0, OnHook__DelegateSignature_Self_PropertyAddress.Address, Self);
				NativeReflection.InitializeValue_InContainer(OnHook__DelegateSignature_CurrentBuilder_PropertyAddress.Address, intPtr);
				FJavascriptMenuBuilder.ToNative(IntPtr.Add(intPtr, OnHook__DelegateSignature_CurrentBuilder_Offset), 0, OnHook__DelegateSignature_CurrentBuilder_PropertyAddress.Address, CurrentBuilder);
				ProcessDelegate(intPtr);
			}
		}
	}

	static UJavascriptMultiBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptMultiBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptMultiBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptMultiBox");
	}
}
