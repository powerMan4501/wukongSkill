using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigComponentMappedElement
{
	private static bool ComponentReference_IsValid;

	private static int ComponentReference_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:ComponentReference")]
	public FComponentReference ComponentReference;

	private static bool TransformIndex_IsValid;

	private static int TransformIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:TransformIndex")]
	public int TransformIndex;

	private static bool TransformName_IsValid;

	private static int TransformName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:TransformName")]
	public FName TransformName;

	private static bool ElementType_IsValid;

	private static FFieldAddress ElementType_PropertyAddress;

	private static int ElementType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:ElementType")]
	public ERigElementType ElementType;

	private static bool ElementName_IsValid;

	private static int ElementName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:ElementName")]
	public FName ElementName;

	private static bool Direction_IsValid;

	private static FFieldAddress Direction_PropertyAddress;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:Direction")]
	public EControlRigComponentMapDirection Direction;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:Offset")]
	public FTransform Offset;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:Weight")]
	public float Weight;

	private static bool Space_IsValid;

	private static FFieldAddress Space_PropertyAddress;

	private static int Space_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedElement:Space")]
	public EControlRigComponentSpace Space;

	private static bool FControlRigComponentMappedElement_IsValid;

	private static int FControlRigComponentMappedElement_StructSize;

	public FControlRigComponentMappedElement Copy()
	{
		return this;
	}

	public static FControlRigComponentMappedElement FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigComponentMappedElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigComponentMappedElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigComponentMappedElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigComponentMappedElement(nativeBuffer + arrayIndex * FControlRigComponentMappedElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigComponentMappedElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigComponentMappedElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedElement");
			return;
		}
		FComponentReference.ToNative(IntPtr.Add(nativeStruct, ComponentReference_Offset), ComponentReference);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TransformIndex_Offset), TransformIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TransformName_Offset), TransformName);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(nativeStruct, ElementType_Offset), 0, ElementType_PropertyAddress.Address, ElementType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ElementName_Offset), ElementName);
		EnumMarshaler<EControlRigComponentMapDirection>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		EnumMarshaler<EControlRigComponentSpace>.ToNative(IntPtr.Add(nativeStruct, Space_Offset), 0, Space_PropertyAddress.Address, Space);
	}

	public FControlRigComponentMappedElement(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedElement");
			ComponentReference = default(FComponentReference);
			TransformIndex = 0;
			TransformName = default(FName);
			ElementType = ERigElementType.None;
			ElementName = default(FName);
			Direction = EControlRigComponentMapDirection.Input;
			Offset = default(FTransform);
			Weight = 0f;
			Space = EControlRigComponentSpace.WorldSpace;
		}
		else
		{
			ComponentReference = FComponentReference.FromNative(IntPtr.Add(nativeStruct, ComponentReference_Offset));
			TransformIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TransformIndex_Offset));
			TransformName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TransformName_Offset));
			ElementType = EnumMarshaler<ERigElementType>.FromNative(IntPtr.Add(nativeStruct, ElementType_Offset), 0, ElementType_PropertyAddress.Address);
			ElementName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ElementName_Offset));
			Direction = EnumMarshaler<EControlRigComponentMapDirection>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address);
			Offset = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
			Weight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
			Space = EnumMarshaler<EControlRigComponentSpace>.FromNative(IntPtr.Add(nativeStruct, Space_Offset), 0, Space_PropertyAddress.Address);
		}
	}

	static FControlRigComponentMappedElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigComponentMappedElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigComponentMappedElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigComponentMappedElement");
		FControlRigComponentMappedElement_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentReference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentReference");
		ComponentReference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentReference", Classes.FStructProperty);
		TransformIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformIndex");
		TransformIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformIndex", Classes.FIntProperty);
		TransformName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformName");
		TransformName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ElementType_PropertyAddress, intPtr, "ElementType");
		ElementType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElementType");
		ElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElementType", Classes.FEnumProperty);
		ElementName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElementName");
		ElementName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElementName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FEnumProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Space_PropertyAddress, intPtr, "Space");
		Space_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Space");
		Space_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Space", Classes.FEnumProperty);
		FControlRigComponentMappedElement_IsValid = intPtr != IntPtr.Zero && ComponentReference_IsValid && TransformIndex_IsValid && TransformName_IsValid && ElementType_IsValid && ElementName_IsValid && Direction_IsValid && Offset_IsValid && Weight_IsValid && Space_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigComponentMappedElement", FControlRigComponentMappedElement_IsValid);
	}
}
