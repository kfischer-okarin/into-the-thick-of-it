﻿/* Copyright (c) 2016 Kevin Fischer
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

namespace StateMachine.Editor {

    public static class StateMachineConstants {

        public static string NEW_STATE_NAME = "NewState";

        public static class UndoCommands {
            public static string CREATE_STATE = "Create State";
            public static string DELETE_STATE = "Delete State";
            public static string UPDATE_STATE_POSITION = "Update State Position";
        }

        public static int STATE_WIDTH = 150;
        public static int STATE_HEIGHT = 50;

        public static string PREF_VISIBLE = "StateMachineEditorVisible";
        public static string PREF_INSTANCE = "StateMachineEditorInstance";

        public static int CANVAS_WIDTH = 2000;
        public static int CANVAS_HEIGHT = 2000;

        public static string SKIN_PATH = @"EditorSkin";

        public static int NOTHING_SELECTED = -1;
    }

}