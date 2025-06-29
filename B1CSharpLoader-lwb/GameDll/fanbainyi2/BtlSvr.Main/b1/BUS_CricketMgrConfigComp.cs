using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp")]
public class BUS_CricketMgrConfigComp : UActorEditCompBase
{
	private static bool CricketTamer_IsValid;

	private static int CricketTamer_Offset;

	private static bool SpawnProbability_IsValid;

	private static int SpawnProbability_Offset;

	private static bool SpawnDelayTimeRange_IsValid;

	private static int SpawnDelayTimeRange_Offset;

	private static bool TrySpawnMaxCount_IsValid;

	private static int TrySpawnMaxCount_Offset;

	private static bool ReSpawnDelayTime_IsValid;

	private static int ReSpawnDelayTime_Offset;

	private static bool MovePointConfig_IsValid;

	private static int MovePointConfig_Offset;

	private static FFieldAddress MovePointConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FCricketMovePointConfig> MovePointConfig_Marshaler;

	private static bool LeaveFightDistance_IsValid;

	private static int LeaveFightDistance_Offset;

	private static bool LeaveFightDelayTime_IsValid;

	private static int LeaveFightDelayTime_Offset;

	private static bool InteractConfig_IsValid;

	private static int InteractConfig_Offset;

	private static bool ASWeakIdle_IsValid;

	private static int ASWeakIdle_Offset;

	private static bool WeakDuration_IsValid;

	private static int WeakDuration_Offset;

	private static bool NormalLongPressInteractGroupID_IsValid;

	private static int NormalLongPressInteractGroupID_Offset;

	private static bool WeakLongPressInteractGroupID_IsValid;

