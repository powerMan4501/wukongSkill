using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UDelegate]
[UMetaPath("/Script/Water.OnCameraUnderwaterStateChanged__DelegateSignature")]
public class FOnCameraUnderwaterStateChanged : FMulticastDelegate<FOnCameraUnderwaterStateChanged.Signature>
{
	public delegate void Signature(bool bIsUnderWater, float DepthUnderwater);

	private static bool OnCameraUnderwaterStateChanged__DelegateSignature_IsValid;

	private static IntPtr OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress;

	private static int OnCameraUnderwaterStateChanged__DelegateSignature_ParamsSize;

	private static bool OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_IsValid;

	private static FFieldAddress OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_PropertyAddress;

	private static int OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_Offset;

	private static bool OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_IsValid;

	private static FFieldAddress OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_PropertyAddress;

	private static int OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCameraUnderwaterStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Water.OnCameraUnderwaterStateChanged__DelegateSignature");
		OnCameraUnderwaterStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_PropertyAddress, OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "bIsUnderWater");
		OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_Offset = NativeReflectionCached.GetPropertyOffset(OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "bIsUnderWater");
		OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "bIsUnderWater", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_PropertyAddress, OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "DepthUnderwater");
		OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_Offset = NativeReflectionCached.GetPropertyOffset(OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "DepthUnderwater");
		OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress, "DepthUnderwater", Classes.FFloatProperty);
		OnCameraUnderwaterStateChanged__DelegateSignature_IsValid = OnCameraUnderwaterStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_IsValid && OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.OnCameraUnderwaterStateChanged__DelegateSignature", OnCameraUnderwaterStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsUnderWater, float DepthUnderwater)
	{
		if (!OnCameraUnderwaterStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.OnCameraUnderwaterStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCameraUnderwaterStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCameraUnderwaterStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_Offset), 0, OnCameraUnderwaterStateChanged__DelegateSignature_bIsUnderWater_PropertyAddress.Address, bIsUnderWater);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_Offset), 0, OnCameraUnderwaterStateChanged__DelegateSignature_DepthUnderwater_PropertyAddress.Address, DepthUnderwater);
			ProcessDelegate(intPtr);
		}
	}
}
