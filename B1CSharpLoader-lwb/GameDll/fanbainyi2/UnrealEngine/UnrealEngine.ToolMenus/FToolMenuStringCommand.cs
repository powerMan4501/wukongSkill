using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuStringCommand", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuStringCommand
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuStringCommand:Type")]
	public EToolMenuStringCommandType Type;

	private static bool CustomType_IsValid;

	private static int CustomType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuStringCommand:CustomType")]
	public FName CustomType;

	private static bool String_IsValid;

	private static int String_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuStringCommand:String")]
	public string String;

	private static bool FToolMenuStringCommand_IsValid;

	private static int FToolMenuStringCommand_StructSize;

	public FToolMenuStringCommand Copy()
	{
		return this;
	}

	public static FToolMenuStringCommand FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuStringCommand(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuStringCommand value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuStringCommand FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuStringCommand(nativeBuffer + arrayIndex * FToolMenuStringCommand_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuStringCommand value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuStringCommand_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuStringCommand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuStringCommand");
			return;
		}
		EnumMarshaler<EToolMenuStringCommandType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CustomType_Offset), CustomType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, String_Offset), String);
	}

	public FToolMenuStringCommand(IntPtr nativeStruct)
	{
		if (!FToolMenuStringCommand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuStringCommand");
			Type = EToolMenuStringCommandType.Command;
			CustomType = default(FName);
			String = FStringMarshaler.DefaultString;
		}
		else
		{
			Type = EnumMarshaler<EToolMenuStringCommandType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			CustomType = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CustomType_Offset));
			String = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, String_Offset));
		}
	}

	static FToolMenuStringCommand()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuStringCommand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuStringCommand));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuStringCommand");
		FToolMenuStringCommand_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		CustomType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomType");
		CustomType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomType", Classes.FNameProperty);
		String_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "String");
		String_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "String", Classes.FStrProperty);
		FToolMenuStringCommand_IsValid = intPtr != IntPtr.Zero && Type_IsValid && CustomType_IsValid && String_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuStringCommand", FToolMenuStringCommand_IsValid);
	}
}
