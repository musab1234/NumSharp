﻿using System;

namespace NumSharp.Backends
{
    public partial class DefaultEngine
    {
        public override NDArray Subtract(in NDArray lhs, in NDArray rhs)
        {
            switch (lhs.GetTypeCode)
            {
#if _REGEN
	            %foreach supported_dtypes,supported_dtypes_lowercase%
	            case NPTypeCode.#1: return Subtract#1(lhs, rhs);
	            %
	            default:
		            throw new NotSupportedException();
#else
	            case NPTypeCode.Boolean: return SubtractBoolean(lhs, rhs);
	            case NPTypeCode.Byte: return SubtractByte(lhs, rhs);
	            case NPTypeCode.Int16: return SubtractInt16(lhs, rhs);
	            case NPTypeCode.UInt16: return SubtractUInt16(lhs, rhs);
	            case NPTypeCode.Int32: return SubtractInt32(lhs, rhs);
	            case NPTypeCode.UInt32: return SubtractUInt32(lhs, rhs);
	            case NPTypeCode.Int64: return SubtractInt64(lhs, rhs);
	            case NPTypeCode.UInt64: return SubtractUInt64(lhs, rhs);
	            case NPTypeCode.Char: return SubtractChar(lhs, rhs);
	            case NPTypeCode.Double: return SubtractDouble(lhs, rhs);
	            case NPTypeCode.Single: return SubtractSingle(lhs, rhs);
	            case NPTypeCode.Decimal: return SubtractDecimal(lhs, rhs);
	            default:
		            throw new NotSupportedException();
#endif
            }
        }
    }
}
