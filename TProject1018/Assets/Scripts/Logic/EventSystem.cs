using System;
using System.Collections.Generic;

public class EventSystem : Singleton<EventSystem>
{
    private Dictionary<Type, IEventDispatcher> _dispatchers = new Dictionary<Type, IEventDispatcher>();

    public void RegistEventHandler<T>(IEventHandler<T> handle) where T : IEvent
    {
        var type = typeof(EventDispatcher<T>);
        if (!_dispatchers.TryGetValue(type, out var dispatcher))
        {
            dispatcher = new EventDispatcher<T>();
        }
        ((EventDispatcher<T>)dispatcher).RegistEventHandler(handle);
        _dispatchers[type] = dispatcher;
    }

    public void SendEvent<T>(T evt) where T : IEvent
    {
        var type = typeof(EventDispatcher<T>);
        if (_dispatchers.TryGetValue(type, out var dispatcher))
        {
            var impl = (EventDispatcher<T>)dispatcher;
            impl.SendEvent(evt);
        }
    }
}