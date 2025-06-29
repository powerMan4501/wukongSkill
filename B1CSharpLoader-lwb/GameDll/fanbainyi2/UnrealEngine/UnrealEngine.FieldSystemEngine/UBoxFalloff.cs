using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.BoxFalloff", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UBoxFalloff : UFieldNodeFloat
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool MinRange_IsValid;

	private static int MinRange_Offset;

	private static bool MaxRange_IsValid;

	private static int MaxRange_Offset;

	private static bool Default_IsValid;

	private static int Default_Offset;

	private static bool Transform_IsValid;

	private static int Transform_Offset;

	private static bool Falloff_IsValid;

	private static FFieldAddress Falloff_PropertyAddress;

	private static int Falloff_Offset;

	private static bool SetBoxFalloff_IsValid;

	private static IntPtr SetBoxFalloff_FunctionAddress;

	private static int SetBoxFalloff_ParamsSize;

	private static bool SetBoxFalloff_Magnitude_IsValid;

	private static FFieldAddress SetBoxFalloff_Magnitude_PropertyAddress;

	private static int SetBoxFalloff_Magnitude_Offset;

	private static bool SetBoxFalloff_MinRange_IsValid;

	private static FFieldAddress SetBoxFalloff_MinRange_PropertyAddress;

	private static int SetBoxFalloff_MinRange_Offset;

	private static bool SetBoxFalloff_MaxRange_IsValid;

	private static FFieldAddress SetBoxFalloff_MaxRange_PropertyAddress;

	private static int SetBoxFalloff_MaxRange_Offset;

	private static bool SetBoxFalloff_Default_IsValid;

	private static FFieldAddress SetBoxFalloff_Default_PropertyAddress;

	private static int SetBoxFalloff_Default_Offset;

	private static bool SetBoxFalloff_Transform_IsValid;

	private static FFieldAddress SetBoxFalloff_Transform_PropertyAddress;

	private static int SetBoxFalloff_Transform_Offset;

	private static bool SetBoxFalloff_Falloff_IsValid;

	private static FFieldAddress SetBoxFalloff_Falloff_PropertyAddress;

	private static int SetBoxFalloff_Falloff_Offset;

	private static bool SetBoxFalloff_ReturnValue_IsValid;

	private static FFieldAddress SetBoxFalloff_ReturnValue_PropertyAddress;

	private static int SetBoxFalloff_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:MinRange")]
	public float MinRange
	{
		get
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:MinRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:MinRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:MaxRange")]
	public float MaxRange
	{
		get
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:MaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:MaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:Default")]
	public float Default
	{
		get
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Default");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Default_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Default");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Default_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:Transform")]
	public FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:Falloff")]
	public EFieldFalloffType Falloff
	{
		get
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Falloff");
				return EFieldFalloffType.Field_FallOff_None;
			}
			return EnumMarshaler<EFieldFalloffType>.FromNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.BoxFalloff:Falloff");
			}
			else
			{
				EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.BoxFalloff:SetBoxFalloff")]
	public unsafe UBoxFalloff SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, FTransform Transform, EFieldFalloffType Falloff)
	{
		CheckDestroyed();
		if (!SetBoxFalloff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.BoxFalloff:SetBoxFalloff");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoxFalloff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoxFalloff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_Magnitude_Offset), 0, SetBoxFalloff_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_MinRange_Offset), 0, SetBoxFalloff_MinRange_PropertyAddress.Address, MinRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_MaxRange_Offset), 0, SetBoxFalloff_MaxRange_PropertyAddress.Address, MaxRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_Default_Offset), 0, SetBoxFalloff_Default_PropertyAddress.Address, Default);
		NativeReflection.InitializeValue_InContainer(SetBoxFalloff_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_Transform_Offset), 0, SetBoxFalloff_Transform_PropertyAddress.Address, Transform);
		EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(intPtr, SetBoxFalloff_Falloff_Offset), 0, SetBoxFalloff_Falloff_PropertyAddress.Address, Falloff);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoxFalloff_FunctionAddress, intPtr, SetBoxFalloff_ParamsSize);
		return UObjectMarshaler<UBoxFalloff>.FromNative(IntPtr.Add(intPtr, SetBoxFalloff_ReturnValue_Offset), 0, SetBoxFalloff_ReturnValue_PropertyAddress.Address);
	}

	static UBoxFalloff()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBoxFalloff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBoxFalloff));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.BoxFalloff");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		MinRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRange");
		MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRange", Classes.FFloatProperty);
		MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRange");
		MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRange", Classes.FFloatProperty);
		Default_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Default");
		Default_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Default", Classes.FFloatProperty);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Falloff_PropertyAddress, intPtr, "Falloff");
		Falloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Falloff");
		Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Falloff", Classes.FByteProperty);
		SetBoxFalloff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoxFalloff");
		SetBoxFalloff_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoxFalloff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_Magnitude_PropertyAddress, SetBoxFalloff_FunctionAddress, "Magnitude");
		SetBoxFalloff_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "Magnitude");
		SetBoxFalloff_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_MinRange_PropertyAddress, SetBoxFalloff_FunctionAddress, "MinRange");
		SetBoxFalloff_MinRange_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "MinRange");
		SetBoxFalloff_MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "MinRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_MaxRange_PropertyAddress, SetBoxFalloff_FunctionAddress, "MaxRange");
		SetBoxFalloff_MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "MaxRange");
		SetBoxFalloff_MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "MaxRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_Default_PropertyAddress, SetBoxFalloff_FunctionAddress, "Default");
		SetBoxFalloff_Default_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "Default");
		SetBoxFalloff_Default_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "Default", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_Transform_PropertyAddress, SetBoxFalloff_FunctionAddress, "Transform");
		SetBoxFalloff_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "Transform");
		SetBoxFalloff_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_Falloff_PropertyAddress, SetBoxFalloff_FunctionAddress, "Falloff");
		SetBoxFalloff_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "Falloff");
		SetBoxFalloff_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoxFalloff_ReturnValue_PropertyAddress, SetBoxFalloff_FunctionAddress, "ReturnValue");
		SetBoxFalloff_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoxFalloff_FunctionAddress, "ReturnValue");
		SetBoxFalloff_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoxFalloff_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetBoxFalloff_IsValid = SetBoxFalloff_FunctionAddress != IntPtr.Zero && SetBoxFalloff_Magnitude_IsValid && SetBoxFalloff_MinRange_IsValid && SetBoxFalloff_MaxRange_IsValid && SetBoxFalloff_Default_IsValid && SetBoxFalloff_Transform_IsValid && SetBoxFalloff_Falloff_IsValid && SetBoxFalloff_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.BoxFalloff:SetBoxFalloff", SetBoxFalloff_IsValid);
	}
}
