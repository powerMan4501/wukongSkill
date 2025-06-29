using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.BoxComponent", "Engine", UnrealModuleType.Engine)]
public class UBoxComponent : UShapeComponent
{
	private static bool BoxExtent_IsValid;

	private static int BoxExtent_Offset;

	private static bool LineThickness_IsValid;

	private static int LineThickness_Offset;

	private static bool SetBoxExtent_IsValid;

	private static IntPtr SetBoxExtent_FunctionAddress;

	private static int SetBoxExtent_ParamsSize;

	private static bool SetBoxExtent_InBoxExtent_IsValid;

	private static FFieldAddress SetBoxExtent_InBoxExtent_PropertyAddress;

	private static int SetBoxExtent_InBoxExtent_Offset;

	private static bool SetBoxExtent_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetBoxExtent_bUpdateOverlaps_PropertyAddress;

	private static int SetBoxExtent_bUpdateOverlaps_Offset;

	private static bool GetUnscaledBoxExtent_IsValid;

	private static IntPtr GetUnscaledBoxExtent_FunctionAddress;

	private static int GetUnscaledBoxExtent_ParamsSize;

	private static bool GetUnscaledBoxExtent_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledBoxExtent_ReturnValue_PropertyAddress;

	private static int GetUnscaledBoxExtent_ReturnValue_Offset;

	private static bool GetScaledBoxExtent_IsValid;

	private static IntPtr GetScaledBoxExtent_FunctionAddress;

	private static int GetScaledBoxExtent_ParamsSize;

	private static bool GetScaledBoxExtent_ReturnValue_IsValid;

	private static FFieldAddress GetScaledBoxExtent_ReturnValue_PropertyAddress;

	private static int GetScaledBoxExtent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.BoxComponent:BoxExtent")]
	protected FVector BoxExtent
	{
		get
		{
			CheckDestroyed();
			if (!BoxExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxComponent:BoxExtent");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, BoxExtent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxComponent:BoxExtent");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, BoxExtent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.BoxComponent:LineThickness")]
	protected float LineThickness
	{
		get
		{
			CheckDestroyed();
			if (!LineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxComponent:LineThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BoxComponent:LineThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineThickness_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.BoxComponent:SetBoxExtent")]
	public unsafe void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetBoxExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BoxComponent:SetBoxExtent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoxExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoxExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBoxExtent_InBoxExtent_Offset), 0, SetBoxExtent_InBoxExtent_PropertyAddress.Address, InBoxExtent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoxExtent_bUpdateOverlaps_Offset), 0, SetBoxExtent_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoxExtent_FunctionAddress, intPtr, SetBoxExtent_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.BoxComponent:GetUnscaledBoxExtent")]
	public unsafe FVector GetUnscaledBoxExtent()
	{
		CheckDestroyed();
		if (!GetUnscaledBoxExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BoxComponent:GetUnscaledBoxExtent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledBoxExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledBoxExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledBoxExtent_FunctionAddress, intPtr, GetUnscaledBoxExtent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUnscaledBoxExtent_ReturnValue_Offset), 0, GetUnscaledBoxExtent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.BoxComponent:GetScaledBoxExtent")]
	public unsafe FVector GetScaledBoxExtent()
	{
		CheckDestroyed();
		if (!GetScaledBoxExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BoxComponent:GetScaledBoxExtent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledBoxExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledBoxExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledBoxExtent_FunctionAddress, intPtr, GetScaledBoxExtent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetScaledBoxExtent_ReturnValue_Offset), 0, GetScaledBoxExtent_ReturnValue_PropertyAddress.Address);
	}

	static UBoxComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBoxComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBoxComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.BoxComponent");
		BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoxExtent");
		BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoxExtent", Classes.FStructProperty);
		LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineThickness");
		LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineThickness", Classes.FFloatProperty);
		SetBoxExtent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoxExtent");
		SetBoxExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoxExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoxExtent_InBoxExtent_PropertyAddress, SetBoxExtent_FunctionAddress, "InBoxExtent");
		SetBoxExtent_InBoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxExtent_FunctionAddress, "InBoxExtent");
		SetBoxExtent_InBoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxExtent_FunctionAddress, "InBoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxExtent_bUpdateOverlaps_PropertyAddress, SetBoxExtent_FunctionAddress, "bUpdateOverlaps");
		SetBoxExtent_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxExtent_FunctionAddress, "bUpdateOverlaps");
		SetBoxExtent_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxExtent_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetBoxExtent_IsValid = SetBoxExtent_FunctionAddress != IntPtr.Zero && SetBoxExtent_InBoxExtent_IsValid && SetBoxExtent_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BoxComponent:SetBoxExtent", SetBoxExtent_IsValid);
		GetUnscaledBoxExtent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledBoxExtent");
		GetUnscaledBoxExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledBoxExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledBoxExtent_ReturnValue_PropertyAddress, GetUnscaledBoxExtent_FunctionAddress, "ReturnValue");
		GetUnscaledBoxExtent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledBoxExtent_FunctionAddress, "ReturnValue");
		GetUnscaledBoxExtent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledBoxExtent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUnscaledBoxExtent_IsValid = GetUnscaledBoxExtent_FunctionAddress != IntPtr.Zero && GetUnscaledBoxExtent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BoxComponent:GetUnscaledBoxExtent", GetUnscaledBoxExtent_IsValid);
		GetScaledBoxExtent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledBoxExtent");
		GetScaledBoxExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledBoxExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledBoxExtent_ReturnValue_PropertyAddress, GetScaledBoxExtent_FunctionAddress, "ReturnValue");
		GetScaledBoxExtent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledBoxExtent_FunctionAddress, "ReturnValue");
		GetScaledBoxExtent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledBoxExtent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScaledBoxExtent_IsValid = GetScaledBoxExtent_FunctionAddress != IntPtr.Zero && GetScaledBoxExtent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BoxComponent:GetScaledBoxExtent", GetScaledBoxExtent_IsValid);
	}
}
