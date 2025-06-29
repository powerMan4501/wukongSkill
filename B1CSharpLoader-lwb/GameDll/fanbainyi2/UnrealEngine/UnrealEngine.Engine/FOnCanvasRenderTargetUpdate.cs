using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature")]
public class FOnCanvasRenderTargetUpdate : FMulticastDelegate<FOnCanvasRenderTargetUpdate.Signature>
{
	public delegate void Signature(UCanvas Canvas, int Width, int Height);

	private static bool OnCanvasRenderTargetUpdate__DelegateSignature_IsValid;

	private static IntPtr OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress;

	private static int OnCanvasRenderTargetUpdate__DelegateSignature_ParamsSize;

	private static bool OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_IsValid;

	private static FFieldAddress OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_PropertyAddress;

	private static int OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_Offset;

	private static bool OnCanvasRenderTargetUpdate__DelegateSignature_Width_IsValid;

	private static FFieldAddress OnCanvasRenderTargetUpdate__DelegateSignature_Width_PropertyAddress;

	private static int OnCanvasRenderTargetUpdate__DelegateSignature_Width_Offset;

	private static bool OnCanvasRenderTargetUpdate__DelegateSignature_Height_IsValid;

	private static FFieldAddress OnCanvasRenderTargetUpdate__DelegateSignature_Height_PropertyAddress;

	private static int OnCanvasRenderTargetUpdate__DelegateSignature_Height_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCanvasRenderTargetUpdate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature");
		OnCanvasRenderTargetUpdate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_PropertyAddress, OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Canvas");
		OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Canvas");
		OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnCanvasRenderTargetUpdate__DelegateSignature_Width_PropertyAddress, OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Width");
		OnCanvasRenderTargetUpdate__DelegateSignature_Width_Offset = NativeReflectionCached.GetPropertyOffset(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Width");
		OnCanvasRenderTargetUpdate__DelegateSignature_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnCanvasRenderTargetUpdate__DelegateSignature_Height_PropertyAddress, OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Height");
		OnCanvasRenderTargetUpdate__DelegateSignature_Height_Offset = NativeReflectionCached.GetPropertyOffset(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Height");
		OnCanvasRenderTargetUpdate__DelegateSignature_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress, "Height", Classes.FIntProperty);
		OnCanvasRenderTargetUpdate__DelegateSignature_IsValid = OnCanvasRenderTargetUpdate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_IsValid && OnCanvasRenderTargetUpdate__DelegateSignature_Width_IsValid && OnCanvasRenderTargetUpdate__DelegateSignature_Height_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature", OnCanvasRenderTargetUpdate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UCanvas Canvas, int Width, int Height)
	{
		if (!OnCanvasRenderTargetUpdate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCanvasRenderTargetUpdate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCanvasRenderTargetUpdate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_Offset), 0, OnCanvasRenderTargetUpdate__DelegateSignature_Canvas_PropertyAddress.Address, Canvas);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnCanvasRenderTargetUpdate__DelegateSignature_Width_Offset), 0, OnCanvasRenderTargetUpdate__DelegateSignature_Width_PropertyAddress.Address, Width);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnCanvasRenderTargetUpdate__DelegateSignature_Height_Offset), 0, OnCanvasRenderTargetUpdate__DelegateSignature_Height_PropertyAddress.Address, Height);
			ProcessDelegate(intPtr);
		}
	}
}
