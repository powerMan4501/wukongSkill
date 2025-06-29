using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContentEditor;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor", "VariantManagerContentEditor", UnrealModuleType.EnginePlugin)]
public class AVariantManagerTestActor : AActor
{
	private static bool EnumWithNoDefault_IsValid;

	private static FFieldAddress EnumWithNoDefault_PropertyAddress;

	private static int EnumWithNoDefault_Offset;

	private static bool EnumWithSecondDefault_IsValid;

	private static FFieldAddress EnumWithSecondDefault_PropertyAddress;

	private static int EnumWithSecondDefault_Offset;

	private static bool CapturedByteProperty_IsValid;

	private static int CapturedByteProperty_Offset;

	private static bool CapturedIntProperty_IsValid;

	private static int CapturedIntProperty_Offset;

	private static bool CapturedFloatProperty_IsValid;

	private static int CapturedFloatProperty_Offset;

	private static bool CapturedBoolProperty_IsValid;

	private static FFieldAddress CapturedBoolProperty_PropertyAddress;

	private static int CapturedBoolProperty_Offset;

	private static bool CapturedObjectProperty_IsValid;

	private static int CapturedObjectProperty_Offset;

	private static bool CapturedInterfaceProperty_IsValid;

	private static int CapturedInterfaceProperty_Offset;

	private static bool CapturedNameProperty_IsValid;

	private static int CapturedNameProperty_Offset;

	private static bool CapturedStrProperty_IsValid;

	private static int CapturedStrProperty_Offset;

	private static bool CapturedTextProperty_IsValid;

	private static int CapturedTextProperty_Offset;

	private FText CapturedTextProperty_TextCached;

	private static bool CapturedRotatorProperty_IsValid;

	private static int CapturedRotatorProperty_Offset;

	private static bool CapturedColorProperty_IsValid;

	private static int CapturedColorProperty_Offset;

	private static bool CapturedLinearColorProperty_IsValid;

	private static int CapturedLinearColorProperty_Offset;

	private static bool CapturedVectorProperty_IsValid;

	private static int CapturedVectorProperty_Offset;

	private static bool CapturedQuatProperty_IsValid;

	private static int CapturedQuatProperty_Offset;

	private static bool CapturedVector4Property_IsValid;

	private static int CapturedVector4Property_Offset;

	private static bool CapturedVector2DProperty_IsValid;

	private static int CapturedVector2DProperty_Offset;

	private static bool CapturedIntPointProperty_IsValid;

	private static int CapturedIntPointProperty_Offset;

	private static bool CapturedUObjectArrayProperty_IsValid;

	private static FFieldAddress CapturedUObjectArrayProperty_PropertyAddress;

	private static int CapturedUObjectArrayProperty_Offset;

	private TArrayReadWriteMarshaler<UObject> CapturedUObjectArrayProperty_MarshalerCached;

	private static bool CapturedVectorArrayProperty_IsValid;

	private static FFieldAddress CapturedVectorArrayProperty_PropertyAddress;

	private static int CapturedVectorArrayProperty_Offset;

