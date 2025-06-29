using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF")]
internal class BGWDataAsset_EnvEHF : UBGWDataAsset
{
	private static bool FogDensity_IsValid;

	private static int FogDensity_Offset;

	private static bool FogHeightFalloff_IsValid;

	private static int FogHeightFalloff_Offset;

	private static bool SecondFogData_IsValid;

	private static int SecondFogData_Offset;

	private static bool FogInscatteringColor_IsValid;

	private static int FogInscatteringColor_Offset;

	private static bool FogMaxOpacity_IsValid;

	private static int FogMaxOpacity_Offset;

	private static bool StartDistance_IsValid;

	private static int StartDistance_Offset;

	private static bool FogCutoffDistance_IsValid;

	private static int FogCutoffDistance_Offset;

	private static bool EnableVolumetricFog_IsValid;

	private static int EnableVolumetricFog_Offset;

	private static FFieldAddress EnableVolumetricFog_PropertyAddress;

	private static bool Albedo_IsValid;

	private static int Albedo_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogDensity")]
	public float FogDensity
	{
		get
		{
			CheckDestroyed();
			if (!FogDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogDensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogDensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogDensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogDensity_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogHeightFalloff")]
	public float FogHeightFalloff
	{
		get
		{
			CheckDestroyed();
			if (!FogHeightFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogHeightFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogHeightFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogHeightFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogHeightFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogHeightFalloff_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:SecondFogData")]
	public FExponentialHeightFogData SecondFogData
	{
		get
		{
			CheckDestroyed();
			if (!SecondFogData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:SecondFogData");
				return default(FExponentialHeightFogData);
			}
			return FExponentialHeightFogData.FromNative(IntPtr.Add(base.Address, SecondFogData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondFogData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:SecondFogData");
			}
			else
			{
				FExponentialHeightFogData.ToNative(IntPtr.Add(base.Address, SecondFogData_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogInscatteringColor")]
	public FLinearColor FogInscatteringColor
	{
		get
		{
			CheckDestroyed();
			if (!FogInscatteringColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogInscatteringColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FogInscatteringColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogInscatteringColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogInscatteringColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FogInscatteringColor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogMaxOpacity")]
	public float FogMaxOpacity
	{
		get
		{
			CheckDestroyed();
			if (!FogMaxOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogMaxOpacity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogMaxOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogMaxOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogMaxOpacity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogMaxOpacity_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:StartDistance")]
	public float StartDistance
	{
		get
		{
			CheckDestroyed();
			if (!StartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:StartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:StartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogCutoffDistance")]
	public float FogCutoffDistance
	{
		get
		{
			CheckDestroyed();
			if (!FogCutoffDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogCutoffDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogCutoffDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogCutoffDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:FogCutoffDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogCutoffDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:EnableVolumetricFog")]
	public bool EnableVolumetricFog
	{
		get
		{
			CheckDestroyed();
			if (!EnableVolumetricFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:EnableVolumetricFog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableVolumetricFog_Offset), 0, EnableVolumetricFog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableVolumetricFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:EnableVolumetricFog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableVolumetricFog_Offset), 0, EnableVolumetricFog_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvEHF:Albedo")]
	public FColor Albedo
	{
		get
		{
			CheckDestroyed();
			if (!Albedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:Albedo");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, Albedo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Albedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvEHF:Albedo");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, Albedo_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_EnvEHF");
		FogDensity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FogDensity");
		FogDensity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FogDensity", Classes.FFloatProperty);
		FogHeightFalloff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FogHeightFalloff");
		FogHeightFalloff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FogHeightFalloff", Classes.FFloatProperty);
		SecondFogData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SecondFogData");
		SecondFogData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SecondFogData", Classes.FStructProperty);
		FogInscatteringColor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FogInscatteringColor");
		FogInscatteringColor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FogInscatteringColor", Classes.FStructProperty);
		FogMaxOpacity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FogMaxOpacity");
		FogMaxOpacity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FogMaxOpacity", Classes.FFloatProperty);
		StartDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartDistance");
		StartDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartDistance", Classes.FFloatProperty);
		FogCutoffDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FogCutoffDistance");
		FogCutoffDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FogCutoffDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableVolumetricFog_PropertyAddress, unrealStruct, "EnableVolumetricFog");
		EnableVolumetricFog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableVolumetricFog");
		EnableVolumetricFog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableVolumetricFog", Classes.FBoolProperty);
		Albedo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Albedo");
		Albedo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Albedo", Classes.FStructProperty);
	}

	static BGWDataAsset_EnvEHF()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGWDataAsset_EnvEHF)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGWDataAsset_EnvEHF));
	}
}