	private static int WeakLongPressInteractGroupID_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:CricketTamer")]
	public TSubclassOf<BUTamerActor> CricketTamer
	{
		get
		{
			CheckDestroyed();
			if (!CricketTamer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:CricketTamer");
				return default(TSubclassOf<BUTamerActor>);
			}
			return TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, CricketTamer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CricketTamer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:CricketTamer");
			}
			else
			{
				TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, CricketTamer_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.ClampMax, 1f)]
	[Category("Cricket Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnProbability")]
	public float SpawnProbability
	{
		get
		{
			CheckDestroyed();
			if (!SpawnProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnProbability");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnProbability");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnProbability_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnDelayTimeRange")]
	public FVector2D SpawnDelayTimeRange
	{
		get
		{
			CheckDestroyed();
			if (!SpawnDelayTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnDelayTimeRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, SpawnDelayTimeRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnDelayTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:SpawnDelayTimeRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, SpawnDelayTimeRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:TrySpawnMaxCount")]
	public int TrySpawnMaxCount
	{
		get
		{
			CheckDestroyed();
			if (!TrySpawnMaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:TrySpawnMaxCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TrySpawnMaxCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrySpawnMaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:TrySpawnMaxCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TrySpawnMaxCount_Offset), value);
			}
		}
	}

	[Category("Cricket Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:ReSpawnDelayTime")]
	public float ReSpawnDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!ReSpawnDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:ReSpawnDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ReSpawnDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReSpawnDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:ReSpawnDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ReSpawnDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Cricket Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:MovePointConfig")]
	public TArrayReadWrite<FCricketMovePointConfig> MovePointConfig
	{
		get
		{
			CheckDestroyed();
			if (!MovePointConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:MovePointConfig");
				return null;
			}
			if (MovePointConfig_Marshaler == null)
			{
				MovePointConfig_Marshaler = new TArrayReadWriteMarshaler<FCricketMovePointConfig>(1, MovePointConfig_PropertyAddress, CachedMarshalingDelegates<FCricketMovePointConfig, FCricketMovePointConfig>.FromNative, CachedMarshalingDelegates<FCricketMovePointConfig, FCricketMovePointConfig>.ToNative);
			}
			return MovePointConfig_Marshaler.FromNative(IntPtr.Add(base.Address, MovePointConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDistance")]
	public float LeaveFightDistance
	{
		get
		{
			CheckDestroyed();
			if (!LeaveFightDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeaveFightDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeaveFightDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeaveFightDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDelayTime")]
	public float LeaveFightDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!LeaveFightDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeaveFightDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeaveFightDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:LeaveFightDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeaveFightDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Cricket Config|Interact")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:InteractConfig")]
	public BGWDataAsset_CricketInteractConfig InteractConfig
	{
		get
		{
			CheckDestroyed();
			if (!InteractConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:InteractConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_CricketInteractConfig>.FromNative(IntPtr.Add(base.Address, InteractConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:InteractConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_CricketInteractConfig>.ToNative(IntPtr.Add(base.Address, InteractConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Cricket Config|Interact")]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:ASWeakIdle")]
	public UAnimSequence ASWeakIdle
	{
		get
		{
			CheckDestroyed();
			if (!ASWeakIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:ASWeakIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWeakIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWeakIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:ASWeakIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWeakIdle_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Cricket Config|Interact")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakDuration")]
	public float WeakDuration
	{
		get
		{
			CheckDestroyed();
			if (!WeakDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeakDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeakDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeakDuration_Offset), value);
			}
		}
	}

	[Category("Cricket Config|Interact")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:NormalLongPressInteractGroupID")]
	public int NormalLongPressInteractGroupID
	{
		get
		{
			CheckDestroyed();
			if (!NormalLongPressInteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:NormalLongPressInteractGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NormalLongPressInteractGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalLongPressInteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:NormalLongPressInteractGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NormalLongPressInteractGroupID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Cricket Config|Interact")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakLongPressInteractGroupID")]
	public int WeakLongPressInteractGroupID
	{
		get
		{
			CheckDestroyed();
			if (!WeakLongPressInteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakLongPressInteractGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeakLongPressInteractGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeakLongPressInteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CricketMgrConfigComp:WeakLongPressInteractGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeakLongPressInteractGroupID_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_CricketMgrData bUC_CricketMgrData = RequireWritableData<b1.BUC_CricketMgrData>();
		bUC_CricketMgrData.CricketTamer = CricketTamer;
		bUC_CricketMgrData.SpawnProbability = SpawnProbability;
		bUC_CricketMgrData.SpawnDelayTimeRange = SpawnDelayTimeRange;
		bUC_CricketMgrData.TrySpawnMaxCount = TrySpawnMaxCount;
		bUC_CricketMgrData.ReSpawnDelayTime = ReSpawnDelayTime;
		bUC_CricketMgrData.MovePointConfig = new List<b1.CricketMovePointConfig>();
		foreach (FCricketMovePointConfig item in MovePointConfig)
		{
			FCricketMovePointConfig Config = item;
			bUC_CricketMgrData.MovePointConfig.Add(new b1.CricketMovePointConfig(in Config));
		}
		bUC_CricketMgrData.LeaveFightDistance = LeaveFightDistance;
		bUC_CricketMgrData.LeaveFightDelayTime = LeaveFightDelayTime;
		bUC_CricketMgrData.InteractConfig = InteractConfig;
		bUC_CricketMgrData.InteractMaxJumpCount = ((InteractConfig != null && InteractConfig.JumpAnimConfig != null) ? InteractConfig.JumpAnimConfig.Count : 0);
		bUC_CricketMgrData.ASWeakIdle = ASWeakIdle;
		bUC_CricketMgrData.WeakDuration = WeakDuration;
		bUC_CricketMgrData.NormalLongPressInteractGroupID = NormalLongPressInteractGroupID;
		bUC_CricketMgrData.WeakLongPressInteractGroupID = WeakLongPressInteractGroupID;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_CricketMgrConfigComp");
		CricketTamer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketTamer");
		CricketTamer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketTamer", Classes.FClassProperty);
		SpawnProbability_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnProbability");
		SpawnProbability_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnProbability", Classes.FFloatProperty);
		SpawnDelayTimeRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnDelayTimeRange");
		SpawnDelayTimeRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnDelayTimeRange", Classes.FStructProperty);
		TrySpawnMaxCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TrySpawnMaxCount");
		TrySpawnMaxCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TrySpawnMaxCount", Classes.FIntProperty);
		ReSpawnDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReSpawnDelayTime");
		ReSpawnDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReSpawnDelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MovePointConfig_PropertyAddress, unrealStruct, "MovePointConfig");
		MovePointConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovePointConfig");
		MovePointConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovePointConfig", Classes.FArrayProperty);
		LeaveFightDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeaveFightDistance");
		LeaveFightDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeaveFightDistance", Classes.FFloatProperty);
		LeaveFightDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeaveFightDelayTime");
		LeaveFightDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeaveFightDelayTime", Classes.FFloatProperty);
		InteractConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractConfig");
		InteractConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractConfig", Classes.FObjectProperty);
		ASWeakIdle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASWeakIdle");
		ASWeakIdle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASWeakIdle", Classes.FObjectProperty);
		WeakDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeakDuration");
		WeakDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeakDuration", Classes.FFloatProperty);
		NormalLongPressInteractGroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalLongPressInteractGroupID");
		NormalLongPressInteractGroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalLongPressInteractGroupID", Classes.FIntProperty);
		WeakLongPressInteractGroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeakLongPressInteractGroupID");
		WeakLongPressInteractGroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeakLongPressInteractGroupID", Classes.FIntProperty);
	}

	static BUS_CricketMgrConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CricketMgrConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CricketMgrConfigComp));
	}
}
