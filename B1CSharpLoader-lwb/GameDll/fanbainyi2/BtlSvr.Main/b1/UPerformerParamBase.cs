using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[EditInlineNew]
[CollapseCategories(true)]
[USharpPath("/Script/b1-Managed.PerformerParamBase")]
public class UPerformerParamBase : UBGWObjectExtend
{
	private static bool ParamType_IsValid;

	private static int ParamType_Offset;

	private static FFieldAddress ParamType_PropertyAddress;

	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParamBase:ParamType")]
	public EPerformerParamType ParamType
	{
		get
		{
			CheckDestroyed();
			if (!ParamType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ParamType");
				return EPerformerParamType.None;
			}
			return EnumMarshaler<EPerformerParamType>.FromNative(IntPtr.Add(base.Address, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ParamType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ParamType");
			}
			else
			{
				EnumMarshaler<EPerformerParamType>.ToNative(IntPtr.Add(base.Address, ParamType_Offset), 0, ParamType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParamBase:ConfigGuid")]
	public FCalliopeGuid ConfigGuid
	{
		get
		{
			CheckDestroyed();
			if (!ConfigGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ConfigGuid");
				return default(FCalliopeGuid);
			}
			return FCalliopeGuid.FromNative(IntPtr.Add(base.Address, ConfigGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ConfigGuid");
			}
			else
			{
				FCalliopeGuid.ToNative(IntPtr.Add(base.Address, ConfigGuid_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerParamBase:ParamName")]
	public FName ParamName
	{
		get
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ParamName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerParamBase:ParamName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ParamName_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ConfigGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
		ParamType = EPerformerParamType.None;
	}

	public virtual string GetDisplayName()
	{
		return ParamName.ToString();
	}

	public virtual string GetActorGuid()
	{
		return "";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerParamBase");
		NativeReflection.GetPropertyRef(ref ParamType_PropertyAddress, unrealStruct, "ParamType");
		ParamType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParamType");
		ParamType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigGuid", Classes.FStructProperty);
		ParamName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParamName", Classes.FNameProperty);
	}

	static UPerformerParamBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerParamBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerParamBase));
	}
}
