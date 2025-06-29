using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779234uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierScalar", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierScalar : UInputModifier
{
	private static bool Scalar_IsValid;

	private static int Scalar_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierScalar:Scalar")]
	public FVector Scalar
	{
		get
		{
			CheckDestroyed();
			if (!Scalar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierScalar:Scalar");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Scalar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Scalar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierScalar:Scalar");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Scalar_Offset), value);
			}
		}
	}

	static UInputModifierScalar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierScalar));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierScalar");
		Scalar_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Scalar");
		Scalar_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Scalar", Classes.FStructProperty);
	}
}
