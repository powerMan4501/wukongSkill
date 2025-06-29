using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.AiConversationFact")]
public struct FAiConversationFact
{
	[BlueprintReadWrite]
	[DisplayName("数据名")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AiConversationFact:KeyName")]
	public string KeyName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("数据类型")]
	[USharpPath("/Script/b1-Managed.AiConversationFact:FactType")]
	public EAiConversationFactType FactType;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "FactType == AiConversationFactType::FactType_Int")]
	[USharpPath("/Script/b1-Managed.AiConversationFact:DefaultValue_Int")]
	public int DefaultValue_Int;

	[UMeta(MDProp.EditCondition, "FactType == AiConversationFactType::FactType_Bool")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AiConversationFact:DefaultValue_Bool")]
	public bool DefaultValue_Bool;

	[UProperty]
	[UMeta(MDProp.EditCondition, "FactType == AiConversationFactType::FactType_String")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AiConversationFact:DefaultValue_Str")]
	public string DefaultValue_Str;

	private static int AiConversationFact_StructSize;

	private static int AiConversationFact_IsValid;

	private static bool KeyName_IsValid;

	private static int KeyName_Offset;

	private static bool FactType_IsValid;

	private static int FactType_Offset;

	private static FFieldAddress FactType_PropertyAddress;

	private static bool DefaultValue_Int_IsValid;

	private static int DefaultValue_Int_Offset;

	private static bool DefaultValue_Bool_IsValid;

	private static int DefaultValue_Bool_Offset;

	private static FFieldAddress DefaultValue_Bool_PropertyAddress;

	private static bool DefaultValue_Str_IsValid;

	private static int DefaultValue_Str_Offset;

	public FAiConversationFact Copy()
	{
		return this;
	}

	public static FAiConversationFact FromNative(IntPtr nativeBuffer)
	{
		return new FAiConversationFact(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAiConversationFact value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAiConversationFact FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAiConversationFact(IntPtr.Add(nativeBuffer, arrayIndex * AiConversationFact_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAiConversationFact value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AiConversationFact_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AiConversationFact_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AiConversationFact");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, KeyName_Offset), KeyName);
		EnumMarshaler<EAiConversationFactType>.ToNative(IntPtr.Add(nativeStruct, FactType_Offset), 0, FactType_PropertyAddress.Address, FactType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Int_Offset), DefaultValue_Int);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Bool_Offset), 0, DefaultValue_Bool_PropertyAddress.Address, DefaultValue_Bool);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Str_Offset), DefaultValue_Str);
	}

	public FAiConversationFact(IntPtr nativeStruct)
	{
		if (AiConversationFact_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AiConversationFact");
			KeyName = null;
			FactType = EAiConversationFactType.FactType_Int;
			DefaultValue_Int = 0;
			DefaultValue_Bool = false;
			DefaultValue_Str = null;
		}
		else
		{
			KeyName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, KeyName_Offset));
			FactType = EnumMarshaler<EAiConversationFactType>.FromNative(IntPtr.Add(nativeStruct, FactType_Offset), 0, FactType_PropertyAddress.Address);
			DefaultValue_Int = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Int_Offset));
			DefaultValue_Bool = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Bool_Offset), 0, DefaultValue_Bool_PropertyAddress.Address);
			DefaultValue_Str = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Str_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AiConversationFact");
		AiConversationFact_StructSize = NativeReflection.GetStructSize(intPtr);
		KeyName_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeyName");
		KeyName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref FactType_PropertyAddress, intPtr, "FactType");
		FactType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FactType");
		FactType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FactType", Classes.FEnumProperty);
		DefaultValue_Int_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultValue_Int");
		DefaultValue_Int_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultValue_Int", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DefaultValue_Bool_PropertyAddress, intPtr, "DefaultValue_Bool");
		DefaultValue_Bool_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultValue_Bool");
		DefaultValue_Bool_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultValue_Bool", Classes.FBoolProperty);
		DefaultValue_Str_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultValue_Str");
		DefaultValue_Str_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultValue_Str", Classes.FStrProperty);
		AiConversationFact_IsValid = ((intPtr != IntPtr.Zero && KeyName_IsValid && FactType_IsValid && DefaultValue_Int_IsValid && DefaultValue_Bool_IsValid && DefaultValue_Str_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AiConversationFact", (byte)AiConversationFact_IsValid != 0);
	}

	static FAiConversationFact()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAiConversationFact)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAiConversationFact));
	}
}
