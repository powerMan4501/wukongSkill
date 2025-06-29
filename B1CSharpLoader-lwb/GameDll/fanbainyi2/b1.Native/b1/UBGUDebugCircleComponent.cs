using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819990692uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUDebugCircleComponent", "b1", UnrealModuleType.Game)]
public class UBGUDebugCircleComponent : UShapeComponent
{
	private static bool CircleRadius_IsValid;

	private static int CircleRadius_Offset;

	private static bool CircleThickness_IsValid;

	private static int CircleThickness_Offset;

	private static bool SetCircleRadius_IsValid;

	private static IntPtr SetCircleRadius_FunctionAddress;

	private static int SetCircleRadius_ParamsSize;

	private static bool SetCircleRadius_InCircleRadius_IsValid;

	private static FFieldAddress SetCircleRadius_InCircleRadius_PropertyAddress;

	private static int SetCircleRadius_InCircleRadius_Offset;

	private static bool GetUnscaledCircleRadius_IsValid;

	private static IntPtr GetUnscaledCircleRadius_FunctionAddress;

	private static int GetUnscaledCircleRadius_ParamsSize;

	private static bool GetUnscaledCircleRadius_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledCircleRadius_ReturnValue_PropertyAddress;

	private static int GetUnscaledCircleRadius_ReturnValue_Offset;

	private static bool GetShapeScale_IsValid;

	private static IntPtr GetShapeScale_FunctionAddress;

	private static int GetShapeScale_ParamsSize;

	private static bool GetShapeScale_ReturnValue_IsValid;

	private static FFieldAddress GetShapeScale_ReturnValue_PropertyAddress;

	private static int GetShapeScale_ReturnValue_Offset;

	private static bool GetScaledCircleRadius_IsValid;

	private static IntPtr GetScaledCircleRadius_FunctionAddress;

	private static int GetScaledCircleRadius_ParamsSize;

	private static bool GetScaledCircleRadius_ReturnValue_IsValid;

	private static FFieldAddress GetScaledCircleRadius_ReturnValue_PropertyAddress;

	private static int GetScaledCircleRadius_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:CircleRadius")]
	protected float CircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugCircleComponent:CircleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugCircleComponent:CircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:CircleThickness")]
	protected float CircleThickness
	{
		get
		{
			CheckDestroyed();
			if (!CircleThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugCircleComponent:CircleThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugCircleComponent:CircleThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleThickness_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:SetCircleRadius")]
	public unsafe void SetCircleRadius(float InCircleRadius)
	{
		CheckDestroyed();
		if (!SetCircleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugCircleComponent:SetCircleRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCircleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCircleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCircleRadius_InCircleRadius_Offset), 0, SetCircleRadius_InCircleRadius_PropertyAddress.Address, InCircleRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCircleRadius_FunctionAddress, intPtr, SetCircleRadius_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:GetUnscaledCircleRadius")]
	public unsafe float GetUnscaledCircleRadius()
	{
		CheckDestroyed();
		if (!GetUnscaledCircleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugCircleComponent:GetUnscaledCircleRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCircleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCircleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCircleRadius_FunctionAddress, intPtr, GetUnscaledCircleRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCircleRadius_ReturnValue_Offset), 0, GetUnscaledCircleRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:GetShapeScale")]
	public unsafe float GetShapeScale()
	{
		CheckDestroyed();
		if (!GetShapeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugCircleComponent:GetShapeScale");
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
	[UMetaPath("/Script/b1.BGUDebugCircleComponent:GetScaledCircleRadius")]
	public unsafe float GetScaledCircleRadius()
	{
		CheckDestroyed();
		if (!GetScaledCircleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugCircleComponent:GetScaledCircleRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCircleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCircleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCircleRadius_FunctionAddress, intPtr, GetScaledCircleRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCircleRadius_ReturnValue_Offset), 0, GetScaledCircleRadius_ReturnValue_PropertyAddress.Address);
	}

	static UBGUDebugCircleComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUDebugCircleComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUDebugCircleComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUDebugCircleComponent");
		CircleRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CircleRadius");
		CircleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CircleRadius", Classes.FFloatProperty);
		CircleThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CircleThickness");
		CircleThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CircleThickness", Classes.FFloatProperty);
		SetCircleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCircleRadius");
		SetCircleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCircleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCircleRadius_InCircleRadius_PropertyAddress, SetCircleRadius_FunctionAddress, "InCircleRadius");
		SetCircleRadius_InCircleRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetCircleRadius_FunctionAddress, "InCircleRadius");
		SetCircleRadius_InCircleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCircleRadius_FunctionAddress, "InCircleRadius", Classes.FFloatProperty);
		SetCircleRadius_IsValid = SetCircleRadius_FunctionAddress != IntPtr.Zero && SetCircleRadius_InCircleRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugCircleComponent:SetCircleRadius", SetCircleRadius_IsValid);
		GetUnscaledCircleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCircleRadius");
		GetUnscaledCircleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCircleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCircleRadius_ReturnValue_PropertyAddress, GetUnscaledCircleRadius_FunctionAddress, "ReturnValue");
		GetUnscaledCircleRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCircleRadius_FunctionAddress, "ReturnValue");
		GetUnscaledCircleRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCircleRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledCircleRadius_IsValid = GetUnscaledCircleRadius_FunctionAddress != IntPtr.Zero && GetUnscaledCircleRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugCircleComponent:GetUnscaledCircleRadius", GetUnscaledCircleRadius_IsValid);
		GetShapeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShapeScale");
		GetShapeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeScale_ReturnValue_PropertyAddress, GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetShapeScale_IsValid = GetShapeScale_FunctionAddress != IntPtr.Zero && GetShapeScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugCircleComponent:GetShapeScale", GetShapeScale_IsValid);
		GetScaledCircleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCircleRadius");
		GetScaledCircleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCircleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCircleRadius_ReturnValue_PropertyAddress, GetScaledCircleRadius_FunctionAddress, "ReturnValue");
		GetScaledCircleRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCircleRadius_FunctionAddress, "ReturnValue");
		GetScaledCircleRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCircleRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledCircleRadius_IsValid = GetScaledCircleRadius_FunctionAddress != IntPtr.Zero && GetScaledCircleRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugCircleComponent:GetScaledCircleRadius", GetScaledCircleRadius_IsValid);
	}
}
