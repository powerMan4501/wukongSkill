using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 57349)]
[BlueprintType]
[UMetaPath("/Script/b1.UStGSNotifyParam", "b1", UnrealModuleType.Game)]
public struct FUStGSNotifyParam
{
	private static bool World_IsValid;

	private static int World_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:World")]
	public UWorld World;

	private static bool owner_IsValid;

	private static int owner_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:owner")]
	public AActor owner;

	private static bool CurInstanceID_IsValid;

	private static int CurInstanceID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:CurInstanceID")]
	public int CurInstanceID;

	private static bool FromInstanceID_IsValid;

	private static int FromInstanceID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:FromInstanceID")]
	public int FromInstanceID;

	private static bool UniqueID_IsValid;

	private static int UniqueID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:UniqueID")]
	public int UniqueID;

	private static bool MeshComp_IsValid;

	private static int MeshComp_Offset;

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:MeshComp")]
	public USkeletalMeshComponent MeshComp;

	private static bool Animation_IsValid;

	private static int Animation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:Animation")]
	public UAnimSequenceBase Animation;

	private static bool AnimNotifyEvent_LinkValue_IsValid;

	private static int AnimNotifyEvent_LinkValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:AnimNotifyEvent_LinkValue")]
	public float AnimNotifyEvent_LinkValue;

	private static bool NotifyBeginTime_IsValid;

	private static int NotifyBeginTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:NotifyBeginTime")]
	public float NotifyBeginTime;

	private static bool NotifyEndTime_IsValid;

	private static int NotifyEndTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSNotifyParam:NotifyEndTime")]
	public float NotifyEndTime;

	private static bool FUStGSNotifyParam_IsValid;

	private static int FUStGSNotifyParam_StructSize;

	public FUStGSNotifyParam Copy()
	{
		return this;
	}

	public static FUStGSNotifyParam FromNative(IntPtr nativeBuffer)
	{
		return new FUStGSNotifyParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStGSNotifyParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStGSNotifyParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStGSNotifyParam(nativeBuffer + arrayIndex * FUStGSNotifyParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStGSNotifyParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStGSNotifyParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStGSNotifyParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSNotifyParam");
			return;
		}
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(nativeStruct, World_Offset), World);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, owner_Offset), owner);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CurInstanceID_Offset), CurInstanceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FromInstanceID_Offset), FromInstanceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UniqueID_Offset), UniqueID);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(nativeStruct, MeshComp_Offset), MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(nativeStruct, Animation_Offset), Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimNotifyEvent_LinkValue_Offset), AnimNotifyEvent_LinkValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NotifyBeginTime_Offset), NotifyBeginTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NotifyEndTime_Offset), NotifyEndTime);
	}

	public FUStGSNotifyParam(IntPtr nativeStruct)
	{
		if (!FUStGSNotifyParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSNotifyParam");
			World = null;
			owner = null;
			CurInstanceID = 0;
			FromInstanceID = 0;
			UniqueID = 0;
			MeshComp = null;
			Animation = null;
			AnimNotifyEvent_LinkValue = 0f;
			NotifyBeginTime = 0f;
			NotifyEndTime = 0f;
		}
		else
		{
			World = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(nativeStruct, World_Offset));
			owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, owner_Offset));
			CurInstanceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CurInstanceID_Offset));
			FromInstanceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FromInstanceID_Offset));
			UniqueID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UniqueID_Offset));
			MeshComp = UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(nativeStruct, MeshComp_Offset));
			Animation = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(nativeStruct, Animation_Offset));
			AnimNotifyEvent_LinkValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimNotifyEvent_LinkValue_Offset));
			NotifyBeginTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NotifyBeginTime_Offset));
			NotifyEndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NotifyEndTime_Offset));
		}
	}

	static FUStGSNotifyParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStGSNotifyParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStGSNotifyParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStGSNotifyParam");
		FUStGSNotifyParam_StructSize = NativeReflection.GetStructSize(intPtr);
		World_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "World");
		World_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "World", Classes.FObjectProperty);
		owner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "owner");
		owner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "owner", Classes.FObjectProperty);
		CurInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurInstanceID");
		CurInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurInstanceID", Classes.FIntProperty);
		FromInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FromInstanceID");
		FromInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FromInstanceID", Classes.FIntProperty);
		UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UniqueID");
		UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UniqueID", Classes.FIntProperty);
		MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshComp");
		MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshComp", Classes.FObjectProperty);
		Animation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Animation");
		Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Animation", Classes.FObjectProperty);
		AnimNotifyEvent_LinkValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimNotifyEvent_LinkValue");
		AnimNotifyEvent_LinkValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimNotifyEvent_LinkValue", Classes.FFloatProperty);
		NotifyBeginTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyBeginTime");
		NotifyBeginTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyBeginTime", Classes.FFloatProperty);
		NotifyEndTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyEndTime");
		NotifyEndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyEndTime", Classes.FFloatProperty);
		FUStGSNotifyParam_IsValid = intPtr != IntPtr.Zero && World_IsValid && owner_IsValid && CurInstanceID_IsValid && FromInstanceID_IsValid && UniqueID_IsValid && MeshComp_IsValid && Animation_IsValid && AnimNotifyEvent_LinkValue_IsValid && NotifyBeginTime_IsValid && NotifyEndTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UStGSNotifyParam", FUStGSNotifyParam_IsValid);
	}
}
