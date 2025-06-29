using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819990692uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUDebugSectorComponent", "b1", UnrealModuleType.Game)]
public class UBGUDebugSectorComponent : UShapeComponent
{
	private static bool SectorRadius_IsValid;

	private static int SectorRadius_Offset;

	private static bool SectorMinAngle_IsValid;

	private static int SectorMinAngle_Offset;

	private static bool SectorMaxAngle_IsValid;

	private static int SectorMaxAngle_Offset;

	private static bool SectorThickness_IsValid;

	private static int SectorThickness_Offset;

	private static bool SetSectorRadius_IsValid;

	private static IntPtr SetSectorRadius_FunctionAddress;

	private static int SetSectorRadius_ParamsSize;

	private static bool SetSectorRadius_InSectorRadius_IsValid;

	private static FFieldAddress SetSectorRadius_InSectorRadius_PropertyAddress;

	private static int SetSectorRadius_InSectorRadius_Offset;

	private static bool SetSectorMinAngle_IsValid;

	private static IntPtr SetSectorMinAngle_FunctionAddress;

	private static int SetSectorMinAngle_ParamsSize;

	private static bool SetSectorMinAngle_InMinAngle_IsValid;

	private static FFieldAddress SetSectorMinAngle_InMinAngle_PropertyAddress;

	private static int SetSectorMinAngle_InMinAngle_Offset;

	private static bool SetSectorMaxAngle_IsValid;

	private static IntPtr SetSectorMaxAngle_FunctionAddress;

	private static int SetSectorMaxAngle_ParamsSize;

	private static bool SetSectorMaxAngle_InMaxAngle_IsValid;

	private static FFieldAddress SetSectorMaxAngle_InMaxAngle_PropertyAddress;

	private static int SetSectorMaxAngle_InMaxAngle_Offset;

	private static bool GetUnscaledSectorRadius_IsValid;

	private static IntPtr GetUnscaledSectorRadius_FunctionAddress;

	private static int GetUnscaledSectorRadius_ParamsSize;

	private static bool GetUnscaledSectorRadius_ReturnValue_IsValid;

	private static FFieldAddress GetUnscaledSectorRadius_ReturnValue_PropertyAddress;

	private static int GetUnscaledSectorRadius_ReturnValue_Offset;

	private static bool GetShapeScale_IsValid;

	private static IntPtr GetShapeScale_FunctionAddress;

	private static int GetShapeScale_ParamsSize;

	private static bool GetShapeScale_ReturnValue_IsValid;

	private static FFieldAddress GetShapeScale_ReturnValue_PropertyAddress;

	private static int GetShapeScale_ReturnValue_Offset;

	private static bool GetScaledSectorRadius_IsValid;

	private static IntPtr GetScaledSectorRadius_FunctionAddress;

	private static int GetScaledSectorRadius_ParamsSize;

	private static bool GetScaledSectorRadius_ReturnValue_IsValid;

	private static FFieldAddress GetScaledSectorRadius_ReturnValue_PropertyAddress;

