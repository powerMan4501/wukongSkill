using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGTransformPointsSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGTransformPointsSettings : UPCGSettings
{
	private static bool ApplyToAttribute_IsValid;

	private static FFieldAddress ApplyToAttribute_PropertyAddress;

	private static int ApplyToAttribute_Offset;

	private static bool AttributeName_IsValid;

	private static int AttributeName_Offset;

	private static bool OffsetMin_IsValid;

	private static int OffsetMin_Offset;

	private static bool OffsetMax_IsValid;

	private static int OffsetMax_Offset;

	private static bool AbsoluteOffset_IsValid;

	private static FFieldAddress AbsoluteOffset_PropertyAddress;

	private static int AbsoluteOffset_Offset;

	private static bool RotationMin_IsValid;

	private static int RotationMin_Offset;

	private static bool RotationMax_IsValid;

	private static int RotationMax_Offset;

	private static bool AbsoluteRotation_IsValid;

	private static FFieldAddress AbsoluteRotation_PropertyAddress;

	private static int AbsoluteRotation_Offset;

	private static bool ScaleMin_IsValid;

	private static int ScaleMin_Offset;

	private static bool ScaleMax_IsValid;

	private static int ScaleMax_Offset;

	private static bool AbsoluteScale_IsValid;

	private static FFieldAddress AbsoluteScale_PropertyAddress;

	private static int AbsoluteScale_Offset;

	private static bool UniformScale_IsValid;

	private static FFieldAddress UniformScale_PropertyAddress;

	private static int UniformScale_Offset;

	private static bool RecomputeSeed_IsValid;

	private static FFieldAddress RecomputeSeed_PropertyAddress;

	private static int RecomputeSeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bApplyToAttribute")]
	public bool ApplyToAttribute
	{
		get
		{
			CheckDestroyed();
			if (!ApplyToAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bApplyToAttribute");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyToAttribute_Offset), 0, ApplyToAttribute_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyToAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bApplyToAttribute");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyToAttribute_Offset), 0, ApplyToAttribute_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:AttributeName")]
	public FName AttributeName
	{
		get
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:AttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:AttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:OffsetMin")]
	public FVector OffsetMin
	{
		get
		{
			CheckDestroyed();
			if (!OffsetMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:OffsetMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OffsetMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:OffsetMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OffsetMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:OffsetMax")]
	public FVector OffsetMax
	{
		get
		{
			CheckDestroyed();
			if (!OffsetMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:OffsetMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OffsetMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:OffsetMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OffsetMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bAbsoluteOffset")]
	public bool AbsoluteOffset
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteOffset_Offset), 0, AbsoluteOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteOffset_Offset), 0, AbsoluteOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:RotationMin")]
	public FRotator RotationMin
	{
		get
		{
			CheckDestroyed();
			if (!RotationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:RotationMin");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:RotationMin");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:RotationMax")]
	public FRotator RotationMax
	{
		get
		{
			CheckDestroyed();
			if (!RotationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:RotationMax");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:RotationMax");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bAbsoluteRotation")]
	public bool AbsoluteRotation
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteRotation_Offset), 0, AbsoluteRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteRotation_Offset), 0, AbsoluteRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:ScaleMin")]
	public FVector ScaleMin
	{
		get
		{
			CheckDestroyed();
			if (!ScaleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:ScaleMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ScaleMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:ScaleMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ScaleMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:ScaleMax")]
	public FVector ScaleMax
	{
		get
		{
			CheckDestroyed();
			if (!ScaleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:ScaleMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ScaleMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:ScaleMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ScaleMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bAbsoluteScale")]
	public bool AbsoluteScale
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteScale_Offset), 0, AbsoluteScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bAbsoluteScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteScale_Offset), 0, AbsoluteScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bUniformScale")]
	public bool UniformScale
	{
		get
		{
			CheckDestroyed();
			if (!UniformScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bUniformScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UniformScale_Offset), 0, UniformScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UniformScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bUniformScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UniformScale_Offset), 0, UniformScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTransformPointsSettings:bRecomputeSeed")]
	public bool RecomputeSeed
	{
		get
		{
			CheckDestroyed();
			if (!RecomputeSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bRecomputeSeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RecomputeSeed_Offset), 0, RecomputeSeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RecomputeSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTransformPointsSettings:bRecomputeSeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RecomputeSeed_Offset), 0, RecomputeSeed_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGTransformPointsSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGTransformPointsSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGTransformPointsSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGTransformPointsSettings");
		NativeReflectionCached.GetPropertyRef(ref ApplyToAttribute_PropertyAddress, unrealStruct, "bApplyToAttribute");
		ApplyToAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bApplyToAttribute");
		ApplyToAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bApplyToAttribute", Classes.FBoolProperty);
		AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeName");
		AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeName", Classes.FNameProperty);
		OffsetMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OffsetMin");
		OffsetMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OffsetMin", Classes.FStructProperty);
		OffsetMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OffsetMax");
		OffsetMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OffsetMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteOffset_PropertyAddress, unrealStruct, "bAbsoluteOffset");
		AbsoluteOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAbsoluteOffset");
		AbsoluteOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAbsoluteOffset", Classes.FBoolProperty);
		RotationMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RotationMin");
		RotationMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RotationMin", Classes.FStructProperty);
		RotationMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RotationMax");
		RotationMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RotationMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteRotation_PropertyAddress, unrealStruct, "bAbsoluteRotation");
		AbsoluteRotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAbsoluteRotation");
		AbsoluteRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAbsoluteRotation", Classes.FBoolProperty);
		ScaleMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScaleMin");
		ScaleMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScaleMin", Classes.FStructProperty);
		ScaleMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScaleMax");
		ScaleMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScaleMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteScale_PropertyAddress, unrealStruct, "bAbsoluteScale");
		AbsoluteScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAbsoluteScale");
		AbsoluteScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAbsoluteScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UniformScale_PropertyAddress, unrealStruct, "bUniformScale");
		UniformScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUniformScale");
		UniformScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUniformScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeSeed_PropertyAddress, unrealStruct, "bRecomputeSeed");
		RecomputeSeed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRecomputeSeed");
		RecomputeSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRecomputeSeed", Classes.FBoolProperty);
	}
}
