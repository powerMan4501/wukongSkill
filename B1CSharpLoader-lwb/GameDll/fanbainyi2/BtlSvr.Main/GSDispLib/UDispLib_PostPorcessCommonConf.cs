using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf")]
public struct UDispLib_PostPorcessCommonConf
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:ID")]
	public int ID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:Name")]
	public string Name;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:ActorType")]
	public TSubclassOf<GSDispLib_PostProcessActor> ActorType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:BeginningDuration")]
	public float BeginningDuration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:FinishingDuration")]
	public float FinishingDuration;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostPorcessCommonConf:AutoEnable")]
	public bool AutoEnable;

	private static int UDispLib_PostPorcessCommonConf_StructSize;

	private static int UDispLib_PostPorcessCommonConf_IsValid;

	private static bool ID_IsValid;

	private static int ID_Offset;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool ActorType_IsValid;

	private static int ActorType_Offset;

	private static bool BeginningDuration_IsValid;

	private static int BeginningDuration_Offset;

	private static bool FinishingDuration_IsValid;

	private static int FinishingDuration_Offset;

	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	public void Copy(UDispLib_PostPorcessCommonConf Other)
	{
		ID = Other.ID;
		Name = Other.Name;
		ActorType = Other.ActorType;
		BeginningDuration = Other.BeginningDuration;
		FinishingDuration = Other.FinishingDuration;
		AutoEnable = Other.AutoEnable;
	}

	public UDispLib_PostPorcessCommonConf Copy()
	{
		return this;
	}

	public static UDispLib_PostPorcessCommonConf FromNative(IntPtr nativeBuffer)
	{
		return new UDispLib_PostPorcessCommonConf(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UDispLib_PostPorcessCommonConf value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UDispLib_PostPorcessCommonConf FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UDispLib_PostPorcessCommonConf(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostPorcessCommonConf_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UDispLib_PostPorcessCommonConf value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostPorcessCommonConf_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UDispLib_PostPorcessCommonConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostPorcessCommonConf");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ID_Offset), ID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		TSubclassOfMarshaler<GSDispLib_PostProcessActor>.ToNative(IntPtr.Add(nativeStruct, ActorType_Offset), ActorType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeginningDuration_Offset), BeginningDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FinishingDuration_Offset), FinishingDuration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, AutoEnable);
	}

	public UDispLib_PostPorcessCommonConf(IntPtr nativeStruct)
	{
		if (UDispLib_PostPorcessCommonConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostPorcessCommonConf");
			ID = 0;
			Name = null;
			ActorType = default(TSubclassOf<GSDispLib_PostProcessActor>);
			BeginningDuration = 0f;
			FinishingDuration = 0f;
			AutoEnable = false;
		}
		else
		{
			ID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ID_Offset));
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			ActorType = TSubclassOfMarshaler<GSDispLib_PostProcessActor>.FromNative(IntPtr.Add(nativeStruct, ActorType_Offset));
			BeginningDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeginningDuration_Offset));
			FinishingDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FinishingDuration_Offset));
			AutoEnable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UDispLib_PostPorcessCommonConf");
		UDispLib_PostPorcessCommonConf_StructSize = NativeReflection.GetStructSize(intPtr);
		ID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ID");
		ID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ID", Classes.FIntProperty);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		ActorType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorType");
		ActorType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorType", Classes.FClassProperty);
		BeginningDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginningDuration");
		BeginningDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginningDuration", Classes.FFloatProperty);
		FinishingDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinishingDuration");
		FinishingDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinishingDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, intPtr, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoEnable", Classes.FBoolProperty);
		UDispLib_PostPorcessCommonConf_IsValid = ((intPtr != IntPtr.Zero && ID_IsValid && Name_IsValid && ActorType_IsValid && BeginningDuration_IsValid && FinishingDuration_IsValid && AutoEnable_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UDispLib_PostPorcessCommonConf", (byte)UDispLib_PostPorcessCommonConf_IsValid != 0);
	}

	static UDispLib_PostPorcessCommonConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDispLib_PostPorcessCommonConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDispLib_PostPorcessCommonConf));
	}
}
