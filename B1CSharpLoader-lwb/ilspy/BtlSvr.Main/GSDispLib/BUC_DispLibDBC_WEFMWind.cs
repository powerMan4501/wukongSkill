using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind")]
public struct BUC_DispLibDBC_WEFMWind
{
	[UMeta(MD.ToolTip, "事件名类似tag，当需要暂停某个风源的时候用事件名来索引。为了方便配置，对于作用相似的风源即使不同角色间也应该统一事件名")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("事件名")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:EventName")]
	public FName EventName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("风源中心")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:SocketName")]
	public FName SocketName;

	[EditAnywhere]
	[DisplayName("延迟时间")]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:Delay")]
	public float Delay;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UProperty]
	[DisplayName("持续时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:Duration")]
	public float Duration;

	[DisplayName("风源中心本地偏移")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:SocketLocalOffset")]
	public FVector SocketLocalOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发概率")]
	[UMeta(MDProp.ClampMax, 1)]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:TriggerProbability")]
	public float TriggerProbability;

	[EditAnywhere]
	[DisplayName("半径")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:Radius")]
	public BUC_DispLibUtil_DBCAdvProcessScalar Radius;

	[UMeta(MD.ToolTip, "风源中心速度低于此值时不会产生风")]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("速度阈值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:VelocityThreshold")]
	public float VelocityThreshold;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("基础强度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:BaseIntensity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar BaseIntensity;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("速度强度倍率")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:ScaleVelocityIntensity")]
	public float ScaleVelocityIntensity;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("末端衰减率")]
	[UMeta(MD.ToolTip, "距离风源中心越近的位置风强越接近【中心强度】，距离风源中心越远（越接近半径值）的位置风强越接近【中心强度】*【末端衰减率】")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:DistanceDamplingRate")]
	public float DistanceDamplingRate;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("风源类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:WindMotorMode")]
	public DispLibDBCWindMotorMode WindMotorMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围轴向")]
	[UMeta(MD.ToolTip, "指定风源范围的轴向，与遮罩参数配合可以实现半球/弧地圆锥等形状的注风区域")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:RangeAxis")]
	public DispLibDBCAxisMode RangeAxis;

	[UMeta(MD.ToolTip, "当范围轴向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("范围轴向本地旋转")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:RangeAxisLocalRotation")]
	public FVector RangeAxisLocalRotation;

	[DisplayName("范围遮罩")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "待注入的风场Cell中心点与范围轴向的点乘结果若小于这个值，则不注入，例如 = 0 可以实现只注入轴向半球范围, = 0.5 可注入沿轴向的弧底锥形")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:RangeMask")]
	public float RangeMask;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风速(副风速)方向")]
	[UMeta(MD.ToolTip, "对于定向风，风速方向即最终方向；对于其他类型的风会在其原本方向上叠加此方向，使用【缩放副风速方向】控制叠加的强度")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:VelocityDir")]
	public DispLibDBCAxisMode VelocityDir;

	[UMeta(MD.ToolTip, "当风速(副风速)方向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[DisplayName("风速(副风速)方向本地旋转")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:VelocityDirLocalRotation")]
	public FVector VelocityDirLocalRotation;

	[UMeta(MDProp.EditCondition, "WindMotorMode != DispLibDBCWindMotorMode::LocalDirectionalWind")]
	[DisplayName("缩放副风速方向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:ScaleSecondVelocity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar ScaleSecondVelocity;

	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_WEFMWind_StructSize;

	private static int BUC_DispLibDBC_WEFMWind_IsValid;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool SocketLocalOffset_IsValid;

	private static int SocketLocalOffset_Offset;

	private static bool TriggerProbability_IsValid;

	private static int TriggerProbability_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool VelocityThreshold_IsValid;

	private static int VelocityThreshold_Offset;

	private static bool BaseIntensity_IsValid;

	private static int BaseIntensity_Offset;

	private static bool ScaleVelocityIntensity_IsValid;

	private static int ScaleVelocityIntensity_Offset;

	private static bool DistanceDamplingRate_IsValid;

	private static int DistanceDamplingRate_Offset;

	private static bool WindMotorMode_IsValid;

	private static int WindMotorMode_Offset;

	private static FFieldAddress WindMotorMode_PropertyAddress;

	private static bool RangeAxis_IsValid;

	private static int RangeAxis_Offset;

	private static FFieldAddress RangeAxis_PropertyAddress;

	private static bool RangeAxisLocalRotation_IsValid;

	private static int RangeAxisLocalRotation_Offset;

	private static bool RangeMask_IsValid;

	private static int RangeMask_Offset;

	private static bool VelocityDir_IsValid;

	private static int VelocityDir_Offset;

	private static FFieldAddress VelocityDir_PropertyAddress;

	private static bool VelocityDirLocalRotation_IsValid;

	private static int VelocityDirLocalRotation_Offset;

	private static bool ScaleSecondVelocity_IsValid;

	private static int ScaleSecondVelocity_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_WEFMWind SetCustomData(FName _EventName, FName _SocketName, FVector _SocketLocalOffset, FVector _RangeAxisLocalRotation, BUC_DispLibUtil_DBCAdvProcessScalar _Radius, float _TriggerProbability, float _VelocityThreshold, BUC_DispLibUtil_DBCAdvProcessScalar _BaseIntensity, float _ScaleVelocityIntensity, float _DistanceDamplingRate, DispLibDBCWindMotorMode _WindMotorMode, DispLibDBCAxisMode _RangeAxis, float _RangeMask, DispLibDBCAxisMode _VelocityDir, FVector _VelocityDirLocalRotation, BUC_DispLibUtil_DBCAdvProcessScalar _ScaleSecondVelocity, int _PausePriority)
	{
		EventName = _EventName;
		SocketName = _SocketName;
		SocketLocalOffset = _SocketLocalOffset;
		RangeAxisLocalRotation = _RangeAxisLocalRotation;
		Radius = _Radius;
		TriggerProbability = _TriggerProbability;
		VelocityThreshold = _VelocityThreshold;
		BaseIntensity = _BaseIntensity;
		ScaleVelocityIntensity = _ScaleVelocityIntensity;
		DistanceDamplingRate = _DistanceDamplingRate;
		WindMotorMode = _WindMotorMode;
		RangeAxis = _RangeAxis;
		RangeMask = _RangeMask;
		VelocityDir = _VelocityDir;
		VelocityDirLocalRotation = _VelocityDirLocalRotation;
		ScaleSecondVelocity = _ScaleSecondVelocity;
		PausePriority = _PausePriority;
		return this;
	}

	public BUC_DispLibDBC_WEFMWind Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_WEFMWind FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_WEFMWind(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_WEFMWind value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_WEFMWind FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_WEFMWind(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_WEFMWind_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_WEFMWind value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_WEFMWind_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_WEFMWind_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, EventName_Offset), EventName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset), SocketLocalOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TriggerProbability_Offset), TriggerProbability);
		BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VelocityThreshold_Offset), VelocityThreshold);
		BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(nativeStruct, BaseIntensity_Offset), BaseIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScaleVelocityIntensity_Offset), ScaleVelocityIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset), DistanceDamplingRate);
		EnumMarshaler<DispLibDBCWindMotorMode>.ToNative(IntPtr.Add(nativeStruct, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address, WindMotorMode);
		EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address, RangeAxis);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RangeAxisLocalRotation_Offset), RangeAxisLocalRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeMask_Offset), RangeMask);
		EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(nativeStruct, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address, VelocityDir);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VelocityDirLocalRotation_Offset), VelocityDirLocalRotation);
		BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(nativeStruct, ScaleSecondVelocity_Offset), ScaleSecondVelocity);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_WEFMWind(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_WEFMWind_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind");
			EventName = default(FName);
			SocketName = default(FName);
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			SocketLocalOffset = default(FVector);
			TriggerProbability = 0f;
			Radius = default(BUC_DispLibUtil_DBCAdvProcessScalar);
			VelocityThreshold = 0f;
			BaseIntensity = default(BUC_DispLibUtil_DBCAdvProcessScalar);
			ScaleVelocityIntensity = 0f;
			DistanceDamplingRate = 0f;
			WindMotorMode = DispLibDBCWindMotorMode.NoWind;
			RangeAxis = DispLibDBCAxisMode.WS_X;
			RangeAxisLocalRotation = default(FVector);
			RangeMask = 0f;
			VelocityDir = DispLibDBCAxisMode.WS_X;
			VelocityDirLocalRotation = default(FVector);
			ScaleSecondVelocity = default(BUC_DispLibUtil_DBCAdvProcessScalar);
			PausePriority = 0;
		}
		else
		{
			EventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, EventName_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			SocketLocalOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset));
			TriggerProbability = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TriggerProbability_Offset));
			Radius = BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			VelocityThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VelocityThreshold_Offset));
			BaseIntensity = BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(nativeStruct, BaseIntensity_Offset));
			ScaleVelocityIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScaleVelocityIntensity_Offset));
			DistanceDamplingRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset));
			WindMotorMode = EnumMarshaler<DispLibDBCWindMotorMode>.FromNative(IntPtr.Add(nativeStruct, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address);
			RangeAxis = EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address);
			RangeAxisLocalRotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RangeAxisLocalRotation_Offset));
			RangeMask = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeMask_Offset));
			VelocityDir = EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(nativeStruct, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address);
			VelocityDirLocalRotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VelocityDirLocalRotation_Offset));
			ScaleSecondVelocity = BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(nativeStruct, ScaleSecondVelocity_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind");
		BUC_DispLibDBC_WEFMWind_StructSize = NativeReflection.GetStructSize(intPtr);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		SocketLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketLocalOffset");
		SocketLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketLocalOffset", Classes.FStructProperty);
		TriggerProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerProbability");
		TriggerProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerProbability", Classes.FFloatProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FStructProperty);
		VelocityThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityThreshold");
		VelocityThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityThreshold", Classes.FFloatProperty);
		BaseIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseIntensity");
		BaseIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseIntensity", Classes.FStructProperty);
		ScaleVelocityIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleVelocityIntensity");
		ScaleVelocityIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleVelocityIntensity", Classes.FFloatProperty);
		DistanceDamplingRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceDamplingRate");
		DistanceDamplingRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceDamplingRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref WindMotorMode_PropertyAddress, intPtr, "WindMotorMode");
		WindMotorMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindMotorMode");
		WindMotorMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindMotorMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RangeAxis_PropertyAddress, intPtr, "RangeAxis");
		RangeAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeAxis");
		RangeAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeAxis", Classes.FEnumProperty);
		RangeAxisLocalRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeAxisLocalRotation");
		RangeAxisLocalRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeAxisLocalRotation", Classes.FStructProperty);
		RangeMask_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeMask");
		RangeMask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeMask", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref VelocityDir_PropertyAddress, intPtr, "VelocityDir");
		VelocityDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDir");
		VelocityDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDir", Classes.FEnumProperty);
		VelocityDirLocalRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDirLocalRotation");
		VelocityDirLocalRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDirLocalRotation", Classes.FStructProperty);
		ScaleSecondVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleSecondVelocity");
		ScaleSecondVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleSecondVelocity", Classes.FStructProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_WEFMWind_IsValid = ((intPtr != IntPtr.Zero && EventName_IsValid && SocketName_IsValid && Delay_IsValid && EndMode_IsValid && Duration_IsValid && SocketLocalOffset_IsValid && TriggerProbability_IsValid && Radius_IsValid && VelocityThreshold_IsValid && BaseIntensity_IsValid && ScaleVelocityIntensity_IsValid && DistanceDamplingRate_IsValid && WindMotorMode_IsValid && RangeAxis_IsValid && RangeAxisLocalRotation_IsValid && RangeMask_IsValid && VelocityDir_IsValid && VelocityDirLocalRotation_IsValid && ScaleSecondVelocity_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_WEFMWind", (byte)BUC_DispLibDBC_WEFMWind_IsValid != 0);
	}

	static BUC_DispLibDBC_WEFMWind()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_WEFMWind)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_WEFMWind));
	}
}
