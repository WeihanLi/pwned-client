﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

using HaveIBeenPwned.Client.Abstractions;
using Xunit;

namespace HaveIBeenPwned.ClientTests.Models;

public class PwnedPasswordTests
{
    [
        Theory,
        InlineData(null, true),
        InlineData("", true),
        InlineData("   ", false),
        InlineData("someValue", false)
    ]
    public void PwnedPassword_Returns_CorrectValidityState_WhenConstructed(string value, bool expected)
    {
        PwnedPassword pwnedPassword = new(value);
        Assert.Equal(expected, pwnedPassword.IsInvalid());
    }
}
