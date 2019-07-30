using System;
using Convey.CQRS.Events;

namespace Pacco.Services.Availability.Application.Events.Rejected
{
    public class ReleaseResourceRejected : IRejectedEvent
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }
        public string Reason { get; }
        public string Code { get; }

        public ReleaseResourceRejected(Guid resourceId, DateTime dateTime, string reason, string code)
        {
            ResourceId = resourceId;
            DateTime = dateTime;
            Reason = reason;
            Code = code;
        }
    }
}