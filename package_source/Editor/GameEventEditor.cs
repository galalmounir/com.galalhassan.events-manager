using UnityEditor;
using UnityEngine;

namespace GalalHassan.EventsManager.Editor
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var gameEvent = target as GameEvent;
            
            if (GUILayout.Button("Raise"))
                gameEvent.Raise(new EventParameters());
        }
    }
}