using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2")]
public class BGWDataAsset_InputMappingContextConfigV2 : UBGWDataAsset
{
	private static bool ChordActionDelayConflictActionDuration_IsValid;

	private static int ChordActionDelayConflictActionDuration_Offset;

	private static bool DefaultCustomizedInputType_IsValid;

	private static int DefaultCustomizedInputType_Offset;

	private static FFieldAddress DefaultCustomizedInputType_PropertyAddress;

	private static bool Configs_IsValid;

	private static int Configs_Offset;

	private static FFieldAddress Configs_PropertyAddress;

	private TMapReadWriteMarshaler<EInputMappingContextTagV2, FInputMappingContextConfigV2> Configs_Marshaler;

	[Category("组合键")]
	[DisplayName("组合键延迟冲突按键时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:ChordActionDelayConflictActionDuration")]
	public float ChordActionDelayConflictActionDuration
	{
		get
		{
			CheckDestroyed();
			if (!ChordActionDelayConflictActionDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:ChordActionDelayConflictActionDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChordActionDelayConflictActionDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChordActionDelayConflictActionDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:ChordActionDelayConflictActionDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChordActionDelayConflictActionDuration_Offset), value);
			}
		}
	}

	[Category("按键自定义")]
	[DisplayName("默认自定义输入配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:DefaultCustomizedInputType")]
	public ECustomizedInputType DefaultCustomizedInputType
	{
		get
		{
			CheckDestroyed();
			if (!DefaultCustomizedInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:DefaultCustomizedInputType");
				return ECustomizedInputType.None;
			}
			return EnumMarshaler<ECustomizedInputType>.FromNative(IntPtr.Add(base.Address, DefaultCustomizedInputType_Offset), 0, DefaultCustomizedInputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultCustomizedInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:DefaultCustomizedInputType");
			}
			else
			{
				EnumMarshaler<ECustomizedInputType>.ToNative(IntPtr.Add(base.Address, DefaultCustomizedInputType_Offset), 0, DefaultCustomizedInputType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("按键映射配置")]
	[Category("按键映射")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:Configs")]
	public TMapReadWrite<EInputMappingContextTagV2, FInputMappingContextConfigV2> Configs
	{
		get
		{
			CheckDestroyed();
			if (!Configs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2:Configs");
				return null;
			}
			if (Configs_Marshaler == null)
			{
				Configs_Marshaler = new TMapReadWriteMarshaler<EInputMappingContextTagV2, FInputMappingContextConfigV2>(1, Configs_PropertyAddress, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.FromNative, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.ToNative, CachedMarshalingDelegates<FInputMappingContextConfigV2, FInputMappingContextConfigV2>.FromNative, CachedMarshalingDelegates<FInputMappingContextConfigV2, FInputMappingContextConfigV2>.ToNative);
			}
			return Configs_Marshaler.FromNative(IntPtr.Add(base.Address, Configs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_InputMappingContextConfigV2");
		ChordActionDelayConflictActionDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChordActionDelayConflictActionDuration");
		ChordActionDelayConflictActionDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChordActionDelayConflictActionDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DefaultCustomizedInputType_PropertyAddress, unrealStruct, "DefaultCustomizedInputType");
		DefaultCustomizedInputType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultCustomizedInputType");
		DefaultCustomizedInputType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultCustomizedInputType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Configs_PropertyAddress, unrealStruct, "Configs");
		Configs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Configs");
		Configs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Configs", Classes.FMapProperty);
	}

	static BGWDataAsset_InputMappingContextConfigV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_InputMappingContextConfigV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_InputMappingContextConfigV2));
	}
}
