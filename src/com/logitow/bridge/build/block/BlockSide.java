package com.logitow.bridge.build.block;

import java.util.HashMap;
import java.util.Map;

/**
 * Block side numbers.
 */
public enum BlockSide {
    TOP(0), //TODO: Change values to appropriate ones.
    BOTTOM(1),
    LEFT(2),
    RIGHT(3),
    FRONT(4),
    BACK(5);

    //Logitow callback side value.
    private final int sideValue;

    private static Map<Integer, BlockSide> map = new HashMap<>();

    static {
        for (BlockSide side : BlockSide.values()) {
            map.put(side.sideValue, side);
        }
    }

    BlockSide(final int leg) { sideValue = leg; }

    public static BlockSide valueOf(int sideValue) {
        return map.get(sideValue);
    }

    public int getValue() {
        return sideValue;
    }
}
