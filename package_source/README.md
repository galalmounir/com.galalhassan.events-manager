# Events Manager System

## Overview
The events manager is a system to streamline messaging between different components in Unity.

## Usage Instructions
There are two different parts to using the events manager. Triggering an event, and Listening to an event.

### Triggering an event
To trigger an event, a GameEvent asset needs to exist first.
- To create a GameEvent asset, right-click anywhere inside your `Assets` folder then choose `Create->Events->Game Event`
- Rename the newly created asset to reflect the event name required.

Once the GameEvent asset is created, you can trigger the event anywhere in your code-base by calling the following function:
```c#
EventsManager.RaiseEvent(string event_name, EventParameters params);
```
Triggered events can carry a payload. The `EventParameter` class currently supports an `int` and `GameObject` payloads.

To trigger an event for level 5 started, an example can be as follows:
```c#
var eventParameters = new EventParameters(5, gameObject);
EventsManager.RaiseEvent("LEVEL_STARTED", eventPayload);
```

### Listening on an event
To listen to an event, attach the `EventListener` script to any `GameObject` and assign the event(s) to listen to.
You will also need to add some actions to take place once the event is triggered.

## Limitations
- The event manager currently only supports `int` and `GameObject` payloads, however, will support more types in the future.
- Listening on events is currently only supported using the editor.

## References
This package is based on the work of [Ryan Hipple](https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEvent.cs) for Unite 2017.

## Samples
There is a `Usage Example` demo scene that illustrates how to use the package.

## Document revision history
|Date|Reason|
|---|---|
|September 1, 2021|Document created. Matches package version 0.0.1|