using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimSequenceBase", "Engine", UnrealModuleType.Engine)]
public class UAnimSequenceBase : UAnimationAsset
{
	private static bool SequenceLength_IsValid;

	private static int SequenceLength_Offset;

	private static bool DataModel_IsValid;

	private static int DataModel_Offset;

	private static bool Controller_IsValid;

	private static int Controller_Offset;

	[UProperty(Flags = (PropFlags)6756568746033685uL)]
	[UMetaPath("/Script/Engine.AnimSequenceBase:SequenceLength")]
	public float SequenceLength
	{
		get
		{
			CheckDestroyed();
			if (!SequenceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:SequenceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SequenceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:SequenceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SequenceLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393799221379605uL)]
	[UMetaPath("/Script/Engine.AnimSequenceBase:DataModel")]
	protected UAnimDataModel DataModel
	{
		get
		{
			CheckDestroyed();
			if (!DataModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:DataModel");
				return null;
			}
			return UObjectMarshaler<UAnimDataModel>.FromNative(IntPtr.Add(base.Address, DataModel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:DataModel");
			}
			else
			{
				UObjectMarshaler<UAnimDataModel>.ToNative(IntPtr.Add(base.Address, DataModel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393799223484949uL)]
	[UMetaPath("/Script/Engine.AnimSequenceBase:Controller")]
	protected IAnimationDataController Controller
	{
		get
		{
			CheckDestroyed();
			if (!Controller_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:Controller");
				return null;
			}
			return InterfaceMarshaler<IAnimationDataController>.FromNative(IntPtr.Add(base.Address, Controller_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Controller_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimSequenceBase:Controller");
			}
			else
			{
				InterfaceMarshaler<IAnimationDataController>.ToNative(IntPtr.Add(base.Address, Controller_Offset), value);
			}
		}
	}

	static UAnimSequenceBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSequenceBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSequenceBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AnimSequenceBase");
		SequenceLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SequenceLength");
		SequenceLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SequenceLength", Classes.FFloatProperty);
		DataModel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DataModel");
		DataModel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DataModel", Classes.FObjectProperty);
		Controller_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Controller");
		Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Controller", Classes.FInterfaceProperty);
	}
}
