using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat")]
public struct BUC_DispLibDBC_Heat
{
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "事件名类似tag，当需要暂停某个风源的时候用事件名来索引。为了方便配置，对于作用相似的风源即使不同角色间也应该统一事件名")]
	[DisplayName("事件名")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:EventName")]
	public FName EventName;

	[DisplayName("热源中心")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta("AnimNotifyBoneName", "true")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:SocketName")]
	public FName SocketName;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("热源中心本地偏移")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:SocketLocalOffset")]
	public FVector SocketLocalOffset;

	[UMeta(MD.ToolTip, "注意，旋转后【范围轴向】等参数的【挂点轴】方向会受影响")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("热源中心本地旋转")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:SocketLocalRotation")]
	public FVector SocketLocalRotation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("半径")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:Radius")]
	public float Radius;

	[UProperty]
	[UMeta(MDProp.ClampMax, 1)]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("触发概率")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:TriggerProbability")]
	public float TriggerProbability;

	[UProperty]
	[UMeta(MDProp.ClampMax, 1)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("中心热力Min")]
	[UMeta(MDProp.ClampMin, -1)]
	[UMeta(MD.ToolTip, "范围-1到1，一个固定位置的热源会每帧注入范围内的随机热力")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:MinIntensity")]
	public float MinIntensity;

	[UProperty]
	[UMeta(MDProp.ClampMax, 1)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("中心热力Max")]
	[UMeta(MDProp.ClampMin, -1)]
	[UMeta(MD.ToolTip, "范围-1到1，一个固定位置的热源会每帧注入范围内的随机热力")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:MaxIntensity")]
	public float MaxIntensity;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("末端衰减率")]
	[UMeta(MD.ToolTip, "距离中心越近的位置热力越接近【中心热力】，距离中心越远（越接近半径值）的位置热力越接近【中心热力】*【末端衰减率】")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:DistanceDamplingRate")]
	public float DistanceDamplingRate;

	[UProperty]
	[UMeta(MD.ToolTip, "指定范围的轴向，与遮罩参数配合可以实现半球/弧地圆锥等形状的注风区域")]
	[DisplayName("范围轴向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:RangeAxis")]
	public DispLibDBCAxisMode RangeAxis;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "待注入的Cell中心点与范围轴向的点乘结果若小于这个值，则不注入。 = 0 即注入轴向半球范围, = 0.5 可注入沿轴向的弧底锥形")]
	[DisplayName("范围遮罩")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:RangeMask")]
	public float RangeMask;

	[UProperty]
	[EditAnywhere]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_Heat:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_Heat_StructSize;

	private static int BUC_DispLibDBC_Heat_IsValid;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SocketLocalOffset_IsValid;

	private static int SocketLocalOffset_Offset;

	private static bool SocketLocalRotation_IsValid;

	private static int SocketLocalRotation_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool TriggerProbability_IsValid;

	private static int TriggerProbability_Offset;

	private static bool MinIntensity_IsValid;

	private static int MinIntensity_Offset;

	private static bool MaxIntensity_IsValid;

	private static int MaxIntensity_Offset;

	private static bool DistanceDamplingRate_IsValid;

	private static int DistanceDamplingRate_Offset;

	private static bool RangeAxis_IsValid;

	private static int RangeAxis_Offset;

	private static FFieldAddress RangeAxis_PropertyAddress;

	private static bool RangeMask_IsValid;

	private static int RangeMask_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_Heat SetCustomData(FName _EventName, FName _SocketName, FVector _SocketLocalOffset, FVector _SocketLocalRotation, float _Radius, float _TriggerProbability, float _MinIntensity, float _MaxIntensity, float _ScaleVelocityIntensity, float _DistanceDamplingRate, DispLibDBCWindMotorMode _WindMotorMode, DispLibDBCAxisMode _RangeAxis, float _RangeMask, DispLibDBCAxisMode _VelocityDir, int _PausePriority)
	{
		EventName = _EventName;
		SocketName = _SocketName;
		SocketLocalOffset = _SocketLocalOffset;
		SocketLocalRotation = _SocketLocalRotation;
		Radius = _Radius;
		TriggerProbability = _TriggerProbability;
		MinIntensity = _MinIntensity;
		MaxIntensity = _MaxIntensity;
		DistanceDamplingRate = _DistanceDamplingRate;
		RangeAxis = _RangeAxis;
		RangeMask = _RangeMask;
		PausePriority = _PausePriority;
		return this;
	}

	public BUC_DispLibDBC_Heat Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_Heat FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_Heat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_Heat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_Heat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_Heat(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_Heat_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_Heat value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_Heat_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_Heat_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_Heat");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, EventName_Offset), EventName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset), SocketLocalOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SocketLocalRotation_Offset), SocketLocalRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TriggerProbability_Offset), TriggerProbability);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinIntensity_Offset), MinIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxIntensity_Offset), MaxIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset), DistanceDamplingRate);
		EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address, RangeAxis);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeMask_Offset), RangeMask);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_Heat(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_Heat_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_Heat");
			EventName = default(FName);
			SocketName = default(FName);
			SocketLocalOffset = default(FVector);
			SocketLocalRotation = default(FVector);
			Radius = 0f;
			TriggerProbability = 0f;
			MinIntensity = 0f;
			MaxIntensity = 0f;
			DistanceDamplingRate = 0f;
			RangeAxis = DispLibDBCAxisMode.WS_X;
			RangeMask = 0f;
			PausePriority = 0;
		}
		else
		{
			EventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, EventName_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			SocketLocalOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SocketLocalOffset_Offset));
			SocketLocalRotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SocketLocalRotation_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			TriggerProbability = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TriggerProbability_Offset));
			MinIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinIntensity_Offset));
			MaxIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxIntensity_Offset));
			DistanceDamplingRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceDamplingRate_Offset));
			RangeAxis = EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(nativeStruct, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address);
			RangeMask = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeMask_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_Heat");
		BUC_DispLibDBC_Heat_StructSize = NativeReflection.GetStructSize(intPtr);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SocketLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketLocalOffset");
		SocketLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketLocalOffset", Classes.FStructProperty);
		SocketLocalRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketLocalRotation");
		SocketLocalRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketLocalRotation", Classes.FStructProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		TriggerProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerProbability");
		TriggerProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerProbability", Classes.FFloatProperty);
		MinIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinIntensity");
		MinIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinIntensity", Classes.FFloatProperty);
		MaxIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxIntensity");
		MaxIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxIntensity", Classes.FFloatProperty);
		DistanceDamplingRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceDamplingRate");
		DistanceDamplingRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceDamplingRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RangeAxis_PropertyAddress, intPtr, "RangeAxis");
		RangeAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeAxis");
		RangeAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeAxis", Classes.FEnumProperty);
		RangeMask_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeMask");
		RangeMask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeMask", Classes.FFloatProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_Heat_IsValid = ((intPtr != IntPtr.Zero && EventName_IsValid && SocketName_IsValid && SocketLocalOffset_IsValid && SocketLocalRotation_IsValid && Radius_IsValid && TriggerProbability_IsValid && MinIntensity_IsValid && MaxIntensity_IsValid && DistanceDamplingRate_IsValid && RangeAxis_IsValid && RangeMask_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_Heat", (byte)BUC_DispLibDBC_Heat_IsValid != 0);
	}

	static BUC_DispLibDBC_Heat()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_Heat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_Heat));
	}
}
