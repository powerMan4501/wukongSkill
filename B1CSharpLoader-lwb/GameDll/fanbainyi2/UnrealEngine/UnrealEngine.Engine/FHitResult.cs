using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 26117)]
[BlueprintType]
[UMetaPath("/Script/Engine.HitResult", "Engine", UnrealModuleType.Engine)]
public struct FHitResult
{
	private static bool FaceIndex_IsValid;

	private static int FaceIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:FaceIndex")]
	public int FaceIndex;

	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:Time")]
	public float Time;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:Distance")]
	public float Distance;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:Location")]
	public FVector_NetQuantize Location;

	private static bool ImpactPoint_IsValid;

	private static int ImpactPoint_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:ImpactPoint")]
	public FVector_NetQuantize ImpactPoint;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:Normal")]
	public FVector_NetQuantizeNormal Normal;

	private static bool ImpactNormal_IsValid;

	private static int ImpactNormal_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:ImpactNormal")]
	public FVector_NetQuantizeNormal ImpactNormal;

	private static bool TraceStart_IsValid;

	private static int TraceStart_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:TraceStart")]
	public FVector_NetQuantize TraceStart;

	private static bool TraceEnd_IsValid;

	private static int TraceEnd_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:TraceEnd")]
	public FVector_NetQuantize TraceEnd;

	private static bool PenetrationDepth_IsValid;

	private static int PenetrationDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:PenetrationDepth")]
	public float PenetrationDepth;

	private static bool MyItem_IsValid;

	private static int MyItem_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:MyItem")]
	public int MyItem;

	private static bool Item_IsValid;

	private static int Item_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:Item")]
	public int Item;

	private static bool ElementIndex_IsValid;

	private static int ElementIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:ElementIndex")]
	public byte ElementIndex;

	private static bool BlockingHit_IsValid;

	private static FFieldAddress BlockingHit_PropertyAddress;

	private static int BlockingHit_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:bBlockingHit")]
	public bool BlockingHit;

	private static bool StartPenetrating_IsValid;

	private static FFieldAddress StartPenetrating_PropertyAddress;

	private static int StartPenetrating_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:bStartPenetrating")]
	public bool StartPenetrating;

	private static bool PhysMaterial_IsValid;

	private static int PhysMaterial_Offset;

	[UProperty(Flags = (PropFlags)7881369141117440uL)]
	[UMetaPath("/Script/Engine.HitResult:PhysMaterial")]
	public TWeakObject<UPhysicalMaterial> PhysMaterial;

	private static bool HitObjectHandle_IsValid;

