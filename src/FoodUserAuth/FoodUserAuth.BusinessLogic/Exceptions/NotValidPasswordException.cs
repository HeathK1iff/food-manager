﻿using System.Runtime.Serialization;

namespace FoodUserAuth.BusinessLogic.Exceptions;

public class NotValidPasswordException : Exception
{
    public NotValidPasswordException()
    {
    }

    public NotValidPasswordException(string message) : base(message)
    {
    }

    public NotValidPasswordException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NotValidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
