using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/Water.SphericalPontoon", "Water", UnrealModuleType.EnginePlugin)]
public struct FSphericalPontoon
{
	private static bool CenterSocket_IsValid;

	private static int CenterSocket_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:CenterSocket")]
	public FName CenterSocket;

	private static bool RelativeLocation_IsValid;

	private static int RelativeLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:RelativeLocation")]
	public FVector RelativeLocation;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:Radius")]
	public float Radius;

	private static bool LocalForce_IsValid;

	private static int LocalForce_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:LocalForce")]
	public FVector LocalForce;

	private static bool CenterLocation_IsValid;

	private static int CenterLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:CenterLocation")]
	public FVector CenterLocation;

	private static bool SocketRotation_IsValid;

	private static int SocketRotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589076uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:SocketRotation")]
	public FQuat SocketRotation;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:Offset")]
	public FVector Offset;

	private static bool WaterHeight_IsValid;

	private static int WaterHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterHeight")]
	public float WaterHeight;

	private static bool WaterDepth_IsValid;

	private static int WaterDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterDepth")]
	public float WaterDepth;

	private static bool ImmersionDepth_IsValid;

	private static int ImmersionDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:ImmersionDepth")]
	public float ImmersionDepth;

	private static bool WaterPlaneLocation_IsValid;

	private static int WaterPlaneLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterPlaneLocation")]
	public FVector WaterPlaneLocation;

	private static bool WaterPlaneNormal_IsValid;

	private static int WaterPlaneNormal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterPlaneNormal")]
	public FVector WaterPlaneNormal;

	private static bool WaterSurfacePosition_IsValid;

	private static int WaterSurfacePosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterSurfacePosition")]
	public FVector WaterSurfacePosition;

	private static bool WaterVelocity_IsValid;

	private static int WaterVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterVelocity")]
	public FVector WaterVelocity;

	private static bool WaterBodyIndex_IsValid;

	private static int WaterBodyIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:WaterBodyIndex")]
	public int WaterBodyIndex;

	private static bool CurrentWaterBodyComponent_IsValid;

