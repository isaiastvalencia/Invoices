using System;

namespace DEMO09.Types.Exceptions
{
    [Serializable]
    public class TypeValidationException : BusinessException
    {
        const string TypeValidationExceptionMessage = "Han ocurrido varios errores de validación";

        public TypeValidationException() : base(TypeValidationExceptionMessage) { }
        public TypeValidationException(Exception inner) : base(TypeValidationExceptionMessage, inner) { }
        protected TypeValidationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
