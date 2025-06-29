using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributeNoiseSettings : UPCGSettings
{
	private static bool InputSource_IsValid;

	private static int InputSource_Offset;

	private static bool OutputTarget_IsValid;

	private static int OutputTarget_Offset;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool NoiseMin_IsValid;

	private static int NoiseMin_Offset;

	private static bool NoiseMax_IsValid;

	private static int NoiseMax_Offset;

	private static bool InvertSource_IsValid;

	private static FFieldAddress InvertSource_PropertyAddress;

	private static int InvertSource_Offset;

	private static bool ClampResult_IsValid;

	private static FFieldAddress ClampResult_PropertyAddress;

	private static int ClampResult_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:InputSource")]
	public FPCGAttributePropertyInputSelector InputSource
	{
		get
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:InputSource");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, InputSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:InputSource");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, InputSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:OutputTarget")]
	public FPCGAttributePropertyOutputSelector OutputTarget
	{
		get
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:OutputTarget");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, OutputTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:OutputTarget");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, OutputTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:Mode")]
	public EPCGAttributeNoiseMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:Mode");
				return EPCGAttributeNoiseMode.Set;
			}
			return EnumMarshaler<EPCGAttributeNoiseMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGAttributeNoiseMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:NoiseMin")]
	public float NoiseMin
	{
		get
		{
			CheckDestroyed();
			if (!NoiseMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:NoiseMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:NoiseMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:NoiseMax")]
	public float NoiseMax
	{
		get
		{
			CheckDestroyed();
			if (!NoiseMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:NoiseMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:NoiseMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:bInvertSource")]
	public bool InvertSource
	{
		get
		{
			CheckDestroyed();
			if (!InvertSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:bInvertSource");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InvertSource_Offset), 0, InvertSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InvertSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:bInvertSource");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InvertSource_Offset), 0, InvertSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGAttributeNoiseSettings:bClampResult")]
	public bool ClampResult
	{
		get
		{
			CheckDestroyed();
			if (!ClampResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:bClampResult");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClampResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGAttributeNoiseSettings:bClampResult");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClampResult_Offset), 0, ClampResult_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGAttributeNoiseSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributeNoiseSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributeNoiseSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGAttributeNoiseSettings");
		InputSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputSource");
		InputSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputSource", Classes.FStructProperty);
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputTarget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		NoiseMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NoiseMin");
		NoiseMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NoiseMin", Classes.FFloatProperty);
		NoiseMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NoiseMax");
		NoiseMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NoiseMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertSource_PropertyAddress, unrealStruct, "bInvertSource");
		InvertSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bInvertSource");
		InvertSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bInvertSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClampResult_PropertyAddress, unrealStruct, "bClampResult");
		ClampResult_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bClampResult");
		ClampResult_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bClampResult", Classes.FBoolProperty);
	}
}
