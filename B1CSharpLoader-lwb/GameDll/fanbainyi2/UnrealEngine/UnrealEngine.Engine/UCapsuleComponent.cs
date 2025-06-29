using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CapsuleComponent", "Engine", UnrealModuleType.Engine)]
public class UCapsuleComponent : UShapeComponent
{
	private static bool CapsuleHalfHeight_IsValid;

	private static int CapsuleHalfHeight_Offset;

	private static bool CapsuleRadius_IsValid;

	private static int CapsuleRadius_Offset;

	private static bool SetCapsuleSize_IsValid;

	private static IntPtr SetCapsuleSize_FunctionAddress;

	private static int SetCapsuleSize_ParamsSize;

	private static bool SetCapsuleSize_InRadius_IsValid;

	private static FFieldAddress SetCapsuleSize_InRadius_PropertyAddress;

	private static int SetCapsuleSize_InRadius_Offset;

	private static bool SetCapsuleSize_InHalfHeight_IsValid;

	private static FFieldAddress SetCapsuleSize_InHalfHeight_PropertyAddress;

	private static int SetCapsuleSize_InHalfHeight_Offset;

	private static bool SetCapsuleSize_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetCapsuleSize_bUpdateOverlaps_PropertyAddress;

	private static int SetCapsuleSize_bUpdateOverlaps_Offset;

	private static bool SetCapsuleRadius_IsValid;

	private static IntPtr SetCapsuleRadius_FunctionAddress;

	private static int SetCapsuleRadius_ParamsSize;

	private static bool SetCapsuleRadius_Radius_IsValid;

	private static FFieldAddress SetCapsuleRadius_Radius_PropertyAddress;

	private static int SetCapsuleRadius_Radius_Offset;

	private static bool SetCapsuleRadius_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetCapsuleRadius_bUpdateOverlaps_PropertyAddress;

	private static int SetCapsuleRadius_bUpdateOverlaps_Offset;

	private static bool SetCapsuleHalfHeight_IsValid;

	private static IntPtr SetCapsuleHalfHeight_FunctionAddress;

	private static int SetCapsuleHalfHeight_ParamsSize;

	private static bool SetCapsuleHalfHeight_HalfHeight_IsValid;

	private static FFieldAddress SetCapsuleHalfHeight_HalfHeight_PropertyAddress;

	private static int SetCapsuleHalfHeight_HalfHeight_Offset;

	private static bool SetCapsuleHalfHeight_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetCapsuleHalfHeight_bUpdateOverlaps_PropertyAddress;

	private static int SetCapsuleHalfHeight_bUpdateOverlaps_Offset;

	private static bool GetUnscaledCapsuleSize_WithoutHemisphere_IsValid;

	private static IntPtr GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress;

	private static int GetUnscaledCapsuleSize_WithoutHemisphere_ParamsSize;

	private static bool GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid;

	private static FFieldAddress GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress;

	private static int GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_Offset;

	private static bool GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid;

	private static FFieldAddress GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress;

	private static int GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset;

	private static bool GetUnscaledCapsuleSize_IsValid;

	private static IntPtr GetUnscaledCapsuleSize_FunctionAddress;

	private static int GetUnscaledCapsuleSize_ParamsSize;

	private static bool GetUnscaledCapsuleSize_OutRadius_IsValid;

	private static FFieldAddress GetUnscaledCapsuleSize_OutRadius_PropertyAddress;

	private static int GetUnscaledCapsuleSize_OutRadius_Offset;

	private static bool GetUnscaledCapsuleSize_OutHalfHeight_IsValid;

	private static FFieldAddress GetUnscaledCapsuleSize_OutHalfHeight_PropertyAddress;

	private static int GetUnscaledCapsuleSize_OutHalfHeight_Offset;

	private static bool GetUnscaledCapsuleRadius_IsValid;

	private static IntPtr GetUnscaledCapsuleRadius_FunctionAddress;

	private static int GetUnscaledCapsuleRadius_ParamsSize;

	private static bool GetUnscaledCapsuleRadius_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledCapsuleRadius_ReturnValue_PropertyAddress;

	private static int GetUnscaledCapsuleRadius_ReturnValue_Offset;

