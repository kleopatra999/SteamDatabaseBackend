﻿/*
 * Copyright (c) 2013-2015, SteamDB. All rights reserved.
 * Use of this source code is governed by a BSD-style license that can be
 * found in the LICENSE file.
 */
using SteamKit2;

namespace SteamDatabaseBackend
{
    public abstract class SteamHandler
    {
        protected SteamHandler(CallbackManager manager)
        {
            // This is just an empty class, steamkit callbacks extend this
        }
    }
}