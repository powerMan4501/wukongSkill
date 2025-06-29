using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779234uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveUser", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierResponseCurveUser : UInputModifier
{
	private static bool ResponseX_IsValid;

	private static int ResponseX_Offset;

	private static bool ResponseY_IsValid;

	private static int ResponseY_Offset;

	private static bool ResponseZ_IsValid;

	private static int ResponseZ_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseX")]
	public UCurveFloat ResponseX
	{
		get
		{
			CheckDestroyed();
			if (!ResponseX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseX");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ResponseX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResponseX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseX");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ResponseX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseY")]
	public UCurveFloat ResponseY
	{
		get
		{
			CheckDestroyed();
			if (!ResponseY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseY");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ResponseY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResponseY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseY");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ResponseY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseZ")]
	public UCurveFloat ResponseZ
	{
		get
		{
			CheckDestroyed();
			if (!ResponseZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseZ");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, ResponseZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResponseZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveUser:ResponseZ");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, ResponseZ_Offset), value);
			}
		}
	}

	static UInputModifierResponseCurveUser()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierResponseCurveUser)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierResponseCurveUser));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierResponseCurveUser");
		ResponseX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ResponseX");
		ResponseX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ResponseX", Classes.FObjectProperty);
		ResponseY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ResponseY");
		ResponseY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ResponseY", Classes.FObjectProperty);
		ResponseZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ResponseZ");
		ResponseZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ResponseZ", Classes.FObjectProperty);
	}
}
