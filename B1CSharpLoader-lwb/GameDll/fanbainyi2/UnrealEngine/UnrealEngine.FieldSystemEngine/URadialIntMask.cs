using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.RadialIntMask", "FieldSystemEngine", UnrealModuleType.Engine)]
public class URadialIntMask : UFieldNodeInt
{
	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool InteriorValue_IsValid;

	private static int InteriorValue_Offset;

	private static bool ExteriorValue_IsValid;

	private static int ExteriorValue_Offset;

	private static bool SetMaskCondition_IsValid;

	private static FFieldAddress SetMaskCondition_PropertyAddress;

	private static int SetMaskCondition_Offset;

	private static bool SetRadialIntMask_IsValid;

	private static IntPtr SetRadialIntMask_FunctionAddress;

	private static int SetRadialIntMask_ParamsSize;

	private static bool SetRadialIntMask_Radius_IsValid;

	private static FFieldAddress SetRadialIntMask_Radius_PropertyAddress;

	private static int SetRadialIntMask_Radius_Offset;

	private static bool SetRadialIntMask_Position_IsValid;

	private static FFieldAddress SetRadialIntMask_Position_PropertyAddress;

	private static int SetRadialIntMask_Position_Offset;

	private static bool SetRadialIntMask_InteriorValue_IsValid;

	private static FFieldAddress SetRadialIntMask_InteriorValue_PropertyAddress;

	private static int SetRadialIntMask_InteriorValue_Offset;

	private static bool SetRadialIntMask_ExteriorValue_IsValid;

	private static FFieldAddress SetRadialIntMask_ExteriorValue_PropertyAddress;

	private static int SetRadialIntMask_ExteriorValue_Offset;

	private static bool SetRadialIntMask_SetMaskConditionIn_IsValid;

	private static FFieldAddress SetRadialIntMask_SetMaskConditionIn_PropertyAddress;

	private static int SetRadialIntMask_SetMaskConditionIn_Offset;

	private static bool SetRadialIntMask_ReturnValue_IsValid;

	private static FFieldAddress SetRadialIntMask_ReturnValue_PropertyAddress;

	private static int SetRadialIntMask_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:Position")]
	public FVector Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:Position");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:Position");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:InteriorValue")]
	public int InteriorValue
	{
		get
		{
			CheckDestroyed();
			if (!InteriorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:InteriorValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteriorValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteriorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:InteriorValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteriorValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:ExteriorValue")]
	public int ExteriorValue
	{
		get
		{
			CheckDestroyed();
			if (!ExteriorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:ExteriorValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ExteriorValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExteriorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:ExteriorValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ExteriorValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:SetMaskCondition")]
	public ESetMaskConditionType SetMaskCondition
	{
		get
		{
			CheckDestroyed();
			if (!SetMaskCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:SetMaskCondition");
				return ESetMaskConditionType.Field_Set_Always;
			}
			return EnumMarshaler<ESetMaskConditionType>.FromNative(IntPtr.Add(base.Address, SetMaskCondition_Offset), 0, SetMaskCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetMaskCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialIntMask:SetMaskCondition");
			}
			else
			{
				EnumMarshaler<ESetMaskConditionType>.ToNative(IntPtr.Add(base.Address, SetMaskCondition_Offset), 0, SetMaskCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.RadialIntMask:SetRadialIntMask")]
	public unsafe URadialIntMask SetRadialIntMask(float Radius, FVector Position, int InteriorValue, int ExteriorValue, ESetMaskConditionType SetMaskConditionIn)
	{
		CheckDestroyed();
		if (!SetRadialIntMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.RadialIntMask:SetRadialIntMask");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadialIntMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadialIntMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialIntMask_Radius_Offset), 0, SetRadialIntMask_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRadialIntMask_Position_Offset), 0, SetRadialIntMask_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRadialIntMask_InteriorValue_Offset), 0, SetRadialIntMask_InteriorValue_PropertyAddress.Address, InteriorValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRadialIntMask_ExteriorValue_Offset), 0, SetRadialIntMask_ExteriorValue_PropertyAddress.Address, ExteriorValue);
		EnumMarshaler<ESetMaskConditionType>.ToNative(IntPtr.Add(intPtr, SetRadialIntMask_SetMaskConditionIn_Offset), 0, SetRadialIntMask_SetMaskConditionIn_PropertyAddress.Address, SetMaskConditionIn);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadialIntMask_FunctionAddress, intPtr, SetRadialIntMask_ParamsSize);
		return UObjectMarshaler<URadialIntMask>.FromNative(IntPtr.Add(intPtr, SetRadialIntMask_ReturnValue_Offset), 0, SetRadialIntMask_ReturnValue_PropertyAddress.Address);
	}

	static URadialIntMask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URadialIntMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URadialIntMask));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.RadialIntMask");
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		InteriorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorValue");
		InteriorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorValue", Classes.FIntProperty);
		ExteriorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExteriorValue");
		ExteriorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExteriorValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaskCondition_PropertyAddress, intPtr, "SetMaskCondition");
		SetMaskCondition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SetMaskCondition");
		SetMaskCondition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SetMaskCondition", Classes.FByteProperty);
		SetRadialIntMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadialIntMask");
		SetRadialIntMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadialIntMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_Radius_PropertyAddress, SetRadialIntMask_FunctionAddress, "Radius");
		SetRadialIntMask_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "Radius");
		SetRadialIntMask_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_Position_PropertyAddress, SetRadialIntMask_FunctionAddress, "Position");
		SetRadialIntMask_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "Position");
		SetRadialIntMask_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_InteriorValue_PropertyAddress, SetRadialIntMask_FunctionAddress, "InteriorValue");
		SetRadialIntMask_InteriorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "InteriorValue");
		SetRadialIntMask_InteriorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "InteriorValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_ExteriorValue_PropertyAddress, SetRadialIntMask_FunctionAddress, "ExteriorValue");
		SetRadialIntMask_ExteriorValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "ExteriorValue");
		SetRadialIntMask_ExteriorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "ExteriorValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_SetMaskConditionIn_PropertyAddress, SetRadialIntMask_FunctionAddress, "SetMaskConditionIn");
		SetRadialIntMask_SetMaskConditionIn_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "SetMaskConditionIn");
		SetRadialIntMask_SetMaskConditionIn_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "SetMaskConditionIn", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialIntMask_ReturnValue_PropertyAddress, SetRadialIntMask_FunctionAddress, "ReturnValue");
		SetRadialIntMask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialIntMask_FunctionAddress, "ReturnValue");
		SetRadialIntMask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialIntMask_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetRadialIntMask_IsValid = SetRadialIntMask_FunctionAddress != IntPtr.Zero && SetRadialIntMask_Radius_IsValid && SetRadialIntMask_Position_IsValid && SetRadialIntMask_InteriorValue_IsValid && SetRadialIntMask_ExteriorValue_IsValid && SetRadialIntMask_SetMaskConditionIn_IsValid && SetRadialIntMask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.RadialIntMask:SetRadialIntMask", SetRadialIntMask_IsValid);
	}
}
