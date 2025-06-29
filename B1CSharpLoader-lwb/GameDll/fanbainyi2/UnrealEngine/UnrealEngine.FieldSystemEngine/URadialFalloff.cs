using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.RadialFalloff", "FieldSystemEngine", UnrealModuleType.Engine)]
public class URadialFalloff : UFieldNodeFloat
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool MinRange_IsValid;

	private static int MinRange_Offset;

	private static bool MaxRange_IsValid;

	private static int MaxRange_Offset;

	private static bool Default_IsValid;

	private static int Default_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool Falloff_IsValid;

	private static FFieldAddress Falloff_PropertyAddress;

	private static int Falloff_Offset;

	private static bool SetRadialFalloff_IsValid;

	private static IntPtr SetRadialFalloff_FunctionAddress;

	private static int SetRadialFalloff_ParamsSize;

	private static bool SetRadialFalloff_Magnitude_IsValid;

	private static FFieldAddress SetRadialFalloff_Magnitude_PropertyAddress;

	private static int SetRadialFalloff_Magnitude_Offset;

	private static bool SetRadialFalloff_MinRange_IsValid;

	private static FFieldAddress SetRadialFalloff_MinRange_PropertyAddress;

	private static int SetRadialFalloff_MinRange_Offset;

	private static bool SetRadialFalloff_MaxRange_IsValid;

	private static FFieldAddress SetRadialFalloff_MaxRange_PropertyAddress;

	private static int SetRadialFalloff_MaxRange_Offset;

	private static bool SetRadialFalloff_Default_IsValid;

	private static FFieldAddress SetRadialFalloff_Default_PropertyAddress;

	private static int SetRadialFalloff_Default_Offset;

	private static bool SetRadialFalloff_Radius_IsValid;

	private static FFieldAddress SetRadialFalloff_Radius_PropertyAddress;

	private static int SetRadialFalloff_Radius_Offset;

	private static bool SetRadialFalloff_Position_IsValid;

	private static FFieldAddress SetRadialFalloff_Position_PropertyAddress;

	private static int SetRadialFalloff_Position_Offset;

	private static bool SetRadialFalloff_Falloff_IsValid;

	private static FFieldAddress SetRadialFalloff_Falloff_PropertyAddress;

	private static int SetRadialFalloff_Falloff_Offset;

	private static bool SetRadialFalloff_ReturnValue_IsValid;

	private static FFieldAddress SetRadialFalloff_ReturnValue_PropertyAddress;

	private static int SetRadialFalloff_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:MinRange")]
	public float MinRange
	{
		get
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:MinRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:MinRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:MaxRange")]
	public float MaxRange
	{
		get
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:MaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:MaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:Default")]
	public float Default
	{
		get
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Default");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Default_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Default");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Default_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:Position")]
	public FVector Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Position");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Position");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:Falloff")]
	public EFieldFalloffType Falloff
	{
		get
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Falloff");
				return EFieldFalloffType.Field_FallOff_None;
			}
			return EnumMarshaler<EFieldFalloffType>.FromNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.RadialFalloff:Falloff");
			}
			else
			{
				EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.RadialFalloff:SetRadialFalloff")]
	public unsafe URadialFalloff SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, FVector Position, EFieldFalloffType Falloff)
	{
		CheckDestroyed();
		if (!SetRadialFalloff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.RadialFalloff:SetRadialFalloff");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadialFalloff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadialFalloff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_Magnitude_Offset), 0, SetRadialFalloff_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_MinRange_Offset), 0, SetRadialFalloff_MinRange_PropertyAddress.Address, MinRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_MaxRange_Offset), 0, SetRadialFalloff_MaxRange_PropertyAddress.Address, MaxRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_Default_Offset), 0, SetRadialFalloff_Default_PropertyAddress.Address, Default);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_Radius_Offset), 0, SetRadialFalloff_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_Position_Offset), 0, SetRadialFalloff_Position_PropertyAddress.Address, Position);
		EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(intPtr, SetRadialFalloff_Falloff_Offset), 0, SetRadialFalloff_Falloff_PropertyAddress.Address, Falloff);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadialFalloff_FunctionAddress, intPtr, SetRadialFalloff_ParamsSize);
		return UObjectMarshaler<URadialFalloff>.FromNative(IntPtr.Add(intPtr, SetRadialFalloff_ReturnValue_Offset), 0, SetRadialFalloff_ReturnValue_PropertyAddress.Address);
	}

	static URadialFalloff()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URadialFalloff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URadialFalloff));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.RadialFalloff");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		MinRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRange");
		MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRange", Classes.FFloatProperty);
		MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRange");
		MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRange", Classes.FFloatProperty);
		Default_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Default");
		Default_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Default", Classes.FFloatProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Falloff_PropertyAddress, intPtr, "Falloff");
		Falloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Falloff");
		Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Falloff", Classes.FByteProperty);
		SetRadialFalloff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadialFalloff");
		SetRadialFalloff_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadialFalloff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_Magnitude_PropertyAddress, SetRadialFalloff_FunctionAddress, "Magnitude");
		SetRadialFalloff_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "Magnitude");
		SetRadialFalloff_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_MinRange_PropertyAddress, SetRadialFalloff_FunctionAddress, "MinRange");
		SetRadialFalloff_MinRange_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "MinRange");
		SetRadialFalloff_MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "MinRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_MaxRange_PropertyAddress, SetRadialFalloff_FunctionAddress, "MaxRange");
		SetRadialFalloff_MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "MaxRange");
		SetRadialFalloff_MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "MaxRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_Default_PropertyAddress, SetRadialFalloff_FunctionAddress, "Default");
		SetRadialFalloff_Default_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "Default");
		SetRadialFalloff_Default_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "Default", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_Radius_PropertyAddress, SetRadialFalloff_FunctionAddress, "Radius");
		SetRadialFalloff_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "Radius");
		SetRadialFalloff_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_Position_PropertyAddress, SetRadialFalloff_FunctionAddress, "Position");
		SetRadialFalloff_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "Position");
		SetRadialFalloff_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_Falloff_PropertyAddress, SetRadialFalloff_FunctionAddress, "Falloff");
		SetRadialFalloff_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "Falloff");
		SetRadialFalloff_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRadialFalloff_ReturnValue_PropertyAddress, SetRadialFalloff_FunctionAddress, "ReturnValue");
		SetRadialFalloff_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialFalloff_FunctionAddress, "ReturnValue");
		SetRadialFalloff_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialFalloff_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetRadialFalloff_IsValid = SetRadialFalloff_FunctionAddress != IntPtr.Zero && SetRadialFalloff_Magnitude_IsValid && SetRadialFalloff_MinRange_IsValid && SetRadialFalloff_MaxRange_IsValid && SetRadialFalloff_Default_IsValid && SetRadialFalloff_Radius_IsValid && SetRadialFalloff_Position_IsValid && SetRadialFalloff_Falloff_IsValid && SetRadialFalloff_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.RadialFalloff:SetRadialFalloff", SetRadialFalloff_IsValid);
	}
}
