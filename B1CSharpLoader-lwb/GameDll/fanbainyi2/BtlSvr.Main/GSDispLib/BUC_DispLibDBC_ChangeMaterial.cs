using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial")]
public struct BUC_DispLibDBC_ChangeMaterial
{
	[DisplayName("影响范围")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	[DisplayName("延迟时间")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:Delay")]
	public float Delay;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:Duration")]
	public float Duration;

	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "表现逻辑层通知材质表现应该结束时要额外延后多长时间真正结束材质，小于等于0会立即结束，否则会进行销毁阶段参数更新; EndMode 是 AutoRelease 时无效")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Template")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:Template")]
	public UMaterialInterface Template;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "旧参数继承方式")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:InheriParamsMode")]
	public DispLibMaterialParamsInheritMode InheriParamsMode;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.DisplayName, "继承旧材质 Scalar 参数名")]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Scalar 参数")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:InheritScalarParam")]
	public List<FName> InheritScalarParam;

	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 FLinearColor 参数")]
	[UMeta(MD.DisplayName, "继承旧材质 FLinearColor 参数名")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:InheritFLinearColorParam")]
	public List<FName> InheritFLinearColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "InheriParamsMode == DispLibMaterialParamsInheritMode::CustomInheritParamsNameArray")]
	[UMeta(MD.DisplayName, "继承旧材质 Texture 参数名")]
	[UMeta(MD.ToolTip, "旧参数继承方式是【自定义】时继承这些 Texture 参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:InheritTextureParam")]
	public List<FName> InheritTextureParam;

	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置Scalar参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:SetScalarParam")]
	public List<BUC_DispLibUtil_NameAndScalar> SetScalarParam;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "设置Color参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:SetColorParam")]
	public List<BUC_DispLibUtil_NameAndLColor> SetColorParam;

	[UMeta(MD.DisplayName, "Scalar 参数曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:SetCurveScalarParam")]
	public List<BUC_DispLibUtil_NameAndScalarCurve> SetCurveScalarParam;

	[UProperty]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "LColor 参数曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:SetCurveLColorParam")]
	public List<BUC_DispLibUtil_NameAndLColorCurve> SetCurveLColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Vector3 参数曲线")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:SetCurveV3Param")]
	public List<BUC_DispLibUtil_NameAndVectorCurve> SetCurveV3Param;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "进入 EndStage 后指定参数会缓存当前的参数值并在 TimeStage.X 的时间内线性插值到 Value")]
	[DisplayName("结束阶段 Scalar 参数程序曲线")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "DelayTimeAfterStop > 0.001")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:EndStage_SetPCurveScalarParam")]
	public List<BUC_DispLibUtil_PCurve_NameAndScalar> EndStage_SetPCurveScalarParam;

	[UMeta(MD.ToolTip, "进入 EndStage 后指定参数会缓存当前的参数值在 TimeStage.X 的时间内线性插值到 Value")]
	[DisplayName("结束阶段 LColor 参数程序曲线")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "DelayTimeAfterStop > 0.001")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:EndStage_SetPCurveLColorParam")]
	public List<BUC_DispLibUtil_PCurve_NameAndLColor> EndStage_SetPCurveLColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:PausePriority")]
	public int PausePriority;

	[DisplayName("结束表现阶段优先级")]
	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial:EndStagePriority")]
	public int EndStagePriority;

	private static int BUC_DispLibDBC_ChangeMaterial_StructSize;

	private static int BUC_DispLibDBC_ChangeMaterial_IsValid;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool InheriParamsMode_IsValid;

	private static int InheriParamsMode_Offset;

	private static FFieldAddress InheriParamsMode_PropertyAddress;

	private static bool InheritScalarParam_IsValid;

	private static int InheritScalarParam_Offset;

	private static FFieldAddress InheritScalarParam_PropertyAddress;

	private static bool InheritFLinearColorParam_IsValid;

	private static int InheritFLinearColorParam_Offset;

	private static FFieldAddress InheritFLinearColorParam_PropertyAddress;

	private static bool InheritTextureParam_IsValid;

	private static int InheritTextureParam_Offset;

	private static FFieldAddress InheritTextureParam_PropertyAddress;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private static bool SetColorParam_IsValid;

	private static int SetColorParam_Offset;

	private static FFieldAddress SetColorParam_PropertyAddress;

	private static bool SetCurveScalarParam_IsValid;

	private static int SetCurveScalarParam_Offset;

	private static FFieldAddress SetCurveScalarParam_PropertyAddress;

	private static bool SetCurveLColorParam_IsValid;

	private static int SetCurveLColorParam_Offset;

	private static FFieldAddress SetCurveLColorParam_PropertyAddress;

	private static bool SetCurveV3Param_IsValid;

	private static int SetCurveV3Param_Offset;

	private static FFieldAddress SetCurveV3Param_PropertyAddress;

	private static bool EndStage_SetPCurveScalarParam_IsValid;

	private static int EndStage_SetPCurveScalarParam_Offset;

	private static FFieldAddress EndStage_SetPCurveScalarParam_PropertyAddress;

	private static bool EndStage_SetPCurveLColorParam_IsValid;

	private static int EndStage_SetPCurveLColorParam_Offset;

	private static FFieldAddress EndStage_SetPCurveLColorParam_PropertyAddress;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	public BUC_DispLibDBC_ChangeMaterial Copy()
	{
		BUC_DispLibDBC_ChangeMaterial result = this;
		if (InheritScalarParam != null)
		{
			result.InheritScalarParam = new List<FName>(InheritScalarParam);
		}
		if (InheritFLinearColorParam != null)
		{
			result.InheritFLinearColorParam = new List<FName>(InheritFLinearColorParam);
		}
		if (InheritTextureParam != null)
		{
			result.InheritTextureParam = new List<FName>(InheritTextureParam);
		}
		if (SetScalarParam != null)
		{
			result.SetScalarParam = new List<BUC_DispLibUtil_NameAndScalar>(SetScalarParam);
		}
		if (SetColorParam != null)
		{
			result.SetColorParam = new List<BUC_DispLibUtil_NameAndLColor>(SetColorParam);
		}
		if (SetCurveScalarParam != null)
		{
			result.SetCurveScalarParam = new List<BUC_DispLibUtil_NameAndScalarCurve>(SetCurveScalarParam);
		}
		if (SetCurveLColorParam != null)
		{
			result.SetCurveLColorParam = new List<BUC_DispLibUtil_NameAndLColorCurve>(SetCurveLColorParam);
		}
		if (SetCurveV3Param != null)
		{
			result.SetCurveV3Param = new List<BUC_DispLibUtil_NameAndVectorCurve>(SetCurveV3Param);
		}
		if (EndStage_SetPCurveScalarParam != null)
		{
			result.EndStage_SetPCurveScalarParam = new List<BUC_DispLibUtil_PCurve_NameAndScalar>(EndStage_SetPCurveScalarParam);
		}
		if (EndStage_SetPCurveLColorParam != null)
		{
			result.EndStage_SetPCurveLColorParam = new List<BUC_DispLibUtil_PCurve_NameAndLColor>(EndStage_SetPCurveLColorParam);
		}
		return result;
	}

	public static BUC_DispLibDBC_ChangeMaterial FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_ChangeMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_ChangeMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_ChangeMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_ChangeMaterial(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ChangeMaterial_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_ChangeMaterial value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_ChangeMaterial_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ChangeMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial");
			return;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo.ToNative(IntPtr.Add(nativeStruct, FilterMode_Offset), FilterMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		EnumMarshaler<DispLibMaterialParamsInheritMode>.ToNative(IntPtr.Add(nativeStruct, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address, InheriParamsMode);
		new TArrayCopyMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritScalarParam_Offset), InheritScalarParam);
		new TArrayCopyMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritFLinearColorParam_Offset), InheritFLinearColorParam);
		new TArrayCopyMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InheritTextureParam_Offset), InheritTextureParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalar>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset), SetScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColor>(1, SetColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetColorParam_Offset), SetColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalarCurve>(1, SetCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveScalarParam_Offset), SetCurveScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColorCurve>(1, SetCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveLColorParam_Offset), SetCurveLColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndVectorCurve>(1, SetCurveV3Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveV3Param_Offset), SetCurveV3Param);
		new TArrayCopyMarshaler<BUC_DispLibUtil_PCurve_NameAndScalar>(1, EndStage_SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndScalar, BUC_DispLibUtil_PCurve_NameAndScalar>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndScalar, BUC_DispLibUtil_PCurve_NameAndScalar>.ToNative).ToNative(IntPtr.Add(nativeStruct, EndStage_SetPCurveScalarParam_Offset), EndStage_SetPCurveScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_PCurve_NameAndLColor>(1, EndStage_SetPCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndLColor, BUC_DispLibUtil_PCurve_NameAndLColor>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndLColor, BUC_DispLibUtil_PCurve_NameAndLColor>.ToNative).ToNative(IntPtr.Add(nativeStruct, EndStage_SetPCurveLColorParam_Offset), EndStage_SetPCurveLColorParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
	}

	public BUC_DispLibDBC_ChangeMaterial(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_ChangeMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial");
			FilterMode = default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			Template = null;
			InheriParamsMode = DispLibMaterialParamsInheritMode.NoInherit;
			InheritScalarParam = null;
			InheritFLinearColorParam = null;
			InheritTextureParam = null;
			SetScalarParam = null;
			SetColorParam = null;
			SetCurveScalarParam = null;
			SetCurveLColorParam = null;
			SetCurveV3Param = null;
			EndStage_SetPCurveScalarParam = null;
			EndStage_SetPCurveLColorParam = null;
			PausePriority = 0;
			EndStagePriority = 0;
		}
		else
		{
			FilterMode = BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(nativeStruct, FilterMode_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			Template = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			InheriParamsMode = EnumMarshaler<DispLibMaterialParamsInheritMode>.FromNative(IntPtr.Add(nativeStruct, InheriParamsMode_Offset), 0, InheriParamsMode_PropertyAddress.Address);
			InheritScalarParam = new TArrayCopyMarshaler<FName>(1, InheritScalarParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritScalarParam_Offset));
			InheritFLinearColorParam = new TArrayCopyMarshaler<FName>(1, InheritFLinearColorParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritFLinearColorParam_Offset));
			InheritTextureParam = new TArrayCopyMarshaler<FName>(1, InheritTextureParam_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InheritTextureParam_Offset));
			SetScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalar>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset));
			SetColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColor>(1, SetColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetColorParam_Offset));
			SetCurveScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalarCurve>(1, SetCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveScalarParam_Offset));
			SetCurveLColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColorCurve>(1, SetCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveLColorParam_Offset));
			SetCurveV3Param = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndVectorCurve>(1, SetCurveV3Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveV3Param_Offset));
			EndStage_SetPCurveScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_PCurve_NameAndScalar>(1, EndStage_SetPCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndScalar, BUC_DispLibUtil_PCurve_NameAndScalar>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndScalar, BUC_DispLibUtil_PCurve_NameAndScalar>.ToNative).FromNative(IntPtr.Add(nativeStruct, EndStage_SetPCurveScalarParam_Offset));
			EndStage_SetPCurveLColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_PCurve_NameAndLColor>(1, EndStage_SetPCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndLColor, BUC_DispLibUtil_PCurve_NameAndLColor>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_PCurve_NameAndLColor, BUC_DispLibUtil_PCurve_NameAndLColor>.ToNative).FromNative(IntPtr.Add(nativeStruct, EndStage_SetPCurveLColorParam_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial");
		BUC_DispLibDBC_ChangeMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
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
		NativeReflection.GetPropertyRef(ref SetScalarParam_PropertyAddress, intPtr, "SetScalarParam");
		SetScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetScalarParam");
		SetScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetColorParam_PropertyAddress, intPtr, "SetColorParam");
		SetColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetColorParam");
		SetColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveScalarParam_PropertyAddress, intPtr, "SetCurveScalarParam");
		SetCurveScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveScalarParam");
		SetCurveScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveLColorParam_PropertyAddress, intPtr, "SetCurveLColorParam");
		SetCurveLColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveLColorParam");
		SetCurveLColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveLColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveV3Param_PropertyAddress, intPtr, "SetCurveV3Param");
		SetCurveV3Param_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveV3Param");
		SetCurveV3Param_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveV3Param", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EndStage_SetPCurveScalarParam_PropertyAddress, intPtr, "EndStage_SetPCurveScalarParam");
		EndStage_SetPCurveScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStage_SetPCurveScalarParam");
		EndStage_SetPCurveScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStage_SetPCurveScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EndStage_SetPCurveLColorParam_PropertyAddress, intPtr, "EndStage_SetPCurveLColorParam");
		EndStage_SetPCurveLColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStage_SetPCurveLColorParam");
		EndStage_SetPCurveLColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStage_SetPCurveLColorParam", Classes.FArrayProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		BUC_DispLibDBC_ChangeMaterial_IsValid = ((intPtr != IntPtr.Zero && FilterMode_IsValid && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && Template_IsValid && InheriParamsMode_IsValid && InheritScalarParam_IsValid && InheritFLinearColorParam_IsValid && InheritTextureParam_IsValid && SetScalarParam_IsValid && SetColorParam_IsValid && SetCurveScalarParam_IsValid && SetCurveLColorParam_IsValid && SetCurveV3Param_IsValid && EndStage_SetPCurveScalarParam_IsValid && EndStage_SetPCurveLColorParam_IsValid && PausePriority_IsValid && EndStagePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_ChangeMaterial", (byte)BUC_DispLibDBC_ChangeMaterial_IsValid != 0);
	}

	static BUC_DispLibDBC_ChangeMaterial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_ChangeMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_ChangeMaterial));
	}
}
