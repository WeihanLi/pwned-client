﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace HaveIBeenPwned.Client
{
    public interface IPwnedClient : IPwnedBreachesClient, IPwnedPastesClient, IPwnedPasswordsClient
    {
    }
}