	private static bool GetUnscaledCapsuleHalfHeight_WithoutHemisphere_IsValid;

	private static IntPtr GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress;

	private static int GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize;

	private static bool GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress;

	private static int GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset;

	private static bool GetUnscaledCapsuleHalfHeight_IsValid;

	private static IntPtr GetUnscaledCapsuleHalfHeight_FunctionAddress;

	private static int GetUnscaledCapsuleHalfHeight_ParamsSize;

	private static bool GetUnscaledCapsuleHalfHeight_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledCapsuleHalfHeight_ReturnValue_PropertyAddress;

	private static int GetUnscaledCapsuleHalfHeight_ReturnValue_Offset;

	private static bool GetShapeScale_IsValid;

	private static IntPtr GetShapeScale_FunctionAddress;

	private static int GetShapeScale_ParamsSize;

	private static bool GetShapeScale_ReturnValue_IsValid;

	private static FFieldAddress GetShapeScale_ReturnValue_PropertyAddress;

	private static int GetShapeScale_ReturnValue_Offset;

	private static bool GetScaledCapsuleSize_WithoutHemisphere_IsValid;

	private static IntPtr GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress;

	private static int GetScaledCapsuleSize_WithoutHemisphere_ParamsSize;

	private static bool GetScaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid;

	private static FFieldAddress GetScaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress;

	private static int GetScaledCapsuleSize_WithoutHemisphere_OutRadius_Offset;

	private static bool GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid;

	private static FFieldAddress GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress;

	private static int GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset;

	private static bool GetScaledCapsuleSize_IsValid;

	private static IntPtr GetScaledCapsuleSize_FunctionAddress;

	private static int GetScaledCapsuleSize_ParamsSize;

	private static bool GetScaledCapsuleSize_OutRadius_IsValid;

	private static FFieldAddress GetScaledCapsuleSize_OutRadius_PropertyAddress;

	private static int GetScaledCapsuleSize_OutRadius_Offset;

	private static bool GetScaledCapsuleSize_OutHalfHeight_IsValid;

	private static FFieldAddress GetScaledCapsuleSize_OutHalfHeight_PropertyAddress;

	private static int GetScaledCapsuleSize_OutHalfHeight_Offset;

	private static bool GetScaledCapsuleRadius_IsValid;

	private static IntPtr GetScaledCapsuleRadius_FunctionAddress;

	private static int GetScaledCapsuleRadius_ParamsSize;

	private static bool GetScaledCapsuleRadius_ReturnValue_IsValid;

	private static FFieldAddress GetScaledCapsuleRadius_ReturnValue_PropertyAddress;

	private static int GetScaledCapsuleRadius_ReturnValue_Offset;

	private static bool GetScaledCapsuleHalfHeight_WithoutHemisphere_IsValid;

	private static IntPtr GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress;

	private static int GetScaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize;

	private static bool GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid;

	private static FFieldAddress GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress;

	private static int GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset;

	private static bool GetScaledCapsuleHalfHeight_IsValid;

	private static IntPtr GetScaledCapsuleHalfHeight_FunctionAddress;

	private static int GetScaledCapsuleHalfHeight_ParamsSize;

	private static bool GetScaledCapsuleHalfHeight_ReturnValue_IsValid;

	private static FFieldAddress GetScaledCapsuleHalfHeight_ReturnValue_PropertyAddress;

