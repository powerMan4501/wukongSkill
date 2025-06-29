using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821039269uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LocalLightComponent", "Engine", UnrealModuleType.Engine)]
public class ULocalLightComponent : ULightComponent
{
	private static IntPtr classAddress;

	private static bool IntensityUnits_IsValid;

	private static FFieldAddress IntensityUnits_PropertyAddress;

	private static int IntensityUnits_Offset;

	private static bool AttenuationRadius_IsValid;

	private static int AttenuationRadius_Offset;

	private static bool SetIntensityUnits_IsValid;

	private static IntPtr SetIntensityUnits_FunctionAddress;

	private static int SetIntensityUnits_ParamsSize;

	private static bool SetIntensityUnits_NewIntensityUnits_IsValid;

	private static FFieldAddress SetIntensityUnits_NewIntensityUnits_PropertyAddress;

	private static int SetIntensityUnits_NewIntensityUnits_Offset;

	private static bool SetAttenuationRadius_IsValid;

	private static IntPtr SetAttenuationRadius_FunctionAddress;

	private static int SetAttenuationRadius_ParamsSize;

	private static bool SetAttenuationRadius_NewRadius_IsValid;

	private static FFieldAddress SetAttenuationRadius_NewRadius_PropertyAddress;

	private static int SetAttenuationRadius_NewRadius_Offset;

	private static bool GetUnitsConversionFactor_IsValid;

	private static IntPtr GetUnitsConversionFactor_FunctionAddress;

	private static int GetUnitsConversionFactor_ParamsSize;

	private static bool GetUnitsConversionFactor_SrcUnits_IsValid;

	private static FFieldAddress GetUnitsConversionFactor_SrcUnits_PropertyAddress;

	private static int GetUnitsConversionFactor_SrcUnits_Offset;

	private static bool GetUnitsConversionFactor_TargetUnits_IsValid;

	private static FFieldAddress GetUnitsConversionFactor_TargetUnits_PropertyAddress;

	private static int GetUnitsConversionFactor_TargetUnits_Offset;

	private static bool GetUnitsConversionFactor_CosHalfConeAngle_IsValid;

	private static FFieldAddress GetUnitsConversionFactor_CosHalfConeAngle_PropertyAddress;

	private static int GetUnitsConversionFactor_CosHalfConeAngle_Offset;

	private static bool GetUnitsConversionFactor_ReturnValue_IsValid;

	private static FFieldAddress GetUnitsConversionFactor_ReturnValue_PropertyAddress;