	private TArrayReadWriteMarshaler<FVector> CapturedVectorArrayProperty_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithNoDefault")]
	public EVariantManagerTestEnum EnumWithNoDefault
	{
		get
		{
			CheckDestroyed();
			if (!EnumWithNoDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithNoDefault");
				return EVariantManagerTestEnum.None;
			}
			return EnumMarshaler<EVariantManagerTestEnum>.FromNative(IntPtr.Add(base.Address, EnumWithNoDefault_Offset), 0, EnumWithNoDefault_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnumWithNoDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithNoDefault");
			}
			else
			{
				EnumMarshaler<EVariantManagerTestEnum>.ToNative(IntPtr.Add(base.Address, EnumWithNoDefault_Offset), 0, EnumWithNoDefault_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithSecondDefault")]
	public EVariantManagerTestEnum EnumWithSecondDefault
	{
		get
		{
			CheckDestroyed();
			if (!EnumWithSecondDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithSecondDefault");
				return EVariantManagerTestEnum.None;
			}
			return EnumMarshaler<EVariantManagerTestEnum>.FromNative(IntPtr.Add(base.Address, EnumWithSecondDefault_Offset), 0, EnumWithSecondDefault_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnumWithSecondDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:EnumWithSecondDefault");
			}
			else
			{
				EnumMarshaler<EVariantManagerTestEnum>.ToNative(IntPtr.Add(base.Address, EnumWithSecondDefault_Offset), 0, EnumWithSecondDefault_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedByteProperty")]
	public byte CapturedByteProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedByteProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedByteProperty");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, CapturedByteProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedByteProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedByteProperty");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, CapturedByteProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntProperty")]
	public int CapturedIntProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntProperty");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CapturedIntProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntProperty");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CapturedIntProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedFloatProperty")]
	public float CapturedFloatProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedFloatProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedFloatProperty");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapturedFloatProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedFloatProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedFloatProperty");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapturedFloatProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:bCapturedBoolProperty")]
	public bool CapturedBoolProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedBoolProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:bCapturedBoolProperty");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CapturedBoolProperty_Offset), 0, CapturedBoolProperty_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CapturedBoolProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:bCapturedBoolProperty");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CapturedBoolProperty_Offset), 0, CapturedBoolProperty_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedObjectProperty")]
	public UObject CapturedObjectProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedObjectProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedObjectProperty");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, CapturedObjectProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedObjectProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedObjectProperty");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, CapturedObjectProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedInterfaceProperty")]
	public IInterface CapturedInterfaceProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedInterfaceProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedInterfaceProperty");
				return null;
			}
			return InterfaceMarshaler<IInterface>.FromNative(IntPtr.Add(base.Address, CapturedInterfaceProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedInterfaceProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedInterfaceProperty");
			}
			else
			{
				InterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(base.Address, CapturedInterfaceProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedNameProperty")]
	public FName CapturedNameProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedNameProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedNameProperty");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CapturedNameProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedNameProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedNameProperty");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CapturedNameProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedStrProperty")]
	public string CapturedStrProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedStrProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedStrProperty");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CapturedStrProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedStrProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedStrProperty");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CapturedStrProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedTextProperty")]
	public FText CapturedTextProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedTextProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedTextProperty");
				return null;
			}
			if (CapturedTextProperty_TextCached == null)
			{
				CapturedTextProperty_TextCached = new FText(IntPtr.Add(base.Address, CapturedTextProperty_Offset), createReference: false);
			}
			return CapturedTextProperty_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!CapturedTextProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedTextProperty");
				return;
			}
			if (CapturedTextProperty_TextCached == null)
			{
				CapturedTextProperty_TextCached = new FText(IntPtr.Add(base.Address, CapturedTextProperty_Offset), createReference: false);
			}
			CapturedTextProperty_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedRotatorProperty")]
	public FRotator CapturedRotatorProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedRotatorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedRotatorProperty");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, CapturedRotatorProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedRotatorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedRotatorProperty");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, CapturedRotatorProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedColorProperty")]
	public FColor CapturedColorProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedColorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedColorProperty");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, CapturedColorProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedColorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedColorProperty");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, CapturedColorProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedLinearColorProperty")]
	public FLinearColor CapturedLinearColorProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedLinearColorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedLinearColorProperty");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, CapturedLinearColorProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedLinearColorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedLinearColorProperty");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, CapturedLinearColorProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVectorProperty")]
	public FVector CapturedVectorProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedVectorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVectorProperty");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CapturedVectorProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedVectorProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVectorProperty");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CapturedVectorProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedQuatProperty")]
	public FQuat CapturedQuatProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedQuatProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedQuatProperty");
				return default(FQuat);
			}
			return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(base.Address, CapturedQuatProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedQuatProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedQuatProperty");
			}
			else
			{
				BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(base.Address, CapturedQuatProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector4Property")]
	public FVector4 CapturedVector4Property
	{
		get
		{
			CheckDestroyed();
			if (!CapturedVector4Property_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector4Property");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, CapturedVector4Property_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedVector4Property_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector4Property");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, CapturedVector4Property_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector2DProperty")]
	public FVector2D CapturedVector2DProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedVector2DProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector2DProperty");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, CapturedVector2DProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedVector2DProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVector2DProperty");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, CapturedVector2DProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntPointProperty")]
	public FIntPoint CapturedIntPointProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedIntPointProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntPointProperty");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, CapturedIntPointProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapturedIntPointProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedIntPointProperty");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, CapturedIntPointProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedUObjectArrayProperty")]
	public TArrayReadWrite<UObject> CapturedUObjectArrayProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedUObjectArrayProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedUObjectArrayProperty");
				return null;
			}
			if (CapturedUObjectArrayProperty_MarshalerCached == null)
			{
				CapturedUObjectArrayProperty_MarshalerCached = new TArrayReadWriteMarshaler<UObject>(1, CapturedUObjectArrayProperty_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return CapturedUObjectArrayProperty_MarshalerCached.FromNative(IntPtr.Add(base.Address, CapturedUObjectArrayProperty_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVectorArrayProperty")]
	public TArrayReadWrite<FVector> CapturedVectorArrayProperty
	{
		get
		{
			CheckDestroyed();
			if (!CapturedVectorArrayProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContentEditor.VariantManagerTestActor:CapturedVectorArrayProperty");
				return null;
			}
			if (CapturedVectorArrayProperty_MarshalerCached == null)
			{
				CapturedVectorArrayProperty_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, CapturedVectorArrayProperty_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return CapturedVectorArrayProperty_MarshalerCached.FromNative(IntPtr.Add(base.Address, CapturedVectorArrayProperty_Offset));
		}
	}

	static AVariantManagerTestActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVariantManagerTestActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVariantManagerTestActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/VariantManagerContentEditor.VariantManagerTestActor");
		NativeReflectionCached.GetPropertyRef(ref EnumWithNoDefault_PropertyAddress, unrealStruct, "EnumWithNoDefault");
		EnumWithNoDefault_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnumWithNoDefault");
		EnumWithNoDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnumWithNoDefault", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnumWithSecondDefault_PropertyAddress, unrealStruct, "EnumWithSecondDefault");
		EnumWithSecondDefault_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnumWithSecondDefault");
		EnumWithSecondDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnumWithSecondDefault", Classes.FEnumProperty);
		CapturedByteProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedByteProperty");
		CapturedByteProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedByteProperty", Classes.FByteProperty);
		CapturedIntProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedIntProperty");
		CapturedIntProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedIntProperty", Classes.FIntProperty);
		CapturedFloatProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedFloatProperty");
		CapturedFloatProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedFloatProperty", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CapturedBoolProperty_PropertyAddress, unrealStruct, "bCapturedBoolProperty");
		CapturedBoolProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCapturedBoolProperty");
		CapturedBoolProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCapturedBoolProperty", Classes.FBoolProperty);
		CapturedObjectProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedObjectProperty");
		CapturedObjectProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedObjectProperty", Classes.FObjectProperty);
		CapturedInterfaceProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedInterfaceProperty");
		CapturedInterfaceProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedInterfaceProperty", Classes.FInterfaceProperty);
		CapturedNameProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedNameProperty");
		CapturedNameProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedNameProperty", Classes.FNameProperty);
		CapturedStrProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedStrProperty");
		CapturedStrProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedStrProperty", Classes.FStrProperty);
		CapturedTextProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedTextProperty");
		CapturedTextProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedTextProperty", Classes.FTextProperty);
		CapturedRotatorProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedRotatorProperty");
		CapturedRotatorProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedRotatorProperty", Classes.FStructProperty);
		CapturedColorProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedColorProperty");
		CapturedColorProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedColorProperty", Classes.FStructProperty);
		CapturedLinearColorProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedLinearColorProperty");
		CapturedLinearColorProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedLinearColorProperty", Classes.FStructProperty);
		CapturedVectorProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedVectorProperty");
		CapturedVectorProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedVectorProperty", Classes.FStructProperty);
		CapturedQuatProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedQuatProperty");
		CapturedQuatProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedQuatProperty", Classes.FStructProperty);
		CapturedVector4Property_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedVector4Property");
		CapturedVector4Property_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedVector4Property", Classes.FStructProperty);
		CapturedVector2DProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedVector2DProperty");
		CapturedVector2DProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedVector2DProperty", Classes.FStructProperty);
		CapturedIntPointProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedIntPointProperty");
		CapturedIntPointProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedIntPointProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CapturedUObjectArrayProperty_PropertyAddress, unrealStruct, "CapturedUObjectArrayProperty");
		CapturedUObjectArrayProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedUObjectArrayProperty");
		CapturedUObjectArrayProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedUObjectArrayProperty", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CapturedVectorArrayProperty_PropertyAddress, unrealStruct, "CapturedVectorArrayProperty");
		CapturedVectorArrayProperty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CapturedVectorArrayProperty");
		CapturedVectorArrayProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CapturedVectorArrayProperty", Classes.FArrayProperty);
	}
}
