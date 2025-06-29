using System.Collections.Generic;
using System.Linq;
using BtlB1;

namespace b1;

public class FAttrSnapShot
{
	public List<float> FloatAttrs { get; }

	public FUStAttrCopyConfigDesc AttrCopyConfigDesc { get; set; }

	public FAttrSnapShot(IEnumerable<float> InFloatAttrs)
	{
		FloatAttrs = InFloatAttrs.ToList();
	}
}
