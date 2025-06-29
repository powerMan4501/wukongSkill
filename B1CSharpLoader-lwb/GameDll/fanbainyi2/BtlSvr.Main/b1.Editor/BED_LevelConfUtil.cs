using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1.Editor;

[UClass]
[USharpPath("/Script/b1-Managed.BED_LevelConfUtil")]
public class BED_LevelConfUtil : UBlueprintFunctionLibrary
{
	private static bool GetLevelStreamingBoundingBox_IsValid;

	private static IntPtr GetLevelStreamingBoundingBox_FunctionAddress;

	private static int GetLevelStreamingBoundingBox_ParamsSize;

	private static bool GetLevelStreamingBoundingBox_LevelStreaming_IsValid;

	private static int GetLevelStreamingBoundingBox_LevelStreaming_Offset;

	private static bool GetLevelStreamingBoundingBox_Center_IsValid;

	private static int GetLevelStreamingBoundingBox_Center_Offset;

	private static FFieldAddress GetLevelStreamingBoundingBox_Center_PropertyAddress;

	private static bool GetLevelStreamingBoundingBox_BoxExtent_IsValid;

	private static int GetLevelStreamingBoundingBox_BoxExtent_Offset;

	private static FFieldAddress GetLevelStreamingBoundingBox_BoxExtent_PropertyAddress;

	public static void GetLevelStreamingVolume(ULevelStreaming LevelStreaming, out FBox Volume)
	{
		Volume = UBGUFunctionLibrary.GetStreamingVolumeBounds(LevelStreaming);
	}

	public static void GetLandscapeVolume(ULevelStreaming LevelStreaming, out FBox Volume, out FVector LandscapeLocation)
	{
		Volume = default(FBox);
		LandscapeLocation = FVector.ZeroVector;
		bool flag = false;
		ULevel loadedLevel = LevelStreaming.GetLoadedLevel();
		if (loadedLevel == null)
		{
			return;
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(loadedLevel);
		new List<AActor>();
		foreach (AActor aActor in allActorsOfClass)
		{
			if (!(aActor.GetOutermost().GetName() == LevelStreaming.GetWorldAssetPackageFName().ToString()))
			{
				continue;
			}
			ALandscape aLandscape = aActor as ALandscape;
			if (aLandscape != null)
			{
				LandscapeLocation = aLandscape.GetActorLocation();
				aLandscape.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
				FBox fBox = new FBox
				{
					Min = Origin - BoxExtent,
					Max = Origin + BoxExtent
				};
				if (flag)
				{
					Volume += fBox;
					continue;
				}
				flag = true;
				Volume = fBox;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("B1Editor|Level")]
	[USharpPath("/Script/b1-Managed.BED_LevelConfUtil:GetLevelStreamingBoundingBox")]
	public static void GetLevelStreamingBoundingBox(ULevelStreaming LevelStreaming, out FVector Center, out FVector BoxExtent)
	{
		Center = (BoxExtent = FVector.ZeroVector);
		ULevel loadedLevel = LevelStreaming.GetLoadedLevel();
		if (loadedLevel == null)
		{
			return;
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(loadedLevel);
		List<AActor> list = new List<AActor>();
		foreach (AActor aActor in allActorsOfClass)
		{
			if (aActor != null && aActor.GetOutermost().GetName() == LevelStreaming.GetWorldAssetPackageFName().ToString())
			{
				list.Add(aActor);
			}
		}
		UGameplayStatics.GetActorArrayBounds(list, bOnlyCollidingComponents: true, out Center, out BoxExtent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_LevelConfUtil:GetLevelStreamingBoundingBox")]
	private static void GetLevelStreamingBoundingBox__Invoker(IntPtr buffer, IntPtr obj)
	{
		ULevelStreaming levelStreaming = UObjectMarshaler<ULevelStreaming>.FromNative(IntPtr.Add(buffer, GetLevelStreamingBoundingBox_LevelStreaming_Offset));
		GetLevelStreamingBoundingBox(levelStreaming, out var Center, out var BoxExtent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, GetLevelStreamingBoundingBox_Center_Offset), Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, GetLevelStreamingBoundingBox_BoxExtent_Offset), BoxExtent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_LevelConfUtil");
		GetLevelStreamingBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelStreamingBoundingBox");
		GetLevelStreamingBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingBoundingBox_FunctionAddress);
		GetLevelStreamingBoundingBox_LevelStreaming_Offset = NativeReflection.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "LevelStreaming");
		GetLevelStreamingBoundingBox_LevelStreaming_IsValid = NativeReflection.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "LevelStreaming", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetLevelStreamingBoundingBox_Center_PropertyAddress, GetLevelStreamingBoundingBox_FunctionAddress, "Center");
		GetLevelStreamingBoundingBox_Center_Offset = NativeReflection.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "Center");
		GetLevelStreamingBoundingBox_Center_IsValid = NativeReflection.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetLevelStreamingBoundingBox_BoxExtent_PropertyAddress, GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent");
		GetLevelStreamingBoundingBox_BoxExtent_Offset = NativeReflection.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent");
		GetLevelStreamingBoundingBox_BoxExtent_IsValid = NativeReflection.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		GetLevelStreamingBoundingBox_IsValid = GetLevelStreamingBoundingBox_FunctionAddress != IntPtr.Zero && GetLevelStreamingBoundingBox_LevelStreaming_IsValid && GetLevelStreamingBoundingBox_Center_IsValid && GetLevelStreamingBoundingBox_BoxExtent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_LevelConfUtil:GetLevelStreamingBoundingBox", GetLevelStreamingBoundingBox_IsValid);
	}

	static BED_LevelConfUtil()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_LevelConfUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_LevelConfUtil));
	}
}
