using System;
using System.Collections.Generic;
using System.Linq;

namespace EventDrivenFramework.Core
{
    public sealed class BaseMediator : IMediator
    {
        private readonly List<IReceivable> _receivables = new List<IReceivable>();
        
        public void Add(IReceivable receivable)
        {
            if (!_receivables.Contains(receivable))
                _receivables.Add(receivable);
        }

        public void Broadcast(IReceivable receivable, EventArgs eventArgs)
        {
            foreach (var otherReceivable in _receivables.Where(otherReceivable => otherReceivable != receivable))
                otherReceivable.Receive(eventArgs);
        }
    }
}