	private static int GetScaledSectorRadius_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SectorRadius")]
	protected float SectorRadius
	{
		get
		{
			CheckDestroyed();
			if (!SectorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectorRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectorRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectorRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SectorMinAngle")]
	protected float SectorMinAngle
	{
		get
		{
			CheckDestroyed();
			if (!SectorMinAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorMinAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectorMinAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectorMinAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorMinAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectorMinAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SectorMaxAngle")]
	protected float SectorMaxAngle
	{
		get
		{
			CheckDestroyed();
			if (!SectorMaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorMaxAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectorMaxAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectorMaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorMaxAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectorMaxAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SectorThickness")]
	protected float SectorThickness
	{
		get
		{
			CheckDestroyed();
			if (!SectorThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectorThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectorThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDebugSectorComponent:SectorThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectorThickness_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SetSectorRadius")]
	public unsafe void SetSectorRadius(float InSectorRadius)
	{
		CheckDestroyed();
		if (!SetSectorRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:SetSectorRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSectorRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSectorRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSectorRadius_InSectorRadius_Offset), 0, SetSectorRadius_InSectorRadius_PropertyAddress.Address, InSectorRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSectorRadius_FunctionAddress, intPtr, SetSectorRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SetSectorMinAngle")]
	public unsafe void SetSectorMinAngle(float InMinAngle)
	{
		CheckDestroyed();
		if (!SetSectorMinAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:SetSectorMinAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSectorMinAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSectorMinAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSectorMinAngle_InMinAngle_Offset), 0, SetSectorMinAngle_InMinAngle_PropertyAddress.Address, InMinAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSectorMinAngle_FunctionAddress, intPtr, SetSectorMinAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:SetSectorMaxAngle")]
	public unsafe void SetSectorMaxAngle(float InMaxAngle)
	{
		CheckDestroyed();
		if (!SetSectorMaxAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:SetSectorMaxAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSectorMaxAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSectorMaxAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSectorMaxAngle_InMaxAngle_Offset), 0, SetSectorMaxAngle_InMaxAngle_PropertyAddress.Address, InMaxAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSectorMaxAngle_FunctionAddress, intPtr, SetSectorMaxAngle_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:GetUnscaledSectorRadius")]
	public unsafe float GetUnscaledSectorRadius()
	{
		CheckDestroyed();
		if (!GetUnscaledSectorRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:GetUnscaledSectorRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnscaledSectorRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnscaledSectorRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnscaledSectorRadius_FunctionAddress, intPtr, GetUnscaledSectorRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnscaledSectorRadius_ReturnValue_Offset), 0, GetUnscaledSectorRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:GetShapeScale")]
	public unsafe float GetShapeScale()
	{
		CheckDestroyed();
		if (!GetShapeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:GetShapeScale");
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
	[UMetaPath("/Script/b1.BGUDebugSectorComponent:GetScaledSectorRadius")]
	public unsafe float GetScaledSectorRadius()
	{
		CheckDestroyed();
		if (!GetScaledSectorRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDebugSectorComponent:GetScaledSectorRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledSectorRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledSectorRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledSectorRadius_FunctionAddress, intPtr, GetScaledSectorRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledSectorRadius_ReturnValue_Offset), 0, GetScaledSectorRadius_ReturnValue_PropertyAddress.Address);
	}

	static UBGUDebugSectorComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUDebugSectorComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUDebugSectorComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUDebugSectorComponent");
		SectorRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectorRadius");
		SectorRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectorRadius", Classes.FFloatProperty);
		SectorMinAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectorMinAngle");
		SectorMinAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectorMinAngle", Classes.FFloatProperty);
		SectorMaxAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectorMaxAngle");
		SectorMaxAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectorMaxAngle", Classes.FFloatProperty);
		SectorThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectorThickness");
		SectorThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectorThickness", Classes.FFloatProperty);
		SetSectorRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSectorRadius");
		SetSectorRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSectorRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSectorRadius_InSectorRadius_PropertyAddress, SetSectorRadius_FunctionAddress, "InSectorRadius");
		SetSectorRadius_InSectorRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetSectorRadius_FunctionAddress, "InSectorRadius");
		SetSectorRadius_InSectorRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSectorRadius_FunctionAddress, "InSectorRadius", Classes.FFloatProperty);
		SetSectorRadius_IsValid = SetSectorRadius_FunctionAddress != IntPtr.Zero && SetSectorRadius_InSectorRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:SetSectorRadius", SetSectorRadius_IsValid);
		SetSectorMinAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSectorMinAngle");
		SetSectorMinAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSectorMinAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSectorMinAngle_InMinAngle_PropertyAddress, SetSectorMinAngle_FunctionAddress, "InMinAngle");
		SetSectorMinAngle_InMinAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetSectorMinAngle_FunctionAddress, "InMinAngle");
		SetSectorMinAngle_InMinAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSectorMinAngle_FunctionAddress, "InMinAngle", Classes.FFloatProperty);
		SetSectorMinAngle_IsValid = SetSectorMinAngle_FunctionAddress != IntPtr.Zero && SetSectorMinAngle_InMinAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:SetSectorMinAngle", SetSectorMinAngle_IsValid);
		SetSectorMaxAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSectorMaxAngle");
		SetSectorMaxAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSectorMaxAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSectorMaxAngle_InMaxAngle_PropertyAddress, SetSectorMaxAngle_FunctionAddress, "InMaxAngle");
		SetSectorMaxAngle_InMaxAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetSectorMaxAngle_FunctionAddress, "InMaxAngle");
		SetSectorMaxAngle_InMaxAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSectorMaxAngle_FunctionAddress, "InMaxAngle", Classes.FFloatProperty);
		SetSectorMaxAngle_IsValid = SetSectorMaxAngle_FunctionAddress != IntPtr.Zero && SetSectorMaxAngle_InMaxAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:SetSectorMaxAngle", SetSectorMaxAngle_IsValid);
		GetUnscaledSectorRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnscaledSectorRadius");
		GetUnscaledSectorRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnscaledSectorRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnscaledSectorRadius_ReturnValue_PropertyAddress, GetUnscaledSectorRadius_FunctionAddress, "ReturnValue");
		GetUnscaledSectorRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnscaledSectorRadius_FunctionAddress, "ReturnValue");
		GetUnscaledSectorRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnscaledSectorRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnscaledSectorRadius_IsValid = GetUnscaledSectorRadius_FunctionAddress != IntPtr.Zero && GetUnscaledSectorRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:GetUnscaledSectorRadius", GetUnscaledSectorRadius_IsValid);
		GetShapeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShapeScale");
		GetShapeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShapeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShapeScale_ReturnValue_PropertyAddress, GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShapeScale_FunctionAddress, "ReturnValue");
		GetShapeScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShapeScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetShapeScale_IsValid = GetShapeScale_FunctionAddress != IntPtr.Zero && GetShapeScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:GetShapeScale", GetShapeScale_IsValid);
		GetScaledSectorRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaledSectorRadius");
		GetScaledSectorRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledSectorRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledSectorRadius_ReturnValue_PropertyAddress, GetScaledSectorRadius_FunctionAddress, "ReturnValue");
		GetScaledSectorRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledSectorRadius_FunctionAddress, "ReturnValue");
		GetScaledSectorRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledSectorRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledSectorRadius_IsValid = GetScaledSectorRadius_FunctionAddress != IntPtr.Zero && GetScaledSectorRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDebugSectorComponent:GetScaledSectorRadius", GetScaledSectorRadius_IsValid);
	}
}
