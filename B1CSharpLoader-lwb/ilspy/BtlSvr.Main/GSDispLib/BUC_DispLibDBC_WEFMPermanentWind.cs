using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind")]
public struct BUC_DispLibDBC_WEFMPermanentWind
{
	[UMeta(MD.ToolTip, "事件名类似tag，当需要暂停某个风源的时候用事件名来索引。为了方便配置，对于作用相似的风源即使不同角色间也应该统一事件名")]
	[DisplayName("事件名")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:EventName")]
	public FName EventName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风源中心")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:SocketName")]
	public FName SocketName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风源中心本地偏移")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:SocketLocalOffset")]
	public FVector SocketLocalOffset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("半径")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:Radius")]
	public float Radius;

	[UMeta(MD.ToolTip, "风源中心速度低于此值时不会产生风")]
	[UProperty]
	[DisplayName("速度阈值")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:VelocityThreshold")]
	public float VelocityThreshold;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("基础强度")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:BaseIntensity")]
	public float BaseIntensity;

	[BlueprintReadWrite]
	[DisplayName("速度强度倍率")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:ScaleVelocityIntensity")]
	public float ScaleVelocityIntensity;

	[DisplayName("末端衰减率")]
	[UMeta(MD.ToolTip, "距离风源中心越近的位置风强越接近【中心强度】，距离风源中心越远（越接近半径值）的位置风强越接近【中心强度】*【末端衰减率】")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:DistanceDamplingRate")]
	public float DistanceDamplingRate;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("风源类型")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:WindMotorMode")]
	public DispLibDBCWindMotorMode WindMotorMode;

	[DisplayName("范围轴向")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "指定风源范围的轴向，与遮罩参数配合可以实现半球/弧地圆锥等形状的注风区域")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:RangeAxis")]
	public DispLibDBCAxisMode RangeAxis;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围轴向本地旋转")]
	[UMeta(MD.ToolTip, "当范围轴向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:RangeAxisLocalRotation")]
	public FVector RangeAxisLocalRotation;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围遮罩")]
	[UProperty]
	[UMeta(MD.ToolTip, "待注入的风场Cell中心点与范围轴向的点乘结果若小于这个值，则不注入，例如 = 0 可以实现只注入轴向半球范围, = 0.5 可注入沿轴向的弧底锥形")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:RangeMask")]
	public float RangeMask;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风速(副风速)方向")]
	[UMeta(MD.ToolTip, "对于定向风，风速方向即最终方向；对于其他类型的风会在其原本方向上叠加此方向，使用【缩放副风速方向】控制叠加的强度")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:VelocityDir")]
	public DispLibDBCAxisMode VelocityDir;

	[UMeta(MD.ToolTip, "当风速(副风速)方向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风速(副风速)方向本地旋转")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:VelocityDirLocalRotation")]
	public FVector VelocityDirLocalRotation;

	[DisplayName("缩放副风速方向")]
	[UMeta(MDProp.EditCondition, "WindMotorMode != DispLibDBCWindMotorMode::LocalDirectionalWind")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind:ScaleSecondVelocity")]
	public float ScaleSecondVelocity;

	private static int BUC_DispLibDBC_WEFMPermanentWind_StructSize;

	private static int BUC_DispLibDBC_WEFMPermanentWind_IsValid;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SocketLocalOffset_IsValid;

	private static int SocketLocalOffset_Offset;

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

	public BUC_DispLibDBC_WEFMPermanentWind Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_WEFMPermanentWind FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_WEFMPermanentWind(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_WEFMPermanentWind value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_WEFMPermanentWind FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_WEFMPermanentWind(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_WEFMPermanentWind_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_WEFMPermanentWind value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_WEFMPermanentWind_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_WEFMPermanentWind_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, EventName_Offset), EventName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset), SocketLocalOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VelocityThreshold_Offset), VelocityThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BaseIntensity_Offset), BaseIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScaleVelocityIntensity_Offset), ScaleVelocityIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset), DistanceDamplingRate);
		EnumMarshaler<DispLibDBCWindMotorMode>.ToNative(IntPtr.Add(nativeStruct, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address, WindMotorMode);
		EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address, RangeAxis);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RangeAxisLocalRotation_Offset), RangeAxisLocalRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeMask_Offset), RangeMask);
		EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(nativeStruct, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address, VelocityDir);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VelocityDirLocalRotation_Offset), VelocityDirLocalRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScaleSecondVelocity_Offset), ScaleSecondVelocity);
	}

	public BUC_DispLibDBC_WEFMPermanentWind(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_WEFMPermanentWind_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind");
			EventName = default(FName);
			SocketName = default(FName);
			SocketLocalOffset = default(FVector);
			Radius = 0f;
			VelocityThreshold = 0f;
			BaseIntensity = 0f;
			ScaleVelocityIntensity = 0f;
			DistanceDamplingRate = 0f;
			WindMotorMode = DispLibDBCWindMotorMode.NoWind;
			RangeAxis = DispLibDBCAxisMode.WS_X;
			RangeAxisLocalRotation = default(FVector);
			RangeMask = 0f;
			VelocityDir = DispLibDBCAxisMode.WS_X;
			VelocityDirLocalRotation = default(FVector);
			ScaleSecondVelocity = 0f;
		}
		else
		{
			EventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, EventName_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			SocketLocalOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			VelocityThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VelocityThreshold_Offset));
			BaseIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BaseIntensity_Offset));
			ScaleVelocityIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScaleVelocityIntensity_Offset));
			DistanceDamplingRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset));
			WindMotorMode = EnumMarshaler<DispLibDBCWindMotorMode>.FromNative(IntPtr.Add(nativeStruct, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address);
			RangeAxis = EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address);
			RangeAxisLocalRotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RangeAxisLocalRotation_Offset));
			RangeMask = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeMask_Offset));
			VelocityDir = EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(nativeStruct, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address);
			VelocityDirLocalRotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VelocityDirLocalRotation_Offset));
			ScaleSecondVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScaleSecondVelocity_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind");
		BUC_DispLibDBC_WEFMPermanentWind_StructSize = NativeReflection.GetStructSize(intPtr);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SocketLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketLocalOffset");
		SocketLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketLocalOffset", Classes.FStructProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		VelocityThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityThreshold");
		VelocityThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityThreshold", Classes.FFloatProperty);
		BaseIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseIntensity");
		BaseIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseIntensity", Classes.FFloatProperty);
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
		ScaleSecondVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleSecondVelocity", Classes.FFloatProperty);
		BUC_DispLibDBC_WEFMPermanentWind_IsValid = ((intPtr != IntPtr.Zero && EventName_IsValid && SocketName_IsValid && SocketLocalOffset_IsValid && Radius_IsValid && VelocityThreshold_IsValid && BaseIntensity_IsValid && ScaleVelocityIntensity_IsValid && DistanceDamplingRate_IsValid && WindMotorMode_IsValid && RangeAxis_IsValid && RangeAxisLocalRotation_IsValid && RangeMask_IsValid && VelocityDir_IsValid && VelocityDirLocalRotation_IsValid && ScaleSecondVelocity_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_WEFMPermanentWind", (byte)BUC_DispLibDBC_WEFMPermanentWind_IsValid != 0);
	}

	static BUC_DispLibDBC_WEFMPermanentWind()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_WEFMPermanentWind)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_WEFMPermanentWind));
	}
}
