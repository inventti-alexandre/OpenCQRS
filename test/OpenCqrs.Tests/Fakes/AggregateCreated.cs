﻿using System;
using OpenCqrs.Bus;
using OpenCqrs.Domain;

namespace OpenCqrs.Tests.Fakes
{
    public class AggregateCreated : DomainEvent, IBusQueueMessage
    {
        public DateTime? ScheduledEnqueueTimeUtc { get; set; }
        public string QueueName { get; set; } = "queue-name";
    }
}
