package com.logitow.bridge.event;

import java.util.ArrayList;
import java.util.HashMap;

/**
 * Manages the events generated by the application.
 */

public class EventManager {
    /**
     * List of all the registered event handlers.
     */
    public static HashMap<Class, ArrayList<EventHandler>> eventHandlers = new HashMap<>();

    private static org.apache.logging.log4j.Logger logger = org.apache.logging.log4j.LogManager.getLogger(EventManager.class);

    /**
     * Registers an event.
     * @param eventType
     */
    public static void registerEvent(Class eventType) {
        if (!eventHandlers.containsKey(eventType)) {
            System.out.println("Registered event type " + eventType.toString());
            eventHandlers.put(eventType, new ArrayList<>());
        } else {
            System.out.println("Event type " + eventType.toString() + " already registered!");
        }
    }

    /**
     * Registers an event handler.
     * @param handler
     * @param eventType
     */
    public static void registerHandler(EventHandler handler, Class eventType) {
        if(!eventHandlers.containsKey(eventType)) {
            registerEvent(eventType);
        }

        eventHandlers.get(eventType).add(handler);
    }

    /**
     * Unregisters an event handler.
     * @param handler
     * @param eventType
     */
    public static void unregisterHandler(EventHandler handler, Class eventType) {
        if(!eventHandlers.containsKey(eventType)) {
            registerEvent(eventType);
            return;
        }
        eventHandlers.get(eventType).remove(handler);
    }

    /**
     * Calls the specified event.
     * @param event
     */
    public static void callEvent(Event event) {
        event.onCalled();
        for (EventHandler handler :
            eventHandlers.get(event.getClass()))
        {
            handler.onEventCalled(event);
        }
    }
}
