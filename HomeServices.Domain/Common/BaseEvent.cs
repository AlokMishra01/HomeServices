using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Domain.Common
{
    internal class BaseEvent : INotification
    {
        public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
    }
}
