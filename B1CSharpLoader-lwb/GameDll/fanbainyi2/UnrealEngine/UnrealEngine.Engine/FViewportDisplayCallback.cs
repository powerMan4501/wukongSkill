using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ViewportDisplayCallback__DelegateSignature")]
public class FViewportDisplayCallback : FDelegate<FViewportDisplayCallback.Signature>
{
	public delegate bool Signature(out FText OutText, out FLinearColor OutColor);

	private static bool ViewportDisplayCallback__DelegateSignature_IsValid;

	private static IntPtr ViewportDisplayCallback__DelegateSignature_FunctionAddress;

	private static int ViewportDisplayCallback__DelegateSignature_ParamsSize;

	private static bool ViewportDisplayCallback__DelegateSignature_OutText_IsValid;

	private static FFieldAddress ViewportDisplayCallback__DelegateSignature_OutText_PropertyAddress;

	private static int ViewportDisplayCallback__DelegateSignature_OutText_Offset;

	private static bool ViewportDisplayCallback__DelegateSignature_OutColor_IsValid;

	private static FFieldAddress ViewportDisplayCallback__DelegateSignature_OutColor_PropertyAddress;

	private static int ViewportDisplayCallback__DelegateSignature_OutColor_Offset;

	private static bool ViewportDisplayCallback__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress ViewportDisplayCallback__DelegateSignature_ReturnValue_PropertyAddress;

	private static int ViewportDisplayCallback__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FViewportDisplayCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ViewportDisplayCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ViewportDisplayCallback__DelegateSignature");
		ViewportDisplayCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ViewportDisplayCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ViewportDisplayCallback__DelegateSignature_OutText_PropertyAddress, ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutText");
		ViewportDisplayCallback__DelegateSignature_OutText_Offset = NativeReflectionCached.GetPropertyOffset(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutText");
		ViewportDisplayCallback__DelegateSignature_OutText_IsValid = NativeReflectionCached.ValidatePropertyClass(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ViewportDisplayCallback__DelegateSignature_OutColor_PropertyAddress, ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutColor");
		ViewportDisplayCallback__DelegateSignature_OutColor_Offset = NativeReflectionCached.GetPropertyOffset(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutColor");
		ViewportDisplayCallback__DelegateSignature_OutColor_IsValid = NativeReflectionCached.ValidatePropertyClass(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "OutColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ViewportDisplayCallback__DelegateSignature_ReturnValue_PropertyAddress, ViewportDisplayCallback__DelegateSignature_FunctionAddress, "ReturnValue");
		ViewportDisplayCallback__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "ReturnValue");
		ViewportDisplayCallback__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ViewportDisplayCallback__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ViewportDisplayCallback__DelegateSignature_IsValid = ViewportDisplayCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && ViewportDisplayCallback__DelegateSignature_OutText_IsValid && ViewportDisplayCallback__DelegateSignature_OutColor_IsValid && ViewportDisplayCallback__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ViewportDisplayCallback__DelegateSignature", ViewportDisplayCallback__DelegateSignature_IsValid);
	}

	private unsafe bool Invoker(out FText OutText, out FLinearColor OutColor)
	{
		if (!ViewportDisplayCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ViewportDisplayCallback__DelegateSignature");
			OutText = null;
			OutColor = default(FLinearColor);
			return false;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ViewportDisplayCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ViewportDisplayCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(ViewportDisplayCallback__DelegateSignature_OutText_PropertyAddress.Address, intPtr);
			ProcessDelegate(intPtr);
			OutText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ViewportDisplayCallback__DelegateSignature_OutText_Offset), 0, ViewportDisplayCallback__DelegateSignature_OutText_PropertyAddress.Address);
			NativeReflection.DestroyValue_InContainer(ViewportDisplayCallback__DelegateSignature_OutText_PropertyAddress.Address, intPtr);
			OutColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, ViewportDisplayCallback__DelegateSignature_OutColor_Offset), 0, ViewportDisplayCallback__DelegateSignature_OutColor_PropertyAddress.Address);
			return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ViewportDisplayCallback__DelegateSignature_ReturnValue_Offset), 0, ViewportDisplayCallback__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		OutText = null;
		OutColor = default(FLinearColor);
		return false;
	}
}
