using System;
using System.Runtime.Serialization;

namespace cats.Controllers
{
  [Serializable]
  internal class ThisIsCat : Exception
  {
    public ThisIsCat()
    {
    }

    public ThisIsCat(string message) : base(message)
    {
    }

    public ThisIsCat(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected ThisIsCat(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}