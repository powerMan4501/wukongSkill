using System;
using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_AttrContainer
{
	float GetFloatValue(EBGUAttrFloat AttrID);

	float GetFloatValMin(EBGUAttrFloat AttrID);

	float GetFloatValMax(EBGUAttrFloat AttrID);

	void BindOneValueChanged(Action<int, float, float> ActionChange);

	bool GetAttrSnapShot(out FAttrSnapShot OutAttrSnapShot);
}
