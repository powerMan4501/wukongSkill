using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveExponential", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierResponseCurveExponential : UInputModifier
{
	private static bool CurveExponent_IsValid;

	private static int CurveExponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierResponseCurveExponential:CurveExponent")]
	public FVector CurveExponent
	{
		get
		{
			CheckDestroyed();
			if (!CurveExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveExponential:CurveExponent");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CurveExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierResponseCurveExponential:CurveExponent");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CurveExponent_Offset), value);
			}
		}
	}

	static UInputModifierResponseCurveExponential()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierResponseCurveExponential)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierResponseCurveExponential));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierResponseCurveExponential");
		CurveExponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveExponent");
		CurveExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveExponent", Classes.FStructProperty);
	}
}
