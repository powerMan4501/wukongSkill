using System;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_B1DBC")]
public class BGWDataAsset_B1DBC : BUC_DispLibDispBaseConfigDataAsset
{
	private static bool ExtraSetting_IsValid;

	private static int ExtraSetting_Offset;

	[Category("B1ExtraSetting")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("B1额外配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_B1DBC:ExtraSetting")]
	public B1DBC_ExtraSetting ExtraSetting
	{
		get
		{
			CheckDestroyed();
			if (!ExtraSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_B1DBC:ExtraSetting");
				return default(B1DBC_ExtraSetting);
			}
			return B1DBC_ExtraSetting.FromNative(IntPtr.Add(base.Address, ExtraSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtraSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_B1DBC:ExtraSetting");
			}
			else
			{
				B1DBC_ExtraSetting.ToNative(IntPtr.Add(base.Address, ExtraSetting_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_B1DBC");
		ExtraSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExtraSetting");
		ExtraSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExtraSetting", Classes.FStructProperty);
	}

	static BGWDataAsset_B1DBC()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_B1DBC)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_B1DBC));
	}
}
