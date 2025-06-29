using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetNaniteSettingsOperation : UDataprepOperation
{
	private static bool NaniteEnabled_IsValid;

	private static FFieldAddress NaniteEnabled_PropertyAddress;

	private static int NaniteEnabled_Offset;

	private static bool PositionPrecision_IsValid;

	private static int PositionPrecision_Offset;

	private static bool PercentTriangles_IsValid;

	private static int PercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:bNaniteEnabled")]
	public bool NaniteEnabled
	{
		get
		{
			CheckDestroyed();
			if (!NaniteEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:bNaniteEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NaniteEnabled_Offset), 0, NaniteEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NaniteEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:bNaniteEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NaniteEnabled_Offset), 0, NaniteEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PositionPrecision")]
	public int PositionPrecision
	{
		get
		{
			CheckDestroyed();
			if (!PositionPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PositionPrecision");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PositionPrecision_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PositionPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PositionPrecision");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PositionPrecision_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PercentTriangles")]
	public float PercentTriangles
	{
		get
		{
			CheckDestroyed();
			if (!PercentTriangles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PercentTriangles");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PercentTriangles_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PercentTriangles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation:PercentTriangles");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PercentTriangles_Offset), value);
			}
		}
	}

	static UDataprepSetNaniteSettingsOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetNaniteSettingsOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetNaniteSettingsOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetNaniteSettingsOperation");
		NativeReflectionCached.GetPropertyRef(ref NaniteEnabled_PropertyAddress, unrealStruct, "bNaniteEnabled");
		NaniteEnabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bNaniteEnabled");
		NaniteEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bNaniteEnabled", Classes.FBoolProperty);
		PositionPrecision_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PositionPrecision");
		PositionPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PositionPrecision", Classes.FIntProperty);
		PercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PercentTriangles");
		PercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PercentTriangles", Classes.FFloatProperty);
	}
}
