using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription", "RigVMDeveloper", UnrealModuleType.Engine)]
public struct FRigVMGraphParameterDescription
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription:Name")]
	public FName Name;

	private static bool IsInput_IsValid;

	private static FFieldAddress IsInput_PropertyAddress;

	private static int IsInput_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription:bIsInput")]
	public bool IsInput;

	private static bool CPPType_IsValid;

	private static int CPPType_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription:CPPType")]
	public string CPPType;

	private static bool CPPTypeObject_IsValid;

	private static int CPPTypeObject_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription:CPPTypeObject")]
	public UObject CPPTypeObject;

	private static bool DefaultValue_IsValid;

	private static int DefaultValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphParameterDescription:DefaultValue")]
	public string DefaultValue;

	private static bool FRigVMGraphParameterDescription_IsValid;

	private static int FRigVMGraphParameterDescription_StructSize;

	public FRigVMGraphParameterDescription Copy()
	{
		return this;
	}

	public static FRigVMGraphParameterDescription FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMGraphParameterDescription(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMGraphParameterDescription value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMGraphParameterDescription FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMGraphParameterDescription(nativeBuffer + arrayIndex * FRigVMGraphParameterDescription_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMGraphParameterDescription value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMGraphParameterDescription_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMGraphParameterDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMGraphParameterDescription");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInput_Offset), 0, IsInput_PropertyAddress.Address, IsInput);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CPPType_Offset), CPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, CPPTypeObject_Offset), CPPTypeObject);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Offset), DefaultValue);
	}

	public FRigVMGraphParameterDescription(IntPtr nativeStruct)
	{
		if (!FRigVMGraphParameterDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMGraphParameterDescription");
			Name = default(FName);
			IsInput = false;
			CPPType = FStringMarshaler.DefaultString;
			CPPTypeObject = null;
			DefaultValue = FStringMarshaler.DefaultString;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			IsInput = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInput_Offset), 0, IsInput_PropertyAddress.Address);
			CPPType = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CPPType_Offset));
			CPPTypeObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, CPPTypeObject_Offset));
			DefaultValue = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Offset));
		}
	}

	static FRigVMGraphParameterDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMGraphParameterDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMGraphParameterDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVMDeveloper.RigVMGraphParameterDescription");
		FRigVMGraphParameterDescription_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInput_PropertyAddress, intPtr, "bIsInput");
		IsInput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsInput");
		IsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsInput", Classes.FBoolProperty);
		CPPType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CPPType");
		CPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CPPType", Classes.FStrProperty);
		CPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CPPTypeObject");
		CPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CPPTypeObject", Classes.FObjectProperty);
		DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultValue");
		DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultValue", Classes.FStrProperty);
		FRigVMGraphParameterDescription_IsValid = intPtr != IntPtr.Zero && Name_IsValid && IsInput_IsValid && CPPType_IsValid && CPPTypeObject_IsValid && DefaultValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVMDeveloper.RigVMGraphParameterDescription", FRigVMGraphParameterDescription_IsValid);
	}
}
