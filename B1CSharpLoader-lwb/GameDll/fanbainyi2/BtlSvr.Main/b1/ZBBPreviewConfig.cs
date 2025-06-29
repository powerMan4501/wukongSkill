using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ZBBPreviewConfig")]
public struct ZBBPreviewConfig
{
	[Category("Preview Config | ZangBaBa")]
	[DisplayName("打开该测试")]
	[Tooltip("打开以后，编辑器中Play就会触发该测试")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:EnableZBBTest")]
	public bool EnableZBBTest;

	[Tooltip("任君挑选，不要用主角")]
	[DisplayName("攻击者的类")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Preview Config | ZangBaBa")]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:AttackerClass")]
	public TSubclassOf<BUTamerActor> AttackerClass;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Preview Config | ZangBaBa")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[DisplayName("攻击者要释放的技能ID")]
	[Tooltip("得是这个Unit能放的技能")]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:SkillID")]
	public int SkillID;

	[Tooltip("一般情况下0就可以了")]
	[DisplayName("两次放技能之间的延时")]
	[Category("Preview Config | ZangBaBa")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:Delay")]
	public float Delay;

	[Tooltip("一般情况下开着吧")]
	[DisplayName("给受击者加一个霸体")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[Category("Preview Config | ZangBaBa")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:TargetAddBati")]
	public bool TargetAddBati;

	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[EditAnywhere]
	[Category("Preview Config | ZangBaBa")]
	[DisplayName("打开粗采样过滤测试")]
	[Tooltip("推荐不开")]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:OpenLowDensityTest")]
	public bool OpenLowDensityTest;

	[Category("Preview Config | ZangBaBa")]
	[DisplayName("测试区距离上下界")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[Tooltip("推荐设置为0,1000。最大值越大，受击者能站的越远，测试技能的极限攻击距离。当你的技能能打得非常远的时候，最大值弄大点儿")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:DistRange")]
	public FVector2D DistRange;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[Tooltip("推荐设置为51。这个值越大，测试点越密，耗时越多。当你需要更精确的数据的时候，这个值弄大点儿")]
	[Category("Preview Config | ZangBaBa")]
	[DisplayName("采样矩阵切分数")]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:MapSize")]
	public int MapSize;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[UProperty]
	[Category("Preview Config | ZangBaBa")]
	[DisplayName("人为过滤扇区")]
	[Tooltip("比如你知道这个技能不会往后打的时候，可以把身后的扇区给过滤掉。填入扇区ID即可")]
	[USharpPath("/Script/b1-Managed.ZBBPreviewConfig:SectorFilterList")]
	public List<int> SectorFilterList;

	private static int ZBBPreviewConfig_StructSize;

	private static int ZBBPreviewConfig_IsValid;

	private static bool EnableZBBTest_IsValid;

	private static int EnableZBBTest_Offset;

	private static FFieldAddress EnableZBBTest_PropertyAddress;

	private static bool AttackerClass_IsValid;

	private static int AttackerClass_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool TargetAddBati_IsValid;

	private static int TargetAddBati_Offset;

	private static FFieldAddress TargetAddBati_PropertyAddress;

	private static bool OpenLowDensityTest_IsValid;

	private static int OpenLowDensityTest_Offset;

	private static FFieldAddress OpenLowDensityTest_PropertyAddress;

	private static bool DistRange_IsValid;

	private static int DistRange_Offset;

	private static bool MapSize_IsValid;

	private static int MapSize_Offset;

	private static bool SectorFilterList_IsValid;

	private static int SectorFilterList_Offset;

	private static FFieldAddress SectorFilterList_PropertyAddress;

	public ZBBPreviewConfig Copy()
	{
		ZBBPreviewConfig result = this;
		if (SectorFilterList != null)
		{
			result.SectorFilterList = new List<int>(SectorFilterList);
		}
		return result;
	}

	public static ZBBPreviewConfig FromNative(IntPtr nativeBuffer)
	{
		return new ZBBPreviewConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ZBBPreviewConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ZBBPreviewConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ZBBPreviewConfig(IntPtr.Add(nativeBuffer, arrayIndex * ZBBPreviewConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ZBBPreviewConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ZBBPreviewConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ZBBPreviewConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ZBBPreviewConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableZBBTest_Offset), 0, EnableZBBTest_PropertyAddress.Address, EnableZBBTest);
		TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, AttackerClass_Offset), AttackerClass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TargetAddBati_Offset), 0, TargetAddBati_PropertyAddress.Address, TargetAddBati);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OpenLowDensityTest_Offset), 0, OpenLowDensityTest_PropertyAddress.Address, OpenLowDensityTest);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, DistRange_Offset), DistRange);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MapSize_Offset), MapSize);
		new TArrayCopyMarshaler<int>(1, SectorFilterList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SectorFilterList_Offset), SectorFilterList);
	}

	public ZBBPreviewConfig(IntPtr nativeStruct)
	{
		if (ZBBPreviewConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ZBBPreviewConfig");
			EnableZBBTest = false;
			AttackerClass = default(TSubclassOf<BUTamerActor>);
			SkillID = 0;
			Delay = 0f;
			TargetAddBati = false;
			OpenLowDensityTest = false;
			DistRange = default(FVector2D);
			MapSize = 0;
			SectorFilterList = null;
		}
		else
		{
			EnableZBBTest = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableZBBTest_Offset), 0, EnableZBBTest_PropertyAddress.Address);
			AttackerClass = TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, AttackerClass_Offset));
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			TargetAddBati = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TargetAddBati_Offset), 0, TargetAddBati_PropertyAddress.Address);
			OpenLowDensityTest = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OpenLowDensityTest_Offset), 0, OpenLowDensityTest_PropertyAddress.Address);
			DistRange = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, DistRange_Offset));
			MapSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MapSize_Offset));
			SectorFilterList = new TArrayCopyMarshaler<int>(1, SectorFilterList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SectorFilterList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ZBBPreviewConfig");
		ZBBPreviewConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnableZBBTest_PropertyAddress, intPtr, "EnableZBBTest");
		EnableZBBTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableZBBTest");
		EnableZBBTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableZBBTest", Classes.FBoolProperty);
		AttackerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerClass");
		AttackerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerClass", Classes.FClassProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TargetAddBati_PropertyAddress, intPtr, "TargetAddBati");
		TargetAddBati_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetAddBati");
		TargetAddBati_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetAddBati", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenLowDensityTest_PropertyAddress, intPtr, "OpenLowDensityTest");
		OpenLowDensityTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "OpenLowDensityTest");
		OpenLowDensityTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OpenLowDensityTest", Classes.FBoolProperty);
		DistRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistRange");
		DistRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistRange", Classes.FStructProperty);
		MapSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapSize");
		MapSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapSize", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SectorFilterList_PropertyAddress, intPtr, "SectorFilterList");
		SectorFilterList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectorFilterList");
		SectorFilterList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectorFilterList", Classes.FArrayProperty);
		ZBBPreviewConfig_IsValid = ((intPtr != IntPtr.Zero && EnableZBBTest_IsValid && AttackerClass_IsValid && SkillID_IsValid && Delay_IsValid && TargetAddBati_IsValid && OpenLowDensityTest_IsValid && DistRange_IsValid && MapSize_IsValid && SectorFilterList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ZBBPreviewConfig", (byte)ZBBPreviewConfig_IsValid != 0);
	}

	static ZBBPreviewConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ZBBPreviewConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ZBBPreviewConfig));
	}
}
