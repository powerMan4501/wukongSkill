using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset")]
public sealed class BUC_DBCCustomEventExampleDataAsset : DispLibDBCCustomEventDataAssetBase
{
	private static bool MyBool_IsValid;

	private static int MyBool_Offset;

	private static FFieldAddress MyBool_PropertyAddress;

	private static bool MyLinearColor_IsValid;

	private static int MyLinearColor_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyBool")]
	public bool MyBool
	{
		get
		{
			CheckDestroyed();
			if (!MyBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyBool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MyBool_Offset), 0, MyBool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MyBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyBool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MyBool_Offset), 0, MyBool_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyLinearColor")]
	public FLinearColor MyLinearColor
	{
		get
		{
			CheckDestroyed();
			if (!MyLinearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyLinearColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, MyLinearColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MyLinearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset:MyLinearColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, MyLinearColor_Offset), value);
			}
		}
	}

	public override DispLibDBCCustomEventType GetEventType()
	{
		return DispLibDBCCustomEventType.None;
	}

	public override bool AllowOverrideTriggerMode()
	{
		return false;
	}

	public override DispLibDBCCustomEventTriggerMode GetDefaultTriggerMode()
	{
		return DispLibDBCCustomEventTriggerMode.Immediate;
	}

	public override bool AllowOverrideEndMode()
	{
		return true;
	}

	public override DispLibDBCEndMode GetDefaultEndMode()
	{
		return DispLibDBCEndMode.ProcedureNotity;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DBCCustomEventExampleDataAsset");
		NativeReflection.GetPropertyRef(ref MyBool_PropertyAddress, unrealStruct, "MyBool");
		MyBool_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MyBool");
		MyBool_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MyBool", Classes.FBoolProperty);
		MyLinearColor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MyLinearColor");
		MyLinearColor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MyLinearColor", Classes.FStructProperty);
	}

	static BUC_DBCCustomEventExampleDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DBCCustomEventExampleDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DBCCustomEventExampleDataAsset));
	}
}
