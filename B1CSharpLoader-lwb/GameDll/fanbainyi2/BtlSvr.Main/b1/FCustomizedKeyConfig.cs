using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CustomizedKeyConfig")]
public struct FCustomizedKeyConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:ActionName")]
	public string ActionName;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:UIWordID")]
	public int UIWordID;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:ChangeType")]
	public EGSInputChangeType ChangeType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:InputTab")]
	public EGSInputTab InputTab;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:KeyMappingType")]
	public EGSKeyMappingType KeyMappingType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:GroupName")]
	public string GroupName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:GroupNameUIWordID")]
	public int GroupNameUIWordID;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CustomizedKeyConfig:UnlockCondition")]
	public ECustomizedKeyUnlockCondition UnlockCondition;

	private static int CustomizedKeyConfig_StructSize;

	private static int CustomizedKeyConfig_IsValid;

	private static bool ActionName_IsValid;

	private static int ActionName_Offset;

	private static bool UIWordID_IsValid;

	private static int UIWordID_Offset;

	private static bool ChangeType_IsValid;

	private static int ChangeType_Offset;

	private static FFieldAddress ChangeType_PropertyAddress;

	private static bool InputTab_IsValid;

	private static int InputTab_Offset;

	private static FFieldAddress InputTab_PropertyAddress;

	private static bool KeyMappingType_IsValid;

	private static int KeyMappingType_Offset;

	private static FFieldAddress KeyMappingType_PropertyAddress;

	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	private static bool GroupNameUIWordID_IsValid;

	private static int GroupNameUIWordID_Offset;

	private static bool UnlockCondition_IsValid;

	private static int UnlockCondition_Offset;

	private static FFieldAddress UnlockCondition_PropertyAddress;

	public FCustomizedKeyConfig Copy()
	{
		return this;
	}

	public static FCustomizedKeyConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCustomizedKeyConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCustomizedKeyConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCustomizedKeyConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCustomizedKeyConfig(IntPtr.Add(nativeBuffer, arrayIndex * CustomizedKeyConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCustomizedKeyConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CustomizedKeyConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CustomizedKeyConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomizedKeyConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActionName_Offset), ActionName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UIWordID_Offset), UIWordID);
		EnumMarshaler<EGSInputChangeType>.ToNative(IntPtr.Add(nativeStruct, ChangeType_Offset), 0, ChangeType_PropertyAddress.Address, ChangeType);
		EnumMarshaler<EGSInputTab>.ToNative(IntPtr.Add(nativeStruct, InputTab_Offset), 0, InputTab_PropertyAddress.Address, InputTab);
		EnumMarshaler<EGSKeyMappingType>.ToNative(IntPtr.Add(nativeStruct, KeyMappingType_Offset), 0, KeyMappingType_PropertyAddress.Address, KeyMappingType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, GroupName_Offset), GroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GroupNameUIWordID_Offset), GroupNameUIWordID);
		EnumMarshaler<ECustomizedKeyUnlockCondition>.ToNative(IntPtr.Add(nativeStruct, UnlockCondition_Offset), 0, UnlockCondition_PropertyAddress.Address, UnlockCondition);
	}

	public FCustomizedKeyConfig(IntPtr nativeStruct)
	{
		if (CustomizedKeyConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomizedKeyConfig");
			ActionName = null;
			UIWordID = 0;
			ChangeType = EGSInputChangeType.All;
			InputTab = EGSInputTab.Comm;
			KeyMappingType = EGSKeyMappingType.Comm;
			GroupName = null;
			GroupNameUIWordID = 0;
			UnlockCondition = ECustomizedKeyUnlockCondition.AlwaysShow;
		}
		else
		{
			ActionName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActionName_Offset));
			UIWordID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UIWordID_Offset));
			ChangeType = EnumMarshaler<EGSInputChangeType>.FromNative(IntPtr.Add(nativeStruct, ChangeType_Offset), 0, ChangeType_PropertyAddress.Address);
			InputTab = EnumMarshaler<EGSInputTab>.FromNative(IntPtr.Add(nativeStruct, InputTab_Offset), 0, InputTab_PropertyAddress.Address);
			KeyMappingType = EnumMarshaler<EGSKeyMappingType>.FromNative(IntPtr.Add(nativeStruct, KeyMappingType_Offset), 0, KeyMappingType_PropertyAddress.Address);
			GroupName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, GroupName_Offset));
			GroupNameUIWordID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GroupNameUIWordID_Offset));
			UnlockCondition = EnumMarshaler<ECustomizedKeyUnlockCondition>.FromNative(IntPtr.Add(nativeStruct, UnlockCondition_Offset), 0, UnlockCondition_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CustomizedKeyConfig");
		CustomizedKeyConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ActionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionName");
		ActionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionName", Classes.FStrProperty);
		UIWordID_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIWordID");
		UIWordID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIWordID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ChangeType_PropertyAddress, intPtr, "ChangeType");
		ChangeType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChangeType");
		ChangeType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChangeType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InputTab_PropertyAddress, intPtr, "InputTab");
		InputTab_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputTab");
		InputTab_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputTab", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref KeyMappingType_PropertyAddress, intPtr, "KeyMappingType");
		KeyMappingType_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeyMappingType");
		KeyMappingType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeyMappingType", Classes.FEnumProperty);
		GroupName_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupName");
		GroupName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupName", Classes.FStrProperty);
		GroupNameUIWordID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupNameUIWordID");
		GroupNameUIWordID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupNameUIWordID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UnlockCondition_PropertyAddress, intPtr, "UnlockCondition");
		UnlockCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnlockCondition");
		UnlockCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnlockCondition", Classes.FEnumProperty);
		CustomizedKeyConfig_IsValid = ((intPtr != IntPtr.Zero && ActionName_IsValid && UIWordID_IsValid && ChangeType_IsValid && InputTab_IsValid && KeyMappingType_IsValid && GroupName_IsValid && GroupNameUIWordID_IsValid && UnlockCondition_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CustomizedKeyConfig", (byte)CustomizedKeyConfig_IsValid != 0);
	}

	static FCustomizedKeyConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCustomizedKeyConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCustomizedKeyConfig));
	}
}
