using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMGraphVariableDescription", "RigVMDeveloper", UnrealModuleType.Engine)]
public struct FRigVMGraphVariableDescription
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphVariableDescription:Name")]
	public FName Name;

	private static bool CPPType_IsValid;

	private static int CPPType_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphVariableDescription:CPPType")]
	public string CPPType;

	private static bool CPPTypeObject_IsValid;

	private static int CPPTypeObject_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphVariableDescription:CPPTypeObject")]
	public UObject CPPTypeObject;

	private static bool DefaultValue_IsValid;

	private static int DefaultValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraphVariableDescription:DefaultValue")]
	public string DefaultValue;

	private static bool FRigVMGraphVariableDescription_IsValid;

	private static int FRigVMGraphVariableDescription_StructSize;

	public FRigVMGraphVariableDescription Copy()
	{
		return this;
	}

	public static FRigVMGraphVariableDescription FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMGraphVariableDescription(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMGraphVariableDescription value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMGraphVariableDescription FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMGraphVariableDescription(nativeBuffer + arrayIndex * FRigVMGraphVariableDescription_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMGraphVariableDescription value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMGraphVariableDescription_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMGraphVariableDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMGraphVariableDescription");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CPPType_Offset), CPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, CPPTypeObject_Offset), CPPTypeObject);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Offset), DefaultValue);
	}

	public FRigVMGraphVariableDescription(IntPtr nativeStruct)
	{
		if (!FRigVMGraphVariableDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMGraphVariableDescription");
			Name = default(FName);
			CPPType = FStringMarshaler.DefaultString;
			CPPTypeObject = null;
			DefaultValue = FStringMarshaler.DefaultString;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			CPPType = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CPPType_Offset));
			CPPTypeObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, CPPTypeObject_Offset));
			DefaultValue = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Offset));
		}
	}

	static FRigVMGraphVariableDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMGraphVariableDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMGraphVariableDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVMDeveloper.RigVMGraphVariableDescription");
		FRigVMGraphVariableDescription_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		CPPType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CPPType");
		CPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CPPType", Classes.FStrProperty);
		CPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CPPTypeObject");
		CPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CPPTypeObject", Classes.FObjectProperty);
		DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultValue");
		DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultValue", Classes.FStrProperty);
		FRigVMGraphVariableDescription_IsValid = intPtr != IntPtr.Zero && Name_IsValid && CPPType_IsValid && CPPTypeObject_IsValid && DefaultValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVMDeveloper.RigVMGraphVariableDescription", FRigVMGraphVariableDescription_IsValid);
	}
}
