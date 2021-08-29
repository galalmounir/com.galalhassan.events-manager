using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GalalHassan.EventsManager
{
    public static class EventsManager
    {
        private static Dictionary<string, GameEvent> _gameEvents = new Dictionary<string, GameEvent>();

        private static bool _initialized = false;
        
        public static void Init()
        {
            if (_initialized) return;
            
            _gameEvents ??= new Dictionary<string, GameEvent>();
            
            GetAllGameEvents();

            _initialized = true;
        }

        public static void RaiseEvent(string eventName, EventParameters parameters)
        {
            if (_gameEvents.TryGetValue(eventName, out var @event))
            {
                @event.Raise(parameters);
                return;
            }

            Debug.LogError($"{eventName} event does not exist.");
        }
        
        private static void GetAllGameEvents()
        {
            var guids = AssetDatabase.FindAssets($"t:{nameof(GameEvent)}");
            foreach (var guid in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                var gameEvent = AssetDatabase.LoadAssetAtPath<GameEvent>(path);
                _gameEvents.Add(gameEvent.name, gameEvent);
            }
        }
    }
}