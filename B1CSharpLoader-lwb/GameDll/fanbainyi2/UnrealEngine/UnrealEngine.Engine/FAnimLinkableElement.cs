using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[UMetaPath("/Script/Engine.AnimLinkableElement", "Engine", UnrealModuleType.Engine)]
public struct FAnimLinkableElement
{
	private static bool LinkedMontage_IsValid;

	private static int LinkedMontage_Offset;

	[UProperty(Flags = (PropFlags)12393764861510144uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkedMontage")]
	public UAnimMontage LinkedMontage;

	private static bool SlotIndex_IsValid;

	private static int SlotIndex_Offset;

	[UProperty(Flags = (PropFlags)11267864954667521uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SlotIndex")]
	public int SlotIndex;

	private static bool SegmentIndex_IsValid;

	private static int SegmentIndex_Offset;

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentIndex")]
	public int SegmentIndex;

	private static bool LinkMethod_IsValid;

	private static FFieldAddress LinkMethod_PropertyAddress;

	private static int LinkMethod_Offset;

	[UProperty(Flags = (PropFlags)11267864954667521uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkMethod")]
	public EAnimLinkMethod LinkMethod;

	private static bool CachedLinkMethod_IsValid;

	private static FFieldAddress CachedLinkMethod_PropertyAddress;

	private static int CachedLinkMethod_Offset;

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:CachedLinkMethod")]
	public EAnimLinkMethod CachedLinkMethod;

	private static bool SegmentBeginTime_IsValid;

	private static int SegmentBeginTime_Offset;

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentBeginTime")]
	public float SegmentBeginTime;

	private static bool SegmentLength_IsValid;

	private static int SegmentLength_Offset;

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentLength")]
	public float SegmentLength;

	private static bool LinkValue_IsValid;

	private static int LinkValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkValue")]
	public float LinkValue;

	private static bool LinkedSequence_IsValid;

	private static int LinkedSequence_Offset;

	[UProperty(Flags = (PropFlags)12398162908152321uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkedSequence")]
	public UAnimSequenceBase LinkedSequence;

	private static bool FAnimLinkableElement_IsValid;

	private static int FAnimLinkableElement_StructSize;

	public FAnimLinkableElement Copy()
	{
		return this;
	}

	public static FAnimLinkableElement FromNative(IntPtr nativeBuffer)
	{
		return new FAnimLinkableElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimLinkableElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimLinkableElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimLinkableElement(nativeBuffer + arrayIndex * FAnimLinkableElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimLinkableElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimLinkableElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimLinkableElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimLinkableElement");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LinkedMontage_Offset), LinkedMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SlotIndex_Offset), SlotIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SegmentIndex_Offset), SegmentIndex);
		EnumMarshaler<EAnimLinkMethod>.ToNative(IntPtr.Add(nativeStruct, LinkMethod_Offset), 0, LinkMethod_PropertyAddress.Address, LinkMethod);
		EnumMarshaler<EAnimLinkMethod>.ToNative(IntPtr.Add(nativeStruct, CachedLinkMethod_Offset), 0, CachedLinkMethod_PropertyAddress.Address, CachedLinkMethod);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SegmentBeginTime_Offset), SegmentBeginTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SegmentLength_Offset), SegmentLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinkValue_Offset), LinkValue);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(nativeStruct, LinkedSequence_Offset), LinkedSequence);
	}

	public FAnimLinkableElement(IntPtr nativeStruct)
	{
		if (!FAnimLinkableElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimLinkableElement");
			LinkedMontage = null;
			SlotIndex = 0;
			SegmentIndex = 0;
			LinkMethod = EAnimLinkMethod.Absolute;
			CachedLinkMethod = EAnimLinkMethod.Absolute;
			SegmentBeginTime = 0f;
			SegmentLength = 0f;
			LinkValue = 0f;
			LinkedSequence = null;
		}
		else
		{
			LinkedMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LinkedMontage_Offset));
			SlotIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SlotIndex_Offset));
			SegmentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SegmentIndex_Offset));
			LinkMethod = EnumMarshaler<EAnimLinkMethod>.FromNative(IntPtr.Add(nativeStruct, LinkMethod_Offset), 0, LinkMethod_PropertyAddress.Address);
			CachedLinkMethod = EnumMarshaler<EAnimLinkMethod>.FromNative(IntPtr.Add(nativeStruct, CachedLinkMethod_Offset), 0, CachedLinkMethod_PropertyAddress.Address);
			SegmentBeginTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SegmentBeginTime_Offset));
			SegmentLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SegmentLength_Offset));
			LinkValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinkValue_Offset));
			LinkedSequence = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(nativeStruct, LinkedSequence_Offset));
		}
	}

	static FAnimLinkableElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimLinkableElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimLinkableElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimLinkableElement");
		FAnimLinkableElement_StructSize = NativeReflection.GetStructSize(intPtr);
		LinkedMontage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkedMontage");
		LinkedMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkedMontage", Classes.FObjectProperty);
		SlotIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SlotIndex");
		SlotIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SlotIndex", Classes.FIntProperty);
		SegmentIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentIndex");
		SegmentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LinkMethod_PropertyAddress, intPtr, "LinkMethod");
		LinkMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkMethod");
		LinkMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CachedLinkMethod_PropertyAddress, intPtr, "CachedLinkMethod");
		CachedLinkMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedLinkMethod");
		CachedLinkMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedLinkMethod", Classes.FByteProperty);
		SegmentBeginTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentBeginTime");
		SegmentBeginTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentBeginTime", Classes.FFloatProperty);
		SegmentLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentLength");
		SegmentLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentLength", Classes.FFloatProperty);
		LinkValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkValue");
		LinkValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkValue", Classes.FFloatProperty);
		LinkedSequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkedSequence");
		LinkedSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkedSequence", Classes.FObjectProperty);
		FAnimLinkableElement_IsValid = intPtr != IntPtr.Zero && LinkedMontage_IsValid && SlotIndex_IsValid && SegmentIndex_IsValid && LinkMethod_IsValid && CachedLinkMethod_IsValid && SegmentBeginTime_IsValid && SegmentLength_IsValid && LinkValue_IsValid && LinkedSequence_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimLinkableElement", FAnimLinkableElement_IsValid);
	}
}
