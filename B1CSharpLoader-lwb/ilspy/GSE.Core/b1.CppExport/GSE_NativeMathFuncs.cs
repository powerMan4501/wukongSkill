using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_NativeMathFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate bool Del_RandomBool();

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_InverseTransformLocation(FTransform T, FVector Location);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_InverseTransformDirection(FTransform T, FVector Direction);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_TransformLocation(FTransform T, FVector Location);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_TransformRotation(FTransform T, FRotator Rotation);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_MakeRotFromX(FVector X);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_FindLookAtRotation(FVector Start, FVector Target);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_MakeRotFromZ(FVector Z);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_RInterpTo_Constant(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed);

	[MonoNativeFunctionWrapper]
	public delegate double Del_NormalizeAxis_CPP(float Angle);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_RandomRotator();

	[MonoNativeFunctionWrapper]
	public delegate double Del_ClampAxis_CPP(float Angle);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_NormalizedDeltaRotator(FRotator A, FRotator B);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_Conv_VectorToRotator(FVector InVec);

	[MonoNativeFunctionWrapper]
	public delegate double Del_DotProduct2D_CPP(FVector2D A, FVector2D B);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_CrossProduct(FVector A, FVector B);

	[MonoNativeFunctionWrapper]
	public delegate double Del_DegAcos_CPP(double A);

	[MonoNativeFunctionWrapper]
	public delegate double Del_RandomFloatInRange_CPP(double Min, double Max);

	[MonoNativeFunctionWrapper]
	public delegate int Del_RandomIntInRange(int Min, int Max);

	[MonoNativeFunctionWrapper]
	public delegate int Del_FFloor(float A);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_Normal(FVector A);

	[MonoNativeFunctionWrapper]
	public delegate double Del_FClamp_CPP(float V, float A, float B);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_InverseTransformRotation(FTransform T, FRotator Rotation);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_GetForwardVector(FRotator InRot);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_GetRightVector(FRotator InRot);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_MakeRotFromYZ(FVector Y, FVector Z);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_RotateAngleAxis(FVector InVect, float AngleDeg, FVector Axis);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_MakeRotFromXZ(FVector X, FVector Z);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_TransformDirection(FTransform T, FVector Direction);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_ProjectPointontoPlane(FVector Point, FVector PlaneBase, FVector PlaneNormal);

	[MonoNativeFunctionWrapper]
	public delegate FMatrix Del_TransformToMatrix(FTransform T);

	[MonoNativeFunctionWrapper]
	public delegate FQuat Del_MakeFromEuler(FVector Euler);

	static GSE_NativeMathFuncs()
	{
		Type typeFromHandle = typeof(MathLib);
		Dictionary<string, FIntPtr> mathFuncAsMap = UGSE_CppExport.GetMathFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (mathFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
