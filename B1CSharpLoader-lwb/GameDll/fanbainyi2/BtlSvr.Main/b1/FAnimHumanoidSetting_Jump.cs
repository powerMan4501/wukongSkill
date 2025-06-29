using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump")]
public struct FAnimHumanoidSetting_Jump
{
	[DisplayName("跳跃按住时Z速度增量")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:CustomJumpVelocityIncrementWhenPressed")]
	public float CustomJumpVelocityIncrementWhenPressed;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("锁定下跳跃按住时Z速度增量")]
	[Tooltip("没有缺省，不填锁定下长按就不会有增量")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:CustomJumpVelocityIncrementWhenPressed_Locked")]
	public float CustomJumpVelocityIncrementWhenPressed_Locked;

	[UProperty]
	[Category("跳跃BlendSpace")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_start_fwd")]
	public UBlendSpace BS_jump_start_fwd;

	[UProperty]
	[Category("跳跃BlendSpace")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_start_bwd")]
	public UBlendSpace BS_jump_start_bwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("跳跃BlendSpace")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_loop_fwd")]
	public UBlendSpace BS_jump_loop_fwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("跳跃BlendSpace")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_loop_bwd")]
	public UBlendSpace BS_jump_loop_bwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("跳跃BlendSpace")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_additive_lean")]
	public UBlendSpace BS_jump_additive_lean;

	[BlueprintReadOnly]
	[Category("跳跃BlendSpace")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:BS_jump_additive_rot")]
	public UBlendSpace BS_jump_additive_rot;

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("原地起跳动画")]
	[Category("起跳阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimJumpStart_N")]
	public UAnimSequence AnimJumpStart_N;

	[UProperty]
	[Category("起跳阶段")]
	[DisplayName("向前起跳动画")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimJumpStart_F")]
	public UAnimSequence AnimJumpStart_F;

	[UProperty]
	[Category("起跳阶段")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("向左起跳动画")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimJumpStart_L")]
	public UAnimSequence AnimJumpStart_L;

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("向右起跳动画")]
	[Category("起跳阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimJumpStart_R")]
	public UAnimSequence AnimJumpStart_R;

	[Category("起跳阶段")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("向后起跳动画")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimJumpStart_B")]
	public UAnimSequence AnimJumpStart_B;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("原地坠落Start动画")]
	[Category("坠落阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_N")]
	public UAnimSequence AnimFallStart_N;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("向前坠落Start动画")]
	[Category("坠落阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_F")]
	public UAnimSequence AnimFallStart_F;

	[Category("坠落阶段")]
	[DisplayName("向前冲刺坠落Start动画")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_F_Dash")]
	public UAnimSequence AnimFallStart_F_Dash;

	[Category("坠落阶段")]
	[DisplayName("向后坠落Start动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_B")]
	public UAnimSequence AnimFallStart_B;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("向左坠落Start动画")]
	[EditAnywhere]
	[Category("坠落阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_L")]
	public UAnimSequence AnimFallStart_L;

	[UProperty]
	[EditAnywhere]
	[Category("坠落阶段")]
	[BlueprintReadOnly]
	[DisplayName("向右坠落Start动画")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallStart_R")]
	public UAnimSequence AnimFallStart_R;

	[UProperty]
	[BlueprintReadOnly]
	[Category("坠落阶段")]
	[DisplayName("坠落循环动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AnimFallLoop")]
	public UAnimSequence AnimFallLoop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("着陆阶段")]
	[Tooltip("低于这个高度下落不会触发着陆动画")]
	[DisplayName("最低触发着陆动画的高度")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:TriggerLandHeight")]
	public float TriggerLandHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("落地高度线_低")]
	[Tooltip("小于等于该值，触发Low档着陆动画")]
	[Category("着陆阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:HeightDividingLine_Low")]
	public float HeightDividingLine_Low;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("落地高度线_中")]
	[Tooltip("小于等于该值，触发Mid档着陆动画, 大于该值触发High档着陆动画")]
	[Category("着陆阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:HeightDividingLine_Mid")]
	public float HeightDividingLine_Mid;

	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("着陆阶段")]
	[DisplayName("着陆_前_低")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_F_Low")]
	public FAnimHumanoidSetting_Jump_Land Land_F_Low;

	[DisplayName("着陆_前_中")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("着陆阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_F_Mid")]
	public FAnimHumanoidSetting_Jump_Land Land_F_Mid;

	[Category("着陆阶段")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("着陆_前_高")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_F_High")]
	public FAnimHumanoidSetting_Jump_Land Land_F_High;

	[EditAnywhere]
	[DisplayName("着陆_左")]
	[Category("着陆阶段")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_L")]
	public FAnimHumanoidSetting_Jump_Land Land_L;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("着陆_右")]
	[Category("着陆阶段")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_R")]
	public FAnimHumanoidSetting_Jump_Land Land_R;

	[Category("着陆阶段")]
	[DisplayName("着陆_后")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:Land_B")]
	public FAnimHumanoidSetting_Jump_Land Land_B;

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("着陆后移动叠加Addtive")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AddtiveMoveAfterJump_F")]
	public UAnimSequence AddtiveMoveAfterJump_F;

	[UProperty]
	[Category("着陆后移动叠加Addtive")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AddtiveMoveAfterJump_B")]
	public UAnimSequence AddtiveMoveAfterJump_B;

	[UProperty]
	[Category("着陆后移动叠加Addtive")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AddtiveMoveAfterJump_L")]
	public UAnimSequence AddtiveMoveAfterJump_L;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("着陆后移动叠加Addtive")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:AddtiveMoveAfterJump_R")]
	public UAnimSequence AddtiveMoveAfterJump_R;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump:GlideJump")]
	public FAnimHumanoidSetting_GlideJump GlideJump;

	private static int AnimHumanoidSetting_Jump_StructSize;

	private static int AnimHumanoidSetting_Jump_IsValid;

	private static bool CustomJumpVelocityIncrementWhenPressed_IsValid;

	private static int CustomJumpVelocityIncrementWhenPressed_Offset;

	private static bool CustomJumpVelocityIncrementWhenPressed_Locked_IsValid;

	private static int CustomJumpVelocityIncrementWhenPressed_Locked_Offset;

	private static bool BS_jump_start_fwd_IsValid;

	private static int BS_jump_start_fwd_Offset;

	private static bool BS_jump_start_bwd_IsValid;

	private static int BS_jump_start_bwd_Offset;

	private static bool BS_jump_loop_fwd_IsValid;

	private static int BS_jump_loop_fwd_Offset;

	private static bool BS_jump_loop_bwd_IsValid;

	private static int BS_jump_loop_bwd_Offset;

	private static bool BS_jump_additive_lean_IsValid;

	private static int BS_jump_additive_lean_Offset;

	private static bool BS_jump_additive_rot_IsValid;

	private static int BS_jump_additive_rot_Offset;

	private static bool AnimJumpStart_N_IsValid;

	private static int AnimJumpStart_N_Offset;

	private static bool AnimJumpStart_F_IsValid;

	private static int AnimJumpStart_F_Offset;

	private static bool AnimJumpStart_L_IsValid;

	private static int AnimJumpStart_L_Offset;

	private static bool AnimJumpStart_R_IsValid;

	private static int AnimJumpStart_R_Offset;

	private static bool AnimJumpStart_B_IsValid;

	private static int AnimJumpStart_B_Offset;

	private static bool AnimFallStart_N_IsValid;

	private static int AnimFallStart_N_Offset;

	private static bool AnimFallStart_F_IsValid;

	private static int AnimFallStart_F_Offset;

	private static bool AnimFallStart_F_Dash_IsValid;

	private static int AnimFallStart_F_Dash_Offset;

	private static bool AnimFallStart_B_IsValid;

	private static int AnimFallStart_B_Offset;

	private static bool AnimFallStart_L_IsValid;

	private static int AnimFallStart_L_Offset;

	private static bool AnimFallStart_R_IsValid;

	private static int AnimFallStart_R_Offset;

	private static bool AnimFallLoop_IsValid;

	private static int AnimFallLoop_Offset;

	private static bool TriggerLandHeight_IsValid;

	private static int TriggerLandHeight_Offset;

	private static bool HeightDividingLine_Low_IsValid;

	private static int HeightDividingLine_Low_Offset;

	private static bool HeightDividingLine_Mid_IsValid;

	private static int HeightDividingLine_Mid_Offset;

	private static bool Land_F_Low_IsValid;

	private static int Land_F_Low_Offset;

	private static bool Land_F_Mid_IsValid;

	private static int Land_F_Mid_Offset;

	private static bool Land_F_High_IsValid;

	private static int Land_F_High_Offset;

	private static bool Land_L_IsValid;

	private static int Land_L_Offset;

	private static bool Land_R_IsValid;

	private static int Land_R_Offset;

	private static bool Land_B_IsValid;

	private static int Land_B_Offset;

	private static bool AddtiveMoveAfterJump_F_IsValid;

	private static int AddtiveMoveAfterJump_F_Offset;

	private static bool AddtiveMoveAfterJump_B_IsValid;

	private static int AddtiveMoveAfterJump_B_Offset;

	private static bool AddtiveMoveAfterJump_L_IsValid;

	private static int AddtiveMoveAfterJump_L_Offset;

	private static bool AddtiveMoveAfterJump_R_IsValid;

	private static int AddtiveMoveAfterJump_R_Offset;

	private static bool GlideJump_IsValid;

	private static int GlideJump_Offset;

	public FAnimHumanoidSetting_Jump Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Jump FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Jump(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Jump value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Jump FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Jump(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Jump_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Jump value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Jump_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Jump_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Jump");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrementWhenPressed_Offset), CustomJumpVelocityIncrementWhenPressed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrementWhenPressed_Locked_Offset), CustomJumpVelocityIncrementWhenPressed_Locked);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_start_fwd_Offset), BS_jump_start_fwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_start_bwd_Offset), BS_jump_start_bwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_loop_fwd_Offset), BS_jump_loop_fwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_loop_bwd_Offset), BS_jump_loop_bwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_additive_lean_Offset), BS_jump_additive_lean);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BS_jump_additive_rot_Offset), BS_jump_additive_rot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimJumpStart_N_Offset), AnimJumpStart_N);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimJumpStart_F_Offset), AnimJumpStart_F);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimJumpStart_L_Offset), AnimJumpStart_L);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimJumpStart_R_Offset), AnimJumpStart_R);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimJumpStart_B_Offset), AnimJumpStart_B);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_N_Offset), AnimFallStart_N);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_F_Offset), AnimFallStart_F);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_F_Dash_Offset), AnimFallStart_F_Dash);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_B_Offset), AnimFallStart_B);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_L_Offset), AnimFallStart_L);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_R_Offset), AnimFallStart_R);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallLoop_Offset), AnimFallLoop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TriggerLandHeight_Offset), TriggerLandHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HeightDividingLine_Low_Offset), HeightDividingLine_Low);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HeightDividingLine_Mid_Offset), HeightDividingLine_Mid);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_F_Low_Offset), Land_F_Low);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_F_Mid_Offset), Land_F_Mid);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_F_High_Offset), Land_F_High);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_L_Offset), Land_L);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_R_Offset), Land_R);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, Land_B_Offset), Land_B);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_F_Offset), AddtiveMoveAfterJump_F);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_B_Offset), AddtiveMoveAfterJump_B);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_L_Offset), AddtiveMoveAfterJump_L);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_R_Offset), AddtiveMoveAfterJump_R);
		FAnimHumanoidSetting_GlideJump.ToNative(IntPtr.Add(nativeStruct, GlideJump_Offset), GlideJump);
	}

	public FAnimHumanoidSetting_Jump(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Jump_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Jump");
			CustomJumpVelocityIncrementWhenPressed = 0f;
			CustomJumpVelocityIncrementWhenPressed_Locked = 0f;
			BS_jump_start_fwd = null;
			BS_jump_start_bwd = null;
			BS_jump_loop_fwd = null;
			BS_jump_loop_bwd = null;
			BS_jump_additive_lean = null;
			BS_jump_additive_rot = null;
			AnimJumpStart_N = null;
			AnimJumpStart_F = null;
			AnimJumpStart_L = null;
			AnimJumpStart_R = null;
			AnimJumpStart_B = null;
			AnimFallStart_N = null;
			AnimFallStart_F = null;
			AnimFallStart_F_Dash = null;
			AnimFallStart_B = null;
			AnimFallStart_L = null;
			AnimFallStart_R = null;
			AnimFallLoop = null;
			TriggerLandHeight = 0f;
			HeightDividingLine_Low = 0f;
			HeightDividingLine_Mid = 0f;
			Land_F_Low = default(FAnimHumanoidSetting_Jump_Land);
			Land_F_Mid = default(FAnimHumanoidSetting_Jump_Land);
			Land_F_High = default(FAnimHumanoidSetting_Jump_Land);
			Land_L = default(FAnimHumanoidSetting_Jump_Land);
			Land_R = default(FAnimHumanoidSetting_Jump_Land);
			Land_B = default(FAnimHumanoidSetting_Jump_Land);
			AddtiveMoveAfterJump_F = null;
			AddtiveMoveAfterJump_B = null;
			AddtiveMoveAfterJump_L = null;
			AddtiveMoveAfterJump_R = null;
			GlideJump = default(FAnimHumanoidSetting_GlideJump);
		}
		else
		{
			CustomJumpVelocityIncrementWhenPressed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrementWhenPressed_Offset));
			CustomJumpVelocityIncrementWhenPressed_Locked = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrementWhenPressed_Locked_Offset));
			BS_jump_start_fwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_start_fwd_Offset));
			BS_jump_start_bwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_start_bwd_Offset));
			BS_jump_loop_fwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_loop_fwd_Offset));
			BS_jump_loop_bwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_loop_bwd_Offset));
			BS_jump_additive_lean = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_additive_lean_Offset));
			BS_jump_additive_rot = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BS_jump_additive_rot_Offset));
			AnimJumpStart_N = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimJumpStart_N_Offset));
			AnimJumpStart_F = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimJumpStart_F_Offset));
			AnimJumpStart_L = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimJumpStart_L_Offset));
			AnimJumpStart_R = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimJumpStart_R_Offset));
			AnimJumpStart_B = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimJumpStart_B_Offset));
			AnimFallStart_N = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_N_Offset));
			AnimFallStart_F = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_F_Offset));
			AnimFallStart_F_Dash = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_F_Dash_Offset));
			AnimFallStart_B = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_B_Offset));
			AnimFallStart_L = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_L_Offset));
			AnimFallStart_R = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_R_Offset));
			AnimFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallLoop_Offset));
			TriggerLandHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TriggerLandHeight_Offset));
			HeightDividingLine_Low = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HeightDividingLine_Low_Offset));
			HeightDividingLine_Mid = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HeightDividingLine_Mid_Offset));
			Land_F_Low = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_F_Low_Offset));
			Land_F_Mid = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_F_Mid_Offset));
			Land_F_High = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_F_High_Offset));
			Land_L = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_L_Offset));
			Land_R = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_R_Offset));
			Land_B = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, Land_B_Offset));
			AddtiveMoveAfterJump_F = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_F_Offset));
			AddtiveMoveAfterJump_B = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_B_Offset));
			AddtiveMoveAfterJump_L = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_L_Offset));
			AddtiveMoveAfterJump_R = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AddtiveMoveAfterJump_R_Offset));
			GlideJump = FAnimHumanoidSetting_GlideJump.FromNative(IntPtr.Add(nativeStruct, GlideJump_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Jump");
		AnimHumanoidSetting_Jump_StructSize = NativeReflection.GetStructSize(intPtr);
		CustomJumpVelocityIncrementWhenPressed_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomJumpVelocityIncrementWhenPressed");
		CustomJumpVelocityIncrementWhenPressed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomJumpVelocityIncrementWhenPressed", Classes.FFloatProperty);
		CustomJumpVelocityIncrementWhenPressed_Locked_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomJumpVelocityIncrementWhenPressed_Locked");
		CustomJumpVelocityIncrementWhenPressed_Locked_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomJumpVelocityIncrementWhenPressed_Locked", Classes.FFloatProperty);
		BS_jump_start_fwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_start_fwd");
		BS_jump_start_fwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_start_fwd", Classes.FObjectProperty);
		BS_jump_start_bwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_start_bwd");
		BS_jump_start_bwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_start_bwd", Classes.FObjectProperty);
		BS_jump_loop_fwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_loop_fwd");
		BS_jump_loop_fwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_loop_fwd", Classes.FObjectProperty);
		BS_jump_loop_bwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_loop_bwd");
		BS_jump_loop_bwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_loop_bwd", Classes.FObjectProperty);
		BS_jump_additive_lean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_additive_lean");
		BS_jump_additive_lean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_additive_lean", Classes.FObjectProperty);
		BS_jump_additive_rot_Offset = NativeReflection.GetPropertyOffset(intPtr, "BS_jump_additive_rot");
		BS_jump_additive_rot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BS_jump_additive_rot", Classes.FObjectProperty);
		AnimJumpStart_N_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_N");
		AnimJumpStart_N_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_N", Classes.FObjectProperty);
		AnimJumpStart_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_F");
		AnimJumpStart_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_F", Classes.FObjectProperty);
		AnimJumpStart_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_L");
		AnimJumpStart_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_L", Classes.FObjectProperty);
		AnimJumpStart_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_R");
		AnimJumpStart_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_R", Classes.FObjectProperty);
		AnimJumpStart_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_B");
		AnimJumpStart_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_B", Classes.FObjectProperty);
		AnimFallStart_N_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_N");
		AnimFallStart_N_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_N", Classes.FObjectProperty);
		AnimFallStart_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_F");
		AnimFallStart_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_F", Classes.FObjectProperty);
		AnimFallStart_F_Dash_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_F_Dash");
		AnimFallStart_F_Dash_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_F_Dash", Classes.FObjectProperty);
		AnimFallStart_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_B");
		AnimFallStart_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_B", Classes.FObjectProperty);
		AnimFallStart_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_L");
		AnimFallStart_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_L", Classes.FObjectProperty);
		AnimFallStart_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_R");
		AnimFallStart_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_R", Classes.FObjectProperty);
		AnimFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallLoop");
		AnimFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallLoop", Classes.FObjectProperty);
		TriggerLandHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerLandHeight");
		TriggerLandHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerLandHeight", Classes.FFloatProperty);
		HeightDividingLine_Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightDividingLine_Low");
		HeightDividingLine_Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightDividingLine_Low", Classes.FFloatProperty);
		HeightDividingLine_Mid_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightDividingLine_Mid");
		HeightDividingLine_Mid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightDividingLine_Mid", Classes.FFloatProperty);
		Land_F_Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_F_Low");
		Land_F_Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_F_Low", Classes.FStructProperty);
		Land_F_Mid_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_F_Mid");
		Land_F_Mid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_F_Mid", Classes.FStructProperty);
		Land_F_High_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_F_High");
		Land_F_High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_F_High", Classes.FStructProperty);
		Land_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_L");
		Land_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_L", Classes.FStructProperty);
		Land_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_R");
		Land_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_R", Classes.FStructProperty);
		Land_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "Land_B");
		Land_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Land_B", Classes.FStructProperty);
		AddtiveMoveAfterJump_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_F");
		AddtiveMoveAfterJump_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_F", Classes.FObjectProperty);
		AddtiveMoveAfterJump_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_B");
		AddtiveMoveAfterJump_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_B", Classes.FObjectProperty);
		AddtiveMoveAfterJump_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_L");
		AddtiveMoveAfterJump_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_L", Classes.FObjectProperty);
		AddtiveMoveAfterJump_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_R");
		AddtiveMoveAfterJump_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_R", Classes.FObjectProperty);
		GlideJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideJump");
		GlideJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideJump", Classes.FStructProperty);
		AnimHumanoidSetting_Jump_IsValid = ((intPtr != IntPtr.Zero && CustomJumpVelocityIncrementWhenPressed_IsValid && CustomJumpVelocityIncrementWhenPressed_Locked_IsValid && BS_jump_start_fwd_IsValid && BS_jump_start_bwd_IsValid && BS_jump_loop_fwd_IsValid && BS_jump_loop_bwd_IsValid && BS_jump_additive_lean_IsValid && BS_jump_additive_rot_IsValid && AnimJumpStart_N_IsValid && AnimJumpStart_F_IsValid && AnimJumpStart_L_IsValid && AnimJumpStart_R_IsValid && AnimJumpStart_B_IsValid && AnimFallStart_N_IsValid && AnimFallStart_F_IsValid && AnimFallStart_F_Dash_IsValid && AnimFallStart_B_IsValid && AnimFallStart_L_IsValid && AnimFallStart_R_IsValid && AnimFallLoop_IsValid && TriggerLandHeight_IsValid && HeightDividingLine_Low_IsValid && HeightDividingLine_Mid_IsValid && Land_F_Low_IsValid && Land_F_Mid_IsValid && Land_F_High_IsValid && Land_L_IsValid && Land_R_IsValid && Land_B_IsValid && AddtiveMoveAfterJump_F_IsValid && AddtiveMoveAfterJump_B_IsValid && AddtiveMoveAfterJump_L_IsValid && AddtiveMoveAfterJump_R_IsValid && GlideJump_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Jump", (byte)AnimHumanoidSetting_Jump_IsValid != 0);
	}

	static FAnimHumanoidSetting_Jump()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Jump)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Jump));
	}
}
