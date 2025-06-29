using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.WaveScalar", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UWaveScalar : UFieldNodeFloat
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool Wavelength_IsValid;

	private static int Wavelength_Offset;

	private static bool Period_IsValid;

	private static int Period_Offset;

	private static bool Function_IsValid;

	private static FFieldAddress Function_PropertyAddress;

	private static int Function_Offset;

	private static bool Falloff_IsValid;

	private static FFieldAddress Falloff_PropertyAddress;

	private static int Falloff_Offset;

	private static bool SetWaveScalar_IsValid;

	private static IntPtr SetWaveScalar_FunctionAddress;

	private static int SetWaveScalar_ParamsSize;

	private static bool SetWaveScalar_Magnitude_IsValid;

	private static FFieldAddress SetWaveScalar_Magnitude_PropertyAddress;

	private static int SetWaveScalar_Magnitude_Offset;

	private static bool SetWaveScalar_Position_IsValid;

	private static FFieldAddress SetWaveScalar_Position_PropertyAddress;

	private static int SetWaveScalar_Position_Offset;

	private static bool SetWaveScalar_Wavelength_IsValid;

	private static FFieldAddress SetWaveScalar_Wavelength_PropertyAddress;

	private static int SetWaveScalar_Wavelength_Offset;

	private static bool SetWaveScalar_Period_IsValid;

	private static FFieldAddress SetWaveScalar_Period_PropertyAddress;

	private static int SetWaveScalar_Period_Offset;

	private static bool SetWaveScalar_Time_IsValid;

	private static FFieldAddress SetWaveScalar_Time_PropertyAddress;

	private static int SetWaveScalar_Time_Offset;

	private static bool SetWaveScalar_Function_IsValid;

	private static FFieldAddress SetWaveScalar_Function_PropertyAddress;

	private static int SetWaveScalar_Function_Offset;

	private static bool SetWaveScalar_Falloff_IsValid;

	private static FFieldAddress SetWaveScalar_Falloff_PropertyAddress;

	private static int SetWaveScalar_Falloff_Offset;

	private static bool SetWaveScalar_ReturnValue_IsValid;

	private static FFieldAddress SetWaveScalar_ReturnValue_PropertyAddress;

	private static int SetWaveScalar_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Magnitude")]
	public float Magnitude
	{
		get
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Magnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Magnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Magnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Magnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Magnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Position")]
	public FVector Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Position");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Position");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Wavelength")]
	public float Wavelength
	{
		get
		{
			CheckDestroyed();
			if (!Wavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Wavelength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Wavelength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Wavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Wavelength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Wavelength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Period")]
	public float Period
	{
		get
		{
			CheckDestroyed();
			if (!Period_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Period");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Period_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Period_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Period");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Period_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Function")]
	public EWaveFunctionType Function
	{
		get
		{
			CheckDestroyed();
			if (!Function_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Function");
				return EWaveFunctionType.Field_Wave_Cosine;
			}
			return EnumMarshaler<EWaveFunctionType>.FromNative(IntPtr.Add(base.Address, Function_Offset), 0, Function_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Function_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Function");
			}
			else
			{
				EnumMarshaler<EWaveFunctionType>.ToNative(IntPtr.Add(base.Address, Function_Offset), 0, Function_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:Falloff")]
	public EFieldFalloffType Falloff
	{
		get
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Falloff");
				return EFieldFalloffType.Field_FallOff_None;
			}
			return EnumMarshaler<EFieldFalloffType>.FromNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.WaveScalar:Falloff");
			}
			else
			{
				EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/FieldSystemEngine.WaveScalar:SetWaveScalar")]
	public unsafe UWaveScalar SetWaveScalar(float Magnitude, FVector Position, float Wavelength, float Period, float Time, EWaveFunctionType Function, EFieldFalloffType Falloff)
	{
		CheckDestroyed();
		if (!SetWaveScalar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.WaveScalar:SetWaveScalar");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaveScalar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaveScalar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Magnitude_Offset), 0, SetWaveScalar_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Position_Offset), 0, SetWaveScalar_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Wavelength_Offset), 0, SetWaveScalar_Wavelength_PropertyAddress.Address, Wavelength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Period_Offset), 0, SetWaveScalar_Period_PropertyAddress.Address, Period);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Time_Offset), 0, SetWaveScalar_Time_PropertyAddress.Address, Time);
		EnumMarshaler<EWaveFunctionType>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Function_Offset), 0, SetWaveScalar_Function_PropertyAddress.Address, Function);
		EnumMarshaler<EFieldFalloffType>.ToNative(IntPtr.Add(intPtr, SetWaveScalar_Falloff_Offset), 0, SetWaveScalar_Falloff_PropertyAddress.Address, Falloff);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaveScalar_FunctionAddress, intPtr, SetWaveScalar_ParamsSize);
		return UObjectMarshaler<UWaveScalar>.FromNative(IntPtr.Add(intPtr, SetWaveScalar_ReturnValue_Offset), 0, SetWaveScalar_ReturnValue_PropertyAddress.Address);
	}

	static UWaveScalar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaveScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaveScalar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.WaveScalar");
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Wavelength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Wavelength");
		Wavelength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Wavelength", Classes.FFloatProperty);
		Period_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Period");
		Period_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Period", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Function_PropertyAddress, intPtr, "Function");
		Function_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Function");
		Function_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Function", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Falloff_PropertyAddress, intPtr, "Falloff");
		Falloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Falloff");
		Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Falloff", Classes.FByteProperty);
		SetWaveScalar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaveScalar");
		SetWaveScalar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaveScalar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Magnitude_PropertyAddress, SetWaveScalar_FunctionAddress, "Magnitude");
		SetWaveScalar_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Magnitude");
		SetWaveScalar_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Position_PropertyAddress, SetWaveScalar_FunctionAddress, "Position");
		SetWaveScalar_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Position");
		SetWaveScalar_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Wavelength_PropertyAddress, SetWaveScalar_FunctionAddress, "Wavelength");
		SetWaveScalar_Wavelength_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Wavelength");
		SetWaveScalar_Wavelength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Wavelength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Period_PropertyAddress, SetWaveScalar_FunctionAddress, "Period");
		SetWaveScalar_Period_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Period");
		SetWaveScalar_Period_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Period", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Time_PropertyAddress, SetWaveScalar_FunctionAddress, "Time");
		SetWaveScalar_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Time");
		SetWaveScalar_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Function_PropertyAddress, SetWaveScalar_FunctionAddress, "Function");
		SetWaveScalar_Function_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Function");
		SetWaveScalar_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Function", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_Falloff_PropertyAddress, SetWaveScalar_FunctionAddress, "Falloff");
		SetWaveScalar_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "Falloff");
		SetWaveScalar_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveScalar_ReturnValue_PropertyAddress, SetWaveScalar_FunctionAddress, "ReturnValue");
		SetWaveScalar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveScalar_FunctionAddress, "ReturnValue");
		SetWaveScalar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveScalar_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetWaveScalar_IsValid = SetWaveScalar_FunctionAddress != IntPtr.Zero && SetWaveScalar_Magnitude_IsValid && SetWaveScalar_Position_IsValid && SetWaveScalar_Wavelength_IsValid && SetWaveScalar_Period_IsValid && SetWaveScalar_Time_IsValid && SetWaveScalar_Function_IsValid && SetWaveScalar_Falloff_IsValid && SetWaveScalar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.WaveScalar:SetWaveScalar", SetWaveScalar_IsValid);
	}
}
