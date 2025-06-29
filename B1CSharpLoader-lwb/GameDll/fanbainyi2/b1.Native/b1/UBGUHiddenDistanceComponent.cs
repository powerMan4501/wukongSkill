using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUHiddenDistanceComponent", "b1", UnrealModuleType.Game)]
public class UBGUHiddenDistanceComponent : UActorComponent
{
	private static bool SupportComponents_IsValid;

	private static FFieldAddress SupportComponents_PropertyAddress;

	private static int SupportComponents_Offset;

	private TArrayReadWriteMarshaler<TSoftClass<UPrimitiveComponent>> SupportComponents_MarshalerCached;

	private static bool FadeOutDistance_IsValid;

	private static int FadeOutDistance_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/b1.BGUHiddenDistanceComponent:SupportComponents")]
	public TArrayReadWrite<TSoftClass<UPrimitiveComponent>> SupportComponents
	{
		get
		{
			CheckDestroyed();
			if (!SupportComponents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUHiddenDistanceComponent:SupportComponents");
				return null;
			}
			if (SupportComponents_MarshalerCached == null)
			{
				SupportComponents_MarshalerCached = new TArrayReadWriteMarshaler<TSoftClass<UPrimitiveComponent>>(1, SupportComponents_PropertyAddress, CachedMarshalingDelegates<TSoftClass<UPrimitiveComponent>, TSoftClassMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<TSoftClass<UPrimitiveComponent>, TSoftClassMarshaler<UPrimitiveComponent>>.ToNative);
			}
			return SupportComponents_MarshalerCached.FromNative(IntPtr.Add(base.Address, SupportComponents_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUHiddenDistanceComponent:FadeOutDistance")]
	public float FadeOutDistance
	{
		get
		{
			CheckDestroyed();
			if (!FadeOutDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUHiddenDistanceComponent:FadeOutDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeOutDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeOutDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUHiddenDistanceComponent:FadeOutDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeOutDistance_Offset), value);
			}
		}
	}

	static UBGUHiddenDistanceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUHiddenDistanceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUHiddenDistanceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGUHiddenDistanceComponent");
		NativeReflectionCached.GetPropertyRef(ref SupportComponents_PropertyAddress, unrealStruct, "SupportComponents");
		SupportComponents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SupportComponents");
		SupportComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SupportComponents", Classes.FArrayProperty);
		FadeOutDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FadeOutDistance");
		FadeOutDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FadeOutDistance", Classes.FFloatProperty);
	}
}
