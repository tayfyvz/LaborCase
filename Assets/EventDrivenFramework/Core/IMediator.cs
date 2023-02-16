using System;

namespace EventDrivenFramework.Core
{
    public interface IMediator
    {
        void Add(IReceivable receivable);

        void Broadcast(IReceivable receivable, EventArgs eventArgs);
    }
}