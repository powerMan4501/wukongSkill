using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("[已废弃] BAN DispLib Change Unit Material")]
[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial")]
internal class BAN_DispLibChangeUnitMaterial : BAN_GSBase
{
	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool template_IsValid;

	private static int template_Offset;

	private static bool InheriParamsMode_IsValid;

	private static int InheriParamsMode_Offset;

	private static FFieldAddress InheriParamsMode_PropertyAddress;

	private static bool InheritScalarParam_IsValid;

	private static int InheritScalarParam_Offset;

	private static FFieldAddress InheritScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritScalarParam_Marshaler;

	private static bool InheritFLinearColorParam_IsValid;

	private static int InheritFLinearColorParam_Offset;

	private static FFieldAddress InheritFLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritFLinearColorParam_Marshaler;

	private static bool InheritTextureParam_IsValid;

	private static int InheritTextureParam_Offset;

	private static FFieldAddress InheritTextureParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> InheritTextureParam_Marshaler;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("影响范围")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode
	{
		get
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:FilterMode");
				return default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			}
			return BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(base.Address, FilterMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilterMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:FilterMode");
			}
			else
			{
				BUC_DispLibDBC_MaterialEffectTargetInfo.ToNative(IntPtr.Add(base.Address, FilterMode_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:template")]
	public UMaterialInterface template
	{
		get
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:template");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:template");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "参数继承方式 ")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheriParamsMode")]
	public DispLibMaterialParamsInheritMode InheriParamsMode
	{
		get
		{
			CheckDestroyed();
			if (!InheriParamsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheriParamsMode");
				return DispLibMaterialParamsInheritMode.NoInherit;
			}
			return EnumMarshaler<DispLibMaterialParamsInheritMode>.FromNative(IntPtr.Add(base.Address, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheriParamsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheriParamsMode");
			}
			else
			{
				EnumMarshaler<DispLibMaterialParamsInheritMode>.ToNative(IntPtr.Add(base.Address, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.DisplayName, "继承旧材质 Scalar 参数名 ")]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritScalarParam")]
	public TArrayReadWrite<FName> InheritScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritScalarParam");
				return null;
			}
			if (InheritScalarParam_Marshaler == null)
			{
				InheritScalarParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritScalarParam_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "继承旧材质 FLinearColor 参数名 ")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritFLinearColorParam")]
	public TArrayReadWrite<FName> InheritFLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritFLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritFLinearColorParam");
				return null;
			}
			if (InheritFLinearColorParam_Marshaler == null)
			{
				InheritFLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritFLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritFLinearColorParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.DisplayName, "继承旧材质 Texture 参数名 ")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritTextureParam")]
	public TArrayReadWrite<FName> InheritTextureParam
	{
		get
		{
			CheckDestroyed();
			if (!InheritTextureParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:InheritTextureParam");
				return null;
			}
			if (InheritTextureParam_Marshaler == null)
			{
				InheritTextureParam_Marshaler = new TArrayReadWriteMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return InheritTextureParam_Marshaler.FromNative(IntPtr.Add(base.Address, InheritTextureParam_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(NotifyParam.MeshComp.GetOwner());
		if (bUS_DispLibEventCollection != null && FilterMode.isVaild())
		{
			if (InheriParamsMode == DispLibMaterialParamsInheritMode.CustomInheritParamsNameArray)
			{
				bUS_DispLibEventCollection.Evt_CreateNewMaterialsWithCustomParamsByList(DispLibRefParam.Instance, FilterMode, template, InheritCurParamQueue: true, InheritScalarParam.ToList(), InheritFLinearColorParam.ToList(), InheritTextureParam.ToList());
			}
			else
			{
				bUS_DispLibEventCollection.Evt_CreateNewMaterials(DispLibRefParam.Instance, FilterMode, template, InheriParamsMode);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibChangeUnitMaterial bAN_DispLibChangeUnitMaterial = GCHelper.Find<GSDispLib.BAN_DispLibChangeUnitMaterial>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibChangeUnitMaterial.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial");
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		template_Offset = NativeReflection.GetPropertyOffset(intPtr, "template");
		template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "template", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref InheriParamsMode_PropertyAddress, intPtr, "InheriParamsMode");
		InheriParamsMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheriParamsMode");
		InheriParamsMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheriParamsMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InheritScalarParam_PropertyAddress, intPtr, "InheritScalarParam");
		InheritScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritScalarParam");
		InheritScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InheritFLinearColorParam_PropertyAddress, intPtr, "InheritFLinearColorParam");
		InheritFLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritFLinearColorParam");
		InheritFLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritFLinearColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InheritTextureParam_PropertyAddress, intPtr, "InheritTextureParam");
		InheritTextureParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "InheritTextureParam");
		InheritTextureParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InheritTextureParam", Classes.FArrayProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibChangeUnitMaterial:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibChangeUnitMaterial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibChangeUnitMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibChangeUnitMaterial));
	}
}
