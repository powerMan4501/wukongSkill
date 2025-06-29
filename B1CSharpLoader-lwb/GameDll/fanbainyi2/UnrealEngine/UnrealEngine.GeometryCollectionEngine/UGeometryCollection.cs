using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public class UGeometryCollection : UObject
{
	private static bool GeometrySource_IsValid;

	private static FFieldAddress GeometrySource_PropertyAddress;

	private static int GeometrySource_Offset;

	private TArrayReadWriteMarshaler<FGeometryCollectionSource> GeometrySource_MarshalerCached;

	private static bool EnableNanite_IsValid;

	private static FFieldAddress EnableNanite_PropertyAddress;

	private static int EnableNanite_Offset;

	private static bool MassAsDensity_IsValid;

	private static FFieldAddress MassAsDensity_PropertyAddress;

	private static int MassAsDensity_Offset;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	private static bool MinimumMassClamp_IsValid;

	private static int MinimumMassClamp_Offset;

	private static bool RemoveOnMaxSleep_IsValid;

	private static FFieldAddress RemoveOnMaxSleep_PropertyAddress;

	private static int RemoveOnMaxSleep_Offset;

	private static bool MaximumSleepTime_IsValid;

	private static int MaximumSleepTime_Offset;

	private static bool RemovalDuration_IsValid;

	private static int RemovalDuration_Offset;

	private static bool EnableRemovePiecesOnFracture_IsValid;

	private static FFieldAddress EnableRemovePiecesOnFracture_PropertyAddress;

	private static int EnableRemovePiecesOnFracture_Offset;

	[UProperty(Flags = (PropFlags)4503633987109381uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:GeometrySource")]
	public TArrayReadWrite<FGeometryCollectionSource> GeometrySource
	{
		get
		{
			CheckDestroyed();
			if (!GeometrySource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:GeometrySource");
				return null;
			}
			if (GeometrySource_MarshalerCached == null)
			{
				GeometrySource_MarshalerCached = new TArrayReadWriteMarshaler<FGeometryCollectionSource>(1, GeometrySource_PropertyAddress, CachedMarshalingDelegates<FGeometryCollectionSource, FGeometryCollectionSource>.FromNative, CachedMarshalingDelegates<FGeometryCollectionSource, FGeometryCollectionSource>.ToNative);
			}
			return GeometrySource_MarshalerCached.FromNative(IntPtr.Add(base.Address, GeometrySource_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:EnableNanite")]
	public bool EnableNanite
	{
		get
		{
			CheckDestroyed();
			if (!EnableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:EnableNanite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:EnableNanite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:bMassAsDensity")]
	public bool MassAsDensity
	{
		get
		{
			CheckDestroyed();
			if (!MassAsDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:bMassAsDensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MassAsDensity_Offset), 0, MassAsDensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MassAsDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:bMassAsDensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MassAsDensity_Offset), 0, MassAsDensity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:Mass")]
	public float Mass
	{
		get
		{
			CheckDestroyed();
			if (!Mass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:Mass");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Mass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:Mass");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Mass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:MinimumMassClamp")]
	public float MinimumMassClamp
	{
		get
		{
			CheckDestroyed();
			if (!MinimumMassClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:MinimumMassClamp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumMassClamp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumMassClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:MinimumMassClamp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumMassClamp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:bRemoveOnMaxSleep")]
	public bool RemoveOnMaxSleep
	{
		get
		{
			CheckDestroyed();
			if (!RemoveOnMaxSleep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:bRemoveOnMaxSleep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RemoveOnMaxSleep_Offset), 0, RemoveOnMaxSleep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RemoveOnMaxSleep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:bRemoveOnMaxSleep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RemoveOnMaxSleep_Offset), 0, RemoveOnMaxSleep_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:MaximumSleepTime")]
	public FVector2D MaximumSleepTime
	{
		get
		{
			CheckDestroyed();
			if (!MaximumSleepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:MaximumSleepTime");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, MaximumSleepTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumSleepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:MaximumSleepTime");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, MaximumSleepTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:RemovalDuration")]
	public FVector2D RemovalDuration
	{
		get
		{
			CheckDestroyed();
			if (!RemovalDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:RemovalDuration");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RemovalDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RemovalDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:RemovalDuration");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RemovalDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollection:EnableRemovePiecesOnFracture")]
	public bool EnableRemovePiecesOnFracture
	{
		get
		{
			CheckDestroyed();
			if (!EnableRemovePiecesOnFracture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:EnableRemovePiecesOnFracture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRemovePiecesOnFracture_Offset), 0, EnableRemovePiecesOnFracture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRemovePiecesOnFracture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollection:EnableRemovePiecesOnFracture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRemovePiecesOnFracture_Offset), 0, EnableRemovePiecesOnFracture_PropertyAddress.Address, value);
			}
		}
	}

	static UGeometryCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GeometryCollectionEngine.GeometryCollection");
		NativeReflectionCached.GetPropertyRef(ref GeometrySource_PropertyAddress, unrealStruct, "GeometrySource");
		GeometrySource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GeometrySource");
		GeometrySource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GeometrySource", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNanite_PropertyAddress, unrealStruct, "EnableNanite");
		EnableNanite_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableNanite");
		EnableNanite_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableNanite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MassAsDensity_PropertyAddress, unrealStruct, "bMassAsDensity");
		MassAsDensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMassAsDensity");
		MassAsDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMassAsDensity", Classes.FBoolProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mass", Classes.FFloatProperty);
		MinimumMassClamp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinimumMassClamp");
		MinimumMassClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinimumMassClamp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveOnMaxSleep_PropertyAddress, unrealStruct, "bRemoveOnMaxSleep");
		RemoveOnMaxSleep_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRemoveOnMaxSleep");
		RemoveOnMaxSleep_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRemoveOnMaxSleep", Classes.FBoolProperty);
		MaximumSleepTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaximumSleepTime");
		MaximumSleepTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaximumSleepTime", Classes.FStructProperty);
		RemovalDuration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RemovalDuration");
		RemovalDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RemovalDuration", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRemovePiecesOnFracture_PropertyAddress, unrealStruct, "EnableRemovePiecesOnFracture");
		EnableRemovePiecesOnFracture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableRemovePiecesOnFracture");
		EnableRemovePiecesOnFracture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableRemovePiecesOnFracture", Classes.FBoolProperty);
	}
}