	private static int HitObjectHandle_Offset;

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.HitResult:HitObjectHandle")]
	public FActorInstanceHandle HitObjectHandle;

	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641736uL)]
	[UMetaPath("/Script/Engine.HitResult:Component")]
	public TWeakObject<UPrimitiveComponent> Component;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:BoneName")]
	public FName BoneName;

	private static bool MyBoneName_IsValid;

	private static int MyBoneName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.HitResult:MyBoneName")]
	public FName MyBoneName;

	private static bool FHitResult_IsValid;

	private static int FHitResult_StructSize;

	public FHitResult Copy()
	{
		return this;
	}

	public static FHitResult FromNative(IntPtr nativeBuffer)
	{
		return new FHitResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHitResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHitResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHitResult(nativeBuffer + arrayIndex * FHitResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHitResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHitResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.HitResult");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FaceIndex_Offset), FaceIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Distance_Offset), Distance);
		FVector_NetQuantize.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		FVector_NetQuantize.ToNative(IntPtr.Add(nativeStruct, ImpactPoint_Offset), ImpactPoint);
		FVector_NetQuantizeNormal.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		FVector_NetQuantizeNormal.ToNative(IntPtr.Add(nativeStruct, ImpactNormal_Offset), ImpactNormal);
		FVector_NetQuantize.ToNative(IntPtr.Add(nativeStruct, TraceStart_Offset), TraceStart);
		FVector_NetQuantize.ToNative(IntPtr.Add(nativeStruct, TraceEnd_Offset), TraceEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PenetrationDepth_Offset), PenetrationDepth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MyItem_Offset), MyItem);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Item_Offset), Item);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, ElementIndex_Offset), ElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address, BlockingHit);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StartPenetrating_Offset), 0, StartPenetrating_PropertyAddress.Address, StartPenetrating);
		TWeakObjectMarshaler<UPhysicalMaterial>.ToNative(IntPtr.Add(nativeStruct, PhysMaterial_Offset), PhysMaterial);
		FActorInstanceHandle.ToNative(IntPtr.Add(nativeStruct, HitObjectHandle_Offset), HitObjectHandle);
		TWeakObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MyBoneName_Offset), MyBoneName);
	}

	public FHitResult(IntPtr nativeStruct)
	{
		if (!FHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.HitResult");
			FaceIndex = 0;
			Time = 0f;
			Distance = 0f;
			Location = default(FVector_NetQuantize);
			ImpactPoint = default(FVector_NetQuantize);
			Normal = default(FVector_NetQuantizeNormal);
			ImpactNormal = default(FVector_NetQuantizeNormal);
			TraceStart = default(FVector_NetQuantize);
			TraceEnd = default(FVector_NetQuantize);
			PenetrationDepth = 0f;
			MyItem = 0;
			Item = 0;
			ElementIndex = 0;
			BlockingHit = false;
			StartPenetrating = false;
			PhysMaterial = default(TWeakObject<UPhysicalMaterial>);
			HitObjectHandle = default(FActorInstanceHandle);
			Component = default(TWeakObject<UPrimitiveComponent>);
			BoneName = default(FName);
			MyBoneName = default(FName);
		}
		else
		{
			FaceIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FaceIndex_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
			Distance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Distance_Offset));
			Location = FVector_NetQuantize.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			ImpactPoint = FVector_NetQuantize.FromNative(IntPtr.Add(nativeStruct, ImpactPoint_Offset));
			Normal = FVector_NetQuantizeNormal.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			ImpactNormal = FVector_NetQuantizeNormal.FromNative(IntPtr.Add(nativeStruct, ImpactNormal_Offset));
			TraceStart = FVector_NetQuantize.FromNative(IntPtr.Add(nativeStruct, TraceStart_Offset));
			TraceEnd = FVector_NetQuantize.FromNative(IntPtr.Add(nativeStruct, TraceEnd_Offset));
			PenetrationDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PenetrationDepth_Offset));
			MyItem = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MyItem_Offset));
			Item = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Item_Offset));
			ElementIndex = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, ElementIndex_Offset));
			BlockingHit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address);
			StartPenetrating = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StartPenetrating_Offset), 0, StartPenetrating_PropertyAddress.Address);
			PhysMaterial = TWeakObjectMarshaler<UPhysicalMaterial>.FromNative(IntPtr.Add(nativeStruct, PhysMaterial_Offset));
			HitObjectHandle = FActorInstanceHandle.FromNative(IntPtr.Add(nativeStruct, HitObjectHandle_Offset));
			Component = TWeakObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			MyBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MyBoneName_Offset));
		}
	}

	static FHitResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHitResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHitResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.HitResult");
		FHitResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FaceIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FaceIndex");
		FaceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FaceIndex", Classes.FIntProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		Distance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Distance");
		Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Distance", Classes.FFloatProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		ImpactPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImpactPoint");
		ImpactPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImpactPoint", Classes.FStructProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		ImpactNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImpactNormal");
		ImpactNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImpactNormal", Classes.FStructProperty);
		TraceStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceStart");
		TraceStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceStart", Classes.FStructProperty);
		TraceEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceEnd");
		TraceEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceEnd", Classes.FStructProperty);
		PenetrationDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PenetrationDepth");
		PenetrationDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PenetrationDepth", Classes.FFloatProperty);
		MyItem_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MyItem");
		MyItem_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MyItem", Classes.FIntProperty);
		Item_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Item");
		Item_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Item", Classes.FIntProperty);
		ElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElementIndex");
		ElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElementIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockingHit_PropertyAddress, intPtr, "bBlockingHit");
		BlockingHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlockingHit");
		BlockingHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlockingHit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartPenetrating_PropertyAddress, intPtr, "bStartPenetrating");
		StartPenetrating_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStartPenetrating");
		StartPenetrating_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStartPenetrating", Classes.FBoolProperty);
		PhysMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysMaterial");
		PhysMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysMaterial", Classes.FWeakObjectProperty);
		HitObjectHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitObjectHandle");
		HitObjectHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitObjectHandle", Classes.FStructProperty);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FWeakObjectProperty);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		MyBoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MyBoneName");
		MyBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MyBoneName", Classes.FNameProperty);
		FHitResult_IsValid = intPtr != IntPtr.Zero && FaceIndex_IsValid && Time_IsValid && Distance_IsValid && Location_IsValid && ImpactPoint_IsValid && Normal_IsValid && ImpactNormal_IsValid && TraceStart_IsValid && TraceEnd_IsValid && PenetrationDepth_IsValid && MyItem_IsValid && Item_IsValid && ElementIndex_IsValid && BlockingHit_IsValid && StartPenetrating_IsValid && PhysMaterial_IsValid && HitObjectHandle_IsValid && Component_IsValid && BoneName_IsValid && MyBoneName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.HitResult", FHitResult_IsValid);
	}
}
