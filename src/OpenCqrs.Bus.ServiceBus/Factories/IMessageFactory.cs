﻿using Microsoft.Azure.ServiceBus;

namespace OpenCqrs.Bus.ServiceBus.Factories
{
    public interface IMessageFactory
    {
        Message CreateMessage<TMessage>(TMessage message) where TMessage : IBusMessage;
    }
}
