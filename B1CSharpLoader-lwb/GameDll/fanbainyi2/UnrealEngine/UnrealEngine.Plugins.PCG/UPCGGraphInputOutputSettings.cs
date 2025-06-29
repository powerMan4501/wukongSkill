using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)827326624uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGGraphInputOutputSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGraphInputOutputSettings : UPCGSettings
{
	private static bool CustomPins_IsValid;

	private static FFieldAddress CustomPins_PropertyAddress;

	private static int CustomPins_Offset;

	private TArrayReadWriteMarshaler<FPCGPinProperties> CustomPins_MarshalerCached;

	[UProperty(Flags = (PropFlags)9015995347763717uL)]
	[UMetaPath("/Script/PCG.PCGGraphInputOutputSettings:CustomPins")]
	protected TArrayReadWrite<FPCGPinProperties> CustomPins
	{
		get
		{
			CheckDestroyed();
			if (!CustomPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraphInputOutputSettings:CustomPins");
				return null;
			}
			if (CustomPins_MarshalerCached == null)
			{
				CustomPins_MarshalerCached = new TArrayReadWriteMarshaler<FPCGPinProperties>(1, CustomPins_PropertyAddress, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.FromNative, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.ToNative);
			}
			return CustomPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, CustomPins_Offset));
		}
	}

	static UPCGGraphInputOutputSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGraphInputOutputSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGraphInputOutputSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGGraphInputOutputSettings");
		NativeReflectionCached.GetPropertyRef(ref CustomPins_PropertyAddress, unrealStruct, "CustomPins");
		CustomPins_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomPins");
		CustomPins_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomPins", Classes.FArrayProperty);
	}
}
