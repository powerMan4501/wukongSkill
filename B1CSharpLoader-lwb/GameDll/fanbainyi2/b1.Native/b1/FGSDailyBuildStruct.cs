using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSDailyBuildStruct
{
	private static bool ComponentClass_IsValid;

	private static int ComponentClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct:ComponentClass")]
	public TSubclassOf<UActorComponent> ComponentClass;

	private static bool PropertyName_IsValid;

	private static FFieldAddress PropertyName_PropertyAddress;

	private static int PropertyName_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct:PropertyName")]
	public List<string> PropertyName;

	private static bool ExportExcel_IsValid;

	private static FFieldAddress ExportExcel_PropertyAddress;

	private static int ExportExcel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct:ExportExcel")]
	public bool ExportExcel;

	private static bool SpecialFileName_IsValid;

	private static int SpecialFileName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct:SpecialFileName")]
	public string SpecialFileName;

	private static bool Commands_IsValid;

	private static FFieldAddress Commands_PropertyAddress;

	private static int Commands_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/FuncLibEditor.GSDailyBuildStruct:Commands")]
	public Dictionary<string, string> Commands;

	private static bool FGSDailyBuildStruct_IsValid;

	private static int FGSDailyBuildStruct_StructSize;

	public FGSDailyBuildStruct Copy()
	{
		FGSDailyBuildStruct result = this;
		if (PropertyName != null)
		{
			result.PropertyName = new List<string>(PropertyName);
		}
		if (Commands != null)
		{
			result.Commands = new Dictionary<string, string>(Commands);
		}
		return result;
	}

	public static FGSDailyBuildStruct FromNative(IntPtr nativeBuffer)
	{
		return new FGSDailyBuildStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSDailyBuildStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSDailyBuildStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSDailyBuildStruct(nativeBuffer + arrayIndex * FGSDailyBuildStruct_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSDailyBuildStruct value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSDailyBuildStruct_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSDailyBuildStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSDailyBuildStruct");
			return;
		}
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(nativeStruct, ComponentClass_Offset), ComponentClass);
		new TArrayCopyMarshaler<string>(1, PropertyName_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyName_Offset), PropertyName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExportExcel_Offset), 0, ExportExcel_PropertyAddress.Address, ExportExcel);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SpecialFileName_Offset), SpecialFileName);
		new TMapCopyMarshaler<string, string>(1, Commands_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, Commands_Offset), Commands);
	}

	public FGSDailyBuildStruct(IntPtr nativeStruct)
	{
		if (!FGSDailyBuildStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSDailyBuildStruct");
			ComponentClass = default(TSubclassOf<UActorComponent>);
			PropertyName = null;
			ExportExcel = false;
			SpecialFileName = FStringMarshaler.DefaultString;
			Commands = null;
		}
		else
		{
			ComponentClass = TSubclassOfMarshaler<UActorComponent>.FromNative(IntPtr.Add(nativeStruct, ComponentClass_Offset));
			PropertyName = new TArrayCopyMarshaler<string>(1, PropertyName_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyName_Offset));
			ExportExcel = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExportExcel_Offset), 0, ExportExcel_PropertyAddress.Address);
			SpecialFileName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SpecialFileName_Offset));
			Commands = new TMapCopyMarshaler<string, string>(1, Commands_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, Commands_Offset));
		}
	}

	static FGSDailyBuildStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSDailyBuildStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSDailyBuildStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.GSDailyBuildStruct");
		FGSDailyBuildStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentClass");
		ComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyName_PropertyAddress, intPtr, "PropertyName");
		PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyName");
		PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyName", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportExcel_PropertyAddress, intPtr, "ExportExcel");
		ExportExcel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExportExcel");
		ExportExcel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExportExcel", Classes.FBoolProperty);
		SpecialFileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecialFileName");
		SpecialFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecialFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Commands_PropertyAddress, intPtr, "Commands");
		Commands_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Commands");
		Commands_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Commands", Classes.FMapProperty);
		FGSDailyBuildStruct_IsValid = intPtr != IntPtr.Zero && ComponentClass_IsValid && PropertyName_IsValid && ExportExcel_IsValid && SpecialFileName_IsValid && Commands_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.GSDailyBuildStruct", FGSDailyBuildStruct_IsValid);
	}
}
