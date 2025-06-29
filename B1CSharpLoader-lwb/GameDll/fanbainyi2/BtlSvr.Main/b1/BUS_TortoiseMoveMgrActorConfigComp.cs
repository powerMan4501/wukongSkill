using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp")]
internal class BUS_TortoiseMoveMgrActorConfigComp : UActorEditCompBase
{
	private static bool Tortoise_IsValid;

	private static int Tortoise_Offset;

	private static bool LevelMoveAttachedBone_IsValid;

	private static int LevelMoveAttachedBone_Offset;

	private static bool FakeMoveLevels_IsValid;

	private static int FakeMoveLevels_Offset;

	private static FFieldAddress FakeMoveLevels_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> FakeMoveLevels_Marshaler;

	private static bool TortoiseUnitResIDs_IsValid;

	private static int TortoiseUnitResIDs_Offset;

	private static FFieldAddress TortoiseUnitResIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> TortoiseUnitResIDs_Marshaler;

	private static bool TortoiseRotationTriggerBoxInfoMap_IsValid;

	private static int TortoiseRotationTriggerBoxInfoMap_Offset;

	private static FFieldAddress TortoiseRotationTriggerBoxInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FTortoiseRotateTriggerBoxInfo> TortoiseRotationTriggerBoxInfoMap_Marshaler;

	[BlueprintReadWrite]
	[Category("BasicConfig")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:Tortoise")]
	protected AActor Tortoise
	{
		get
		{
			CheckDestroyed();
			if (!Tortoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:Tortoise");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Tortoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tortoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:Tortoise");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Tortoise_Offset), value);
			}
		}
	}

	[Category("BasicConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:LevelMoveAttachedBone")]
	protected FName LevelMoveAttachedBone
	{
		get
		{
			CheckDestroyed();
			if (!LevelMoveAttachedBone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:LevelMoveAttachedBone");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LevelMoveAttachedBone_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelMoveAttachedBone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:LevelMoveAttachedBone");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LevelMoveAttachedBone_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BasicConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:FakeMoveLevels")]
	protected TArrayReadWrite<FName> FakeMoveLevels
	{
		get
		{
			CheckDestroyed();
			if (!FakeMoveLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:FakeMoveLevels");
				return null;
			}
			if (FakeMoveLevels_Marshaler == null)
			{
				FakeMoveLevels_Marshaler = new TArrayReadWriteMarshaler<FName>(1, FakeMoveLevels_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return FakeMoveLevels_Marshaler.FromNative(IntPtr.Add(base.Address, FakeMoveLevels_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BasicConfig")]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:TortoiseUnitResIDs")]
	protected TArrayReadWrite<int> TortoiseUnitResIDs
	{
		get
		{
			CheckDestroyed();
			if (!TortoiseUnitResIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:TortoiseUnitResIDs");
				return null;
			}
			if (TortoiseUnitResIDs_Marshaler == null)
			{
				TortoiseUnitResIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, TortoiseUnitResIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return TortoiseUnitResIDs_Marshaler.FromNative(IntPtr.Add(base.Address, TortoiseUnitResIDs_Offset));
		}
	}

	[Category("BasicConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:TortoiseRotationTriggerBoxInfoMap")]
	protected TMapReadWrite<int, FTortoiseRotateTriggerBoxInfo> TortoiseRotationTriggerBoxInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!TortoiseRotationTriggerBoxInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp:TortoiseRotationTriggerBoxInfoMap");
				return null;
			}
			if (TortoiseRotationTriggerBoxInfoMap_Marshaler == null)
			{
				TortoiseRotationTriggerBoxInfoMap_Marshaler = new TMapReadWriteMarshaler<int, FTortoiseRotateTriggerBoxInfo>(1, TortoiseRotationTriggerBoxInfoMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FTortoiseRotateTriggerBoxInfo, FTortoiseRotateTriggerBoxInfo>.FromNative, CachedMarshalingDelegates<FTortoiseRotateTriggerBoxInfo, FTortoiseRotateTriggerBoxInfo>.ToNative);
			}
			return TortoiseRotationTriggerBoxInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, TortoiseRotationTriggerBoxInfoMap_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_TortoiseMoveMgrActorData bUC_TortoiseMoveMgrActorData = RequireWritableData<b1.BUC_TortoiseMoveMgrActorData>();
		BUC_QuestTortoiseCtrlData bUC_QuestTortoiseCtrlData = RequireWritableData<BUC_QuestTortoiseCtrlData>();
		bUC_TortoiseMoveMgrActorData.Tortoise = (bUC_QuestTortoiseCtrlData.Tortoise = Tortoise);
		bUC_TortoiseMoveMgrActorData.LevelMoveAttachedBone = LevelMoveAttachedBone;
		foreach (FName fakeMoveLevel in FakeMoveLevels)
		{
			bUC_TortoiseMoveMgrActorData.FakeMoveLevels.Add(fakeMoveLevel);
		}
		foreach (int key in TortoiseRotationTriggerBoxInfoMap.Keys)
		{
			bUC_QuestTortoiseCtrlData.TortoiseRotateTriggerBoxInfoDict.Add(key, TortoiseRotationTriggerBoxInfoMap[key]);
		}
		foreach (int tortoiseUnitResID in TortoiseUnitResIDs)
		{
			bUC_QuestTortoiseCtrlData.TortoiseUnitResIDList.Add(tortoiseUnitResID);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TortoiseMoveMgrActorConfigComp");
		Tortoise_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Tortoise");
		Tortoise_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Tortoise", Classes.FObjectProperty);
		LevelMoveAttachedBone_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelMoveAttachedBone");
		LevelMoveAttachedBone_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelMoveAttachedBone", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref FakeMoveLevels_PropertyAddress, unrealStruct, "FakeMoveLevels");
		FakeMoveLevels_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FakeMoveLevels");
		FakeMoveLevels_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FakeMoveLevels", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TortoiseUnitResIDs_PropertyAddress, unrealStruct, "TortoiseUnitResIDs");
		TortoiseUnitResIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TortoiseUnitResIDs");
		TortoiseUnitResIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TortoiseUnitResIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TortoiseRotationTriggerBoxInfoMap_PropertyAddress, unrealStruct, "TortoiseRotationTriggerBoxInfoMap");
		TortoiseRotationTriggerBoxInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TortoiseRotationTriggerBoxInfoMap");
		TortoiseRotationTriggerBoxInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TortoiseRotationTriggerBoxInfoMap", Classes.FMapProperty);
	}

	static BUS_TortoiseMoveMgrActorConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TortoiseMoveMgrActorConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TortoiseMoveMgrActorConfigComp));
	}
}
