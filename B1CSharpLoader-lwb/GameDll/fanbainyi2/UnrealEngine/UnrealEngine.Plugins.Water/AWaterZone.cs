using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.WaterZone", "Water", UnrealModuleType.EnginePlugin)]
public class AWaterZone : AActor
{
	private static bool WaterVelocityTexture_IsValid;

	private static int WaterVelocityTexture_Offset;

	private static bool BoundsComponent_IsValid;

	private static int BoundsComponent_Offset;

	private static bool WaterMesh_IsValid;

	private static int WaterMesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Water.WaterZone:WaterVelocityTexture")]
	public UTexture2D WaterVelocityTexture
	{
		get
		{
			CheckDestroyed();
			if (!WaterVelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:WaterVelocityTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, WaterVelocityTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterVelocityTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:WaterVelocityTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, WaterVelocityTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268117041693uL)]
	[UMetaPath("/Script/Water.WaterZone:BoundsComponent")]
	public UBoxComponent BoundsComponent
	{
		get
		{
			CheckDestroyed();
			if (!BoundsComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:BoundsComponent");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoundsComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundsComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:BoundsComponent");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoundsComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268117041693uL)]
	[UMetaPath("/Script/Water.WaterZone:WaterMesh")]
	public UWaterMeshComponent WaterMesh
	{
		get
		{
			CheckDestroyed();
			if (!WaterMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:WaterMesh");
				return null;
			}
			return UObjectMarshaler<UWaterMeshComponent>.FromNative(IntPtr.Add(base.Address, WaterMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterZone:WaterMesh");
			}
			else
			{
				UObjectMarshaler<UWaterMeshComponent>.ToNative(IntPtr.Add(base.Address, WaterMesh_Offset), value);
			}
		}
	}

	static AWaterZone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWaterZone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWaterZone));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Water.WaterZone");
		WaterVelocityTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WaterVelocityTexture");
		WaterVelocityTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WaterVelocityTexture", Classes.FObjectProperty);
		BoundsComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoundsComponent");
		BoundsComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoundsComponent", Classes.FObjectProperty);
		WaterMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WaterMesh");
		WaterMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WaterMesh", Classes.FObjectProperty);
	}
}