	private static int CurrentWaterBodyComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234807324uL)]
	[UMetaPath("/Script/Water.SphericalPontoon:CurrentWaterBodyComponent")]
	public UWaterBodyComponent CurrentWaterBodyComponent;

	private static bool FSphericalPontoon_IsValid;

	private static int FSphericalPontoon_StructSize;

	public FSphericalPontoon Copy()
	{
		return this;
	}

	public static FSphericalPontoon FromNative(IntPtr nativeBuffer)
	{
		return new FSphericalPontoon(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSphericalPontoon value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSphericalPontoon FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSphericalPontoon(nativeBuffer + arrayIndex * FSphericalPontoon_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSphericalPontoon value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSphericalPontoon_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSphericalPontoon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.SphericalPontoon");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CenterSocket_Offset), CenterSocket);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RelativeLocation_Offset), RelativeLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocalForce_Offset), LocalForce);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, CenterLocation_Offset), CenterLocation);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(nativeStruct, SocketRotation_Offset), SocketRotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaterHeight_Offset), WaterHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaterDepth_Offset), WaterDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ImmersionDepth_Offset), ImmersionDepth);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, WaterPlaneLocation_Offset), WaterPlaneLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, WaterPlaneNormal_Offset), WaterPlaneNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, WaterSurfacePosition_Offset), WaterSurfacePosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, WaterVelocity_Offset), WaterVelocity);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, WaterBodyIndex_Offset), WaterBodyIndex);
		UObjectMarshaler<UWaterBodyComponent>.ToNative(IntPtr.Add(nativeStruct, CurrentWaterBodyComponent_Offset), CurrentWaterBodyComponent);
	}

	public FSphericalPontoon(IntPtr nativeStruct)
	{
		if (!FSphericalPontoon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.SphericalPontoon");
			CenterSocket = default(FName);
			RelativeLocation = default(FVector);
			Radius = 0f;
			LocalForce = default(FVector);
			CenterLocation = default(FVector);
			SocketRotation = default(FQuat);
			Offset = default(FVector);
			WaterHeight = 0f;
			WaterDepth = 0f;
			ImmersionDepth = 0f;
			WaterPlaneLocation = default(FVector);
			WaterPlaneNormal = default(FVector);
			WaterSurfacePosition = default(FVector);
			WaterVelocity = default(FVector);
			WaterBodyIndex = 0;
			CurrentWaterBodyComponent = null;
		}
		else
		{
			CenterSocket = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CenterSocket_Offset));
			RelativeLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RelativeLocation_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			LocalForce = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocalForce_Offset));
			CenterLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, CenterLocation_Offset));
			SocketRotation = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(nativeStruct, SocketRotation_Offset));
			Offset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
			WaterHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaterHeight_Offset));
			WaterDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaterDepth_Offset));
			ImmersionDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ImmersionDepth_Offset));
			WaterPlaneLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, WaterPlaneLocation_Offset));
			WaterPlaneNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, WaterPlaneNormal_Offset));
			WaterSurfacePosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, WaterSurfacePosition_Offset));
			WaterVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, WaterVelocity_Offset));
			WaterBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, WaterBodyIndex_Offset));
			CurrentWaterBodyComponent = UObjectMarshaler<UWaterBodyComponent>.FromNative(IntPtr.Add(nativeStruct, CurrentWaterBodyComponent_Offset));
		}
	}

	static FSphericalPontoon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSphericalPontoon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSphericalPontoon));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.SphericalPontoon");
		FSphericalPontoon_StructSize = NativeReflection.GetStructSize(intPtr);
		CenterSocket_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CenterSocket");
		CenterSocket_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CenterSocket", Classes.FNameProperty);
		RelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeLocation");
		RelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeLocation", Classes.FStructProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		LocalForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalForce");
		LocalForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalForce", Classes.FStructProperty);
		CenterLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CenterLocation");
		CenterLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CenterLocation", Classes.FStructProperty);
		SocketRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketRotation");
		SocketRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketRotation", Classes.FStructProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		WaterHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterHeight");
		WaterHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterHeight", Classes.FFloatProperty);
		WaterDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterDepth");
		WaterDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterDepth", Classes.FFloatProperty);
		ImmersionDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImmersionDepth");
		ImmersionDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImmersionDepth", Classes.FFloatProperty);
		WaterPlaneLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterPlaneLocation");
		WaterPlaneLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterPlaneLocation", Classes.FStructProperty);
		WaterPlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterPlaneNormal");
		WaterPlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterPlaneNormal", Classes.FStructProperty);
		WaterSurfacePosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterSurfacePosition");
		WaterSurfacePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterSurfacePosition", Classes.FStructProperty);
		WaterVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterVelocity");
		WaterVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterVelocity", Classes.FStructProperty);
		WaterBodyIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterBodyIndex");
		WaterBodyIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterBodyIndex", Classes.FIntProperty);
		CurrentWaterBodyComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentWaterBodyComponent");
		CurrentWaterBodyComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentWaterBodyComponent", Classes.FObjectProperty);
		FSphericalPontoon_IsValid = intPtr != IntPtr.Zero && CenterSocket_IsValid && RelativeLocation_IsValid && Radius_IsValid && LocalForce_IsValid && CenterLocation_IsValid && SocketRotation_IsValid && Offset_IsValid && WaterHeight_IsValid && WaterDepth_IsValid && ImmersionDepth_IsValid && WaterPlaneLocation_IsValid && WaterPlaneNormal_IsValid && WaterSurfacePosition_IsValid && WaterVelocity_IsValid && WaterBodyIndex_IsValid && CurrentWaterBodyComponent_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.SphericalPontoon", FSphericalPontoon_IsValid);
	}
}