	private static int GetUnitsConversionFactor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LocalLightComponent:IntensityUnits")]
	public ELightUnits IntensityUnits
	{
		get
		{
			CheckDestroyed();
			if (!IntensityUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LocalLightComponent:IntensityUnits");
				return ELightUnits.Unitless;
			}
			return EnumMarshaler<ELightUnits>.FromNative(IntPtr.Add(base.Address, IntensityUnits_Offset), 0, IntensityUnits_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IntensityUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LocalLightComponent:IntensityUnits");
			}
			else
			{
				EnumMarshaler<ELightUnits>.ToNative(IntPtr.Add(base.Address, IntensityUnits_Offset), 0, IntensityUnits_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LocalLightComponent:AttenuationRadius")]
	public float AttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LocalLightComponent:AttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LocalLightComponent:AttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttenuationRadius_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LocalLightComponent:SetIntensityUnits")]
	public unsafe void SetIntensityUnits(ELightUnits NewIntensityUnits)
	{
		CheckDestroyed();
		if (!SetIntensityUnits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LocalLightComponent:SetIntensityUnits");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntensityUnits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntensityUnits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELightUnits>.ToNative(IntPtr.Add(intPtr, SetIntensityUnits_NewIntensityUnits_Offset), 0, SetIntensityUnits_NewIntensityUnits_PropertyAddress.Address, NewIntensityUnits);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntensityUnits_FunctionAddress, intPtr, SetIntensityUnits_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LocalLightComponent:SetAttenuationRadius")]
	public unsafe void SetAttenuationRadius(float NewRadius)
	{
		CheckDestroyed();
		if (!SetAttenuationRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LocalLightComponent:SetAttenuationRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttenuationRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttenuationRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAttenuationRadius_NewRadius_Offset), 0, SetAttenuationRadius_NewRadius_PropertyAddress.Address, NewRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttenuationRadius_FunctionAddress, intPtr, SetAttenuationRadius_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.LocalLightComponent:GetUnitsConversionFactor")]
	public unsafe static float GetUnitsConversionFactor(ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle = -1f)
	{
		if (!GetUnitsConversionFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LocalLightComponent:GetUnitsConversionFactor");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnitsConversionFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnitsConversionFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELightUnits>.ToNative(IntPtr.Add(intPtr, GetUnitsConversionFactor_SrcUnits_Offset), 0, GetUnitsConversionFactor_SrcUnits_PropertyAddress.Address, SrcUnits);
		EnumMarshaler<ELightUnits>.ToNative(IntPtr.Add(intPtr, GetUnitsConversionFactor_TargetUnits_Offset), 0, GetUnitsConversionFactor_TargetUnits_PropertyAddress.Address, TargetUnits);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetUnitsConversionFactor_CosHalfConeAngle_Offset), 0, GetUnitsConversionFactor_CosHalfConeAngle_PropertyAddress.Address, CosHalfConeAngle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUnitsConversionFactor_FunctionAddress, intPtr, GetUnitsConversionFactor_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUnitsConversionFactor_ReturnValue_Offset), 0, GetUnitsConversionFactor_ReturnValue_PropertyAddress.Address);
	}

	static ULocalLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULocalLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULocalLightComponent));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.LocalLightComponent");
		NativeReflectionCached.GetPropertyRef(ref IntensityUnits_PropertyAddress, classAddress, "IntensityUnits");
		IntensityUnits_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "IntensityUnits");
		IntensityUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "IntensityUnits", Classes.FEnumProperty);
		AttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "AttenuationRadius");
		AttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "AttenuationRadius", Classes.FFloatProperty);
		SetIntensityUnits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIntensityUnits");
		SetIntensityUnits_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntensityUnits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntensityUnits_NewIntensityUnits_PropertyAddress, SetIntensityUnits_FunctionAddress, "NewIntensityUnits");
		SetIntensityUnits_NewIntensityUnits_Offset = NativeReflectionCached.GetPropertyOffset(SetIntensityUnits_FunctionAddress, "NewIntensityUnits");
		SetIntensityUnits_NewIntensityUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntensityUnits_FunctionAddress, "NewIntensityUnits", Classes.FEnumProperty);
		SetIntensityUnits_IsValid = SetIntensityUnits_FunctionAddress != IntPtr.Zero && SetIntensityUnits_NewIntensityUnits_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LocalLightComponent:SetIntensityUnits", SetIntensityUnits_IsValid);
		SetAttenuationRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAttenuationRadius");
		SetAttenuationRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttenuationRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttenuationRadius_NewRadius_PropertyAddress, SetAttenuationRadius_FunctionAddress, "NewRadius");
		SetAttenuationRadius_NewRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetAttenuationRadius_FunctionAddress, "NewRadius");
		SetAttenuationRadius_NewRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttenuationRadius_FunctionAddress, "NewRadius", Classes.FFloatProperty);
		SetAttenuationRadius_IsValid = SetAttenuationRadius_FunctionAddress != IntPtr.Zero && SetAttenuationRadius_NewRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LocalLightComponent:SetAttenuationRadius", SetAttenuationRadius_IsValid);
		GetUnitsConversionFactor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUnitsConversionFactor");
		GetUnitsConversionFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnitsConversionFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnitsConversionFactor_SrcUnits_PropertyAddress, GetUnitsConversionFactor_FunctionAddress, "SrcUnits");
		GetUnitsConversionFactor_SrcUnits_Offset = NativeReflectionCached.GetPropertyOffset(GetUnitsConversionFactor_FunctionAddress, "SrcUnits");
		GetUnitsConversionFactor_SrcUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnitsConversionFactor_FunctionAddress, "SrcUnits", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnitsConversionFactor_TargetUnits_PropertyAddress, GetUnitsConversionFactor_FunctionAddress, "TargetUnits");
		GetUnitsConversionFactor_TargetUnits_Offset = NativeReflectionCached.GetPropertyOffset(GetUnitsConversionFactor_FunctionAddress, "TargetUnits");
		GetUnitsConversionFactor_TargetUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnitsConversionFactor_FunctionAddress, "TargetUnits", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnitsConversionFactor_CosHalfConeAngle_PropertyAddress, GetUnitsConversionFactor_FunctionAddress, "CosHalfConeAngle");
		GetUnitsConversionFactor_CosHalfConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetUnitsConversionFactor_FunctionAddress, "CosHalfConeAngle");
		GetUnitsConversionFactor_CosHalfConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnitsConversionFactor_FunctionAddress, "CosHalfConeAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnitsConversionFactor_ReturnValue_PropertyAddress, GetUnitsConversionFactor_FunctionAddress, "ReturnValue");
		GetUnitsConversionFactor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnitsConversionFactor_FunctionAddress, "ReturnValue");
		GetUnitsConversionFactor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnitsConversionFactor_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUnitsConversionFactor_IsValid = GetUnitsConversionFactor_FunctionAddress != IntPtr.Zero && GetUnitsConversionFactor_SrcUnits_IsValid && GetUnitsConversionFactor_TargetUnits_IsValid && GetUnitsConversionFactor_CosHalfConeAngle_IsValid && GetUnitsConversionFactor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LocalLightComponent:GetUnitsConversionFactor", GetUnitsConversionFactor_IsValid);
	}
}