	private static int GetScaledCapsuleHalfHeight_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.CapsuleComponent:CapsuleHalfHeight")]
	protected float CapsuleHalfHeight
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CapsuleComponent:CapsuleHalfHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CapsuleComponent:CapsuleHalfHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.CapsuleComponent:CapsuleRadius")]
	protected float CapsuleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CapsuleComponent:CapsuleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CapsuleComponent:CapsuleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleRadius_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:SetCapsuleSize")]
	public unsafe void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetCapsuleSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:SetCapsuleSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCapsuleSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCapsuleSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCapsuleSize_InRadius_Offset), 0, SetCapsuleSize_InRadius_PropertyAddress.Address, InRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCapsuleSize_InHalfHeight_Offset), 0, SetCapsuleSize_InHalfHeight_PropertyAddress.Address, InHalfHeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCapsuleSize_bUpdateOverlaps_Offset), 0, SetCapsuleSize_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCapsuleSize_FunctionAddress, intPtr, SetCapsuleSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:SetCapsuleRadius")]
	public unsafe void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetCapsuleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:SetCapsuleRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCapsuleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCapsuleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCapsuleRadius_Radius_Offset), 0, SetCapsuleRadius_Radius_PropertyAddress.Address, Radius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCapsuleRadius_bUpdateOverlaps_Offset), 0, SetCapsuleRadius_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCapsuleRadius_FunctionAddress, intPtr, SetCapsuleRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:SetCapsuleHalfHeight")]
	public unsafe void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetCapsuleHalfHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:SetCapsuleHalfHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCapsuleHalfHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCapsuleHalfHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCapsuleHalfHeight_HalfHeight_Offset), 0, SetCapsuleHalfHeight_HalfHeight_PropertyAddress.Address, HalfHeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCapsuleHalfHeight_bUpdateOverlaps_Offset), 0, SetCapsuleHalfHeight_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCapsuleHalfHeight_FunctionAddress, intPtr, SetCapsuleHalfHeight_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize_WithoutHemisphere")]
	public unsafe void GetUnscaledCapsuleSize_WithoutHemisphere(out float OutRadius, out float OutHalfHeightWithoutHemisphere)
	{
		CheckDestroyed();
		if (!GetUnscaledCapsuleSize_WithoutHemisphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize_WithoutHemisphere");
			OutRadius = 0f;
			OutHalfHeightWithoutHemisphere = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCapsuleSize_WithoutHemisphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCapsuleSize_WithoutHemisphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, intPtr, GetUnscaledCapsuleSize_WithoutHemisphere_ParamsSize);
		OutRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_Offset), 0, GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress.Address);
		OutHalfHeightWithoutHemisphere = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset), 0, GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize")]
	public unsafe void GetUnscaledCapsuleSize(out float OutRadius, out float OutHalfHeight)
	{
		CheckDestroyed();
		if (!GetUnscaledCapsuleSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize");
			OutRadius = 0f;
			OutHalfHeight = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCapsuleSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCapsuleSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCapsuleSize_FunctionAddress, intPtr, GetUnscaledCapsuleSize_ParamsSize);
		OutRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleSize_OutRadius_Offset), 0, GetUnscaledCapsuleSize_OutRadius_PropertyAddress.Address);
		OutHalfHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleSize_OutHalfHeight_Offset), 0, GetUnscaledCapsuleSize_OutHalfHeight_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleRadius")]
	public unsafe float GetUnscaledCapsuleRadius()
	{
		CheckDestroyed();
		if (!GetUnscaledCapsuleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCapsuleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCapsuleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCapsuleRadius_FunctionAddress, intPtr, GetUnscaledCapsuleRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleRadius_ReturnValue_Offset), 0, GetUnscaledCapsuleRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight_WithoutHemisphere")]
	public unsafe float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
	{
		CheckDestroyed();
		if (!GetUnscaledCapsuleHalfHeight_WithoutHemisphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight_WithoutHemisphere");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, intPtr, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset), 0, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight")]
	public unsafe float GetUnscaledCapsuleHalfHeight()
	{
		CheckDestroyed();
		if (!GetUnscaledCapsuleHalfHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledCapsuleHalfHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledCapsuleHalfHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledCapsuleHalfHeight_FunctionAddress, intPtr, GetUnscaledCapsuleHalfHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledCapsuleHalfHeight_ReturnValue_Offset), 0, GetUnscaledCapsuleHalfHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetShapeScale")]
	public unsafe float GetShapeScale()
	{
		CheckDestroyed();
		if (!GetShapeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetShapeScale");
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

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize_WithoutHemisphere")]
	public unsafe void GetScaledCapsuleSize_WithoutHemisphere(out float OutRadius, out float OutHalfHeightWithoutHemisphere)
	{
		CheckDestroyed();
		if (!GetScaledCapsuleSize_WithoutHemisphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize_WithoutHemisphere");
			OutRadius = 0f;
			OutHalfHeightWithoutHemisphere = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCapsuleSize_WithoutHemisphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCapsuleSize_WithoutHemisphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, intPtr, GetScaledCapsuleSize_WithoutHemisphere_ParamsSize);
		OutRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleSize_WithoutHemisphere_OutRadius_Offset), 0, GetScaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress.Address);
		OutHalfHeightWithoutHemisphere = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset), 0, GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize")]
	public unsafe void GetScaledCapsuleSize(out float OutRadius, out float OutHalfHeight)
	{
		CheckDestroyed();
		if (!GetScaledCapsuleSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize");
			OutRadius = 0f;
			OutHalfHeight = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCapsuleSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCapsuleSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCapsuleSize_FunctionAddress, intPtr, GetScaledCapsuleSize_ParamsSize);
		OutRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleSize_OutRadius_Offset), 0, GetScaledCapsuleSize_OutRadius_PropertyAddress.Address);
		OutHalfHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleSize_OutHalfHeight_Offset), 0, GetScaledCapsuleSize_OutHalfHeight_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetScaledCapsuleRadius")]
	public unsafe float GetScaledCapsuleRadius()
	{
		CheckDestroyed();
		if (!GetScaledCapsuleRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetScaledCapsuleRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCapsuleRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCapsuleRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCapsuleRadius_FunctionAddress, intPtr, GetScaledCapsuleRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleRadius_ReturnValue_Offset), 0, GetScaledCapsuleRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight_WithoutHemisphere")]
	public unsafe float GetScaledCapsuleHalfHeight_WithoutHemisphere()
	{
		CheckDestroyed();
		if (!GetScaledCapsuleHalfHeight_WithoutHemisphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight_WithoutHemisphere");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, intPtr, GetScaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset), 0, GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight")]
	public unsafe float GetScaledCapsuleHalfHeight()
	{
		CheckDestroyed();
		if (!GetScaledCapsuleHalfHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledCapsuleHalfHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledCapsuleHalfHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledCapsuleHalfHeight_FunctionAddress, intPtr, GetScaledCapsuleHalfHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledCapsuleHalfHeight_ReturnValue_Offset), 0, GetScaledCapsuleHalfHeight_ReturnValue_PropertyAddress.Address);
	}

	static UCapsuleComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCapsuleComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCapsuleComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CapsuleComponent");
		CapsuleHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleHalfHeight");
		CapsuleHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleHalfHeight", Classes.FFloatProperty);
		CapsuleRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleRadius");
		CapsuleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleRadius", Classes.FFloatProperty);
		SetCapsuleSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCapsuleSize");
		SetCapsuleSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCapsuleSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleSize_InRadius_PropertyAddress, SetCapsuleSize_FunctionAddress, "InRadius");
		SetCapsuleSize_InRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleSize_FunctionAddress, "InRadius");
		SetCapsuleSize_InRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleSize_FunctionAddress, "InRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleSize_InHalfHeight_PropertyAddress, SetCapsuleSize_FunctionAddress, "InHalfHeight");
		SetCapsuleSize_InHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleSize_FunctionAddress, "InHalfHeight");
		SetCapsuleSize_InHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleSize_FunctionAddress, "InHalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleSize_bUpdateOverlaps_PropertyAddress, SetCapsuleSize_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleSize_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleSize_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleSize_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleSize_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetCapsuleSize_IsValid = SetCapsuleSize_FunctionAddress != IntPtr.Zero && SetCapsuleSize_InRadius_IsValid && SetCapsuleSize_InHalfHeight_IsValid && SetCapsuleSize_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:SetCapsuleSize", SetCapsuleSize_IsValid);
		SetCapsuleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCapsuleRadius");
		SetCapsuleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCapsuleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleRadius_Radius_PropertyAddress, SetCapsuleRadius_FunctionAddress, "Radius");
		SetCapsuleRadius_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleRadius_FunctionAddress, "Radius");
		SetCapsuleRadius_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleRadius_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleRadius_bUpdateOverlaps_PropertyAddress, SetCapsuleRadius_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleRadius_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleRadius_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleRadius_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleRadius_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetCapsuleRadius_IsValid = SetCapsuleRadius_FunctionAddress != IntPtr.Zero && SetCapsuleRadius_Radius_IsValid && SetCapsuleRadius_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:SetCapsuleRadius", SetCapsuleRadius_IsValid);
		SetCapsuleHalfHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCapsuleHalfHeight");
		SetCapsuleHalfHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCapsuleHalfHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleHalfHeight_HalfHeight_PropertyAddress, SetCapsuleHalfHeight_FunctionAddress, "HalfHeight");
		SetCapsuleHalfHeight_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleHalfHeight_FunctionAddress, "HalfHeight");
		SetCapsuleHalfHeight_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleHalfHeight_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleHalfHeight_bUpdateOverlaps_PropertyAddress, SetCapsuleHalfHeight_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleHalfHeight_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleHalfHeight_FunctionAddress, "bUpdateOverlaps");
		SetCapsuleHalfHeight_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleHalfHeight_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetCapsuleHalfHeight_IsValid = SetCapsuleHalfHeight_FunctionAddress != IntPtr.Zero && SetCapsuleHalfHeight_HalfHeight_IsValid && SetCapsuleHalfHeight_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:SetCapsuleHalfHeight", SetCapsuleHalfHeight_IsValid);
		GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCapsuleSize_WithoutHemisphere");
		GetUnscaledCapsuleSize_WithoutHemisphere_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress, GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius");
		GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius");
		GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress, GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere");
		GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere");
		GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere", Classes.FFloatProperty);
		GetUnscaledCapsuleSize_WithoutHemisphere_IsValid = GetUnscaledCapsuleSize_WithoutHemisphere_FunctionAddress != IntPtr.Zero && GetUnscaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid && GetUnscaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize_WithoutHemisphere", GetUnscaledCapsuleSize_WithoutHemisphere_IsValid);
		GetUnscaledCapsuleSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCapsuleSize");
		GetUnscaledCapsuleSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCapsuleSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleSize_OutRadius_PropertyAddress, GetUnscaledCapsuleSize_FunctionAddress, "OutRadius");
		GetUnscaledCapsuleSize_OutRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleSize_FunctionAddress, "OutRadius");
		GetUnscaledCapsuleSize_OutRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleSize_FunctionAddress, "OutRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleSize_OutHalfHeight_PropertyAddress, GetUnscaledCapsuleSize_FunctionAddress, "OutHalfHeight");
		GetUnscaledCapsuleSize_OutHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleSize_FunctionAddress, "OutHalfHeight");
		GetUnscaledCapsuleSize_OutHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleSize_FunctionAddress, "OutHalfHeight", Classes.FFloatProperty);
		GetUnscaledCapsuleSize_IsValid = GetUnscaledCapsuleSize_FunctionAddress != IntPtr.Zero && GetUnscaledCapsuleSize_OutRadius_IsValid && GetUnscaledCapsuleSize_OutHalfHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleSize", GetUnscaledCapsuleSize_IsValid);
		GetUnscaledCapsuleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCapsuleRadius");
		GetUnscaledCapsuleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCapsuleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleRadius_ReturnValue_PropertyAddress, GetUnscaledCapsuleRadius_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleRadius_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledCapsuleRadius_IsValid = GetUnscaledCapsuleRadius_FunctionAddress != IntPtr.Zero && GetUnscaledCapsuleRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleRadius", GetUnscaledCapsuleRadius_IsValid);
		GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCapsuleHalfHeight_WithoutHemisphere");
		GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress, GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledCapsuleHalfHeight_WithoutHemisphere_IsValid = GetUnscaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress != IntPtr.Zero && GetUnscaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight_WithoutHemisphere", GetUnscaledCapsuleHalfHeight_WithoutHemisphere_IsValid);
		GetUnscaledCapsuleHalfHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledCapsuleHalfHeight");
		GetUnscaledCapsuleHalfHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledCapsuleHalfHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledCapsuleHalfHeight_ReturnValue_PropertyAddress, GetUnscaledCapsuleHalfHeight_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleHalfHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledCapsuleHalfHeight_FunctionAddress, "ReturnValue");
		GetUnscaledCapsuleHalfHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledCapsuleHalfHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledCapsuleHalfHeight_IsValid = GetUnscaledCapsuleHalfHeight_FunctionAddress != IntPtr.Zero && GetUnscaledCapsuleHalfHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetUnscaledCapsuleHalfHeight", GetUnscaledCapsuleHalfHeight_IsValid);
		GetShapeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShapeScale");
		GetShapeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeScale_ReturnValue_PropertyAddress, GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetShapeScale_IsValid = GetShapeScale_FunctionAddress != IntPtr.Zero && GetShapeScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetShapeScale", GetShapeScale_IsValid);
		GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCapsuleSize_WithoutHemisphere");
		GetScaledCapsuleSize_WithoutHemisphere_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleSize_WithoutHemisphere_OutRadius_PropertyAddress, GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius");
		GetScaledCapsuleSize_WithoutHemisphere_OutRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius");
		GetScaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_PropertyAddress, GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere");
		GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere");
		GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress, "OutHalfHeightWithoutHemisphere", Classes.FFloatProperty);
		GetScaledCapsuleSize_WithoutHemisphere_IsValid = GetScaledCapsuleSize_WithoutHemisphere_FunctionAddress != IntPtr.Zero && GetScaledCapsuleSize_WithoutHemisphere_OutRadius_IsValid && GetScaledCapsuleSize_WithoutHemisphere_OutHalfHeightWithoutHemisphere_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize_WithoutHemisphere", GetScaledCapsuleSize_WithoutHemisphere_IsValid);
		GetScaledCapsuleSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCapsuleSize");
		GetScaledCapsuleSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCapsuleSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleSize_OutRadius_PropertyAddress, GetScaledCapsuleSize_FunctionAddress, "OutRadius");
		GetScaledCapsuleSize_OutRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleSize_FunctionAddress, "OutRadius");
		GetScaledCapsuleSize_OutRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleSize_FunctionAddress, "OutRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleSize_OutHalfHeight_PropertyAddress, GetScaledCapsuleSize_FunctionAddress, "OutHalfHeight");
		GetScaledCapsuleSize_OutHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleSize_FunctionAddress, "OutHalfHeight");
		GetScaledCapsuleSize_OutHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleSize_FunctionAddress, "OutHalfHeight", Classes.FFloatProperty);
		GetScaledCapsuleSize_IsValid = GetScaledCapsuleSize_FunctionAddress != IntPtr.Zero && GetScaledCapsuleSize_OutRadius_IsValid && GetScaledCapsuleSize_OutHalfHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetScaledCapsuleSize", GetScaledCapsuleSize_IsValid);
		GetScaledCapsuleRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCapsuleRadius");
		GetScaledCapsuleRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCapsuleRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleRadius_ReturnValue_PropertyAddress, GetScaledCapsuleRadius_FunctionAddress, "ReturnValue");
		GetScaledCapsuleRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleRadius_FunctionAddress, "ReturnValue");
		GetScaledCapsuleRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledCapsuleRadius_IsValid = GetScaledCapsuleRadius_FunctionAddress != IntPtr.Zero && GetScaledCapsuleRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetScaledCapsuleRadius", GetScaledCapsuleRadius_IsValid);
		GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCapsuleHalfHeight_WithoutHemisphere");
		GetScaledCapsuleHalfHeight_WithoutHemisphere_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_PropertyAddress, GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue");
		GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue");
		GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledCapsuleHalfHeight_WithoutHemisphere_IsValid = GetScaledCapsuleHalfHeight_WithoutHemisphere_FunctionAddress != IntPtr.Zero && GetScaledCapsuleHalfHeight_WithoutHemisphere_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight_WithoutHemisphere", GetScaledCapsuleHalfHeight_WithoutHemisphere_IsValid);
		GetScaledCapsuleHalfHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledCapsuleHalfHeight");
		GetScaledCapsuleHalfHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledCapsuleHalfHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledCapsuleHalfHeight_ReturnValue_PropertyAddress, GetScaledCapsuleHalfHeight_FunctionAddress, "ReturnValue");
		GetScaledCapsuleHalfHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledCapsuleHalfHeight_FunctionAddress, "ReturnValue");
		GetScaledCapsuleHalfHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledCapsuleHalfHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledCapsuleHalfHeight_IsValid = GetScaledCapsuleHalfHeight_FunctionAddress != IntPtr.Zero && GetScaledCapsuleHalfHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CapsuleComponent:GetScaledCapsuleHalfHeight", GetScaledCapsuleHalfHeight_IsValid);
	}
}
