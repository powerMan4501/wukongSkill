using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting")]
public class BGWDataAsset_PostProcessMatSetting : UBGWDataAsset
{
	private static bool PostProcessMatInstances_IsValid;

	private static int PostProcessMatInstances_Offset;

	private static FFieldAddress PostProcessMatInstances_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> PostProcessMatInstances_Marshaler;

	private static bool PostProcessMatParams_IsValid;

	private static int PostProcessMatParams_Offset;

	private static FFieldAddress PostProcessMatParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FMatParam> PostProcessMatParams_Marshaler;

	private static bool Weights_IsValid;

	private static int Weights_Offset;

	private static FFieldAddress Weights_PropertyAddress;

	private TArrayReadWriteMarshaler<float> Weights_Marshaler;

	[Category("PostProcess")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:PostProcessMatInstances")]
	public TArrayReadWrite<UMaterialInterface> PostProcessMatInstances
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:PostProcessMatInstances");
				return null;
			}
			if (PostProcessMatInstances_Marshaler == null)
			{
				PostProcessMatInstances_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, PostProcessMatInstances_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return PostProcessMatInstances_Marshaler.FromNative(IntPtr.Add(base.Address, PostProcessMatInstances_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("PostProcess")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:PostProcessMatParams")]
	public TArrayReadWrite<FMatParam> PostProcessMatParams
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:PostProcessMatParams");
				return null;
			}
			if (PostProcessMatParams_Marshaler == null)
			{
				PostProcessMatParams_Marshaler = new TArrayReadWriteMarshaler<FMatParam>(1, PostProcessMatParams_PropertyAddress, CachedMarshalingDelegates<FMatParam, FMatParam>.FromNative, CachedMarshalingDelegates<FMatParam, FMatParam>.ToNative);
			}
			return PostProcessMatParams_Marshaler.FromNative(IntPtr.Add(base.Address, PostProcessMatParams_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("PostProcess")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:Weights")]
	public TArrayReadWrite<float> Weights
	{
		get
		{
			CheckDestroyed();
			if (!Weights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting:Weights");
				return null;
			}
			if (Weights_Marshaler == null)
			{
				Weights_Marshaler = new TArrayReadWriteMarshaler<float>(1, Weights_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return Weights_Marshaler.FromNative(IntPtr.Add(base.Address, Weights_Offset));
		}
	}

	public float ExistedTime { get; set; }

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PostProcessMatSetting");
		NativeReflection.GetPropertyRef(ref PostProcessMatInstances_PropertyAddress, unrealStruct, "PostProcessMatInstances");
		PostProcessMatInstances_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatInstances");
		PostProcessMatInstances_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatInstances", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PostProcessMatParams_PropertyAddress, unrealStruct, "PostProcessMatParams");
		PostProcessMatParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatParams");
		PostProcessMatParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Weights_PropertyAddress, unrealStruct, "Weights");
		Weights_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Weights");
		Weights_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Weights", Classes.FArrayProperty);
	}

	static BGWDataAsset_PostProcessMatSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PostProcessMatSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PostProcessMatSetting));
	}
}
