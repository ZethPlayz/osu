﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Overlays.Dashboard
{
    public class DashboardOverlayHeader : TabControlOverlayHeader<DashboardOverlayTabs>
    {
        protected override OverlayTitle CreateTitle() => new DashboardTitle();

        private class DashboardTitle : OverlayTitle
        {
            public DashboardTitle()
            {
                Title = "dashboard";
                Description = "View your friends and other information";
                IconTexture = "Icons/Hexacons/social";
            }
        }
    }

    public enum DashboardOverlayTabs
    {
        Friends
    }
}
