using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting")]
public struct FGSBeamFXPlaySetting
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:BeamTemplate")]
	public TSoftObject<UNiagaraSystem> BeamTemplate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:IsAttach")]
	public bool IsAttach;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:AttachSocketName")]
	public FName AttachSocketName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:Scale")]
	public FVector Scale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:GSBeamTargetType")]
	public EBeamFXTargetActorType GSBeamTargetType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:GSBeamTargetParamName")]
	public string GSBeamTargetParamName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBeamFXPlaySetting:TargetSocketName")]
	public FName TargetSocketName;

	private static int FGSBeamFXPlaySetting_StructSize;

	private static int FGSBeamFXPlaySetting_IsValid;

	private static bool BeamTemplate_IsValid;

	private static int BeamTemplate_Offset;

	private static bool IsAttach_IsValid;

	private static int IsAttach_Offset;

	private static FFieldAddress IsAttach_PropertyAddress;

	private static bool AttachSocketName_IsValid;

	private static int AttachSocketName_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool GSBeamTargetType_IsValid;

	private static int GSBeamTargetType_Offset;

	private static FFieldAddress GSBeamTargetType_PropertyAddress;

	private static bool GSBeamTargetParamName_IsValid;

	private static int GSBeamTargetParamName_Offset;

	private static bool TargetSocketName_IsValid;

	private static int TargetSocketName_Offset;

	public FGSBeamFXPlaySetting Copy()
	{
		return this;
	}

	public static FGSBeamFXPlaySetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSBeamFXPlaySetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSBeamFXPlaySetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSBeamFXPlaySetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSBeamFXPlaySetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSBeamFXPlaySetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSBeamFXPlaySetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSBeamFXPlaySetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSBeamFXPlaySetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBeamFXPlaySetting");
			return;
		}
		TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, BeamTemplate_Offset), BeamTemplate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAttach_Offset), 0, IsAttach_PropertyAddress.Address, IsAttach);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachSocketName_Offset), AttachSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		EnumMarshaler<EBeamFXTargetActorType>.ToNative(IntPtr.Add(nativeStruct, GSBeamTargetType_Offset), 0, GSBeamTargetType_PropertyAddress.Address, GSBeamTargetType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, GSBeamTargetParamName_Offset), GSBeamTargetParamName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TargetSocketName_Offset), TargetSocketName);
	}

	public FGSBeamFXPlaySetting(IntPtr nativeStruct)
	{
		if (FGSBeamFXPlaySetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBeamFXPlaySetting");
			BeamTemplate = default(TSoftObject<UNiagaraSystem>);
			IsAttach = false;
			AttachSocketName = default(FName);
			Scale = default(FVector);
			GSBeamTargetType = EBeamFXTargetActorType.Zero;
			GSBeamTargetParamName = null;
			TargetSocketName = default(FName);
		}
		else
		{
			BeamTemplate = TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, BeamTemplate_Offset));
			IsAttach = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAttach_Offset), 0, IsAttach_PropertyAddress.Address);
			AttachSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachSocketName_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			GSBeamTargetType = EnumMarshaler<EBeamFXTargetActorType>.FromNative(IntPtr.Add(nativeStruct, GSBeamTargetType_Offset), 0, GSBeamTargetType_PropertyAddress.Address);
			GSBeamTargetParamName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, GSBeamTargetParamName_Offset));
			TargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TargetSocketName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSBeamFXPlaySetting");
		FGSBeamFXPlaySetting_StructSize = NativeReflection.GetStructSize(intPtr);
		BeamTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeamTemplate");
		BeamTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeamTemplate", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref IsAttach_PropertyAddress, intPtr, "IsAttach");
		IsAttach_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsAttach");
		IsAttach_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsAttach", Classes.FBoolProperty);
		AttachSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachSocketName");
		AttachSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachSocketName", Classes.FNameProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GSBeamTargetType_PropertyAddress, intPtr, "GSBeamTargetType");
		GSBeamTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSBeamTargetType");
		GSBeamTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSBeamTargetType", Classes.FEnumProperty);
		GSBeamTargetParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSBeamTargetParamName");
		GSBeamTargetParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSBeamTargetParamName", Classes.FStrProperty);
		TargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSocketName");
		TargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSocketName", Classes.FNameProperty);
		FGSBeamFXPlaySetting_IsValid = ((intPtr != IntPtr.Zero && BeamTemplate_IsValid && IsAttach_IsValid && AttachSocketName_IsValid && Scale_IsValid && GSBeamTargetType_IsValid && GSBeamTargetParamName_IsValid && TargetSocketName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSBeamFXPlaySetting", (byte)FGSBeamFXPlaySetting_IsValid != 0);
	}

	static FGSBeamFXPlaySetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSBeamFXPlaySetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSBeamFXPlaySetting));
	}
}
