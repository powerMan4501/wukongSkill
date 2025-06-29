using System;
using b1.GameState.Data;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp")]
public class BUS_AudioEmitterEditComp : UActorEditCompBase
{
	private static bool bDebug_IsValid;

	private static int bDebug_Offset;

	private static FFieldAddress bDebug_PropertyAddress;

	private static bool bDebugLog_IsValid;

	private static int bDebugLog_Offset;

	private static FFieldAddress bDebugLog_PropertyAddress;

	private static bool bHiddenInGame_IsValid;

	private static int bHiddenInGame_Offset;

	private static FFieldAddress bHiddenInGame_PropertyAddress;

	private static bool bFollowPlayerElevation_IsValid;

	private static int bFollowPlayerElevation_Offset;

	private static FFieldAddress bFollowPlayerElevation_PropertyAddress;

	private static bool AkEventEmitter_IsValid;

	private static int AkEventEmitter_Offset;

	private static bool EmitterHeight_IsValid;

	private static int EmitterHeight_Offset;

	private static bool SwitchGroup_IsValid;

	private static int SwitchGroup_Offset;

	private static bool SwitchStateInside_IsValid;

	private static int SwitchStateInside_Offset;

	private static bool SwitchStateOutside_IsValid;

	private static int SwitchStateOutside_Offset;

	private static bool OccRefreshInterval_IsValid;

	private static int OccRefreshInterval_Offset;

	private static bool MaxRangeFadeDistance_IsValid;

	private static int MaxRangeFadeDistance_Offset;

	private static bool WallHeight_IsValid;

