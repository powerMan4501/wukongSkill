using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SphereComponent", "Engine", UnrealModuleType.Engine)]
public class USphereComponent : UShapeComponent
{
	private static bool SphereRadius_IsValid;

	private static int SphereRadius_Offset;

	private static bool SetSphereRadius_IsValid;

	private static IntPtr SetSphereRadius_FunctionAddress;

	private static int SetSphereRadius_ParamsSize;

	private static bool SetSphereRadius_InSphereRadius_IsValid;

	private static FFieldAddress SetSphereRadius_InSphereRadius_PropertyAddress;

	private static int SetSphereRadius_InSphereRadius_Offset;

	private static bool SetSphereRadius_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetSphereRadius_bUpdateOverlaps_PropertyAddress;

	private static int SetSphereRadius_bUpdateOverlaps_Offset;

	private static bool GetUnscaledSphereRadius_IsValid;

	private static IntPtr GetUnscaledSphereRadius_FunctionAddress;

	private static int GetUnscaledSphereRadius_ParamsSize;

	private static bool GetUnscaledSphereRadius_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledSphereRadius_ReturnValue_PropertyAddress;

	private static int GetUnscaledSphereRadius_ReturnValue_Offset;

	private static bool GetShapeScale_IsValid;

	private static IntPtr GetShapeScale_FunctionAddress;

	private static int GetShapeScale_ParamsSize;

	private static bool GetShapeScale_ReturnValue_IsValid;

	private static FFieldAddress GetShapeScale_ReturnValue_PropertyAddress;

	private static int GetShapeScale_ReturnValue_Offset;

	private static bool GetScaledSphereRadius_IsValid;

	private static IntPtr GetScaledSphereRadius_FunctionAddress;

	private static int GetScaledSphereRadius_ParamsSize;

	private static bool GetScaledSphereRadius_ReturnValue_IsValid;

	private static FFieldAddress GetScaledSphereRadius_ReturnValue_PropertyAddress;

	private static int GetScaledSphereRadius_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.SphereComponent:SphereRadius")]
	protected float SphereRadius
	{
		get
		{
			CheckDestroyed();
			if (!SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SphereComponent:SphereRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SphereRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SphereComponent:SphereRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SphereRadius_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SphereComponent:SetSphereRadius")]
	public unsafe void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetSphereRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SphereComponent:SetSphereRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSphereRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSphereRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSphereRadius_InSphereRadius_Offset), 0, SetSphereRadius_InSphereRadius_PropertyAddress.Address, InSphereRadius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSphereRadius_bUpdateOverlaps_Offset), 0, SetSphereRadius_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSphereRadius_FunctionAddress, intPtr, SetSphereRadius_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SphereComponent:GetUnscaledSphereRadius")]
	public unsafe float GetUnscaledSphereRadius()
	{
		CheckDestroyed();
		if (!GetUnscaledSphereRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SphereComponent:GetUnscaledSphereRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledSphereRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledSphereRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledSphereRadius_FunctionAddress, intPtr, GetUnscaledSphereRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledSphereRadius_ReturnValue_Offset), 0, GetUnscaledSphereRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SphereComponent:GetShapeScale")]
	public unsafe float GetShapeScale()
	{
		CheckDestroyed();
		if (!GetShapeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SphereComponent:GetShapeScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShapeScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShapeScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShapeScale_FunctionAddress, intPtr, GetShapeScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetShapeScale_ReturnValue_Offset), 0, GetShapeScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SphereComponent:GetScaledSphereRadius")]
	public unsafe float GetScaledSphereRadius()
	{
		CheckDestroyed();
		if (!GetScaledSphereRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SphereComponent:GetScaledSphereRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledSphereRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledSphereRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledSphereRadius_FunctionAddress, intPtr, GetScaledSphereRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledSphereRadius_ReturnValue_Offset), 0, GetScaledSphereRadius_ReturnValue_PropertyAddress.Address);
	}

	static USphereComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USphereComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USphereComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SphereComponent");
		SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SphereRadius");
		SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SphereRadius", Classes.FFloatProperty);
		SetSphereRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSphereRadius");
		SetSphereRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSphereRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSphereRadius_InSphereRadius_PropertyAddress, SetSphereRadius_FunctionAddress, "InSphereRadius");
		SetSphereRadius_InSphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetSphereRadius_FunctionAddress, "InSphereRadius");
		SetSphereRadius_InSphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSphereRadius_FunctionAddress, "InSphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSphereRadius_bUpdateOverlaps_PropertyAddress, SetSphereRadius_FunctionAddress, "bUpdateOverlaps");
		SetSphereRadius_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetSphereRadius_FunctionAddress, "bUpdateOverlaps");
		SetSphereRadius_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSphereRadius_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetSphereRadius_IsValid = SetSphereRadius_FunctionAddress != IntPtr.Zero && SetSphereRadius_InSphereRadius_IsValid && SetSphereRadius_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SphereComponent:SetSphereRadius", SetSphereRadius_IsValid);
		GetUnscaledSphereRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledSphereRadius");
		GetUnscaledSphereRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledSphereRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledSphereRadius_ReturnValue_PropertyAddress, GetUnscaledSphereRadius_FunctionAddress, "ReturnValue");
		GetUnscaledSphereRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledSphereRadius_FunctionAddress, "ReturnValue");
		GetUnscaledSphereRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledSphereRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledSphereRadius_IsValid = GetUnscaledSphereRadius_FunctionAddress != IntPtr.Zero && GetUnscaledSphereRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SphereComponent:GetUnscaledSphereRadius", GetUnscaledSphereRadius_IsValid);
		GetShapeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShapeScale");
		GetShapeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeScale_ReturnValue_PropertyAddress, GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetShapeScale_IsValid = GetShapeScale_FunctionAddress != IntPtr.Zero && GetShapeScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SphereComponent:GetShapeScale", GetShapeScale_IsValid);
		GetScaledSphereRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledSphereRadius");
		GetScaledSphereRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledSphereRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledSphereRadius_ReturnValue_PropertyAddress, GetScaledSphereRadius_FunctionAddress, "ReturnValue");
		GetScaledSphereRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledSphereRadius_FunctionAddress, "ReturnValue");
		GetScaledSphereRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledSphereRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledSphereRadius_IsValid = GetScaledSphereRadius_FunctionAddress != IntPtr.Zero && GetScaledSphereRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SphereComponent:GetScaledSphereRadius", GetScaledSphereRadius_IsValid);
	}
}
