using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrossComponentInterop
{
    public static class EventDispatcher
    {
        private static Dictionary<string, Action<object>> _actions;
        static EventDispatcher()
        {
            _actions = new Dictionary<string, Action<object>>();
        }

        public static void AddAction(string key, Action<object> action)
        {
            if (!_actions.ContainsKey(key))
            {
                _actions.Add(key, action);
            }
            else
            {
                throw new Exception($"event key{key} has existed");
            }
        }

        public static void RemoveAction(string key)
        {
            if (_actions.ContainsKey(key))
            {
                _actions.Remove(key);
            }
        }

        public static void Dispatch(string key, object value)
        {
            Console.WriteLine("Dispatch");
            Console.WriteLine(string.Join(",", _actions.Keys));
            if (_actions.ContainsKey(key))
            {
                var act = _actions[key];
                act.Invoke(value);
            }

        }
    }
}