	private static int WallHeight_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebug")]
	public bool bDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDebug_Offset), 0, bDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDebug_Offset), 0, bDebug_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebugLog")]
	public bool bDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!bDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDebugLog_Offset), 0, bDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDebugLog_Offset), 0, bDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Audio Emitter")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:bHiddenInGame")]
	public bool bHiddenInGame
	{
		get
		{
			CheckDestroyed();
			if (!bHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bHiddenInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHiddenInGame_Offset), 0, bHiddenInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bHiddenInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHiddenInGame_Offset), 0, bHiddenInGame_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Audio Emitter")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:bFollowPlayerElevation")]
	public bool bFollowPlayerElevation
	{
		get
		{
			CheckDestroyed();
			if (!bFollowPlayerElevation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bFollowPlayerElevation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFollowPlayerElevation_Offset), 0, bFollowPlayerElevation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFollowPlayerElevation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:bFollowPlayerElevation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFollowPlayerElevation_Offset), 0, bFollowPlayerElevation_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:AkEventEmitter")]
	public UAkAudioEvent AkEventEmitter
	{
		get
		{
			CheckDestroyed();
			if (!AkEventEmitter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:AkEventEmitter");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEventEmitter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEventEmitter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:AkEventEmitter");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEventEmitter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:EmitterHeight")]
	public float EmitterHeight
	{
		get
		{
			CheckDestroyed();
			if (!EmitterHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:EmitterHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EmitterHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EmitterHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:EmitterHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EmitterHeight_Offset), value);
			}
		}
	}

	[Category("Audio Emitter")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchGroup")]
	public FName SwitchGroup
	{
		get
		{
			CheckDestroyed();
			if (!SwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchGroup");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SwitchGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchGroup");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SwitchGroup_Offset), value);
			}
		}
	}

	[Category("Audio Emitter")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateInside")]
	public FName SwitchStateInside
	{
		get
		{
			CheckDestroyed();
			if (!SwitchStateInside_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateInside");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SwitchStateInside_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchStateInside_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateInside");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SwitchStateInside_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateOutside")]
	public FName SwitchStateOutside
	{
		get
		{
			CheckDestroyed();
			if (!SwitchStateOutside_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateOutside");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SwitchStateOutside_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchStateOutside_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:SwitchStateOutside");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SwitchStateOutside_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:OccRefreshInterval")]
	public float OccRefreshInterval
	{
		get
		{
			CheckDestroyed();
			if (!OccRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:OccRefreshInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OccRefreshInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OccRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:OccRefreshInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OccRefreshInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio Emitter")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:MaxRangeFadeDistance")]
	public float MaxRangeFadeDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxRangeFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:MaxRangeFadeDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRangeFadeDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRangeFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:MaxRangeFadeDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRangeFadeDistance_Offset), value);
			}
		}
	}

	[Category("Audio Emitter")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_AudioEmitterEditComp:WallHeight")]
	public float WallHeight
	{
		get
		{
			CheckDestroyed();
			if (!WallHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:WallHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WallHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WallHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEmitterEditComp:WallHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WallHeight_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SwitchGroup = B1GlobalFNames.state_dampning;
		MaxRangeFadeDistance = 8000f;
		WallHeight = 50f;
		EmitterHeight = 0f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_AudioEmitterData bUC_AudioEmitterData = RequireWritableData<BUC_AudioEmitterData>();
		FVector actorLocation = Owner.GetActorLocation();
		USplineComponent componentByClass = Owner.GetComponentByClass<USplineComponent>();
		float num = 1000f;
		int numberOfSplinePoints = componentByClass.GetNumberOfSplinePoints();
		for (int i = 0; i < numberOfSplinePoints; i++)
		{
			FVector locationAtSplinePoint = componentByClass.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World);
			num = Math.Max(num, (locationAtSplinePoint - actorLocation).Size2D());
		}
		FAudioEmitter audioEmitter = new FAudioEmitter
		{
			bDebug = bDebug,
			bDebugLog = bDebugLog,
			bFollowPlayerElevation = bFollowPlayerElevation,
			AkEventEmitter = AkEventEmitter,
			StateGroup = SwitchGroup,
			StateInside = SwitchStateInside,
			StateOutside = SwitchStateOutside,
			OccRefreshInterval = OccRefreshInterval,
			MaxRangeFadeDistance = MaxRangeFadeDistance,
			EmitterHeight = EmitterHeight,
			EmitterLocation = actorLocation,
			MinHeightLimit = actorLocation.Z,
			MaxHeightLimit = actorLocation.Z + WallHeight * 100f,
			AkComponent = Owner.GetComponentByClass<UAkComponent>(),
			SplineComponent = componentByClass,
			LazyDistance = num
		};
		bUC_AudioEmitterData.AudioEmitter = audioEmitter;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioEmitterEditComp");
		NativeReflection.GetPropertyRef(ref bDebug_PropertyAddress, unrealStruct, "bDebug");
		bDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDebug");
		bDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDebugLog_PropertyAddress, unrealStruct, "bDebugLog");
		bDebugLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDebugLog");
		bDebugLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDebugLog", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHiddenInGame_PropertyAddress, unrealStruct, "bHiddenInGame");
		bHiddenInGame_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHiddenInGame");
		bHiddenInGame_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHiddenInGame", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFollowPlayerElevation_PropertyAddress, unrealStruct, "bFollowPlayerElevation");
		bFollowPlayerElevation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFollowPlayerElevation");
		bFollowPlayerElevation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFollowPlayerElevation", Classes.FBoolProperty);
		AkEventEmitter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEventEmitter");
		AkEventEmitter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEventEmitter", Classes.FObjectProperty);
		EmitterHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EmitterHeight");
		EmitterHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EmitterHeight", Classes.FFloatProperty);
		SwitchGroup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SwitchGroup");
		SwitchGroup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SwitchGroup", Classes.FNameProperty);
		SwitchStateInside_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SwitchStateInside");
		SwitchStateInside_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SwitchStateInside", Classes.FNameProperty);
		SwitchStateOutside_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SwitchStateOutside");
		SwitchStateOutside_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SwitchStateOutside", Classes.FNameProperty);
		OccRefreshInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OccRefreshInterval");
		OccRefreshInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OccRefreshInterval", Classes.FFloatProperty);
		MaxRangeFadeDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxRangeFadeDistance");
		MaxRangeFadeDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxRangeFadeDistance", Classes.FFloatProperty);
		WallHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WallHeight");
		WallHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WallHeight", Classes.FFloatProperty);
	}

	static BUS_AudioEmitterEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AudioEmitterEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AudioEmitterEditComp));
	}
}
