using System;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo")]
public struct FDispInteractLandscapeInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:Landscape")]
	public ALandscape Landscape;

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:LS_HeightMap")]
	public UTexture2D LS_HeightMap;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:LS_WeightMap")]
	public UTexture2D LS_WeightMap;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:_LandscapeOriginOffset")]
	public FVector _LandscapeOriginOffset;

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:VertexCount_Width")]
	public int VertexCount_Width;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:VertexCount_Height")]
	public int VertexCount_Height;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:MaxHeight")]
	public float MaxHeight;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:SimulationSize_cm")]
	public float SimulationSize_cm;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:InteractiveData_StorageSize_cm")]
	public float InteractiveData_StorageSize_cm;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractLandscapeInfo:InteractDistLimitToDispActor")]
	public float InteractDistLimitToDispActor;

	private static int DispInteractLandscapeInfo_StructSize;

	private static int DispInteractLandscapeInfo_IsValid;

	private static bool Landscape_IsValid;

	private static int Landscape_Offset;

	private static bool LS_HeightMap_IsValid;

	private static int LS_HeightMap_Offset;

	private static bool LS_WeightMap_IsValid;

	private static int LS_WeightMap_Offset;

	private static bool _LandscapeOriginOffset_IsValid;

	private static int _LandscapeOriginOffset_Offset;

	private static bool VertexCount_Width_IsValid;

	private static int VertexCount_Width_Offset;

	private static bool VertexCount_Height_IsValid;

	private static int VertexCount_Height_Offset;

	private static bool MaxHeight_IsValid;

	private static int MaxHeight_Offset;

	private static bool SimulationSize_cm_IsValid;

	private static int SimulationSize_cm_Offset;

	private static bool InteractiveData_StorageSize_cm_IsValid;

	private static int InteractiveData_StorageSize_cm_Offset;

	private static bool InteractDistLimitToDispActor_IsValid;

	private static int InteractDistLimitToDispActor_Offset;

	public FDispInteractLandscapeInfo Copy()
	{
		return this;
	}

	public static FDispInteractLandscapeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDispInteractLandscapeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDispInteractLandscapeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDispInteractLandscapeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDispInteractLandscapeInfo(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractLandscapeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDispInteractLandscapeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractLandscapeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DispInteractLandscapeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractLandscapeInfo");
			return;
		}
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(nativeStruct, Landscape_Offset), Landscape);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, LS_HeightMap_Offset), LS_HeightMap);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, LS_WeightMap_Offset), LS_WeightMap);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, _LandscapeOriginOffset_Offset), _LandscapeOriginOffset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, VertexCount_Width_Offset), VertexCount_Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, VertexCount_Height_Offset), VertexCount_Height);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxHeight_Offset), MaxHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SimulationSize_cm_Offset), SimulationSize_cm);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteractiveData_StorageSize_cm_Offset), InteractiveData_StorageSize_cm);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteractDistLimitToDispActor_Offset), InteractDistLimitToDispActor);
	}

	public FDispInteractLandscapeInfo(IntPtr nativeStruct)
	{
		if (DispInteractLandscapeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractLandscapeInfo");
			Landscape = null;
			LS_HeightMap = null;
			LS_WeightMap = null;
			_LandscapeOriginOffset = default(FVector);
			VertexCount_Width = 0;
			VertexCount_Height = 0;
			MaxHeight = 0f;
			SimulationSize_cm = 0f;
			InteractiveData_StorageSize_cm = 0f;
			InteractDistLimitToDispActor = 0f;
		}
		else
		{
			Landscape = UObjectMarshaler<ALandscape>.FromNative(IntPtr.Add(nativeStruct, Landscape_Offset));
			LS_HeightMap = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, LS_HeightMap_Offset));
			LS_WeightMap = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, LS_WeightMap_Offset));
			_LandscapeOriginOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, _LandscapeOriginOffset_Offset));
			VertexCount_Width = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, VertexCount_Width_Offset));
			VertexCount_Height = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, VertexCount_Height_Offset));
			MaxHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxHeight_Offset));
			SimulationSize_cm = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SimulationSize_cm_Offset));
			InteractiveData_StorageSize_cm = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteractiveData_StorageSize_cm_Offset));
			InteractDistLimitToDispActor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteractDistLimitToDispActor_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DispInteractLandscapeInfo");
		DispInteractLandscapeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Landscape_Offset = NativeReflection.GetPropertyOffset(intPtr, "Landscape");
		Landscape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Landscape", Classes.FObjectProperty);
		LS_HeightMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "LS_HeightMap");
		LS_HeightMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LS_HeightMap", Classes.FObjectProperty);
		LS_WeightMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "LS_WeightMap");
		LS_WeightMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LS_WeightMap", Classes.FObjectProperty);
		_LandscapeOriginOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "_LandscapeOriginOffset");
		_LandscapeOriginOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "_LandscapeOriginOffset", Classes.FStructProperty);
		VertexCount_Width_Offset = NativeReflection.GetPropertyOffset(intPtr, "VertexCount_Width");
		VertexCount_Width_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VertexCount_Width", Classes.FIntProperty);
		VertexCount_Height_Offset = NativeReflection.GetPropertyOffset(intPtr, "VertexCount_Height");
		VertexCount_Height_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VertexCount_Height", Classes.FIntProperty);
		MaxHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxHeight");
		MaxHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxHeight", Classes.FFloatProperty);
		SimulationSize_cm_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimulationSize_cm");
		SimulationSize_cm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimulationSize_cm", Classes.FFloatProperty);
		InteractiveData_StorageSize_cm_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractiveData_StorageSize_cm");
		InteractiveData_StorageSize_cm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractiveData_StorageSize_cm", Classes.FFloatProperty);
		InteractDistLimitToDispActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractDistLimitToDispActor");
		InteractDistLimitToDispActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractDistLimitToDispActor", Classes.FFloatProperty);
		DispInteractLandscapeInfo_IsValid = ((intPtr != IntPtr.Zero && Landscape_IsValid && LS_HeightMap_IsValid && LS_WeightMap_IsValid && _LandscapeOriginOffset_IsValid && VertexCount_Width_IsValid && VertexCount_Height_IsValid && MaxHeight_IsValid && SimulationSize_cm_IsValid && InteractiveData_StorageSize_cm_IsValid && InteractDistLimitToDispActor_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DispInteractLandscapeInfo", (byte)DispInteractLandscapeInfo_IsValid != 0);
	}

	static FDispInteractLandscapeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDispInteractLandscapeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDispInteractLandscapeInfo));
	}
}
