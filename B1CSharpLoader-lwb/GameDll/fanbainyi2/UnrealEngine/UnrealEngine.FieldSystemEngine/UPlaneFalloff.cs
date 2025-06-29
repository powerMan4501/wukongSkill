using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UPlaneFalloff : UFieldNodeFloat
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool MinRange_IsValid;

	private static int MinRange_Offset;

	private static bool MaxRange_IsValid;

	private static int MaxRange_Offset;

	private static bool Default_IsValid;

	private static int Default_Offset;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	private static bool Falloff_IsValid;

	private static FFieldAddress Falloff_PropertyAddress;

	private static int Falloff_Offset;

	private static bool SetPlaneFalloff_IsValid;

	private static IntPtr SetPlaneFalloff_FunctionAddress;

	private static int SetPlaneFalloff_ParamsSize;

	private static bool SetPlaneFalloff_Magnitude_IsValid;

	private static FFieldAddress SetPlaneFalloff_Magnitude_PropertyAddress;

	private static int SetPlaneFalloff_Magnitude_Offset;

	private static bool SetPlaneFalloff_MinRange_IsValid;

	private static FFieldAddress SetPlaneFalloff_MinRange_PropertyAddress;

	private static int SetPlaneFalloff_MinRange_Offset;

	private static bool SetPlaneFalloff_MaxRange_IsValid;

	private static FFieldAddress SetPlaneFalloff_MaxRange_PropertyAddress;

	private static int SetPlaneFalloff_MaxRange_Offset;

	private static bool SetPlaneFalloff_Default_IsValid;

	private static FFieldAddress SetPlaneFalloff_Default_PropertyAddress;

	private static int SetPlaneFalloff_Default_Offset;

	private static bool SetPlaneFalloff_Distance_IsValid;

	private static FFieldAddress SetPlaneFalloff_Distance_PropertyAddress;

	private static int SetPlaneFalloff_Distance_Offset;

	private static bool SetPlaneFalloff_Position_IsValid;

	private static FFieldAddress SetPlaneFalloff_Position_PropertyAddress;

	private static int SetPlaneFalloff_Position_Offset;

	private static bool SetPlaneFalloff_Normal_IsValid;

	private static FFieldAddress SetPlaneFalloff_Normal_PropertyAddress;

	private static int SetPlaneFalloff_Normal_Offset;

	private static bool SetPlaneFalloff_Falloff_IsValid;

	private static FFieldAddress SetPlaneFalloff_Falloff_PropertyAddress;

	private static int SetPlaneFalloff_Falloff_Offset;

	private static bool SetPlaneFalloff_ReturnValue_IsValid;

	private static FFieldAddress SetPlaneFalloff_ReturnValue_PropertyAddress;

	private static int SetPlaneFalloff_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:MinRange")]
	public float MinRange
	{
		get
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:MinRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:MinRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:MaxRange")]
	public float MaxRange
	{
		get
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:MaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:MaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Default")]
	public float Default
	{
		get
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Default");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Default_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Default_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Default");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Default_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Distance")]
	public float Distance
	{
		get
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Distance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Distance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Distance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Distance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Position")]
	public FVector Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Position");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Position");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Normal")]
	public FVector Normal
	{
		get
		{
			CheckDestroyed();
			if (!Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Normal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Normal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Normal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Normal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:Falloff")]
	public EFieldFalloffType Falloff
	{
		get
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Falloff");
				return EFieldFalloffType.Field_FallOff_None;
			}
			return EnumMarshaler<EFieldFalloffType>.FromNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.PlaneFalloff:Falloff");
			}
			else
			{
				EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.PlaneFalloff:SetPlaneFalloff")]
	public unsafe UPlaneFalloff SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, FVector Position, FVector Normal, EFieldFalloffType Falloff)
	{
		CheckDestroyed();
		if (!SetPlaneFalloff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.PlaneFalloff:SetPlaneFalloff");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneFalloff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneFalloff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Magnitude_Offset), 0, SetPlaneFalloff_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_MinRange_Offset), 0, SetPlaneFalloff_MinRange_PropertyAddress.Address, MinRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_MaxRange_Offset), 0, SetPlaneFalloff_MaxRange_PropertyAddress.Address, MaxRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Default_Offset), 0, SetPlaneFalloff_Default_PropertyAddress.Address, Default);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Distance_Offset), 0, SetPlaneFalloff_Distance_PropertyAddress.Address, Distance);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Position_Offset), 0, SetPlaneFalloff_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Normal_Offset), 0, SetPlaneFalloff_Normal_PropertyAddress.Address, Normal);
		EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(intPtr, SetPlaneFalloff_Falloff_Offset), 0, SetPlaneFalloff_Falloff_PropertyAddress.Address, Falloff);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneFalloff_FunctionAddress, intPtr, SetPlaneFalloff_ParamsSize);
		return UObjectMarshaler<UPlaneFalloff>.FromNative(IntPtr.Add(intPtr, SetPlaneFalloff_ReturnValue_Offset), 0, SetPlaneFalloff_ReturnValue_PropertyAddress.Address);
	}

	static UPlaneFalloff()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlaneFalloff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlaneFalloff));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.PlaneFalloff");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		MinRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRange");
		MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRange", Classes.FFloatProperty);
		MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRange");
		MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRange", Classes.FFloatProperty);
		Default_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Default");
		Default_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Default", Classes.FFloatProperty);
		Distance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Distance");
		Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Distance", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Falloff_PropertyAddress, intPtr, "Falloff");
		Falloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Falloff");
		Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Falloff", Classes.FByteProperty);
		SetPlaneFalloff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneFalloff");
		SetPlaneFalloff_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneFalloff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Magnitude_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Magnitude");
		SetPlaneFalloff_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Magnitude");
		SetPlaneFalloff_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_MinRange_PropertyAddress, SetPlaneFalloff_FunctionAddress, "MinRange");
		SetPlaneFalloff_MinRange_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "MinRange");
		SetPlaneFalloff_MinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "MinRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_MaxRange_PropertyAddress, SetPlaneFalloff_FunctionAddress, "MaxRange");
		SetPlaneFalloff_MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "MaxRange");
		SetPlaneFalloff_MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "MaxRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Default_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Default");
		SetPlaneFalloff_Default_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Default");
		SetPlaneFalloff_Default_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Default", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Distance_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Distance");
		SetPlaneFalloff_Distance_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Distance");
		SetPlaneFalloff_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Position_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Position");
		SetPlaneFalloff_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Position");
		SetPlaneFalloff_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Normal_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Normal");
		SetPlaneFalloff_Normal_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Normal");
		SetPlaneFalloff_Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Normal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_Falloff_PropertyAddress, SetPlaneFalloff_FunctionAddress, "Falloff");
		SetPlaneFalloff_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "Falloff");
		SetPlaneFalloff_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneFalloff_ReturnValue_PropertyAddress, SetPlaneFalloff_FunctionAddress, "ReturnValue");
		SetPlaneFalloff_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneFalloff_FunctionAddress, "ReturnValue");
		SetPlaneFalloff_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneFalloff_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetPlaneFalloff_IsValid = SetPlaneFalloff_FunctionAddress != IntPtr.Zero && SetPlaneFalloff_Magnitude_IsValid && SetPlaneFalloff_MinRange_IsValid && SetPlaneFalloff_MaxRange_IsValid && SetPlaneFalloff_Default_IsValid && SetPlaneFalloff_Distance_IsValid && SetPlaneFalloff_Position_IsValid && SetPlaneFalloff_Normal_IsValid && SetPlaneFalloff_Falloff_IsValid && SetPlaneFalloff_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.PlaneFalloff:SetPlaneFalloff", SetPlaneFalloff_IsValid);
	}
}
