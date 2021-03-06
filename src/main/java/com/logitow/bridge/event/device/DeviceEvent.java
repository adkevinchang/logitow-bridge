package com.logitow.bridge.event.device;

import com.logitow.bridge.communication.Device;
import com.logitow.bridge.event.Event;

/**
 * Event concerning a device.
 */
public abstract class DeviceEvent extends Event {
    public Device device;

    /**
     * Constructs a device event given device.
     * @param device
     */
    public DeviceEvent(Device device) {
        this.device = device;
    }
}
